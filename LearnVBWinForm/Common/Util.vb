Public Class Util
    Private Shared _priority As New Dictionary(Of String, String) From {
        {"LOW", "Low"},
        {"MEDIUM", "Medium"},
        {"HIGH", "High"}
    }

    Public Shared Function PriorityList()
        Return _priority
    End Function

End Class
