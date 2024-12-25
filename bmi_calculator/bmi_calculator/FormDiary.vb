Public Class FormDiary

    ' This sub will run scripts found within its scope upon Form's first initial load (once form is loaded, run the scripts).
    Private Sub FormDiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set parents of buttons, labels, and panels to support their transparent background effect,
        ' and change some elements transparent BackColor (background color) 

        ' Return button
        btnReturn.Parent = picBackground
        btnReturn.BackColor = Color.FromArgb(75, 255, 255, 255)

        ' Labels
        lblTitle.Parent = picBackground
        lblSubTitle.Parent = picBackground
        lblRecordsTitle.Parent = picBackground
        lblRecordContent.Parent = picBackground

        ' Panel of main options: Read, Edit, Drop...
        panMainOptions.Parent = picBackground

        ' Show main-options: diary-record selection (comboBox) with buttons: Read, Edit and Drop
        ShowMyRecordsDisplay()

    End Sub


    ' This sub (function) hides all key labels, buttons, comboBoxes, text-inputs and panels.
    Private Sub HideKeyElementsFromDisplay()

        ' for: Main options: Read, Edit and Drop
        panMainOptions.Hide() ' (Right side)
        cmbRecords.Hide() ' (Left side)
        btnNewRecord.Hide() ' (Left side - bottom)

        ' Right side - for: Add or Edit record
        lblRecordsTitle.Hide()
        panTextTitle.Hide()
        btnAddRecord.Hide()
        btnSaveRecord.Hide()

        ' Left side - for: Add or Edit record
        txtContent.Hide()
        btnMyRecordsBottom.Hide()

        ' for: Read record
        btnMyRecordsTop.Hide() ' (Top-right conrer)
        lblRecordContent.Hide() ' (Center/left-to-right)

    End Sub


    ' This sub (function) shows main-options: diary-record selection (comboBox) with buttons: Read, Edit and Drop. And more...
    Private Sub ShowMyRecordsDisplay()

        HideKeyElementsFromDisplay()

        ' Set subTitle label to MyRecords. (Above comboBox: Records)
        lblSubTitle.Text = "My Records"

        ' Show main display options
        panMainOptions.Show() ' (Right side) Main options: Read, Edit and Drop and more...
        cmbRecords.Show() ' (Left side)
        btnNewRecord.Show() ' (Left side - bottom, under comboBox: Records)

        ' Get all of logged-in user's diary-records data (Lists): Titles and AdditionDates
        Dim ListTitles As ArrayList = GlobalVariables.GetUserRecords().Item("Titles")
        Dim ListAdditionDates As ArrayList = GlobalVariables.GetUserRecords().Item("Dates")



        ' --- Reset comboBox: Records -------------------------------------

        ' Clear all selection-options from the comboBox: Records
        cmbRecords.Items.Clear()

        ' Add logged-in user's diary-records to the comboBox: Records
        '
        ' NOTE: The following loop iterates backwards, where each iteration decrements index by 1 unit.
        ' This is made so that comboBox options are ordered chronologically.
        For index As Integer = ListTitles.Count - 1 To 0 Step -1

            ' Get next instance of Title and AdditionDate
            Dim Title = ListTitles.Item(index)
            Dim AdditionDate = ListAdditionDates.Item(index)

            ' Concatonate AdditionDate and Title, and add it to the comboBox: Records AS selectable-item-option
            cmbRecords.Items.Add(AdditionDate & "   |      " & Title)

        Next

    End Sub





    ' Call this sub if button MyRecordsTop is triggered by the mouse button: Mouse button is held down
    Private Sub btnMyRecordsTop_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMyRecordsTop.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnMyRecordsTop.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button MyRecordsTop is triggered by the mouse button: Mouse button is released
    Private Sub btnMyRecordsTop_MouseUp(sender As Object, e As MouseEventArgs) Handles btnMyRecordsTop.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnMyRecordsTop.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button MyRecordsTop is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnMyRecordsTop_Click(sender As Object, e As EventArgs) Handles btnMyRecordsTop.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnMyRecordsTop.BackgroundImage = My.Resources.gradientGreen

        ' Show main-options: diary-record selection (comboBox) with buttons: Read, Edit and Drop
        ShowMyRecordsDisplay()
    End Sub





    ' Call this Sub If button AddRecord Is triggered by the mouse button: Mouse button Is held down
    Private Sub btnAddRecord_MouseDown(sender As Object, e As MouseEventArgs) Handles btnAddRecord.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnAddRecord.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button AddRecord is triggered by the mouse button: Mouse button is released
    Private Sub btnAddRecord_MouseUp(sender As Object, e As MouseEventArgs) Handles btnAddRecord.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnAddRecord.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button AddRecord is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnAddRecord.BackgroundImage = My.Resources.gradientGreen

        ' Get Title and Content from text inputs
        Dim Title = txtTitle.Text
        Dim Content = txtContent.Text

        ' Test for empty Title OR Content
        If Title = String.Empty Or Content = String.Empty Then
            ' Display error message/popup of empty text inputs, and stop this sub (function) from further execution
            MessageBox.Show("ERROR: Title and Content must not be empty.")
            Exit Sub
        End If

        ' Add new diary-record for the logged-in user
        GlobalVariables.AddUserRecord(Title, Content)

        ' Reset/Clear the text-inputs: Title and Content
        ' and get back main-options: diary-record selection (comboBox) with buttons: Read, Edit and Drop
        txtTitle.Text = ""
        txtContent.Text = ""
        ShowMyRecordsDisplay()

    End Sub





    ' Call this Sub If button ReadRecord Is triggered by the mouse button: Mouse button Is held down
    Private Sub btnReadRecord_MouseDown(sender As Object, e As MouseEventArgs) Handles btnReadRecord.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnReadRecord.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button ReadRecord is triggered by the mouse button: Mouse button is released
    Private Sub btnReadRecord_MouseUp(sender As Object, e As MouseEventArgs) Handles btnReadRecord.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnReadRecord.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button ReadRecord is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnReadRecord_Click(sender As Object, e As EventArgs) Handles btnReadRecord.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnReadRecord.BackgroundImage = My.Resources.gradientGreen


        Dim SelectedRecord As String = cmbRecords.Text

        ' --- Validate selected diary-record -------------------------------------------------------------

        ' This if-statement checks if user selected a valid diary-record from the comboBox: Records
        ' If selected record is NOT found in the comboBox, then
        ' it outputs an error message/popup to select a valid record, and stop this sub from further execution.
        If Not cmbRecords.Items.Contains(SelectedRecord) Then
            MessageBox.Show("ERROR: record does not exist. Please select a valid record from the list.")
            Exit Sub
        End If


        HideKeyElementsFromDisplay()


        ' --- initialise the target diary-record for editing and later for saving ------------------------

        ' NOTE: RecordIndex is the index corresponding to the record's array slot (of logged-in user).
        ' The records are listed in the comboBox: Records, in chronological order, hence why
        ' RecordIndex has to be inversed to get valid corresponding index. 
        Dim SelectedRecordIndex As Integer = cmbRecords.Items.IndexOf(SelectedRecord)
        Dim RecordIndex As Integer = (cmbRecords.Items.Count - 1) - SelectedRecordIndex

        ' Get diary-record's data
        Dim Record = GlobalVariables.GetUserRecord(RecordIndex)


        ' Set record's data to its corresponding labels: Title and Content
        lblSubTitle.Text = Record.Item("Title")
        lblRecordContent.Text = Record.Item("Content")

        ' Display Content, and also a button: MyRecordsTop (At the top-right corner)
        btnMyRecordsTop.Show()
        lblRecordContent.Show()

    End Sub





    ' Call this sub if button EditRecord is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnEditRecord_Click(sender As Object, e As EventArgs) Handles btnEditRecord.Click

        Dim SelectedRecord As String = cmbRecords.Text

        ' --- Validate selected diary-record -------------------------------------------------------------

        ' This if-statement checks if user selected a valid diary-record from the comboBox: Records
        ' If selected record is NOT found in the comboBox, then
        ' it outputs an error message/popup to select a valid record, and stop this sub from further execution.
        If Not cmbRecords.Items.Contains(SelectedRecord) Then
            MessageBox.Show("ERROR: record does not exist. Please select a valid record from the list.")
            Exit Sub
        End If


        HideKeyElementsFromDisplay()


        ' --- initialise the target diary-record for editing and later for saving ------------------------

        ' NOTE: RecordIndex is the index corresponding to the record's array slot (of logged-in user).
        ' The records are listed in the comboBox: Records, in chronological order, hence why
        ' RecordIndex has to be inversed to get valid corresponding index. 
        Dim SelectedRecordIndex As Integer = cmbRecords.Items.IndexOf(SelectedRecord)
        Dim RecordIndex As Integer = (cmbRecords.Items.Count - 1) - SelectedRecordIndex

        ' Get diary-record's data
        Dim Record = GlobalVariables.GetUserRecord(RecordIndex)

        ' Set record's data to its corresponding text-inputs: Title and Content
        txtTitle.Text = Record.Item("Title") ' (Right side)
        txtContent.Text = Record.Item("Content") ' (Left side)

        ' Store RecordIndex at SaveRecord button's Tag.
        ' It is going to be used at button: SaveRecord, to target the right diary-record.
        btnSaveRecord.Tag = RecordIndex



        ' --- display key-options for saving and editing the diary-record  -------------------------------

        ' (Left side) Display editable area for new records content, with below button: MyRecordsBottom
        lblSubTitle.Text = "Content"
        txtContent.Show()
        btnMyRecordsBottom.Show()

        ' (Right side) Display text input for records-title, with below button: Save (record)
        lblRecordsTitle.Show()
        panTextTitle.Show()
        btnSaveRecord.Show()

    End Sub





    ' Call this Sub If button SaveRecord Is triggered by the mouse button: Mouse button Is held down
    Private Sub btnSaveRecord_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSaveRecord.MouseDown
        ' Set background image of this button to: gradientDarkGreen, found in Resources folder
        btnSaveRecord.BackgroundImage = My.Resources.gradientDarkGreen
    End Sub


    ' Call this sub if button SaveRecord is triggered by the mouse button: Mouse button is released
    Private Sub btnSaveRecord_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSaveRecord.MouseUp
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnSaveRecord.BackgroundImage = My.Resources.gradientGreen
    End Sub


    ' Call this sub if button SaveRecord is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        ' Set background image of this button to: gradientGreen, found in Resources folder
        btnSaveRecord.BackgroundImage = My.Resources.gradientGreen

        ' Get text-input-data from Title and Content
        ' NOTE: RecordIndex is the index corresponding to the record's array slot.
        ' Also, btnSaveRecord.Tag is updated only at EditRecord button.
        Dim RecordIndex = btnSaveRecord.Tag
        Dim Title = txtTitle.Text
        Dim Content = txtContent.Text

        ' Display success message and save/update the edited-diary-record for the logged-in user
        MessageBox.Show("SUCCESS: record has been updated.")
        GlobalVariables.UpdateUserRecord(RecordIndex, Title, Content)
    End Sub





    ' Call this sub if button DropRecord is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnDropRecord_Click(sender As Object, e As EventArgs) Handles btnDropRecord.Click

        Dim SelectedRecord As String = cmbRecords.Text

        ' --- Validate selected diary-record -------------------------------------------------------------

        ' This if-statement checks if user selected a valid diary-record from the comboBox: Records
        ' If selected record is NOT found in the comboBox, then
        ' it outputs an error message/popup to select a valid record, and stop this sub from further execution.
        If Not cmbRecords.Items.Contains(SelectedRecord) Then
            MessageBox.Show("ERROR: record does not exist. Please select a valid record from the list.")
            Exit Sub
        End If

        ' NOTE: RecordIndex is the index corresponding to the record's array slot (of logged-in user).
        ' The records are listed in the comboBox: Records, in chronological order, hence why
        ' RecordIndex has to be inversed to get valid corresponding index. 
        Dim SelectedRecordIndex As Integer = cmbRecords.Items.IndexOf(SelectedRecord)
        Dim RecordIndex As Integer = (cmbRecords.Items.Count - 1) - SelectedRecordIndex

        ' Remove logged-in user's diary-record, and update the records display
        GlobalVariables.RemoveUserRecord(RecordIndex)
        ShowMyRecordsDisplay()

    End Sub





    ' Call this sub if button NewRecord is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click

        HideKeyElementsFromDisplay()

        ' (Left side) Display editable area for new records content, with below button: MyRecordsBottom
        lblSubTitle.Text = "Content"
        txtContent.Show()
        btnMyRecordsBottom.Show()

        ' (Right side) Display text input for new records title, with below button: Add (record)
        lblRecordsTitle.Show()
        panTextTitle.Show()
        btnAddRecord.Show()

    End Sub





    ' Call this sub if button MyRecordsBottom is triggered by the mouse button: Mouse button clicked this button
    Private Sub btnMyRecordsBottom_Click(sender As Object, e As EventArgs) Handles btnMyRecordsBottom.Click
        ' Show main-options: diary-record selection (comboBox) with buttons: Read, Edit and Drop
        ShowMyRecordsDisplay()
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