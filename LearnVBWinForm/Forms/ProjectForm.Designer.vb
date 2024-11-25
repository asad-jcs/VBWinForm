<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectForm))
        projectTableLayoutPanel = New TableLayoutPanel()
        projectLabel = New Label()
        projectDataGridView = New DataGridView()
        Panel1 = New Panel()
        messagePanel = New Panel()
        msgLabel = New Label()
        clearButton = New Button()
        addButton = New Button()
        updateButton = New Button()
        deleteButton = New Button()
        clientReqComboBox = New ComboBox()
        clientLabel = New Label()
        projDesTextBox = New TextBox()
        pDesLabel = New Label()
        projNameReqTextBox = New TextBox()
        pTitleLabel = New Label()
        projectTableLayoutPanel.SuspendLayout()
        CType(projectDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        messagePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' projectTableLayoutPanel
        ' 
        projectTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        projectTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        projectTableLayoutPanel.ColumnCount = 5
        projectTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        projectTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        projectTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        projectTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        projectTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        projectTableLayoutPanel.Controls.Add(projectLabel, 2, 0)
        projectTableLayoutPanel.Dock = DockStyle.Top
        projectTableLayoutPanel.Location = New Point(0, 0)
        projectTableLayoutPanel.Name = "projectTableLayoutPanel"
        projectTableLayoutPanel.RowCount = 1
        projectTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        projectTableLayoutPanel.Size = New Size(800, 57)
        projectTableLayoutPanel.TabIndex = 17
        ' 
        ' projectLabel
        ' 
        projectLabel.AutoSize = True
        projectLabel.Font = New Font("Comic Sans MS", 20F)
        projectLabel.ForeColor = SystemColors.ControlLightLight
        projectLabel.Location = New Point(363, 0)
        projectLabel.Name = "projectLabel"
        projectLabel.Size = New Size(138, 47)
        projectLabel.TabIndex = 0
        projectLabel.Text = "Project"
        ' 
        ' projectDataGridView
        ' 
        projectDataGridView.BackgroundColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        projectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        projectDataGridView.Dock = DockStyle.Fill
        projectDataGridView.Location = New Point(0, 57)
        projectDataGridView.Name = "projectDataGridView"
        projectDataGridView.RowHeadersWidth = 51
        projectDataGridView.Size = New Size(800, 394)
        projectDataGridView.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(messagePanel)
        Panel1.Controls.Add(clearButton)
        Panel1.Controls.Add(addButton)
        Panel1.Controls.Add(updateButton)
        Panel1.Controls.Add(deleteButton)
        Panel1.Controls.Add(clientReqComboBox)
        Panel1.Controls.Add(clientLabel)
        Panel1.Controls.Add(projDesTextBox)
        Panel1.Controls.Add(pDesLabel)
        Panel1.Controls.Add(projNameReqTextBox)
        Panel1.Controls.Add(pTitleLabel)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(411, 57)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(389, 394)
        Panel1.TabIndex = 19
        ' 
        ' messagePanel
        ' 
        messagePanel.Controls.Add(msgLabel)
        messagePanel.Dock = DockStyle.Bottom
        messagePanel.Location = New Point(0, 269)
        messagePanel.Margin = New Padding(10, 11, 10, 11)
        messagePanel.Name = "messagePanel"
        messagePanel.Size = New Size(389, 125)
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
        ' clearButton
        ' 
        clearButton.BackColor = SystemColors.ActiveBorder
        clearButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        clearButton.Image = CType(resources.GetObject("clearButton.Image"), Image)
        clearButton.ImageAlign = ContentAlignment.MiddleRight
        clearButton.Location = New Point(282, 13)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(94, 29)
        clearButton.TabIndex = 9
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' addButton
        ' 
        addButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        addButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        addButton.Image = My.Resources.Resources.icons8_add_16
        addButton.ImageAlign = ContentAlignment.MiddleRight
        addButton.Location = New Point(82, 245)
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
        updateButton.Location = New Point(182, 245)
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
        deleteButton.Location = New Point(282, 245)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(94, 29)
        deleteButton.TabIndex = 6
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = False
        ' 
        ' clientReqComboBox
        ' 
        clientReqComboBox.FormattingEnabled = True
        clientReqComboBox.Location = New Point(133, 204)
        clientReqComboBox.Name = "clientReqComboBox"
        clientReqComboBox.Size = New Size(243, 28)
        clientReqComboBox.TabIndex = 5
        ' 
        ' clientLabel
        ' 
        clientLabel.AutoSize = True
        clientLabel.Location = New Point(27, 207)
        clientLabel.Name = "clientLabel"
        clientLabel.Size = New Size(47, 20)
        clientLabel.TabIndex = 4
        clientLabel.Text = "Client"
        ' 
        ' projDesTextBox
        ' 
        projDesTextBox.Location = New Point(133, 81)
        projDesTextBox.Multiline = True
        projDesTextBox.Name = "projDesTextBox"
        projDesTextBox.Size = New Size(243, 117)
        projDesTextBox.TabIndex = 3
        ' 
        ' pDesLabel
        ' 
        pDesLabel.AutoSize = True
        pDesLabel.Location = New Point(27, 84)
        pDesLabel.Name = "pDesLabel"
        pDesLabel.Size = New Size(85, 20)
        pDesLabel.TabIndex = 2
        pDesLabel.Text = "Description"
        ' 
        ' projNameReqTextBox
        ' 
        projNameReqTextBox.Location = New Point(133, 48)
        projNameReqTextBox.Name = "projNameReqTextBox"
        projNameReqTextBox.Size = New Size(243, 27)
        projNameReqTextBox.TabIndex = 1
        ' 
        ' pTitleLabel
        ' 
        pTitleLabel.AutoSize = True
        pTitleLabel.Location = New Point(27, 51)
        pTitleLabel.Name = "pTitleLabel"
        pTitleLabel.Size = New Size(88, 20)
        pTitleLabel.TabIndex = 0
        pTitleLabel.Text = "Project Title"
        ' 
        ' ProjectForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(Panel1)
        Controls.Add(projectDataGridView)
        Controls.Add(projectTableLayoutPanel)
        Name = "ProjectForm"
        Text = "ProjectForm"
        projectTableLayoutPanel.ResumeLayout(False)
        projectTableLayoutPanel.PerformLayout()
        CType(projectDataGridView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        messagePanel.ResumeLayout(False)
        messagePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents projectTableLayoutPanel As TableLayoutPanel
    Friend WithEvents projectLabel As Label
    Friend WithEvents projectDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents projNameReqTextBox As TextBox
    Friend WithEvents pTitleLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents updateButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents clientReqComboBox As ComboBox
    Friend WithEvents clientLabel As Label
    Friend WithEvents projDesTextBox As TextBox
    Friend WithEvents pDesLabel As Label
    Friend WithEvents clearButton As Button
    Friend WithEvents messagePanel As Panel
    Friend WithEvents msgLabel As Label
End Class
