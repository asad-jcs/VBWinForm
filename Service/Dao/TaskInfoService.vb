Imports Dapper
Imports IBM.Data.Db2

Public Class TaskInfoService
    Inherits RootService

    Public Sub Add(taskInfo As Task_Info)
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
        End Using
    End Sub

    Public Function GetAll()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select ti.Id, ti.Title, ti.Description, ti.Start_Date, ti.End_Date, ti.Priority, ti.User_Id, ti.Completion, ti.Finishing_Date, us.Username, pj.Name As ProjectName, pj.Id as ProjectId from TASK.TASK_INFO ti left join AUTH.USER us on ti.User_Id= us.Id left join TASK.Project pj on ti.ProjectId = pj.Id"

            Dim result As List(Of UserTaskViewModel) = connection.Query(Of UserTaskViewModel)(query).ToList()

            Return result
        End Using
    End Function

    Public Sub UpdateTask(task As Task_Info)
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
    End Sub

    Public Function GetAllTasks()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select * from TASK.TASK_INFO"

            Dim result As List(Of Task_Info) = connection.Query(Of Task_Info)(query).ToList()

            Return result
        End Using
    End Function

    Public Sub Delete(taskId As Integer)
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Delete from TASK.TASK_INFO Where Id = @Id"

            connection.Execute(query, New With {
                .Id = taskId
            })
        End Using
    End Sub
End Class
