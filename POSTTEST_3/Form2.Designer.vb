<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        lblHobi = New Label()
        lblJK = New Label()
        lblTLahir = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        lblAlamat = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.project_star_PEMVIS
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(lblAlamat)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(lblHobi)
        Panel1.Controls.Add(lblJK)
        Panel1.Controls.Add(lblTLahir)
        Panel1.Controls.Add(lblUmur)
        Panel1.Controls.Add(lblNama)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 452)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(58, 157)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(206, 271)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Font = New Font("Segoe UI", 11F)
        lblHobi.ForeColor = SystemColors.Control
        lblHobi.Location = New Point(418, 361)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(0, 20)
        lblHobi.TabIndex = 9
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Font = New Font("Segoe UI", 11F)
        lblJK.ForeColor = SystemColors.Control
        lblJK.Location = New Point(418, 309)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(0, 20)
        lblJK.TabIndex = 8
        ' 
        ' lblTLahir
        ' 
        lblTLahir.AutoSize = True
        lblTLahir.Font = New Font("Segoe UI", 11F)
        lblTLahir.ForeColor = SystemColors.Control
        lblTLahir.Location = New Point(418, 255)
        lblTLahir.Name = "lblTLahir"
        lblTLahir.Size = New Size(0, 20)
        lblTLahir.TabIndex = 7
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 11F)
        lblUmur.ForeColor = SystemColors.Control
        lblUmur.Location = New Point(418, 203)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(0, 20)
        lblUmur.TabIndex = 6
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 11F)
        lblNama.ForeColor = SystemColors.Control
        lblNama.Location = New Point(418, 157)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(0, 20)
        lblNama.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(286, 309)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 20)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(287, 361)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 3
        Label4.Text = "Hobi :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(287, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 2
        Label3.Text = "Tanggal Lahir :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(287, 203)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 1
        Label2.Text = "Umur :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(287, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(287, 408)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 20)
        Label6.TabIndex = 11
        Label6.Text = "Alamat :"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 11F)
        lblAlamat.ForeColor = SystemColors.Control
        lblAlamat.Location = New Point(418, 408)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(0, 20)
        lblAlamat.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTLahir As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAlamat As Label
End Class
