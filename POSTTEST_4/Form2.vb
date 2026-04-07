Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menampilkan data ke Label sesuai permintaan tugas
        lblNama.Text = DataModule.Nama
        lblID.Text = "ID: " & DataModule.ID
        lblKomunitas.Text = "Komunitas " & DataModule.Komunitas
        lblEmail.Text = "Email: " & DataModule.Email
        lblNoTelp.Text = "Telp: " & DataModule.NoTelp
        lblAlamat.Text = "Alamat: " & DataModule.Alamat

        ' Menampilkan Hobi/Aktivitas
        lblHobi.Text = "Hobi: " & DataModule.Hobi

        ' Menampilkan Foto Profil
        ' Gunakan ImageLocation agar lebih aman jika file sedang digunakan proses lain
        If Not String.IsNullOrEmpty(DataModule.Foto) AndAlso IO.File.Exists(DataModule.Foto) Then
            PictureBox1.ImageLocation = DataModule.Foto
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom ' Biar foto tidak gepeng
        End If
    End Sub
End Class