<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanForm
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
        titleLabel = New Label()
        titleTextBox = New TextBox()
        descriptionTextBox = New TextBox()
        descriptionLabel = New Label()
        durationLabel = New Label()
        startDateTimePicker = New DateTimePicker()
        endDateTimePicker = New DateTimePicker()
        endLabel = New Label()
        Label1 = New Label()
        priorityComboBox = New ComboBox()
        addButton = New Button()
        ColorDialog1 = New ColorDialog()
        FontDialog1 = New FontDialog()
        entryPlanLabel = New Label()
        planTableLayoutPanel = New TableLayoutPanel()
        userComboBox = New ComboBox()
        assignLabel = New Label()
        planTableLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' titleLabel
        ' 
        titleLabel.AutoSize = True
        titleLabel.Location = New Point(26, 84)
        titleLabel.Name = "titleLabel"
        titleLabel.Size = New Size(38, 20)
        titleLabel.TabIndex = 0
        titleLabel.Text = "Title"
        ' 
        ' titleTextBox
        ' 
        titleTextBox.Location = New Point(162, 81)
        titleTextBox.Name = "titleTextBox"
        titleTextBox.Size = New Size(311, 27)
        titleTextBox.TabIndex = 1
        ' 
        ' descriptionTextBox
        ' 
        descriptionTextBox.Location = New Point(162, 127)
        descriptionTextBox.Multiline = True
        descriptionTextBox.Name = "descriptionTextBox"
        descriptionTextBox.Size = New Size(311, 100)
        descriptionTextBox.TabIndex = 5
        ' 
        ' descriptionLabel
        ' 
        descriptionLabel.AutoSize = True
        descriptionLabel.Location = New Point(26, 134)
        descriptionLabel.Name = "descriptionLabel"
        descriptionLabel.Size = New Size(85, 20)
        descriptionLabel.TabIndex = 4
        descriptionLabel.Text = "Description"
        ' 
        ' durationLabel
        ' 
        durationLabel.AutoSize = True
        durationLabel.Location = New Point(26, 258)
        durationLabel.Name = "durationLabel"
        durationLabel.Size = New Size(76, 20)
        durationLabel.TabIndex = 6
        durationLabel.Text = "Start Date"
        ' 
        ' startDateTimePicker
        ' 
        startDateTimePicker.Location = New Point(162, 253)
        startDateTimePicker.Name = "startDateTimePicker"
        startDateTimePicker.Size = New Size(202, 27)
        startDateTimePicker.TabIndex = 7
        ' 
        ' endDateTimePicker
        ' 
        endDateTimePicker.Location = New Point(465, 253)
        endDateTimePicker.Name = "endDateTimePicker"
        endDateTimePicker.Size = New Size(203, 27)
        endDateTimePicker.TabIndex = 9
        ' 
        ' endLabel
        ' 
        endLabel.AutoSize = True
        endLabel.Location = New Point(383, 258)
        endLabel.Name = "endLabel"
        endLabel.Size = New Size(70, 20)
        endLabel.TabIndex = 8
        endLabel.Text = "End Date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 10
        Label1.Text = "Priority"
        ' 
        ' priorityComboBox
        ' 
        priorityComboBox.FormattingEnabled = True
        priorityComboBox.Location = New Point(162, 302)
        priorityComboBox.Name = "priorityComboBox"
        priorityComboBox.Size = New Size(202, 28)
        priorityComboBox.TabIndex = 11
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(162, 392)
        addButton.Name = "addButton"
        addButton.Size = New Size(94, 29)
        addButton.TabIndex = 12
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' entryPlanLabel
        ' 
        entryPlanLabel.AutoSize = True
        entryPlanLabel.Font = New Font("Comic Sans MS", 20F)
        entryPlanLabel.ForeColor = SystemColors.ControlLightLight
        entryPlanLabel.Location = New Point(303, 0)
        entryPlanLabel.Name = "entryPlanLabel"
        entryPlanLabel.Size = New Size(181, 47)
        entryPlanLabel.TabIndex = 0
        entryPlanLabel.Text = "Plan Entry"
        ' 
        ' planTableLayoutPanel
        ' 
        planTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        planTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        planTableLayoutPanel.ColumnCount = 5
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.5F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.5F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        planTableLayoutPanel.Controls.Add(entryPlanLabel, 2, 0)
        planTableLayoutPanel.Dock = DockStyle.Top
        planTableLayoutPanel.Location = New Point(0, 0)
        planTableLayoutPanel.Name = "planTableLayoutPanel"
        planTableLayoutPanel.RowCount = 1
        planTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        planTableLayoutPanel.Size = New Size(800, 57)
        planTableLayoutPanel.TabIndex = 16
        ' 
        ' userComboBox
        ' 
        userComboBox.FormattingEnabled = True
        userComboBox.Location = New Point(162, 354)
        userComboBox.Name = "userComboBox"
        userComboBox.Size = New Size(202, 28)
        userComboBox.TabIndex = 19
        ' 
        ' assignLabel
        ' 
        assignLabel.AutoSize = True
        assignLabel.Location = New Point(26, 357)
        assignLabel.Name = "assignLabel"
        assignLabel.Size = New Size(52, 20)
        assignLabel.TabIndex = 18
        assignLabel.Text = "Assign"
        ' 
        ' PlanForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(userComboBox)
        Controls.Add(assignLabel)
        Controls.Add(planTableLayoutPanel)
        Controls.Add(addButton)
        Controls.Add(priorityComboBox)
        Controls.Add(Label1)
        Controls.Add(endDateTimePicker)
        Controls.Add(endLabel)
        Controls.Add(startDateTimePicker)
        Controls.Add(durationLabel)
        Controls.Add(descriptionTextBox)
        Controls.Add(descriptionLabel)
        Controls.Add(titleTextBox)
        Controls.Add(titleLabel)
        Name = "PlanForm"
        Text = "PlanForm"
        WindowState = FormWindowState.Maximized
        planTableLayoutPanel.ResumeLayout(False)
        planTableLayoutPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents titleTextBox As TextBox
    Friend WithEvents descriptionTextBox As TextBox
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents durationLabel As Label
    Friend WithEvents startDateTimePicker As DateTimePicker
    Friend WithEvents endDateTimePicker As DateTimePicker
    Friend WithEvents endLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents priorityComboBox As ComboBox
    Friend WithEvents addButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents entryPlanLabel As Label
    Friend WithEvents planTableLayoutPanel As TableLayoutPanel
    Friend WithEvents userComboBox As ComboBox
    Friend WithEvents assignLabel As Label
End Class
