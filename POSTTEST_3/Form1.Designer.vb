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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        txtAlamat = New TextBox()
        btnCetak = New Button()
        btnBrowse = New Button()
        grupHobi = New GroupBox()
        cbGaming = New CheckBox()
        cbCoding = New CheckBox()
        cbTravelling = New CheckBox()
        cbDrawing = New CheckBox()
        cbWriting = New CheckBox()
        cbFishing = New CheckBox()
        cbReading = New CheckBox()
        cbExercise = New CheckBox()
        cbSinging = New CheckBox()
        cbDancing = New CheckBox()
        grupJK = New GroupBox()
        rbCowo = New RadioButton()
        rbCewe = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtTelp = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        picProfil = New PictureBox()
        Panel1.SuspendLayout()
        grupHobi.SuspendLayout()
        grupJK.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.poeblack
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(txtAlamat)
        Panel1.Controls.Add(btnCetak)
        Panel1.Controls.Add(btnBrowse)
        Panel1.Controls.Add(grupHobi)
        Panel1.Controls.Add(grupJK)
        Panel1.Controls.Add(dtpLahir)
        Panel1.Controls.Add(txtTelp)
        Panel1.Controls.Add(txtUmur)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(picProfil)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 454)
        Panel1.TabIndex = 0
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(472, 191)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(303, 23)
        txtAlamat.TabIndex = 0
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(268, 420)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(507, 23)
        btnCetak.TabIndex = 1
        btnCetak.Text = "CETAK KARTU"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(66, 402)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(83, 24)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse"
        ' 
        ' grupHobi
        ' 
        grupHobi.Controls.Add(cbGaming)
        grupHobi.Controls.Add(cbCoding)
        grupHobi.Controls.Add(cbTravelling)
        grupHobi.Controls.Add(cbDrawing)
        grupHobi.Controls.Add(cbWriting)
        grupHobi.Controls.Add(cbFishing)
        grupHobi.Controls.Add(cbReading)
        grupHobi.Controls.Add(cbExercise)
        grupHobi.Controls.Add(cbSinging)
        grupHobi.Controls.Add(cbDancing)
        grupHobi.Location = New Point(516, 260)
        grupHobi.Name = "grupHobi"
        grupHobi.Size = New Size(259, 154)
        grupHobi.TabIndex = 3
        grupHobi.TabStop = False
        grupHobi.Text = "Hobby"
        ' 
        ' cbGaming
        ' 
        cbGaming.Location = New Point(6, 23)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(104, 24)
        cbGaming.TabIndex = 0
        cbGaming.Text = "Gaming"
        ' 
        ' cbCoding
        ' 
        cbCoding.Location = New Point(6, 48)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(104, 24)
        cbCoding.TabIndex = 1
        cbCoding.Text = "Coding"
        ' 
        ' cbTravelling
        ' 
        cbTravelling.Location = New Point(6, 73)
        cbTravelling.Name = "cbTravelling"
        cbTravelling.Size = New Size(104, 24)
        cbTravelling.TabIndex = 2
        cbTravelling.Text = "Travelling"
        ' 
        ' cbDrawing
        ' 
        cbDrawing.Location = New Point(6, 98)
        cbDrawing.Name = "cbDrawing"
        cbDrawing.Size = New Size(104, 24)
        cbDrawing.TabIndex = 3
        cbDrawing.Text = "Drawing"
        ' 
        ' cbWriting
        ' 
        cbWriting.Location = New Point(6, 123)
        cbWriting.Name = "cbWriting"
        cbWriting.Size = New Size(104, 24)
        cbWriting.TabIndex = 4
        cbWriting.Text = "Writing"
        ' 
        ' cbFishing
        ' 
        cbFishing.Location = New Point(147, 22)
        cbFishing.Name = "cbFishing"
        cbFishing.Size = New Size(104, 24)
        cbFishing.TabIndex = 5
        cbFishing.Text = "Fishing"
        ' 
        ' cbReading
        ' 
        cbReading.Location = New Point(147, 47)
        cbReading.Name = "cbReading"
        cbReading.Size = New Size(104, 24)
        cbReading.TabIndex = 6
        cbReading.Text = "Reading"
        ' 
        ' cbExercise
        ' 
        cbExercise.Location = New Point(147, 72)
        cbExercise.Name = "cbExercise"
        cbExercise.Size = New Size(104, 24)
        cbExercise.TabIndex = 7
        cbExercise.Text = "Exercise"
        ' 
        ' cbSinging
        ' 
        cbSinging.Location = New Point(147, 98)
        cbSinging.Name = "cbSinging"
        cbSinging.Size = New Size(104, 24)
        cbSinging.TabIndex = 8
        cbSinging.Text = "Singing"
        ' 
        ' cbDancing
        ' 
        cbDancing.Location = New Point(147, 123)
        cbDancing.Name = "cbDancing"
        cbDancing.Size = New Size(104, 24)
        cbDancing.TabIndex = 9
        cbDancing.Text = "Dancing"
        ' 
        ' grupJK
        ' 
        grupJK.Controls.Add(rbCowo)
        grupJK.Controls.Add(rbCewe)
        grupJK.Location = New Point(268, 260)
        grupJK.Name = "grupJK"
        grupJK.Size = New Size(224, 154)
        grupJK.TabIndex = 4
        grupJK.TabStop = False
        grupJK.Text = "Jenis Kelamin"
        ' 
        ' rbCowo
        ' 
        rbCowo.Location = New Point(6, 22)
        rbCowo.Name = "rbCowo"
        rbCowo.Size = New Size(104, 24)
        rbCowo.TabIndex = 0
        rbCowo.Text = "Laki - Laki"
        ' 
        ' rbCewe
        ' 
        rbCewe.Location = New Point(6, 47)
        rbCewe.Name = "rbCewe"
        rbCewe.Size = New Size(104, 24)
        rbCewe.TabIndex = 1
        rbCewe.Text = "Perempuan"
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(474, 120)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(301, 23)
        dtpLahir.TabIndex = 5
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(474, 157)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(303, 23)
        txtTelp.TabIndex = 6
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(474, 82)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(301, 23)
        txtUmur.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(474, 47)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(301, 23)
        txtNama.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.Location = New Point(274, 194)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 9
        Label5.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(274, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 10
        Label4.Text = "No Telepon"
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(274, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 11
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(274, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 12
        Label2.Text = "Umur"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(272, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 13
        Label1.Text = "Nama"
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = SystemColors.ButtonHighlight
        picProfil.Location = New Point(14, 37)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(219, 348)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 14
        picProfil.TabStop = False
        ' 
        ' Form1
        ' 
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        grupHobi.ResumeLayout(False)
        grupJK.ResumeLayout(False)
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents grupJK As GroupBox
    Friend WithEvents rbCowo As RadioButton
    Friend WithEvents rbCewe As RadioButton
    Friend WithEvents grupHobi As GroupBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbTravelling As CheckBox
    Friend WithEvents cbDrawing As CheckBox
    Friend WithEvents cbWriting As CheckBox
    Friend WithEvents cbFishing As CheckBox
    Friend WithEvents cbReading As CheckBox
    Friend WithEvents cbExercise As CheckBox
    Friend WithEvents cbSinging As CheckBox
    Friend WithEvents cbDancing As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNIM As TextBox

End Class
