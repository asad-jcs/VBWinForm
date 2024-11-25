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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        emailReqTextBox = New TextBox()
        emailLabel = New Label()
        usernameLabel = New Label()
        usernameReqTextBox = New TextBox()
        passwordLabel = New Label()
        passwordReqTextBox = New TextBox()
        cnfPasswordLabel = New Label()
        cnfPasswordReqTextBox = New TextBox()
        regButton = New Button()
        loginTableLayoutPanel = New TableLayoutPanel()
        loginLabel = New Label()
        clearButton = New Button()
        messagePanel = New Panel()
        msgLabel = New Label()
        loginTableLayoutPanel.SuspendLayout()
        messagePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' emailReqTextBox
        ' 
        emailReqTextBox.Location = New Point(145, 72)
        emailReqTextBox.Margin = New Padding(3, 2, 3, 2)
        emailReqTextBox.Name = "emailReqTextBox"
        emailReqTextBox.Size = New Size(170, 23)
        emailReqTextBox.TabIndex = 0
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(10, 74)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(36, 15)
        emailLabel.TabIndex = 1
        emailLabel.Text = "Email"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Location = New Point(10, 99)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(60, 15)
        usernameLabel.TabIndex = 3
        usernameLabel.Text = "Username"
        ' 
        ' usernameReqTextBox
        ' 
        usernameReqTextBox.Location = New Point(145, 97)
        usernameReqTextBox.Margin = New Padding(3, 2, 3, 2)
        usernameReqTextBox.Name = "usernameReqTextBox"
        usernameReqTextBox.Size = New Size(170, 23)
        usernameReqTextBox.TabIndex = 2
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(10, 124)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(57, 15)
        passwordLabel.TabIndex = 5
        passwordLabel.Text = "Password"
        ' 
        ' passwordReqTextBox
        ' 
        passwordReqTextBox.Location = New Point(145, 122)
        passwordReqTextBox.Margin = New Padding(3, 2, 3, 2)
        passwordReqTextBox.Name = "passwordReqTextBox"
        passwordReqTextBox.Size = New Size(170, 23)
        passwordReqTextBox.TabIndex = 4
        ' 
        ' cnfPasswordLabel
        ' 
        cnfPasswordLabel.AutoSize = True
        cnfPasswordLabel.Location = New Point(10, 148)
        cnfPasswordLabel.Name = "cnfPasswordLabel"
        cnfPasswordLabel.Size = New Size(104, 15)
        cnfPasswordLabel.TabIndex = 7
        cnfPasswordLabel.Text = "Confirm Password"
        ' 
        ' cnfPasswordReqTextBox
        ' 
        cnfPasswordReqTextBox.Location = New Point(145, 146)
        cnfPasswordReqTextBox.Margin = New Padding(3, 2, 3, 2)
        cnfPasswordReqTextBox.Name = "cnfPasswordReqTextBox"
        cnfPasswordReqTextBox.Size = New Size(170, 23)
        cnfPasswordReqTextBox.TabIndex = 6
        ' 
        ' regButton
        ' 
        regButton.BackColor = Color.BlueViolet
        regButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regButton.ForeColor = SystemColors.ButtonHighlight
        regButton.Image = My.Resources.Resources.icons8_create_16
        regButton.ImageAlign = ContentAlignment.MiddleRight
        regButton.Location = New Point(211, 171)
        regButton.Margin = New Padding(3, 2, 3, 2)
        regButton.Name = "regButton"
        regButton.Size = New Size(104, 26)
        regButton.TabIndex = 8
        regButton.Text = "Sign Up"
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
        loginTableLayoutPanel.Margin = New Padding(3, 2, 3, 2)
        loginTableLayoutPanel.Name = "loginTableLayoutPanel"
        loginTableLayoutPanel.RowCount = 1
        loginTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        loginTableLayoutPanel.Size = New Size(700, 43)
        loginTableLayoutPanel.TabIndex = 16
        ' 
        ' loginLabel
        ' 
        loginLabel.AutoSize = True
        loginLabel.Font = New Font("Comic Sans MS", 20F)
        loginLabel.ForeColor = SystemColors.ControlLightLight
        loginLabel.Location = New Point(304, 0)
        loginLabel.Name = "loginLabel"
        loginLabel.Size = New Size(172, 38)
        loginLabel.TabIndex = 0
        loginLabel.Text = "Registration"
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = SystemColors.ActiveBorder
        clearButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        clearButton.Image = CType(resources.GetObject("clearButton.Image"), Image)
        clearButton.ImageAlign = ContentAlignment.MiddleRight
        clearButton.Location = New Point(123, 171)
        clearButton.Margin = New Padding(3, 2, 3, 2)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(82, 26)
        clearButton.TabIndex = 17
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' messagePanel
        ' 
        messagePanel.Controls.Add(msgLabel)
        messagePanel.Dock = DockStyle.Bottom
        messagePanel.Location = New Point(0, 244)
        messagePanel.Margin = New Padding(9, 8, 9, 8)
        messagePanel.Name = "messagePanel"
        messagePanel.Size = New Size(700, 94)
        messagePanel.TabIndex = 18
        ' 
        ' msgLabel
        ' 
        msgLabel.AutoSize = True
        msgLabel.Dock = DockStyle.Top
        msgLabel.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        msgLabel.Location = New Point(0, 0)
        msgLabel.Margin = New Padding(9, 8, 9, 8)
        msgLabel.Name = "msgLabel"
        msgLabel.Size = New Size(0, 21)
        msgLabel.TabIndex = 0
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(700, 338)
        ControlBox = False
        Controls.Add(messagePanel)
        Controls.Add(clearButton)
        Controls.Add(loginTableLayoutPanel)
        Controls.Add(regButton)
        Controls.Add(cnfPasswordLabel)
        Controls.Add(cnfPasswordReqTextBox)
        Controls.Add(passwordLabel)
        Controls.Add(passwordReqTextBox)
        Controls.Add(usernameLabel)
        Controls.Add(usernameReqTextBox)
        Controls.Add(emailLabel)
        Controls.Add(emailReqTextBox)
        Margin = New Padding(3, 2, 3, 2)
        Name = "RegistrationForm"
        Text = "RegistrationForm"
        WindowState = FormWindowState.Maximized
        loginTableLayoutPanel.ResumeLayout(False)
        loginTableLayoutPanel.PerformLayout()
        messagePanel.ResumeLayout(False)
        messagePanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents emailReqTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents usernameReqTextBox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordReqTextBox As TextBox
    Friend WithEvents cnfPasswordLabel As Label
    Friend WithEvents cnfPasswordReqTextBox As TextBox
    Friend WithEvents regButton As Button
    Friend WithEvents loginTableLayoutPanel As TableLayoutPanel
    Friend WithEvents loginLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents messagePanel As Panel
    Friend WithEvents msgLabel As Label
End Class
