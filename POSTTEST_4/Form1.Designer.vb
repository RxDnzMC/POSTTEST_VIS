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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label6 = New Label()
        cboKomunitas = New ComboBox()
        txtID = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        dtpLahir = New DateTimePicker()
        grupJK = New GroupBox()
        rbCowo = New RadioButton()
        rbCewe = New RadioButton()
        TabPage2 = New TabPage()
        txtEmail = New TextBox()
        Label7 = New Label()
        txtTelp = New MaskedTextBox()
        txtAlamat = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TabPage3 = New TabPage()
        grupPeran = New GroupBox()
        rbMember = New RadioButton()
        rbAdmin = New RadioButton()
        rbWakilKetua = New RadioButton()
        rbKetua = New RadioButton()
        picProfil = New PictureBox()
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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatDataToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        Label9 = New Label()
        PictureBox2 = New PictureBox()
        Label10 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        grupJK.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        grupPeran.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        grupHobi.SuspendLayout()
        MenuStrip1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(TabControl1)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(-2, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 454)
        Panel1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(14, 27)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 412)
        TabControl1.TabIndex = 16
        ' 
        ' TabPage1
        ' 
        TabPage1.BackgroundImage = My.Resources.Resources.poeblack
        TabPage1.BackgroundImageLayout = ImageLayout.Stretch
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(cboKomunitas)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(grupJK)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 384)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.White
        Label6.Location = New Point(291, 300)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 23)
        Label6.TabIndex = 17
        Label6.Text = "Komunitas"
        ' 
        ' cboKomunitas
        ' 
        cboKomunitas.FormattingEnabled = True
        cboKomunitas.Items.AddRange(New Object() {"Star", "Simpanse", "Eclipse"})
        cboKomunitas.Location = New Point(434, 303)
        cboKomunitas.Name = "cboKomunitas"
        cboKomunitas.Size = New Size(301, 23)
        cboKomunitas.TabIndex = 16
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(434, 229)
        txtID.Name = "txtID"
        txtID.Size = New Size(301, 23)
        txtID.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.White
        Label2.Location = New Point(291, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 23)
        Label2.TabIndex = 14
        Label2.Text = "ID"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.White
        Label1.Location = New Point(291, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 13
        Label1.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.White
        Label3.Location = New Point(291, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 23)
        Label3.TabIndex = 11
        Label3.Text = "Tanggal Lahir"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(434, 193)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(301, 23)
        txtNama.TabIndex = 8
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(434, 266)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(301, 23)
        dtpLahir.TabIndex = 5
        ' 
        ' grupJK
        ' 
        grupJK.BackColor = Color.White
        grupJK.Controls.Add(rbCowo)
        grupJK.Controls.Add(rbCewe)
        grupJK.Location = New Point(19, 193)
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
        ' TabPage2
        ' 
        TabPage2.BackgroundImage = My.Resources.Resources.poeblack
        TabPage2.BackgroundImageLayout = ImageLayout.Stretch
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(PictureBox2)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(txtTelp)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 384)
        TabPage2.TabIndex = 1
        TabPage2.Text = "kontak dan Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(346, 172)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(303, 23)
        txtEmail.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.White
        Label7.Location = New Point(148, 172)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 23)
        Label7.TabIndex = 12
        Label7.Text = "Email"
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(346, 204)
        txtTelp.Mask = "0000-0000-0000"
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(303, 23)
        txtTelp.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(346, 238)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(303, 23)
        txtAlamat.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.White
        Label4.Location = New Point(148, 207)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 10
        Label4.Text = "No Telepon"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.White
        Label5.Location = New Point(148, 241)
        Label5.Name = "Label5"
        Label5.Size = New Size(100, 23)
        Label5.TabIndex = 9
        Label5.Text = "Alamat"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackgroundImage = My.Resources.Resources.poeblack
        TabPage3.BackgroundImageLayout = ImageLayout.Stretch
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(PictureBox3)
        TabPage3.Controls.Add(grupPeran)
        TabPage3.Controls.Add(picProfil)
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(grupHobi)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(768, 384)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' grupPeran
        ' 
        grupPeran.BackColor = Color.White
        grupPeran.Controls.Add(rbMember)
        grupPeran.Controls.Add(rbAdmin)
        grupPeran.Controls.Add(rbWakilKetua)
        grupPeran.Controls.Add(rbKetua)
        grupPeran.Location = New Point(530, 125)
        grupPeran.Name = "grupPeran"
        grupPeran.Size = New Size(232, 83)
        grupPeran.TabIndex = 16
        grupPeran.TabStop = False
        grupPeran.Text = "Peran Dalam Komunitas"
        ' 
        ' rbMember
        ' 
        rbMember.AutoSize = True
        rbMember.Location = New Point(123, 57)
        rbMember.Name = "rbMember"
        rbMember.Size = New Size(70, 19)
        rbMember.TabIndex = 3
        rbMember.TabStop = True
        rbMember.Text = "Member"
        rbMember.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(123, 32)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(61, 19)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbWakilKetua
        ' 
        rbWakilKetua.AutoSize = True
        rbWakilKetua.Location = New Point(20, 57)
        rbWakilKetua.Name = "rbWakilKetua"
        rbWakilKetua.Size = New Size(87, 19)
        rbWakilKetua.TabIndex = 1
        rbWakilKetua.TabStop = True
        rbWakilKetua.Text = "Wakil Ketua"
        rbWakilKetua.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(20, 32)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(55, 19)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = SystemColors.ButtonHighlight
        picProfil.Location = New Point(3, 6)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(219, 345)
        picProfil.SizeMode = PictureBoxSizeMode.StretchImage
        picProfil.TabIndex = 14
        picProfil.TabStop = False
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(237, 355)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(507, 23)
        btnCetak.TabIndex = 1
        btnCetak.Text = "SIMPAN DAN CETAK KARTU"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(63, 357)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(83, 24)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse"
        ' 
        ' grupHobi
        ' 
        grupHobi.BackColor = Color.White
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
        grupHobi.Location = New Point(248, 125)
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
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatDataToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(804, 24)
        MenuStrip1.TabIndex = 15
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(74, 20)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatDataToolStripMenuItem
        ' 
        LihatDataToolStripMenuItem.Name = "LihatDataToolStripMenuItem"
        LihatDataToolStripMenuItem.Size = New Size(72, 20)
        LihatDataToolStripMenuItem.Text = "Lihat Data"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(86, 20)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(72, 20)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(52, 20)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Font = New Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(180, 52)
        Label8.Name = "Label8"
        Label8.Size = New Size(582, 42)
        Label8.TabIndex = 18
        Label8.Text = "Pembuatan Kartu Komunitas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Path_of_Exile_Logo
        PictureBox1.Location = New Point(0, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.White
        Label9.Font = New Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(180, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(582, 42)
        Label9.TabIndex = 20
        Label9.Text = "Pembuatan Kartu Komunitas"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Path_of_Exile_Logo
        PictureBox2.Location = New Point(0, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(203, 119)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.White
        Label10.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(375, 48)
        Label10.Name = "Label10"
        Label10.Size = New Size(350, 25)
        Label10.TabIndex = 20
        Label10.Text = "Pembuatan Kartu Komunitas"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Path_of_Exile_Logo
        PictureBox3.Location = New Point(228, 15)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(156, 94)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 21
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        grupJK.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        grupPeran.ResumeLayout(False)
        grupPeran.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        grupHobi.ResumeLayout(False)
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNama As TextBox
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents cboKomunitas As ComboBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelp As MaskedTextBox
    Friend WithEvents grupPeran As GroupBox
    Friend WithEvents rbMember As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbWakilKetua As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox

End Class
