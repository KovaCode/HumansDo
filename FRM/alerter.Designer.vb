<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alerter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alerter))
        Me.lblMess = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdErrDetails = New DevExpress.XtraEditors.SimpleButton()
        Me.layout2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.img = New DevExpress.XtraEditors.PictureEdit()
        Me.groupError = New System.Windows.Forms.GroupBox()
        Me.txtError = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupError.SuspendLayout()
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMess
        '
        Me.lblMess.AutoEllipsis = True
        Me.lblMess.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblMess.Location = New System.Drawing.Point(60, 34)
        Me.lblMess.Name = "lblMess"
        Me.lblMess.Size = New System.Drawing.Size(243, 39)
        Me.lblMess.TabIndex = 2
        Me.lblMess.Text = "ovo je poruka koja može biti i poduža tako da se i preklapa,a može biti i takova " & _
    "da se može staviti na kraju i upitnik?"
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Appearance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTitle.Location = New System.Drawing.Point(50, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(253, 16)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Ovo je naslov"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.Controls.Add(Me.cmdErrDetails)
        Me.PanelControl1.Controls.Add(Me.layout2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 113)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(310, 44)
        Me.PanelControl1.TabIndex = 6
        '
        'cmdErrDetails
        '
        Me.cmdErrDetails.Image = CType(resources.GetObject("cmdErrDetails.Image"), System.Drawing.Image)
        Me.cmdErrDetails.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.cmdErrDetails.Location = New System.Drawing.Point(12, 10)
        Me.cmdErrDetails.Name = "cmdErrDetails"
        Me.cmdErrDetails.Size = New System.Drawing.Size(73, 20)
        Me.cmdErrDetails.TabIndex = 13
        Me.cmdErrDetails.Text = "Detaljno"
        Me.cmdErrDetails.Visible = False
        '
        'layout2
        '
        Me.layout2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layout2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.layout2.BackColor = System.Drawing.Color.Transparent
        Me.layout2.Location = New System.Drawing.Point(208, 7)
        Me.layout2.Name = "layout2"
        Me.layout2.Size = New System.Drawing.Size(100, 29)
        Me.layout2.TabIndex = 12
        Me.layout2.WrapContents = False
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "SYSTEM ALERT CAUTION.png")
        Me.ImageCollection1.Images.SetKeyName(1, "SYSTEM ALERT NOTE ICON.png")
        Me.ImageCollection1.Images.SetKeyName(2, "SYSTEM ALERT NOTE.png")
        Me.ImageCollection1.Images.SetKeyName(3, "SYSTEM ALERT STOP.png")
        Me.ImageCollection1.Images.SetKeyName(4, "gears_animatedBWsmaller.gif")
        '
        'img
        '
        Me.img.EditValue = Global.HumansDo.My.Resources.Resources.SYSTEM_ALERT_NOTE1
        Me.img.Location = New System.Drawing.Point(12, 12)
        Me.img.Name = "img"
        Me.img.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img.Properties.Appearance.Options.UseBackColor = True
        Me.img.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.img.Size = New System.Drawing.Size(32, 33)
        Me.img.TabIndex = 9
        '
        'groupError
        '
        Me.groupError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupError.Controls.Add(Me.txtError)
        Me.groupError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupError.ForeColor = System.Drawing.Color.DarkRed
        Me.groupError.Location = New System.Drawing.Point(0, -6)
        Me.groupError.Name = "groupError"
        Me.groupError.Size = New System.Drawing.Size(310, 113)
        Me.groupError.TabIndex = 10
        Me.groupError.TabStop = False
        Me.groupError.Text = "SQL exception : erorr 1412"
        Me.groupError.Visible = False
        '
        'txtError
        '
        Me.txtError.EditValue = "Error occured in table ""Operateri"""
        Me.txtError.Location = New System.Drawing.Point(21, 19)
        Me.txtError.Name = "txtError"
        Me.txtError.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtError.Size = New System.Drawing.Size(282, 88)
        Me.txtError.TabIndex = 0
        '
        'alerter
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 157)
        Me.Controls.Add(Me.lblMess)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.groupError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alerter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TopMost = True
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupError.ResumeLayout(False)
        CType(Me.txtError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMess As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents img As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents layout2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdErrDetails As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents groupError As System.Windows.Forms.GroupBox
    Friend WithEvents txtError As DevExpress.XtraEditors.MemoEdit

End Class
