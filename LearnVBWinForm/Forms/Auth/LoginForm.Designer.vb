<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        emailReqTextBox = New TextBox()
        emailLabel = New Label()
        passwordLabel = New Label()
        passwordReqTextBox = New TextBox()
        loginButton = New Button()
        loginTableLayoutPanel = New TableLayoutPanel()
        loginLabel = New Label()
        regButton = New Button()
        messagePanel = New Panel()
        msgLabel = New Label()
        loginTableLayoutPanel.SuspendLayout()
        messagePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' emailReqTextBox
        ' 
        emailReqTextBox.Location = New Point(113, 92)
        emailReqTextBox.Name = "emailReqTextBox"
        emailReqTextBox.Size = New Size(170, 27)
        emailReqTextBox.TabIndex = 0
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(29, 95)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 1
        emailLabel.Text = "Email"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(29, 128)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 7
        passwordLabel.Text = "Password"
        ' 
        ' passwordReqTextBox
        ' 
        passwordReqTextBox.Location = New Point(113, 125)
        passwordReqTextBox.Name = "passwordReqTextBox"
        passwordReqTextBox.Size = New Size(170, 27)
        passwordReqTextBox.TabIndex = 6
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.SpringGreen
        loginButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginButton.Image = My.Resources.Resources.icons8_login_16
        loginButton.ImageAlign = ContentAlignment.MiddleRight
        loginButton.Location = New Point(189, 157)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(94, 29)
        loginButton.TabIndex = 8
        loginButton.Text = "Sign In"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' loginTableLayoutPanel
        ' 
        loginTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        loginTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        loginTableLayoutPanel.ColumnCount = 5
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.30457F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 22.7664986F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 21.7766514F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.8477163F))
        loginTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.3045712F))
        loginTableLayoutPanel.Controls.Add(loginLabel, 2, 0)
        loginTableLayoutPanel.Controls.Add(regButton, 0, 0)
        loginTableLayoutPanel.Dock = DockStyle.Top
        loginTableLayoutPanel.Location = New Point(0, 0)
        loginTableLayoutPanel.Name = "loginTableLayoutPanel"
        loginTableLayoutPanel.RowCount = 1
        loginTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        loginTableLayoutPanel.Size = New Size(800, 57)
        loginTableLayoutPanel.TabIndex = 15
        ' 
        ' loginLabel
        ' 
        loginLabel.AutoSize = True
        loginLabel.Font = New Font("Comic Sans MS", 20F)
        loginLabel.ForeColor = SystemColors.ControlLightLight
        loginLabel.Location = New Point(347, 0)
        loginLabel.Name = "loginLabel"
        loginLabel.Size = New Size(103, 47)
        loginLabel.TabIndex = 0
        loginLabel.Text = "Login"
        ' 
        ' regButton
        ' 
        regButton.BackColor = Color.DarkKhaki
        regButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regButton.Image = My.Resources.Resources.icons8_registration_16
        regButton.ImageAlign = ContentAlignment.MiddleRight
        regButton.Location = New Point(3, 3)
        regButton.Name = "regButton"
        regButton.Size = New Size(134, 29)
        regButton.TabIndex = 16
        regButton.Text = "Registration"
        regButton.UseVisualStyleBackColor = False
        ' 
        ' messagePanel
        ' 
        messagePanel.Controls.Add(msgLabel)
        messagePanel.Dock = DockStyle.Bottom
        messagePanel.Location = New Point(0, 326)
        messagePanel.Margin = New Padding(10, 11, 10, 11)
        messagePanel.Name = "messagePanel"
        messagePanel.Size = New Size(800, 125)
        messagePanel.TabIndex = 19
        ' 
        ' msgLabel
        ' 
        msgLabel.AutoSize = True
        msgLabel.Dock = DockStyle.Top
        msgLabel.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        msgLabel.Location = New Point(0, 0)
        msgLabel.Margin = New Padding(10, 11, 10, 11)
        msgLabel.Name = "msgLabel"
        msgLabel.Size = New Size(0, 25)
        msgLabel.TabIndex = 0
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(800, 451)
        ControlBox = False
        Controls.Add(messagePanel)
        Controls.Add(loginTableLayoutPanel)
        Controls.Add(loginButton)
        Controls.Add(passwordLabel)
        Controls.Add(passwordReqTextBox)
        Controls.Add(emailLabel)
        Controls.Add(emailReqTextBox)
        Name = "LoginForm"
        Text = "Login"
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
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordReqTextBox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents loginTableLayoutPanel As TableLayoutPanel
    Friend WithEvents loginLabel As Label
    Friend WithEvents regButton As Button
    Friend WithEvents messagePanel As Panel
    Friend WithEvents msgLabel As Label

End Class
