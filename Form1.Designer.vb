<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnStudent_Registration = New Button()
        btnStudentDetails = New Button()
        btnAcademicInput = New Button()
        btnAcademicDetails = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Century Gothic", 30.0521736F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(-1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(896, 56)
        Label1.TabIndex = 0
        Label1.Text = "SCHOOL MANAGEMENT SYSTEM (SMS)"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnStudent_Registration
        ' 
        btnStudent_Registration.BackColor = Color.Green
        btnStudent_Registration.Cursor = Cursors.Hand
        btnStudent_Registration.Font = New Font("Calisto MT", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent_Registration.ForeColor = Color.Ivory
        btnStudent_Registration.Location = New Point(524, 106)
        btnStudent_Registration.Name = "btnStudent_Registration"
        btnStudent_Registration.Size = New Size(313, 92)
        btnStudent_Registration.TabIndex = 1
        btnStudent_Registration.Text = "STUDENT REGISTRATION"
        btnStudent_Registration.UseVisualStyleBackColor = False
        ' 
        ' btnStudentDetails
        ' 
        btnStudentDetails.BackColor = Color.Green
        btnStudentDetails.Cursor = Cursors.Hand
        btnStudentDetails.Font = New Font("Calisto MT", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudentDetails.ForeColor = Color.Ivory
        btnStudentDetails.Location = New Point(524, 466)
        btnStudentDetails.Name = "btnStudentDetails"
        btnStudentDetails.Size = New Size(313, 92)
        btnStudentDetails.TabIndex = 2
        btnStudentDetails.Text = "STUDENT DETAILS"
        btnStudentDetails.UseVisualStyleBackColor = False
        ' 
        ' btnAcademicInput
        ' 
        btnAcademicInput.BackColor = Color.Green
        btnAcademicInput.Cursor = Cursors.Hand
        btnAcademicInput.Font = New Font("Calisto MT", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAcademicInput.ForeColor = Color.Ivory
        btnAcademicInput.Location = New Point(43, 106)
        btnAcademicInput.Name = "btnAcademicInput"
        btnAcademicInput.Size = New Size(313, 92)
        btnAcademicInput.TabIndex = 3
        btnAcademicInput.Text = "ACADEMIC INPUT"
        btnAcademicInput.UseVisualStyleBackColor = False
        ' 
        ' btnAcademicDetails
        ' 
        btnAcademicDetails.BackColor = Color.Green
        btnAcademicDetails.Cursor = Cursors.Hand
        btnAcademicDetails.Font = New Font("Calisto MT", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAcademicDetails.ForeColor = Color.Ivory
        btnAcademicDetails.Location = New Point(43, 466)
        btnAcademicDetails.Name = "btnAcademicDetails"
        btnAcademicDetails.Size = New Size(313, 92)
        btnAcademicDetails.TabIndex = 4
        btnAcademicDetails.Text = "ACADEMIC DETAILS"
        btnAcademicDetails.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 600)
        Controls.Add(btnAcademicDetails)
        Controls.Add(btnAcademicInput)
        Controls.Add(btnStudentDetails)
        Controls.Add(btnStudent_Registration)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "SCHOOL MANAGEMNT SYSTEM (SMS)"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStudent_Registration As Button
    Friend WithEvents btnStudentDetails As Button
    Friend WithEvents btnAcademicInput As Button
    Friend WithEvents btnAcademicDetails As Button

End Class
