<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlanListForm
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
        planTableLayoutPanel = New TableLayoutPanel()
        listPlanLabel = New Label()
        planListView = New ListView()
        planTableLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' planTableLayoutPanel
        ' 
        planTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        planTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        planTableLayoutPanel.ColumnCount = 5
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.5F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 17.5F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        planTableLayoutPanel.Controls.Add(listPlanLabel, 2, 0)
        planTableLayoutPanel.Dock = DockStyle.Top
        planTableLayoutPanel.Location = New Point(0, 0)
        planTableLayoutPanel.Name = "planTableLayoutPanel"
        planTableLayoutPanel.RowCount = 1
        planTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        planTableLayoutPanel.Size = New Size(800, 57)
        planTableLayoutPanel.TabIndex = 17
        ' 
        ' listPlanLabel
        ' 
        listPlanLabel.AutoSize = True
        listPlanLabel.Font = New Font("Comic Sans MS", 20.0F)
        listPlanLabel.ForeColor = SystemColors.ControlLightLight
        listPlanLabel.Location = New Point(303, 0)
        listPlanLabel.Name = "listPlanLabel"
        listPlanLabel.Size = New Size(154, 47)
        listPlanLabel.TabIndex = 0
        listPlanLabel.Text = "Plan List"
        ' 
        ' planListView
        ' 
        planListView.Dock = DockStyle.Fill
        planListView.Location = New Point(0, 57)
        planListView.Name = "planListView"
        planListView.Size = New Size(800, 393)
        planListView.TabIndex = 18
        planListView.UseCompatibleStateImageBehavior = False
        ' 
        ' Plan_List
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(planListView)
        Controls.Add(planTableLayoutPanel)
        Name = "PlanListForm"
        Text = "Plan List"
        planTableLayoutPanel.ResumeLayout(False)
        planTableLayoutPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents planTableLayoutPanel As TableLayoutPanel
    Friend WithEvents listPlanLabel As Label
    Friend WithEvents planListView As ListView
End Class
