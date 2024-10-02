Imports Service

Public Class Dashboard

    Private CurrentForm As Form = Nothing
    Private user As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ServiceProvider.Register(Me)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loginLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles loginLinkLabel.LinkClicked

    End Sub

    Public Sub LoadForm(form As Form)

        ShowProfileName()

        If CurrentForm IsNot Nothing Then
            CurrentForm.Close()
            CurrentForm.Dispose()
        End If

        CurrentForm = form

        mainPanel.Controls.Clear()


        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        mainPanel.Controls.Add(form)

        form.Visible = True
        form.Show()
        form.BringToFront()

        mainPanel.Refresh()
    End Sub

    Private Sub ShowProfileName()
        user = ServiceProvider.GetSessionValue(Of User)("User")

        If user IsNot Nothing Then
            pNameLabel.Text = user.Username
        End If
    End Sub

    Public Sub ShowNavBeforeLogin()
        Me.logoutLinkLabel.Visible = False
        Me.planLinkLabel.Visible = False
        Me.pNameLabel.Visible = False
        Me.planListLinkLabel.Visible = False
        Me.planManageLinkLabel.Visible = False
        Me.welcomeLabel.Visible = True
        welcomeLabel.BringToFront()
        mainPanel.Controls.Add(welcomeLabel)
        Me.loginLinkLabel.Visible = True
    End Sub

    Public Sub ShowNavAfterLogin()
        Me.logoutLinkLabel.Visible = True
        Me.planLinkLabel.Visible = True
        Me.pNameLabel.Visible = True
        Me.planListLinkLabel.Visible = True
        Me.planManageLinkLabel.Visible = True
        welcomeLabel.Visible = False
        Me.loginLinkLabel.Visible = False
    End Sub

    Private Sub onLinkClickEvent(sender As Object, e As EventArgs) Handles loginLinkLabel.Click, logoutLinkLabel.Click, planLinkLabel.Click, planListLinkLabel.Click, navPanel.Click, planManageLinkLabel.Click
        Dim clickedLinkLabel = DirectCast(sender, LinkLabel)

        Select Case clickedLinkLabel.Name
            Case "loginLinkLabel"
                LoadForm(New LoginForm)
            Case "logoutLinkLabel"
                mainPanel.Controls.Clear()
                ShowNavBeforeLogin()
            Case "planLinkLabel"
                LoadForm(New PlanForm(user.Id))
            Case "planListLinkLabel"
                LoadForm(New PlanListForm)
            Case "planManageLinkLabel"
                LoadForm(New PlanManage)
            Case Else
                MessageBox.Show("Unknown LinkLabel clicked")
        End Select
    End Sub
End Class