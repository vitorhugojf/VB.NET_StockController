﻿Imports System.Data.SqlClient
Imports System.IO

Public Class StockControll

    ReadOnly connection As New SqlConnection("Server= localhost; Database = vb; Integrated Security = true")
    Private Sub StockControll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("select * from product", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        ProductData.AllowUserToAddRows = False
        ProductData.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        ProductData.DataSource = table

    End Sub

    Private Sub ProductData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductData.CellClick
        TextBoxName.Text = ProductData.CurrentRow.Cells(1).Value
        TextBoxDescription.Text = ProductData.CurrentRow.Cells(2).Value
        TextBoxValue.Text = ProductData.CurrentRow.Cells(3).Value
        TextBoxAmount.Text = ProductData.CurrentRow.Cells(4).Value
    End Sub

    Private Sub TextBoxFindById_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFindById.TextChanged

        Dim id As Integer
        If Integer.TryParse(TextBoxFindById.Text, id) Then
            Dim searchQuery As String = "select * from product WHERE id = " & id
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ProductData.AllowUserToAddRows = False
            ProductData.RowTemplate.Height = 100
            ProductData.DataSource = table
        Else
            Dim searchQuery As String = "select * from product"
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            ProductData.AllowUserToAddRows = False
            ProductData.RowTemplate.Height = 100
            ProductData.DataSource = table
        End If

    End Sub

    Private Sub TextBoxFindByName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFindByName.TextChanged
        Dim searchQuery As String = "SELECT * From product WHERE CONCAT(name,description) like '%" & TextBoxFindByName.Text & "%'"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        ProductData.AllowUserToAddRows = False
        ProductData.RowTemplate.Height = 100
        ProductData.DataSource = table
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim ms As New MemoryStream
        Dim insertQuery As String = "INSERT INTO product(name,description,value,amount)
            VALUES ('" & TextBoxName.Text & "','" & TextBoxDescription.Text & "'," & TextBoxValue.Text.Replace(",", ".") & "," & TextBoxAmount.Text & ");"
        Dim command As New SqlCommand(insertQuery, connection)

        ExecuteMyQuery(command)
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim ms As New MemoryStream
        Dim updateQuery As String = "UPDATE product SET name = '" & TextBoxName.Text & "',description = '" &
            TextBoxDescription.Text & "',value = " & TextBoxValue.Text.Replace(",", ".") & ",amount = " & TextBoxAmount.Text & " WHERE id = " & ProductData.CurrentRow.Cells(0).Value

        Dim command As New SqlCommand(updateQuery, connection)

        ExecuteMyQuery(command)
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click

        If MsgBox("This action will Delete the Product with the Id=" & ProductData.CurrentRow.Cells(0).Value & ", Are you Sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim deleteQuery As String = "DELETE FROM product WHERE id = " & ProductData.CurrentRow.Cells(0).Value

            Dim command As New SqlCommand(deleteQuery, connection)

            ExecuteMyQuery(command)
        Else
            MsgBox("The Product wasn't deleted")
        End If

    End Sub

    Private Sub ExecuteMyQuery(ByRef command As SqlCommand)
        connection.Open()
        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Successful Operation")

            Dim searchQuery As String = "select * from product"
            Dim commandToReload As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(commandToReload)
            Dim table As New DataTable()
            adapter.Fill(table)
            ProductData.AllowUserToAddRows = False
            ProductData.RowTemplate.Height = 100
            ProductData.DataSource = table

            TextBoxName.Text = ProductData.CurrentRow.Cells(1).Value
            TextBoxDescription.Text = ProductData.CurrentRow.Cells(2).Value
            TextBoxValue.Text = ProductData.CurrentRow.Cells(3).Value
            TextBoxAmount.Text = ProductData.CurrentRow.Cells(4).Value

            connection.Close()
        Catch er As Exception
            MessageBox.Show("Unsuccessful Operation, Error: " & er.Message)
            connection.Close()
        End Try
    End Sub
End Class
