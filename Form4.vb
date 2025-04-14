Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Form4

    Dim connectionString As String = "Server=localhost; Port=3307; Database=school_management_system; password=Jace102020.; user id = root;"

    Dim connection As New MySqlConnection(connectionString)

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection = New MySqlConnection(connectionString)

        LoadData()

    End Sub

    'Retrieves Data From the Database to the DataGridView
    Public Sub LoadData()

        Try

            connection.Open()

            Dim query As String = "SELECT * FROM student_details "

            Dim adapter As New MySqlDataAdapter(query, connection)

            Dim DataTable As New DataTable()

            adapter.Fill(DataTable)

            DataGridViewStudentDetails.DataSource = DataTable

        Catch ex As Exception

            MessageBox.Show("Error :" & ex.Message)

        Finally

            connection.Close()

        End Try

    End Sub

    'The event update button handler will handle update events that would happpen to the data in the database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()

            'Validating whether a row is selected 
            If DataGridViewStudentDetails.SelectedRows.Count = 0 Then
                MessageBox.Show("Please Select a Row to Update", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'Getting the selected Row
            Dim row As DataGridViewRow = DataGridViewStudentDetails.SelectedRows(0)

            'Validating the registration Number as it is used as the Primary Key
            If String.IsNullOrEmpty(row.Cells("Registration_Number").Value.ToString()) Then
                MessageBox.Show("Registration Number is required to update the Record", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'Sql Update Query
            Dim query As String = "UPDATE student_details SET First_Name = @First_Name, Surname = @Surname, Year_Of_Study = @Year_Of_Study, Semester = @Semester, Course_Name = @Course_Name WHERE Registration_Number = @Registration_Number"

            'Create the Update Sql Command
            Dim cmd As New MySqlCommand(query, connection)

            'Updating the data via the SQL command
            cmd.Parameters.AddWithValue("@Registration_Number", row.Cells("Registration_Number").Value)
            cmd.Parameters.AddWithValue("@First_Name", row.Cells("First_Name").Value)
            cmd.Parameters.AddWithValue("Surname", row.Cells("Surname").Value)
            cmd.Parameters.AddWithValue("Year_Of_Study", row.Cells("Year_Of_Study").Value)
            cmd.Parameters.AddWithValue("Semester", row.Cells("Semester").Value)
            cmd.Parameters.AddWithValue("Course_Name", row.Cells("Course_Name").Value)

            'Executing the Query
            cmd.ExecuteNonQuery()

            'If the query was executed successfullyt , then show:
            MessageBox.Show("Records Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            'If not successful catch as exception by displaying the following:
            MessageBox.Show("Error : " & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            'Refreshing the Application
            LoadData()

        Finally
            'Closing the Database connection
            connection.Close()

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            'Validating if there is a selected row
            If DataGridViewStudentDetails.SelectedRows.Count = 0 Then
                MessageBox.Show("Please Select a Row to Delete", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            'Getting the selected Row
            Dim row As DataGridViewRow = DataGridViewStudentDetails.SelectedRows(0)
            Dim Registration_Number As String = row.Cells("Registration_Number").Value.ToString()

            'Opening the database connection
            connection.Open()

            'sql delete query
            Dim query As String = "DELETE FROM student_details WHERE Registration_Number = @Registration_Number"

            'Creating the delete command
            Dim cmd As New MySqlCommand(query, connection)

            'Adding the parameters
            cmd.Parameters.AddWithValue("@Registration_Number", Registration_Number)

            'Executing the query
            cmd.ExecuteNonQuery()

            'If the query was executed successfully, then show:
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Refreshing the Application
            LoadData()

        Catch ex As Exception
            'If not successful catch as exception by displaying the following:
            MessageBox.Show("Error : " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Finally
            'Closing the Database connection
            connection.Close()

        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closing the Form
        Me.Close()

    End Sub

End Class