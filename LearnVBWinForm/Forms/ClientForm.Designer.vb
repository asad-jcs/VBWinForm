<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientForm
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
        clientTableLayoutPanel = New TableLayoutPanel()
        clientLabel = New Label()
        clientPanel = New Panel()
        emailTextBox = New TextBox()
        emailLabel = New Label()
        phoneTextBox = New TextBox()
        phoneLabel = New Label()
        addButton = New Button()
        updateButton = New Button()
        deleteButton = New Button()
        addressTextBox = New TextBox()
        addressLabel = New Label()
        cliNameTextBox = New TextBox()
        cTitleLabel = New Label()
        clientDataGridView = New DataGridView()
        clearButton = New Button()
        clientTableLayoutPanel.SuspendLayout()
        clientPanel.SuspendLayout()
        CType(clientDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' clientTableLayoutPanel
        ' 
        clientTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        clientTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        clientTableLayoutPanel.ColumnCount = 5
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.5F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.5F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        clientTableLayoutPanel.Controls.Add(clientLabel, 2, 0)
        clientTableLayoutPanel.Dock = DockStyle.Top
        clientTableLayoutPanel.Location = New Point(0, 0)
        clientTableLayoutPanel.Name = "clientTableLayoutPanel"
        clientTableLayoutPanel.RowCount = 1
        clientTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        clientTableLayoutPanel.Size = New Size(800, 57)
        clientTableLayoutPanel.TabIndex = 20
        ' 
        ' clientLabel
        ' 
        clientLabel.AutoSize = True
        clientLabel.Font = New Font("Comic Sans MS", 20F)
        clientLabel.ForeColor = SystemColors.ControlLightLight
        clientLabel.Location = New Point(303, 0)
        clientLabel.Name = "clientLabel"
        clientLabel.Size = New Size(112, 47)
        clientLabel.TabIndex = 0
        clientLabel.Text = "Client"
        ' 
        ' clientPanel
        ' 
        clientPanel.BackColor = SystemColors.ActiveCaption
        clientPanel.Controls.Add(clearButton)
        clientPanel.Controls.Add(emailTextBox)
        clientPanel.Controls.Add(emailLabel)
        clientPanel.Controls.Add(phoneTextBox)
        clientPanel.Controls.Add(phoneLabel)
        clientPanel.Controls.Add(addButton)
        clientPanel.Controls.Add(updateButton)
        clientPanel.Controls.Add(deleteButton)
        clientPanel.Controls.Add(addressTextBox)
        clientPanel.Controls.Add(addressLabel)
        clientPanel.Controls.Add(cliNameTextBox)
        clientPanel.Controls.Add(cTitleLabel)
        clientPanel.Dock = DockStyle.Right
        clientPanel.Location = New Point(418, 57)
        clientPanel.Name = "clientPanel"
        clientPanel.Size = New Size(382, 393)
        clientPanel.TabIndex = 22
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(133, 236)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(243, 27)
        emailTextBox.TabIndex = 12
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(27, 239)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 11
        emailLabel.Text = "Email"
        ' 
        ' phoneTextBox
        ' 
        phoneTextBox.Location = New Point(133, 203)
        phoneTextBox.Name = "phoneTextBox"
        phoneTextBox.Size = New Size(243, 27)
        phoneTextBox.TabIndex = 10
        ' 
        ' phoneLabel
        ' 
        phoneLabel.AutoSize = True
        phoneLabel.Location = New Point(27, 206)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(50, 20)
        phoneLabel.TabIndex = 9
        phoneLabel.Text = "Phone"
        ' 
        ' addButton
        ' 
        addButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        addButton.Location = New Point(82, 272)
        addButton.Name = "addButton"
        addButton.Size = New Size(94, 29)
        addButton.TabIndex = 8
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = False
        ' 
        ' updateButton
        ' 
        updateButton.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        updateButton.Location = New Point(182, 272)
        updateButton.Name = "updateButton"
        updateButton.Size = New Size(94, 29)
        updateButton.TabIndex = 7
        updateButton.Text = "Update"
        updateButton.UseVisualStyleBackColor = False
        ' 
        ' deleteButton
        ' 
        deleteButton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        deleteButton.Location = New Point(282, 272)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(94, 29)
        deleteButton.TabIndex = 6
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = False
        ' 
        ' addressTextBox
        ' 
        addressTextBox.Location = New Point(133, 81)
        addressTextBox.Multiline = True
        addressTextBox.Name = "addressTextBox"
        addressTextBox.Size = New Size(243, 117)
        addressTextBox.TabIndex = 3
        ' 
        ' addressLabel
        ' 
        addressLabel.AutoSize = True
        addressLabel.Location = New Point(27, 84)
        addressLabel.Name = "addressLabel"
        addressLabel.Size = New Size(62, 20)
        addressLabel.TabIndex = 2
        addressLabel.Text = "Address"
        ' 
        ' cliNameTextBox
        ' 
        cliNameTextBox.Location = New Point(133, 48)
        cliNameTextBox.Name = "cliNameTextBox"
        cliNameTextBox.Size = New Size(243, 27)
        cliNameTextBox.TabIndex = 1
        ' 
        ' cTitleLabel
        ' 
        cTitleLabel.AutoSize = True
        cTitleLabel.Location = New Point(27, 51)
        cTitleLabel.Name = "cTitleLabel"
        cTitleLabel.Size = New Size(91, 20)
        cTitleLabel.TabIndex = 0
        cTitleLabel.Text = "Client Name"
        ' 
        ' clientDataGridView
        ' 
        clientDataGridView.BackgroundColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        clientDataGridView.Dock = DockStyle.Fill
        clientDataGridView.Location = New Point(0, 57)
        clientDataGridView.Name = "clientDataGridView"
        clientDataGridView.RowHeadersWidth = 51
        clientDataGridView.Size = New Size(418, 393)
        clientDataGridView.TabIndex = 21
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.Silver
        clearButton.Location = New Point(282, 13)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(94, 29)
        clearButton.TabIndex = 13
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' ClientForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(clientDataGridView)
        Controls.Add(clientPanel)
        Controls.Add(clientTableLayoutPanel)
        Name = "ClientForm"
        Text = "Client"
        clientTableLayoutPanel.ResumeLayout(False)
        clientTableLayoutPanel.PerformLayout()
        clientPanel.ResumeLayout(False)
        clientPanel.PerformLayout()
        CType(clientDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents clientTableLayoutPanel As TableLayoutPanel
    Friend WithEvents clientPanel As Panel
    Friend WithEvents addButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents clientLabel As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents cliNameTextBox As TextBox
    Friend WithEvents cTitleLabel As Label
    Friend WithEvents clientDataGridView As DataGridView
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents phoneLabel As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents clearButton As Button
End Class
