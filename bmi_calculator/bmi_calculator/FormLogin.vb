Public Class FormLogin

    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons, panels, and labels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' Labels
        lblTitle.Parent = picBackground
        lblFooter.Parent = panelFooter

        ' Footer panel
        panelFooter.Parent = picBackground
        panelFooter.BackColor = Color.FromArgb(100, 0, 0, 0)

        ' Button Register
        btnRegister.Parent = picBackground
        btnRegister.BackColor = Color.FromArgb(150, 0, 0, 0)

    End Sub



    ' Run this sub upon picBackground render
    Private Sub picBackground_Paint(sender As Object, e As PaintEventArgs) Handles picBackground.Paint

        ' Define shadows transparent background-color and its offset to the relative object/element
        Dim shadowColor As Color = Color.FromArgb(50, 0, 0, 0)
        Dim shadowOffset As Integer = 10

        ' Set relative object, and get a graphics-event instance used for drawing
        Dim relativeObject = panelForm
        Dim g As Graphics = e.Graphics

        ' Draw shadow on picBackground, under panelForm
        Using shadowBrush As New SolidBrush(shadowColor)
            g.FillRectangle(shadowBrush, relativeObject.Location.X + shadowOffset, relativeObject.Location.Y + shadowOffset, relativeObject.Width, relativeObject.Height)
        End Using

    End Sub



    ' Call this sub if button Login is triggered by the mouse button: Mouse button is held down
    Private Sub btnLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnLogin.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button Login is triggered by the mouse button: Mouse button is released
    Private Sub btnLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnLogin.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button Login is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnLogin.BackgroundImage = My.Resources.gradientGreen

        ' Get username and password value from text inputs (values are provided by the client)
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Check if user is already registered/exists
        ' Iterate for each key-value-pair: User object, in all instances of GlobalVariables.Users (key-value-pair object)
        For Each User As KeyValuePair(Of String, String) In GlobalVariables.Users

            ' Check if username matches the User-object's-key: registered username
            ' And then test for password match of this User-object's: User.value = password
            If username = User.Key Then
                If password = User.Value Then

                    ' Login the user
                    Dim isUserLoggedIn = GlobalVariables.LoginTheUser(username)

                    ' Check if user is logged-in
                    If isUserLoggedIn Then
                        ' send logged-in user to the BMI Form
                        SendClientToBMIForm()
                    Else
                        ' Display error popup on unsuccessful login, and stop this sub (function) from further execution
                        MessageBox.Show("ERROR: failed to login the user.")
                        Exit Sub
                    End If

                Else
                    ' Output an error message/popup of password failure
                    MessageBox.Show("ERROR: invalid password")
                End If

                ' Stop this sub (function) from further execution
                Exit Sub
            End If
        Next

        ' Output an error message/popup of unsuccessful login
        MessageBox.Show("ERROR: user '" & username & "' does not exist.")

    End Sub



    ' Send the client to the Register Form if the button Register is pressed.
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' Create a form object: FormRegister and store it in local variable: form
        Dim form = New FormRegister()

        ' Display the form and bring it to front of other forms
        form.Show()
        form.BringToFront()
        ' Set newly created form's position to that of the previously-used-by-the-client form's position
        form.Location = New Point(Me.Location)

        ' Terminate the previously-used-by-the-client form
        Me.Close()

    End Sub


    ' Define local-scope-Sub (function) that redirects clients to the BMI Form
    Private Sub SendClientToBMIForm()

        ' Create a form object: FormBMI and store it in local variable: form
        Dim form = New FormBMI()

        ' Display the form and bring it to front of other forms
        form.Show()
        form.BringToFront()
        ' Set newly created form's position to that of the previously-used-by-the-client form's position
        form.Location = New Point(Me.Location)

        ' Terminate the previously-used-by-the-client form
        Me.Close()

    End Sub

End Class
