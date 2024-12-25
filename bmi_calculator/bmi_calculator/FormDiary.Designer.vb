<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDiary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDiary))
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnMyRecordsTop = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblRecordsTitle = New System.Windows.Forms.Label()
        Me.panTextTitle = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.lblRecordContent = New System.Windows.Forms.Label()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.btnReadRecord = New System.Windows.Forms.Button()
        Me.panMainOptions = New System.Windows.Forms.Panel()
        Me.btnDropRecord = New System.Windows.Forms.Button()
        Me.btnEditRecord = New System.Windows.Forms.Button()
        Me.btnMyRecordsBottom = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.cmbRecords = New System.Windows.Forms.ComboBox()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTextTitle.SuspendLayout()
        Me.panMainOptions.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnReturn.TabIndex = 6
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
        Me.lblTitle.Size = New System.Drawing.Size(185, 35)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "DIARY ENTRY"
        '
        'btnMyRecordsTop
        '
        Me.btnMyRecordsTop.BackgroundImage = CType(resources.GetObject("btnMyRecordsTop.BackgroundImage"), System.Drawing.Image)
        Me.btnMyRecordsTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMyRecordsTop.FlatAppearance.BorderSize = 0
        Me.btnMyRecordsTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyRecordsTop.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnMyRecordsTop.ForeColor = System.Drawing.Color.White
        Me.btnMyRecordsTop.Location = New System.Drawing.Point(586, 34)
        Me.btnMyRecordsTop.Margin = New System.Windows.Forms.Padding(3, 25, 20, 3)
        Me.btnMyRecordsTop.Name = "btnMyRecordsTop"
        Me.btnMyRecordsTop.Size = New System.Drawing.Size(185, 45)
        Me.btnMyRecordsTop.TabIndex = 18
        Me.btnMyRecordsTop.Tag = "0"
        Me.btnMyRecordsTop.Text = "MY RECORDS"
        Me.btnMyRecordsTop.UseVisualStyleBackColor = True
        Me.btnMyRecordsTop.Visible = False
        '
        'picBackground
        '
        Me.picBackground.Image = Global.bmi_calculator.My.Resources.Resources.nunnyDimmer
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(801, 452)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 5
        Me.picBackground.TabStop = False
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubTitle.Font = New System.Drawing.Font("Calibri Light", 16.0!)
        Me.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblSubTitle.Location = New System.Drawing.Point(110, 107)
        Me.lblSubTitle.Margin = New System.Windows.Forms.Padding(3, 45, 3, 0)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(117, 27)
        Me.lblSubTitle.TabIndex = 21
        Me.lblSubTitle.Text = "My Records"
        '
        'lblRecordsTitle
        '
        Me.lblRecordsTitle.AutoSize = True
        Me.lblRecordsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblRecordsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRecordsTitle.Font = New System.Drawing.Font("Calibri Light", 16.0!)
        Me.lblRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblRecordsTitle.Location = New System.Drawing.Point(580, 107)
        Me.lblRecordsTitle.Margin = New System.Windows.Forms.Padding(3, 45, 3, 0)
        Me.lblRecordsTitle.Name = "lblRecordsTitle"
        Me.lblRecordsTitle.Size = New System.Drawing.Size(51, 27)
        Me.lblRecordsTitle.TabIndex = 22
        Me.lblRecordsTitle.Text = "Title"
        Me.lblRecordsTitle.Visible = False
        '
        'panTextTitle
        '
        Me.panTextTitle.BackColor = System.Drawing.Color.White
        Me.panTextTitle.Controls.Add(Me.txtTitle)
        Me.panTextTitle.Location = New System.Drawing.Point(586, 142)
        Me.panTextTitle.Margin = New System.Windows.Forms.Padding(1, 8, 1, 1)
        Me.panTextTitle.Name = "panTextTitle"
        Me.panTextTitle.Size = New System.Drawing.Size(184, 29)
        Me.panTextTitle.TabIndex = 23
        Me.panTextTitle.Visible = False
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(14, 6)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(165, 18)
        Me.txtTitle.TabIndex = 0
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackgroundImage = CType(resources.GetObject("btnAddRecord.BackgroundImage"), System.Drawing.Image)
        Me.btnAddRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddRecord.FlatAppearance.BorderSize = 0
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnAddRecord.ForeColor = System.Drawing.Color.White
        Me.btnAddRecord.Location = New System.Drawing.Point(586, 183)
        Me.btnAddRecord.Margin = New System.Windows.Forms.Padding(3, 25, 20, 3)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(185, 45)
        Me.btnAddRecord.TabIndex = 25
        Me.btnAddRecord.Tag = "0"
        Me.btnAddRecord.Text = "ADD"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        Me.btnAddRecord.Visible = False
        '
        'lblRecordContent
        '
        Me.lblRecordContent.AutoSize = True
        Me.lblRecordContent.BackColor = System.Drawing.Color.Transparent
        Me.lblRecordContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRecordContent.Font = New System.Drawing.Font("Calibri Light", 13.0!)
        Me.lblRecordContent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.lblRecordContent.Location = New System.Drawing.Point(139, 160)
        Me.lblRecordContent.Margin = New System.Windows.Forms.Padding(3, 45, 3, 0)
        Me.lblRecordContent.MaximumSize = New System.Drawing.Size(647, 0)
        Me.lblRecordContent.Name = "lblRecordContent"
        Me.lblRecordContent.Size = New System.Drawing.Size(128, 22)
        Me.lblRecordContent.TabIndex = 25
        Me.lblRecordContent.Text = "$RecordContent"
        Me.lblRecordContent.Visible = False
        '
        'txtContent
        '
        Me.txtContent.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.txtContent.Location = New System.Drawing.Point(115, 142)
        Me.txtContent.MaxLength = 2000
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContent.Size = New System.Drawing.Size(433, 211)
        Me.txtContent.TabIndex = 26
        Me.txtContent.Visible = False
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.BackgroundImage = CType(resources.GetObject("btnSaveRecord.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveRecord.FlatAppearance.BorderSize = 0
        Me.btnSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRecord.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnSaveRecord.ForeColor = System.Drawing.Color.White
        Me.btnSaveRecord.Location = New System.Drawing.Point(586, 183)
        Me.btnSaveRecord.Margin = New System.Windows.Forms.Padding(3, 25, 20, 3)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(185, 45)
        Me.btnSaveRecord.TabIndex = 27
        Me.btnSaveRecord.Tag = "0"
        Me.btnSaveRecord.Text = "SAVE"
        Me.btnSaveRecord.UseVisualStyleBackColor = True
        Me.btnSaveRecord.Visible = False
        '
        'btnReadRecord
        '
        Me.btnReadRecord.BackColor = System.Drawing.SystemColors.Control
        Me.btnReadRecord.BackgroundImage = CType(resources.GetObject("btnReadRecord.BackgroundImage"), System.Drawing.Image)
        Me.btnReadRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReadRecord.FlatAppearance.BorderSize = 0
        Me.btnReadRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReadRecord.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnReadRecord.ForeColor = System.Drawing.Color.White
        Me.btnReadRecord.Location = New System.Drawing.Point(1, 0)
        Me.btnReadRecord.Margin = New System.Windows.Forms.Padding(3, 25, 20, 3)
        Me.btnReadRecord.Name = "btnReadRecord"
        Me.btnReadRecord.Size = New System.Drawing.Size(185, 45)
        Me.btnReadRecord.TabIndex = 29
        Me.btnReadRecord.Tag = "0"
        Me.btnReadRecord.Text = "READ"
        Me.btnReadRecord.UseVisualStyleBackColor = False
        '
        'panMainOptions
        '
        Me.panMainOptions.BackColor = System.Drawing.Color.Transparent
        Me.panMainOptions.Controls.Add(Me.btnDropRecord)
        Me.panMainOptions.Controls.Add(Me.btnReadRecord)
        Me.panMainOptions.Controls.Add(Me.btnEditRecord)
        Me.panMainOptions.Location = New System.Drawing.Point(585, 142)
        Me.panMainOptions.Name = "panMainOptions"
        Me.panMainOptions.Size = New System.Drawing.Size(187, 154)
        Me.panMainOptions.TabIndex = 30
        '
        'btnDropRecord
        '
        Me.btnDropRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDropRecord.FlatAppearance.BorderSize = 0
        Me.btnDropRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDropRecord.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnDropRecord.Location = New System.Drawing.Point(1, 108)
        Me.btnDropRecord.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDropRecord.Name = "btnDropRecord"
        Me.btnDropRecord.Size = New System.Drawing.Size(185, 45)
        Me.btnDropRecord.TabIndex = 30
        Me.btnDropRecord.Text = "DROP"
        Me.btnDropRecord.UseVisualStyleBackColor = False
        '
        'btnEditRecord
        '
        Me.btnEditRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditRecord.FlatAppearance.BorderSize = 0
        Me.btnEditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRecord.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnEditRecord.Location = New System.Drawing.Point(1, 54)
        Me.btnEditRecord.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEditRecord.Name = "btnEditRecord"
        Me.btnEditRecord.Size = New System.Drawing.Size(185, 45)
        Me.btnEditRecord.TabIndex = 29
        Me.btnEditRecord.Text = "EDIT"
        Me.btnEditRecord.UseVisualStyleBackColor = False
        '
        'btnMyRecordsBottom
        '
        Me.btnMyRecordsBottom.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnMyRecordsBottom.FlatAppearance.BorderSize = 0
        Me.btnMyRecordsBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyRecordsBottom.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnMyRecordsBottom.Location = New System.Drawing.Point(115, 364)
        Me.btnMyRecordsBottom.Margin = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.btnMyRecordsBottom.Name = "btnMyRecordsBottom"
        Me.btnMyRecordsBottom.Size = New System.Drawing.Size(433, 45)
        Me.btnMyRecordsBottom.TabIndex = 31
        Me.btnMyRecordsBottom.Text = "MY RECORDS"
        Me.btnMyRecordsBottom.UseVisualStyleBackColor = False
        Me.btnMyRecordsBottom.Visible = False
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNewRecord.FlatAppearance.BorderSize = 0
        Me.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRecord.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnNewRecord.Location = New System.Drawing.Point(115, 364)
        Me.btnNewRecord.Margin = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(433, 45)
        Me.btnNewRecord.TabIndex = 32
        Me.btnNewRecord.Text = "NEW RECORD"
        Me.btnNewRecord.UseVisualStyleBackColor = False
        '
        'cmbRecords
        '
        Me.cmbRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbRecords.FormattingEnabled = True
        Me.cmbRecords.Location = New System.Drawing.Point(115, 142)
        Me.cmbRecords.Name = "cmbRecords"
        Me.cmbRecords.Size = New System.Drawing.Size(433, 215)
        Me.cmbRecords.TabIndex = 33
        '
        'FormDiary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbRecords)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.btnMyRecordsBottom)
        Me.Controls.Add(Me.panMainOptions)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.panTextTitle)
        Me.Controls.Add(Me.lblRecordsTitle)
        Me.Controls.Add(Me.lblRecordContent)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.btnMyRecordsTop)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.picBackground)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormDiary"
        Me.Text = "BMI Calculator"
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTextTitle.ResumeLayout(False)
        Me.panTextTitle.PerformLayout()
        Me.panMainOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnMyRecordsTop As Button
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblRecordsTitle As Label
    Friend WithEvents panTextTitle As Panel
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents lblRecordContent As Label
    Friend WithEvents txtContent As TextBox
    Friend WithEvents btnSaveRecord As Button
    Friend WithEvents btnReadRecord As Button
    Friend WithEvents panMainOptions As Panel
    Friend WithEvents btnDropRecord As Button
    Friend WithEvents btnEditRecord As Button
    Friend WithEvents btnMyRecordsBottom As Button
    Friend WithEvents btnNewRecord As Button
    Friend WithEvents cmbRecords As ComboBox
End Class
