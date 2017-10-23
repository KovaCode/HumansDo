<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alerterInput
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.layout2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblMess = New DevExpress.XtraEditors.LabelControl()
        Me.lblTitle = New DevExpress.XtraEditors.LabelControl()
        Me.img = New DevExpress.XtraEditors.PictureEdit()
        Me.txtInput = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.img.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.AutoSize = True
        Me.PanelControl1.Controls.Add(Me.layout2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 100)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(385, 44)
        Me.PanelControl1.TabIndex = 7
        '
        'layout2
        '
        Me.layout2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layout2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.layout2.BackColor = System.Drawing.Color.Transparent
        Me.layout2.Location = New System.Drawing.Point(283, 7)
        Me.layout2.Name = "layout2"
        Me.layout2.Size = New System.Drawing.Size(100, 29)
        Me.layout2.TabIndex = 12
        Me.layout2.WrapContents = False
        '
        'lblMess
        '
        Me.lblMess.AutoEllipsis = True
        Me.lblMess.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblMess.Location = New System.Drawing.Point(56, 34)
        Me.lblMess.Name = "lblMess"
        Me.lblMess.Size = New System.Drawing.Size(306, 13)
        Me.lblMess.TabIndex = 8
        Me.lblMess.Text = "Ovdje ide opis"
        '
        'lblTitle
        '
        Me.lblTitle.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.Appearance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTitle.AutoEllipsis = True
        Me.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblTitle.Location = New System.Drawing.Point(46, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(253, 16)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Ovo je naslov"
        '
        'img
        '
        Me.img.EditValue = Global.HumansDo.My.Resources.Resources.SYSTEM_ALERT_NOTE1
        Me.img.Location = New System.Drawing.Point(8, 12)
        Me.img.Name = "img"
        Me.img.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img.Properties.Appearance.Options.UseBackColor = True
        Me.img.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.img.Size = New System.Drawing.Size(32, 33)
        Me.img.TabIndex = 10
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(56, 54)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(306, 20)
        Me.txtInput.TabIndex = 11
        '
        'alerterInput
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 144)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.lblMess)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alerterInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.img.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents layout2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblMess As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents img As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtInput As DevExpress.XtraEditors.TextEdit
End Class
