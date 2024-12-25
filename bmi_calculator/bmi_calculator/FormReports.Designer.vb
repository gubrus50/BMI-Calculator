<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReports))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAverageWeight = New System.Windows.Forms.Label()
        Me.lblHighestWeight = New System.Windows.Forms.Label()
        Me.lblLowestWeight = New System.Windows.Forms.Label()
        Me.lblDash1 = New System.Windows.Forms.Label()
        Me.lblDash2 = New System.Windows.Forms.Label()
        Me.lblDash3 = New System.Windows.Forms.Label()
        Me.lblAverageWeightResult = New System.Windows.Forms.Label()
        Me.lblHighestWeightResult = New System.Windows.Forms.Label()
        Me.lblLowestWeightResult = New System.Windows.Forms.Label()
        Me.btnMetric = New System.Windows.Forms.Button()
        Me.btnImperial = New System.Windows.Forms.Button()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = Global.bmi_calculator.My.Resources.Resources.nunnyDimmer
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(801, 452)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 3
        Me.picBackground.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI Light", 60.0!)
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(-20, 0)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(3, 3, 30, 3)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(95, 452)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "〈"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft JhengHei Light", 21.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(109, 34)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(207, 35)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "USER REPORTS"
        '
        'lblAverageWeight
        '
        Me.lblAverageWeight.AutoSize = True
        Me.lblAverageWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblAverageWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAverageWeight.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblAverageWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblAverageWeight.Location = New System.Drawing.Point(109, 156)
        Me.lblAverageWeight.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblAverageWeight.Name = "lblAverageWeight"
        Me.lblAverageWeight.Size = New System.Drawing.Size(268, 29)
        Me.lblAverageWeight.TabIndex = 7
        Me.lblAverageWeight.Text = "Average weight of all users"
        '
        'lblHighestWeight
        '
        Me.lblHighestWeight.AutoSize = True
        Me.lblHighestWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblHighestWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHighestWeight.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblHighestWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblHighestWeight.Location = New System.Drawing.Point(109, 214)
        Me.lblHighestWeight.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblHighestWeight.Name = "lblHighestWeight"
        Me.lblHighestWeight.Size = New System.Drawing.Size(261, 29)
        Me.lblHighestWeight.TabIndex = 8
        Me.lblHighestWeight.Text = "Highest weight of all users"
        '
        'lblLowestWeight
        '
        Me.lblLowestWeight.AutoSize = True
        Me.lblLowestWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblLowestWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLowestWeight.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblLowestWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblLowestWeight.Location = New System.Drawing.Point(109, 272)
        Me.lblLowestWeight.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblLowestWeight.Name = "lblLowestWeight"
        Me.lblLowestWeight.Size = New System.Drawing.Size(258, 29)
        Me.lblLowestWeight.TabIndex = 9
        Me.lblLowestWeight.Text = "Lowest weight of all users"
        '
        'lblDash1
        '
        Me.lblDash1.AutoSize = True
        Me.lblDash1.BackColor = System.Drawing.Color.Transparent
        Me.lblDash1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDash1.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.lblDash1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblDash1.Location = New System.Drawing.Point(411, 153)
        Me.lblDash1.Margin = New System.Windows.Forms.Padding(3, 25, 25, 0)
        Me.lblDash1.Name = "lblDash1"
        Me.lblDash1.Size = New System.Drawing.Size(23, 33)
        Me.lblDash1.TabIndex = 10
        Me.lblDash1.Text = "-"
        '
        'lblDash2
        '
        Me.lblDash2.AutoSize = True
        Me.lblDash2.BackColor = System.Drawing.Color.Transparent
        Me.lblDash2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDash2.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.lblDash2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblDash2.Location = New System.Drawing.Point(411, 211)
        Me.lblDash2.Margin = New System.Windows.Forms.Padding(3, 25, 25, 0)
        Me.lblDash2.Name = "lblDash2"
        Me.lblDash2.Size = New System.Drawing.Size(23, 33)
        Me.lblDash2.TabIndex = 11
        Me.lblDash2.Text = "-"
        '
        'lblDash3
        '
        Me.lblDash3.AutoSize = True
        Me.lblDash3.BackColor = System.Drawing.Color.Transparent
        Me.lblDash3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDash3.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.lblDash3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblDash3.Location = New System.Drawing.Point(411, 269)
        Me.lblDash3.Margin = New System.Windows.Forms.Padding(3, 25, 25, 0)
        Me.lblDash3.Name = "lblDash3"
        Me.lblDash3.Size = New System.Drawing.Size(23, 33)
        Me.lblDash3.TabIndex = 12
        Me.lblDash3.Text = "-"
        '
        'lblAverageWeightResult
        '
        Me.lblAverageWeightResult.AutoSize = True
        Me.lblAverageWeightResult.BackColor = System.Drawing.Color.Transparent
        Me.lblAverageWeightResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAverageWeightResult.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.lblAverageWeightResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblAverageWeightResult.Location = New System.Drawing.Point(468, 153)
        Me.lblAverageWeightResult.Margin = New System.Windows.Forms.Padding(3, 25, 25, 0)
        Me.lblAverageWeightResult.Name = "lblAverageWeightResult"
        Me.lblAverageWeightResult.Size = New System.Drawing.Size(260, 33)
        Me.lblAverageWeightResult.TabIndex = 13
        Me.lblAverageWeightResult.Text = "$AverageWeight $Unit"
        '
        'lblHighestWeightResult
        '
        Me.lblHighestWeightResult.AutoSize = True
        Me.lblHighestWeightResult.BackColor = System.Drawing.Color.Transparent
        Me.lblHighestWeightResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHighestWeightResult.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.lblHighestWeightResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblHighestWeightResult.Location = New System.Drawing.Point(468, 211)
        Me.lblHighestWeightResult.Margin = New System.Windows.Forms.Padding(3, 25, 25, 0)
        Me.lblHighestWeightResult.Name = "lblHighestWeightResult"
        Me.lblHighestWeightResult.Size = New System.Drawing.Size(255, 33)
        Me.lblHighestWeightResult.TabIndex = 14
        Me.lblHighestWeightResult.Text = "$HighestWeight $Unit"
        '
        'lblLowestWeightResult
        '
        Me.lblLowestWeightResult.AutoSize = True
        Me.lblLowestWeightResult.BackColor = System.Drawing.Color.Transparent
        Me.lblLowestWeightResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLowestWeightResult.Font = New System.Drawing.Font("Calibri Light", 20.0!)
        Me.lblLowestWeightResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblLowestWeightResult.Location = New System.Drawing.Point(468, 269)
        Me.lblLowestWeightResult.Margin = New System.Windows.Forms.Padding(3, 25, 25, 0)
        Me.lblLowestWeightResult.Name = "lblLowestWeightResult"
        Me.lblLowestWeightResult.Size = New System.Drawing.Size(249, 33)
        Me.lblLowestWeightResult.TabIndex = 15
        Me.lblLowestWeightResult.Text = "$LowestWeight $Unit"
        '
        'btnMetric
        '
        Me.btnMetric.BackgroundImage = CType(resources.GetObject("btnMetric.BackgroundImage"), System.Drawing.Image)
        Me.btnMetric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMetric.FlatAppearance.BorderSize = 0
        Me.btnMetric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMetric.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnMetric.ForeColor = System.Drawing.Color.White
        Me.btnMetric.Location = New System.Drawing.Point(586, 34)
        Me.btnMetric.Margin = New System.Windows.Forms.Padding(3, 25, 20, 3)
        Me.btnMetric.Name = "btnMetric"
        Me.btnMetric.Size = New System.Drawing.Size(185, 45)
        Me.btnMetric.TabIndex = 16
        Me.btnMetric.Tag = "0"
        Me.btnMetric.Text = "TO METRIC"
        Me.btnMetric.UseVisualStyleBackColor = True
        Me.btnMetric.Visible = False
        '
        'btnImperial
        '
        Me.btnImperial.BackgroundImage = CType(resources.GetObject("btnImperial.BackgroundImage"), System.Drawing.Image)
        Me.btnImperial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnImperial.FlatAppearance.BorderSize = 0
        Me.btnImperial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImperial.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnImperial.ForeColor = System.Drawing.Color.White
        Me.btnImperial.Location = New System.Drawing.Point(586, 34)
        Me.btnImperial.Margin = New System.Windows.Forms.Padding(3, 25, 20, 3)
        Me.btnImperial.Name = "btnImperial"
        Me.btnImperial.Size = New System.Drawing.Size(185, 45)
        Me.btnImperial.TabIndex = 17
        Me.btnImperial.Tag = "0"
        Me.btnImperial.Text = "TO IMPERIAL"
        Me.btnImperial.UseVisualStyleBackColor = True
        '
        'FormReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnImperial)
        Me.Controls.Add(Me.btnMetric)
        Me.Controls.Add(Me.lblLowestWeightResult)
        Me.Controls.Add(Me.lblHighestWeightResult)
        Me.Controls.Add(Me.lblAverageWeightResult)
        Me.Controls.Add(Me.lblDash3)
        Me.Controls.Add(Me.lblDash2)
        Me.Controls.Add(Me.lblDash1)
        Me.Controls.Add(Me.lblLowestWeight)
        Me.Controls.Add(Me.lblHighestWeight)
        Me.Controls.Add(Me.lblAverageWeight)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.picBackground)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormReports"
        Me.Text = "BMI Calculator"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAverageWeight As Label
    Friend WithEvents lblHighestWeight As Label
    Friend WithEvents lblLowestWeight As Label
    Friend WithEvents lblDash1 As Label
    Friend WithEvents lblDash2 As Label
    Friend WithEvents lblDash3 As Label
    Friend WithEvents lblAverageWeightResult As Label
    Friend WithEvents lblHighestWeightResult As Label
    Friend WithEvents lblLowestWeightResult As Label
    Friend WithEvents btnMetric As Button
    Friend WithEvents btnImperial As Button
End Class
