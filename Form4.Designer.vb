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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        Button1 = New Button()
        txtGithubLink = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtPhone = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        Timer1 = New Timer(components)
        lblTimeDisplay = New Label()
        btnStart = New Button()
        btnReset = New Button()
        btnStop = New Button()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(251, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 28)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(686, 440)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 32)
        Button1.TabIndex = 1
        Button1.Text = "Sumbit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGithubLink.Location = New Point(347, 280)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(330, 34)
        txtGithubLink.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.MenuHighlight
        Label2.Location = New Point(182, 223)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 28)
        Label2.TabIndex = 3
        Label2.Text = "Phone Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.MenuHighlight
        Label3.Location = New Point(251, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 28)
        Label3.TabIndex = 4
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.MenuHighlight
        Label4.Location = New Point(204, 283)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 28)
        Label4.TabIndex = 5
        Label4.Text = "Github Link"
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(347, 221)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(330, 34)
        txtPhone.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(347, 103)
        txtName.Name = "txtName"
        txtName.Size = New Size(330, 34)
        txtName.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(347, 163)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(330, 34)
        txtEmail.TabIndex = 10
        ' 
        ' Timer1
        ' 
        ' 
        ' lblTimeDisplay
        ' 
        lblTimeDisplay.AutoSize = True
        lblTimeDisplay.Font = New Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTimeDisplay.ForeColor = SystemColors.MenuHighlight
        lblTimeDisplay.Location = New Point(380, 363)
        lblTimeDisplay.Name = "lblTimeDisplay"
        lblTimeDisplay.Size = New Size(136, 41)
        lblTimeDisplay.TabIndex = 11
        lblTimeDisplay.Text = "00:00:00"
        ' 
        ' btnStart
        ' 
        btnStart.BackColor = SystemColors.MenuHighlight
        btnStart.ForeColor = SystemColors.ButtonHighlight
        btnStart.Location = New Point(204, 371)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(37, 29)
        btnStart.TabIndex = 12
        btnStart.Text = "▶️"
        btnStart.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.MenuHighlight
        btnReset.ForeColor = SystemColors.ButtonHighlight
        btnReset.Location = New Point(300, 371)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(36, 29)
        btnReset.TabIndex = 13
        btnReset.Text = "🔄️"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnStop
        ' 
        btnStop.BackColor = SystemColors.MenuHighlight
        btnStop.ForeColor = SystemColors.ButtonHighlight
        btnStop.Location = New Point(254, 372)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(35, 29)
        btnStop.TabIndex = 14
        btnStop.Text = "⏸️"
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bauhaus 93", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.MenuHighlight
        Label5.Location = New Point(292, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(357, 50)
        Label5.TabIndex = 17
        Label5.Text = "Application From"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(232, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(54, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(851, 510)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(txtName)
        Controls.Add(btnStop)
        Controls.Add(btnStart)
        Controls.Add(btnReset)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(lblTimeDisplay)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtGithubLink)
        Controls.Add(Button1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimeDisplay As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
