Public Class Employee
    Public Property Id As Integer
    Public Property Name As String
    Public Property Username As String
    Public Property Password As String
    Public Property JobRole As String
    Public Property LastActive As Date

    Sub New(cId As Integer, cName As String, cUsername As String, cPassword As String, cJobRole As String)
        Id = cId
        Name = cName
        Username = cUsername
        Password = cPassword
        JobRole = cJobRole
    End Sub
End Class
