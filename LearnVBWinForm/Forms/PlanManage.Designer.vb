<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanManage))
        planManageTableLayoutPanel = New TableLayoutPanel()
        planMngLabel = New Label()
        planDataGridView = New DataGridView()
        editPanel = New Panel()
        clearButton = New Button()
        priorityReqComboBox = New ComboBox()
        Label1 = New Label()
        addButton = New Button()
        projectReqComboBox = New ComboBox()
        projectLabel = New Label()
        deleteButton = New Button()
        updteButton = New Button()
        userReqComboBox = New ComboBox()
        userLabel = New Label()
        finishDateLabel = New Label()
        completionTextBox = New TextBox()
        completionLabel = New Label()
        endReqDateTimePicker = New DateTimePicker()
        startReqDateTimePicker = New DateTimePicker()
        endDateLabel = New Label()
        startDateLabel = New Label()
        descTextBox = New TextBox()
        descriptionLabel = New Label()
        titleReqTextBox = New TextBox()
        titleLabel = New Label()
        searchTextBox = New TextBox()
        searchButton = New Button()
        Panel1 = New Panel()
        messagePanel = New Panel()
        msgLabel = New Label()
        reloadButton = New Button()
        planManageTableLayoutPanel.SuspendLayout()
        CType(planDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        editPanel.SuspendLayout()
        Panel1.SuspendLayout()
        messagePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' planManageTableLayoutPanel
        ' 
        planManageTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        planManageTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        planManageTableLayoutPanel.ColumnCount = 5
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 24.0F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 6.0F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        planManageTableLayoutPanel.Controls.Add(planMngLabel, 2, 0)
        planManageTableLayoutPanel.Dock = DockStyle.Top
        planManageTableLayoutPanel.Location = New Point(0, 0)
        planManageTableLayoutPanel.Name = "planManageTableLayoutPanel"
        planManageTableLayoutPanel.RowCount = 1
        planManageTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        planManageTableLayoutPanel.Size = New Size(1352, 57)
        planManageTableLayoutPanel.TabIndex = 18
        ' 
        ' planMngLabel
        ' 
        planMngLabel.AutoSize = True
        planMngLabel.Font = New Font("Comic Sans MS", 20.0F)
        planMngLabel.ForeColor = SystemColors.ControlLightLight
        planMngLabel.Location = New Point(597, 0)
        planMngLabel.Name = "planMngLabel"
        planMngLabel.Size = New Size(289, 47)
        planMngLabel.TabIndex = 0
        planMngLabel.Text = "Plan Management"
        ' 
        ' planDataGridView
        ' 
        planDataGridView.BackgroundColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        planDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        planDataGridView.GridColor = SystemColors.InactiveCaption
        planDataGridView.Location = New Point(424, 97)
        planDataGridView.Name = "planDataGridView"
        planDataGridView.RowHeadersWidth = 51
        planDataGridView.Size = New Size(1099, 451)
        planDataGridView.TabIndex = 19
        ' 
        ' editPanel
        ' 
        editPanel.BackColor = SystemColors.ActiveCaption
        editPanel.Controls.Add(clearButton)
        editPanel.Controls.Add(priorityReqComboBox)
        editPanel.Controls.Add(Label1)
        editPanel.Controls.Add(addButton)
        editPanel.Controls.Add(projectReqComboBox)
        editPanel.Controls.Add(projectLabel)
        editPanel.Controls.Add(deleteButton)
        editPanel.Controls.Add(updteButton)
        editPanel.Controls.Add(userReqComboBox)
        editPanel.Controls.Add(userLabel)
        editPanel.Controls.Add(finishDateLabel)
        editPanel.Controls.Add(completionTextBox)
        editPanel.Controls.Add(completionLabel)
        editPanel.Controls.Add(endReqDateTimePicker)
        editPanel.Controls.Add(startReqDateTimePicker)
        editPanel.Controls.Add(endDateLabel)
        editPanel.Controls.Add(startDateLabel)
        editPanel.Controls.Add(descTextBox)
        editPanel.Controls.Add(descriptionLabel)
        editPanel.Controls.Add(titleReqTextBox)
        editPanel.Controls.Add(titleLabel)
        editPanel.Location = New Point(11, 63)
        editPanel.Name = "editPanel"
        editPanel.Size = New Size(406, 485)
        editPanel.TabIndex = 20
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.Silver
        clearButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        clearButton.Image = My.Resources.Resources.icons8_clear_16
        clearButton.ImageAlign = ContentAlignment.MiddleRight
        clearButton.Location = New Point(299, 3)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(94, 29)
        clearButton.TabIndex = 24
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' priorityReqComboBox
        ' 
        priorityReqComboBox.FormattingEnabled = True
        priorityReqComboBox.Location = New Point(133, 357)
        priorityReqComboBox.Name = "priorityReqComboBox"
        priorityReqComboBox.Size = New Size(261, 28)
        priorityReqComboBox.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 360)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 22
        Label1.Text = "Priority"
        ' 
        ' addButton
        ' 
        addButton.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        addButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        addButton.Image = My.Resources.Resources.icons8_add_16
        addButton.ImageAlign = ContentAlignment.MiddleRight
        addButton.Location = New Point(99, 429)
        addButton.Name = "addButton"
        addButton.Size = New Size(94, 29)
        addButton.TabIndex = 21
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = False
        ' 
        ' projectReqComboBox
        ' 
        projectReqComboBox.FormattingEnabled = True
        projectReqComboBox.Location = New Point(133, 320)
        projectReqComboBox.Name = "projectReqComboBox"
        projectReqComboBox.Size = New Size(261, 28)
        projectReqComboBox.TabIndex = 20
        ' 
        ' projectLabel
        ' 
        projectLabel.AutoSize = True
        projectLabel.Location = New Point(13, 323)
        projectLabel.Name = "projectLabel"
        projectLabel.Size = New Size(55, 20)
        projectLabel.TabIndex = 19
        projectLabel.Text = "Project"
        ' 
        ' deleteButton
        ' 
        deleteButton.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        deleteButton.Enabled = False
        deleteButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        deleteButton.Image = CType(resources.GetObject("deleteButton.Image"), Image)
        deleteButton.ImageAlign = ContentAlignment.MiddleRight
        deleteButton.Location = New Point(299, 429)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(94, 29)
        deleteButton.TabIndex = 18
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = False
        ' 
        ' updteButton
        ' 
        updteButton.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        updteButton.Enabled = False
        updteButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        updteButton.ForeColor = SystemColors.ButtonHighlight
        updteButton.Image = My.Resources.Resources.icons8_update_16
        updteButton.ImageAlign = ContentAlignment.MiddleRight
        updteButton.Location = New Point(199, 429)
        updteButton.Name = "updteButton"
        updteButton.Size = New Size(94, 29)
        updteButton.TabIndex = 17
        updteButton.Text = "Update"
        updteButton.UseVisualStyleBackColor = False
        ' 
        ' userReqComboBox
        ' 
        userReqComboBox.FormattingEnabled = True
        userReqComboBox.Location = New Point(133, 283)
        userReqComboBox.Name = "userReqComboBox"
        userReqComboBox.Size = New Size(261, 28)
        userReqComboBox.TabIndex = 16
        ' 
        ' userLabel
        ' 
        userLabel.AutoSize = True
        userLabel.Location = New Point(13, 285)
        userLabel.Name = "userLabel"
        userLabel.Size = New Size(52, 20)
        userLabel.TabIndex = 15
        userLabel.Text = "Assign"
        ' 
        ' finishDateLabel
        ' 
        finishDateLabel.AutoSize = True
        finishDateLabel.Location = New Point(13, 252)
        finishDateLabel.Name = "finishDateLabel"
        finishDateLabel.Size = New Size(103, 20)
        finishDateLabel.TabIndex = 13
        finishDateLabel.Text = "Finishing Date"
        ' 
        ' completionTextBox
        ' 
        completionTextBox.Location = New Point(133, 213)
        completionTextBox.Name = "completionTextBox"
        completionTextBox.Size = New Size(261, 27)
        completionTextBox.TabIndex = 12
        ' 
        ' completionLabel
        ' 
        completionLabel.AutoSize = True
        completionLabel.Location = New Point(13, 217)
        completionLabel.Name = "completionLabel"
        completionLabel.Size = New Size(87, 20)
        completionLabel.TabIndex = 11
        completionLabel.Text = "Completion"
        ' 
        ' endReqDateTimePicker
        ' 
        endReqDateTimePicker.Location = New Point(133, 179)
        endReqDateTimePicker.Name = "endReqDateTimePicker"
        endReqDateTimePicker.Size = New Size(261, 27)
        endReqDateTimePicker.TabIndex = 8
        ' 
        ' startReqDateTimePicker
        ' 
        startReqDateTimePicker.Location = New Point(133, 147)
        startReqDateTimePicker.Name = "startReqDateTimePicker"
        startReqDateTimePicker.Size = New Size(261, 27)
        startReqDateTimePicker.TabIndex = 7
        ' 
        ' endDateLabel
        ' 
        endDateLabel.AutoSize = True
        endDateLabel.Location = New Point(13, 184)
        endDateLabel.Name = "endDateLabel"
        endDateLabel.Size = New Size(70, 20)
        endDateLabel.TabIndex = 6
        endDateLabel.Text = "End Date"
        ' 
        ' startDateLabel
        ' 
        startDateLabel.AutoSize = True
        startDateLabel.Location = New Point(13, 148)
        startDateLabel.Name = "startDateLabel"
        startDateLabel.Size = New Size(84, 20)
        startDateLabel.TabIndex = 4
        startDateLabel.Text = "Strate Date"
        ' 
        ' descTextBox
        ' 
        descTextBox.Location = New Point(133, 71)
        descTextBox.Multiline = True
        descTextBox.Name = "descTextBox"
        descTextBox.Size = New Size(261, 69)
        descTextBox.TabIndex = 3
        ' 
        ' descriptionLabel
        ' 
        descriptionLabel.AutoSize = True
        descriptionLabel.Location = New Point(13, 77)
        descriptionLabel.Name = "descriptionLabel"
        descriptionLabel.Size = New Size(85, 20)
        descriptionLabel.TabIndex = 2
        descriptionLabel.Text = "Description"
        ' 
        ' titleReqTextBox
        ' 
        titleReqTextBox.Location = New Point(133, 37)
        titleReqTextBox.Name = "titleReqTextBox"
        titleReqTextBox.Size = New Size(261, 27)
        titleReqTextBox.TabIndex = 1
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Location = New Point(13, 45)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(38, 20)
        titleLabel.TabIndex = 0
        titleLabel.Text = "Title"
        ' 
        ' searchTextBox
        ' 
        searchTextBox.Location = New Point(424, 63)
        searchTextBox.Name = "searchTextBox"
        searchTextBox.Size = New Size(303, 27)
        searchTextBox.TabIndex = 24
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.Bisque
        searchButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        searchButton.ForeColor = SystemColors.ActiveCaptionText
        searchButton.Image = My.Resources.Resources.search
        searchButton.ImageAlign = ContentAlignment.MiddleRight
        searchButton.Location = New Point(733, 61)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(141, 29)
        searchButton.TabIndex = 24
        searchButton.Text = "Search"
        searchButton.TextAlign = ContentAlignment.MiddleLeft
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(messagePanel)
        Panel1.Controls.Add(reloadButton)
        Panel1.Controls.Add(searchButton)
        Panel1.Controls.Add(editPanel)
        Panel1.Controls.Add(searchTextBox)
        Panel1.Controls.Add(planDataGridView)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1352, 805)
        Panel1.TabIndex = 21
        ' 
        ' messagePanel
        ' 
        messagePanel.Controls.Add(msgLabel)
        messagePanel.Dock = DockStyle.Bottom
        messagePanel.Location = New Point(0, 680)
        messagePanel.Margin = New Padding(10, 11, 10, 11)
        messagePanel.Name = "messagePanel"
        messagePanel.Size = New Size(1352, 125)
        messagePanel.TabIndex = 29
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
        ' reloadButton
        ' 
        reloadButton.BackColor = SystemColors.GradientInactiveCaption
        reloadButton.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        reloadButton.ForeColor = SystemColors.ActiveCaptionText
        reloadButton.Image = CType(resources.GetObject("reloadButton.Image"), Image)
        reloadButton.ImageAlign = ContentAlignment.MiddleRight
        reloadButton.Location = New Point(880, 61)
        reloadButton.Name = "reloadButton"
        reloadButton.Size = New Size(133, 29)
        reloadButton.TabIndex = 28
        reloadButton.Text = "Reload"
        reloadButton.UseVisualStyleBackColor = False
        ' 
        ' PlanManage
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(1352, 805)
        Controls.Add(planManageTableLayoutPanel)
        Controls.Add(Panel1)
        Name = "PlanManage"
        Text = "Plan Manage"
        planManageTableLayoutPanel.ResumeLayout(False)
        planManageTableLayoutPanel.PerformLayout()
        CType(planDataGridView, ComponentModel.ISupportInitialize).EndInit()
        editPanel.ResumeLayout(False)
        editPanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        messagePanel.ResumeLayout(False)
        messagePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents planManageTableLayoutPanel As TableLayoutPanel
    Friend WithEvents planMngLabel As Label
    Friend WithEvents planDataGridView As DataGridView
    Friend WithEvents editPanel As Panel
    Friend WithEvents endDateLabel As Label
    Friend WithEvents startDateLabel As Label
    Friend WithEvents descTextBox As TextBox
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents titleLabel As Label
    Friend WithEvents completionLabel As Label
    Friend WithEvents finishDateLabel As Label
    Friend WithEvents completionTextBox As TextBox
    Friend WithEvents updteButton As Button
    Friend WithEvents userLabel As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents projectLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents reloadButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents messagePanel As Panel
    Friend WithEvents msgLabel As Label
    Friend WithEvents priorityReqComboBox As ComboBox
    Friend WithEvents projectReqComboBox As ComboBox
    Friend WithEvents userReqComboBox As ComboBox
    Friend WithEvents endReqDateTimePicker As DateTimePicker
    Friend WithEvents startReqDateTimePicker As DateTimePicker
    Friend WithEvents titleReqTextBox As TextBox
End Class
