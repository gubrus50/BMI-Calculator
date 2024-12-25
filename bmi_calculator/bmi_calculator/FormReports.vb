Public Class FormReports

    ' Highest scope variables: ListWeights -> { 12.3, 60, 75.2 ... } where each number corresponds to registered user's weight.
    Dim ListWeights As Object = GlobalVariables.ListWeightsInKilograms

    ' Highest scope variables: avg, highest and lowest weight of registered users (in kilograms) (8 bytes)
    Public averageWeightKg As Double = GetAverageWeight(ListWeights)
    Public highestWeightKg As Double = GetHighestWeight(ListWeights)
    Public lowestWeightKg As Double = GetLowestWeight(ListWeights)


    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons and labels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' Return button
        btnReturn.Parent = picBackground
        btnReturn.BackColor = Color.FromArgb(75, 255, 255, 255)


        ' title label
        lblTitle.Parent = picBackground

        ' average weight labels
        lblAverageWeight.Parent = picBackground
        lblAverageWeightResult.Parent = picBackground
        lblDash1.Parent = picBackground

        ' highest weight labels
        lblHighestWeight.Parent = picBackground
        lblHighestWeightResult.Parent = picBackground
        lblDash2.Parent = picBackground

        ' lowest weight labels
        lblLowestWeight.Parent = picBackground
        lblLowestWeightResult.Parent = picBackground
        lblDash3.Parent = picBackground


        DisplayReportsInMetricMeasure()

    End Sub





    Private Function GetAverageWeight(weightList As Object)
        ' Define and initialise local scope variables:
        '   total TO 0 (8 bytes), and
        '   count TO 0 (4 bytes)
        '
        ' total is -> sum N of all weights in weightList
        ' count is -> count N of weight instances from weightList

        Dim total As Double = 0
        Dim count As Integer = 0

        ' Iterate for every weight instance in weightList
        For Each weight In weightList
            ' Check if weight instance is occupied with some value
            If weight IsNot Nothing Then
                ' If so; Increment total variable by this weight instance,
                ' and also increment a count by 1 unit
                total += weight
                count += 1
            End If
        Next

        ' Return resultant of: total divided by count (average)
        Return total / count
    End Function


    Private Function GetHighestWeight(weightList As Object)
        ' Define and initialise local scope variable: highestWeight TO 0 (8 bytes)
        Dim highestWeight As Double = 0

        ' Iterate for every weight instance in weightList
        For Each weight In weightList
            ' Check if weight instance is occupied with some value
            If weight IsNot Nothing Then
                ' If so; Check if weigh is greater than the value of highest weight
                If weight > highestWeight Then
                    ' If so; set this weight as the new highest weight
                    highestWeight = weight
                End If
            End If
        Next

        ' Return highest weight
        Return highestWeight
    End Function


    Private Function GetLowestWeight(weightList As Object)
        ' Define and initialise local scope variable:
        ' lowestWeight TO the highest weight instance from the weightList (8 bytes)
        Dim lowestWeight As Double = GetHighestWeight(weightList)

        ' Iterate for every weight instance in weightList
        For Each weight In weightList
            ' Check if weight instance is occupied with some value
            If weight IsNot Nothing Then
                ' If so; Check if weight is lower than the value of lowest weight
                If weight < lowestWeight Then
                    ' If so; set this weight as the new lowest weight
                    lowestWeight = weight
                End If
            End If
        Next

        ' Return lowest weight
        Return lowestWeight
    End Function





    Private Sub DisplayReportsInMetricMeasure()
        ' Define metric unit
        Dim Unit As String = " Kg"

        ' Update average, highest and lowest weight labels. (All values are rounded by 2 decimal places)
        lblAverageWeightResult.Text = Math.Round(averageWeightKg, 2) & Unit
        lblHighestWeightResult.Text = Math.Round(highestWeightKg, 2) & Unit
        lblLowestWeightResult.Text = Math.Round(lowestWeightKg, 2) & Unit
    End Sub

    Private Sub DisplayReportsInImperialMeasure()
        ' Define imperial unit
        Dim Unit As String = " Lb"

        ' Update average, highest and lowest weight labels. (All values are rounded by 2 decimal places)
        ' Note [ value * 2.2046 ] -> Kilograms (Kg) To Pounds (Lb) conversion
        lblAverageWeightResult.Text = Math.Round(averageWeightKg * 2.2046, 2) & Unit
        lblHighestWeightResult.Text = Math.Round(highestWeightKg * 2.2046, 2) & Unit
        lblLowestWeightResult.Text = Math.Round(highestWeightKg * 2.2046, 2) & Unit
    End Sub





    ' Call this sub if button Imperial is triggered by the mouse button: Mouse button is held down
    Private Sub btnImperial_MouseDown(sender As Object, e As MouseEventArgs) Handles btnImperial.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnImperial.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button Imperial is triggered by the mouse button: Mouse button is released
    Private Sub btnImperial_MouseUp(sender As Object, e As MouseEventArgs) Handles btnImperial.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnImperial.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button Imperial is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnImperial_Click(sender As Object, e As EventArgs) Handles btnImperial.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnImperial.BackgroundImage = My.Resources.gradientGreen

        ' Replace imperial with metric button
        btnImperial.Hide()
        btnMetric.Show()

        DisplayReportsInImperialMeasure()

    End Sub



    ' Call this sub if button Metric is triggered by the mouse button: Mouse button is held down
    Private Sub btnMetric_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMetric.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnMetric.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button Metric is triggered by the mouse button: Mouse button is released
    Private Sub btnMetric_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMetric.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnMetric.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button Metric is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnMetric_Click(sender As Object, e As EventArgs) Handles btnMetric.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnMetric.BackgroundImage = My.Resources.gradientGreen

        ' Replace metric with imperial button
        btnMetric.Hide()
        btnImperial.Show()

        DisplayReportsInMetricMeasure()
    End Sub





    ' --- Hover effect for Return button ------------------------------------------------------------

    ' The sub is called when mouse cursor gets into Return button's area
    Private Sub btnReturn_MouseEnter(sender As Object, e As EventArgs) Handles btnReturn.MouseEnter
        ' Set Return buttons background to transparent black color
        btnReturn.BackColor = Color.FromArgb(50, 0, 0, 0)
    End Sub

    ' The sub is called when mouse exits from Return button's area
    Private Sub btnReturn_MouseLeave(sender As Object, e As EventArgs) Handles btnReturn.MouseLeave
        ' Set Return buttons background to transparent white color
        btnReturn.BackColor = Color.FromArgb(75, 255, 255, 255)
    End Sub



    ' Send the client to the Home Form if the button Return is pressed.
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        ' Create a form object: FormHome and store it in local variable: form
        Dim form = New FormHome()

        ' Display the form and bring it to front of other forms
        form.Show()
        form.BringToFront()
        ' Set newly created form's position to that of the previously-used-by-the-client form's position
        form.Location = New Point(Me.Location)

        ' Terminate the previously-used-by-the-client form
        Me.Close()

    End Sub

End Class