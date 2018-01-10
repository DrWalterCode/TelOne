<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame1 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame2 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame3 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame4 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame5 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.Timer2 = New System.Windows.Forms.Timer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.MaskedTextBox()
        Me.lblerror = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(4, 65)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 311
        Me.Label7.Text = "Label6"
        '
        'Timer2
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1800, 19)
        Me.Panel2.TabIndex = 327
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TileControl1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.ItemSize = 400
        Me.TileControl1.Location = New System.Drawing.Point(7, 166)
        Me.TileControl1.MaxId = 1
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(884, 436)
        Me.TileControl1.TabIndex = 328
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(1100, 529)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 330
        Me.Label1.Text = "I Forgot My Password"
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Location = New System.Drawing.Point(1077, 181)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(246, 66)
        Me.ProgressPanel1.TabIndex = 331
        Me.ProgressPanel1.Text = "ProgressPanel1"
        Me.ProgressPanel1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TelOne_Gamification.My.Resources.Resources.reg
        Me.PictureBox1.Location = New System.Drawing.Point(917, 572)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(565, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 332
        Me.PictureBox1.TabStop = False
        '
        'TileItem1
        '
        Me.TileItem1.CurrentFrameIndex = 2
        TileItemElement1.Image = Global.TelOne_Gamification.My.Resources.Resources._071060_TelOnePrepaidLady_Web1785x560
        TileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement1.Text = "TileItem1"
        Me.TileItem1.Elements.Add(TileItemElement1)
        TileItemElement2.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_006
        TileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement2.Text = "TileItem1"
        TileItemFrame1.Elements.Add(TileItemElement2)
        TileItemFrame1.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_006
        TileItemElement3.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_008
        TileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement3.Text = "TileItem1"
        TileItemFrame2.Elements.Add(TileItemElement3)
        TileItemFrame2.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_008
        TileItemElement4.Image = Global.TelOne_Gamification.My.Resources.Resources._071060_TelOnePrepaidLady_Web1785x560
        TileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement4.Text = "TileItem1"
        TileItemFrame3.Elements.Add(TileItemElement4)
        TileItemFrame3.Image = Global.TelOne_Gamification.My.Resources.Resources._071060_TelOnePrepaidLady_Web1785x560
        TileItemElement5.Image = Global.TelOne_Gamification.My.Resources.Resources.telone_satellite
        TileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement5.Text = "TileItem1"
        TileItemFrame4.Elements.Add(TileItemElement5)
        TileItemFrame4.Image = Global.TelOne_Gamification.My.Resources.Resources.telone_satellite
        TileItemElement6.Image = Global.TelOne_Gamification.My.Resources.Resources.voice_website_slider_new
        TileItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement6.Text = "TileItem1"
        TileItemFrame5.Elements.Add(TileItemElement6)
        TileItemFrame5.Image = Global.TelOne_Gamification.My.Resources.Resources.voice_website_slider_new
        Me.TileItem1.Frames.Add(TileItemFrame1)
        Me.TileItem1.Frames.Add(TileItemFrame2)
        Me.TileItem1.Frames.Add(TileItemFrame3)
        Me.TileItem1.Frames.Add(TileItemFrame4)
        Me.TileItem1.Frames.Add(TileItemFrame5)
        Me.TileItem1.Id = 0
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = Global.TelOne_Gamification.My.Resources.Resources.top
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1800, 79)
        Me.Panel4.TabIndex = 326
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.TelOne_Gamification.My.Resources.Resources.login
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.txtpwd)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.lblerror)
        Me.Panel1.Location = New System.Drawing.Point(897, 263)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 250)
        Me.Panel1.TabIndex = 325
        '
        'txtpwd
        '
        Me.txtpwd.BackColor = System.Drawing.Color.White
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.ForeColor = System.Drawing.Color.Black
        Me.txtpwd.Location = New System.Drawing.Point(146, 181)
        Me.txtpwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(232, 23)
        Me.txtpwd.TabIndex = 303
        Me.txtpwd.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.BeepOnError = True
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Black
        Me.txtusername.Location = New System.Drawing.Point(146, 100)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(232, 23)
        Me.txtusername.TabIndex = 302
        '
        'lblerror
        '
        Me.lblerror.AutoSize = True
        Me.lblerror.BackColor = System.Drawing.Color.White
        Me.lblerror.Font = New System.Drawing.Font("Corbel", 9.75!)
        Me.lblerror.ForeColor = System.Drawing.Color.Gray
        Me.lblerror.Location = New System.Drawing.Point(147, 75)
        Me.lblerror.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblerror.Name = "lblerror"
        Me.lblerror.Size = New System.Drawing.Size(222, 21)
        Me.lblerror.TabIndex = 301
        Me.lblerror.Text = "Login Details not yet verified !! "
        Me.lblerror.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.LightGray
        Me.SimpleButton1.AppearanceHovered.Options.UseBackColor = True
        Me.SimpleButton1.AppearancePressed.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.White
        Me.SimpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.RoyalBlue
        Me.SimpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Black
        Me.SimpleButton1.AppearancePressed.Options.UseBackColor = True
        Me.SimpleButton1.AppearancePressed.Options.UseBorderColor = True
        Me.SimpleButton1.AppearancePressed.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(7, 105)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(160, 37)
        Me.SimpleButton1.TabIndex = 323
        Me.SimpleButton1.Text = "Exit Application"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1800, 897)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelOne Gamification ( Point Badges and Leaderboards )"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents lblerror As Label
    Friend WithEvents txtusername As MaskedTextBox
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
