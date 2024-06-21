Imports System.Net.Http
Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class Form2
    Private currentIndex As Integer = 0
    Private maxIndex As Integer = 0
    Private client As New HttpClient()

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' URL to get the length of JSON data
        Me.KeyPreview = True
        Dim url2 As String = "http://localhost:3000/len"
        progressBarLoading.Visible = False

        Try
            ' Show the loading symbol and set the cursor to waiting
            progressBarLoading.Visible = True
            Cursor = Cursors.WaitCursor

            ' Send GET request to get the length of the JSON data asynchronously
            Dim response As HttpResponseMessage = Await client.GetAsync(url2)

            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Parse the length from the response
                maxIndex = Integer.Parse(responseContent) - 1
                Await LoadData(currentIndex)
            Else
                ' Display the status code and reason phrase in a message box
                MessageBox.Show(String.Format("Error: {0} - {1}", response.StatusCode, response.ReasonPhrase), "HTTP GET Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Display exception message in a message box
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Hide the loading symbol and reset the cursor to default
            progressBarLoading.Visible = False
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Async Function LoadData(index As Integer) As Task
        ' URL to send the GET request to
        Dim url As String = $"http://localhost:3000/read?index={index}"

        Try
            ' Show the loading symbol and set the cursor to waiting
            progressBarLoading.Visible = True
            Cursor = Cursors.WaitCursor

            ' Send GET request asynchronously
            Dim response As HttpResponseMessage = Await client.GetAsync(url)

            ' Check if the response is successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON response to a Dictionary
                Dim data As Dictionary(Of String, String) = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseContent)

                ' Set the text of the text boxes with the corresponding values
                If data.ContainsKey("name") Then txtName.Text = data("name")
                If data.ContainsKey("email") Then txtEmail.Text = data("email")
                If data.ContainsKey("phone") Then txtPhone.Text = data("phone")
                If data.ContainsKey("github_link") Then txtGithubLink.Text = data("github_link")
                If data.ContainsKey("stopwatch_time") Then txtStopwatchTime.Text = data("stopwatch_time")
            Else
                ' Display the status code and reason phrase in a message box
                MessageBox.Show(String.Format("Error: {0} - {1}", response.StatusCode, response.ReasonPhrase), "HTTP GET Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Display exception message in a message box
            MessageBox.Show("Error: " & ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Hide the loading symbol and reset the cursor to default
            progressBarLoading.Visible = False
            Cursor = Cursors.Default
        End Try
    End Function

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Handle the "Previous" button click
        currentIndex -= 1
        If currentIndex < 0 Then
            currentIndex = maxIndex
        End If
        Await LoadData(currentIndex)
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Handle the "Next" button click
        currentIndex += 1
        If currentIndex > maxIndex Then
            currentIndex = 0
        End If
        Await LoadData(currentIndex)
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        ' Dispose of the HttpClient instance when done
        client.Dispose()
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl+N pressed
            Button1.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            ' Ctrl+P pressed
            Button2.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.C Then
            ' Ctrl+C pressed
            Me.Close()
        End If
    End Sub
End Class
