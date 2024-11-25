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
        Init()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Init()
        Util.ClearAllInputs(Me)
        addButton.Enabled = True
        updateButton.Enabled = False
        deleteButton.Enabled = False

        LoadDataGridView()
        LoadComboBox()
    End Sub

    Private Sub LoadComboBox()
        Dim _result As Result = _clientService.GetAll()
        Util.LoadDropBox(clientReqComboBox, CType(_result.ResModel, List(Of Client)), "Name", "Id")
    End Sub

    Private Sub LoadDataGridView()
        Dim _result As Result = _projectService.GetAllProjectInfoWithClient()
        Util.LoadGridView(projectDataGridView, CType(_result.ResModel, List(Of ProjectClientViewModel)))
        projectDataGridView.Columns("ClientId").Visible = False
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Init()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        Dim msg = UIValidation.ValidateForm(Me)
        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)
        Else
            Dim project As New Project()
            project.Name = projNameReqTextBox.Text
            project.Description = projDesTextBox.Text
            project.ClientId = clientReqComboBox.SelectedValue

            Dim res As Result = _projectService.Add(project)

            If res.Status Then
                Util.ShowMsg(SUCCESS_MSG, msgLabel)
                Util.ClearAllInputs(Me)
                LoadDataGridView()
            Else
                Util.ShowMsg(res.ErrorMessage, msgLabel, True)
            End If
        End If
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        Dim project As New Project()
        project.Id = _selectedItem
        project.Name = projNameReqTextBox.Text
        project.Description = projDesTextBox.Text
        project.ClientId = clientReqComboBox.SelectedValue

        _projectService.Update(project)

        Util.ClearAllInputs(Me)
        LoadDataGridView()
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim project As New Project()
        project.Id = _selectedItem
        project.Name = projNameReqTextBox.Text

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
                projNameReqTextBox.Text = selectedRow.Cells("Name").Value.ToString()
                projDesTextBox.Text = selectedRow.Cells("Description").Value.ToString()
                clientReqComboBox.SelectedValue = selectedRow.Cells("ClientId").Value.ToString()
            End If
        End If
    End Sub
End Class