<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tbJudul = New TextBox()
        tbGenre = New TextBox()
        tbHapusJudul = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        rtbBuku = New RichTextBox()
        Label6 = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbJudul
        ' 
        tbJudul.Location = New Point(91, 27)
        tbJudul.Name = "tbJudul"
        tbJudul.Size = New Size(123, 23)
        tbJudul.TabIndex = 0
        ' 
        ' tbGenre
        ' 
        tbGenre.Location = New Point(91, 75)
        tbGenre.Name = "tbGenre"
        tbGenre.Size = New Size(123, 23)
        tbGenre.TabIndex = 1
        ' 
        ' tbHapusJudul
        ' 
        tbHapusJudul.Location = New Point(91, 47)
        tbHapusJudul.Name = "tbHapusJudul"
        tbHapusJudul.Size = New Size(123, 23)
        tbHapusJudul.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.White
        btnTambah.Location = New Point(139, 124)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(139, 101)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 23)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Location = New Point(15, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 17)
        Label1.TabIndex = 6
        Label1.Text = "Judul"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.GhostWhite
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Location = New Point(15, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 17)
        Label2.TabIndex = 7
        Label2.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Window
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Segoe UI", 11.0F)
        Label3.ForeColor = SystemColors.MenuText
        Label3.Location = New Point(15, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 22)
        Label3.TabIndex = 8
        Label3.Text = "Judul"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumSlateBlue
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(tbGenre)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbJudul)
        Panel1.Location = New Point(74, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(257, 159)
        Panel1.TabIndex = 9
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumSlateBlue
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(tbHapusJudul)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(74, 258)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(267, 148)
        Panel2.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Location = New Point(74, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 17)
        Label4.TabIndex = 11
        Label4.Text = "Tambah Buku"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Location = New Point(74, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 12
        Label5.Text = "Hapus Buku"
        ' 
        ' rtbBuku
        ' 
        rtbBuku.BackColor = SystemColors.Highlight
        rtbBuku.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        rtbBuku.ForeColor = SystemColors.Window
        rtbBuku.Location = New Point(448, 65)
        rtbBuku.Name = "rtbBuku"
        rtbBuku.Size = New Size(295, 341)
        rtbBuku.TabIndex = 13
        rtbBuku.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Location = New Point(448, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 17)
        Label6.TabIndex = 14
        Label6.Text = "List Buku"
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImage = My.Resources.Resources.people_in_library_flat_vector_illustration_6140321
        Panel3.Controls.Add(Panel1)
        Panel3.Controls.Add(Panel2)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(rtbBuku)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(2, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(799, 450)
        Panel3.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(800, 450)
        Controls.Add(Panel3)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tbJudul As TextBox
    Friend WithEvents tbGenre As TextBox
    Friend WithEvents tbHapusJudul As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents judulBuku As DataGridViewTextBoxColumn
    Friend WithEvents genreBuku As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtJudul As Label
    Friend WithEvents rtbBuku As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel

End Class
