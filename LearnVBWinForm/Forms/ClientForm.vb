Imports Service

Public Class ClientForm
    Private _clientService As ClientService
    Private _selectedItem As Integer
    Private _client As Client
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LoadClient()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadClient()
        _clientService = New ClientService()
        Dim result As Result = _clientService.GetAll()

        If result.Status Then
            Util.LoadGridView(clientDataGridView, CType(result.ResModel, List(Of Client)))
        Else
            Util.ShowMsg(result.ErrorMessage, msgLabel, True)
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim msg = UIValidation.ValidateForm(Me)

        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)
        ElseIf Not String.IsNullOrEmpty(emailTextBox.Text) AndAlso
            Not UIValidation.IsValidEmail(emailTextBox.Text) Then
            Util.ShowMsg(EMAIL_FORMAT, msgLabel, True)
        ElseIf Not String.IsNullOrEmpty(phoneTextBox.Text) AndAlso
            Not UIValidation.IsValidNumber(phoneTextBox.Text) Then
            Util.ShowMsg(NUMBER_FORMAT, msgLabel, True)
        Else
            Dim client As New Client()
            client.Name = cliNameReqTextBox.Text
            client.Phone = phoneTextBox.Text
            client.Email = emailTextBox.Text
            client.Address = addressTextBox.Text

            _clientService.Add(client)

            Util.ClearAllInputs(Me)
            Util.LoadGridView(clientDataGridView, _clientService.GetAll())
        End If

    End Sub

    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        Dim msg = UIValidation.ValidateForm(Me)
        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)
        ElseIf Not String.IsNullOrEmpty(emailTextBox.Text) AndAlso
            Not UIValidation.IsValidEmail(emailTextBox.Text) Then
            Util.ShowMsg(EMAIL_FORMAT, msgLabel, True)
        ElseIf Not String.IsNullOrEmpty(phoneTextBox.Text) AndAlso
            Not UIValidation.IsValidNumber(phoneTextBox.Text) Then
            Util.ShowMsg(NUMBER_FORMAT, msgLabel, True)
        Else
            Dim client As New Client()
            client.Id = _selectedItem
            client.Name = cliNameReqTextBox.Text
            client.Phone = phoneTextBox.Text
            client.Email = emailTextBox.Text
            client.Address = addressTextBox.Text

            Dim res As Result = _clientService.Update(client)
            If res.Status Then
                Util.ShowMsg(UPDATE_MSG, msgLabel)
                Util.ClearAllInputs(Me)
                LoadClient()
            Else
                Util.ShowMsg(res.ErrorMessage, msgLabel, True)
            End If
        End If
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim client As New Client()
        client.Id = _selectedItem
        client.Name = cliNameReqTextBox.Text
        Dim res = Util.ShowConfirmationDialog("Are sure you want to delete this item " + client.Name)

        If res Then
            Dim result As Result = _clientService.Delete(client.Id)
            If result.Status Then
                Util.ShowMsg(DELETE_MSG, msgLabel)
                Util.ClearAllInputs(Me)
                LoadClient()
            Else
                Util.ShowMsg(result.ErrorMessage, msgLabel, True)
            End If
        End If
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
                cliNameReqTextBox.Text = selectedRow.Cells("Name").Value.ToString()
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
        Util.LoadGridView(clientDataGridView, _clientService.GetAll().ResModel)
    End Sub
End Class