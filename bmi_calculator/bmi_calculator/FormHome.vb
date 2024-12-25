Public Class FormHome

    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons, panels, and labels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' Labels
        lblUsername.Parent = picBackground
        lblFooter.Parent = panelFooter

        ' Footer panel
        panelFooter.Parent = picBackground
        panelFooter.BackColor = Color.FromArgb(100, 0, 0, 0)

        ' Button Logout
        btnLogout.Parent = picBackground
        btnLogout.BackColor = Color.FromArgb(150, 0, 0, 0)


        ' --- Update text and position of username label --------------------------

        ' Set label: username TO logged-in username (Users' data is stored at GlobalVariables.vb)
        lblUsername.Text = GlobalVariables.LoggedInUser

        ' Get username label's and app's (this window) width
        Dim lblWidth = lblUsername.Size.Width
        Dim appWidth = Me.Size.Width

        ' Define center position of username label relative to the app's width
        Dim newXPos = (appWidth - lblWidth) / 2

        ' Center the label / update label's horizontal position
        lblUsername.Location = New Point(newXPos, lblUsername.Location.Y)

    End Sub



    ' Run this sub upon picBackground render
    Private Sub picBackground_Paint(sender As Object, e As PaintEventArgs) Handles picBackground.Paint

        ' Define shadows transparent background-color and its offset to the relative object/element
        Dim shadowColor As Color = Color.FromArgb(50, 0, 0, 0)
        Dim shadowOffset As Integer = 10

        ' Set relative object, and get a graphics-event instance used for drawing
        Dim relativeObject = picProfile
        Dim g As Graphics = e.Graphics

        ' Draw shadow on picBackground, under picProfile
        Using shadowBrush As New SolidBrush(shadowColor)
            g.FillRectangle(shadowBrush, relativeObject.Location.X + shadowOffset, relativeObject.Location.Y + shadowOffset, relativeObject.Width, relativeObject.Height)
        End Using

    End Sub



    ' This sub redirects the client to specified form. (The new form replaces the currently used form)
    Private Sub sendUserToForm(form As Form)

        ' Display the form and bring it to front of other forms
        form.Show()
        form.BringToFront()
        ' Set newly created form's position to that of the previously-used-by-the-client form's position
        form.Location = New Point(Me.Location)

        ' Terminate the previously-used-by-the-client form
        Me.Close()

    End Sub



    ' Call this sub if button Calories is clicked by the client
    Private Sub btnCalories_Click(sender As Object, e As EventArgs) Handles btnCalories.Click
        ' Redirect the user to the calories counter form
        sendUserToForm(New FormCaloriesCounter())
    End Sub


    ' Call this sub if button Diary is clicked by the client
    Private Sub btnDiary_Click(sender As Object, e As EventArgs) Handles btnDiary.Click
        ' Redirect the user to the diary form
        sendUserToForm(New FormDiary())
    End Sub


    ' Call this sub if button Reports is clicked by the client
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ' Redirect the user to the reports form
        sendUserToForm(New FormReports())
    End Sub


    ' Call this sub if button Logout is clicked by the client
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Logout the user, and redirect the client to the login form
        GlobalVariables.LoggedInUser = ""
        sendUserToForm(New FormLogin())
    End Sub

End Class