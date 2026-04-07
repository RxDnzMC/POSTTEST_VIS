Module ValidationModule

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    'VALIDASI RADIO BUTTON (Minimal pilih satu)
    Public Function ValidasiRadioButton(radioButtons() As RadioButton, ep As ErrorProvider, pesan As String) As Boolean
        For Each rb As RadioButton In radioButtons
            If rb.Checked Then
                For Each r In radioButtons : ep.SetError(r, "") : Next
                Return True
            End If
        Next
        ep.SetError(radioButtons(0), pesan)
        Return False
    End Function

    'VALIDASI CHECKBOX (Minimal pilih satu)
    Public Function ValidasiCheckBox(checkBoxes() As CheckBox, ep As ErrorProvider, pesan As String) As Boolean
        For Each cb As CheckBox In checkBoxes
            If cb.Checked Then
                For Each c In checkBoxes : ep.SetError(c, "") : Next
                Return True
            End If
        Next
        ep.SetError(checkBoxes(0), pesan)
        Return False
    End Function

    'VALIDASI PICTUREBOX (Gambar tidak boleh kosong)
    Public Function ValidasiPictureBox(ep As ErrorProvider, pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            ep.SetError(pic, pesan)
            Return False
        Else
            ep.SetError(pic, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiSemuaInput(
        ep As ErrorProvider,
        txtNama As TextBox,
        txtID As TextBox,
        txtEmail As TextBox,
        mtbNoHP As MaskedTextBox,
        txtAlamat As TextBox,
        cboKomunitas As ComboBox,
        arrayJK() As RadioButton,
        arrayPeran() As RadioButton,
        arrayHobi() As CheckBox,
        picProfil As PictureBox
    ) As Boolean

        ' Jalankan semua fungsi validasi satu per satu
        Dim vNama As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim vID As Boolean = ValidasiTextBox(ep, txtID, "ID tidak boleh kosong")
        Dim vEmail As Boolean = ValidasiTextBox(ep, txtEmail, "Email tidak boleh kosong")
        Dim vNoHP As Boolean = ValidasiMaskedTextBox(ep, mtbNoHP, "Nomor HP belum lengkap")
        Dim vAlamat As Boolean = ValidasiTextBox(ep, txtAlamat, "Alamat tidak boleh kosong")
        Dim vKomunitas As Boolean = ValidasiComboBox(ep, cboKomunitas, "Pilih komunitas anda")

        ' Validasi Group Kontrol
        Dim vJK As Boolean = ValidasiRadioButton(arrayJK, ep, "Pilih jenis kelamin")
        Dim vPeran As Boolean = ValidasiRadioButton(arrayPeran, ep, "Pilih peran anda")
        Dim vHobi As Boolean = ValidasiCheckBox(arrayHobi, ep, "Pilih minimal 1 hobi")

        ' Validasi PictureBox
        Dim vFoto As Boolean = ValidasiPictureBox(ep, picProfil, "Foto profil harus diunggah")

        ' Return True hanya jika SEMUA variabel di atas bernilai True
        Return vNama And vID And vEmail And vNoHP And vAlamat And vKomunitas And vJK And vPeran And vHobi And vFoto
    End Function

End Module