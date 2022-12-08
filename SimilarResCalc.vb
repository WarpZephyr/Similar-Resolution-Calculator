Public Class SimilarResCalc
    'Function to check if dividing will give us a decimal
    Private Function ResFilter(value As Double, divisible As Integer)
        If value Mod divisible = 0 Then
            Return False
        End If
        Return True
    End Function

    'When the Calculate button is pressed
    Private Sub DataCalc_Click(sender As Object, e As EventArgs) Handles DataCalc.Click
        'Check if the Width and Height textboxes are empty
        If DataWidth.Text = "" Or DataHeight.Text = "" Then
            DataFeedback.Text = "Please enter values for Width and/or Height."
            Exit Sub
        End If

        'If iterations is empty use Height as it's number
        If DataIterations.Text = "" And IsNumeric(DataWidth.Text) = True Then
            DataIterations.Text = DataHeight.Text
            DataFeedback.Text = "Iterations was empty, using Height as value"
        End If

        'If Divisble By is empty, use 1 as it's number
        If DataDivisible.Text = "" Then
            DataDivisible.Text = "1"
            DataFeedback.Text = "Divisible By was empty, using 1 as value"
        End If

        'Check if input for Height textbox is 0
        If DataHeight.Text = "0" Then
            DataFeedback.Text = "Numbers cannot be divided by 0, please choose a different number for Height."
            Exit Sub
        End If

        'Check if input for Divisible By textbox is 0
        If DataDivisible.Text = "0" Then
            DataFeedback.Text = "Numbers cannot be divided by 0, please choose a different number for Divisible By."
            Exit Sub
        End If

        'Check if input is not numeric for textboxes
        If IsNumeric(DataWidth.Text) = False Or IsNumeric(DataHeight.Text) = False Or IsNumeric(DataIterations.Text) = False Or IsNumeric(DataDivisible.Text) = False Then
            DataFeedback.Text = "Please only use valid numbers in textboxes."
            Exit Sub
        End If

        'Assign textbox values to variables
        Dim resWidth As Integer = DataWidth.Text
        Dim resHeight As Integer = DataHeight.Text
        Dim calcIterations As Integer = DataIterations.Text
        Dim divisbleFilter As Integer = DataDivisible.Text
        Dim aspectRatio As Double = resWidth / resHeight

        'Error checking to prevent overflow
        Try
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
            If calcIterations < resWidth Then
                DataFeedback.Text += ", try making iterations bigger, such as the value Width is set to."
            End If
        Catch ex As Exception
            DataFeedback.Text = "An error occurred, please try again."
        End Try
    End Sub

    'Clear the output box, someone might want it to not clear every time they do a new calculation
    Private Sub DataClear_Click(sender As Object, e As EventArgs) Handles DataClear.Click
        DataOutputBox.Items.Clear()
        DataFeedback.Text = "Output box cleared"
    End Sub
End Class