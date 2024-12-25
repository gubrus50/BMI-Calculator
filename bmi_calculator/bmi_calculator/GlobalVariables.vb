Imports System.Reflection

Public Class GlobalVariables

    ' Users Dictionary (Key: Username, Value: Password ) is used to register and validate registered users' passwords at Login Form
    Public Shared Users As New Dictionary(Of String, String)

    ' This is a max allowed number of accounts that can be registered into this program
    Public Shared MaxAccountCount As Integer = 100

    ' This text variable is used for loging-in the user, and identifying LoggedInUserIndex
    Public Shared LoggedInUser As String

    ' This index is used to target the logged-in user's data from the below ListData:
    Public Shared LoggedInUserIndex As Integer



    ' --- ListData ------------------------------------------------------------------------

    ' Create flexible list ListUsers, which is used to register and login the user
    Public Shared ListUsers As New ArrayList

    ' Create fixed size lists (arrays: 100 units, starting from 0)
    Public Shared ListWeightsInKilograms(MaxAccountCount - 1)
    Public Shared ListHeightsInMeters(MaxAccountCount - 1)
    Public Shared ListBMIs(MaxAccountCount - 1)
    Public Shared ListRecords(MaxAccountCount - 1) ' (Diary records at Diary Form)

    ' NOTE: Weights, Heights and BMIs arrays are updated at BMI Form, and
    '       Records are updated at Diary Form.
    '
    '       ListRecords{
    '          UserRecord{
    '             Title{}, Content{}, AdditionDate{}
    '          }
    '          ...
    '       }
    '
    ' -------------------------------------------------------------------------------------



    ' This function is called only at Register and Login Form.
    '
    ' Its parameter: username, is used to set the global variable: LoggedInUser,
    ' which is used to find the index of registered user with the same username in: ListUsers
    '
    ' This function returns boolean True if username is found in ListUsers list.
    ' Otherwise, False is returned with an error message/popup.
    '
    ' NOTE: password is not required to login the user with this function.
    Public Shared Function LoginTheUser(username As String)

        ' Update highest scope variable: LoggedInUser TO parameter: username
        LoggedInUser = username

        ' Linear iteration:
        '
        ' Declare and set initial value of variable index TO 0 (4 bytes)
        ' And start iterating in range of ListUsers list's item count / length.
        ' Each iteration cycle increments index by 1 unit.
        '
        For index As Integer = 0 To ListUsers.Count
            ' Check if LoggedInUser, is the same as the, next instance/item of ListUsers list. 
            If LoggedInUser = ListUsers.Item(index) Then
                ' If so; Update highest scope variable: LoggedInUserIndex, and return boolean: True,
                ' stopping the function from further execution.
                LoggedInUserIndex = index
                Return True
            End If
        Next

        ' If parameter: username, was not found in list: ListUsers, then display this below error message/popup
        ' and return boolean: False, stopping the function from further execution.
        MessageBox.Show("ERROR: user '" & username & "' is not registered.")
        Return False

    End Function





    ' --- Getters and Setters for logged-in user ------------------------------------------

    Public Shared Sub SetUserWeight(Weight As Double)
        ' Target below array's slot to that of the logged-in user, and update its value TO parameter: Weight (float: 8 bytes)
        ListWeightsInKilograms(LoggedInUserIndex) = Weight
    End Sub

    Public Shared Function GetUserWeight()
        ' Return logged-in user's Weight (Kilograms) value
        Return ListWeightsInKilograms(LoggedInUserIndex)
    End Function

    Public Shared Sub SetUserHeight(Height As Double)
        ' Target below array's slot to that of the logged-in user, and update its value TO parameter: Height (float: 8 bytes)
        ListHeightsInMeters(LoggedInUserIndex) = Height
    End Sub

    Public Shared Function GetUserHeight()
        ' Return logged-in user's Height (Meters) value
        Return ListHeightsInMeters(LoggedInUserIndex)
    End Function

    Public Shared Sub SetUserBMI(BMI As Double)
        ' Target below array's slot to that of the logged-in user, and update its value TO parameter: BMI (flaot: 8 bytes)
        ListBMIs(LoggedInUserIndex) = BMI
    End Sub

    Public Shared Function GetUserBMI()
        ' Return logged-in user's BMI value
        Return ListBMIs(LoggedInUserIndex)
    End Function





    ' --- Manage logged-in user's (Diary) Records -----------------------------------------


    ' This function creates a UserRecord list with nested (children) lists: Titles, Contents, and AdditionalDate
    ' Example: UserRecord: { T{}, C{}, AD{} }
    '
    ' Once UserRecord is created, it is then added to the highest scope variable: ListRecords, at slot of the currently logged-in user.
    '
    ' NOTE: This sub (function) is currently used at Register Form only.
    '       All newly registered users must have initialised user record list to prevent errors at the Diary Form.
    Public Shared Sub InitialiseUserRecords()
        If ListRecords(LoggedInUserIndex) Is Nothing Then
            Dim UserRecords, Titles, Contents, AdditionDate As New ArrayList

            UserRecords.Add(Titles)
            UserRecords.Add(Contents)
            UserRecords.Add(AdditionDate)

            ListRecords(LoggedInUserIndex) = UserRecords
        End If
    End Sub


    ' This sub (function) adds new diary-record: title, content, and date of addition
    Public Shared Sub AddUserRecord(Title As String, Content As String)
        ' Get logged-in user's records data (lists): Titles, Contents and AdditionDate
        Dim ListTitles As ArrayList = ListRecords(LoggedInUserIndex)(0)
        Dim ListContents As ArrayList = ListRecords(LoggedInUserIndex)(1)
        Dim ListAdditionDate As ArrayList = ListRecords(LoggedInUserIndex)(2)

        ' Populate lists
        ListTitles.Add(Title)
        ListContents.Add(Content)
        ListAdditionDate.Add(DateTime.Now) ' DateTime.Now - Current date and time
    End Sub


    ' This function is a Getter.
    ' It returns a dictionary object, of logged-in user's, diary-record data (based on target parameter: Index)
    Public Shared Function GetUserRecord(Index As Integer)
        ' NOTE: Parameter Index is used to target specific logged-in user's record.

        ' Create temp key value pairs dictionary: UserRecord
        Dim UserRecord As New Dictionary(Of String, String)

        ' Get logged-in user's records data (lists): Titles, Contents and AdditionDate
        Dim ListTitles As ArrayList = ListRecords(LoggedInUserIndex)(0)
        Dim ListContents As ArrayList = ListRecords(LoggedInUserIndex)(1)
        Dim ListAdditionDate As ArrayList = ListRecords(LoggedInUserIndex)(2)

        ' Populate the UserRecord dictionary with keys: Titles, Content, and Date
        UserRecord.Add("Title", ListTitles(Index))
        UserRecord.Add("Content", ListContents(Index))
        UserRecord.Add("Date", ListAdditionDate(Index))

        ' Returns Dictionary -> UserRecord{ "Title": Title, "Content": Content, "Date": AdditionDate }
        Return UserRecord
    End Function


    ' This sub (funciton) changes the data of existing diary-record of logged-in user, based on target parameter: Index
    ' NOTE: It can only update Title AND Content, however, both parameters are required for change to take place
    Public Shared Sub UpdateUserRecord(Index As Integer, Title As String, Content As String)
        ' Get logged-in user's records data (lists): Titles and Contents
        Dim ListTitles As ArrayList = ListRecords(LoggedInUserIndex)(0)
        Dim ListContents As ArrayList = ListRecords(LoggedInUserIndex)(1)

        ' Update logged-in user's, targeted by index, diary-records data: Title and Content TO the corresponding parameters
        ListTitles(Index) = Title
        ListContents(Index) = Content
    End Sub


    ' This sub (function) removes diary-record data of logged-in user, based on target parameter: Index
    Public Shared Sub RemoveUserRecord(Index As Integer)
        ' Get logged-in user's records data (lists): Titles, Contents and AdditionDate
        Dim ListTitles As ArrayList = ListRecords(LoggedInUserIndex)(0)
        Dim ListContents As ArrayList = ListRecords(LoggedInUserIndex)(1)
        Dim ListAdditionDate As ArrayList = ListRecords(LoggedInUserIndex)(2)

        ' Remove target Title, Content and AdditionDate (based on parameter: Index)
        ListTitles.RemoveAt(Index)
        ListContents.RemoveAt(Index)
        ListAdditionDate.RemoveAt(Index)
    End Sub


    ' This function is a Getter.
    ' It returns a dictionary object, of all logged-in user's, diary-records data.
    '
    ' NOTE: This function is used at Diary Form to populate the records combobox at sub-function: ShowMyRecordsDisplay()
    Public Shared Function GetUserRecords()
        ' Create temp key value pairs dictionary: UserRecords
        Dim UserRecords As New Dictionary(Of String, ArrayList)

        ' Get logged-in user's records data (lists): Titles, Contents and AdditionDate
        Dim ListTitles As ArrayList = ListRecords(LoggedInUserIndex)(0)
        Dim ListContents As ArrayList = ListRecords(LoggedInUserIndex)(1)
        Dim ListAdditionDate As ArrayList = ListRecords(LoggedInUserIndex)(2)

        ' Populate the UserRecords dictionary with keys: Titles, Content, and Date
        UserRecords.Add("Titles", ListTitles)
        UserRecords.Add("Contents", ListContents)
        UserRecords.Add("Dates", ListAdditionDate)

        ' Returns Dictionary -> UserRecords{ "Titles": Titles{}, "Contents": Contents{}, "Dates": AdditionDate{} }
        Return UserRecords
    End Function


End Class
