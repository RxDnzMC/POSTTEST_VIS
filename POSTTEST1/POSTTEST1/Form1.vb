Public Class Form1
    Dim inputNilai As Double
    Dim TotalNilai As Double
    Dim Counter As Integer
    Dim RataRata As Double
    Dim BoxOutput As Double
    Private Sub txtIPINPUT_Enter(sender As Object, e As EventArgs) Handles txtIPINPUT.Enter

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtIPINPUT.Text = "" Or txtIPINPUT.Text > 4 Then
            MessageBox.Show("Masukkan Nilai IPK")
        Else
            inputNilai = txtIPINPUT.Text
            TotalNilai = TotalNilai + inputNilai
            Counter = Counter + 1
            RataRata = TotalNilai / Counter
            txtOUTPUTIP.Text = String.Format("{0:0.00}", RataRata)
            BoxOutput = CDbl(txtOUTPUTIP.Text)
            If BoxOutput >= 3.01 Then
                txtHasilIP.Text = "Sangat Memuaskan"
            ElseIf BoxOutput < 3.01 And BoxOutput > 2.77 Then
                txtHasilIP.Text = "Memuaskan"
            ElseIf BoxOutput < 2.76 And txtOUTPUTIP.Text > 1.99 Then
                txtHasilIP.Text = "Cukup"
            Else
                txtHasilIP.Text = "Kurang"
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtIPINPUT.Text = 0
        TotalNilai = 0
        Counter = 0
        txtHasilIP.Text = ""
        txtOUTPUTIP.Text = ""
    End Sub
End Class
