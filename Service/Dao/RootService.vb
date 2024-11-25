Public Class RootService
    Public ReadOnly _dbContext As MyDBContext
    Public _result As Result
    Public Sub New()
        _dbContext = New MyDBContext()
        _result = New Result()
    End Sub
End Class
