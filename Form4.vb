Imports System.Net.Http
Imports System.Text
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Form4
    Private client As New HttpClient()
    Private elapsedTime As TimeSpan
    Private stopwatchRunning As Boolean = False
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True
        Timer1.Interval = 100 ' Set the interval to 100 milliseconds
        elapsedTime = TimeSpan.Zero ' Initialize elapsed time
        UpdateTimeDisplay()
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim phone = txtPhone.Text
        Dim githubLink = txtGithubLink.Text
        Dim stopwatchTime As String = lblTimeDisplay.Text

        ' Create a dictionary to hold the data
        Dim data As New Dictionary(Of String, String) From {
        {"name", name},
        {"email", email},
        {"phone", phone},
        {"github_link", githubLink},
        {"stopwatch_time", stopwatchTime}
    }

        ' Convert the dictionary to JSON
        Dim jsonData = JsonConvert.SerializeObject(data)

        ' URL to send the POST request to
        Dim url = "http://localhost:3000/submit"

        ' Create HttpContent from the JSON string
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

        Try
            ' Send POST request asynchronously
            Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                Dim responseData As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse As JObject = JObject.Parse(responseData)
                Dim message As String = jsonResponse("message").ToString() ' Assuming your JSON has a "message" field
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim responseData As String = Await response.Content.ReadAsStringAsync()
                Dim jsonResponse As JObject = JObject.Parse(responseData)
                Dim errorMessage As String = jsonResponse("error").ToString() ' Assuming your JSON has an "error" field
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Display exception message in a message box
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not stopwatchRunning Then
            Timer1.Start()
            stopwatchRunning = True
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatchRunning = False
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Timer1.Stop()
        stopwatchRunning = False
        elapsedTime = TimeSpan.Zero
        UpdateTimeDisplay()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromMilliseconds(Timer1.Interval))
        UpdateTimeDisplay()
    End Sub
    Private Sub UpdateTimeDisplay()
        lblTimeDisplay.Text = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds / 10)
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Ctrl+K pressed
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.C Then
            ' Ctrl+K pressed
            Me.Close()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ' Ctrl+K pressed
            btnStart.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.X Then
            ' Ctrl+K pressed
            btnStop.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.R Then
            ' Ctrl+K pressed
            btnReset.PerformClick()
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class