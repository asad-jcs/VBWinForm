Imports System.Text.RegularExpressions

Public Class UIValidation
    Public Shared Function ValidateForm(currentForm As Form)
        ' Iterate through all the controls in the form
        Dim message = ""
        For Each control As Control In currentForm.Controls
            ' Recursively clear controls in nested containers (like panels, group boxes)
            If control.HasChildren Then
                For Each childControl As Control In control.Controls
                    If Not CheckUIInput(childControl) Then ' Recursive call for child controls
                        message = String.Format(INPUT_ERROR, childControl.Name) + "; " + Environment.NewLine() + message
                    End If
                Next
            End If

            If Not CheckUIInput(control) Then
                message = String.Format(INPUT_ERROR, control.Name) + "; " + Environment.NewLine() + message
            End If
        Next

        Return message
    End Function

    Private Shared Function CheckUIInput(control As Control)

        ' Check if the control is a TextBox before casting it
        If TypeOf control Is TextBox AndAlso
            control.Name.ToLower().Contains("req") AndAlso
            String.IsNullOrEmpty(CType(control, TextBox).Text) Then
            Return False
        End If

        ' Check if the control is a ComboBox before casting it
        If TypeOf control Is ComboBox AndAlso
            control.Name.ToLower().Contains("req") AndAlso
            (String.IsNullOrEmpty(CType(control, ComboBox).Text) OrElse CType(control, ComboBox).SelectedIndex = -1) Then
            Return False
        End If

        ' Check if the control is a CheckBox and uncheck it
        If TypeOf control Is CheckBox AndAlso control.Name.ToLower().Contains("req") Then
            Return False
        End If

        ' Check if the control is a RadioButton and uncheck it
        If TypeOf control Is RadioButton AndAlso control.Name.ToLower().Contains("req") Then
            Return False
        End If

        Return True
    End Function

    Public Shared Function IsValidEmail(email As String)
        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        Return Regex.IsMatch(email, emailPattern)
    End Function


    Public Shared Function IsValidNumber(input As String) As Boolean
        Dim numberPattern As String = "^\d+(\.\d+)?$"

        Return Regex.IsMatch(input, numberPattern)
    End Function
End Class
