Imports MySql.Data.MySqlClient

Public Class Form2

    Dim connectionString As String = "Server=localhost; Port=3307; user id = root; password=Jace102020.; Database= school_management_system"

    Dim connection As New MySqlConnection(connectionString)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialization of the Database
        connection = New MySqlConnection(connectionString)

    End Sub

    'Creating a function which adds data to the database

    Private Sub AddUser(Registration_Number As String, First_Name As String, Surname As String, Year_Of_Study As String, Semester As String, Course_Name As String)

        'USING THE 'TRY' STATEMENT
        Try

            'Opening the database connection
            connection.Open()

            'starting the SQL query commands
            Dim query As String = "INSERT INTO student_details(First_Name,Surname,Registration_Number,Year_Of_Study,Semester,Course_Name) VALUES(@First_Name, @Surname,@Registration_Number,@Year_Of_Study, @Semester,@Course_Name)"

            'Creating a command that holds the SQL Query
            Dim cmd As New MySqlCommand(query, connection)

            'Add the Parameters 
            cmd.Parameters.AddWithValue("@Registration_Number", Registration_Number)
            cmd.Parameters.AddWithValue("@First_Name", First_Name)
            cmd.Parameters.AddWithValue("@Surname", Surname)
            cmd.Parameters.AddWithValue("@Year_Of_Study", Year_Of_Study)
            cmd.Parameters.AddWithValue("@Semester", Semester)
            cmd.Parameters.AddWithValue("@Course_Name", Course_Name)

            'Executing the Query
            cmd.ExecuteNonQuery()
            MessageBox.Show("Student Registration Details are added successfully", "Student Registration")

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message, "Student Registration")

        Finally

            connection.Close()

        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Get the student registration details from the textboxes
        Dim Registration_Number As String = txtReg_No.Text
        Dim First_Name As String = txtFirst_Name.Text
        Dim Surname As String = txtSurname.Text
        Dim Year_Of_Study As String = txtYear.Text
        Dim Semester As String = txtSemester.Text
        Dim Course_Name As String = txtCourse.Text

        'CALLING UNTO THE ADD FUNCTION
        AddUser(Registration_Number, First_Name, Surname, Year_Of_Study, Semester, Course_Name)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closing the form
        Me.Close()

    End Sub

End Class