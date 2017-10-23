<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.cmdEnter = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.lblLozinka = New DevExpress.XtraEditors.LabelControl()
        Me.txtPass = New DevExpress.XtraEditors.TextEdit()
        Me.lblKorisnik = New DevExpress.XtraEditors.LabelControl()
        Me.txtUser = New DevExpress.XtraEditors.TextEdit()
        Me.lblWelcome = New DevExpress.XtraEditors.LabelControl()
        Me.lblOpis = New DevExpress.XtraEditors.LabelControl()
        Me.lblVer = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdSetup = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'cmdEnter
        '
        Me.cmdEnter.Location = New System.Drawing.Point(207, 126)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(114, 23)
        Me.cmdEnter.TabIndex = 44
        Me.cmdEnter.Text = "&Logiranje"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(323, 126)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(72, 23)
        Me.cmdExit.TabIndex = 45
        Me.cmdExit.Text = "&Izlaz?"
        '
        'lblLozinka
        '
        Me.lblLozinka.Location = New System.Drawing.Point(92, 68)
        Me.lblLozinka.Name = "lblLozinka"
        Me.lblLozinka.Size = New System.Drawing.Size(35, 13)
        Me.lblLozinka.TabIndex = 46
        Me.lblLozinka.Text = "Lozinka"
        '
        'txtPass
        '
        Me.txtPass.EditValue = "skyline"
        Me.txtPass.Location = New System.Drawing.Point(143, 65)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Properties.LookAndFeel.SkinName = "Blue"
        Me.txtPass.Properties.Mask.EditMask = "•"
        Me.txtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPass.Size = New System.Drawing.Size(242, 20)
        Me.txtPass.TabIndex = 43
        '
        'lblKorisnik
        '
        Me.lblKorisnik.Location = New System.Drawing.Point(92, 42)
        Me.lblKorisnik.Name = "lblKorisnik"
        Me.lblKorisnik.Size = New System.Drawing.Size(36, 13)
        Me.lblKorisnik.TabIndex = 47
        Me.lblKorisnik.Text = "Korisnik"
        '
        'txtUser
        '
        Me.txtUser.EditValue = "ivan"
        Me.txtUser.Location = New System.Drawing.Point(143, 39)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Properties.LookAndFeel.SkinName = "Blue"
        Me.txtUser.Size = New System.Drawing.Size(242, 20)
        Me.txtUser.TabIndex = 42
        '
        'lblWelcome
        '
        Me.lblWelcome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(92, 12)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(130, 13)
        Me.lblWelcome.TabIndex = 50
        Me.lblWelcome.Text = "Dobrodošli u aplikaciju "
        '
        'lblOpis
        '
        Me.lblOpis.Location = New System.Drawing.Point(141, 91)
        Me.lblOpis.Name = "lblOpis"
        Me.lblOpis.Size = New System.Drawing.Size(244, 13)
        Me.lblOpis.TabIndex = 51
        Me.lblOpis.Text = "(Molimo unesite ispod vaše korisničko ime i lozinku!)"
        '
        'lblVer
        '
        Me.lblVer.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblVer.Location = New System.Drawing.Point(25, 105)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(41, 11)
        Me.lblVer.TabIndex = 53
        Me.lblVer.Text = "ver. 0.0.0"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdSetup)
        Me.PanelControl1.Controls.Add(Me.PictureEdit2)
        Me.PanelControl1.Controls.Add(Me.lblVer)
        Me.PanelControl1.Controls.Add(Me.lblOpis)
        Me.PanelControl1.Controls.Add(Me.lblWelcome)
        Me.PanelControl1.Controls.Add(Me.txtUser)
        Me.PanelControl1.Controls.Add(Me.lblKorisnik)
        Me.PanelControl1.Controls.Add(Me.txtPass)
        Me.PanelControl1.Controls.Add(Me.lblLozinka)
        Me.PanelControl1.Controls.Add(Me.cmdExit)
        Me.PanelControl1.Controls.Add(Me.cmdEnter)
        Me.PanelControl1.Controls.Add(Me.ShapeContainer1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(405, 161)
        Me.PanelControl1.TabIndex = 0
        '
        'cmdSetup
        '
        Me.cmdSetup.Image = Global.HumansDo.My.Resources.Resources.Wheels16
        Me.cmdSetup.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdSetup.Location = New System.Drawing.Point(5, 126)
        Me.cmdSetup.Name = "cmdSetup"
        Me.cmdSetup.Size = New System.Drawing.Size(32, 23)
        Me.cmdSetup.TabIndex = 55
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.HumansDo.My.Resources.Resources.HAL_9000
        Me.PictureEdit2.Location = New System.Drawing.Point(5, 12)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(81, 78)
        Me.PictureEdit2.TabIndex = 54
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(2, 2)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(401, 157)
        Me.ShapeContainer1.TabIndex = 52
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -13
        Me.LineShape1.X2 = 406
        Me.LineShape1.Y1 = 113
        Me.LineShape1.Y2 = 113
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 161)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "humansDo - Logiranje u aplikaciju?"
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblVer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOpis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblWelcome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblKorisnik As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLozinka As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEnter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmdSetup As DevExpress.XtraEditors.SimpleButton
End Class
