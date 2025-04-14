Public Class Form1

    'secondForm
    Private Sub btnStudent_Registration_Click(sender As Object, e As EventArgs) Handles btnStudent_Registration.Click

        'Linking the First form with the Student Registration
        Dim secondForm As New Form2()
        'Calling out the Function
        secondForm.Show()

    End Sub

    'thirdForm
    Private Sub btnAcademicInput_Click(sender As Object, e As EventArgs) Handles btnAcademicInput.Click

        'Linking the first form with the third form
        Dim thirdForm As New Form3
        'Calling out the form function
        thirdForm.Show()

    End Sub

    'fourthForm
    Private Sub btnStudentDetails_Click(sender As Object, e As EventArgs) Handles btnStudentDetails.Click

        'Linking the fifth form with the second form
        Dim fourthForm As New Form4
        'Calling out the form function
        fourthForm.Show()
    End Sub

    'fifthForm
    Private Sub btnAcademicDetails_Click(sender As Object, e As EventArgs) Handles btnAcademicDetails.Click

        'Linking the fifth form with the second form
        Dim fifthForm As New Form5
        'Calling out the form function
        fifthForm.Show()
    End Sub

End Class
