' Import security packages that help encript the password text input
Imports System.ComponentModel
Imports System.Security.Cryptography

Public Class FormRegister

    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons, panels, and labels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' Labels
        lblTitle.Parent = picBackground
        lblFooter.Parent = panelFooter

        ' Footer panel
        panelFooter.Parent = picBackground
        panelFooter.BackColor = Color.FromArgb(100, 0, 0, 0)

        ' Button Login
        btnLogin.Parent = picBackground
        btnLogin.BackColor = Color.FromArgb(150, 0, 0, 0)

    End Sub



    ' Run this sub upon picBackground render
    Private Sub picBackground_Paint(sender As Object, e As PaintEventArgs) Handles picBackground.Paint

        ' Define shadows transparent background-color and its offset to the relative object/element
        Dim shadowColor As Color = Color.FromArgb(50, 0, 0, 0)
        Dim shadowOffset As Integer = 10

        ' Set relative object, and get a graphics-event instance used for drawing 
        Dim relativeObject = panelForm
        Dim g As Graphics = e.Graphics

        ' Draw shadow on picBackground / under panelForm
        Using shadowBrush As New SolidBrush(shadowColor)
            g.FillRectangle(shadowBrush, relativeObject.Location.X + shadowOffset, relativeObject.Location.Y + shadowOffset, relativeObject.Width, relativeObject.Height)
        End Using

    End Sub



    ' Call this sub if button Register is triggered by the mouse button: Mouse button is held down
    Private Sub btnRegister_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRegister.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnRegister.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button Register is triggered by the mouse button: Mouse button is released
    Private Sub btnRegister_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRegister.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnRegister.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button Register is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnRegister.BackgroundImage = My.Resources.gradientGreen


        ' Get username and password value from text inputs (values are provided by the client)
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Define legal and illegal characters/words (make sure that everything is in lower case)
        ' We can expand profanity list in future to support the legality of one's username
        Dim validChars As String = "abcdefghijklmnopqrstuvwxyz"
        Dim profanity = {"smelly", "mop", "boring"}



        ' ------ VALIDATE REGISTRY CREDENTIALS ----------------------------------------------------------------------


        ' Validate username for text only.
        ' The error message is called and this sub script stops from further execution if client
        ' provides character that has not been listed within the local-scope variable: validChars

        ' Iterate through username's characters and temporarly store each iterated instance as: character
        For Each character As Char In username

            ' Check if character is NOT registered in variable: validChars
            ' Before the check takes place, convert variable: character to a lowerCase
            If Not validChars.Contains(character.ToString.ToLower) Then
                ' Display error message/popup of invalid username credentials, and stop this sub from further execution
                MessageBox.Show("ERROR: username must include ASCII text only (A-Z).")
                Exit Sub
            End If

        Next


        ' Validate username's legality by preventing the user from providing non-family-friendly words.
        ' The below if statement ensures that username is not a word listed in profanity array.
        If profanity.Contains(username.ToLower) Then
            ' Display error message/popup of invalid username credentials, and stop this sub from further execution
            MessageBox.Show("ERROR: username must be family friendly.")
            Exit Sub
        End If


        ' Check if user is already registered/exists.
        ' Iterate for each key-value-pair: User object, in all instances of GlobalVariables.Users (key-value-pair object)
        For Each User As KeyValuePair(Of String, String) In GlobalVariables.Users

            ' Check if username matches the User-object's-key: registered username
            If username = User.Key Then
                ' Output an error message/popup, and stop the sub (this function) from further execution
                MessageBox.Show("ERROR: user '" & username & "' already exists.")
                Exit Sub
            End If

        Next


        ' Validate inputs (text boxes) form the registry form.
        ' Upon any validation failure, the sub (function) is stopped from further execution.
        If username.Length < 6 Then
            ' Failed to meet minimal username length requirements, error
            MessageBox.Show("ERROR: username must be at least 6 characters long.")
            Exit Sub

        ElseIf Not password = txtConfirmPassword.Text Then
            ' Failed to match the password, error
            MessageBox.Show("ERROR: password mismatch.")
            Exit Sub

        ElseIf password.Length < 6 Then
            ' Failed to meet minimal password length requirements, error
            MessageBox.Show("ERROR: password must be at least 6 characters long.")
            Exit Sub

        End If


        ' ------ REGISTER USER ---------------------------------------------------------------------------------------


        ' Register and login the user if there is available space (MaxAccountCount: 100 accounts max)
        If GlobalVariables.Users.Count < GlobalVariables.MaxAccountCount Then

            ' Register the user
            GlobalVariables.Users.Add(username, password)
            GlobalVariables.ListUsers.Add(username)

            ' Login the user
            Dim isUserLoggedIn = GlobalVariables.LoginTheUser(username)

            ' Check if user is logged-in
            If isUserLoggedIn Then
                ' Setup user's records at GlobalVariables
                ' And send them to the BMI Form
                GlobalVariables.InitialiseUserRecords()
                SendClientToBMIForm()
            Else
                ' Display error popup on unsuccessful login
                MessageBox.Show("ERROR: failed to login the user.")
                Exit Sub
            End If

        Else
            ' Display error popup on unsuccessful registry
            MessageBox.Show("ERROR: cannot register the user due to a lack of space.")
            Exit Sub
        End If

    End Sub



    ' Send the client to the Login Form if the button Login is pressed.
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Create a form object: FormLogin and store it in local variable: form
        Dim form = New FormLogin()

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