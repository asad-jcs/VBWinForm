<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        navPanel = New Panel()
        profileInfoPanel = New Panel()
        profilePictureBox = New PictureBox()
        pNameLabel = New Label()
        loginButton = New Button()
        MenuStrip = New MenuStrip()
        ManagementToolStripMenuItem = New ToolStripMenuItem()
        Home = New ToolStripMenuItem()
        Plan = New ToolStripMenuItem()
        Project = New ToolStripMenuItem()
        Client = New ToolStripMenuItem()
        Logout = New ToolStripMenuItem()
        timeLabel = New Label()
        mainPanel = New Panel()
        timePanel = New Panel()
        timePrintLabel = New Label()
        datePrintLabel = New Label()
        dateLabel = New Label()
        welcomeLabel = New Label()
        trackTimer = New Timer(components)
        clockPictureBox = New PictureBox()
        navPanel.SuspendLayout()
        profileInfoPanel.SuspendLayout()
        CType(profilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip.SuspendLayout()
        mainPanel.SuspendLayout()
        timePanel.SuspendLayout()
        CType(clockPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' navPanel
        ' 
        navPanel.BackColor = Color.Teal
        navPanel.Controls.Add(profileInfoPanel)
        navPanel.Controls.Add(loginButton)
        navPanel.Controls.Add(MenuStrip)
        navPanel.Dock = DockStyle.Left
        navPanel.Location = New Point(0, 0)
        navPanel.Name = "navPanel"
        navPanel.Size = New Size(165, 450)
        navPanel.TabIndex = 0
        ' 
        ' profileInfoPanel
        ' 
        profileInfoPanel.Controls.Add(profilePictureBox)
        profileInfoPanel.Controls.Add(pNameLabel)
        profileInfoPanel.Dock = DockStyle.Bottom
        profileInfoPanel.Location = New Point(0, 306)
        profileInfoPanel.Name = "profileInfoPanel"
        profileInfoPanel.Size = New Size(165, 50)
        profileInfoPanel.TabIndex = 10
        ' 
        ' profilePictureBox
        ' 
        profilePictureBox.Dock = DockStyle.Left
        profilePictureBox.Image = My.Resources.Resources.profile
        profilePictureBox.Location = New Point(0, 0)
        profilePictureBox.Name = "profilePictureBox"
        profilePictureBox.Size = New Size(35, 50)
        profilePictureBox.TabIndex = 9
        profilePictureBox.TabStop = False
        profilePictureBox.Visible = False
        ' 
        ' pNameLabel
        ' 
        pNameLabel.AutoSize = True
        pNameLabel.Font = New Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pNameLabel.ForeColor = SystemColors.ButtonHighlight
        pNameLabel.ImageAlign = ContentAlignment.MiddleLeft
        pNameLabel.Location = New Point(41, 13)
        pNameLabel.Name = "pNameLabel"
        pNameLabel.Size = New Size(100, 25)
        pNameLabel.TabIndex = 0
        pNameLabel.Text = "Username"
        pNameLabel.TextAlign = ContentAlignment.TopRight
        pNameLabel.Visible = False
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.PaleGreen
        loginButton.Dock = DockStyle.Bottom
        loginButton.ForeColor = SystemColors.ActiveBorder
        loginButton.Image = CType(resources.GetObject("loginButton.Image"), Image)
        loginButton.Location = New Point(0, 356)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(165, 94)
        loginButton.TabIndex = 8
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' MenuStrip
        ' 
        MenuStrip.BackColor = SystemColors.ActiveCaption
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {ManagementToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(10, 2, 0, 2)
        MenuStrip.Size = New Size(165, 28)
        MenuStrip.TabIndex = 7
        MenuStrip.Text = "MenuStrip"
        MenuStrip.Visible = False
        ' 
        ' ManagementToolStripMenuItem
        ' 
        ManagementToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Home, Plan, Project, Client, Logout})
        ManagementToolStripMenuItem.Image = My.Resources.Resources.menu_button1
        ManagementToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft
        ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        ManagementToolStripMenuItem.Size = New Size(80, 24)
        ManagementToolStripMenuItem.Text = "Menu"
        ' 
        ' Home
        ' 
        Home.BackColor = SystemColors.ActiveCaption
        Home.Name = "Home"
        Home.Size = New Size(139, 26)
        Home.Text = "Home"
        ' 
        ' Plan
        ' 
        Plan.BackColor = SystemColors.ActiveCaption
        Plan.Name = "Plan"
        Plan.Size = New Size(139, 26)
        Plan.Text = "Plan"
        ' 
        ' Project
        ' 
        Project.BackColor = SystemColors.ActiveCaption
        Project.Name = "Project"
        Project.Size = New Size(139, 26)
        Project.Text = "Project"
        ' 
        ' Client
        ' 
        Client.BackColor = SystemColors.ActiveCaption
        Client.Name = "Client"
        Client.Size = New Size(139, 26)
        Client.Text = "Client"
        ' 
        ' Logout
        ' 
        Logout.BackColor = SystemColors.ActiveCaption
        Logout.Name = "Logout"
        Logout.Size = New Size(139, 26)
        Logout.Text = "Logout"
        ' 
        ' timeLabel
        ' 
        timeLabel.AutoSize = True
        timeLabel.Font = New Font("Comic Sans MS", 20F, FontStyle.Bold)
        timeLabel.ForeColor = Color.FromArgb(CByte(95), CByte(39), CByte(205))
        timeLabel.Location = New Point(3, 72)
        timeLabel.Name = "timeLabel"
        timeLabel.Size = New Size(99, 48)
        timeLabel.TabIndex = 1
        timeLabel.Text = "Time"
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        mainPanel.Controls.Add(timePanel)
        mainPanel.Controls.Add(welcomeLabel)
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(165, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(635, 450)
        mainPanel.TabIndex = 1
        ' 
        ' timePanel
        ' 
        timePanel.BackColor = Color.MediumAquamarine
        timePanel.Controls.Add(clockPictureBox)
        timePanel.Controls.Add(timePrintLabel)
        timePanel.Controls.Add(datePrintLabel)
        timePanel.Controls.Add(dateLabel)
        timePanel.Controls.Add(timeLabel)
        timePanel.Dock = DockStyle.Top
        timePanel.Location = New Point(0, 0)
        timePanel.Name = "timePanel"
        timePanel.Size = New Size(635, 125)
        timePanel.TabIndex = 2
        ' 
        ' timePrintLabel
        ' 
        timePrintLabel.AutoSize = True
        timePrintLabel.Font = New Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timePrintLabel.ForeColor = Color.FromArgb(CByte(95), CByte(39), CByte(205))
        timePrintLabel.Location = New Point(108, 72)
        timePrintLabel.Name = "timePrintLabel"
        timePrintLabel.Size = New Size(91, 48)
        timePrintLabel.TabIndex = 4
        timePrintLabel.Text = "time"
        ' 
        ' datePrintLabel
        ' 
        datePrintLabel.AutoSize = True
        datePrintLabel.Font = New Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        datePrintLabel.ForeColor = Color.FromArgb(CByte(95), CByte(39), CByte(205))
        datePrintLabel.Location = New Point(108, 6)
        datePrintLabel.Name = "datePrintLabel"
        datePrintLabel.Size = New Size(94, 48)
        datePrintLabel.TabIndex = 3
        datePrintLabel.Text = "date"
        ' 
        ' dateLabel
        ' 
        dateLabel.AutoSize = True
        dateLabel.Font = New Font("Comic Sans MS", 20F, FontStyle.Bold)
        dateLabel.ForeColor = Color.FromArgb(CByte(95), CByte(39), CByte(205))
        dateLabel.Location = New Point(3, 6)
        dateLabel.Name = "dateLabel"
        dateLabel.Size = New Size(99, 48)
        dateLabel.TabIndex = 2
        dateLabel.Text = "Date"
        ' 
        ' welcomeLabel
        ' 
        welcomeLabel.AutoSize = True
        welcomeLabel.Font = New Font("Comic Sans MS", 50F, FontStyle.Bold)
        welcomeLabel.ForeColor = Color.FromArgb(CByte(95), CByte(39), CByte(205))
        welcomeLabel.Location = New Point(6, 125)
        welcomeLabel.Name = "welcomeLabel"
        welcomeLabel.Size = New Size(406, 117)
        welcomeLabel.TabIndex = 0
        welcomeLabel.Text = "Welcome"
        ' 
        ' trackTimer
        ' 
        ' 
        ' clockPictureBox
        ' 
        clockPictureBox.Dock = DockStyle.Right
        clockPictureBox.Image = My.Resources.Resources.icons8_clock
        clockPictureBox.Location = New Point(510, 0)
        clockPictureBox.Name = "clockPictureBox"
        clockPictureBox.Size = New Size(125, 125)
        clockPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
        clockPictureBox.TabIndex = 5
        clockPictureBox.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(mainPanel)
        Controls.Add(navPanel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Dashboard"
        Text = "Task Management"
        WindowState = FormWindowState.Maximized
        navPanel.ResumeLayout(False)
        navPanel.PerformLayout()
        profileInfoPanel.ResumeLayout(False)
        profileInfoPanel.PerformLayout()
        CType(profilePictureBox, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        timePanel.ResumeLayout(False)
        timePanel.PerformLayout()
        CType(clockPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents navPanel As Panel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents pNameLabel As Label
    Friend WithEvents planListLinkLabel As LinkLabel
    Friend WithEvents welcomeLabel As Label
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Home As ToolStripMenuItem
    Friend WithEvents Plan As ToolStripMenuItem
    Friend WithEvents Project As ToolStripMenuItem
    Friend WithEvents Client As ToolStripMenuItem
    Friend WithEvents Logout As ToolStripMenuItem
    Friend WithEvents loginButton As Button
    Friend WithEvents profilePictureBox As PictureBox
    Friend WithEvents profileInfoPanel As Panel
    Friend WithEvents timeLabel As Label
    Friend WithEvents trackTimer As Timer
    Friend WithEvents timePanel As Panel
    Friend WithEvents timePrintLabel As Label
    Friend WithEvents datePrintLabel As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents clockPictureBox As PictureBox
End Class
