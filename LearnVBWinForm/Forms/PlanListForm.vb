Imports Service

Public Class PlanListForm
    Private _taskInfoService As TaskInfoService
    Private _listOfPlans As List(Of UserTaskViewModel)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _taskInfoService = New TaskInfoService()
        Dim result As Result = _taskInfoService.GetAll()
        _listOfPlans = result.ResModel
        LoadListView(_listOfPlans)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadListView(taskList As List(Of UserTaskViewModel))
        planListView.View = View.Details

        planListView.Columns.Add("Title", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("Description", 300, HorizontalAlignment.Left)
        planListView.Columns.Add("StartDate", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("EndDate", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("Priority", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("User", 100, HorizontalAlignment.Left)

        planListView.Items.Clear()

        For Each task In taskList
            ' Create a new ListViewItem
            Dim listItem As New ListViewItem(task.Title)

            ' Add subitems for each column (TaskName, TaskDescription, etc.)
            listItem.SubItems.Add(task.Description)
            listItem.SubItems.Add(task.Start_Date)
            listItem.SubItems.Add(task.End_Date)
            listItem.SubItems.Add(task.Priority)
            listItem.SubItems.Add(task.Username)

            ' Add the ListViewItem to the ListView
            planListView.Items.Add(listItem)
        Next
    End Sub

    Private Sub reloadButton_Click(sender As Object, e As EventArgs) Handles reloadButton.Click
        _listOfPlans = _taskInfoService.GetAll
        LoadListView(_listOfPlans)
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim searchKey = searchTextBox.Text
        _listOfPlans = _taskInfoService.GetAllBySearchKey(searchKey)
        LoadListView(_listOfPlans)
    End Sub


End Class