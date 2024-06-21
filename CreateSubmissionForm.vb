Imports System.Net.Http
Imports System.Text
Imports System.Text.Json.Serialization
Imports Newtonsoft.Json


Public Class CreateSubmissionForm

    Dim ss, tt, vv As Integer

    Private Async Function SubmitData(name As String, email As String, phone As String, github_link As String, stop_watch As String) As Task
        Dim client As New HttpClient()
        Dim submission As New With {
            .name = name,
            .email = email,
            .github_link = github_link,
            .phone = phone,
            .stop_watch = stop_watch
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:7000/routes/submit", content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission Saved Successfully")
            Form1.Show()
            Me.Close()
        Else
            Dim errorMessage As String = Await response.Content.ReadAsStringAsync()
            MessageBox.Show("Error Saving Submission: " & errorMessage)
        End If

    End Function

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Await SubmitData(TBName.Text, TBEmail.Text, TBPhoneNumber.Text, TBGitHubLink.Text, TBTimer.Text)
    End Sub

    Private Sub btnToggleStopWatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopWatch.Click
        If Timer1.Enabled Then
            Timer1.Stop()
        Else
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TBTimer.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
        If tt > 59 Then
            tt = 0
            ss = ss + 1
        End If
        If ss > 23 Then
            tt = 0
            vv = 0
            Timer1.Enabled = False
        End If
    End Sub
End Class