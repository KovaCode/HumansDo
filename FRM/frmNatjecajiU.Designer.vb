<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNatjecajiU
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
        Me.lblNatjecajBr = New DevExpress.XtraEditors.LabelControl()
        Me.lblNatjecajBroj = New DevExpress.XtraEditors.LabelControl()
        Me.lblOtvorenoRadMj = New DevExpress.XtraEditors.LabelControl()
        Me.lblRadnoMj = New DevExpress.XtraEditors.LabelControl()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.lblDatumOtvaranje = New DevExpress.XtraEditors.LabelControl()
        Me.lblDatumPLan = New DevExpress.XtraEditors.LabelControl()
        Me.lblDatumPopunj = New DevExpress.XtraEditors.LabelControl()
        Me.lblOrgJed = New DevExpress.XtraEditors.LabelControl()
        Me.lblLokacija = New DevExpress.XtraEditors.LabelControl()
        Me.lblVrstaZaposl = New DevExpress.XtraEditors.LabelControl()
        Me.txtOpis = New DevExpress.XtraEditors.MemoExEdit()
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
        Me.txtNaziv = New DevExpress.XtraEditors.TextEdit()
        Me.cmbRadnoMjesto = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbStatusi = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtpOtvaranje = New DevExpress.XtraEditors.DateEdit()
        Me.dtpPlanirano = New DevExpress.XtraEditors.DateEdit()
        Me.dtpZavrseno = New DevExpress.XtraEditors.DateEdit()
        Me.cmbOrgJed = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbVrsta = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmdBrowse2 = New DevExpress.XtraEditors.SimpleButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.lblIzvrsitelj = New DevExpress.XtraEditors.LabelControl()
        Me.txtLokacija = New DevExpress.XtraEditors.TextEdit()
        Me.txtIzvrsitelja = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txtOpis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNaziv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRadnoMjesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatusi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpOtvaranje.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpOtvaranje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPlanirano.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpPlanirano.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpZavrseno.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpZavrseno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrgJed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVrsta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLokacija.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIzvrsitelja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNatjecajBr
        '
        Me.lblNatjecajBr.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblNatjecajBr.Location = New System.Drawing.Point(12, 15)
        Me.lblNatjecajBr.Name = "lblNatjecajBr"
        Me.lblNatjecajBr.Size = New System.Drawing.Size(57, 13)
        Me.lblNatjecajBr.TabIndex = 0
        Me.lblNatjecajBr.Text = "Natječaj br:"
        '
        'lblNatjecajBroj
        '
        Me.lblNatjecajBroj.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNatjecajBroj.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNatjecajBroj.Location = New System.Drawing.Point(80, 13)
        Me.lblNatjecajBroj.Name = "lblNatjecajBroj"
        Me.lblNatjecajBroj.Size = New System.Drawing.Size(48, 16)
        Me.lblNatjecajBroj.TabIndex = 1
        Me.lblNatjecajBroj.Text = "1/2012"
        '
        'lblOtvorenoRadMj
        '
        Me.lblOtvorenoRadMj.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblOtvorenoRadMj.Location = New System.Drawing.Point(12, 51)
        Me.lblOtvorenoRadMj.Name = "lblOtvorenoRadMj"
        Me.lblOtvorenoRadMj.Size = New System.Drawing.Size(116, 13)
        Me.lblOtvorenoRadMj.TabIndex = 2
        Me.lblOtvorenoRadMj.Text = "Otvoreno radno mjesto:"
        '
        'lblRadnoMj
        '
        Me.lblRadnoMj.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblRadnoMj.Location = New System.Drawing.Point(12, 80)
        Me.lblRadnoMj.Name = "lblRadnoMj"
        Me.lblRadnoMj.Size = New System.Drawing.Size(70, 13)
        Me.lblRadnoMj.TabIndex = 3
        Me.lblRadnoMj.Text = "Radno mjesto:"
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(12, 133)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(35, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        '
        'lblDatumOtvaranje
        '
        Me.lblDatumOtvaranje.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDatumOtvaranje.Location = New System.Drawing.Point(12, 162)
        Me.lblDatumOtvaranje.Name = "lblDatumOtvaranje"
        Me.lblDatumOtvaranje.Size = New System.Drawing.Size(125, 13)
        Me.lblDatumOtvaranje.TabIndex = 5
        Me.lblDatumOtvaranje.Text = "Otvaranje radnog mjesta:"
        '
        'lblDatumPLan
        '
        Me.lblDatumPLan.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDatumPLan.Location = New System.Drawing.Point(12, 191)
        Me.lblDatumPLan.Name = "lblDatumPLan"
        Me.lblDatumPLan.Size = New System.Drawing.Size(117, 13)
        Me.lblDatumPLan.TabIndex = 6
        Me.lblDatumPLan.Text = "Planirano popunjavanja:"
        '
        'lblDatumPopunj
        '
        Me.lblDatumPopunj.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDatumPopunj.Location = New System.Drawing.Point(12, 220)
        Me.lblDatumPopunj.Name = "lblDatumPopunj"
        Me.lblDatumPopunj.Size = New System.Drawing.Size(104, 13)
        Me.lblDatumPopunj.TabIndex = 7
        Me.lblDatumPopunj.Text = "Datum popunjavanja:"
        '
        'lblOrgJed
        '
        Me.lblOrgJed.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblOrgJed.Location = New System.Drawing.Point(12, 249)
        Me.lblOrgJed.Name = "lblOrgJed"
        Me.lblOrgJed.Size = New System.Drawing.Size(62, 13)
        Me.lblOrgJed.TabIndex = 8
        Me.lblOrgJed.Text = "Org.jedinica:"
        '
        'lblLokacija
        '
        Me.lblLokacija.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblLokacija.Location = New System.Drawing.Point(12, 275)
        Me.lblLokacija.Name = "lblLokacija"
        Me.lblLokacija.Size = New System.Drawing.Size(42, 13)
        Me.lblLokacija.TabIndex = 9
        Me.lblLokacija.Text = "Lokacija:"
        '
        'lblVrstaZaposl
        '
        Me.lblVrstaZaposl.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblVrstaZaposl.Location = New System.Drawing.Point(12, 303)
        Me.lblVrstaZaposl.Name = "lblVrstaZaposl"
        Me.lblVrstaZaposl.Size = New System.Drawing.Size(98, 13)
        Me.lblVrstaZaposl.TabIndex = 10
        Me.lblVrstaZaposl.Text = "Vrsta zapošljavanja:"
        '
        'txtOpis
        '
        Me.txtOpis.Location = New System.Drawing.Point(143, 329)
        Me.txtOpis.Name = "txtOpis"
        Me.txtOpis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOpis.Size = New System.Drawing.Size(117, 20)
        Me.txtOpis.TabIndex = 11
        '
        'lblDescription
        '
        Me.lblDescription.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(12, 332)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(25, 13)
        Me.lblDescription.TabIndex = 12
        Me.lblDescription.Text = "Opis:"
        '
        'txtNaziv
        '
        Me.txtNaziv.Location = New System.Drawing.Point(143, 48)
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(180, 20)
        Me.txtNaziv.TabIndex = 13
        '
        'cmbRadnoMjesto
        '
        Me.cmbRadnoMjesto.Location = New System.Drawing.Point(143, 77)
        Me.cmbRadnoMjesto.Name = "cmbRadnoMjesto"
        Me.cmbRadnoMjesto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRadnoMjesto.Size = New System.Drawing.Size(180, 20)
        Me.cmbRadnoMjesto.TabIndex = 14
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(326, 77)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(20, 20)
        Me.cmdBrowse.TabIndex = 15
        Me.cmdBrowse.Text = "..."
        '
        'cmbStatusi
        '
        Me.cmbStatusi.Location = New System.Drawing.Point(143, 130)
        Me.cmbStatusi.Name = "cmbStatusi"
        Me.cmbStatusi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatusi.Size = New System.Drawing.Size(180, 20)
        Me.cmbStatusi.TabIndex = 16
        '
        'dtpOtvaranje
        '
        Me.dtpOtvaranje.EditValue = Nothing
        Me.dtpOtvaranje.Location = New System.Drawing.Point(143, 159)
        Me.dtpOtvaranje.Name = "dtpOtvaranje"
        Me.dtpOtvaranje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpOtvaranje.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpOtvaranje.Size = New System.Drawing.Size(100, 20)
        Me.dtpOtvaranje.TabIndex = 17
        '
        'dtpPlanirano
        '
        Me.dtpPlanirano.EditValue = Nothing
        Me.dtpPlanirano.Location = New System.Drawing.Point(143, 188)
        Me.dtpPlanirano.Name = "dtpPlanirano"
        Me.dtpPlanirano.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpPlanirano.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpPlanirano.Size = New System.Drawing.Size(100, 20)
        Me.dtpPlanirano.TabIndex = 18
        '
        'dtpZavrseno
        '
        Me.dtpZavrseno.EditValue = Nothing
        Me.dtpZavrseno.Location = New System.Drawing.Point(143, 217)
        Me.dtpZavrseno.Name = "dtpZavrseno"
        Me.dtpZavrseno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpZavrseno.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpZavrseno.Size = New System.Drawing.Size(100, 20)
        Me.dtpZavrseno.TabIndex = 19
        '
        'cmbOrgJed
        '
        Me.cmbOrgJed.Location = New System.Drawing.Point(143, 246)
        Me.cmbOrgJed.Name = "cmbOrgJed"
        Me.cmbOrgJed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrgJed.Size = New System.Drawing.Size(180, 20)
        Me.cmbOrgJed.TabIndex = 20
        '
        'cmbVrsta
        '
        Me.cmbVrsta.Location = New System.Drawing.Point(143, 300)
        Me.cmbVrsta.Name = "cmbVrsta"
        Me.cmbVrsta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbVrsta.Size = New System.Drawing.Size(180, 20)
        Me.cmbVrsta.TabIndex = 22
        '
        'cmdBrowse2
        '
        Me.cmdBrowse2.Location = New System.Drawing.Point(326, 246)
        Me.cmdBrowse2.Name = "cmdBrowse2"
        Me.cmdBrowse2.Size = New System.Drawing.Size(20, 20)
        Me.cmdBrowse2.TabIndex = 23
        Me.cmdBrowse2.Text = "..."
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(358, 419)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -2
        Me.LineShape2.X2 = 363
        Me.LineShape2.Y1 = 377
        Me.LineShape2.Y2 = 376
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 403
        Me.LineShape1.Y1 = 35
        Me.LineShape1.Y2 = 35
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(185, 386)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(165, 27)
        Me.cmdExit.TabIndex = 25
        Me.cmdExit.Text = "&Odustani"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(3, 386)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(176, 27)
        Me.cmdSave.TabIndex = 26
        Me.cmdSave.Text = "&Spremi"
        '
        'lblIzvrsitelj
        '
        Me.lblIzvrsitelj.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblIzvrsitelj.Location = New System.Drawing.Point(12, 107)
        Me.lblIzvrsitelj.Name = "lblIzvrsitelj"
        Me.lblIzvrsitelj.Size = New System.Drawing.Size(51, 13)
        Me.lblIzvrsitelj.TabIndex = 28
        Me.lblIzvrsitelj.Text = "Izvršitelja:"
        '
        'txtLokacija
        '
        Me.txtLokacija.Location = New System.Drawing.Point(143, 274)
        Me.txtLokacija.Name = "txtLokacija"
        Me.txtLokacija.Size = New System.Drawing.Size(180, 20)
        Me.txtLokacija.TabIndex = 33
        '
        'txtIzvrsitelja
        '
        Me.txtIzvrsitelja.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIzvrsitelja.Location = New System.Drawing.Point(143, 104)
        Me.txtIzvrsitelja.Name = "txtIzvrsitelja"
        Me.txtIzvrsitelja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtIzvrsitelja.Size = New System.Drawing.Size(36, 20)
        Me.txtIzvrsitelja.TabIndex = 34
        '
        'frmNatjecajiU
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 419)
        Me.Controls.Add(Me.txtIzvrsitelja)
        Me.Controls.Add(Me.txtLokacija)
        Me.Controls.Add(Me.lblIzvrsitelj)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdBrowse2)
        Me.Controls.Add(Me.cmbVrsta)
        Me.Controls.Add(Me.cmbOrgJed)
        Me.Controls.Add(Me.dtpZavrseno)
        Me.Controls.Add(Me.dtpPlanirano)
        Me.Controls.Add(Me.dtpOtvaranje)
        Me.Controls.Add(Me.cmbStatusi)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.cmbRadnoMjesto)
        Me.Controls.Add(Me.txtNaziv)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtOpis)
        Me.Controls.Add(Me.lblVrstaZaposl)
        Me.Controls.Add(Me.lblLokacija)
        Me.Controls.Add(Me.lblOrgJed)
        Me.Controls.Add(Me.lblDatumPopunj)
        Me.Controls.Add(Me.lblDatumPLan)
        Me.Controls.Add(Me.lblDatumOtvaranje)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblRadnoMj)
        Me.Controls.Add(Me.lblOtvorenoRadMj)
        Me.Controls.Add(Me.lblNatjecajBroj)
        Me.Controls.Add(Me.lblNatjecajBr)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNatjecajiU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNatjecajiU"
        CType(Me.txtOpis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNaziv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRadnoMjesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatusi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpOtvaranje.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpOtvaranje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPlanirano.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpPlanirano.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpZavrseno.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpZavrseno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrgJed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVrsta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLokacija.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIzvrsitelja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNatjecajBr As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNatjecajBroj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOtvorenoRadMj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRadnoMj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDatumOtvaranje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDatumPLan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDatumPopunj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOrgJed As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLokacija As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVrstaZaposl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOpis As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNaziv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbRadnoMjesto As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbStatusi As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtpOtvaranje As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpPlanirano As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpZavrseno As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbOrgJed As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbVrsta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmdBrowse2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblIzvrsitelj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtLokacija As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIzvrsitelja As DevExpress.XtraEditors.SpinEdit
End Class
