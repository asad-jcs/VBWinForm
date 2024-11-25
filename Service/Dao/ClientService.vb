Imports Dapper
Imports IBM.Data.Db2

Public Class ClientService
    Inherits RootService

    Public Function Add(client As Client)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)

                connection.Open()

                Dim query As String = "INSERT INTO TASK.Client (Name, Phone, Email, Address) VALUES (@Name, @Phone, @Email, @Address)"

                connection.Execute(query, New With {
                    .Name = client.Name,
                    .Phone = client.Phone,
                    .Email = client.Email,
                    .Address = client.Address
                })
            End Using

            _result.Status = True

            Return _result
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

    Public Function GetAll()
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Select * from TASK.Client"

                Dim listOfClient As List(Of Client) = connection.Query(Of Client)(query).ToList()

                _result.Status = True
                _result.ResModel = listOfClient

            End Using
        Catch ex As Exception
            _result.ErrorMessage = ex.Message
            _result.Status = True
        End Try

        Return _result
    End Function

    Public Function Delete(clientId As Integer)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Delete from TASK.Client Where Id = @Id"

                connection.Execute(query, New With {
                    .Id = clientId
                })
            End Using
            _result.Status = True

            Return _result
        Catch ex As Exception
            _result.ErrorMessage = ex.Message
            _result.Status = True
        End Try

        Return _result
    End Function

    Public Function Update(client As Client)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Update TASK.Client set Name = @Name, Phone = @Phone, Email= @Email, Address= @Address Where Id = @Id"

                connection.Execute(query, New With {
                    .Id = client.Id,
                    .Name = client.Name,
                    .Phone = client.Phone,
                    .Email = client.Email,
                    .Address = client.Address
                })
            End Using

            _result.Status = True
            Return _result
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

End Class
