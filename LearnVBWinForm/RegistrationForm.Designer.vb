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
        Panel1 = New Panel()
        registrationLabel = New Label()
        Panel1.SuspendLayout()
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
        regButton.Location = New Point(241, 228)
        regButton.Name = "regButton"
        regButton.Size = New Size(119, 34)
        regButton.TabIndex = 8
        regButton.Text = "Registration"
        regButton.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        Panel1.Controls.Add(registrationLabel)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 54)
        Panel1.TabIndex = 15
        ' 
        ' registrationLabel
        ' 
        registrationLabel.AutoSize = True
        registrationLabel.Font = New Font("Comic Sans MS", 20F)
        registrationLabel.ForeColor = SystemColors.ControlLightLight
        registrationLabel.Location = New Point(338, 0)
        registrationLabel.Name = "registrationLabel"
        registrationLabel.Size = New Size(216, 47)
        registrationLabel.TabIndex = 0
        registrationLabel.Text = "Registration"
        ' 
        ' RegistrationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents registrationLabel As Label
End Class
