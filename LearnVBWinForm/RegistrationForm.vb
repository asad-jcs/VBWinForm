Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices
Imports Service

Public Class RegistrationForm
    Private mainForm As Dashboard
    Private _userService As UserService
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _userService = New UserService()
        mainForm = ServiceProvider.GetService(Of Dashboard)()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub regButton_Click(sender As Object, e As EventArgs) Handles regButton.Click
        Dim user = New User()

        user.Username = usernameTextBox.Text
        user.Email = emailTextBox.Text
        If cnfPasswordTextBox.Text = passwordTextBox.Text Then
            user.Password = passwordTextBox.Text
            _userService.Registration(user)
        Else
            MessageBox.Show("Password did not match!")
        End If

        MessageBox.Show("Data Saved Successfully!")

    End Sub
End Class