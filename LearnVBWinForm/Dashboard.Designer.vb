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
        navPanel = New Panel()
        planListLinkLabel = New LinkLabel()
        pNameLabel = New Label()
        logoutLinkLabel = New LinkLabel()
        planLinkLabel = New LinkLabel()
        loginLinkLabel = New LinkLabel()
        mainPanel = New Panel()
        navPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' navPanel
        ' 
        navPanel.BackColor = Color.FromArgb(CByte(155), CByte(89), CByte(182))
        navPanel.Controls.Add(planListLinkLabel)
        navPanel.Controls.Add(pNameLabel)
        navPanel.Controls.Add(logoutLinkLabel)
        navPanel.Controls.Add(planLinkLabel)
        navPanel.Controls.Add(loginLinkLabel)
        navPanel.Dock = DockStyle.Left
        navPanel.Location = New Point(0, 0)
        navPanel.Name = "navPanel"
        navPanel.Size = New Size(136, 450)
        navPanel.TabIndex = 0
        ' 
        ' planListLinkLabel
        ' 
        planListLinkLabel.AutoSize = True
        planListLinkLabel.LinkColor = Color.Yellow
        planListLinkLabel.Location = New Point(3, 102)
        planListLinkLabel.Name = "planListLinkLabel"
        planListLinkLabel.Size = New Size(63, 20)
        planListLinkLabel.TabIndex = 3
        planListLinkLabel.TabStop = True
        planListLinkLabel.Text = "Plan List"
        planListLinkLabel.Visible = False
        ' 
        ' pNameLabel
        ' 
        pNameLabel.AutoSize = True
        pNameLabel.Location = New Point(6, 9)
        pNameLabel.Name = "pNameLabel"
        pNameLabel.Size = New Size(0, 20)
        pNameLabel.TabIndex = 0
        ' 
        ' logoutLinkLabel
        ' 
        logoutLinkLabel.AutoSize = True
        logoutLinkLabel.LinkColor = Color.Yellow
        logoutLinkLabel.Location = New Point(3, 36)
        logoutLinkLabel.Name = "logoutLinkLabel"
        logoutLinkLabel.Size = New Size(56, 20)
        logoutLinkLabel.TabIndex = 2
        logoutLinkLabel.TabStop = True
        logoutLinkLabel.Text = "Logout"
        logoutLinkLabel.Visible = False
        ' 
        ' planLinkLabel
        ' 
        planLinkLabel.AutoSize = True
        planLinkLabel.LinkColor = Color.Yellow
        planLinkLabel.Location = New Point(3, 68)
        planLinkLabel.Name = "planLinkLabel"
        planLinkLabel.Size = New Size(37, 20)
        planLinkLabel.TabIndex = 1
        planLinkLabel.TabStop = True
        planLinkLabel.Text = "Plan"
        planLinkLabel.Visible = False
        ' 
        ' loginLinkLabel
        ' 
        loginLinkLabel.AutoSize = True
        loginLinkLabel.LinkColor = Color.Yellow
        loginLinkLabel.Location = New Point(3, 36)
        loginLinkLabel.Name = "loginLinkLabel"
        loginLinkLabel.Size = New Size(46, 20)
        loginLinkLabel.TabIndex = 0
        loginLinkLabel.TabStop = True
        loginLinkLabel.Text = "Login"
        ' 
        ' mainPanel
        ' 
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(136, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(664, 450)
        mainPanel.TabIndex = 1
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(mainPanel)
        Controls.Add(navPanel)
        Name = "Dashboard"
        Text = "Task Tracking App"
        WindowState = FormWindowState.Maximized
        navPanel.ResumeLayout(False)
        navPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents navPanel As Panel
    Friend WithEvents loginLinkLabel As LinkLabel
    Friend WithEvents mainPanel As Panel
    Friend WithEvents logoutLinkLabel As LinkLabel
    Friend WithEvents planLinkLabel As LinkLabel
    Friend WithEvents pNameLabel As Label
    Friend WithEvents planListLinkLabel As LinkLabel
End Class
