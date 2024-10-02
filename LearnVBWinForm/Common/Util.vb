Public Class Util
    Private Shared _priority As New Dictionary(Of String, String) From {
        {"LOW", "Low"},
        {"MEDIUM", "Medium"},
        {"HIGH", "High"}
    }

    Public Shared Function PriorityList()
        Return _priority
    End Function

    Public Shared Sub LoadDropBox(Of T)(combobox As ComboBox, list As List(Of T), displayMember As String, valueMember As String)

        combobox.DataSource = list

        combobox.DisplayMember = displayMember

        combobox.ValueMember = valueMember
    End Sub

    Public Shared Sub ClearAllInputs(currentForm As Form)
        ' Iterate through all the controls in the form
        For Each control As Control In currentForm.Controls
            ' Recursively clear controls in nested containers (like panels, group boxes)
            ClearControl(control)
        Next
    End Sub

    Private Shared Sub ClearControl(control As Control)
        ' Check if the control is a TextBox before casting it
        If TypeOf control Is TextBox Then
            DirectCast(control, TextBox).Clear()
        End If

        ' Check if the control is a ComboBox before casting it
        If TypeOf control Is ComboBox Then
            DirectCast(control, ComboBox).SelectedIndex = -1
        End If

        ' Check if the control is a CheckBox and uncheck it
        If TypeOf control Is CheckBox Then
            DirectCast(control, CheckBox).Checked = False
        End If

        ' Check if the control is a RadioButton and uncheck it
        If TypeOf control Is RadioButton Then
            DirectCast(control, RadioButton).Checked = False
        End If

        ' If the control is a container (like a Panel or GroupBox), recursively clear its children
        If control.HasChildren Then
            For Each childControl As Control In control.Controls
                ClearControl(childControl)
            Next
        End If
    End Sub

    Public Shared Sub LoadGridView(Of T)(gridView As DataGridView, list As List(Of T))
        gridView.DataSource = list
    End Sub

    ' Function to show a confirmation dialog
    Public Shared Function ShowConfirmationDialog(message As String) As DialogResult
        ' Show the message box with Yes and No buttons and a question icon
        Return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function
End Class
