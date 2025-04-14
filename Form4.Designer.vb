<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridViewStudentDetails = New DataGridView()
        btnClose = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        CType(DataGridViewStudentDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewStudentDetails
        ' 
        DataGridViewStudentDetails.AllowUserToOrderColumns = True
        DataGridViewStudentDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewStudentDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewStudentDetails.BackgroundColor = Color.Green
        DataGridViewStudentDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewStudentDetails.ImeMode = ImeMode.NoControl
        DataGridViewStudentDetails.Location = New Point(0, 0)
        DataGridViewStudentDetails.MultiSelect = False
        DataGridViewStudentDetails.Name = "DataGridViewStudentDetails"
        DataGridViewStudentDetails.RowHeadersWidth = 60
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewStudentDetails.RowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewStudentDetails.ScrollBars = ScrollBars.None
        DataGridViewStudentDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewStudentDetails.Size = New Size(1097, 685)
        DataGridViewStudentDetails.TabIndex = 1
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        btnClose.Font = New Font("Calisto MT", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.Location = New Point(1115, 417)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(158, 47)
        btnClose.TabIndex = 7
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Font = New Font("Calisto MT", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(1115, 317)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(158, 47)
        btnDelete.TabIndex = 6
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Font = New Font("Calisto MT", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Location = New Point(1115, 211)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(158, 47)
        btnUpdate.TabIndex = 5
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1282, 685)
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(DataGridViewStudentDetails)
        Name = "Form4"
        Text = "STUDENT DETAILS (SMS)"
        CType(DataGridViewStudentDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewStudentDetails As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
End Class
