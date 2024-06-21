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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtGithubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtStopwatchTime = New TextBox()
        Button2 = New Button()
        progressBarLoading = New ProgressBar()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(444, 374)
        Button1.Name = "Button1"
        Button1.Size = New Size(353, 46)
        Button1.TabIndex = 0
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(165, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 1
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(165, 179)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 23)
        Label2.TabIndex = 2
        Label2.Text = "Phn No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(165, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 23)
        Label3.TabIndex = 3
        Label3.Text = "Github"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(149, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 23)
        Label4.TabIndex = 4
        Label4.Text = "Stop Watch"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(166, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 23)
        Label5.TabIndex = 5
        Label5.Text = "Email"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Highlight
        Label6.Location = New Point(183, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(457, 26)
        Label6.TabIndex = 6
        Label6.Text = "Ajay Dattu,Slidely Task 2- View Submissions"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.InactiveCaption
        txtName.Location = New Point(289, 60)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(374, 27)
        txtName.TabIndex = 7
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.BackColor = SystemColors.InactiveCaption
        txtGithubLink.Location = New Point(289, 231)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(374, 27)
        txtGithubLink.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.InactiveCaption
        txtPhone.Location = New Point(289, 179)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(374, 27)
        txtPhone.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.InactiveCaption
        txtEmail.Location = New Point(289, 118)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(374, 27)
        txtEmail.TabIndex = 10
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.InactiveCaption
        txtStopwatchTime.Location = New Point(289, 296)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(374, 27)
        txtStopwatchTime.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.MediumSpringGreen
        Button2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(12, 374)
        Button2.Name = "Button2"
        Button2.Size = New Size(361, 46)
        Button2.TabIndex = 12
        Button2.Text = "previous"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' progressBarLoading
        ' 
        progressBarLoading.Location = New Point(356, 151)
        progressBarLoading.Name = "progressBarLoading"
        progressBarLoading.Size = New Size(125, 29)
        progressBarLoading.Style = ProgressBarStyle.Marquee
        progressBarLoading.TabIndex = 13
        progressBarLoading.Visible = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.Azure
        ClientSize = New Size(800, 465)
        Controls.Add(progressBarLoading)
        Controls.Add(Button2)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGithubLink)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents progressBarLoading As ProgressBar
End Class
