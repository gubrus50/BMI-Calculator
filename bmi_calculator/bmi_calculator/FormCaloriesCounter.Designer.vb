<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaloriesCounter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCaloriesCounter))
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotalCalories = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.numCount = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbFood = New System.Windows.Forms.ComboBox()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBackground
        '
        Me.picBackground.Image = Global.bmi_calculator.My.Resources.Resources.nunnyDimmer
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(801, 452)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 4
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
        Me.btnReturn.TabIndex = 5
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
        Me.lblTitle.Size = New System.Drawing.Size(282, 35)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "CALORIES COUNTER"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalculate.FlatAppearance.BorderSize = 0
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(586, 149)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(3, 3, 20, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(185, 45)
        Me.btnCalculate.TabIndex = 18
        Me.btnCalculate.Tag = "0"
        Me.btnCalculate.Text = "CALCULATE"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotalCalories
        '
        Me.lblTotalCalories.AutoSize = True
        Me.lblTotalCalories.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCalories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalCalories.Font = New System.Drawing.Font("Calibri Light", 18.0!)
        Me.lblTotalCalories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblTotalCalories.Location = New System.Drawing.Point(109, 241)
        Me.lblTotalCalories.Margin = New System.Windows.Forms.Padding(3, 25, 3, 0)
        Me.lblTotalCalories.Name = "lblTotalCalories"
        Me.lblTotalCalories.Size = New System.Drawing.Size(172, 29)
        Me.lblTotalCalories.TabIndex = 19
        Me.lblTotalCalories.Text = "TOTAL CALORIES"
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.BackColor = System.Drawing.Color.Transparent
        Me.lblFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFood.Font = New System.Drawing.Font("Calibri Light", 16.0!)
        Me.lblFood.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblFood.Location = New System.Drawing.Point(110, 114)
        Me.lblFood.Margin = New System.Windows.Forms.Padding(3, 45, 3, 0)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(153, 27)
        Me.lblFood.TabIndex = 20
        Me.lblFood.Text = "Select food type"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCount.Font = New System.Drawing.Font("Calibri Light", 16.0!)
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblCount.Location = New System.Drawing.Point(343, 114)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(3, 45, 3, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(64, 27)
        Me.lblCount.TabIndex = 21
        Me.lblCount.Text = "Count"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResult.Font = New System.Drawing.Font("Calibri Light", 16.0!)
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(145, 305)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(40, 35, 3, 0)
        Me.lblResult.MaximumSize = New System.Drawing.Size(651, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(556, 27)
        Me.lblResult.TabIndex = 22
        Me.lblResult.Text = "$Count x $Food ($FoodCalories calories each) = $TotalCalories"
        Me.lblResult.Visible = False
        '
        'numCount
        '
        Me.numCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numCount.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.numCount.Location = New System.Drawing.Point(14, 4)
        Me.numCount.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.numCount.Maximum = New Decimal(New Integer() {-727379967, 232, 0, 0})
        Me.numCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCount.Name = "numCount"
        Me.numCount.Size = New System.Drawing.Size(104, 21)
        Me.numCount.TabIndex = 6
        Me.numCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.numCount)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(118, 29)
        Me.Panel4.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(348, 157)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(119, 31)
        Me.Panel3.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmbFood)
        Me.Panel1.Location = New System.Drawing.Point(115, 158)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(193, 29)
        Me.Panel1.TabIndex = 7
        '
        'cmbFood
        '
        Me.cmbFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFood.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.cmbFood.FormattingEnabled = True
        Me.cmbFood.Items.AddRange(New Object() {"Apple", "Banana", "Egg", "BurgerKing's Hamburger", "BurgerKing's Whopper"})
        Me.cmbFood.Location = New System.Drawing.Point(14, 1)
        Me.cmbFood.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.cmbFood.Name = "cmbFood"
        Me.cmbFood.Size = New System.Drawing.Size(179, 27)
        Me.cmbFood.TabIndex = 24
        '
        'FormCaloriesCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.lblTotalCalories)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.picBackground)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormCaloriesCounter"
        Me.Text = "BMI Calculator"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotalCalories As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents numCount As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbFood As ComboBox
End Class
