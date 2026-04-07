Imports System.IO
Imports System.Text

Public Class Form1
    Dim arrayHobi() As CheckBox
    Dim arrayJK() As RadioButton
    Dim arrayPeran() As RadioButton
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi sekali di sini untuk semua fungsi
        arrayHobi = {cbGaming, cbCoding, cbTravelling, cbDrawing, cbWriting,
                cbFishing, cbReading, cbExercise, cbSinging, cbDancing}
        arrayJK = {rbCowo, rbCewe}
        arrayPeran = {rbKetua, rbWakilKetua, rbAdmin, rbMember}
    End Sub


    Private Function CekData() As Boolean

        If Not ValidasiTextBox(ErrorProvider1, txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(ErrorProvider1, txtID, "ID Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(ErrorProvider1, txtEmail, "Email Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(ErrorProvider1, txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiComboBox(ErrorProvider1, cboKomunitas, "ID Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(arrayJK, ErrorProvider1, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiRadioButton(arrayPeran, ErrorProvider1, "Pilih Jenis Peran Anda") Then Return False
        If Not ValidasiCheckBox(arrayHobi, ErrorProvider1, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(ErrorProvider1, picProfil, "Gambar Tidak Boleh Kosong") Then Return False

        Return True

    End Function


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If CekData() Then

            Dim Hobi_Selected As String = GetSelectedCheckBox(arrayHobi)
            Dim peran_Selected As String = GetSelectedRadioButton(arrayPeran)
            DataModule.Nama = txtNama.Text
            DataModule.ID = txtID.Text
            DataModule.Email = txtEmail.Text
            DataModule.NoTelp = txtTelp.Text
            DataModule.Komunitas = cboKomunitas.SelectedItem.ToString()
            DataModule.Hobi = Hobi_Selected
            DataModule.Alamat = txtAlamat.Text
            DataModule.Peran = peran_Selected
            DataModule.Tglahir = dtpLahir.Value.ToShortDateString()

            Form2.Show()

        End If

    End Sub


    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        If ValidasiTextBox(ErrorProvider1, txtNama, "Nama Tidak Boleh Kosong") Then

            Dim NamaFile As String = txtNama.Text.Trim()

            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                File.Copy(openFileDialog.FileName, destinationPath, True)

                DataModule.Foto = destinationPath
                picProfil.ImageLocation = destinationPath

                MessageBox.Show("Gambar berhasil disimpan!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

    End Sub


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        Dim arrayHobi() As CheckBox = {cbGaming, cbCoding, cbTravelling, cbDrawing, cbWriting,
                                    cbFishing, cbReading, cbExercise, cbSinging, cbDancing}
        Dim arrayJK() As RadioButton = {rbCowo, rbCewe}
        Dim arrayPeran() As RadioButton = {rbKetua, rbWakilKetua, rbAdmin, rbMember}

        If Not ValidasiSemuaInput(ErrorProvider1, txtNama, txtID, txtEmail, txtTelp,
                              txtAlamat, cboKomunitas, arrayJK, arrayPeran,
                              arrayHobi, picProfil) Then

            MessageBox.Show("Mohon lengkapi semua data yang bertanda merah.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi", MessageBoxButtons.YesNo)

        If hasil = DialogResult.Yes Then
            Dim hobi_Selected As String = GetSelectedCheckBox(arrayHobi)
            Dim jk_Selected As String = GetSelectedRadioButton(arrayJK)
            Dim peran_Selected As String = GetSelectedRadioButton(arrayPeran)

            Dim isi As String = BuatIsiFile(
            txtNama.Text, txtID.Text, txtEmail.Text, txtTelp.Text, txtAlamat.Text,
            cboKomunitas.Text, jk_Selected, peran_Selected, hobi_Selected,
            dtpLahir.Value.ToShortDateString(), DataModule.Foto
        )

            If SimpanDataKeFile(SaveFileDialog1, isi, "data_kartu.txt") Then
                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub mnuBukaFile_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)
        If data Is Nothing Then Exit Sub

        ' Masukkan data kembali ke form
        txtNama.Text = AmbilNilai(data, "Nama")
        txtID.Text = AmbilNilai(data, "ID")
        txtEmail.Text = AmbilNilai(data, "Email")
        txtTelp.Text = AmbilNilai(data, "NoTelp")
        txtAlamat.Text = AmbilNilai(data, "Alamat")
        cboKomunitas.Text = AmbilNilai(data, "Komunitas")
        dtpLahir.Value = CDate(AmbilNilai(data, "TglLahir"))

        SetSelectedRadioButton(arrayJK, AmbilNilai(data, "JK"))
        SetSelectedRadioButton(arrayPeran, AmbilNilai(data, "Peran"))

        SetSelectedCheckBox(arrayHobi, AmbilNilai(data, "Hobi"))

        Dim pathFoto As String = AmbilNilai(data, "Foto")
        If File.Exists(pathFoto) Then
            picProfil.ImageLocation = pathFoto
        End If

        MessageBox.Show("Data berhasil dimuat!", "Informasi")
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub
    Private Sub LihatDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatDataToolStripMenuItem.Click
        If Not CekData() Then
            MessageBox.Show("Data belum lengkap untuk dilihat.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hobi_Selected As String = GetSelectedCheckBox(arrayHobi)
        Dim jk_Selected As String = GetSelectedRadioButton(arrayJK)
        Dim peran_Selected As String = GetSelectedRadioButton(arrayPeran)

        Dim previewData As String = BuatIsiFile(
            txtNama.Text, txtID.Text, txtEmail.Text, txtTelp.Text, txtAlamat.Text,
            cboKomunitas.Text, jk_Selected, peran_Selected, hobi_Selected,
            dtpLahir.Value.ToShortDateString(), DataModule.Foto
        )

        MessageBox.Show("PREVIEW DATA YANG AKAN DISIMPAN" & Environment.NewLine & Environment.NewLine & previewData,
                        "Lihat Data Sementara",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub
    Private Sub KeluarDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
