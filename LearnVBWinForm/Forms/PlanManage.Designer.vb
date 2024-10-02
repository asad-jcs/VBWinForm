﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        planManageTableLayoutPanel = New TableLayoutPanel()
        planMngLabel = New Label()
        planDataGridView = New DataGridView()
        editPanel = New Panel()
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
        planManageTableLayoutPanel.SuspendLayout()
        CType(planDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        editPanel.SuspendLayout()
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
        planManageTableLayoutPanel.Size = New Size(800, 57)
        planManageTableLayoutPanel.TabIndex = 18
        ' 
        ' planMngLabel
        ' 
        planMngLabel.AutoSize = True
        planMngLabel.Font = New Font("Comic Sans MS", 20F)
        planMngLabel.ForeColor = SystemColors.ControlLightLight
        planMngLabel.Location = New Point(243, 0)
        planMngLabel.Name = "planMngLabel"
        planMngLabel.Size = New Size(289, 47)
        planMngLabel.TabIndex = 0
        planMngLabel.Text = "Plan Management"
        ' 
        ' planDataGridView
        ' 
        planDataGridView.BackgroundColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        planDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        planDataGridView.Dock = DockStyle.Fill
        planDataGridView.GridColor = SystemColors.InactiveCaption
        planDataGridView.Location = New Point(0, 57)
        planDataGridView.Name = "planDataGridView"
        planDataGridView.RowHeadersWidth = 51
        planDataGridView.Size = New Size(800, 393)
        planDataGridView.TabIndex = 19
        ' 
        ' editPanel
        ' 
        editPanel.BackColor = SystemColors.ActiveCaption
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
        editPanel.Dock = DockStyle.Right
        editPanel.Location = New Point(303, 57)
        editPanel.Name = "editPanel"
        editPanel.Size = New Size(497, 393)
        editPanel.TabIndex = 20
        ' 
        ' deleteButton
        ' 
        deleteButton.Location = New Point(199, 300)
        deleteButton.Name = "deleteButton"
        deleteButton.Size = New Size(94, 29)
        deleteButton.TabIndex = 18
        deleteButton.Text = "Delete"
        deleteButton.UseVisualStyleBackColor = True
        ' 
        ' updteButton
        ' 
        updteButton.Location = New Point(299, 300)
        updteButton.Name = "updteButton"
        updteButton.Size = New Size(94, 29)
        updteButton.TabIndex = 17
        updteButton.Text = "Update"
        updteButton.UseVisualStyleBackColor = True
        ' 
        ' userComboBox
        ' 
        userComboBox.FormattingEnabled = True
        userComboBox.Location = New Point(132, 266)
        userComboBox.Name = "userComboBox"
        userComboBox.Size = New Size(261, 28)
        userComboBox.TabIndex = 16
        ' 
        ' userLabel
        ' 
        userLabel.AutoSize = True
        userLabel.Location = New Point(13, 269)
        userLabel.Name = "userLabel"
        userLabel.Size = New Size(52, 20)
        userLabel.TabIndex = 15
        userLabel.Text = "Assign"
        ' 
        ' finishDateTimePicker
        ' 
        finishDateTimePicker.Location = New Point(132, 231)
        finishDateTimePicker.Name = "finishDateTimePicker"
        finishDateTimePicker.Size = New Size(261, 27)
        finishDateTimePicker.TabIndex = 14
        ' 
        ' finishDateLabel
        ' 
        finishDateLabel.AutoSize = True
        finishDateLabel.Location = New Point(13, 236)
        finishDateLabel.Name = "finishDateLabel"
        finishDateLabel.Size = New Size(103, 20)
        finishDateLabel.TabIndex = 13
        finishDateLabel.Text = "Finishing Date"
        ' 
        ' completionTextBox
        ' 
        completionTextBox.Location = New Point(132, 198)
        completionTextBox.Name = "completionTextBox"
        completionTextBox.Size = New Size(261, 27)
        completionTextBox.TabIndex = 12
        ' 
        ' completionLabel
        ' 
        completionLabel.AutoSize = True
        completionLabel.Location = New Point(13, 201)
        completionLabel.Name = "completionLabel"
        completionLabel.Size = New Size(87, 20)
        completionLabel.TabIndex = 11
        completionLabel.Text = "Completion"
        ' 
        ' endDateTimePicker
        ' 
        endDateTimePicker.Enabled = False
        endDateTimePicker.Location = New Point(132, 165)
        endDateTimePicker.Name = "endDateTimePicker"
        endDateTimePicker.Size = New Size(261, 27)
        endDateTimePicker.TabIndex = 8
        ' 
        ' startDateTimePicker
        ' 
        startDateTimePicker.Enabled = False
        startDateTimePicker.Location = New Point(132, 132)
        startDateTimePicker.Name = "startDateTimePicker"
        startDateTimePicker.Size = New Size(261, 27)
        startDateTimePicker.TabIndex = 7
        ' 
        ' endDateLabel
        ' 
        endDateLabel.AutoSize = True
        endDateLabel.Location = New Point(13, 170)
        endDateLabel.Name = "endDateLabel"
        endDateLabel.Size = New Size(70, 20)
        endDateLabel.TabIndex = 6
        endDateLabel.Text = "End Date"
        ' 
        ' startDateLabel
        ' 
        startDateLabel.AutoSize = True
        startDateLabel.Location = New Point(13, 134)
        startDateLabel.Name = "startDateLabel"
        startDateLabel.Size = New Size(84, 20)
        startDateLabel.TabIndex = 4
        startDateLabel.Text = "Strate Date"
        ' 
        ' descTextBox
        ' 
        descTextBox.Enabled = False
        descTextBox.Location = New Point(132, 57)
        descTextBox.Multiline = True
        descTextBox.Name = "descTextBox"
        descTextBox.Size = New Size(261, 69)
        descTextBox.TabIndex = 3
        ' 
        ' descriptionLabel
        ' 
        descriptionLabel.AutoSize = True
        descriptionLabel.Location = New Point(13, 64)
        descriptionLabel.Name = "descriptionLabel"
        descriptionLabel.Size = New Size(85, 20)
        descriptionLabel.TabIndex = 2
        descriptionLabel.Text = "Description"
        ' 
        ' titleTextBox
        ' 
        titleTextBox.Location = New Point(132, 24)
        titleTextBox.Name = "titleTextBox"
        titleTextBox.Size = New Size(261, 27)
        titleTextBox.TabIndex = 1
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Location = New Point(13, 31)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(38, 20)
        titleLabel.TabIndex = 0
        titleLabel.Text = "Title"
        ' 
        ' PlanManage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(800, 450)
        Controls.Add(editPanel)
        Controls.Add(planDataGridView)
        Controls.Add(planManageTableLayoutPanel)
        Name = "PlanManage"
        Text = "Plan Manage"
        planManageTableLayoutPanel.ResumeLayout(False)
        planManageTableLayoutPanel.PerformLayout()
        CType(planDataGridView, ComponentModel.ISupportInitialize).EndInit()
        editPanel.ResumeLayout(False)
        editPanel.PerformLayout()
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
End Class
