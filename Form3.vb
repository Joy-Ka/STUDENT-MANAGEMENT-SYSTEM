Imports MySql.Data.MySqlClient

Public Class Form3

    Dim connectionString As String = "Server=localhost ;Port=3307; user id=root; password=Jace102020.; Database=school_management_system"

    Dim connection As New MySqlConnection(connectionString)


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialization of the database 
        connection = New MySqlConnection(connectionString)

    End Sub

    'Use the Add User function so as to add the data in the database
    Private Sub AddUser(Registration_Number As String, Surname As String, Course As String, Unit_Name As String, CAT_Marks As Double, Exam_Marks As Double, Total_Marks As Double, Grade As String)

        'Using the 'TRY' statement. The 'Try and Catch Exeptions' are used to identify any exceptions in the code.The try statement tries to run the block of code while the catch exception tends to show the exception if any errors has been found by opening the messagbox in this code.
        Try

            'Opening the Database Connection
            connection.Open()

            'Starting the SQL Command
            Dim Query As String = "INSERT INTO academic_input(Registration_Number,Surname,Course,Unit_Name,CAT_Marks,Exam_Marks,Total_Marks,Grade) VALUES(@Registration_Number,@Surname,@Course,@Unit_Name,@CAT_Marks,@Exam_Marks,@Total_Marks,@Grade)"

            'Cretaing a command that holds the SQL Query.The command represents a query or a  command that is to be run in the data source.
            Dim cmd As New MySqlCommand(Query, connection)

            'Add the Parameters
            cmd.Parameters.AddWithValue("Registration_Number", Registration_Number)
            cmd.Parameters.AddWithValue("Surname", Surname)
            cmd.Parameters.AddWithValue("Course", Course)
            cmd.Parameters.AddWithValue("Unit_Name", Unit_Name)
            cmd.Parameters.AddWithValue("CAT_Marks", CAT_Marks)
            cmd.Parameters.AddWithValue("Exam_Marks", Exam_Marks)
            cmd.Parameters.AddWithValue("Total_Marks", Total_Marks)
            cmd.Parameters.AddWithValue("Grade", Grade)

            'executing the Query
            cmd.ExecuteNonQuery()
            MessageBox.Show("Academic details added successfully!", "Academic Details")

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "Academic Details")

        Finally
            connection.Close()

        End Try

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        'Using the text boxes to input the data
        Dim Registration_Number As String = txtReg_No.Text
        Dim Surname As String = txtSurname.Text
        Dim Course As String = txtCourse.Text
        Dim Unit_Name As String = txtModule.Text
        Dim CAT_Marks As Double = Convert.ToDouble(txtCAT.Text)
        Dim Exam_Marks As Double = Convert.ToDouble(txtExam.Text)
        Dim Total_Marks As Double = Convert.ToDouble(txtTotal.Text)
        Dim Grade As String = txtGrade.Text

        'Calling unto the Add User Function
        AddUser(Registration_Number, Surname, Course, Unit_Name, CAT_Marks, Exam_Marks, Total_Marks, Grade)

    End Sub

    '********************************** END OF DATABASE CONNECTION CODE *****************************

    '*********************************** DATA ARITHMETIC*********************************************

    'CALCULATING THE TOTAL SCORE WITHIN THE FORM
    Private Sub btnTotalScore_Click(sender As Object, e As EventArgs) Handles btnTotalScore.Click

        'DECLARE THE VARIABLES 
        Dim CAT_Marks As Double
        Dim Exam_Marks As Double

        'INITIALIZE THE VARIABLES
        CAT_Marks = txtCAT.Text
        Exam_Marks = txtExam.Text

        'CALCULATE THE TOTAL SCORE
        Dim Total_Score As Integer = CAT_Marks + Exam_Marks

        'OUTPUT THE TOTAL SCORE
        txtTotal.Text = Total_Score.ToString()

    End Sub

    'CLACULATING THE GRADE OF THE STUDENT BASED ON THE TOTAL
    Private Sub btnAvereageGrade_Click(sender As Object, e As EventArgs) Handles btnAvereageGrade.Click

        'DECLARE THE VARIABLES 
        Dim CAT_Marks As Double
        Dim Exam_Marks As Double

        'INITIALIZE THE VARIABLES
        CAT_Marks = txtCAT.Text
        Exam_Marks = txtExam.Text

        'CALCULATE THE TOTAL SCORE
        Dim Total_Score As Integer = CAT_Marks + Exam_Marks

        'USE THE ELSE IF ELSE STATEMENT TO ASSIGN GRADES BASED ON THE TOTAL SCORE

        Select Case Total_Score
            Case 70 To 100
                txtGrade.Text = "A"
            Case 50 To 69
                txtGrade.Text = "B"
            Case 30 To 49
                txtGrade.Text = "C"
            Case 20 To 29
                txtGrade.Text = "D"
            Case 0 To 19
                txtGrade.Text = "E"
            Case Else
                txtGrade.Text = "Invalid!"
        End Select

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ''Closing the form
        Me.Close()

    End Sub
End Class