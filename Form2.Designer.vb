<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtReg_No = New TextBox()
        txtFirst_Name = New TextBox()
        txtSurname = New TextBox()
        txtSemester = New TextBox()
        btnSubmit = New Button()
        Label7 = New Label()
        txtCourse = New TextBox()
        txtYear = New TextBox()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Century Gothic", 28.173914F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(195, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(518, 53)
        Label1.TabIndex = 1
        Label1.Text = "STUDENT REGISTRATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Ivory
        Label2.Location = New Point(2, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(476, 35)
        Label2.TabIndex = 2
        Label2.Text = "ENTER STUDENT'S FIRST NAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Ivory
        Label3.Location = New Point(2, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(439, 35)
        Label3.TabIndex = 3
        Label3.Text = "ENTER STUDENT'S SURNAME"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Ivory
        Label4.Location = New Point(2, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(380, 35)
        Label4.TabIndex = 4
        Label4.Text = "REGISTRATION NUMBER"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Ivory
        Label5.Location = New Point(-10, 361)
        Label5.Name = "Label5"
        Label5.Size = New Size(429, 35)
        Label5.TabIndex = 5
        Label5.Text = " STUDENT'S YEAR OF STUDY"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Ivory
        Label6.Location = New Point(2, 453)
        Label6.Name = "Label6"
        Label6.Size = New Size(422, 35)
        Label6.TabIndex = 6
        Label6.Text = "INPUT CURRENT SEMESTER"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtReg_No
        ' 
        txtReg_No.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReg_No.Location = New Point(480, 90)
        txtReg_No.Multiline = True
        txtReg_No.Name = "txtReg_No"
        txtReg_No.Size = New Size(390, 50)
        txtReg_No.TabIndex = 7
        txtReg_No.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtFirst_Name
        ' 
        txtFirst_Name.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirst_Name.Location = New Point(480, 173)
        txtFirst_Name.Multiline = True
        txtFirst_Name.Name = "txtFirst_Name"
        txtFirst_Name.Size = New Size(390, 50)
        txtFirst_Name.TabIndex = 8
        txtFirst_Name.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSurname.Location = New Point(480, 258)
        txtSurname.Multiline = True
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(390, 50)
        txtSurname.TabIndex = 9
        txtSurname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtSemester
        ' 
        txtSemester.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSemester.Location = New Point(480, 441)
        txtSemester.Multiline = True
        txtSemester.Name = "txtSemester"
        txtSemester.Size = New Size(390, 50)
        txtSemester.TabIndex = 11
        txtSemester.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Green
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.Font = New Font("Calisto MT", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.ForeColor = Color.Ivory
        btnSubmit.Location = New Point(68, 618)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(236, 55)
        btnSubmit.TabIndex = 12
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Ivory
        Label7.Location = New Point(2, 544)
        Label7.Name = "Label7"
        Label7.Size = New Size(435, 35)
        Label7.TabIndex = 13
        Label7.Text = "COURSE TAKEN BY STUDENT"
        ' 
        ' txtCourse
        ' 
        txtCourse.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourse.Location = New Point(480, 529)
        txtCourse.Multiline = True
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(390, 50)
        txtCourse.TabIndex = 14
        txtCourse.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtYear
        ' 
        txtYear.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtYear.Location = New Point(480, 354)
        txtYear.Multiline = True
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(390, 50)
        txtYear.TabIndex = 10
        txtYear.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Green
        btnClose.Font = New Font("Calisto MT", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Ivory
        btnClose.Location = New Point(562, 618)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(236, 55)
        btnClose.TabIndex = 25
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(882, 685)
        Controls.Add(btnClose)
        Controls.Add(txtCourse)
        Controls.Add(Label7)
        Controls.Add(btnSubmit)
        Controls.Add(txtSemester)
        Controls.Add(txtYear)
        Controls.Add(txtSurname)
        Controls.Add(txtFirst_Name)
        Controls.Add(txtReg_No)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.Black
        Name = "Form2"
        Text = "STUDENT REGISTRATION(SMS)"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReg_No As TextBox
    Friend WithEvents txtFirst_Name As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtSemester As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnClose As Button
End Class
