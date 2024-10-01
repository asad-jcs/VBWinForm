Imports System.Runtime.CompilerServices
Imports Service

Public Class LoginForm
    Private mainForm As Dashboard
    Private _userService As UserService
    Public Event OpenFormSubmitted(ByVal open As Boolean)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _userService = New UserService()
        mainForm = ServiceProvider.GetService(Of Dashboard)()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click


        Dim user = New User()

        user.Email = emailTextBox.Text
        user.Password = passwordTextBox.Text


        Dim res = _userService.Login(user)

        If (res IsNot Nothing) Then
            MessageBox.Show("Login Successful!")

            Dim plan As New PlanForm(res.Id)

            mainForm.ShowNavAfterLogin()

            ServiceProvider.SetSessionValue("User", res)

            mainForm.LoadForm(plan)
        End If
    End Sub

    Private Sub regLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles regLinkLabel.LinkClicked
        'Me.Hide()
        mainForm.LoadForm(New RegistrationForm())
    End Sub


End Class
