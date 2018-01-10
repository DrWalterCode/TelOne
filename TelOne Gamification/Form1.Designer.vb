<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.CBNetInts = New System.Windows.Forms.ComboBox()
        Me.DatSent = New System.Windows.Forms.Label()
        Me.SpdLbl = New System.Windows.Forms.Label()
        Me.DatRcvd = New System.Windows.Forms.Label()
        Me.TmrStatus = New System.Windows.Forms.Timer(Me.components)
        Me.IPAddIn = New System.Windows.Forms.Label()
        Me.IPAddEx = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(442, 69)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(67, 17)
        Me.LblStatus.TabIndex = 0
        Me.LblStatus.Text = "LblStatus"
        '
        'CBNetInts
        '
        Me.CBNetInts.FormattingEnabled = True
        Me.CBNetInts.Location = New System.Drawing.Point(487, 119)
        Me.CBNetInts.Name = "CBNetInts"
        Me.CBNetInts.Size = New System.Drawing.Size(121, 24)
        Me.CBNetInts.TabIndex = 1
        '
        'DatSent
        '
        Me.DatSent.AutoSize = True
        Me.DatSent.Location = New System.Drawing.Point(617, 50)
        Me.DatSent.Name = "DatSent"
        Me.DatSent.Size = New System.Drawing.Size(59, 17)
        Me.DatSent.TabIndex = 2
        Me.DatSent.Text = "DatSent"
        '
        'SpdLbl
        '
        Me.SpdLbl.AutoSize = True
        Me.SpdLbl.Location = New System.Drawing.Point(747, 202)
        Me.SpdLbl.Name = "SpdLbl"
        Me.SpdLbl.Size = New System.Drawing.Size(52, 17)
        Me.SpdLbl.TabIndex = 3
        Me.SpdLbl.Text = "SpdLbl"
        '
        'DatRcvd
        '
        Me.DatRcvd.AutoSize = True
        Me.DatRcvd.Location = New System.Drawing.Point(483, 219)
        Me.DatRcvd.Name = "DatRcvd"
        Me.DatRcvd.Size = New System.Drawing.Size(62, 17)
        Me.DatRcvd.TabIndex = 4
        Me.DatRcvd.Text = "DatRcvd"
        '
        'TmrStatus
        '
        Me.TmrStatus.Enabled = True
        '
        'IPAddIn
        '
        Me.IPAddIn.AutoSize = True
        Me.IPAddIn.Location = New System.Drawing.Point(368, 157)
        Me.IPAddIn.Name = "IPAddIn"
        Me.IPAddIn.Size = New System.Drawing.Size(56, 17)
        Me.IPAddIn.TabIndex = 5
        Me.IPAddIn.Text = "IPAddIn"
        '
        'IPAddEx
        '
        Me.IPAddEx.AutoSize = True
        Me.IPAddEx.Location = New System.Drawing.Point(375, 217)
        Me.IPAddEx.Name = "IPAddEx"
        Me.IPAddEx.Size = New System.Drawing.Size(60, 17)
        Me.IPAddEx.TabIndex = 6
        Me.IPAddEx.Text = "IPAddEx"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 402)
        Me.Controls.Add(Me.IPAddEx)
        Me.Controls.Add(Me.IPAddIn)
        Me.Controls.Add(Me.DatRcvd)
        Me.Controls.Add(Me.SpdLbl)
        Me.Controls.Add(Me.DatSent)
        Me.Controls.Add(Me.CBNetInts)
        Me.Controls.Add(Me.LblStatus)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStatus As Label
    Friend WithEvents CBNetInts As ComboBox
    Friend WithEvents DatSent As Label
    Friend WithEvents SpdLbl As Label
    Friend WithEvents DatRcvd As Label
    Friend WithEvents TmrStatus As Timer
    Friend WithEvents IPAddIn As Label
    Friend WithEvents IPAddEx As Label
End Class
