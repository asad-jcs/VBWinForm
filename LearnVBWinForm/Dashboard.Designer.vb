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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        navPanel = New Panel()
        Panel1 = New Panel()
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
        mainPanel = New Panel()
        welcomeLabel = New Label()
        navPanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(profilePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip.SuspendLayout()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' navPanel
        ' 
        navPanel.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        navPanel.Controls.Add(Panel1)
        navPanel.Controls.Add(loginButton)
        navPanel.Controls.Add(MenuStrip)
        navPanel.Dock = DockStyle.Left
        navPanel.Location = New Point(0, 0)
        navPanel.Name = "navPanel"
        navPanel.Size = New Size(165, 450)
        navPanel.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(profilePictureBox)
        Panel1.Controls.Add(pNameLabel)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 306)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(165, 50)
        Panel1.TabIndex = 10
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
        loginButton.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
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
        MenuStrip.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {ManagementToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
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
        Home.Name = "Home"
        Home.Size = New Size(139, 26)
        Home.Text = "Home"
        ' 
        ' Plan
        ' 
        Plan.Name = "Plan"
        Plan.Size = New Size(139, 26)
        Plan.Text = "Plan"
        ' 
        ' Project
        ' 
        Project.Name = "Project"
        Project.Size = New Size(139, 26)
        Project.Text = "Project"
        ' 
        ' Client
        ' 
        Client.Name = "Client"
        Client.Size = New Size(139, 26)
        Client.Text = "Client"
        ' 
        ' Logout
        ' 
        Logout.Name = "Logout"
        Logout.Size = New Size(139, 26)
        Logout.Text = "Logout"
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        mainPanel.Controls.Add(welcomeLabel)
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(165, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(635, 450)
        mainPanel.TabIndex = 1
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(profilePictureBox, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
End Class
