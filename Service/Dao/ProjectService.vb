Imports Dapper
Imports IBM.Data.Db2

Public Class ProjectService
    Inherits RootService
    Public Sub Add(project As Project)
        Using connection As New DB2Connection(_dbContext.ConnectionString)

            connection.Open()

            Dim query As String = "INSERT INTO TASK.Project (Name, Description, ClientId) VALUES (@Name, @Description, @ClientId)"

            connection.Execute(query, New With {
                .Name = project.Name,
                .Description = project.Description,
                .ClientId = project.ClientId
            })
        End Using
    End Sub

    Public Function GetAll()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select * from TASK.Project"

            Dim result As List(Of Project) = connection.Query(Of Project)(query).ToList()

            Return result
        End Using
    End Function

    Public Function GetAllProjectInfoWithClient()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select proj.Id, proj.Name, proj.Description, proj.ClientId, cli.Name as ClientName from TASK.Project proj inner join TASK.Client cli on proj.ClientId = cli.Id"

            Dim result As List(Of ProjectClientViewModel) = connection.Query(Of ProjectClientViewModel)(query).ToList()

            Return result
        End Using
    End Function

    Public Sub Delete(projectId As Integer)
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Delete from TASK.Project Where Id = @Id"

            connection.Execute(query, New With {
                .Id = projectId
            })
        End Using
    End Sub

    Public Sub Update(project As Project)
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Update TASK.Project set Name = @Name, Description = @Description, ClientId= @ClientId Where Id = @Id"

            connection.Execute(query, New With {
                .Id = project.Id,
                .Name = project.Name,
                .Description = project.Description,
                .ClientId = project.ClientId
            })
        End Using
    End Sub
End Class
