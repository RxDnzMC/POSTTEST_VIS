'CREATE DATABASE If Not EXISTS WraeclastDB;
'USE WraeclastDB;

'CREATE TABLE If Not EXISTS Items (
'    ItemID INT AUTO_INCREMENT PRIMARY KEY,
'    ItemName VARCHAR(100) Not NULL,
'    Category VARCHAR(50) Not NULL,
'    Rarity VARCHAR(50) Not NULL,
'    Quantity INT Not NULL Default 1,
'    Value Decimal(10, 2) Default 0,
'    StashTab VARCHAR(50) Not NULL,
'    Description VARCHAR(255),
'    DateAdded DATETIME Default CURRENT_TIMESTAMP
');

'-- Contoh Data
'INSERT INTO Items (ItemName, Category, Rarity, Quantity, Value, StashTab, Description) VALUES
'('Exalted Orb', 'Currency', 'Rare', 5, 150.00, 'Currency Tab', 'High value currency'),
'('Kaom''s Heart', 'Body Armour', 'Unique', 1, 250.00, 'Unique Collection', 'Glorious Plate'),
'('Scroll of Wisdom', 'Currency', 'Normal', 40, 0.01, 'Currency Tab', 'Identifies items'),
'('Mirror of Kalandra', 'Currency', 'Legendary', 1, 10000.00, 'Valuable Items', 'Rarest currency'),
'('Divine Orb', 'Currency', 'Rare', 10, 20.00, 'Currency Tab', 'Rerolls explicit modifiers');

Imports MySqlConnector
Imports System.Data

Module ConnectionModule
    ' Ubah database ke WraeclastDB
    Public ReadOnly ConnectionString As String =
    "Server=localhost;Port=3306;Database=WraeclastDB;UserID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

    ' Tambahan method untuk ExecuteQuery
    Public Function ExecuteQuery(query As String, Optional parameters As MySqlParameter() = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    ' Tambahan method untuk ExecuteNonQuery
    Public Function ExecuteNonQuery(query As String, Optional parameters As MySqlParameter() = Nothing) As Integer
        Dim rowsAffected As Integer = 0
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters)
                End If
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return rowsAffected
    End Function
End Module