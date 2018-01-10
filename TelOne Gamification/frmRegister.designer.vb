<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtforename = New DevExpress.XtraEditors.TextEdit()
        Me.txtsurname = New DevExpress.XtraEditors.TextEdit()
        Me.txtUsername = New DevExpress.XtraEditors.TextEdit()
        Me.Email_addressTextBox = New DevExpress.XtraEditors.TextEdit()
        Me.txtphonenumber = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabNavigationPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtforename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsurname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Email_addressTextBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtphonenumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabNavigationPage1)
        Me.TabPane1.Location = New System.Drawing.Point(0, 3)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabNavigationPage1})
        Me.TabPane1.RegularSize = New System.Drawing.Size(512, 495)
        Me.TabPane1.SelectedPage = Me.TabNavigationPage1
        Me.TabPane1.Size = New System.Drawing.Size(512, 495)
        Me.TabPane1.TabIndex = 274
        Me.TabPane1.Text = "TabPane1"
        '
        'TabNavigationPage1
        '
        Me.TabNavigationPage1.Caption = "REGISTRATION DETAILS"
        Me.TabNavigationPage1.Controls.Add(Me.PictureBox1)
        Me.TabNavigationPage1.Controls.Add(Me.groupBox1)
        Me.TabNavigationPage1.Name = "TabNavigationPage1"
        Me.TabNavigationPage1.Size = New System.Drawing.Size(490, 439)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TelOne_Gamification.My.Resources.Resources.reg
        Me.PictureBox1.Location = New System.Drawing.Point(-11, 307)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(565, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 326
        Me.PictureBox1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.ComboBoxEdit1)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.TextBox1)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.SimpleButton3)
        Me.groupBox1.Controls.Add(Me.SimpleButton1)
        Me.groupBox1.Controls.Add(Me.txtforename)
        Me.groupBox1.Controls.Add(Me.txtsurname)
        Me.groupBox1.Controls.Add(Me.txtUsername)
        Me.groupBox1.Controls.Add(Me.Email_addressTextBox)
        Me.groupBox1.Controls.Add(Me.txtphonenumber)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.txtPassword)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(12, 14)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(460, 277)
        Me.groupBox1.TabIndex = 2
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "User Details"
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "CLIENT"
        Me.ComboBoxEdit1.Enabled = False
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(200, 20)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.ComboBoxEdit1.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseFont = True
        Me.ComboBoxEdit1.Properties.Mask.BeepOnError = True
        Me.ComboBoxEdit1.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.ComboBoxEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(222, 24)
        Me.ComboBoxEdit1.TabIndex = 144
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "User Group"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightGray
        Me.TextBox1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(222, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 18)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Confirm Password"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton3.ImageOptions.Image = CType(resources.GetObject("SimpleButton3.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(353, 229)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(84, 42)
        Me.SimpleButton3.TabIndex = 7
        Me.SimpleButton3.Text = "&Clear"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(200, 229)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(132, 42)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "&Register"
        '
        'txtforename
        '
        Me.txtforename.Location = New System.Drawing.Point(200, 179)
        Me.txtforename.Name = "txtforename"
        Me.txtforename.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtforename.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtforename.Properties.Appearance.Options.UseBackColor = True
        Me.txtforename.Properties.Appearance.Options.UseFont = True
        Me.txtforename.Properties.Mask.BeepOnError = True
        Me.txtforename.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtforename.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtforename.Properties.Mask.ShowPlaceHolders = False
        Me.txtforename.Size = New System.Drawing.Size(222, 24)
        Me.txtforename.TabIndex = 5
        '
        'txtsurname
        '
        Me.txtsurname.Location = New System.Drawing.Point(200, 153)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtsurname.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsurname.Properties.Appearance.Options.UseBackColor = True
        Me.txtsurname.Properties.Appearance.Options.UseFont = True
        Me.txtsurname.Properties.Mask.BeepOnError = True
        Me.txtsurname.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*)* "
        Me.txtsurname.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtsurname.Properties.Mask.ShowPlaceHolders = False
        Me.txtsurname.Size = New System.Drawing.Size(222, 24)
        Me.txtsurname.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(200, 47)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtUsername.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Properties.Appearance.Options.UseBackColor = True
        Me.txtUsername.Properties.Appearance.Options.UseFont = True
        Me.txtUsername.Properties.Mask.BeepOnError = True
        Me.txtUsername.Properties.Mask.EditMask = "\d\d\d\d\d\d\d\d\d"
        Me.txtUsername.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtUsername.Size = New System.Drawing.Size(222, 24)
        Me.txtUsername.TabIndex = 0
        '
        'Email_addressTextBox
        '
        Me.Email_addressTextBox.Location = New System.Drawing.Point(200, 127)
        Me.Email_addressTextBox.Name = "Email_addressTextBox"
        Me.Email_addressTextBox.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Email_addressTextBox.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_addressTextBox.Properties.Appearance.Options.UseBackColor = True
        Me.Email_addressTextBox.Properties.Appearance.Options.UseFont = True
        Me.Email_addressTextBox.Properties.Mask.BeepOnError = True
        Me.Email_addressTextBox.Properties.Mask.EditMask = "[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"
        Me.Email_addressTextBox.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.Email_addressTextBox.Size = New System.Drawing.Size(222, 24)
        Me.Email_addressTextBox.TabIndex = 3
        '
        'txtphonenumber
        '
        Me.txtphonenumber.Location = New System.Drawing.Point(200, 205)
        Me.txtphonenumber.Name = "txtphonenumber"
        Me.txtphonenumber.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.txtphonenumber.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphonenumber.Properties.Appearance.Options.UseBackColor = True
        Me.txtphonenumber.Properties.Appearance.Options.UseFont = True
        Me.txtphonenumber.Properties.Mask.BeepOnError = True
        Me.txtphonenumber.Properties.Mask.EditMask = "+263700000000"
        Me.txtphonenumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtphonenumber.Size = New System.Drawing.Size(222, 24)
        Me.txtphonenumber.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 18)
        Me.Label8.TabIndex = 138
        Me.Label8.Text = "Cell Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 136
        Me.Label7.Text = "First Name(s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Email"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.LightGray
        Me.txtPassword.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(200, 73)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(222, 26)
        Me.txtPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TelOne Number"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(926, 3)
        Me.Panel3.TabIndex = 325
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TelOne_Gamification.My.Resources.Resources.telone_2
        Me.PictureBox2.Location = New System.Drawing.Point(518, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(422, 364)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 327
        Me.PictureBox2.TabStop = False
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 435)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabPane1)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelOne Gamification ( Point Badges and Leaderboards )"
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabNavigationPage1.ResumeLayout(False)
        Me.TabNavigationPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtforename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsurname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Email_addressTextBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtphonenumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents Label2 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents txtPassword As TextBox
    Private WithEvents Label8 As Label
    Private WithEvents Label7 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents Email_addressTextBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtphonenumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtforename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtsurname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents TextBox1 As TextBox
    Private WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents Label1 As Label
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
