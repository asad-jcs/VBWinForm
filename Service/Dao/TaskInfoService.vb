Imports Dapper
Imports IBM.Data.Db2

Public Class TaskInfoService
    Inherits RootService

    Public Function Add(taskInfo As Task_Info)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)

                connection.Open()

                Dim query As String = "INSERT INTO TASK.TASK_INFO (Title, Description, Start_Date, End_Date, Priority, User_Id, ProjectId) VALUES (@Title, @Description, @Start_Date, @End_Date, @Priority, @User_Id, @ProjectId)"

                connection.Execute(query, New With {
                    .Title = taskInfo.Title,
                    .Description = taskInfo.Description,
                    .Start_Date = taskInfo.Start_Date,
                    .End_Date = taskInfo.End_Date,
                    .Priority = taskInfo.Priority,
                    .User_Id = taskInfo.UserID,
                    .ProjectId = taskInfo.ProjectId
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

                Dim query As String = "Select ti.Id, ti.Title, ti.Description, ti.Start_Date, ti.End_Date, ti.Priority, ti.User_Id, ti.Completion, ti.Finishing_Date, us.Username, pj.Name As ProjectName, pj.Id as ProjectId from TASK.TASK_INFO ti left join AUTH.USER us on ti.User_Id= us.Id left join TASK.Project pj on ti.ProjectId = pj.Id"

                Dim listOfTask As List(Of UserTaskViewModel) = connection.Query(Of UserTaskViewModel)(query).ToList()

                _result.Status = True
                _result.ResModel = listOfTask
            End Using
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try
        Return _result
    End Function

    Public Function UpdateTask(task As Task_Info)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Update TASK.TASK_INFO set Completion = @Completion, User_Id = @UserId, Finishing_Date= @FinishingDate Where Id = @Id"

                connection.Execute(query, New With {
                    .Id = task.Id,
                    .FinishingDate = task.Finishing_Date,
                    .Completion = task.Completion,
                    .UserId = task.UserID
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

    Public Function GetAllTasks()
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Select * from TASK.TASK_INFO"

                Dim result As List(Of Task_Info) = connection.Query(Of Task_Info)(query).ToList()

                _result.Status = True
                _result.ResModel = result
            End Using
        Catch ex As Exception
            _result.Status = False
            _result.ErrorMessage = ex.Message
        End Try

        Return _result
    End Function

    Public Function Delete(taskId As Integer)
        Try
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                Dim query As String = "Delete from TASK.TASK_INFO Where Id = @Id"

                connection.Execute(query, New With {
                    .Id = taskId
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

    Public Function GetAllBySearchKey(searchKey As String)
        Try
            Dim searchKeys As String() = searchKey.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)

            ' Start building the SQL query
            Dim query As String = "
                    SELECT 
                        ti.Id, ti.Title, ti.Description, ti.Start_Date, ti.End_Date, ti.Priority, 
                        ti.User_Id, ti.Completion, ti.Finishing_Date, us.Username, pj.Name AS ProjectName, 
                        pj.Id AS ProjectId 
                    FROM 
                        TASK.TASK_INFO ti 
                    LEFT JOIN 
                        AUTH.USER us ON ti.User_Id = us.Id 
                    LEFT JOIN 
                        TASK.Project pj ON ti.ProjectId = pj.Id
                    WHERE "

            ' List to store conditions
            Dim conditions As New List(Of String)()

            ' Build conditions for each search term
            For i As Integer = 0 To searchKeys.Length - 1
                conditions.Add($"
        (LOWER(ti.Title) LIKE @searchKey{i} OR 
        LOWER(ti.Id) LIKE @searchKey{i} OR
         LOWER(ti.Description) LIKE @searchKey{i} OR
         LOWER(ti.Start_Date) LIKE @searchKey{i} OR
         LOWER(ti.End_Date) LIKE @searchKey{i} OR
         LOWER(ti.Priority) LIKE @searchKey{i} OR
         LOWER(us.Username) LIKE @searchKey{i} OR
         LOWER(ti.Completion) LIKE @searchKey{i} OR
         LOWER(pj.Name) LIKE @searchKey{i})")
            Next

            ' Join all conditions with OR, so any match will work
            query &= String.Join(" OR ", conditions)

            ' Use DB2 connection with Dapper
            Using connection As New DB2Connection(_dbContext.ConnectionString)
                connection.Open()

                ' Create parameters for each search key
                Dim parameters As New DynamicParameters()
                For i As Integer = 0 To searchKeys.Length - 1
                    parameters.Add($"@searchKey{i}", "%" & searchKeys(i).ToLower() & "%") ' Use wildcard for LIKE search
                Next

                ' Execute the query and map results to your view model
                Dim result As List(Of UserTaskViewModel) = connection.Query(Of UserTaskViewModel)(query, parameters).ToList()

                ' Return the result
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
End Class
