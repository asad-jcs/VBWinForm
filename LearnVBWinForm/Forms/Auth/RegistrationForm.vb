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

        Dim msg = UIValidation.ValidateForm(Me)
        UIValidation.IsValidEmail(emailReqTextBox.Text)
        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)
        ElseIf Not UIValidation.IsValidEmail(emailReqTextBox.Text) Then
            Util.ShowMsg(EMAIL_FORMAT, msgLabel, True)
        Else
            Dim user = New User

            user.Username = usernameReqTextBox.Text
            user.Email = emailReqTextBox.Text
            If cnfPasswordReqTextBox.Text = passwordReqTextBox.Text Then
                user.Password = passwordReqTextBox.Text
                Dim result As Result = _userService.Registration(user)
                If result.Status Then
                    Util.ClearAllInputs(Me)
                    Util.ShowMsg("Data Saved Successfully!", msgLabel)
                Else
                    Util.ShowMsg(result.ErrorMessage, msgLabel, True)
                End If
            Else
                Util.ShowMsg("Password did not match!", msgLabel, True)
            End If


        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Util.ClearAllInputs(Me)
    End Sub
End Class