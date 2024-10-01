Public Class RootService
    Public ReadOnly _dbContext As MyDBContext

    Public Sub New()
        _dbContext = New MyDBContext()
    End Sub
End Class
