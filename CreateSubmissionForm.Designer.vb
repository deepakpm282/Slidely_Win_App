<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        txtLabel = New Label()
        txtName = New Label()
        TBName = New TextBox()
        textEmail = New Label()
        TBEmail = New TextBox()
        txtPhoneNumber = New Label()
        TBPhoneNumber = New TextBox()
        txtGitHubLink = New Label()
        TBGitHubLink = New TextBox()
        btnToggleStopWatch = New Button()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        TBTimer = New Label()
        SuspendLayout()
        ' 
        ' txtLabel
        ' 
        txtLabel.AutoSize = True
        txtLabel.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtLabel.ForeColor = Color.DimGray
        txtLabel.Location = New Point(185, 79)
        txtLabel.Name = "txtLabel"
        txtLabel.Size = New Size(424, 25)
        txtLabel.TabIndex = 0
        txtLabel.Text = "Deepak PM, Slidely Task 2, Create Submission"
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.ForeColor = Color.DimGray
        txtName.Location = New Point(215, 142)
        txtName.Name = "txtName"
        txtName.Size = New Size(64, 25)
        txtName.TabIndex = 1
        txtName.Text = "Name"
        ' 
        ' TBName
        ' 
        TBName.BackColor = Color.White
        TBName.BorderStyle = BorderStyle.FixedSingle
        TBName.Location = New Point(310, 138)
        TBName.Name = "TBName"
        TBName.Size = New Size(299, 29)
        TBName.TabIndex = 2
        TBName.TextAlign = HorizontalAlignment.Center
        ' 
        ' textEmail
        ' 
        textEmail.AutoSize = True
        textEmail.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        textEmail.ForeColor = Color.DimGray
        textEmail.Location = New Point(215, 192)
        textEmail.Name = "textEmail"
        textEmail.Size = New Size(60, 25)
        textEmail.TabIndex = 3
        textEmail.Text = "Email"
        ' 
        ' TBEmail
        ' 
        TBEmail.BackColor = Color.White
        TBEmail.BorderStyle = BorderStyle.FixedSingle
        TBEmail.Location = New Point(310, 192)
        TBEmail.Name = "TBEmail"
        TBEmail.Size = New Size(299, 29)
        TBEmail.TabIndex = 4
        TBEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.AutoSize = True
        txtPhoneNumber.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNumber.ForeColor = Color.DimGray
        txtPhoneNumber.Location = New Point(189, 242)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(115, 25)
        txtPhoneNumber.TabIndex = 5
        txtPhoneNumber.Text = "Phone Num"
        ' 
        ' TBPhoneNumber
        ' 
        TBPhoneNumber.BackColor = Color.White
        TBPhoneNumber.BorderStyle = BorderStyle.FixedSingle
        TBPhoneNumber.Location = New Point(310, 238)
        TBPhoneNumber.Name = "TBPhoneNumber"
        TBPhoneNumber.Size = New Size(299, 29)
        TBPhoneNumber.TabIndex = 6
        TBPhoneNumber.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.AutoSize = True
        txtGitHubLink.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHubLink.ForeColor = Color.DimGray
        txtGitHubLink.Location = New Point(189, 296)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(113, 50)
        txtGitHubLink.TabIndex = 7
        txtGitHubLink.Text = "GitHub Link" & vbCrLf & "For Task 2"
        ' 
        ' TBGitHubLink
        ' 
        TBGitHubLink.BackColor = Color.White
        TBGitHubLink.BorderStyle = BorderStyle.FixedSingle
        TBGitHubLink.Location = New Point(310, 296)
        TBGitHubLink.Multiline = True
        TBGitHubLink.Name = "TBGitHubLink"
        TBGitHubLink.Size = New Size(299, 60)
        TBGitHubLink.TabIndex = 8
        TBGitHubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnToggleStopWatch
        ' 
        btnToggleStopWatch.AllowDrop = True
        btnToggleStopWatch.BackColor = Color.Khaki
        btnToggleStopWatch.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        btnToggleStopWatch.ForeColor = SystemColors.GrayText
        btnToggleStopWatch.Location = New Point(185, 375)
        btnToggleStopWatch.Name = "btnToggleStopWatch"
        btnToggleStopWatch.Size = New Size(291, 40)
        btnToggleStopWatch.TabIndex = 9
        btnToggleStopWatch.Text = "Toogle StopWatch (CTRL + T)"
        btnToggleStopWatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightSkyBlue
        btnSubmit.Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Regular, GraphicsUnit.Point)
        btnSubmit.ForeColor = SystemColors.GrayText
        btnSubmit.Location = New Point(185, 438)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(424, 42)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' TBTimer
        ' 
        TBTimer.AutoSize = True
        TBTimer.BackColor = SystemColors.ControlLight
        TBTimer.BorderStyle = BorderStyle.FixedSingle
        TBTimer.Font = New Font("Courier New", 13.1846151F, FontStyle.Regular, GraphicsUnit.Point)
        TBTimer.Location = New Point(483, 383)
        TBTimer.Name = "TBTimer"
        TBTimer.Size = New Size(126, 29)
        TBTimer.TabIndex = 11
        TBTimer.Text = "00:00:00"
        TBTimer.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 667)
        Controls.Add(TBTimer)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopWatch)
        Controls.Add(TBGitHubLink)
        Controls.Add(txtGitHubLink)
        Controls.Add(TBPhoneNumber)
        Controls.Add(txtPhoneNumber)
        Controls.Add(TBEmail)
        Controls.Add(textEmail)
        Controls.Add(TBName)
        Controls.Add(txtName)
        Controls.Add(txtLabel)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLabel As Label
    Friend WithEvents txtName As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents textEmail As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents txtPhoneNumber As Label
    Friend WithEvents TBPhoneNumber As TextBox
    Friend WithEvents txtGitHubLink As Label
    Friend WithEvents TBGitHubLink As TextBox
    Friend WithEvents btnToggleStopWatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TBTimer As Label
End Class
