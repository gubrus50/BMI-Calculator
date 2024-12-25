<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.lblFooter = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelForm = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.panelFooter.SuspendLayout()
        Me.panelForm.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(530, 360)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(271, 92)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "REGISTER NOW"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'panelFooter
        '
        Me.panelFooter.Controls.Add(Me.lblFooter)
        Me.panelFooter.Location = New System.Drawing.Point(0, 360)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(530, 92)
        Me.panelFooter.TabIndex = 2
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
        Me.lblFooter.Size = New System.Drawing.Size(240, 29)
        Me.lblFooter.TabIndex = 3
        Me.lblFooter.Text = "Don't have an Account?"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(366, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(84, 33)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "LOGIN"
        '
        'panelForm
        '
        Me.panelForm.BackColor = System.Drawing.Color.White
        Me.panelForm.Controls.Add(Me.Panel3)
        Me.panelForm.Controls.Add(Me.lblPassword)
        Me.panelForm.Controls.Add(Me.Panel1)
        Me.panelForm.Controls.Add(Me.lblUsername)
        Me.panelForm.Location = New System.Drawing.Point(208, 110)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(400, 165)
        Me.panelForm.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(176, 80)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(186, 31)
        Me.Panel3.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.txtPassword)
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 29)
        Me.Panel4.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(14, 6)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(165, 18)
        Me.txtPassword.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPassword.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(98, 87)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 18)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(176, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 31)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Location = New System.Drawing.Point(1, 1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 29)
        Me.Panel2.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(14, 6)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(5, 6, 6, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(165, 18)
        Me.txtUsername.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsername.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(94, 39)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(71, 18)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Username"
        '
        'btnLogin
        '
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.75!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(384, 249)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(185, 45)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Tag = "0"
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'picBackground
        '
        Me.picBackground.Image = Global.bmi_calculator.My.Resources.Resources.nunny
        Me.picBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(801, 452)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 0
        Me.picBackground.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.picBackground)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "FormLogin"
        Me.Text = "BMI Calculator"
        Me.panelFooter.ResumeLayout(False)
        Me.panelFooter.PerformLayout()
        Me.panelForm.ResumeLayout(False)
        Me.panelForm.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents panelFooter As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelForm As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
End Class
