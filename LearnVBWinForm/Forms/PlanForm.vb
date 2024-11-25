Imports System.Windows.Forms
Imports Service

Public Class PlanForm
    Private _taskInfoService As TaskInfoService
    Private _userService As UserService
    Private _userID As Integer
    Private _priorityDictionary As New Dictionary(Of String, String)
    Public Sub New(userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        _priorityDictionary = Util.PriorityList
        _taskInfoService = New TaskInfoService()
        _userService = New UserService()
        _userID = userId
        LoadDropdown()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim taskInfo = New Task_Info()

        taskInfo.Title = titleTextBox.Text
        taskInfo.Description = descriptionTextBox.Text
        taskInfo.Start_Date = startDateTimePicker.Value
        taskInfo.End_Date = endDateTimePicker.Value

        Dim selectedValue As String = priorityReqComboBox.SelectedItem.ToString()

        ' Find the corresponding key in the dictionary based on the selected value
        Dim selectedKey As String = _priorityDictionary.FirstOrDefault(Function(kvp) kvp.Value = selectedValue).Key
        taskInfo.Priority = selectedKey
        If userReqComboBox.SelectedValue Is Nothing Then
            taskInfo.UserID = _userID
        Else
            taskInfo.UserID = userReqComboBox.SelectedValue
        End If

        _taskInfoService.Add(taskInfo)

        MessageBox.Show("Task Has Registered Successfully")
        Util.ClearAllInputs(Me)
    End Sub

    Private Sub LoadDropdown()
        For Each kvp As KeyValuePair(Of String, String) In _priorityDictionary
            priorityReqComboBox.Items.Add(kvp.Value)
        Next

        Util.LoadDropBox(userReqComboBox, _userService.GetAll(), "Username", "Id")

    End Sub


End Class