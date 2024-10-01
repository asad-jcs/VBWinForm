﻿Imports Service

Public Class PlanListForm
    Private _taskInfoService As TaskInfoService
    Private _listOfPlans As List(Of Task_Info)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        _taskInfoService = New TaskInfoService()
        _listOfPlans = _taskInfoService.GetAll()
        LoadListView(_listOfPlans)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub LoadListView(taskList As List(Of Task_Info))
        planListView.View = View.Details

        planListView.Columns.Add("Title", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("Description", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("StartDate", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("EndDate", 100, HorizontalAlignment.Left)
        planListView.Columns.Add("Priority", 100, HorizontalAlignment.Left)

        planListView.Items.Clear()

        For Each task In taskList
            ' Create a new ListViewItem
            Dim listItem As New ListViewItem(task.Title)

            ' Add subitems for each column (TaskName, TaskDescription, etc.)
            listItem.SubItems.Add(task.Description)
            listItem.SubItems.Add(task.Start_Date)
            listItem.SubItems.Add(task.End_Date)
            listItem.SubItems.Add(task.Priority)

            ' Add the ListViewItem to the ListView
            planListView.Items.Add(listItem)
        Next
    End Sub

End Class