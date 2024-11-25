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

        Dim msg = UIValidation.ValidateForm(Me)
        UIValidation.IsValidEmail(emailReqTextBox.Text)
        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)

        ElseIf Not UIValidation.IsValidEmail(emailReqTextBox.Text) Then
            Util.ShowMsg(EMAIL_FORMAT, msgLabel, True)
        Else
            Dim user = New User()

            user.Email = emailReqTextBox.Text
            user.Password = passwordReqTextBox.Text


            Dim res As Result = _userService.Login(user)

            If res.Status Then
                Dim plan As New PlanListForm()

                mainForm.ShowNavAfterLogin()

                ServiceProvider.SetSessionValue("User", CType(res.ResModel, User))

                mainForm.LoadForm(plan)
            Else
                Util.ShowMsg(res.ErrorMessage, msgLabel, True)
            End If

        End If

    End Sub

    Private Sub regButton_Click(sender As Object, e As EventArgs) Handles regButton.Click
        mainForm.LoadForm(New RegistrationForm())
    End Sub
End Class
