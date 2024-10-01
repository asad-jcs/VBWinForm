Imports System.IO
Imports Microsoft.Extensions.Configuration


Public Class MyDBContext

    Public Property ConnectionString As String

    Public Sub New()
        ConnectionString = GetConnectionString()
    End Sub


    Public Shared Function GetConnectionString() As String
        Dim config As IConfiguration = New ConfigurationBuilder() _
            .SetBasePath(Directory.GetCurrentDirectory()) _
            .AddJsonFile("appsettings.json") _
            .Build()

        Return config.GetConnectionString("DefaultConnection")
    End Function

End Class
