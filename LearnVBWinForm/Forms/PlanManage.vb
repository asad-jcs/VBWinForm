Imports System.Windows.Forms
Imports Service

Public Class PlanManage

    Private ReadOnly _taskService As TaskInfoService
    Private ReadOnly _userService As UserService
    Private _listOfTask As List(Of UserTaskViewModel)
    Private _taskInfo As Task_Info
    Private _selectedItem As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _taskService = New TaskInfoService()
        _userService = New UserService()

        LoadPlanDataGridView()

        Util.LoadDropBox(userComboBox, _userService.GetAll(), "Username", "Id")

        finishDateTimePicker.Format = DateTimePickerFormat.Custom
        finishDateTimePicker.CustomFormat = " " ' This makes it look empty
        finishDateTimePicker.Value = DateTimePicker.MinimumDateTime
    End Sub
    Private Sub LoadPlanDataGridView()
        _listOfTask = _taskService.GetAll()
        Util.LoadGridView(planDataGridView, _listOfTask)
        planDataGridView.Columns("User_ID").Visible = False

    End Sub
    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim title As String = titleTextBox.Text

        Dim confirm As Boolean = Util.ShowConfirmationDialog(title + " will be deleted")

        If confirm Then
            _taskService.Delete(_selectedItem)
        End If

        LoadPlanDataGridView()
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

                titleTextBox.Text = selectedRow.Cells("Title").Value.ToString()
                descTextBox.Text = selectedRow.Cells("Description").Value.ToString()
                Dim startDate As DateTime
                If DateTime.TryParse(selectedRow.Cells("Start_Date").Value.ToString(), startDate) Then
                    startDateTimePicker.Value = startDate
                End If
                Dim endDate As DateTime
                If DateTime.TryParse(selectedRow.Cells("End_Date").Value.ToString(), endDate) Then
                    endDateTimePicker.Value = endDate
                End If
                Dim finishDate As DateTime
                If selectedRow.Cells("Finishing_Date").Value IsNot Nothing Then
                    ' Attempt to parse the cell value to a DateTime
                    If DateTime.TryParse(selectedRow.Cells("Finishing_Date").Value.ToString(), finishDate) Then
                        ' If parsing is successful, set the DateTimePicker value
                        finishDateTimePicker.Value = finishDate
                    End If
                End If
                completionTextBox.Text = selectedRow.Cells("Completion").Value

                userComboBox.SelectedValue = selectedRow.Cells("User_Id").Value.ToString()

            End If
        End If
    End Sub
    Private Sub updteButton_Click(sender As Object, e As EventArgs) Handles updteButton.Click
        Dim taskInfo As New Task_Info()
        taskInfo.Id = _selectedItem
        taskInfo.Title = titleTextBox.Text
        taskInfo.Description = descTextBox.Text
        taskInfo.UserID = userComboBox.SelectedValue
        taskInfo.Completion = If(String.IsNullOrEmpty(completionTextBox.Text), 0D, Convert.ToDecimal(completionTextBox.Text))

        Dim d1 = finishDateTimePicker.Value.Date
        Dim d2 = DateTimePicker.MinimumDateTime.Date

        If d1 = d2 Then
            taskInfo.Finishing_Date = Nothing ' Set to null if no date is selected
        Else
            taskInfo.Finishing_Date = finishDateTimePicker.Value ' Assign the selected date
        End If

        _taskService.UpdateTask(taskInfo)
        MessageBox.Show(taskInfo.Title + " Updated successfully")

        LoadPlanDataGridView()
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
            If fillWidth > 0 Then
                Dim filledRect As New Rectangle(progressBarBounds.X, progressBarBounds.Y,
                                                 fillWidth, progressBarBounds.Height)
                e.Graphics.FillRectangle(Brushes.Green, filledRect) ' Change color as needed
            End If

            ' Optionally draw the percentage text
            e.Graphics.DrawString(completionRate.ToString() & "%", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault)
        End If
    End Sub

    Private Sub planDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles planDataGridView.CellFormatting
        If planDataGridView.Columns(e.ColumnIndex).Name = "End_Date" Then
            Dim endDate As DateTime

            ' Attempt to parse the cell value as a DateTime
            If DateTime.TryParse(e.Value?.ToString(), endDate) Then
                ' Compare the due date with the current date
                Dim daysUntilDue As Integer = (endDate.Date - DateTime.Now.Date).Days

                ' Change row color based on the comparison
                If daysUntilDue <= 7 And daysUntilDue >= 0 Then
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow ' Change to yellow for upcoming due dates
                ElseIf daysUntilDue < 0 Then
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Red ' Change to red for overdue tasks
                Else
                    planDataGridView.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White ' Default color
                End If
            End If
        End If
    End Sub

End Class