Imports System.Data.SqlClient

Public Class CashFlow
    ReadOnly connection As New SqlConnection("Server= localhost; Database = stock; Integrated Security = true")
    Dim employee As Employee
    Sub New(loginEmployee As Employee)
        employee = loginEmployee
        InitializeComponent()
    End Sub
End Class