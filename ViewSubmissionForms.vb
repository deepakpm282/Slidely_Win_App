Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionForms

    Private submissions As List(Of Submission)
    Private CurrIndex As Integer = 0

    Public Sub New()
        InitializeComponent()
        FetchSubmissions()
    End Sub

    Private Async Sub FetchSubmissions()
        Dim Client As New HttpClient()
        Dim response As HttpResponseMessage = Await Client.GetAsync("http://localhost:7000/routes/read")

        If response.IsSuccessStatusCode Then
            Dim json As String = Await response.Content.ReadAsStringAsync()
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)
            DisplaySubmission(CurrIndex)
        End If
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If submissions IsNot Nothing AndAlso submissions.Count > 0 AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim submission As Submission = submissions(index)
            TBName.Text = submission.name
            TBEmail.Text = submission.email
            TBPhoneNum.Text = submission.phone
            TBGithubLink.Text = submission.github_link
            TBStopWatch.Text = submission.stop_watch
        Else
            MessageBox.Show("Submissions Not Found")
        End If
    End Sub

    Private Sub btnPreviousSubmission_Click(sender As Object, e As EventArgs) Handles btnPreviousSubmission.Click
        If CurrIndex > 0 Then
            CurrIndex -= 1
            DisplaySubmission(CurrIndex)
        Else
            MessageBox.Show("No Previuos Submission")
        End If
    End Sub

    Private Sub btnNextSubmission_Click(sender As Object, e As EventArgs) Handles btnNextSubmission.Click
        If submissions IsNot Nothing AndAlso CurrIndex < submissions.Count - 1 Then
            CurrIndex += 1
            DisplaySubmission(CurrIndex)
        Else
            MessageBox.Show("No more submissions")
        End If
    End Sub
End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stop_watch As String
End Class
