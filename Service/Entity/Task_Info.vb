Public Class Task_Info
    Private _id As String
    Public Property Id() As String
        Get
            Return _id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property


    Private _title As String

    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
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

    Private _start_date As String
    Public Property Start_Date() As Date
        Get
            Return _start_date
        End Get
        Set(ByVal value As Date)
            _start_date = value
        End Set
    End Property

    Private _end_date As String
    Public Property End_Date() As Date
        Get
            Return _end_date
        End Get
        Set(ByVal value As Date)
            _end_date = value
        End Set
    End Property

    Private _priority As String
    Public Property Priority() As String
        Get
            Return _priority
        End Get
        Set(ByVal value As String)
            _priority = value
        End Set
    End Property

    Private _user_id As String
    Public Property UserID() As Integer
        Get
            Return _user_id
        End Get
        Set(ByVal value As Integer)
            _user_id = value
        End Set
    End Property
End Class
