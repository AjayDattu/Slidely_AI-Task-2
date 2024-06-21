<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button2 = New Button()
        Panel1 = New Panel()
        Panel5 = New Panel()
        Button1 = New Button()
        Button3 = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.MenuHighlight
        Button2.Dock = DockStyle.Right
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(362, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 55)
        Button2.TabIndex = 1
        Button2.Text = "Create Submission"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 657)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(40)
        Panel1.Size = New Size(1149, 135)
        Panel1.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button1)
        Panel5.Controls.Add(Button2)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(40, 40)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(548, 55)
        Panel5.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.Dock = DockStyle.Left
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(228, 55)
        Button1.TabIndex = 0
        Button1.Text = "View Submission"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Dock = DockStyle.Right
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(901, 40)
        Button3.Name = "Button3"
        Button3.Size = New Size(208, 55)
        Button3.TabIndex = 2
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.HighlightText
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10)
        Panel2.Size = New Size(1149, 208)
        Panel2.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.HighlightText
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.icon
        PictureBox1.Location = New Point(10, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1129, 188)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.HighlightText
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 208)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1149, 449)
        Panel3.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(40)
        Panel4.Size = New Size(1149, 449)
        Panel4.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Cambria", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(40, 40)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(40)
        Label1.Size = New Size(1033, 135)
        Label1.TabIndex = 0
        Label1.Text = "Ajay Dattu , Slidey AI Task 2 - Slidey Form App "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1149, 792)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button

End Class
