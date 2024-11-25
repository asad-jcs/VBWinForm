Imports System.Reflection.Metadata.Ecma335
Imports Dapper
Imports IBM.Data.Db2

Public Class UserService
    Inherits RootService

    Public Function Login(user As User)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM Auth.User WHERE Email = @Email AND Password = @Password"

                ' Pass parameters using an anonymous object
                Dim _user = connection.QueryFirstOrDefault(Of User)(query, New With {
                    .Email = user.Email,
                    .Password = user.Password
                })

                If _user IsNot Nothing Then
                    _result.Status = True
                    _result.ResModel = _user
                    Return _result
                Else
                    Throw New Exception("User Id or Password did not matched")
                End If

            End Using
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

    Public Function Registration(user As User)

        Try
            Dim _user = GetUserByEmail(user.Email)

            If _user Is Nothing Then
                Using connection As New DB2Connection(_dbContext.ConnectionString)

                    connection.Open()

                    Dim query As String = "INSERT INTO Auth.User (Username, Password, Email) VALUES (@Username, @Password, @Email)"

                    connection.Execute(query, New With {
                        .Username = user.Username,
                        .Password = user.Password,
                        .Email = user.Email
                    })
                End Using

                _result.Status = True

                Return _result
            Else
                Throw New Exception("Email Already Exists")
            End If
        Catch ex As Exception
            _result.ErrorMessage = ex.Message
            _result.Status = False
        End Try

        Return _result
    End Function

    Public Function GetAll()
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Select * from AUTH.User"

                Dim result As List(Of User) = connection.Query(Of User)(query).ToList()

                _result.Status = True
                _result.ResModel = result
            End Using
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try
        Return _result
    End Function

    Public Function GetUserByEmail(email As String)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                Dim query As String = "SELECT * FROM Auth.User WHERE Email = @Email"

                ' Pass parameters using an anonymous object
                Dim result = connection.QueryFirstOrDefault(Of User)(query, New With {
                    .Email = email
                })

                _result.Status = True
                _result.ResModel = result
            End Using
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

End Class
