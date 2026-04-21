<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvItems = New DataGridView()
        gbItemDetails = New GroupBox()
        txtDescription = New TextBox()
        lblDescription = New Label()
        cmbRarity = New ComboBox()
        txtValue = New TextBox()
        lblValue = New Label()
        txtQuantity = New TextBox()
        lblQuantity = New Label()
        lblRarity = New Label()
        cmbCategory = New ComboBox()
        lblCategory = New Label()
        cmbStashTab = New ComboBox()
        lblStashTab = New Label()
        txtItemName = New TextBox()
        lblItemName = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        gbSearch = New GroupBox()
        btnSearch = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        lblSearch = New Label()
        lblTitle = New Label()
        lblTotalItems = New Label()
        gbManageTabs = New GroupBox()
        btnRefreshTabs = New Button()
        btnAddTab = New Button()
        cmbTabColor = New ComboBox()
        lblTabColor = New Label()
        chkIsPremium = New CheckBox()
        txtNewTabName = New TextBox()
        lblNewTabName = New Label()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        gbItemDetails.SuspendLayout()
        gbSearch.SuspendLayout()
        gbManageTabs.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.AllowUserToDeleteRows = False
        dgvItems.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Location = New Point(14, 450)
        dgvItems.Margin = New Padding(4, 3, 4, 3)
        dgvItems.MultiSelect = False
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvItems.Size = New Size(1120, 300)
        dgvItems.TabIndex = 0
        ' 
        ' gbItemDetails
        ' 
        gbItemDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        gbItemDetails.Controls.Add(txtDescription)
        gbItemDetails.Controls.Add(lblDescription)
        gbItemDetails.Controls.Add(cmbRarity)
        gbItemDetails.Controls.Add(txtValue)
        gbItemDetails.Controls.Add(lblValue)
        gbItemDetails.Controls.Add(txtQuantity)
        gbItemDetails.Controls.Add(lblQuantity)
        gbItemDetails.Controls.Add(lblRarity)
        gbItemDetails.Controls.Add(cmbCategory)
        gbItemDetails.Controls.Add(lblCategory)
        gbItemDetails.Controls.Add(cmbStashTab)
        gbItemDetails.Controls.Add(lblStashTab)
        gbItemDetails.Controls.Add(txtItemName)
        gbItemDetails.Controls.Add(lblItemName)
        gbItemDetails.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbItemDetails.Location = New Point(14, 90)
        gbItemDetails.Margin = New Padding(4, 3, 4, 3)
        gbItemDetails.Name = "gbItemDetails"
        gbItemDetails.Padding = New Padding(4, 3, 4, 3)
        gbItemDetails.Size = New Size(1120, 200)
        gbItemDetails.TabIndex = 1
        gbItemDetails.TabStop = False
        gbItemDetails.Text = "Item Details"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(572, 140)
        txtDescription.Margin = New Padding(4, 3, 4, 3)
        txtDescription.Multiline = True
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(524, 46)
        txtDescription.TabIndex = 13
        ' 
        ' lblDescription
        ' 
        lblDescription.AutoSize = True
        lblDescription.Location = New Point(455, 143)
        lblDescription.Margin = New Padding(4, 0, 4, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New Size(72, 15)
        lblDescription.TabIndex = 12
        lblDescription.Text = "Description:"
        ' 
        ' cmbRarity
        ' 
        cmbRarity.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRarity.FormattingEnabled = True
        cmbRarity.Items.AddRange(New Object() {"Normal", "Magic", "Rare", "Unique", "Legendary"})
        cmbRarity.Location = New Point(572, 40)
        cmbRarity.Margin = New Padding(4, 3, 4, 3)
        cmbRarity.Name = "cmbRarity"
        cmbRarity.Size = New Size(233, 23)
        cmbRarity.TabIndex = 11
        ' 
        ' txtValue
        ' 
        txtValue.Location = New Point(152, 140)
        txtValue.Margin = New Padding(4, 3, 4, 3)
        txtValue.Name = "txtValue"
        txtValue.Size = New Size(233, 21)
        txtValue.TabIndex = 10
        ' 
        ' lblValue
        ' 
        lblValue.AutoSize = True
        lblValue.Location = New Point(23, 143)
        lblValue.Margin = New Padding(4, 0, 4, 0)
        lblValue.Name = "lblValue"
        lblValue.Size = New Size(41, 15)
        lblValue.TabIndex = 9
        lblValue.Text = "Value:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(152, 105)
        txtQuantity.Margin = New Padding(4, 3, 4, 3)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(233, 21)
        txtQuantity.TabIndex = 8
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(23, 108)
        lblQuantity.Margin = New Padding(4, 0, 4, 0)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(54, 15)
        lblQuantity.TabIndex = 7
        lblQuantity.Text = "Quantity:"
        ' 
        ' lblRarity
        ' 
        lblRarity.AutoSize = True
        lblRarity.Location = New Point(455, 44)
        lblRarity.Margin = New Padding(4, 0, 4, 0)
        lblRarity.Name = "lblRarity"
        lblRarity.Size = New Size(41, 15)
        lblRarity.TabIndex = 6
        lblRarity.Text = "Rarity:"
        ' 
        ' cmbCategory
        ' 
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"Currency", "Weapon", "Armour", "Accessory", "Gem", "Map", "Fragment", "Divination Card", "Essence", "Fossil"})
        cmbCategory.Location = New Point(152, 40)
        cmbCategory.Margin = New Padding(4, 3, 4, 3)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(233, 23)
        cmbCategory.TabIndex = 5
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(23, 44)
        lblCategory.Margin = New Padding(4, 0, 4, 0)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(58, 15)
        lblCategory.TabIndex = 4
        lblCategory.Text = "Category:"
        ' 
        ' cmbStashTab
        ' 
        cmbStashTab.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStashTab.FormattingEnabled = True
        cmbStashTab.Location = New Point(572, 75)
        cmbStashTab.Margin = New Padding(4, 3, 4, 3)
        cmbStashTab.Name = "cmbStashTab"
        cmbStashTab.Size = New Size(233, 23)
        cmbStashTab.TabIndex = 3
        ' 
        ' lblStashTab
        ' 
        lblStashTab.AutoSize = True
        lblStashTab.Location = New Point(455, 78)
        lblStashTab.Margin = New Padding(4, 0, 4, 0)
        lblStashTab.Name = "lblStashTab"
        lblStashTab.Size = New Size(65, 15)
        lblStashTab.TabIndex = 2
        lblStashTab.Text = "Stash Tab:"
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(152, 75)
        txtItemName.Margin = New Padding(4, 3, 4, 3)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(233, 21)
        txtItemName.TabIndex = 1
        ' 
        ' lblItemName
        ' 
        lblItemName.AutoSize = True
        lblItemName.Location = New Point(23, 78)
        lblItemName.Margin = New Padding(4, 0, 4, 0)
        lblItemName.Name = "lblItemName"
        lblItemName.Size = New Size(71, 15)
        lblItemName.TabIndex = 0
        lblItemName.Text = "Item Name:"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(14, 305)
        btnAdd.Margin = New Padding(4, 3, 4, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(117, 40)
        btnAdd.TabIndex = 2
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(140, 305)
        btnUpdate.Margin = New Padding(4, 3, 4, 3)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(117, 40)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(244), CByte(67), CByte(54))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(266, 305)
        btnDelete.Margin = New Padding(4, 3, 4, 3)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(117, 40)
        btnDelete.TabIndex = 4
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(158), CByte(158), CByte(158))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(392, 305)
        btnClear.Margin = New Padding(4, 3, 4, 3)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(117, 40)
        btnClear.TabIndex = 5
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' gbSearch
        ' 
        gbSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        gbSearch.Controls.Add(btnSearch)
        gbSearch.Controls.Add(btnRefresh)
        gbSearch.Controls.Add(txtSearch)
        gbSearch.Controls.Add(lblSearch)
        gbSearch.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbSearch.Location = New Point(714, 14)
        gbSearch.Margin = New Padding(4, 3, 4, 3)
        gbSearch.Name = "gbSearch"
        gbSearch.Padding = New Padding(4, 3, 4, 3)
        gbSearch.Size = New Size(420, 69)
        gbSearch.TabIndex = 6
        gbSearch.TabStop = False
        gbSearch.Text = "Search Items"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(255), CByte(152), CByte(0))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(321, 25)
        btnSearch.Margin = New Padding(4, 3, 4, 3)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(88, 29)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(227, 25)
        btnRefresh.Margin = New Padding(4, 3, 4, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(88, 29)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(70, 28)
        txtSearch.Margin = New Padding(4, 3, 4, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(145, 21)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(7, 31)
        lblSearch.Margin = New Padding(4, 0, 4, 0)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(49, 15)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(139), CByte(69), CByte(19))
        lblTitle.Location = New Point(14, 23)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(309, 29)
        lblTitle.TabIndex = 7
        lblTitle.Text = "Wraeclast Stash Manager"
        ' 
        ' lblTotalItems
        ' 
        lblTotalItems.AutoSize = True
        lblTotalItems.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalItems.Location = New Point(14, 420)
        lblTotalItems.Margin = New Padding(4, 0, 4, 0)
        lblTotalItems.Name = "lblTotalItems"
        lblTotalItems.Size = New Size(80, 15)
        lblTotalItems.TabIndex = 8
        lblTotalItems.Text = "Total Items: 0"
        ' 
        ' gbManageTabs
        ' 
        gbManageTabs.Controls.Add(btnRefreshTabs)
        gbManageTabs.Controls.Add(btnAddTab)
        gbManageTabs.Controls.Add(cmbTabColor)
        gbManageTabs.Controls.Add(lblTabColor)
        gbManageTabs.Controls.Add(chkIsPremium)
        gbManageTabs.Controls.Add(txtNewTabName)
        gbManageTabs.Controls.Add(lblNewTabName)
        gbManageTabs.Font = New Font("Microsoft Sans Serif", 9.0F)
        gbManageTabs.Location = New Point(14, 14)
        gbManageTabs.Size = New Size(680, 72)
        gbManageTabs.TabIndex = 9
        gbManageTabs.TabStop = False
        gbManageTabs.Text = "Manage Stash Tabs"
        ' 
        ' btnRefreshTabs
        ' 
        btnRefreshTabs.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        btnRefreshTabs.FlatStyle = FlatStyle.Flat
        btnRefreshTabs.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnRefreshTabs.ForeColor = Color.White
        btnRefreshTabs.Location = New Point(560, 20)
        btnRefreshTabs.Size = New Size(110, 30)
        btnRefreshTabs.TabIndex = 6
        btnRefreshTabs.Text = "Refresh Tabs"
        btnRefreshTabs.UseVisualStyleBackColor = False
        ' 
        ' btnAddTab
        ' 
        btnAddTab.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnAddTab.FlatStyle = FlatStyle.Flat
        btnAddTab.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold)
        btnAddTab.ForeColor = Color.White
        btnAddTab.Location = New Point(470, 20)
        btnAddTab.Size = New Size(80, 30)
        btnAddTab.TabIndex = 5
        btnAddTab.Text = "Add Tab"
        btnAddTab.UseVisualStyleBackColor = False
        ' 
        ' cmbTabColor
        ' 
        cmbTabColor.DropDownStyle = ComboBoxStyle.DropDownList
        cmbTabColor.FormattingEnabled = True
        cmbTabColor.Items.AddRange(New Object() {"Gray", "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Gold"})
        cmbTabColor.Location = New Point(290, 22)
        cmbTabColor.Size = New Size(80, 23)
        cmbTabColor.TabIndex = 4
        ' 
        ' lblTabColor
        ' 
        lblTabColor.AutoSize = True
        lblTabColor.Location = New Point(245, 25)
        lblTabColor.Text = "Color:"
        ' 
        ' chkIsPremium
        ' 
        chkIsPremium.AutoSize = True
        chkIsPremium.Location = New Point(390, 24)
        chkIsPremium.Text = "Premium"
        ' 
        ' txtNewTabName
        ' 
        txtNewTabName.Location = New Point(80, 22)
        txtNewTabName.Size = New Size(150, 21)
        ' 
        ' lblNewTabName
        ' 
        lblNewTabName.AutoSize = True
        lblNewTabName.Location = New Point(6, 25)
        lblNewTabName.Text = "New Tab:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1148, 764)
        Controls.Add(gbManageTabs)
        Controls.Add(lblTotalItems)
        Controls.Add(lblTitle)
        Controls.Add(gbSearch)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(gbItemDetails)
        Controls.Add(dgvItems)
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(1164, 802)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Wraeclast Stash Manager"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        gbItemDetails.ResumeLayout(False)
        gbItemDetails.PerformLayout()
        gbSearch.ResumeLayout(False)
        gbSearch.PerformLayout()
        gbManageTabs.ResumeLayout(False)
        gbManageTabs.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents gbItemDetails As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents lblItemName As Label
    Friend WithEvents cmbStashTab As ComboBox
    Friend WithEvents lblStashTab As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbRarity As ComboBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents lblValue As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblRarity As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents gbManageTabs As GroupBox
    Friend WithEvents btnRefreshTabs As Button
    Friend WithEvents btnAddTab As Button
    Friend WithEvents cmbTabColor As ComboBox
    Friend WithEvents lblTabColor As Label
    Friend WithEvents chkIsPremium As CheckBox
    Friend WithEvents txtNewTabName As TextBox
    Friend WithEvents lblNewTabName As Label
End Class