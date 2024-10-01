Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Service

Public Class PlanForm
    Private _taskInfoService As TaskInfoService
    Private _userID As Integer
    Private _priorityDictionary As New Dictionary(Of String, String)
    Public Sub New(userId As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        _priorityDictionary = Util.PriorityList
        LoadDropdown()
        _taskInfoService = New TaskInfoService()
        _userID = userId
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim taskInfo = New Task_Info()

        taskInfo.Title = titleTextBox.Text
        taskInfo.Description = descriptionTextBox.Text
        taskInfo.Start_Date = startDateTimePicker.Value
        taskInfo.End_Date = endDateTimePicker.Value

        Dim selectedValue As String = priorityComboBox.SelectedItem.ToString()

        ' Find the corresponding key in the dictionary based on the selected value
        Dim selectedKey As String = _priorityDictionary.FirstOrDefault(Function(kvp) kvp.Value = selectedValue).Key
        taskInfo.Priority = selectedKey
        taskInfo.UserID = _userID

        _taskInfoService.Add(taskInfo)
    End Sub

    Private Sub LoadDropdown()
        For Each kvp As KeyValuePair(Of String, String) In _priorityDictionary
            priorityComboBox.Items.Add(kvp.Value)
        Next
    End Sub
End Class