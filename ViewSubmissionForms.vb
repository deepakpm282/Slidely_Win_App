Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionForms

    Private submissions As List(Of Submission)
    Private CurrIndex As Integer = 0
    Private total As Integer

    Public Sub New()
        InitializeComponent()
        FetchSubmission(CurrIndex)
        GetTotalSubs()
    End Sub

    Private Async Function GetData(email As String) As Task
        Dim client As New HttpClient()
        Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:7000/routes/readByEmail?email={email}")

        If response.IsSuccessStatusCode Then
            Dim json As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
            DisplaySubmission(submission)
        Else
            MessageBox.Show("Error fetching data")
        End If

    End Function

    Private Async Sub FetchSubmission(index As Integer)
        Dim Client As New HttpClient()
        Dim response As HttpResponseMessage = Await Client.GetAsync($"http://localhost:7000/routes/read?index={index}")

        If response.IsSuccessStatusCode Then
            Dim json As String = Await response.Content.ReadAsStringAsync()
            Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(json)
            DisplaySubmission(submission)
        Else
            MessageBox.Show("Error fetching submission")
        End If
    End Sub

    Private Async Sub GetTotalSubs()
        Dim Client As New HttpClient()
        Dim response As HttpResponseMessage = Await Client.GetAsync("http://localhost:7000/routes/get-length")
        Dim totalAsString As String = Await response.Content.ReadAsStringAsync()
        Integer.TryParse(totalAsString, total)
    End Sub

    Private Sub DisplaySubmission(submission As Submission)
        If submission IsNot Nothing Then
            TBName.Text = submission.name
            TBEmail.Text = submission.email
            TBPhoneNum.Text = submission.phone
            TBGithubLink.Text = submission.github_link
            TBStopWatch.Text = submission.stop_watch
        Else
            MessageBox.Show("Submission not found")
        End If
    End Sub

    Private Sub btnPreviousSubmission_Click(sender As Object, e As EventArgs) Handles btnPreviousSubmission.Click
        If CurrIndex > 0 Then
            CurrIndex -= 1
            FetchSubmission(CurrIndex)
        Else
            MessageBox.Show("No previous submission")
        End If
    End Sub

    Private Sub btnNextSubmission_Click(sender As Object, e As EventArgs) Handles btnNextSubmission.Click

        Dim totalSubmissions = total
        If CurrIndex < totalSubmissions - 1 Then
            CurrIndex += 1
            FetchSubmission(CurrIndex)
        Else
            MessageBox.Show("No More Submissions")
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await GetData(TBSearchbox.Text)
    End Sub
End Class

Public Class Submission
    Public Property id As Integer
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stop_watch As String
End Class
