Imports MySqlConnector

Public Class Form1
    Private selectedItemID As Integer = 0
    Private stashTabsData As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStashTabs()
        LoadItems()
        cmbCategory.SelectedIndex = 0
        cmbRarity.SelectedIndex = 0
        cmbTabColor.SelectedIndex = 0
    End Sub

    Private Sub LoadStashTabs()
        Try
            stashTabsData = GetStashTabs()

            ' Untuk ComboBox di Item Details
            cmbStashTab.Items.Clear()
            For Each row As DataRow In stashTabsData.Rows
                cmbStashTab.Items.Add(row("TabName").ToString())
            Next

            If cmbStashTab.Items.Count > 0 Then
                cmbStashTab.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show($"Error loading stash tabs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadItems(Optional searchTerm As String = "")
        Try
            ' Query dengan JOIN untuk mendapatkan nama tab
            Dim query As String = "SELECT i.ItemID, i.ItemName, i.Category, i.Rarity, i.Quantity, i.Value, " &
                                 "s.TabName AS StashTab, i.Description, i.DateAdded " &
                                 "FROM Items i INNER JOIN StashTabs s ON i.StashTabID = s.StashTabID"
            Dim parameters As MySqlParameter() = Nothing

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " WHERE i.ItemName LIKE @Search OR i.Category LIKE @Search OR s.TabName LIKE @Search OR i.Description LIKE @Search"
                parameters = {New MySqlParameter("@Search", "%" & searchTerm & "%")}
            End If

            query &= " ORDER BY i.DateAdded DESC"

            Dim dt As DataTable = ExecuteQuery(query, parameters)
            dgvItems.DataSource = dt

            If dgvItems.Columns.Count > 0 Then
                dgvItems.Columns("ItemID").Visible = False
                dgvItems.Columns("ItemName").HeaderText = "Item Name"
                dgvItems.Columns("Category").HeaderText = "Category"
                dgvItems.Columns("Rarity").HeaderText = "Rarity"
                dgvItems.Columns("Quantity").HeaderText = "Qty"
                dgvItems.Columns("Value").HeaderText = "Value"
                dgvItems.Columns("Value").DefaultCellStyle.Format = "N2"
                dgvItems.Columns("StashTab").HeaderText = "Stash Tab"
                dgvItems.Columns("Description").HeaderText = "Description"
                dgvItems.Columns("DateAdded").HeaderText = "Date Added"
                dgvItems.Columns("DateAdded").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            End If

            lblTotalItems.Text = $"Total Items: {dt.Rows.Count}"

        Catch ex As Exception
            MessageBox.Show($"Error loading items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetStashTabID(tabName As String) As Integer
        For Each row As DataRow In stashTabsData.Rows
            If row("TabName").ToString() = tabName Then
                Return Convert.ToInt32(row("StashTabID"))
            End If
        Next
        Return 0
    End Function

    Private Sub btnAddTab_Click(sender As Object, e As EventArgs) Handles btnAddTab.Click
        If String.IsNullOrWhiteSpace(txtNewTabName.Text) Then
            MessageBox.Show("Please enter a tab name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            AddStashTab(txtNewTabName.Text.Trim(), cmbTabColor.Text, chkIsPremium.Checked)
            MessageBox.Show("Stash Tab added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtNewTabName.Clear()
            cmbTabColor.SelectedIndex = 0
            chkIsPremium.Checked = False

            LoadStashTabs()
        Catch ex As Exception
            MessageBox.Show($"Error adding stash tab: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefreshTabs_Click(sender As Object, e As EventArgs) Handles btnRefreshTabs.Click
        LoadStashTabs()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cmbStashTab.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Stash Tab!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim validationResult = Validation.ValidateItem(txtItemName.Text, cmbCategory.Text, cmbRarity.Text,
                                                        txtQuantity.Text, txtValue.Text, cmbStashTab.Text)

        If Not validationResult.Item1 Then
            MessageBox.Show(validationResult.Item2, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stashTabID As Integer = GetStashTabID(cmbStashTab.Text)
        If stashTabID = 0 Then
            MessageBox.Show("Invalid Stash Tab selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query As String = "INSERT INTO Items (ItemName, Category, Rarity, Quantity, Value, StashTabID, Description) " &
                                 "VALUES (@ItemName, @Category, @Rarity, @Quantity, @Value, @StashTabID, @Description)"

            Dim parameters As MySqlParameter() = {
                New MySqlParameter("@ItemName", txtItemName.Text.Trim()),
                New MySqlParameter("@Category", cmbCategory.Text),
                New MySqlParameter("@Rarity", cmbRarity.Text),
                New MySqlParameter("@Quantity", Integer.Parse(txtQuantity.Text)),
                New MySqlParameter("@Value", Decimal.Parse(txtValue.Text)),
                New MySqlParameter("@StashTabID", stashTabID),
                New MySqlParameter("@Description", If(String.IsNullOrWhiteSpace(txtDescription.Text), Nothing, txtDescription.Text.Trim()))
            }

            ExecuteNonQuery(query, parameters)
            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearForm()
            LoadItems()

        Catch ex As Exception
            MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedItemID = 0 Then
            MessageBox.Show("Please select an item to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbStashTab.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Stash Tab!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim validationResult = Validation.ValidateItem(txtItemName.Text, cmbCategory.Text, cmbRarity.Text,
                                                        txtQuantity.Text, txtValue.Text, cmbStashTab.Text)

        If Not validationResult.Item1 Then
            MessageBox.Show(validationResult.Item2, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim stashTabID As Integer = GetStashTabID(cmbStashTab.Text)
        If stashTabID = 0 Then
            MessageBox.Show("Invalid Stash Tab selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim query As String = "UPDATE Items SET ItemName = @ItemName, Category = @Category, Rarity = @Rarity, " &
                                 "Quantity = @Quantity, Value = @Value, StashTabID = @StashTabID, Description = @Description " &
                                 "WHERE ItemID = @ItemID"

            Dim parameters As MySqlParameter() = {
                New MySqlParameter("@ItemID", selectedItemID),
                New MySqlParameter("@ItemName", txtItemName.Text.Trim()),
                New MySqlParameter("@Category", cmbCategory.Text),
                New MySqlParameter("@Rarity", cmbRarity.Text),
                New MySqlParameter("@Quantity", Integer.Parse(txtQuantity.Text)),
                New MySqlParameter("@Value", Decimal.Parse(txtValue.Text)),
                New MySqlParameter("@StashTabID", stashTabID),
                New MySqlParameter("@Description", If(String.IsNullOrWhiteSpace(txtDescription.Text), Nothing, txtDescription.Text.Trim()))
            }

            ExecuteNonQuery(query, parameters)
            MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ClearForm()
            LoadItems()

        Catch ex As Exception
            MessageBox.Show($"Error updating item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedItemID = 0 Then
            MessageBox.Show("Please select an item to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM Items WHERE ItemID = @ItemID"
                Dim parameters As MySqlParameter() = {New MySqlParameter("@ItemID", selectedItemID)}

                ExecuteNonQuery(query, parameters)
                MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ClearForm()
                LoadItems()

            Catch ex As Exception
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgvItems_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItems.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvItems.Rows(e.RowIndex)

            selectedItemID = Convert.ToInt32(row.Cells("ItemID").Value)
            txtItemName.Text = row.Cells("ItemName").Value.ToString()
            cmbCategory.Text = row.Cells("Category").Value.ToString()
            cmbRarity.Text = row.Cells("Rarity").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()
            txtValue.Text = Convert.ToDecimal(row.Cells("Value").Value).ToString()

            Dim stashTabName As String = row.Cells("StashTab").Value.ToString()
            If cmbStashTab.Items.Contains(stashTabName) Then
                cmbStashTab.Text = stashTabName
            End If

            If row.Cells("Description").Value IsNot Nothing AndAlso Not IsDBNull(row.Cells("Description").Value) Then
                txtDescription.Text = row.Cells("Description").Value.ToString()
            Else
                txtDescription.Text = ""
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedItemID = 0
        txtItemName.Clear()
        cmbCategory.SelectedIndex = 0
        cmbRarity.SelectedIndex = 0
        txtQuantity.Clear()
        txtValue.Clear()
        If cmbStashTab.Items.Count > 0 Then cmbStashTab.SelectedIndex = 0
        txtDescription.Clear()
        txtSearch.Clear()
        txtItemName.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim validationResult = Validation.ValidateSearch(txtSearch.Text)

        If Not validationResult.Item1 Then
            MessageBox.Show(validationResult.Item2, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        LoadItems(txtSearch.Text.Trim())
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadItems()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnSearch.PerformClick()
        End If
    End Sub
End Class