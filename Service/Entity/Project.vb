Public Class Project
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property


    Private _name As String

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _clientId As Integer
    Public Property ClientId() As Integer
        Get
            Return _clientId
        End Get
        Set(ByVal value As Integer)
            _clientId = value
        End Set
    End Property
End Class
