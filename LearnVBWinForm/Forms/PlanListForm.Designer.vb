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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanListForm))
        planTableLayoutPanel = New TableLayoutPanel()
        listPlanLabel = New Label()
        planListView = New ListView()
        searchButton = New Button()
        reloadButton = New Button()
        searchTextBox = New TextBox()
        panelListSplitContainer = New SplitContainer()
        planTableLayoutPanel.SuspendLayout()
        CType(panelListSplitContainer, ComponentModel.ISupportInitialize).BeginInit()
        panelListSplitContainer.Panel1.SuspendLayout()
        panelListSplitContainer.Panel2.SuspendLayout()
        panelListSplitContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' planTableLayoutPanel
        ' 
        planTableLayoutPanel.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        planTableLayoutPanel.BackgroundImageLayout = ImageLayout.Center
        planTableLayoutPanel.ColumnCount = 5
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 5F))
        planTableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        planTableLayoutPanel.Controls.Add(listPlanLabel, 2, 0)
        planTableLayoutPanel.Dock = DockStyle.Top
        planTableLayoutPanel.Location = New Point(0, 0)
        planTableLayoutPanel.Name = "planTableLayoutPanel"
        planTableLayoutPanel.RowCount = 1
        planTableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        planTableLayoutPanel.Size = New Size(800, 57)
        planTableLayoutPanel.TabIndex = 17
        ' 
        ' listPlanLabel
        ' 
        listPlanLabel.AutoSize = True
        listPlanLabel.Font = New Font("Comic Sans MS", 20F)
        listPlanLabel.ForeColor = SystemColors.ControlLightLight
        listPlanLabel.Location = New Point(363, 0)
        listPlanLabel.Name = "listPlanLabel"
        listPlanLabel.Size = New Size(154, 47)
        listPlanLabel.TabIndex = 0
        listPlanLabel.Text = "Plan List"
        ' 
        ' planListView
        ' 
        planListView.BackColor = Color.FromArgb(CByte(189), CByte(195), CByte(199))
        planListView.Dock = DockStyle.Fill
        planListView.Location = New Point(0, 0)
        planListView.Name = "planListView"
        planListView.Size = New Size(530, 393)
        planListView.TabIndex = 28
        planListView.UseCompatibleStateImageBehavior = False
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.Bisque
        searchButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        searchButton.ForeColor = SystemColors.ActiveCaptionText
        searchButton.Image = My.Resources.Resources.search
        searchButton.ImageAlign = ContentAlignment.MiddleRight
        searchButton.Location = New Point(11, 39)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(133, 29)
        searchButton.TabIndex = 29
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' reloadButton
        ' 
        reloadButton.BackColor = SystemColors.GradientInactiveCaption
        reloadButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        reloadButton.ForeColor = SystemColors.ActiveCaptionText
        reloadButton.Image = CType(resources.GetObject("reloadButton.Image"), Image)
        reloadButton.ImageAlign = ContentAlignment.MiddleRight
        reloadButton.Location = New Point(12, 74)
        reloadButton.Name = "reloadButton"
        reloadButton.Size = New Size(133, 29)
        reloadButton.TabIndex = 31
        reloadButton.Text = "Reload"
        reloadButton.UseVisualStyleBackColor = False
        ' 
        ' searchTextBox
        ' 
        searchTextBox.Location = New Point(11, 6)
        searchTextBox.Name = "searchTextBox"
        searchTextBox.Size = New Size(251, 27)
        searchTextBox.TabIndex = 30
        ' 
        ' panelListSplitContainer
        ' 
        panelListSplitContainer.AllowDrop = True
        panelListSplitContainer.Dock = DockStyle.Fill
        panelListSplitContainer.Location = New Point(0, 57)
        panelListSplitContainer.Name = "panelListSplitContainer"
        ' 
        ' panelListSplitContainer.Panel1
        ' 
        panelListSplitContainer.Panel1.Controls.Add(searchTextBox)
        panelListSplitContainer.Panel1.Controls.Add(searchButton)
        panelListSplitContainer.Panel1.Controls.Add(reloadButton)
        ' 
        ' panelListSplitContainer.Panel2
        ' 
        panelListSplitContainer.Panel2.Controls.Add(planListView)
        panelListSplitContainer.Size = New Size(800, 393)
        panelListSplitContainer.SplitterDistance = 266
        panelListSplitContainer.TabIndex = 32
        ' 
        ' PlanListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelListSplitContainer)
        Controls.Add(planTableLayoutPanel)
        Name = "PlanListForm"
        Text = "Plan List"
        planTableLayoutPanel.ResumeLayout(False)
        planTableLayoutPanel.PerformLayout()
        panelListSplitContainer.Panel1.ResumeLayout(False)
        panelListSplitContainer.Panel1.PerformLayout()
        panelListSplitContainer.Panel2.ResumeLayout(False)
        CType(panelListSplitContainer, ComponentModel.ISupportInitialize).EndInit()
        panelListSplitContainer.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents planTableLayoutPanel As TableLayoutPanel
    Friend WithEvents listPlanLabel As Label
    Friend WithEvents planListView As ListView
    Friend WithEvents searchButton As Button
    Friend WithEvents reloadButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents panelListSplitContainer As SplitContainer
End Class
