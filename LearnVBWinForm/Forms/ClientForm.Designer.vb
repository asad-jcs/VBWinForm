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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientForm))
        clientTableLayoutPanel = New TableLayoutPanel()
        clientLabel = New Label()
        clientPanel = New Panel()
        messagePanel = New Panel()
        msgLabel = New Label()
        clearButton = New Button()
        emailTextBox = New TextBox()
        emailLabel = New Label()
        phoneTextBox = New TextBox()
        phoneLabel = New Label()
        addButton = New Button()
        updateButton = New Button()
        deleteButton = New Button()
        addressTextBox = New TextBox()
        addressLabel = New Label()
        cliNameReqTextBox = New TextBox()
        cTitleLabel = New Label()
        clientDataGridView = New DataGridView()
        clientTableLayoutPanel.SuspendLayout()
        clientPanel.SuspendLayout()
        messagePanel.SuspendLayout()
        CType(clientDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' clientTableLayoutPanel
        ' 
        clientTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        clientTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        clientTableLayoutPanel.ColumnCount = 5
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        clientTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
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
        clientLabel.Location = New Point(363, 0)
        clientLabel.Name = "clientLabel"
        clientLabel.Size = New Size(112, 47)
        clientLabel.TabIndex = 0
        clientLabel.Text = "Client"
        ' 
        ' clientPanel
        ' 
        clientPanel.BackColor = SystemColors.ActiveCaption
        clientPanel.Controls.Add(messagePanel)
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
        clientPanel.Controls.Add(cliNameReqTextBox)
        clientPanel.Controls.Add(cTitleLabel)
        clientPanel.Dock = DockStyle.Right
        clientPanel.Location = New Point(418, 57)
        clientPanel.Name = "clientPanel"
        clientPanel.Size = New Size(382, 498)
        clientPanel.TabIndex = 22
        ' 
        ' messagePanel
        ' 
        messagePanel.Controls.Add(msgLabel)
        messagePanel.Dock = DockStyle.Bottom
        messagePanel.Location = New Point(0, 373)
        messagePanel.Margin = New Padding(10, 11, 10, 11)
        messagePanel.Name = "messagePanel"
        messagePanel.Size = New Size(382, 125)
        messagePanel.TabIndex = 19
        ' 
        ' msgLabel
        ' 
        msgLabel.AutoSize = True
        msgLabel.Dock = DockStyle.Top
        msgLabel.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        msgLabel.Location = New Point(0, 0)
        msgLabel.Margin = New Padding(10, 11, 10, 11)
        msgLabel.Name = "msgLabel"
        msgLabel.Size = New Size(0, 29)
        msgLabel.TabIndex = 0
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.Silver
        clearButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        clearButton.Image = My.Resources.Resources.icons8_clear_16
        clearButton.ImageAlign = ContentAlignment.MiddleRight
        clearButton.Location = New Point(282, 13)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(94, 29)
        clearButton.TabIndex = 13
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
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
        phoneLabel.Location = New Point(27, 205)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(50, 20)
        phoneLabel.TabIndex = 9
        phoneLabel.Text = "Phone"
        ' 
        ' addButton
        ' 
        addButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        addButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        addButton.Image = My.Resources.Resources.icons8_add_16
        addButton.ImageAlign = ContentAlignment.MiddleRight
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
        updateButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        updateButton.Image = My.Resources.Resources.icons8_update_16
        updateButton.ImageAlign = ContentAlignment.MiddleRight
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
        deleteButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        deleteButton.Image = CType(resources.GetObject("deleteButton.Image"), Image)
        deleteButton.ImageAlign = ContentAlignment.MiddleRight
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
        ' cliNameReqTextBox
        ' 
        cliNameReqTextBox.Location = New Point(133, 48)
        cliNameReqTextBox.Name = "cliNameReqTextBox"
        cliNameReqTextBox.Size = New Size(243, 27)
        cliNameReqTextBox.TabIndex = 1
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
        clientDataGridView.Size = New Size(418, 498)
        clientDataGridView.TabIndex = 21
        ' 
        ' ClientForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 555)
        Controls.Add(clientDataGridView)
        Controls.Add(clientPanel)
        Controls.Add(clientTableLayoutPanel)
        Name = "ClientForm"
        Text = "Client"
        clientTableLayoutPanel.ResumeLayout(False)
        clientTableLayoutPanel.PerformLayout()
        clientPanel.ResumeLayout(False)
        clientPanel.PerformLayout()
        messagePanel.ResumeLayout(False)
        messagePanel.PerformLayout()
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
    Friend WithEvents cliNameReqTextBox As TextBox
    Friend WithEvents cTitleLabel As Label
    Friend WithEvents clientDataGridView As DataGridView
    Friend WithEvents phoneTextBox As TextBox
    Friend WithEvents phoneLabel As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents emailLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents messagePanel As Panel
    Friend WithEvents msgLabel As Label
End Class
