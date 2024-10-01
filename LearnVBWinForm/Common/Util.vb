Public Class Util
    Private Shared _priority As New Dictionary(Of String, String)

    Public Sub New()
        _priority.Add("LOW", "Low")
        _priority.Add("MEDIUM", "Medium")
        _priority.Add("HIGH", "High")
    End Sub

    Public Shared Function PriorityList()
        Return _priority
    End Function

End Class
