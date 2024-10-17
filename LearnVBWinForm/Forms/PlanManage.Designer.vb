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
        priorityComboBox = New ComboBox()
        Label1 = New Label()
        addButton = New Button()
        projectComboBox = New ComboBox()
        projectLabel = New Label()
        deleteButton = New Button()
        updteButton = New Button()
        userComboBox = New ComboBox()
        userLabel = New Label()
        finishDateTimePicker = New DateTimePicker()
        finishDateLabel = New Label()
        completionTextBox = New TextBox()
        completionLabel = New Label()
        endDateTimePicker = New DateTimePicker()
        startDateTimePicker = New DateTimePicker()
        endDateLabel = New Label()
        startDateLabel = New Label()
        descTextBox = New TextBox()
        descriptionLabel = New Label()
        titleTextBox = New TextBox()
        titleLabel = New Label()
        searchTextBox = New TextBox()
        searchButton = New Button()
        Panel1 = New Panel()
        reloadButton = New Button()
        planManageTableLayoutPanel.SuspendLayout()
        CType(planDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        editPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' planManageTableLayoutPanel
        ' 
        planManageTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        planManageTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        planManageTableLayoutPanel.ColumnCount = 5
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        planManageTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        planManageTableLayoutPanel.Controls.Add(planMngLabel, 2, 0)
        planManageTableLayoutPanel.Dock = DockStyle.Top
        planManageTableLayoutPanel.Location = New Point(0, 0)
        planManageTableLayoutPanel.Name = "planManageTableLayoutPanel"
        planManageTableLayoutPanel.RowCount = 1
        planManageTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        planManageTableLayoutPanel.Size = New Size(1352, 57)
        planManageTableLayoutPanel.TabIndex = 18
        ' 
        ' planMngLabel
        ' 
        planMngLabel.AutoSize = True
        planMngLabel.Font = New Font("Comic Sans MS", 20F)
        planMngLabel.ForeColor = SystemColors.ControlLightLight
        planMngLabel.Location = New Point(408, 0)
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
        planDataGridView.Size = New Size(1100, 451)
        planDataGridView.TabIndex = 19
        ' 
        ' editPanel
        ' 
        editPanel.BackColor = SystemColors.ActiveCaption
        editPanel.Controls.Add(clearButton)
        editPanel.Controls.Add(priorityComboBox)
        editPanel.Controls.Add(Label1)
        editPanel.Controls.Add(addButton)
        editPanel.Controls.Add(projectComboBox)
        editPanel.Controls.Add(projectLabel)
        editPanel.Controls.Add(deleteButton)
        editPanel.Controls.Add(updteButton)
        editPanel.Controls.Add(userComboBox)
        editPanel.Controls.Add(userLabel)
        editPanel.Controls.Add(finishDateTimePicker)
        editPanel.Controls.Add(finishDateLabel)
        editPanel.Controls.Add(completionTextBox)
        editPanel.Controls.Add(completionLabel)
        editPanel.Controls.Add(endDateTimePicker)
        editPanel.Controls.Add(startDateTimePicker)
        editPanel.Controls.Add(endDateLabel)
        editPanel.Controls.Add(startDateLabel)
        editPanel.Controls.Add(descTextBox)
        editPanel.Controls.Add(descriptionLabel)
        editPanel.Controls.Add(titleTextBox)
        editPanel.Controls.Add(titleLabel)
        editPanel.Location = New Point(12, 63)
        editPanel.Name = "editPanel"
        editPanel.Size = New Size(406, 485)
        editPanel.TabIndex = 20
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.Silver
        clearButton.Image = My.Resources.Resources.icons8_clear_16
        clearButton.ImageAlign = ContentAlignment.MiddleRight
        clearButton.Location = New Point(299, 3)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(94, 29)
        clearButton.TabIndex = 24
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' priorityComboBox
        ' 
        priorityComboBox.FormattingEnabled = True
        priorityComboBox.Location = New Point(132, 357)
        priorityComboBox.Name = "priorityComboBox"
        priorityComboBox.Size = New Size(261, 28)
        priorityComboBox.TabIndex = 23
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
        addButton.Image = My.Resources.Resources.icons8_add_16
        addButton.ImageAlign = ContentAlignment.MiddleRight
        addButton.Location = New Point(99, 430)
        addButton.Name = "addButton"
        addButton.Size = New Size(94, 29)
        addButton.TabIndex = 21
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = False
        ' 
        ' projectComboBox
        ' 
        projectComboBox.FormattingEnabled = True
        projectComboBox.Location = New Point(132, 320)
        projectComboBox.Name = "projectComboBox"
        projectComboBox.Size = New Size(261, 28)
        projectComboBox.TabIndex = 20
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
        deleteButton.Image = CType(resources.GetObject("deleteButton.Image"), Image)
        deleteButton.ImageAlign = ContentAlignment.MiddleRight
        deleteButton.Location = New Point(299, 430)
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
        updteButton.Image = My.Resources.Resources.icons8_update_16
        updteButton.ImageAlign = ContentAlignment.MiddleRight
        updteButton.Location = New Point(199, 430)
        updteButton.Name = "updteButton"
        updteButton.Size = New Size(94, 29)
        updteButton.TabIndex = 17
        updteButton.Text = "Update"
        updteButton.UseVisualStyleBackColor = False
        ' 
        ' userComboBox
        ' 
        userComboBox.FormattingEnabled = True
        userComboBox.Location = New Point(132, 282)
        userComboBox.Name = "userComboBox"
        userComboBox.Size = New Size(261, 28)
        userComboBox.TabIndex = 16
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
        ' finishDateTimePicker
        ' 
        finishDateTimePicker.Location = New Point(132, 247)
        finishDateTimePicker.Name = "finishDateTimePicker"
        finishDateTimePicker.Size = New Size(261, 27)
        finishDateTimePicker.TabIndex = 14
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
        completionTextBox.Location = New Point(132, 214)
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
        ' endDateTimePicker
        ' 
        endDateTimePicker.Location = New Point(132, 179)
        endDateTimePicker.Name = "endDateTimePicker"
        endDateTimePicker.Size = New Size(261, 27)
        endDateTimePicker.TabIndex = 8
        ' 
        ' startDateTimePicker
        ' 
        startDateTimePicker.Location = New Point(132, 146)
        startDateTimePicker.Name = "startDateTimePicker"
        startDateTimePicker.Size = New Size(261, 27)
        startDateTimePicker.TabIndex = 7
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
        descTextBox.Location = New Point(132, 71)
        descTextBox.Multiline = True
        descTextBox.Name = "descTextBox"
        descTextBox.Size = New Size(261, 69)
        descTextBox.TabIndex = 3
        ' 
        ' descriptionLabel
        ' 
        descriptionLabel.AutoSize = True
        descriptionLabel.Location = New Point(13, 78)
        descriptionLabel.Name = "descriptionLabel"
        descriptionLabel.Size = New Size(85, 20)
        descriptionLabel.TabIndex = 2
        descriptionLabel.Text = "Description"
        ' 
        ' titleTextBox
        ' 
        titleTextBox.Location = New Point(132, 38)
        titleTextBox.Name = "titleTextBox"
        titleTextBox.Size = New Size(261, 27)
        titleTextBox.TabIndex = 1
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
        ' reloadButton
        ' 
        reloadButton.BackColor = SystemColors.GradientInactiveCaption
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
        AutoScaleDimensions = New SizeF(8F, 20F)
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
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents completionLabel As Label
    Friend WithEvents endDateTimePicker As DateTimePicker
    Friend WithEvents startDateTimePicker As DateTimePicker
    Friend WithEvents finishDateTimePicker As DateTimePicker
    Friend WithEvents finishDateLabel As Label
    Friend WithEvents completionTextBox As TextBox
    Friend WithEvents updteButton As Button
    Friend WithEvents userComboBox As ComboBox
    Friend WithEvents userLabel As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents projectComboBox As ComboBox
    Friend WithEvents projectLabel As Label
    Friend WithEvents addButton As Button
    Friend WithEvents priorityComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents reloadButton As Button
    Friend WithEvents clearButton As Button
End Class
