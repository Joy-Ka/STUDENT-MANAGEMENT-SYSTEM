Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset
Imports System.Data

Public Class Form5

    ' Connection Declaration
    Dim connectionString As String = "Server=localhost;Port=3307;user id=root; password= Jace102020.; Database= school_management_system"

    Dim connection As New MySqlConnection(connectionString)

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialization of the database
        LoadData()

    End Sub

    Private Sub LoadData()

        'Opening the try and catch execption statement
        Try

            'Opening the database connection
            connection.Open()

            Dim query As String = "SELECT * FROM academic_input"

            'Create a command that holds the SQL Query.The Declaration Dim adapter as NewMySqlAdapter(query, connection) is used to declare the adapter which tends to act as the bridge between the database and the DataTable
            Dim adapter As New MySqlDataAdapter(query, connection)

            'This Command creates a tabular format of storing the data from the database.
            Dim DataTable As New DataTable()

            'This fills the data from the database into the DataTable
            adapter.Fill(DataTable)

            ' Add a Row Number column for display purposes
            DataTable.Columns.Add("RowNumber", GetType(Integer))
            For i As Integer = 0 To DataTable.Rows.Count - 1
                DataTable.Rows(i)("RowNumber") = i + 1
            Next

            'After that we tend to assign the data grid view a functionality of the DataTable.
            DataGridViewAcademicDetails.DataSource = DataTable

        Catch ex As Exception

            MessageBox.Show("Error:" & ex.Message)

        Finally

            'Close the database conection
            connection.Close()

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Open the database connection
            connection.Open()

            ' Check if a row is selected
            If DataGridViewAcademicDetails.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a row to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the selected row
            Dim row As DataGridViewRow = DataGridViewAcademicDetails.SelectedRows(0)

            ' Validate Registration_Number
            If String.IsNullOrEmpty(row.Cells("Registration_Number").Value.ToString()) Then
                MessageBox.Show("Registration Number is required to update the record.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Retrieve CAT_Marks and Exam_Marks
            Dim CAT_Marks As Double = Convert.ToDouble(row.Cells("CAT_Marks").Value)
            Dim Exam_Marks As Double = Convert.ToDouble(row.Cells("Exam_Marks").Value)

            ' Calculate Total Marks and Grade
            Dim Total_Marks As Double = CalculateTotalMarks(CAT_Marks, Exam_Marks)
            Dim Grade As String = CalculateGrade(Total_Marks)

            ' SQL update query
            Dim query As String = "UPDATE academic_input SET " &
                          "Registration_Number = @Registration_Number," &
                          "Surname = @Surname, " &
                          "Course = @Course," &
                          "Unit_Name = @Unit_Name, " &
                          "CAT_Marks = @CAT_Marks, " &
                          "Exam_Marks = @Exam_Marks, " &
                          "Total_Marks = @Total_Marks, " &
                          "Grade = @Grade " &
                          "WHERE Number = @Number"

            ' Create MySQL command
            Using cmd As New MySqlCommand(query, connection)
                ' Bind parameters
                cmd.Parameters.AddWithValue("@Number", row.Cells("Number").Value)
                cmd.Parameters.AddWithValue("@Registration_Number", row.Cells("Registration_Number").Value)
                cmd.Parameters.AddWithValue("@Surname", row.Cells("Surname").Value)
                cmd.Parameters.AddWithValue("@Course", row.Cells("Course").Value)
                cmd.Parameters.AddWithValue("@Unit_Name", row.Cells("Unit_Name").Value)
                cmd.Parameters.AddWithValue("@CAT_Marks", CAT_Marks)
                cmd.Parameters.AddWithValue("@Exam_Marks", Exam_Marks)
                cmd.Parameters.AddWithValue("@Total_Marks", Total_Marks)
                cmd.Parameters.AddWithValue("@Grade", Grade)

                ' Execute query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Success message
                If rowsAffected > 0 Then
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No record updated. Please check your data.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

            ' Refresh DataGridView
            LoadData()

        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close connection
            connection.Close()
        End Try

    End Sub
    ' Function to calculate total marks
    Private Function CalculateTotalMarks(ByVal CAT_Marks As Double, ByVal Exam_Marks As Double) As Double
        Return CAT_Marks + Exam_Marks
    End Function

    ' Function to calculate grade based on total marks
    Private Function CalculateGrade(ByVal Total_Marks As Double) As String
        Select Case Total_Marks
            Case 0 To 39
                Return "E"
            Case 40 To 49
                Return "D"
            Case 50 To 59
                Return "C"
            Case 60 To 69
                Return "B"
            Case 70 To 100
                Return "A"
            Case Else
                Return "Invalid"
        End Select
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try
            ' Open the database connection
            connection.Open()

            ' Check if a row is selected
            If DataGridViewAcademicDetails.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get the selected row
            Dim row As DataGridViewRow = DataGridViewAcademicDetails.SelectedRows(0)

            ' SQL delete query
            Dim query As String = "DELETE FROM academic_input WHERE Number = @Number"

            ' Create MySQL command
            Dim cmd As New MySqlCommand(query, connection)

            ' Bind parameters
            cmd.Parameters.AddWithValue("@Number", row.Cells("Number").Value)

            ' Execute query
            cmd.ExecuteNonQuery()

            ' Success message
            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Handle errors
            MessageBox.Show("Error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            ' Close connection
            connection.Close()

        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closing the form
        Me.Close()

    End Sub


End Class
