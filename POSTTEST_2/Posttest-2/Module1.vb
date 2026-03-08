Public Module ModulDataBuku
    Dim dataBuku(24, 1) As String
    Dim jumlahBuku As Integer = 0

    Public Sub TambahBuku(judul As String, penulis As String)
        If jumlahBuku < 25 Then
            dataBuku(jumlahBuku, 0) = judul
            dataBuku(jumlahBuku, 1) = penulis
            jumlahBuku += 1
        Else
            Console.WriteLine("Kapasitas buku sudah penuh.")
        End If
    End Sub

    Public Sub TampilkanBuku()
        Console.WriteLine("Daftar Buku:")
        For i As Integer = 0 To jumlahBuku - 1
            Console.WriteLine($"{i + 1}. {dataBuku(i, 0)} oleh {dataBuku(i, 1)}")
        Next
    End Sub

    Public Sub HapusBuku(Judul As String)
        Dim nilaiIndex As Integer = CariBuku(Judul)
        If nilaiIndex >= 1 And nilaiIndex <= jumlahBuku Then
            For i As Integer = nilaiIndex - 1 To jumlahBuku - 2
                dataBuku(i, 0) = dataBuku(i + 1, 0)
                dataBuku(i, 1) = dataBuku(i + 1, 1)
            Next
            dataBuku(jumlahBuku - 1, 0) = Nothing
            dataBuku(jumlahBuku - 1, 1) = Nothing
            jumlahBuku -= 1
        Else
            MessageBox.Show("Buku Tidak Ditemukan")
        End If
    End Sub

    Function CariBuku(judul As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If dataBuku(i, 0).Equals(judul, StringComparison.OrdinalIgnoreCase) Then
                Return i + 1
            End If
        Next
        Return -1 'Kalau gk ketemu
    End Function

    Function SalinArray() As String(,)
        Dim salinan(24, 1) As String
        For i As Integer = 0 To jumlahBuku - 1
            salinan(i, 0) = dataBuku(i, 0)
            salinan(i, 1) = dataBuku(i, 1)
        Next
        Return salinan
    End Function

    Function ambilJumlahBuku() As Integer
        Return jumlahBuku
    End Function
End Module

