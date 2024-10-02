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
        emailTextBox = New TextBox()
        emailLabel = New Label()
        passwordLabel = New Label()
        passwordTextBox = New TextBox()
        loginButton = New Button()
        loginTableLayoutPanel = New TableLayoutPanel()
        regLinkLabel = New LinkLabel()
        loginLabel = New Label()
        loginTableLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(113, 92)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(170, 27)
        emailTextBox.TabIndex = 0
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
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(113, 125)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(170, 27)
        passwordTextBox.TabIndex = 6
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(189, 158)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(94, 29)
        loginButton.TabIndex = 8
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
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
        loginTableLayoutPanel.Controls.Add(regLinkLabel, 0, 0)
        loginTableLayoutPanel.Controls.Add(loginLabel, 2, 0)
        loginTableLayoutPanel.Dock = DockStyle.Top
        loginTableLayoutPanel.Location = New Point(0, 0)
        loginTableLayoutPanel.Name = "loginTableLayoutPanel"
        loginTableLayoutPanel.RowCount = 1
        loginTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        loginTableLayoutPanel.Size = New Size(800, 57)
        loginTableLayoutPanel.TabIndex = 15
        ' 
        ' regLinkLabel
        ' 
        regLinkLabel.AutoSize = True
        regLinkLabel.Location = New Point(3, 0)
        regLinkLabel.Name = "regLinkLabel"
        regLinkLabel.Size = New Size(89, 20)
        regLinkLabel.TabIndex = 9
        regLinkLabel.TabStop = True
        regLinkLabel.Text = "Registration"
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
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(loginTableLayoutPanel)
        Controls.Add(loginButton)
        Controls.Add(passwordLabel)
        Controls.Add(passwordTextBox)
        Controls.Add(emailLabel)
        Controls.Add(emailTextBox)
        Name = "LoginForm"
        Text = "Login"
        WindowState = FormWindowState.Maximized
        loginTableLayoutPanel.ResumeLayout(False)
        loginTableLayoutPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents loginTableLayoutPanel As TableLayoutPanel
    Friend WithEvents regLinkLabel As LinkLabel
    Friend WithEvents loginLabel As Label

End Class
