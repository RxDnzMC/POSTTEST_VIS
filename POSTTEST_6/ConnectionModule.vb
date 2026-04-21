'--=============================================
'-- DATABASE WRaeclast STASH MANAGER
'--=============================================

'-- Drop database jika ada (HATI-HATI! Ini akan menghapus semua data)
'DROP DATABASE If EXISTS WraeclastDB;

'-- Buat database baru
'CREATE DATABASE WraeclastDB;
'USE WraeclastDB;

'--=============================================
'-- TABLE 1: StashTabs(Parent Table)
'--=============================================
'CREATE TABLE StashTabs (
'    StashTabID INT AUTO_INCREMENT PRIMARY KEY,
'    TabName VARCHAR(50) Not NULL UNIQUE,
'    TabColor VARCHAR(20) Default 'Gray',
'    IsPremium Boolean Default False,
'    DateCreated DATETIME Default CURRENT_TIMESTAMP
');

'--=============================================
'-- TABLE 2: Items(Child Table With Foreign Key)
'--=============================================
'CREATE TABLE Items (
'    ItemID INT AUTO_INCREMENT PRIMARY KEY,
'    ItemName VARCHAR(100) Not NULL,
'    Category VARCHAR(50) Not NULL,
'    Rarity VARCHAR(50) Not NULL,
'    Quantity INT Not NULL Default 1,
'    Value Decimal(10, 2) Default 0,
'    StashTabID INT Not NULL,
'    Description VARCHAR(255),
'    DateAdded DATETIME Default CURRENT_TIMESTAMP,

'    -- Foreign Key constraint
'    CONSTRAINT FK_Items_StashTabs 
'        FOREIGN KEY(StashTabID) 
'        REFERENCES StashTabs(StashTabID)
'On DELETE RESTRICT
');

'--=============================================
'-- INSERT SAMPLE DATA FOR StashTabs
'--=============================================
'INSERT INTO StashTabs (TabName, TabColor, IsPremium) VALUES
'('Currency Tab', 'Gold', TRUE),
'('Unique Collection', 'Orange', TRUE),
'('Maps', 'Blue', FALSE),
'('Random Dump', 'Gray', FALSE),
'('Essence Tab', 'Green', TRUE),
'('Divination Cards', 'Purple', FALSE),
'('Fragments', 'Red', FALSE);

'--=============================================
'-- INSERT SAMPLE DATA FOR Items
'--=============================================
'-- StashTabID references:
'-- 1 = Currency Tab
'-- 2 = Unique Collection  
'-- 3 = Maps
'-- 4 = Random Dump
'-- 5 = Essence Tab
'-- 6 = Divination Cards
'-- 7 = Fragments

'INSERT INTO Items (ItemName, Category, Rarity, Quantity, Value, StashTabID, Description) VALUES
'('Exalted Orb', 'Currency', 'Rare', 5, 150.00, 1, 'High value currency - used for crafting'),
'('Mirror of Kalandra', 'Currency', 'Legendary', 1, 10000.00, 1, 'Rarest currency in the game'),
'('Divine Orb', 'Currency', 'Rare', 10, 20.00, 1, 'Rerolls explicit modifiers on items'),
'('Scroll of Wisdom', 'Currency', 'Normal', 40, 0.01, 1, 'Identifies unidentified items'),

'('Kaom''s Heart', 'Body Armour', 'Unique', 1, 250.00, 2, 'Glorious Plate - +500 Maximum Life'),
'('Headhunter', 'Belt', 'Unique', 1, 800.00, 2, 'Leather Belt - steals modifiers from rare monsters'),
'('The Saviour', 'Sword', 'Unique', 1, 300.00, 2, 'Legion Sword - creates reflection copies'),

'('Beach Map', 'Map', 'Normal', 15, 1.00, 3, 'Tier 1 Beach Map'),
'('Tropical Island Map', 'Map', 'Magic', 8, 2.50, 3, 'Tier 2 Tropical Island Map'),
'('Cemetery Map', 'Map', 'Rare', 5, 5.00, 3, 'Tier 3 Cemetery Map'),

'('Random Helmet', 'Armour', 'Normal', 3, 0.50, 4, 'Just a random drop'),
'('Random Boots', 'Boots', 'Magic', 2, 1.20, 4, 'Movement speed implicit'),

'('Shrieking Essence of Anger', 'Essence', 'Rare', 7, 8.00, 5, 'Upgrades weapon with fire damage'),
'('Deafening Essence of Spite', 'Essence', 'Rare', 4, 12.00, 5, 'Upgrades with mana modifiers'),

'('The Doctor', 'Divination Card', 'Unique', 2, 200.00, 6, 'Set of 8 rewards Headhunter belt'),
'('The Nurse', 'Divination Card', 'Rare', 5, 50.00, 6, 'Set of 8 rewards The Doctor card'),

'('Sacrifice at Midnight', 'Fragment', 'Magic', 10, 3.00, 7, 'Used to open Atziri''s Vault'),
'('Mortal Grief', 'Fragment', 'Rare', 3, 15.00, 7, 'Used to open Uber Atziri');

'--=============================================
'-- VERIFY DATA (optional - run to check)
'--=============================================

'-- Lihat semua items dengan nama stash tab-nya
'Select Case
'    i.ItemID,
'    i.ItemName,
'    i.Category,
'    i.Rarity,
'    i.Quantity,
'    i.Value,
'    s.TabName As StashTab,
'    s.TabColor,
'    i.Description
'FROM Items i
'INNER JOIN StashTabs s On i.StashTabID = s.StashTabID
'ORDER BY i.DateAdded DESC;

'-- Hitung total items per stash tab
'Select Case
'    s.TabName,
'    s.TabColor,
'    COUNT(i.ItemID) As TotalItems,
'    SUM(i.Quantity) As TotalQuantity
'FROM StashTabs s
'LEFT JOIN Items i On s.StashTabID = i.StashTabID
'GROUP BY s.StashTabID
'ORDER BY TotalItems DESC;

'--=============================================
'-- SAMPLE QUERIES FOR TESTING
'--=============================================

'-- Cari item berdasarkan nama
'-- SELECT * FROM Items WHERE ItemName Like '%Exalted%';

'-- Cari item berdasarkan stash tab
'-- SELECT * FROM Items i JOIN StashTabs s ON i.StashTabID = s.StashTabID WHERE s.TabName = 'Currency Tab';

'-- Update quantity item
'-- UPDATE Items SET Quantity = Quantity + 1 WHERE ItemName = 'Exalted Orb';

'-- Delete item (perhatikan foreign key tidak akan menghalangi karena ON DELETE RESTRICT hanya untuk parent)
'-- DELETE FROM Items WHERE ItemID = 1;

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

    ' Tambahkan method ini di dalam ConnectionModule.vb

    Public Function GetStashTabs() As DataTable
        Return ExecuteQuery("SELECT StashTabID, TabName, TabColor, IsPremium FROM StashTabs ORDER BY TabName")
    End Function

    Public Function AddStashTab(tabName As String, tabColor As String, isPremium As Boolean) As Integer
        Dim query As String = "INSERT INTO StashTabs (TabName, TabColor, IsPremium) VALUES (@TabName, @TabColor, @IsPremium)"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@TabName", tabName),
            New MySqlParameter("@TabColor", tabColor),
            New MySqlParameter("@IsPremium", isPremium)
        }
        Return ExecuteNonQuery(query, parameters)
    End Function
End Module