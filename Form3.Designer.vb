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
        txtEmailToDelete = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtEmailToDelete
        ' 
        txtEmailToDelete.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmailToDelete.Location = New Point(290, 165)
        txtEmailToDelete.Name = "txtEmailToDelete"
        txtEmailToDelete.Size = New Size(291, 34)
        txtEmailToDelete.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(628, 366)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 36)
        Button1.TabIndex = 1
        Button1.Text = "Delete"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(188, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 2
        Label1.Text = "Email"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(txtEmailToDelete)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmailToDelete As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
