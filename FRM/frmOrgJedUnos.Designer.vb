<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrgJedUnos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrgJedUnos))
        Me.lblNazivFull = New DevExpress.XtraEditors.LabelControl()
        Me.lblNazivShort = New DevExpress.XtraEditors.LabelControl()
        Me.lblSifra = New DevExpress.XtraEditors.LabelControl()
        Me.lblTvrtka = New DevExpress.XtraEditors.LabelControl()
        Me.txtNazivFull = New DevExpress.XtraEditors.TextEdit()
        Me.txtNazivSkr = New DevExpress.XtraEditors.TextEdit()
        Me.txtSifra = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTvrtka = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.chkAktiv = New DevExpress.XtraEditors.CheckEdit()
        Me.lblAktiv = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtNazivFull.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNazivSkr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSifra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTvrtka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAktiv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNazivFull
        '
        Me.lblNazivFull.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNazivFull.Location = New System.Drawing.Point(12, 43)
        Me.lblNazivFull.Name = "lblNazivFull"
        Me.lblNazivFull.Size = New System.Drawing.Size(72, 13)
        Me.lblNazivFull.TabIndex = 0
        Me.lblNazivFull.Text = "Puni naziv:"
        '
        'lblNazivShort
        '
        Me.lblNazivShort.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNazivShort.Location = New System.Drawing.Point(12, 69)
        Me.lblNazivShort.Name = "lblNazivShort"
        Me.lblNazivShort.Size = New System.Drawing.Size(72, 13)
        Me.lblNazivShort.TabIndex = 1
        Me.lblNazivShort.Text = "Skraćeni naziv:"
        '
        'lblSifra
        '
        Me.lblSifra.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSifra.Location = New System.Drawing.Point(12, 95)
        Me.lblSifra.Name = "lblSifra"
        Me.lblSifra.Size = New System.Drawing.Size(72, 13)
        Me.lblSifra.TabIndex = 2
        Me.lblSifra.Text = "Šifra:"
        '
        'lblTvrtka
        '
        Me.lblTvrtka.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTvrtka.Location = New System.Drawing.Point(12, 17)
        Me.lblTvrtka.Name = "lblTvrtka"
        Me.lblTvrtka.Size = New System.Drawing.Size(72, 13)
        Me.lblTvrtka.TabIndex = 3
        Me.lblTvrtka.Text = "Tvrtka:"
        '
        'txtNazivFull
        '
        Me.txtNazivFull.Location = New System.Drawing.Point(97, 39)
        Me.txtNazivFull.Name = "txtNazivFull"
        Me.txtNazivFull.Properties.MaxLength = 100
        Me.txtNazivFull.Properties.NullText = "Unesite puni naziv"
        Me.txtNazivFull.Size = New System.Drawing.Size(266, 20)
        Me.txtNazivFull.TabIndex = 1
        '
        'txtNazivSkr
        '
        Me.txtNazivSkr.Location = New System.Drawing.Point(97, 65)
        Me.txtNazivSkr.Name = "txtNazivSkr"
        Me.txtNazivSkr.Properties.MaxLength = 50
        Me.txtNazivSkr.Properties.NullText = "Unesite skraćeni naziv"
        Me.txtNazivSkr.Size = New System.Drawing.Size(266, 20)
        Me.txtNazivSkr.TabIndex = 2
        '
        'txtSifra
        '
        Me.txtSifra.Location = New System.Drawing.Point(97, 91)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Properties.MaxLength = 10
        Me.txtSifra.Properties.NullText = "Unesite šifru"
        Me.txtSifra.Size = New System.Drawing.Size(105, 20)
        Me.txtSifra.TabIndex = 3
        '
        'cmbTvrtka
        '
        Me.cmbTvrtka.Location = New System.Drawing.Point(97, 13)
        Me.cmbTvrtka.Name = "cmbTvrtka"
        Me.cmbTvrtka.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTvrtka.Size = New System.Drawing.Size(215, 20)
        Me.cmbTvrtka.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(377, 177)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 5
        Me.LineShape1.X2 = 367
        Me.LineShape1.Y1 = 141
        Me.LineShape1.Y2 = 141
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(167, 150)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(99, 23)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "&Spremi"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(272, 150)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 23)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "&Odustani"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'chkAktiv
        '
        Me.chkAktiv.Location = New System.Drawing.Point(95, 117)
        Me.chkAktiv.Name = "chkAktiv"
        Me.chkAktiv.Properties.Caption = ""
        Me.chkAktiv.Size = New System.Drawing.Size(75, 19)
        Me.chkAktiv.TabIndex = 10
        '
        'lblAktiv
        '
        Me.lblAktiv.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAktiv.Location = New System.Drawing.Point(12, 120)
        Me.lblAktiv.Name = "lblAktiv"
        Me.lblAktiv.Size = New System.Drawing.Size(72, 13)
        Me.lblAktiv.TabIndex = 11
        Me.lblAktiv.Text = "Aktivno:"
        '
        'frmOrgJedUnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 177)
        Me.Controls.Add(Me.lblAktiv)
        Me.Controls.Add(Me.chkAktiv)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmbTvrtka)
        Me.Controls.Add(Me.txtSifra)
        Me.Controls.Add(Me.txtNazivSkr)
        Me.Controls.Add(Me.txtNazivFull)
        Me.Controls.Add(Me.lblTvrtka)
        Me.Controls.Add(Me.lblSifra)
        Me.Controls.Add(Me.lblNazivShort)
        Me.Controls.Add(Me.lblNazivFull)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrgJedUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "orgJedUnos"
        CType(Me.txtNazivFull.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNazivSkr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSifra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTvrtka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAktiv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNazivFull As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNazivShort As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSifra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTvrtka As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNazivFull As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNazivSkr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSifra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbTvrtka As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents lblAktiv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAktiv As DevExpress.XtraEditors.CheckEdit
End Class
