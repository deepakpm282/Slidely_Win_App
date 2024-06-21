Public Class Form1

    Private Sub Form1_Key_Down(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        End If
    End Sub

    Private Sub btnViewSubmission_Click(sender As Object, e As EventArgs) Handles btnViewSubmission.Click
        Dim viewSubmissionsForm = New ViewSubmissionForms()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm = New CreateSubmissionForm()
        createSubmissionForm.Show()

    End Sub

End Class
