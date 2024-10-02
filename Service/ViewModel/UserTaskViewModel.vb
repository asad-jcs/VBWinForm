Public Class UserTaskViewModel
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

    Private _start_date As Date
    Public Property Start_Date() As Date
        Get
            Return _start_date
        End Get
        Set(ByVal value As Date)
            _start_date = value
        End Set
    End Property

    Private _end_date As Date
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
    Public Property User_ID() As Integer
        Get
            Return _user_id
        End Get
        Set(ByVal value As Integer)
            _user_id = value
        End Set
    End Property

    Private _username As String

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _completion As String

    Public Property Completion() As String
        Get
            Return _completion
        End Get
        Set(ByVal value As String)
            _completion = value
        End Set
    End Property

    Private _finishing_date As Date?

    Public Property Finishing_Date() As Date?
        Get
            Return _finishing_date
        End Get
        Set(ByVal value As Date?)
            _finishing_date = value
        End Set
    End Property
End Class
