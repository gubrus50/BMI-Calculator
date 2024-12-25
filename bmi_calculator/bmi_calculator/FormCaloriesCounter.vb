Public Class FormCaloriesCounter

    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormCaloriesCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons, and labels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' return button
        btnReturn.Parent = picBackground
        btnReturn.BackColor = Color.FromArgb(75, 255, 255, 255)

        ' title label
        lblTitle.Parent = picBackground

        ' labels are above food and count inputs. (top)
        lblFood.Parent = picBackground
        lblCount.Parent = picBackground

        ' labels are at the (bottom)
        lblTotalCalories.Parent = picBackground
        lblResult.Parent = picBackground

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

        ' Define and initialise the local scope variables:
        '
        ' Food -> selected food option / text input from client. Required switch-case
        ' Count -> 64bit integer (8 bytes). Required to calculate total calories
        ' Calories -> TO 0, a float of max range: (4 bytes). Required to calculate total calories

        Dim Food As String = cmbFood.Text
        Dim Count As Long = numCount.Value
        Dim Calories As Single = 0

        ' Validate count input -----------------------------------------------------------------------
        ' If count is greater than numeric-count's maximum range limit then,
        ' display error popup/message and stop this sub-script from further execution.
        If Count > (numCount.Maximum - 1) Then
            MessageBox.Show("ERROR: Exeeded count limit of " & (numCount.Maximum - 1) & " units!")
            Exit Sub
        End If

        ' Get calories of valid food option ----------------------------------------------------------
        ' Note (newly added food option in comboBox: Food, must also be registered as a case)
        Select Case Food

            ' if selected food option is an Apple, then set adequate calories and exit the switch case
            Case "Apple"
                Calories = 97.75
                Exit Select

            ' if selected food option is an Banana, then set adequate calories and exit the switch case
            Case "Banana"
                Calories = 100
                Exit Select

            ' if selected food option is an Egg, then set adequate calories and exit the switch case
            Case "Egg"
                Calories = 76.5
                Exit Select

            ' if selected food option is an BurgerKing's Hamburger, then set adequate calories and exit the switch case
            Case "BurgerKing's Hamburger"
                Calories = 253
                Exit Select

            ' if selected food option is an BurgerKing's Whopper, then set adequate calories and exit the switch case
            Case "BurgerKing's Whopper"
                Calories = 698.5
                Exit Select

            Case Else
                ' If food option does not match any of the cases; display error message/popup of invalid food option,
                ' and prevent this sub-script from further execution.
                MessageBox.Show("ERROR: '" & Food & "' is not a valid food option!")
                Exit Sub

        End Select


        ' Calculate total calories = Calories multiply by Count. (round the resultant by 2 decimal places)
        Dim TotalCalories As Double = Math.Round(Calories * Count, 2) ' flaot (4 bytes)
        Dim PluralSuffix As String = "" ' PluralSuffic is used in Result label to emphasise plurality of food item(s) based on Count

        ' If Count is greater than 1 then, include suffix (s) for the food item
        If Count > 1 Then
            PluralSuffix = "s"
        End If

        ' Format the calories equation with a corresponding answer/resultant -> TotalCalories, and display it in the label: Result
        lblResult.Text = Count & " x " & Food & PluralSuffix & " (" & Calories & " calories each) = " & TotalCalories & " calories"
        lblResult.Show()

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