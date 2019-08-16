Imports System.Data.SqlClient
Imports System.IO

Public Class EmployeeControl
    ReadOnly connection As New SqlConnection("Server= localhost; Database = vb; Integrated Security = true")
    Dim employee As Employee

    Sub New(loginEmployee As Employee)
        employee = loginEmployee
        InitializeComponent()
    End Sub
    Private Sub EmployeeControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New SqlCommand("select * from employee", connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        EmployeeData.AllowUserToAddRows = False
        EmployeeData.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        EmployeeData.DataSource = table
        EmployeeData.ReadOnly = True
    End Sub

    Private Sub EmployeeData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeData.CellClick
        TextBoxName.Text = EmployeeData.CurrentRow.Cells(1).Value
        TextBoxUsername.Text = EmployeeData.CurrentRow.Cells(2).Value
        TextBoxPassword.Text = EmployeeData.CurrentRow.Cells(3).Value
        TextBoxJobRole.Text = EmployeeData.CurrentRow.Cells(4).Value
        TextBoxLastActive.Text = EmployeeData.CurrentRow.Cells(5).Value
    End Sub

    Private Sub TextBoxFilters_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFindById.TextChanged, TextBoxFindByNameOrUsername.TextChanged
        Dim id As Integer
        If Integer.TryParse(TextBoxFindById.Text, id) Then
            Dim searchQuery As String = "SELECT * From employee WHERE id = " & id & " AND CONCAT(name,username) like '%" & TextBoxFindByNameOrUsername.Text & "%'"
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            EmployeeData.AllowUserToAddRows = False
            EmployeeData.RowTemplate.Height = 100
            EmployeeData.DataSource = table
        Else
            Dim searchQuery As String = "SELECT * From employee WHERE CONCAT(name,username) like '%" & TextBoxFindByNameOrUsername.Text & "%'"
            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            EmployeeData.AllowUserToAddRows = False
            EmployeeData.RowTemplate.Height = 100
            EmployeeData.DataSource = table
        End If
    End Sub

    Private Sub ButtonCreate_Click(sender As Object, e As EventArgs) Handles ButtonCreate.Click
        Dim ms As New MemoryStream
        Dim insertQuery As String = "INSERT INTO employee(name,username,password,jobrole,lastactive)
            VALUES ('" & TextBoxName.Text & "','" & TextBoxUsername.Text & "','" & TextBoxPassword.Text & "','" & TextBoxJobRole.Text & "','" & Date.Now & "');"
        Dim command As New SqlCommand(insertQuery, connection)

        ExecuteMyQuery(command)
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim ms As New MemoryStream
        Dim updateQuery As String = "UPDATE employee SET name = '" & TextBoxName.Text & "',username = '" &
        TextBoxUsername.Text & "',password = '" & TextBoxPassword.Text & "',jobrole = '" & TextBoxJobRole.Text & "' WHERE id = " & EmployeeData.CurrentRow.Cells(0).Value

        Dim command As New SqlCommand(updateQuery, connection)

        ExecuteMyQuery(command)
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        If MsgBox("This action will Delete the Employee with the Id " & EmployeeData.CurrentRow.Cells(0).Value & ", Are you Sure?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim deleteQuery As String = "DELETE FROM Employee WHERE id = " & EmployeeData.CurrentRow.Cells(0).Value

            Dim command As New SqlCommand(deleteQuery, connection)

            ExecuteMyQuery(command)
        Else
            MsgBox("The Employee wasn't deleted")
        End If
    End Sub

    Private Sub ExecuteMyQuery(ByRef command As SqlCommand)
        connection.Open()
        Try
            command.ExecuteNonQuery()
            MessageBox.Show("Successful Operation")

            Dim searchQuery As String = "select * from employee"
            Dim commandToReload As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(commandToReload)
            Dim table As New DataTable()
            adapter.Fill(table)
            EmployeeData.AllowUserToAddRows = False
            EmployeeData.RowTemplate.Height = 100
            EmployeeData.DataSource = table

            TextBoxName.Text = EmployeeData.CurrentRow.Cells(1).Value
            TextBoxUsername.Text = EmployeeData.CurrentRow.Cells(2).Value
            TextBoxPassword.Text = EmployeeData.CurrentRow.Cells(3).Value
            TextBoxJobRole.Text = EmployeeData.CurrentRow.Cells(4).Value
            TextBoxLastActive.Text = EmployeeData.CurrentRow.Cells(5).Value

            connection.Close()
        Catch er As Exception
            MessageBox.Show("Unsuccessful Operation, Error: " & er.Message)
            connection.Close()
        End Try
    End Sub

    Private Sub ButtonStock_Click(sender As Object, e As EventArgs) Handles ButtonStock.Click
        Dim f As StockControl = New StockControl(employee)
        Hide()
        f.ShowDialog()
        Close()
    End Sub
End Class