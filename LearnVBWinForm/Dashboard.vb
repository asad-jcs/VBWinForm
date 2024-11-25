Imports Service

Public Class Dashboard

    Private CurrentForm As Form = Nothing
    Private user As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ServiceProvider.Register(Me)
        trackTimer.Start()

        ' Add any initialization after the InitializeComponent() call.

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


        Me.pNameLabel.Visible = False
        Me.timePanel.Visible = True
        timePanel.BringToFront()
        Me.welcomeLabel.Visible = True
        welcomeLabel.BringToFront()
        mainPanel.Controls.Add(welcomeLabel)
        mainPanel.Controls.Add(timePanel)
        Me.loginButton.Visible = True
        Me.profilePictureBox.Visible = False
        Me.MenuStrip.Visible = False
    End Sub

    Public Sub ShowNavAfterLogin()

        Me.pNameLabel.Visible = True

        welcomeLabel.Visible = False
        Me.loginButton.Visible = False
        Me.profilePictureBox.Visible = True
        Me.MenuStrip.Visible = True
    End Sub

    Private Sub onLinkClickEvent(sender As Object, e As EventArgs) Handles planListLinkLabel.Click, Home.Click, Plan.Click, Project.Click, Client.Click, Logout.Click
        Dim clickedLinkLabel = DirectCast(sender, ToolStripMenuItem)

        Select Case clickedLinkLabel.Name
            Case LOGIN_MENU
                LoadForm(New LoginForm)
            Case LOGOUT_MENU
                mainPanel.Controls.Clear()
                ShowNavBeforeLogin()
            Case HOME_MENU
                LoadForm(New PlanListForm)
            Case PLAN_MENU
                LoadForm(New PlanManage)
            Case CLIENT_MENU
                LoadForm(New ClientForm)
            Case PROJECT_MENU
                LoadForm(New ProjectForm)
            Case Else
                MessageBox.Show("Unknown LinkLabel clicked")
        End Select
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        LoadForm(New LoginForm)
    End Sub

    Private Sub trackTimer_Tick(sender As Object, e As EventArgs) Handles trackTimer.Tick
        timePrintLabel.Text = DateTime.Now.ToLongTimeString()
        datePrintLabel.Text = DateTime.Now.ToLongDateString()
    End Sub
End Class