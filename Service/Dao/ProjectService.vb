Imports Dapper
Imports IBM.Data.Db2

Public Class ProjectService
    Inherits RootService
    Public Function Add(project As Project)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)

                connection.Open()

                Dim query As String = "INSERT INTO TASK.Project (Name, Description, ClientId) VALUES (@Name, @Description, @ClientId)"

                connection.Execute(query, New With {
                    .Name = project.Name,
                    .Description = project.Description,
                    .ClientId = project.ClientId
                })

                _result.Status = True
                Return _result
            End Using
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

                Dim query As String = "Select * from TASK.Project"

                Dim result As List(Of Project) = connection.Query(Of Project)(query).ToList()

                _result.Status = True
                _result.ResModel = result

                Return _result
            End Using
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

    Public Function GetAllProjectInfoWithClient()
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Select proj.Id, proj.Name, proj.Description, proj.ClientId, cli.Name as ClientName from TASK.Project proj inner join TASK.Client cli on proj.ClientId = cli.Id"

                Dim result As List(Of ProjectClientViewModel) = connection.Query(Of ProjectClientViewModel)(query).ToList()

                _result.Status = True
                _result.ResModel = result
            End Using

            Return _result
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

    Public Function Delete(projectId As Integer)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Delete from TASK.Project Where Id = @Id"

                connection.Execute(query, New With {
                    .Id = projectId
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

    Public Function Update(project As Project)
        Try
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

            _result.Status = True
            Return _result

        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try
        Return _result
    End Function
End Class
