Imports Dapper
Imports IBM.Data.Db2

Public Class TaskInfoService
    Inherits RootService

    Public Sub Add(taskInfo As Task_Info)
        Using connection As New DB2Connection(_dbContext.ConnectionString)

            connection.Open()

            Dim query As String = "INSERT INTO TASK.TASK_INFO (Title, Description, Start_Date, End_Date, Priority, User_Id) VALUES (@Title, @Description, @Start_Date, @End_Date, @Priority, @User_Id)"

            connection.Execute(query, New With {
                .Title = taskInfo.Title,
                .Description = taskInfo.Description,
                .Start_Date = taskInfo.Start_Date,
                .End_Date = taskInfo.End_Date,
                .Priority = taskInfo.Priority,
                .User_Id = taskInfo.UserID
            })
        End Using
    End Sub

    Public Function GetAll()
        Using connection As New DB2Connection(_dbContext.ConnectionString)
            connection.Open()

            Dim query As String = "Select * from TASK.TASK_INFO"

            Dim result As List(Of Task_Info) = connection.Query(Of Task_Info)(query).ToList()

            Return result
        End Using
    End Function
End Class
