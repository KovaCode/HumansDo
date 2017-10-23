<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategUnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKategUnos))
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.lblNaziv = New DevExpress.XtraEditors.LabelControl()
        Me.lblColor = New DevExpress.XtraEditors.LabelControl()
        Me.repColor = New DevExpress.XtraEditors.ColorEdit()
        Me.txtNaziv = New DevExpress.XtraEditors.TextEdit()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.chkMine = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.repColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNaziv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(145, 62)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Spremi"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(226, 62)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Odustani"
        '
        'lblNaziv
        '
        Me.lblNaziv.Location = New System.Drawing.Point(12, 20)
        Me.lblNaziv.Name = "lblNaziv"
        Me.lblNaziv.Size = New System.Drawing.Size(30, 13)
        Me.lblNaziv.TabIndex = 2
        Me.lblNaziv.Text = "Naziv:"
        '
        'lblColor
        '
        Me.lblColor.Location = New System.Drawing.Point(226, 21)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(25, 13)
        Me.lblColor.TabIndex = 3
        Me.lblColor.Text = "Boja:"
        '
        'repColor
        '
        Me.repColor.EditValue = System.Drawing.Color.White
        Me.repColor.Location = New System.Drawing.Point(257, 17)
        Me.repColor.Name = "repColor"
        Me.repColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repColor.Properties.ColorText = DevExpress.XtraEditors.Controls.ColorText.[Integer]
        Me.repColor.Size = New System.Drawing.Size(44, 20)
        Me.repColor.TabIndex = 1
        '
        'txtNaziv
        '
        Me.txtNaziv.Location = New System.Drawing.Point(48, 17)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(172, 20)
        Me.txtNaziv.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(309, 93)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 12
        Me.LineShape1.X2 = 304
        Me.LineShape1.Y1 = 51
        Me.LineShape1.Y2 = 51
        '
        'chkMine
        '
        Me.chkMine.Location = New System.Drawing.Point(10, 62)
        Me.chkMine.Name = "chkMine"
        Me.chkMine.Properties.Caption = "Samo meni vidljivo"
        Me.chkMine.Size = New System.Drawing.Size(111, 19)
        Me.chkMine.TabIndex = 7
        '
        'frmKategUnos
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 93)
        Me.Controls.Add(Me.chkMine)
        Me.Controls.Add(Me.txtNaziv)
        Me.Controls.Add(Me.repColor)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblNaziv)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKategUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Unos Kategorija"
        CType(Me.repColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNaziv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblNaziv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblColor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents repColor As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents txtNaziv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents chkMine As DevExpress.XtraEditors.CheckEdit
End Class
