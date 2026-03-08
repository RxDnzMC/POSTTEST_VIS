Public Class Form1
    Private Sub ListLoad()
        rtbBuku.Clear()
        Dim daftarBukuSalinan(,) As String = ModulDataBuku.SalinArray()
        Dim JumlahBuku As Integer = ModulDataBuku.ambilJumlahBuku()
        For i As Integer = 0 To JumlahBuku - 1
            rtbBuku.AppendText(daftarBukuSalinan(i, 0) & vbTab & vbTab & "(" & daftarBukuSalinan(i, 1) & ")" & vbCrLf)
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If tbJudul.Text = "" Or tbGenre.Text = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong.")
            Return
        End If
        ModulDataBuku.TambahBuku(tbJudul.Text, tbGenre.Text)
        ListLoad()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If tbHapusJudul.Text = "" Then
            MessageBox.Show("Judul Tidak Boleh Kosong.")
            Return
        End If
        ModulDataBuku.HapusBuku(tbHapusJudul.Text)
        ListLoad()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
