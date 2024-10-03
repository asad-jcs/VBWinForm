Imports Service
Imports Windows.Media.Protection.PlayReady

Public Class ProjectForm
    Private _projectService As ProjectService
    Private _selectedItem As Integer
    Private _clientService As ClientService
    Private _project As Project

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        _projectService = New ProjectService()
        _clientService = New ClientService()
        LoadDataGridView()
        Util.LoadDropBox(clientComboBox, _clientService.GetAll(), "Name", "Id")
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub LoadDataGridView()
        Util.LoadGridView(projectDataGridView, _projectService.GetAllProjectInfoWithClient())
        projectDataGridView.Columns("ClientId").Visible = False
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Util.ClearAllInputs(Me)
        addButton.Enabled = True
        updateButton.Enabled = False
        deleteButton.Enabled = False
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim project As New Project()
        project.Name = projNameTextBox.Text
        project.Description = projDesTextBox.Text
        project.ClientId = clientComboBox.SelectedValue

        _projectService.Add(project)

        Util.ClearAllInputs(Me)
        LoadDataGridView()
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim project As New Project()
        project.Id = _selectedItem
        project.Name = projNameTextBox.Text
        project.Description = projDesTextBox.Text
        project.ClientId = clientComboBox.SelectedValue

        _projectService.Update(project)

        Util.ClearAllInputs(Me)
        LoadDataGridView()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim project As New Project()
        project.Id = _selectedItem
        project.Name = projNameTextBox.Text

        Dim res = Util.ShowConfirmationDialog("Are you sure you want to delete this item " + project.Name)

        If res Then
            _projectService.Delete(project.Id)
        End If

        Util.ClearAllInputs(Me)
        LoadDataGridView()
    End Sub

    Private Sub projectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles projectDataGridView.CellClick
        If projectDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = projectDataGridView.SelectedRows(0)
            _project = New Project()
            _project.Id = selectedRow.Cells("Id").Value
            _selectedItem = _project.Id
            If _project.Id > 0 Then
                updateButton.Enabled = True
                deleteButton.Enabled = True
                addButton.Enabled = False
                projNameTextBox.Text = selectedRow.Cells("Name").Value.ToString()
                projDesTextBox.Text = selectedRow.Cells("Description").Value.ToString()
                clientComboBox.SelectedValue = selectedRow.Cells("ClientId").Value
            End If
        End If
    End Sub
End Class