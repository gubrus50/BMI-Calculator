<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBMI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBMI))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpMeasurement = New System.Windows.Forms.GroupBox()
        Me.radImperial = New System.Windows.Forms.RadioButton()
        Me.radMetric = New System.Windows.Forms.RadioButton()
        Me.lblMeasurement = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.numWeight = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.numHeight = New System.Windows.Forms.NumericUpDown()
        Me.panNumerics = New System.Windows.Forms.Panel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.panResult = New System.Windows.Forms.Panel()
        Me.grpMeasurement.SuspendLayout()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panNumerics.SuspendLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(306, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(204, 33)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "BMI CALCULATOR"
        '
        'grpMeasurement
        '
        Me.grpMeasurement.BackColor = System.Drawing.Color.Transparent
        Me.grpMeasurement.Controls.Add(Me.radImperial)
        Me.grpMeasurement.Controls.Add(Me.radMetric)
        Me.grpMeasurement.Location = New System.Drawing.Point(98, 169)
        Me.grpMeasurement.Name = "grpMeasurement"
        Me.grpMeasurement.Size = New System.Drawing.Size(262, 122)
        Me.grpMeasurement.TabIndex = 1
        Me.grpMeasurement.TabStop = False
        '
        'radImperial
        '
        Me.radImperial.AutoSize = True
        Me.radImperial.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radImperial.ForeColor = System.Drawing.Color.White
        Me.radImperial.Location = New System.Drawing.Point(18, 68)
        Me.radImperial.Margin = New System.Windows.Forms.Padding(15, 5, 3, 10)
        Me.radImperial.Name = "radImperial"
        Me.radImperial.Size = New System.Drawing.Size(113, 32)
        Me.radImperial.TabIndex = 3
        Me.radImperial.TabStop = True
        Me.radImperial.Text = "Imperial"
        Me.radImperial.UseVisualStyleBackColor = True
        '
        'radMetric
        '
        Me.radMetric.AutoSize = True
        Me.radMetric.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMetric.ForeColor = System.Drawing.Color.White
        Me.radMetric.Location = New System.Drawing.Point(18, 26)
        Me.radMetric.Margin = New System.Windows.Forms.Padding(15, 10, 3, 5)
        Me.radMetric.Name = "radMetric"
        Me.radMetric.Size = New System.Drawing.Size(96, 32)
        Me.radMetric.TabIndex = 2
        Me.radMetric.TabStop = True
        Me.radMetric.Text = "Metric"
        Me.radMetric.UseVisualStyleBackColor = True
        '
        'lblMeasurement
        '
        Me.lblMeasurement.AutoSize = True
        Me.lblMeasurement.BackColor = System.Drawing.Color.Transparent
        Me.lblMeasurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMeasurement.Font = New System.Drawing.Font("Calibri Light", 16.0!)
        Me.lblMeasurement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblMeasurement.Location = New System.Drawing.Point(93, 126)
        Me.lblMeasurement.Margin = New System.Windows.Forms.Padding(3, 0, 3, 8)
        Me.lblMeasurement.Name = "lblMeasurement"
        Me.lblMeasurement.Size = New System.Drawing.Size(195, 27)
        Me.lblMeasurement.TabIndex = 7
        Me.lblMeasurement.Text = "Select Measurement"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblWeight.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblWeight.Location = New System.Drawing.Point(33, 7)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(3, 0, 3, 8)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(122, 29)
        Me.lblWeight.TabIndex = 8
        Me.lblWeight.Text = "Weight (Kg)"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.Transparent
        Me.lblHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHeight.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblHeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblHeight.Location = New System.Drawing.Point(35, 99)
        Me.lblHeight.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(117, 29)
        Me.lblHeight.TabIndex = 9
        Me.lblHeight.Text = "Height (Kg)"
        '
        'numWeight
        '
        Me.numWeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numWeight.DecimalPlaces = 5
        Me.numWeight.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.numWeight.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numWeight.Location = New System.Drawing.Point(14, 4)
        Me.numWeight.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.numWeight.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(170, 21)
        Me.numWeight.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 52)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 31)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.numWeight)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 29)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(0, 144)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(186, 31)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.numHeight)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 29)
        Me.Panel4.TabIndex = 0
        '
        'numHeight
        '
        Me.numHeight.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numHeight.DecimalPlaces = 5
        Me.numHeight.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.numHeight.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.numHeight.Location = New System.Drawing.Point(14, 4)
        Me.numHeight.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.numHeight.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.numHeight.Name = "numHeight"
        Me.numHeight.Size = New System.Drawing.Size(170, 21)
        Me.numHeight.TabIndex = 6
        '
        'panNumerics
        '
        Me.panNumerics.BackColor = System.Drawing.Color.Transparent
        Me.panNumerics.Controls.Add(Me.Panel1)
        Me.panNumerics.Controls.Add(Me.Panel3)
        Me.panNumerics.Controls.Add(Me.lblWeight)
        Me.panNumerics.Controls.Add(Me.lblHeight)
        Me.panNumerics.Location = New System.Drawing.Point(493, 116)
        Me.panNumerics.Name = "panNumerics"
        Me.panNumerics.Size = New System.Drawing.Size(187, 175)
        Me.panNumerics.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalculate.FlatAppearance.BorderSize = 0
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(494, 318)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(185, 45)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Tag = "0"
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'picBackground
        '
        Me.picBackground.Image = Global.bmi_calculator.My.Resources.Resources.nunnyDimmer
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(801, 452)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 2
        Me.picBackground.TabStop = False
        '
        'btnContinue
        '
        Me.btnContinue.BackgroundImage = CType(resources.GetObject("btnContinue.BackgroundImage"), System.Drawing.Image)
        Me.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnContinue.FlatAppearance.BorderSize = 0
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnContinue.ForeColor = System.Drawing.Color.White
        Me.btnContinue.Location = New System.Drawing.Point(315, 248)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(185, 45)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.Tag = "0"
        Me.btnContinue.Text = "CONTINUE"
        Me.btnContinue.UseVisualStyleBackColor = True
        Me.btnContinue.Visible = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResult.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(25, 7)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(174, 33)
        Me.lblResult.TabIndex = 17
        Me.lblResult.Text = "$ResultantBMI"
        '
        'panResult
        '
        Me.panResult.BackColor = System.Drawing.Color.Transparent
        Me.panResult.Controls.Add(Me.lblResult)
        Me.panResult.Location = New System.Drawing.Point(296, 185)
        Me.panResult.Name = "panResult"
        Me.panResult.Size = New System.Drawing.Size(224, 47)
        Me.panResult.TabIndex = 18
        Me.panResult.Visible = False
        '
        'FormBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panResult)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.panNumerics)
        Me.Controls.Add(Me.lblMeasurement)
        Me.Controls.Add(Me.grpMeasurement)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBackground)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormBMI"
        Me.Text = "BMI Calculator"
        Me.grpMeasurement.ResumeLayout(False)
        Me.grpMeasurement.PerformLayout()
        CType(Me.numWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.numHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panNumerics.ResumeLayout(False)
        Me.panNumerics.PerformLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panResult.ResumeLayout(False)
        Me.panResult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpMeasurement As GroupBox
    Friend WithEvents lblMeasurement As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents numWeight As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents numHeight As NumericUpDown
    Friend WithEvents radMetric As RadioButton
    Friend WithEvents radImperial As RadioButton
    Friend WithEvents panNumerics As Panel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnContinue As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents panResult As Panel
End Class
