Imports Service

Public Class ClientForm
    Private _clientService As ClientService
    Private _selectedItem As Integer
    Private _client As Client
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _clientService = New ClientService()
        Util.LoadGridView(clientDataGridView, _clientService.GetAll())
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim client As New Client()
        client.Name = cliNameTextBox.Text
        client.Phone = phoneTextBox.Text
        client.Email = emailTextBox.Text
        client.Address = addressTextBox.Text

        _clientService.Add(client)

        Util.ClearAllInputs(Me)
        Util.LoadGridView(clientDataGridView, _clientService.GetAll())
    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim client As New Client()
        client.Id = _selectedItem
        client.Name = cliNameTextBox.Text
        client.Phone = phoneTextBox.Text
        client.Email = emailTextBox.Text
        client.Address = addressTextBox.Text

        _clientService.Update(client)

        Util.ClearAllInputs(Me)
        Util.LoadGridView(clientDataGridView, _clientService.GetAll())
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim client As New Client()
        client.Id = _selectedItem
        client.Name = cliNameTextBox.Text
        Dim res = Util.ShowConfirmationDialog("Are sure you want to delete this item " + client.Name)

        If res Then
            _clientService.Delete(client.Id)
        End If

        Util.ClearAllInputs(Me)
        Util.LoadGridView(clientDataGridView, _clientService.GetAll())
    End Sub

    Private Sub clientDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles clientDataGridView.CellClick
        If clientDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = clientDataGridView.SelectedRows(0)
            _client = New Client()
            _client.Id = selectedRow.Cells("Id").Value
            _selectedItem = _client.Id
            If _client.Id > 0 Then
                updateButton.Enabled = True
                deleteButton.Enabled = True
                addButton.Enabled = False
                cliNameTextBox.Text = selectedRow.Cells("Name").Value.ToString()
                emailTextBox.Text = selectedRow.Cells("Email").Value.ToString()
                phoneTextBox.Text = selectedRow.Cells("Phone").Value
                addressTextBox.Text = selectedRow.Cells("Address").Value.ToString()
            End If
        End If
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Util.ClearAllInputs(Me)
        addButton.Enabled = True
        updateButton.Enabled = False
        deleteButton.Enabled = False
        Util.LoadGridView(clientDataGridView, _clientService.GetAll())
    End Sub
End Class