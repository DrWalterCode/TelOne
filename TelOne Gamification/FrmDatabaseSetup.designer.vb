<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatabaseSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatabaseSetup))
        Dim TileItemElement13 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame11 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement14 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame12 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement15 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame13 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement16 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame14 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement17 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame15 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement18 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.groupBox11 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtport = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cbodatabase = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New DevExpress.XtraEditors.TextEdit()
        Me.txthost = New DevExpress.XtraEditors.TextEdit()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label37 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.groupBox11.SuspendLayout()
        CType(Me.txtport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbodatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txthost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox11
        '
        Me.groupBox11.Controls.Add(Me.SimpleButton2)
        Me.groupBox11.Controls.Add(Me.txtport)
        Me.groupBox11.Controls.Add(Me.Label3)
        Me.groupBox11.Controls.Add(Me.SimpleButton1)
        Me.groupBox11.Controls.Add(Me.cbodatabase)
        Me.groupBox11.Controls.Add(Me.txtpassword)
        Me.groupBox11.Controls.Add(Me.Label1)
        Me.groupBox11.Controls.Add(Me.Label2)
        Me.groupBox11.Controls.Add(Me.txtuser)
        Me.groupBox11.Controls.Add(Me.txthost)
        Me.groupBox11.Controls.Add(Me.label38)
        Me.groupBox11.Controls.Add(Me.label37)
        Me.groupBox11.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox11.Location = New System.Drawing.Point(12, 12)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(359, 278)
        Me.groupBox11.TabIndex = 15
        Me.groupBox11.TabStop = False
        Me.groupBox11.Text = "Connection Details"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(222, 176)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(107, 29)
        Me.SimpleButton2.TabIndex = 28
        Me.SimpleButton2.TabStop = False
        Me.SimpleButton2.Text = "&Exit"
        '
        'txtport
        '
        Me.txtport.EditValue = "3306"
        Me.txtport.Location = New System.Drawing.Point(124, 29)
        Me.txtport.Name = "txtport"
        Me.txtport.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtport.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtport.Properties.Appearance.Options.UseBackColor = True
        Me.txtport.Properties.Appearance.Options.UseFont = True
        Me.txtport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtport.Properties.Mask.BeepOnError = True
        Me.txtport.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtport.Properties.Mask.ShowPlaceHolders = False
        Me.txtport.Size = New System.Drawing.Size(205, 24)
        Me.txtport.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 18)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Port"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(107, 176)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 29)
        Me.SimpleButton1.TabIndex = 25
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "&Save"
        '
        'cbodatabase
        '
        Me.cbodatabase.Location = New System.Drawing.Point(125, 137)
        Me.cbodatabase.Name = "cbodatabase"
        Me.cbodatabase.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbodatabase.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodatabase.Properties.Appearance.Options.UseBackColor = True
        Me.cbodatabase.Properties.Appearance.Options.UseFont = True
        Me.cbodatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbodatabase.Properties.Sorted = True
        Me.cbodatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbodatabase.Size = New System.Drawing.Size(205, 24)
        Me.cbodatabase.TabIndex = 23
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(125, 111)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtpassword.Properties.Appearance.Options.UseFont = True
        Me.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtpassword.Properties.Mask.BeepOnError = True
        Me.txtpassword.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtpassword.Properties.Mask.ShowPlaceHolders = False
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(205, 24)
        Me.txtpassword.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(125, 83)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtuser.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Properties.Appearance.Options.UseBackColor = True
        Me.txtuser.Properties.Appearance.Options.UseFont = True
        Me.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtuser.Properties.Mask.BeepOnError = True
        Me.txtuser.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtuser.Properties.Mask.ShowPlaceHolders = False
        Me.txtuser.Size = New System.Drawing.Size(205, 24)
        Me.txtuser.TabIndex = 1
        '
        'txthost
        '
        Me.txthost.Location = New System.Drawing.Point(124, 56)
        Me.txthost.Name = "txthost"
        Me.txthost.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txthost.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthost.Properties.Appearance.Options.UseBackColor = True
        Me.txthost.Properties.Appearance.Options.UseFont = True
        Me.txthost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txthost.Properties.Mask.BeepOnError = True
        Me.txthost.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txthost.Properties.Mask.ShowPlaceHolders = False
        Me.txthost.Size = New System.Drawing.Size(205, 24)
        Me.txthost.TabIndex = 0
        '
        'label38
        '
        Me.label38.AutoSize = True
        Me.label38.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label38.Location = New System.Drawing.Point(7, 86)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(36, 18)
        Me.label38.TabIndex = 17
        Me.label38.Text = "User"
        '
        'label37
        '
        Me.label37.AutoSize = True
        Me.label37.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label37.Location = New System.Drawing.Point(7, 59)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(37, 18)
        Me.label37.TabIndex = 15
        Me.label37.Text = "Host"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 4)
        Me.Panel1.TabIndex = 285
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceItem.Normal.BackColor = System.Drawing.Color.White
        Me.TileControl1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.TileControl1.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileControl1.AppearanceItem.Normal.Options.UseBorderColor = True
        Me.TileControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.ItemSize = 250
        Me.TileControl1.Location = New System.Drawing.Point(377, 3)
        Me.TileControl1.MaxId = 1
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(553, 289)
        Me.TileControl1.TabIndex = 329
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem1
        '
        Me.TileItem1.CurrentFrameIndex = 4
        TileItemElement13.Image = Global.TelOne_Gamification.My.Resources.Resources.voice_website_slider_new
        TileItemElement13.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement13.Text = "TileItem1"
        Me.TileItem1.Elements.Add(TileItemElement13)
        TileItemElement14.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_006
        TileItemElement14.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement14.Text = "TileItem1"
        TileItemFrame11.Elements.Add(TileItemElement14)
        TileItemFrame11.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_006
        TileItemElement15.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_008
        TileItemElement15.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement15.Text = "TileItem1"
        TileItemFrame12.Elements.Add(TileItemElement15)
        TileItemFrame12.Image = Global.TelOne_Gamification.My.Resources.Resources._071022_TelOneConvergenceDigitalAds_1785x560px_r03_page_008
        TileItemElement16.Image = Global.TelOne_Gamification.My.Resources.Resources._071060_TelOnePrepaidLady_Web1785x560
        TileItemElement16.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement16.Text = "TileItem1"
        TileItemFrame13.Elements.Add(TileItemElement16)
        TileItemFrame13.Image = Global.TelOne_Gamification.My.Resources.Resources._071060_TelOnePrepaidLady_Web1785x560
        TileItemElement17.Image = Global.TelOne_Gamification.My.Resources.Resources.telone_satellite
        TileItemElement17.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement17.Text = "TileItem1"
        TileItemFrame14.Elements.Add(TileItemElement17)
        TileItemFrame14.Image = Global.TelOne_Gamification.My.Resources.Resources.telone_satellite
        TileItemElement18.Image = Global.TelOne_Gamification.My.Resources.Resources.voice_website_slider_new
        TileItemElement18.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileItemElement18.Text = "TileItem1"
        TileItemFrame15.Elements.Add(TileItemElement18)
        TileItemFrame15.Image = Global.TelOne_Gamification.My.Resources.Resources.voice_website_slider_new
        Me.TileItem1.Frames.Add(TileItemFrame11)
        Me.TileItem1.Frames.Add(TileItemFrame12)
        Me.TileItem1.Frames.Add(TileItemFrame13)
        Me.TileItem1.Frames.Add(TileItemFrame14)
        Me.TileItem1.Frames.Add(TileItemFrame15)
        Me.TileItem1.Id = 0
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'FrmDatabaseSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(935, 302)
        Me.ControlBox = False
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.groupBox11)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDatabaseSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelOne Gamification ( Point Badges and Leaderboards )"
        Me.groupBox11.ResumeLayout(False)
        Me.groupBox11.PerformLayout()
        CType(Me.txtport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbodatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txthost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox11 As GroupBox
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents txtuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthost As DevExpress.XtraEditors.TextEdit
    Private WithEvents label38 As Label
    Private WithEvents label37 As Label
    Friend WithEvents cbodatabase As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtport As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
End Class
