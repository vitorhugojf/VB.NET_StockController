Imports System.Data.SqlClient

Public Class Login

    ReadOnly connection As New SqlConnection("Server= localhost; Database = stock; Integrated Security = true")

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim searchQuery As String = "SELECT * From employee WHERE username = '" & TextBoxUsername.Text & "' AND password = '" & TextBoxPassword.Text & "'"
        Dim commandSearch As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(commandSearch)
        Dim table As New DataTable()
        adapter.Fill(table)

        Try
            Dim employee As Employee = New Employee(table.Rows.Item(0).ItemArray(0), table.Rows.Item(0).ItemArray(1), table.Rows.Item(0).ItemArray(2),
                                                       table.Rows.Item(0).ItemArray(3), table.Rows.Item(0).ItemArray(4))
            MsgBox("Successfully logged in")

            
            connection.Open()
            Dim updateQuery As String = "UPDATE employee SET LastActive = '" & Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second & "' WHERE id = " & employee.Id
            Dim commandUpdate As New SqlCommand(updateQuery, connection)
            commandUpdate.ExecuteNonQuery()
            connection.Close()

            Dim f As StockControl = New StockControl(employee)
            Hide()
            f.ShowDialog()
            Close()

        Catch er As Exception
            MsgBox("The Employee doesn't exists")
        End Try
    End Sub
End Class