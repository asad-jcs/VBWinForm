<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        emailTextBox = New TextBox()
        emailLabel = New Label()
        usernameLabel = New Label()
        usernameTextBox = New TextBox()
        passwordLabel = New Label()
        passwordTextBox = New TextBox()
        cnfPasswordLabel = New Label()
        cnfPasswordTextBox = New TextBox()
        regButton = New Button()
        loginTableLayoutPanel = New TableLayoutPanel()
        loginLabel = New Label()
        loginTableLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(166, 96)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(194, 27)
        emailTextBox.TabIndex = 0
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(12, 99)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 1
        emailLabel.Text = "Email"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Location = New Point(12, 132)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(75, 20)
        usernameLabel.TabIndex = 3
        usernameLabel.Text = "Username"
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(166, 129)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(194, 27)
        usernameTextBox.TabIndex = 2
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(12, 165)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 5
        passwordLabel.Text = "Password"
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(166, 162)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(194, 27)
        passwordTextBox.TabIndex = 4
        ' 
        ' cnfPasswordLabel
        ' 
        cnfPasswordLabel.AutoSize = True
        cnfPasswordLabel.Location = New Point(12, 198)
        cnfPasswordLabel.Name = "cnfPasswordLabel"
        cnfPasswordLabel.Size = New Size(127, 20)
        cnfPasswordLabel.TabIndex = 7
        cnfPasswordLabel.Text = "Confirm Password"
        ' 
        ' cnfPasswordTextBox
        ' 
        cnfPasswordTextBox.Location = New Point(166, 195)
        cnfPasswordTextBox.Name = "cnfPasswordTextBox"
        cnfPasswordTextBox.Size = New Size(194, 27)
        cnfPasswordTextBox.TabIndex = 6
        ' 
        ' regButton
        ' 
        regButton.BackColor = Color.BlueViolet
        regButton.Image = My.Resources.Resources.icons8_create_16
        regButton.ImageAlign = ContentAlignment.MiddleRight
        regButton.Location = New Point(241, 228)
        regButton.Name = "regButton"
        regButton.Size = New Size(119, 34)
        regButton.TabIndex = 8
        regButton.Text = "Create"
        regButton.UseVisualStyleBackColor = False
        ' 
        ' loginTableLayoutPanel
        ' 
        loginTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        loginTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        loginTableLayoutPanel.ColumnCount = 5
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.3065987F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.7687759F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.79963F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.81840134F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.3065987F))
        loginTableLayoutPanel.Controls.Add(loginLabel, 2, 0)
        loginTableLayoutPanel.Dock = DockStyle.Top
        loginTableLayoutPanel.Location = New Point(0, 0)
        loginTableLayoutPanel.Name = "loginTableLayoutPanel"
        loginTableLayoutPanel.RowCount = 1
        loginTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        loginTableLayoutPanel.Size = New Size(800, 57)
        loginTableLayoutPanel.TabIndex = 16
        ' 
        ' loginLabel
        ' 
        loginLabel.AutoSize = True
        loginLabel.Font = New Font("Comic Sans MS", 20F)
        loginLabel.ForeColor = SystemColors.ControlLightLight
        loginLabel.Location = New Point(347, 0)
        loginLabel.Name = "loginLabel"
        loginLabel.Size = New Size(216, 47)
        loginLabel.TabIndex = 0
        loginLabel.Text = "Registration"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(loginTableLayoutPanel)
        Controls.Add(regButton)
        Controls.Add(cnfPasswordLabel)
        Controls.Add(cnfPasswordTextBox)
        Controls.Add(passwordLabel)
        Controls.Add(passwordTextBox)
        Controls.Add(usernameLabel)
        Controls.Add(usernameTextBox)
        Controls.Add(emailLabel)
        Controls.Add(emailTextBox)
        Name = "RegistrationForm"
        Text = "RegistrationForm"
        WindowState = FormWindowState.Maximized
        loginTableLayoutPanel.ResumeLayout(False)
        loginTableLayoutPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents cnfPasswordLabel As Label
    Friend WithEvents cnfPasswordTextBox As TextBox
    Friend WithEvents regButton As Button
    Friend WithEvents loginTableLayoutPanel As TableLayoutPanel
    Friend WithEvents loginLabel As Label
End Class
