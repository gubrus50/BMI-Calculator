Public Class FormBMI

    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormBMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons, panels, groups, and labels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' Title label is at the top center of the screen
        lblTitle.Parent = picBackground

        ' Measurement radio buttons on a left side of the screen
        lblMeasurement.Parent = picBackground
        grpMeasurement.Parent = picBackground

        ' Weight and Height inputs on a right side of the screen
        panNumerics.Parent = picBackground
        lblWeight.Parent = panNumerics
        lblHeight.Parent = panNumerics

        ' Resultant BMI label and Continue button
        panResult.BackColor = Color.FromArgb(125, 0, 0, 0)
        panResult.Parent = picBackground
        lblResult.Parent = panResult
        btnContinue.Parent = picBackground

    End Sub



    ' This sub (function) aligns a label in the middle of the panel
    Private Sub CenterHorizontallyLabelInPanel(label As Label, panel As Panel)

        ' Get label's and panel's width
        Dim lblWidth = label.Size.Width
        Dim panWidth = panel.Size.Width

        ' Define center position of label relative to the panel's width
        Dim newXPos = (panWidth - lblWidth) / 2

        ' Center the label / update label's horizontal position 
        label.Location = New Point(newXPos, label.Location.Y)

    End Sub



    ' Call this sub if client clicks on metric/imperial radio. (clicked radio takes priority over its siblings at parent: grpMeasurement)
    Private Sub radMetric_CheckedChanged(sender As Object, e As EventArgs) Handles radMetric.CheckedChanged
        ' Update weight and height labels' units
        lblWeight.Text = "Weight (Kg)"
        lblHeight.Text = "Height (meters)"

        ' Adjust weight and height numerics incrementation to their respective measure type (metric)
        numWeight.Increment = 5
        numHeight.Increment = 0.1

        ' Convert Weight and Height numeric inputs to metric measure if radio metric is selected by the client
        If radMetric.Checked = True Then
            numWeight.Value /= 2.2046 ' Pounds to Kilograms
            numHeight.Value *= 0.0254 ' Inches to Meters
        End If

        ' Center weight and height labels horizontally
        CenterHorizontallyLabelInPanel(lblWeight, panNumerics)
        CenterHorizontallyLabelInPanel(lblHeight, panNumerics)
    End Sub



    ' Call this sub if client clicks on metric/imperial radio. (clicked radio takes priority over its siblings at parent: grpMeasurement)
    Private Sub radImperial_CheckedChanged(sender As Object, e As EventArgs) Handles radImperial.CheckedChanged
        ' Update weight and height labels' units
        lblWeight.Text = "Weight (Lb)"
        lblHeight.Text = "Height (inches)"

        ' Adjust weight and height numerics incrementation to their respective measure type (imperial)
        numWeight.Increment = 10
        numHeight.Increment = 5

        ' Convert Weight and Height numeric inputs to imperial measure if radio metric is selected by the client
        If radImperial.Checked = True Then
            numWeight.Value *= 2.2046 ' Kilograms to Pounds
            numHeight.Value /= 0.0254 ' Meters to Inches
        End If

        ' Center weight and height labels horizontally
        CenterHorizontallyLabelInPanel(lblWeight, panNumerics)
        CenterHorizontallyLabelInPanel(lblHeight, panNumerics)
    End Sub





    ' Call this sub if button Calculate is triggered by the mouse button: Mouse button is held down
    Private Sub btnCalculate_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCalculate.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnCalculate.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button Calculate is triggered by the mouse button: Mouse button is released
    Private Sub btnCalculate_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCalculate.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnCalculate.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button Calculate is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnCalculate.BackgroundImage = My.Resources.gradientGreen

        ' Initialize BMI to 0, and get values of weight and height inputs (8 Bytes)
        Dim BMI As Double = 0
        Dim Weight As Double = numWeight.Value
        Dim Height As Double = numHeight.Value


        ' --- Validation + Hide elements ----------------------------------------------------

        ' Validate weight and height variables range: ( value must be greater than 0 )
        If Weight <= 0 Or Height <= 0 Then
            ' Output an error message and stop this sub (function) from further execution
            ' if weight or height is less or equal to 0
            MessageBox.Show("ERROR: weight and height inputs must be greater than 0.")
            Exit Sub
        End If

        ' Hide measurement radio buttons form/panel
        lblMeasurement.Hide()
        grpMeasurement.Hide()

        ' Hide weight and height inputs form/panel
        panNumerics.Hide()
        btnCalculate.Hide()



        ' --- Generate BMI ------------------------------------------------------------------

        ' Produce resultant BMI based on selected radio options: metric / imperial
        If radMetric.Checked Then

            ' BMI = divide weight by squared height
            BMI = Weight / (Height ^ 2)

        ElseIf radImperial.Checked Then

            ' BMI = divide weight by squared height, and multiply everything by 703 units
            BMI = (Weight / (Height ^ 2)) * 703

            ' Convert Weight and Height to metric measure
            Weight /= 2.2046 ' Pounds to Kilograms
            Height *= 0.0254 ' Inches to Meters

        End If



        ' --- Show BMI result ------------------------------------------------

        ' Update result label to, rounded by 2 decimal places, BMI
        lblResult.Text = "BMI = " & Math.Round(BMI, 2)

        ' Center result label horizontally
        CenterHorizontallyLabelInPanel(lblResult, panResult)

        ' Display result panel and continue button 
        panResult.Show()
        btnContinue.Show()



        ' --------------------------------------------------------------------
        ' Update logged-in user's data - Weight, Height and BMI

        GlobalVariables.SetUserWeight(Weight)
        GlobalVariables.SetUserHeight(Height)
        GlobalVariables.SetUserBMI(BMI)

    End Sub





    ' Call this sub if button Continue is triggered by the mouse button: Mouse button is held down
    Private Sub btnContinue_MouseDown(sender As Object, e As MouseEventArgs) Handles btnContinue.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnContinue.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button Continue is triggered by the mouse button: Mouse button is released
    Private Sub btnContinue_MouseUp(sender As Object, e As MouseEventArgs) Handles btnContinue.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnContinue.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button Continue is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnContinue.BackgroundImage = My.Resources.gradientGreen

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