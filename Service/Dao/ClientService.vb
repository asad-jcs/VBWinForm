Imports Dapper
Imports IBM.Data.Db2

Public Class ClientService
    Inherits RootService

    Public Sub Add(client As Client)
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
    End Sub

    Public Function GetAll()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select * from TASK.Client"

            Dim result As List(Of Client) = connection.Query(Of Client)(query).ToList()

            Return result
        End Using
    End Function

    Public Sub Delete(clientId As Integer)
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Delete from TASK.Client Where Id = @Id"

            connection.Execute(query, New With {
                .Id = clientId
            })
        End Using
    End Sub

    Public Sub Update(client As Client)
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
    End Sub

End Class
