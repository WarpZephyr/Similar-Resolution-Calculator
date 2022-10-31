Public Class SimilarResCalc
    'Return true if value has decimal, use divisible for Divisible By filter
    Private Function ResFilter(ByVal value As Double, ByVal divisible As Integer)
        If divisible = 0 Then
            divisible = 1
        End If
        If value Mod divisible = 0 Then
            Return False
        End If
        Return True
    End Function

    'When the resolution calculate button is pressed
    Private Sub DataCalc_Click(sender As Object, e As EventArgs) Handles DataCalc.Click
        On Error GoTo handler
        Dim resWidth As Integer = Val(DataWidth.Text)
        Dim resHeight As Integer = Val(DataHeight.Text)
        Dim calcIterations As Integer = Val(DataIterations.Text)
        Dim divisbleFilter As Integer = Val(DataDivisible.Text)

        'Check to see if the resolution textboxes are empty
        If DataWidth.Text = "" Or DataHeight.Text = "" Then
            DataFeedback.Text = "Please enter values"
            Exit Sub
        End If

        'If Iterations is empty just use the resolution width multipled by 2
        If DataIterations.Text = "" Then
            calcIterations = resWidth * 2
            DataIterations.Text = calcIterations
        End If

        'Show visually that the Divisible By box changes if empty or has a 0
        If divisbleFilter = 0 Then
            DataDivisible.Text = 1
        End If

        'Check to see if input is not numeric or if resHeight is using 0
        If IsNumeric(DataWidth.Text) = False Or IsNumeric(DataHeight.Text) = False Or resHeight = 0 Then
            DataFeedback.Text = "Please only use valid numbers"
            Exit Sub
        End If

        'Placed here to prevent divide by 0
        Dim aspectRatio As Double = resWidth / resHeight

        'Find the resolutions for this aspect ratio
        Dim resCount As Integer
        For index = 1 To calcIterations
            Dim newResHeight As Double = index
            Dim newResWidth As Double = newResHeight * aspectRatio
            If ResFilter(newResWidth, divisbleFilter) = False And ResFilter(newResHeight, divisbleFilter) = False Then
                resCount += 1
                DataOutputBox.Items.Add($"{newResWidth} x {newResHeight}")
            End If
        Next
        DataFeedback.Text = $"{resCount} resolutions found"
        Exit Sub
handler:
        DataFeedback.Text = "An error occurred, please try again"
    End Sub

    'Clear the output box, someone might want it to not clear every time they do a new calculation
    Private Sub DataClear_Click(sender As Object, e As EventArgs) Handles DataClear.Click
        DataOutputBox.Items.Clear()
        DataFeedback.Text = "Output box cleared"
    End Sub
End Class