Imports Dapper
Imports IBM.Data.Db2

Public Class UserService
    Inherits RootService

    Public Function Login(user As User)
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM Auth.User WHERE Email = @Email AND Password = @Password"

            ' Pass parameters using an anonymous object
            Dim result = connection.QueryFirstOrDefault(Of User)(query, New With {
                .Email = user.Email,
                .Password = user.Password
            })

            Return result
        End Using
    End Function

    Public Sub Registration(user As User)
        Using connection As New DB2Connection(_dbContext.ConnectionString)

            connection.Open()

            Dim query As String = "INSERT INTO Auth.User (Username, Password, Email) VALUES (@Username, @Password, @Email)"

            connection.Execute(query, New With {
                .Username = user.Username,
                .Password = user.Password,
                .Email = user.Email
            })
        End Using
    End Sub

    Public Function GetAll()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select * from AUTH.User"

            Dim result As List(Of User) = connection.Query(Of User)(query).ToList()

            Return result
        End Using
    End Function

End Class
