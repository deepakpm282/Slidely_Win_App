﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionForms
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
        topLabel = New Label()
        txtName = New Label()
        TBName = New TextBox()
        txtEmail = New Label()
        TBEmail = New TextBox()
        txtPhoneNum = New Label()
        TBGithubLink = New TextBox()
        TBPhoneNum = New TextBox()
        txtGitHubLink = New Label()
        txtStopWatch = New Label()
        TBStopWatch = New TextBox()
        btnPreviousSubmission = New Button()
        btnNextSubmission = New Button()
        SuspendLayout()
        ' 
        ' topLabel
        ' 
        topLabel.AutoSize = True
        topLabel.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        topLabel.ForeColor = Color.DimGray
        topLabel.Location = New Point(193, 54)
        topLabel.Name = "topLabel"
        topLabel.Size = New Size(423, 25)
        topLabel.TabIndex = 0
        topLabel.Text = "Deepak PM, Slidely Task 2 , View Submissions"
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.ForeColor = Color.DimGray
        txtName.Location = New Point(218, 116)
        txtName.Name = "txtName"
        txtName.Size = New Size(64, 25)
        txtName.TabIndex = 1
        txtName.Text = "Name"
        ' 
        ' TBName
        ' 
        TBName.BackColor = Color.LightGray
        TBName.BorderStyle = BorderStyle.FixedSingle
        TBName.Font = New Font("Microsoft Sans Serif", 8.969231F, FontStyle.Regular, GraphicsUnit.Point)
        TBName.ForeColor = SystemColors.WindowFrame
        TBName.Location = New Point(314, 116)
        TBName.Name = "TBName"
        TBName.ReadOnly = True
        TBName.Size = New Size(292, 26)
        TBName.TabIndex = 2
        TBName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.AutoSize = True
        txtEmail.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.ForeColor = Color.DimGray
        txtEmail.Location = New Point(220, 169)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(60, 25)
        txtEmail.TabIndex = 3
        txtEmail.Text = "Email"
        ' 
        ' TBEmail
        ' 
        TBEmail.BackColor = Color.LightGray
        TBEmail.BorderStyle = BorderStyle.FixedSingle
        TBEmail.Font = New Font("Microsoft Sans Serif", 8.969231F, FontStyle.Regular, GraphicsUnit.Point)
        TBEmail.ForeColor = SystemColors.WindowFrame
        TBEmail.Location = New Point(314, 169)
        TBEmail.Name = "TBEmail"
        TBEmail.ReadOnly = True
        TBEmail.Size = New Size(292, 26)
        TBEmail.TabIndex = 4
        TBEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.AutoSize = True
        txtPhoneNum.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNum.ForeColor = Color.DimGray
        txtPhoneNum.Location = New Point(193, 235)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(115, 25)
        txtPhoneNum.TabIndex = 5
        txtPhoneNum.Text = "Phone Num"
        ' 
        ' TBGithubLink
        ' 
        TBGithubLink.BackColor = Color.LightGray
        TBGithubLink.BorderStyle = BorderStyle.FixedSingle
        TBGithubLink.Font = New Font("Microsoft Sans Serif", 8.969231F, FontStyle.Regular, GraphicsUnit.Point)
        TBGithubLink.ForeColor = SystemColors.WindowFrame
        TBGithubLink.Location = New Point(314, 292)
        TBGithubLink.Multiline = True
        TBGithubLink.Name = "TBGithubLink"
        TBGithubLink.ReadOnly = True
        TBGithubLink.Size = New Size(292, 63)
        TBGithubLink.TabIndex = 6
        TBGithubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBPhoneNum
        ' 
        TBPhoneNum.BackColor = Color.LightGray
        TBPhoneNum.BorderStyle = BorderStyle.FixedSingle
        TBPhoneNum.Font = New Font("Microsoft Sans Serif", 8.969231F, FontStyle.Regular, GraphicsUnit.Point)
        TBPhoneNum.ForeColor = SystemColors.WindowFrame
        TBPhoneNum.Location = New Point(314, 231)
        TBPhoneNum.Name = "TBPhoneNum"
        TBPhoneNum.ReadOnly = True
        TBPhoneNum.Size = New Size(292, 26)
        TBPhoneNum.TabIndex = 7
        TBPhoneNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.AutoSize = True
        txtGitHubLink.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHubLink.ForeColor = Color.DimGray
        txtGitHubLink.Location = New Point(193, 296)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(113, 50)
        txtGitHubLink.TabIndex = 8
        txtGitHubLink.Text = "GitHub Link" & vbCrLf & "For Task 2"
        ' 
        ' txtStopWatch
        ' 
        txtStopWatch.AutoSize = True
        txtStopWatch.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtStopWatch.ForeColor = Color.DimGray
        txtStopWatch.Location = New Point(193, 371)
        txtStopWatch.Name = "txtStopWatch"
        txtStopWatch.Size = New Size(110, 50)
        txtStopWatch.TabIndex = 9
        txtStopWatch.Text = "StopWatch" & vbCrLf & "Time"
        txtStopWatch.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TBStopWatch
        ' 
        TBStopWatch.BackColor = Color.LightGray
        TBStopWatch.BorderStyle = BorderStyle.FixedSingle
        TBStopWatch.Font = New Font("Microsoft Sans Serif", 8.969231F, FontStyle.Regular, GraphicsUnit.Point)
        TBStopWatch.ForeColor = SystemColors.WindowFrame
        TBStopWatch.Location = New Point(314, 385)
        TBStopWatch.Name = "TBStopWatch"
        TBStopWatch.ReadOnly = True
        TBStopWatch.Size = New Size(292, 26)
        TBStopWatch.TabIndex = 10
        TBStopWatch.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPreviousSubmission
        ' 
        btnPreviousSubmission.BackColor = Color.Khaki
        btnPreviousSubmission.Font = New Font("Microsoft Sans Serif", 10.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        btnPreviousSubmission.Location = New Point(193, 450)
        btnPreviousSubmission.Name = "btnPreviousSubmission"
        btnPreviousSubmission.Size = New Size(200, 31)
        btnPreviousSubmission.TabIndex = 11
        btnPreviousSubmission.Text = "Previous (CTRL + P)"
        btnPreviousSubmission.UseCompatibleTextRendering = True
        btnPreviousSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnNextSubmission
        ' 
        btnNextSubmission.BackColor = Color.SkyBlue
        btnNextSubmission.Font = New Font("Microsoft Sans Serif", 9.969231F, FontStyle.Regular, GraphicsUnit.Point)
        btnNextSubmission.Location = New Point(406, 450)
        btnNextSubmission.Name = "btnNextSubmission"
        btnNextSubmission.Size = New Size(200, 31)
        btnNextSubmission.TabIndex = 12
        btnNextSubmission.Text = "Next (CTRL + N)"
        btnNextSubmission.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionForms
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 572)
        Controls.Add(btnNextSubmission)
        Controls.Add(btnPreviousSubmission)
        Controls.Add(TBStopWatch)
        Controls.Add(txtStopWatch)
        Controls.Add(txtGitHubLink)
        Controls.Add(TBPhoneNum)
        Controls.Add(TBGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(TBEmail)
        Controls.Add(txtEmail)
        Controls.Add(TBName)
        Controls.Add(txtName)
        Controls.Add(topLabel)
        Name = "ViewSubmissionForms"
        Text = "ViewSubmissionForms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents topLabel As Label
    Friend WithEvents txtName As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents txtEmail As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents txtPhoneNum As Label
    Friend WithEvents TBGithubLink As TextBox
    Friend WithEvents TBPhoneNum As TextBox
    Friend WithEvents txtGitHubLink As Label
    Friend WithEvents txtStopWatch As Label
    Friend WithEvents TBStopWatch As TextBox
    Friend WithEvents btnPreviousSubmission As Button
    Friend WithEvents btnNextSubmission As Button
End Class
