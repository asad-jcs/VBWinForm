Imports System.Windows.Forms
Imports Service

Public Class PlanManage

    Private ReadOnly _taskService As TaskInfoService
    Private ReadOnly _userService As UserService
    Private ReadOnly _projectService As ProjectService
    Private _listOfTask As List(Of UserTaskViewModel)
    Private _taskInfo As Task_Info
    Private _selectedItem As Integer
    Private _priorityDictionary As New Dictionary(Of String, String)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _taskService = New TaskInfoService()
        _userService = New UserService()
        _projectService = New ProjectService()

        LoadPlanDataGridView()
        LoadDropdown()


        ' This allows for a "blank" appearance while still being able to select dates
        endReqDateTimePicker.Format = DateTimePickerFormat.Custom
        endReqDateTimePicker.CustomFormat = "yyyy/MM/dd" ' or any other format you prefer
        endReqDateTimePicker.ShowCheckBox = True ' Allow checking to "clear" the date
        endReqDateTimePicker.Value = DateTimePicker.MinimumDateTime ' Initially set to the minimum date
    End Sub
    Private Sub LoadPlanDataGridView()
        Dim result As Result = _taskService.GetAll()
        _listOfTask = result.ResModel
        Util.LoadGridView(planDataGridView, _listOfTask)
        planDataGridView.Columns("User_ID").Visible = False
        planDataGridView.Columns("ProjectId").Visible = False
    End Sub
    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim title As String = titleReqTextBox.Text

        Dim confirm As Boolean = Util.ShowConfirmationDialog(title + " will be deleted")

        If confirm Then
            Dim res As Result = _taskService.Delete(_selectedItem)
            If res.Status Then
                Util.ShowMsg(DELETE_MSG, msgLabel)
                LoadPlanDataGridView()
            Else
                Util.ShowMsg(res.ErrorMessage, msgLabel, True)
            End If
        End If


    End Sub
    Private Sub planDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles planDataGridView.CellClick
        If planDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = planDataGridView.SelectedRows(0)
            _taskInfo = New Task_Info()
            _taskInfo.Id = selectedRow.Cells("Id").Value
            _selectedItem = _taskInfo.Id
            If _taskInfo.Id > 0 Then
                updteButton.Enabled = True
                deleteButton.Enabled = True
                addButton.Enabled = False

                titleReqTextBox.Text = selectedRow.Cells("Title").Value.ToString()
                descTextBox.Text = selectedRow.Cells("Description").Value.ToString()
                Dim startDate As DateTime
                If DateTime.TryParse(selectedRow.Cells("Start_Date").Value.ToString(), startDate) Then
                    startReqDateTimePicker.Value = startDate
                End If
                Dim endDate As DateTime
                If DateTime.TryParse(selectedRow.Cells("End_Date").Value.ToString(), endDate) Then
                    endReqDateTimePicker.Value = endDate
                End If
                Dim finishDate As DateTime
                If selectedRow.Cells("Finishing_Date").Value IsNot Nothing Then
                    ' Attempt to parse the cell value to a DateTime
                    If DateTime.TryParse(selectedRow.Cells("Finishing_Date").Value.ToString(), finishDate) Then
                        ' If parsing is successful, set the DateTimePicker value
                        endReqDateTimePicker.Value = finishDate
                    End If
                End If
                completionTextBox.Text = selectedRow.Cells("Completion").Value

                userReqComboBox.SelectedValue = selectedRow.Cells("User_Id").Value.ToString()
                projectReqComboBox.SelectedValue = selectedRow.Cells("ProjectId").Value.ToString()
                Dim val = selectedRow.Cells("Priority").Value.ToString()
                priorityReqComboBox.SelectedValue = val


            End If
        End If
    End Sub
    Private Sub updteButton_Click(sender As Object, e As EventArgs) Handles updteButton.Click

        Dim msg = UIValidation.ValidateForm(Me)

        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)
        ElseIf Not String.IsNullOrEmpty(completionTextBox.Text) AndAlso
            UIValidation.IsValidNumber(completionTextBox.Text) Then
            Util.ShowMsg(NUMBER_FORMAT, msgLabel, True)
        Else

            Dim taskInfo As New Task_Info()
            taskInfo.Id = _selectedItem
            taskInfo.Title = titleReqTextBox.Text
            taskInfo.Description = descTextBox.Text
            taskInfo.UserID = userReqComboBox.SelectedValue
            taskInfo.ProjectId = projectReqComboBox.SelectedValue
            taskInfo.Priority = priorityReqComboBox.SelectedValue
            taskInfo.Completion = If(String.IsNullOrEmpty(completionTextBox.Text), 0D, Convert.ToDecimal(completionTextBox.Text))

            Dim d1 = endReqDateTimePicker.Value.Date
            Dim d2 = DateTimePicker.MinimumDateTime.Date

            taskInfo.Start_Date = startReqDateTimePicker.Value
            taskInfo.End_Date = endReqDateTimePicker.Value
            If d1 = d2 Then
                taskInfo.Finishing_Date = Nothing ' Set to null if no date is selected
            Else
                taskInfo.Finishing_Date = endReqDateTimePicker.Value ' Assign the selected date
            End If

            Dim res As Result = _taskService.UpdateTask(taskInfo)

            If res.Status Then
                Util.ShowMsg(taskInfo.Title + UPDATE_MSG, msgLabel)
                LoadPlanDataGridView()
            Else
                Util.ShowMsg(res.ErrorMessage, msgLabel, True)
            End If

        End If

    End Sub
    Private Sub planDataGridView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles planDataGridView.CellPainting
        ' Check if we are painting the completion column
        If e.ColumnIndex = planDataGridView.Columns("Completion").Index AndAlso e.RowIndex >= 0 Then
            ' Prevent default painting
            e.Handled = True

            ' Draw the cell background
            e.Graphics.FillRectangle(Brushes.White, e.CellBounds)

            ' Get the completion value
            Dim completionRate As Integer = If(IsNumeric(e.Value), CInt(e.Value), 0)

            ' Draw the progress bar
            Dim progressBarBounds As New Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2,
                                                   e.CellBounds.Width - 4, e.CellBounds.Height - 4)

            ' Draw the background of the progress bar
            e.Graphics.FillRectangle(Brushes.LightGray, progressBarBounds)

            ' Calculate the filled area
            Dim fillWidth As Integer = CInt((completionRate / 100.0) * progressBarBounds.Width)
            If fillWidth = 96 Then
                Dim filledRect As New Rectangle(progressBarBounds.X, progressBarBounds.Y,
                                                 fillWidth, progressBarBounds.Height)
                e.Graphics.FillRectangle(Brushes.LightSeaGreen, filledRect) ' Change color as needed
            Else
                Dim filledRect As New Rectangle(progressBarBounds.X, progressBarBounds.Y,
                                                 fillWidth, progressBarBounds.Height)
                e.Graphics.FillRectangle(Brushes.LightSalmon, filledRect) ' Change color as needed
            End If

            ' Optionally draw the percentage text
            e.Graphics.DrawString(completionRate.ToString() & "%", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault)
        End If
    End Sub
    Private Sub planDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles planDataGridView.CellFormatting
        If planDataGridView.Columns(e.ColumnIndex).Name = "End_Date" Then
            Dim endDate As DateTime
            Dim currentRowIndex As Integer = e.RowIndex
            Dim completionValue As Object = planDataGridView.Rows(currentRowIndex).Cells("Completion").Value
            ' Attempt to parse the cell value as a DateTime
            If DateTime.TryParse(e.Value?.ToString(), endDate) Then
                ' Compare the due date with the current date
                Dim daysUntilDue As Integer = (endDate.Date - DateTime.Now.Date).Days

                ' Change row color based on the comparison
                If completionValue = 100 Then
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGray
                ElseIf daysUntilDue <= 7 And daysUntilDue >= 0 Then
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow ' Change to yellow for upcoming due dates
                ElseIf daysUntilDue < 0 Then
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.OrangeRed ' Change to red for overdue tasks
                Else
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White ' Default color
                End If
            End If
        End If

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        Dim msg = UIValidation.ValidateForm(Me)

        If Not String.IsNullOrEmpty(msg) Then
            Util.ShowMsg(msg, msgLabel, True)
        ElseIf Not String.IsNullOrEmpty(completionTextBox.Text) AndAlso
            UIValidation.IsValidNumber(completionTextBox.Text) Then
            Util.ShowMsg(NUMBER_FORMAT, msgLabel, True)
        Else
            Dim taskInfo = New Task_Info()

            taskInfo.Title = titleReqTextBox.Text
            taskInfo.Description = descTextBox.Text
            taskInfo.Start_Date = startReqDateTimePicker.Value
            taskInfo.End_Date = endReqDateTimePicker.Value

            Dim selectedValue As String = priorityReqComboBox.SelectedItem.ToString()

            ' Find the corresponding key in the dictionary based on the selected value
            Dim selectedKey As String = _priorityDictionary.FirstOrDefault(Function(kvp) kvp.Value = selectedValue).Key
            taskInfo.Priority = selectedKey
            'If userReqComboBox.SelectedValue Is Nothing Then
            '    taskInfo.UserID = _userID
            'Else
            '    taskInfo.UserID = userReqComboBox.SelectedValue
            'End If

            taskInfo.ProjectId = projectReqComboBox.SelectedValue
            taskInfo.UserID = userReqComboBox.SelectedValue
            taskInfo.Priority = priorityReqComboBox.SelectedValue
            Dim res As Result = _taskService.Add(taskInfo)
            If res.Status Then
                Util.ShowMsg(SUCCESS_MSG, msgLabel)
                Util.ClearAllInputs(Me)
                LoadPlanDataGridView()
            Else
                Util.ShowMsg(SUCCESS_MSG, msgLabel, True)
            End If

        End If


    End Sub

    Private Sub LoadDropdown()

        Dim priorityList As New DataTable()
        priorityList.Columns.Add("Value", GetType(String))
        priorityList.Columns.Add("Display", GetType(String))

        _priorityDictionary = Util.PriorityList()
        For Each kvp As KeyValuePair(Of String, String) In _priorityDictionary
            priorityList.Rows.Add(kvp.Key, kvp.Value)
        Next

        priorityReqComboBox.DataSource = priorityList
        priorityReqComboBox.DisplayMember = "Display"
        priorityReqComboBox.ValueMember = "Value"

        Util.LoadDropBox(userReqComboBox, _userService.GetAll().ResModel, "Username", "Id")
        Util.LoadDropBox(projectReqComboBox, _projectService.GetAll().ResModel, "Name", "Id")
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim searchKey As String = searchTextBox.Text.Trim()
        If searchKey Is "" Or searchKey Is Nothing Then
            LoadPlanDataGridView()
        Else
            _listOfTask = _taskService.GetAllBySearchKey(searchKey).ResModel
            Util.LoadGridView(planDataGridView, _listOfTask)
        End If

    End Sub

    Private Sub reloadButton_Click(sender As Object, e As EventArgs) Handles reloadButton.Click
        LoadPlanDataGridView()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        Util.ClearAllInputs(Me)
        addButton.Enabled = True
        updteButton.Enabled = False
        deleteButton.Enabled = False
    End Sub
End Class