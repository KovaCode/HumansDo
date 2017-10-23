<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassChange))
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.lblKorisnik = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.lblLozinka = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblLozinka2 = New DevExpress.XtraEditors.LabelControl()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(60, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.LookAndFeel.SkinName = "Blue"
        Me.txtUser.Size = New System.Drawing.Size(132, 20)
        Me.txtUser.TabIndex = 48
        '
        'lblKorisnik
        '
        Me.lblKorisnik.Location = New System.Drawing.Point(9, 15)
        Me.lblKorisnik.Name = "lblKorisnik"
        Me.lblKorisnik.Size = New System.Drawing.Size(36, 13)
        Me.lblKorisnik.TabIndex = 51
        Me.lblKorisnik.Text = "Korisnik"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(60, 38)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.LookAndFeel.SkinName = "Blue"
        Me.txtPass.Properties.Mask.EditMask = "•"
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(132, 20)
        Me.txtPass.TabIndex = 49
        '
        'lblLozinka
        '
        Me.lblLozinka.Location = New System.Drawing.Point(9, 41)
        Me.lblLozinka.Name = "lblLozinka"
        Me.lblLozinka.Size = New System.Drawing.Size(35, 13)
        Me.lblLozinka.TabIndex = 50
        Me.lblLozinka.Text = "Lozinka"
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(60, 64)
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Properties.LookAndFeel.SkinName = "Blue"
        Me.txtPass2.Properties.Mask.EditMask = "•"
        Me.txtPass2.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass2.Size = New System.Drawing.Size(132, 20)
        Me.txtPass2.TabIndex = 52
        '
        'lblLozinka2
        '
        Me.lblLozinka2.Location = New System.Drawing.Point(9, 67)
        Me.lblLozinka2.Name = "lblLozinka2"
        Me.lblLozinka2.Size = New System.Drawing.Size(45, 13)
        Me.lblLozinka2.TabIndex = 53
        Me.lblLozinka2.Text = "Lozinka2:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(213, 136)
        Me.ShapeContainer1.TabIndex = 54
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 206
        Me.LineShape1.Y1 = 94
        Me.LineShape1.Y2 = 94
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(9, 104)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(198, 23)
        Me.cmdSave.TabIndex = 55
        Me.cmdSave.Text = "Spremi"
        '
        'frmPassChange
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 136)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtPass2)
        Me.Controls.Add(Me.lblLozinka2)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblKorisnik)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblLozinka)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPassChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPassChange"
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblKorisnik As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLozinka As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLozinka2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
End Class
