Public Module Validation
    Public Function ValidateItem(itemName As String, category As String, rarity As String,
                                quantity As String, value As String, stashTab As String) As (Boolean, String)

        If String.IsNullOrWhiteSpace(itemName) Then
            Return (False, "Item Name is required!")
        End If

        If String.IsNullOrWhiteSpace(category) Then
            Return (False, "Category is required!")
        End If

        If String.IsNullOrWhiteSpace(rarity) Then
            Return (False, "Rarity is required!")
        End If

        If String.IsNullOrWhiteSpace(stashTab) Then
            Return (False, "Stash Tab is required!")
        End If

        Dim qty As Integer
        If Not Integer.TryParse(quantity, qty) OrElse qty <= 0 Then
            Return (False, "Quantity must be a positive number!")
        End If

        Dim val As Decimal
        If Not Decimal.TryParse(value, val) OrElse val < 0 Then
            Return (False, "Value must be a non-negative number!")
        End If

        Return (True, "Valid")
    End Function

    Public Function ValidateSearch(searchTerm As String) As (Boolean, String)
        If String.IsNullOrWhiteSpace(searchTerm) Then
            Return (False, "Please enter a search term!")
        End If
        Return (True, "Valid")
    End Function
End Module