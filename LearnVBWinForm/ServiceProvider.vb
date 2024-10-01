Public Class ServiceProvider
    Private Shared _services As New Dictionary(Of Type, Object)
    Private Shared _sessionData As New Dictionary(Of String, Object)

    ' Register a service (Singleton)
    Public Shared Sub Register(Of T)(service As T)
        _services(GetType(T)) = service
    End Sub

    ' Resolve a service (Retrieve the Singleton instance)
    Public Shared Function GetService(Of T)() As T
        Return CType(_services(GetType(T)), T)
    End Function

    ' Store session-like data (key-value pair)
    Public Shared Sub SetSessionValue(key As String, value As Object)
        _sessionData(key) = value
    End Sub

    ' Retrieve session-like data
    Public Shared Function GetSessionValue(Of T)(key As String) As T
        If _sessionData.ContainsKey(key) Then
            Return CType(_sessionData(key), T)
        Else
            Return Nothing ' Returns Nothing if the key is not found
        End If
    End Function
End Class
