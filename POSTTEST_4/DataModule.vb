Imports System.Text
Imports System.IO

Module DataModule
    Public Nama, ID, Email, Komunitas, Umur, JK, Hobi, Foto, Peran, NoTelp, Alamat As String
    Public Tglahir As Date

    Public Function BuatIsiFile(
        nama As String,
        id As String,
        email As String,
        telp As String,
        alamat As String,
        komunitas As String,
        jk As String,
        peran As String,
        hobi As String,
        tglLahir As String,
        fotoPath As String
    ) As String
        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("ID=" & id.Trim())
        sb.AppendLine("Email=" & email.Trim())
        sb.AppendLine("NoTelp=" & telp)
        sb.AppendLine("Alamat=" & alamat.Trim())
        sb.AppendLine("Komunitas=" & komunitas)
        sb.AppendLine("JK=" & jk)
        sb.AppendLine("Peran=" & peran)
        sb.AppendLine("Hobi=" & hobi) ' Simpan hobi yang sudah digabung (koma)
        sb.AppendLine("TglLahir=" & tglLahir)
        sb.AppendLine("Foto=" & fotoPath)

        Return sb.ToString()
    End Function
    Public Function GetSelectedRadioButton(grupRadio() As RadioButton) As String
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function
    Public Function GetSelectedCheckBox(grupCheck() As CheckBox) As String
        Dim selectedItems As New List(Of String)
        For Each cb As CheckBox In grupCheck
            If cb.Checked Then
                selectedItems.Add(cb.Text)
            End If
        Next
        Return String.Join(", ", selectedItems)
    End Function

    Public Function GetSelectedComboBox(cbo As ComboBox) As String
        ' Cek apakah ada item yang dipilih (Index -1 berarti kosong)
        If cbo.SelectedIndex <> -1 Then
            Return cbo.Text
        Else
            Return ""
        End If
    End Function

    Public Sub SetSelectedRadioButton(grup() As RadioButton, targetText As String)
        For Each rb In grup
            If rb.Text = targetText Then
                rb.Checked = True
                Exit For ' Keluar loop jika sudah ketemu
            End If
        Next
    End Sub

    ' Mengatur CheckBox mana saja yang harus Checked (untuk Hobi yang dipisah koma)
    Public Sub SetSelectedCheckBox(grup() As CheckBox, hobiList As String)
        ' Memecah string "Gaming, Coding" menjadi array {"Gaming", "Coding"}
        Dim daftar() As String = hobiList.Split(New String() {", "}, StringSplitOptions.RemoveEmptyEntries)

        ' Reset semua dulu jadi False
        For Each cb In grup : cb.Checked = False : Next

        ' Cek satu-satu, jika hobi ada di daftar, maka centang
        For Each cb In grup
            If daftar.Contains(cb.Text) Then
                cb.Checked = True
            End If
        Next
    End Sub


    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data"
        sfd.FileName = namaFileDefault

        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi)
            Return True
        End If

        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim barisFile() As String = File.ReadAllLines(ofd.FileName)

        For Each baris As String In barisFile
            If String.IsNullOrWhiteSpace(baris) Then Continue For

            Dim bagian() As String = baris.Split(New Char() {"="c}, 2)

            If bagian.Length = 2 Then
                hasil(bagian(0).Trim()) = bagian(1).Trim()
            End If
        Next

        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If

        Return ""
    End Function


End Module