
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblTLahir.Text = DataModule.Tglahir
        lblJK.Text = DataModule.JK
        lblHobi.Text = DataModule.Hobi
        lblAlamat.Text = DataModule.Alamat
        PictureBox1.Image = Image.FromFile(DataModule.Foto)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
