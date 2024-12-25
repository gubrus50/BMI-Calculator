<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.btnCalories = New System.Windows.Forms.Button()
        Me.btnDiary = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.panelFooter.SuspendLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(530, 360)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(271, 92)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblFooter
        '
        Me.lblFooter.AutoSize = True
        Me.lblFooter.BackColor = System.Drawing.Color.Transparent
        Me.lblFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFooter.Font = New System.Drawing.Font("Calibri Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFooter.ForeColor = System.Drawing.Color.White
        Me.lblFooter.Location = New System.Drawing.Point(40, 30)
        Me.lblFooter.Name = "lblFooter"
        Me.lblFooter.Size = New System.Drawing.Size(129, 29)
        Me.lblFooter.TabIndex = 3
        Me.lblFooter.Text = "MY PROFILE"
        '
        'panelFooter
        '
        Me.panelFooter.Controls.Add(Me.lblFooter)
        Me.panelFooter.Location = New System.Drawing.Point(0, 360)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(530, 92)
        Me.panelFooter.TabIndex = 4
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsername.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(345, 149)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(126, 29)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "$UserName"
        '
        'picBackground
        '
        Me.picBackground.Image = Global.bmi_calculator.My.Resources.Resources.nunnyDim
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(801, 452)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 1
        Me.picBackground.TabStop = False
        '
        'picProfile
        '
        Me.picProfile.Image = Global.bmi_calculator.My.Resources.Resources.profile
        Me.picProfile.Location = New System.Drawing.Point(358, 35)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(100, 100)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picProfile.TabIndex = 7
        Me.picProfile.TabStop = False
        '
        'btnCalories
        '
        Me.btnCalories.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.btnCalories.Location = New System.Drawing.Point(129, 220)
        Me.btnCalories.Name = "btnCalories"
        Me.btnCalories.Size = New System.Drawing.Size(150, 95)
        Me.btnCalories.TabIndex = 8
        Me.btnCalories.Text = "CALORIES"
        Me.btnCalories.UseVisualStyleBackColor = True
        '
        'btnDiary
        '
        Me.btnDiary.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.btnDiary.Location = New System.Drawing.Point(333, 220)
        Me.btnDiary.Name = "btnDiary"
        Me.btnDiary.Size = New System.Drawing.Size(150, 95)
        Me.btnDiary.TabIndex = 9
        Me.btnDiary.Text = "DIARY"
        Me.btnDiary.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.btnReports.Location = New System.Drawing.Point(537, 220)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(150, 95)
        Me.btnReports.TabIndex = 10
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnDiary)
        Me.Controls.Add(Me.btnCalories)
        Me.Controls.Add(Me.picProfile)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.picBackground)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormHome"
        Me.Text = "BMI Calculator"
        Me.panelFooter.ResumeLayout(False)
        Me.panelFooter.PerformLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblFooter As Label
    Friend WithEvents panelFooter As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnCalories As Button
    Friend WithEvents btnDiary As Button
    Friend WithEvents btnReports As Button
End Class
