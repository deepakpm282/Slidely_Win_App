<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmission = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnCreateNewSubmission = New Button()
        mainHeading = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmission
        ' 
        btnViewSubmission.BackColor = Color.Khaki
        btnViewSubmission.Font = New Font("Microsoft Sans Serif", 10.9692307F)
        btnViewSubmission.ForeColor = SystemColors.WindowFrame
        btnViewSubmission.Location = New Point(135, 234)
        btnViewSubmission.Margin = New Padding(4)
        btnViewSubmission.Name = "btnViewSubmission"
        btnViewSubmission.Size = New Size(507, 51)
        btnViewSubmission.TabIndex = 0
        btnViewSubmission.Text = "View Submissions (CTRL + V)"
        btnViewSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = Color.LightBlue
        btnCreateNewSubmission.Font = New Font("Microsoft Sans Serif", 10.9692307F)
        btnCreateNewSubmission.ForeColor = SystemColors.WindowFrame
        btnCreateNewSubmission.Location = New Point(135, 293)
        btnCreateNewSubmission.Margin = New Padding(4)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(507, 51)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "Create New Submission (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' mainHeading
        ' 
        mainHeading.AutoSize = True
        mainHeading.Font = New Font("Microsoft Sans Serif", 13.1846151F)
        mainHeading.ForeColor = Color.DimGray
        mainHeading.Location = New Point(135, 191)
        mainHeading.Margin = New Padding(4, 0, 4, 0)
        mainHeading.Name = "mainHeading"
        mainHeading.Size = New Size(507, 29)
        mainHeading.TabIndex = 2
        mainHeading.Text = "Deepak PM, Slidely Task 2 - Slidely Form App"
        mainHeading.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(764, 536)
        Controls.Add(mainHeading)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmission)
        Font = New Font("Microsoft Sans Serif", 11.0769234F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmission As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents mainHeading As Label

End Class
