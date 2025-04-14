<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label4 = New Label()
        txtReg_No = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txtSurname = New TextBox()
        txtCourse = New TextBox()
        txtModule = New TextBox()
        txtCAT = New TextBox()
        txtExam = New TextBox()
        btnTotalScore = New Button()
        txtTotal = New TextBox()
        btnAvereageGrade = New Button()
        txtGrade = New TextBox()
        btnAddUser = New Button()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Green
        Label1.Font = New Font("Century Gothic", 28.173914F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MintCream
        Label1.Location = New Point(240, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 53)
        Label1.TabIndex = 2
        Label1.Text = "ACADEMIC INPUT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Ivory
        Label4.Location = New Point(12, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(380, 35)
        Label4.TabIndex = 5
        Label4.Text = "REGISTRATION NUMBER"
        ' 
        ' txtReg_No
        ' 
        txtReg_No.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtReg_No.Location = New Point(416, 90)
        txtReg_No.Multiline = True
        txtReg_No.Name = "txtReg_No"
        txtReg_No.Size = New Size(390, 50)
        txtReg_No.TabIndex = 8
        txtReg_No.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Ivory
        Label2.Location = New Point(12, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(334, 35)
        Label2.TabIndex = 9
        Label2.Text = "ENTER THE SURNAME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Ivory
        Label3.Location = New Point(12, 249)
        Label3.Name = "Label3"
        Label3.Size = New Size(402, 35)
        Label3.TabIndex = 10
        Label3.Text = "ENTER THE COURSE NAME"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Ivory
        Label5.Location = New Point(12, 328)
        Label5.Name = "Label5"
        Label5.Size = New Size(406, 35)
        Label5.TabIndex = 11
        Label5.Text = "INPUT THE MODULE NAME"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Ivory
        Label6.Location = New Point(12, 400)
        Label6.Name = "Label6"
        Label6.Size = New Size(356, 35)
        Label6.TabIndex = 12
        Label6.Text = "INPUT THE CAT MARKS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Ivory
        Label7.Location = New Point(12, 470)
        Label7.Name = "Label7"
        Label7.Size = New Size(385, 35)
        Label7.TabIndex = 13
        Label7.Text = "INPUT  THE EXAM SCORE"
        ' 
        ' txtSurname
        ' 
        txtSurname.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSurname.Location = New Point(416, 159)
        txtSurname.Multiline = True
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(390, 50)
        txtSurname.TabIndex = 14
        txtSurname.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCourse
        ' 
        txtCourse.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCourse.Location = New Point(416, 234)
        txtCourse.Multiline = True
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(390, 50)
        txtCourse.TabIndex = 15
        txtCourse.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtModule
        ' 
        txtModule.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtModule.Location = New Point(416, 315)
        txtModule.Multiline = True
        txtModule.Name = "txtModule"
        txtModule.Size = New Size(390, 50)
        txtModule.TabIndex = 16
        txtModule.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCAT
        ' 
        txtCAT.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCAT.Location = New Point(416, 391)
        txtCAT.Multiline = True
        txtCAT.Name = "txtCAT"
        txtCAT.Size = New Size(390, 50)
        txtCAT.TabIndex = 17
        txtCAT.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtExam
        ' 
        txtExam.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtExam.Location = New Point(416, 464)
        txtExam.Multiline = True
        txtExam.Name = "txtExam"
        txtExam.Size = New Size(390, 50)
        txtExam.TabIndex = 18
        txtExam.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTotalScore
        ' 
        btnTotalScore.BackColor = Color.Green
        btnTotalScore.Cursor = Cursors.Hand
        btnTotalScore.Font = New Font("Tahoma", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTotalScore.ForeColor = Color.Ivory
        btnTotalScore.Location = New Point(12, 537)
        btnTotalScore.Name = "btnTotalScore"
        btnTotalScore.Size = New Size(205, 53)
        btnTotalScore.TabIndex = 19
        btnTotalScore.Text = "TOTAL SCORE"
        btnTotalScore.UseVisualStyleBackColor = False
        ' 
        ' txtTotal
        ' 
        txtTotal.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTotal.Location = New Point(240, 537)
        txtTotal.Multiline = True
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(157, 53)
        txtTotal.TabIndex = 20
        txtTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAvereageGrade
        ' 
        btnAvereageGrade.BackColor = Color.Green
        btnAvereageGrade.Cursor = Cursors.Hand
        btnAvereageGrade.Font = New Font("Tahoma", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAvereageGrade.ForeColor = Color.Ivory
        btnAvereageGrade.Location = New Point(416, 537)
        btnAvereageGrade.Name = "btnAvereageGrade"
        btnAvereageGrade.Size = New Size(250, 60)
        btnAvereageGrade.TabIndex = 21
        btnAvereageGrade.Text = "AVERAGE GRADE"
        btnAvereageGrade.UseVisualStyleBackColor = False
        ' 
        ' txtGrade
        ' 
        txtGrade.Font = New Font("Verdana", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGrade.Location = New Point(692, 540)
        txtGrade.Multiline = True
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(157, 53)
        txtGrade.TabIndex = 22
        txtGrade.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnAddUser
        ' 
        btnAddUser.BackColor = Color.Green
        btnAddUser.Font = New Font("Calisto MT", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddUser.ForeColor = Color.Ivory
        btnAddUser.Location = New Point(99, 612)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(236, 55)
        btnAddUser.TabIndex = 23
        btnAddUser.Text = "SUBMIT"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Green
        btnClose.Font = New Font("Calisto MT", 21.913044F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.Ivory
        btnClose.Location = New Point(520, 612)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(236, 55)
        btnClose.TabIndex = 24
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(882, 685)
        Controls.Add(btnClose)
        Controls.Add(btnAddUser)
        Controls.Add(txtGrade)
        Controls.Add(btnAvereageGrade)
        Controls.Add(txtTotal)
        Controls.Add(btnTotalScore)
        Controls.Add(txtExam)
        Controls.Add(txtCAT)
        Controls.Add(txtModule)
        Controls.Add(txtCourse)
        Controls.Add(txtSurname)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtReg_No)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "ACADEMIC INPUT (SMS)"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReg_No As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtModule As TextBox
    Friend WithEvents txtCAT As TextBox
    Friend WithEvents txtExam As TextBox
    Friend WithEvents btnTotalScore As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnAvereageGrade As Button
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnClose As Button
End Class
