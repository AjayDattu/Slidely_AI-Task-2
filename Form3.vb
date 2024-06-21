Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form3

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = txtEmailToDelete.Text.Trim() ' Replace with the email you want to delete

        ' Create HttpClient instance
        Using client As New HttpClient()

            ' Define the base URL where your API is hosted (replace with your actual base URL)
            client.BaseAddress = New Uri("http://localhost:3000/")

            ' Set headers
            client.DefaultRequestHeaders.Accept.Clear()
            client.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

            ' Send DELETE request asynchronously with query parameter
            Dim response As HttpResponseMessage = Await client.DeleteAsync($"delete?email={Uri.EscapeDataString(email)}")

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Deleted successfully")
            Else
                MessageBox.Show("Email Was Not Found " & response.StatusCode.ToString())
            End If
        End Using
    End Sub

    Private Sub txtEmailToDelete_TextChanged(sender As Object, e As EventArgs) Handles txtEmailToDelete.TextChanged

    End Sub
End Class
