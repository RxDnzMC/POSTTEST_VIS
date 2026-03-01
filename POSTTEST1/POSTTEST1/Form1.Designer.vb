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
        txtIPINPUT = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtOUTPUTIP = New TextBox()
        txtHasilIP = New Label()
        SuspendLayout()
        ' 
        ' txtIPINPUT
        ' 
        txtIPINPUT.Location = New Point(375, 170)
        txtIPINPUT.Name = "txtIPINPUT"
        txtIPINPUT.Size = New Size(160, 23)
        txtIPINPUT.TabIndex = 0
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(375, 203)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(462, 203)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(73, 23)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(267, 173)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 3
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(267, 244)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 4
        Label2.Text = "IP Kumulatif"
        ' 
        ' txtOUTPUTIP
        ' 
        txtOUTPUTIP.AccessibleRole = AccessibleRole.TitleBar
        txtOUTPUTIP.Location = New Point(375, 241)
        txtOUTPUTIP.Name = "txtOUTPUTIP"
        txtOUTPUTIP.ReadOnly = True
        txtOUTPUTIP.Size = New Size(160, 23)
        txtOUTPUTIP.TabIndex = 5
        ' 
        ' txtHasilIP
        ' 
        txtHasilIP.AutoSize = True
        txtHasilIP.Location = New Point(375, 288)
        txtHasilIP.Name = "txtHasilIP"
        txtHasilIP.Size = New Size(0, 15)
        txtHasilIP.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtHasilIP)
        Controls.Add(txtOUTPUTIP)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPINPUT)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtIPINPUT As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOUTPUTIP As TextBox
    Friend WithEvents txtHasilIP As Label

End Class
