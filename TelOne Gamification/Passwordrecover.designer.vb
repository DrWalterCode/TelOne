<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passwordrecover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Passwordrecover))
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
        Me.label7 = New System.Windows.Forms.Label()
        Me.t1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.txtCell = New DevExpress.XtraEditors.TextEdit()
        Me.SerialPort1 = New System.IO.Ports.SerialPort()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        CType(Me.txtCell.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.label7.Location = New System.Drawing.Point(22, 35)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(251, 17)
        Me.label7.TabIndex = 38
        Me.label7.Text = "Enter cellnumber  to recover password"
        '
        't1
        '
        Me.t1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.t1.Appearance.Options.UseBackColor = True
        Me.t1.BarAnimationElementThickness = 2
        Me.t1.Caption = ""
        Me.t1.Description = ""
        Me.t1.Location = New System.Drawing.Point(14, 15)
        Me.t1.Margin = New System.Windows.Forms.Padding(4)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(268, 16)
        Me.t1.TabIndex = 378
        Me.t1.Text = "ProgressPanel1"
        Me.t1.Visible = False
        Me.t1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'txtCell
        '
        Me.txtCell.Location = New System.Drawing.Point(13, 55)
        Me.txtCell.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCell.Name = "txtCell"
        Me.txtCell.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCell.Properties.Appearance.Options.UseBackColor = True
        Me.txtCell.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtCell.Properties.Mask.BeepOnError = True
        Me.txtCell.Properties.Mask.EditMask = "+263700000000"
        Me.txtCell.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCell.Size = New System.Drawing.Size(269, 22)
        Me.txtCell.TabIndex = 380
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(440, 31)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(150, 46)
        Me.SimpleButton1.TabIndex = 39
        Me.SimpleButton1.TabStop = False
        Me.SimpleButton1.Text = "Recover"
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
        Me.TileControl1.Location = New System.Drawing.Point(3, 94)
        Me.TileControl1.MaxId = 1
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(553, 289)
        Me.TileControl1.TabIndex = 381
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.TileItem1)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'TileItem1
        '
        Me.TileItem1.CurrentFrameIndex = 3
        TileItemElement1.Image = Global.TelOne_Gamification.My.Resources.Resources.telone_satellite
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
        'Passwordrecover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 366)
        Me.Controls.Add(Me.txtCell)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Passwordrecover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelOne Gamification ( Point Badges and Leaderboards )"
        CType(Me.txtCell.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents label7 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents t1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents txtCell As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
End Class
