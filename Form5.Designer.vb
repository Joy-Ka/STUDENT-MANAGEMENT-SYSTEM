<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        DataGridViewAcademicDetails = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClose = New Button()
        CType(DataGridViewAcademicDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewAcademicDetails
        ' 
        DataGridViewAcademicDetails.BackgroundColor = Color.Green
        DataGridViewAcademicDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(DataGridViewAcademicDetails, "DataGridViewAcademicDetails")
        DataGridViewAcademicDetails.Name = "DataGridViewAcademicDetails"
        DataGridViewAcademicDetails.ShowEditingIcon = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Cursor = Cursors.Hand
        resources.ApplyResources(btnUpdate, "btnUpdate")
        btnUpdate.ForeColor = Color.Black
        btnUpdate.Name = "btnUpdate"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Cursor = Cursors.Hand
        resources.ApplyResources(btnDelete, "btnDelete")
        btnDelete.Name = "btnDelete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Cursor = Cursors.Hand
        resources.ApplyResources(btnClose, "btnClose")
        btnClose.Name = "btnClose"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnClose)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(DataGridViewAcademicDetails)
        Name = "Form5"
        CType(DataGridViewAcademicDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewAcademicDetails As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
End Class
