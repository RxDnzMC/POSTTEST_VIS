Imports MySqlConnector

Public Class Form1
    Private selectedItemID As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
        cmbCategory.SelectedIndex = 0
        cmbRarity.SelectedIndex = 0
    End Sub

    Private Sub LoadItems(Optional searchTerm As String = "")
        Try
            Dim query As String = "SELECT ItemID, ItemName, Category, Rarity, Quantity, Value, StashTab, Description, DateAdded FROM Items"
            Dim parameters As MySqlParameter() = Nothing

            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                query &= " WHERE ItemName LIKE @Search OR Category LIKE @Search OR StashTab LIKE @Search OR Description LIKE @Search"
                parameters = {New MySqlParameter("@Search", "%" & searchTerm & "%")}
            End If

            query &= " ORDER BY DateAdded DESC"

            ' Panggil ExecuteQuery dari ConnectionModule
            Dim dt As DataTable = ExecuteQuery(query, parameters)
            dgvItems.DataSource = dt

            ' Format DataGridView
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim validationResult = Validation.ValidateItem(txtItemName.Text, cmbCategory.Text, cmbRarity.Text,
                                                        txtQuantity.Text, txtValue.Text, txtStashTab.Text)

        If Not validationResult.Item1 Then
            MessageBox.Show(validationResult.Item2, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "INSERT INTO Items (ItemName, Category, Rarity, Quantity, Value, StashTab, Description) " &
                                 "VALUES (@ItemName, @Category, @Rarity, @Quantity, @Value, @StashTab, @Description)"

            Dim parameters As MySqlParameter() = {
                New MySqlParameter("@ItemName", txtItemName.Text.Trim()),
                New MySqlParameter("@Category", cmbCategory.Text),
                New MySqlParameter("@Rarity", cmbRarity.Text),
                New MySqlParameter("@Quantity", Integer.Parse(txtQuantity.Text)),
                New MySqlParameter("@Value", Decimal.Parse(txtValue.Text)),
                New MySqlParameter("@StashTab", txtStashTab.Text.Trim()),
                New MySqlParameter("@Description", If(String.IsNullOrWhiteSpace(txtDescription.Text), Nothing, txtDescription.Text.Trim()))
            }

            ' Panggil ExecuteNonQuery dari ConnectionModule
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

        Dim validationResult = Validation.ValidateItem(txtItemName.Text, cmbCategory.Text, cmbRarity.Text,
                                                        txtQuantity.Text, txtValue.Text, txtStashTab.Text)

        If Not validationResult.Item1 Then
            MessageBox.Show(validationResult.Item2, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "UPDATE Items SET ItemName = @ItemName, Category = @Category, Rarity = @Rarity, " &
                                 "Quantity = @Quantity, Value = @Value, StashTab = @StashTab, Description = @Description " &
                                 "WHERE ItemID = @ItemID"

            Dim parameters As MySqlParameter() = {
                New MySqlParameter("@ItemID", selectedItemID),
                New MySqlParameter("@ItemName", txtItemName.Text.Trim()),
                New MySqlParameter("@Category", cmbCategory.Text),
                New MySqlParameter("@Rarity", cmbRarity.Text),
                New MySqlParameter("@Quantity", Integer.Parse(txtQuantity.Text)),
                New MySqlParameter("@Value", Decimal.Parse(txtValue.Text)),
                New MySqlParameter("@StashTab", txtStashTab.Text.Trim()),
                New MySqlParameter("@Description", If(String.IsNullOrWhiteSpace(txtDescription.Text), Nothing, txtDescription.Text.Trim()))
            }

            ' Panggil ExecuteNonQuery dari ConnectionModule
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

                ' Panggil ExecuteNonQuery dari ConnectionModule
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
            txtStashTab.Text = row.Cells("StashTab").Value.ToString()

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
        txtStashTab.Clear()
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