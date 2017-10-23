<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMjestaUnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMjestaUnos))
        Me.tab = New DevExpress.XtraTab.XtraTabControl()
        Me.tabZupanije = New DevExpress.XtraTab.XtraTabPage()
        Me.txtZsifra = New DevExpress.XtraEditors.TextEdit()
        Me.cmbZmjesto = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtZKratica = New DevExpress.XtraEditors.TextEdit()
        Me.lblZKratica = New DevExpress.XtraEditors.LabelControl()
        Me.txtZNaziv = New DevExpress.XtraEditors.TextEdit()
        Me.lblZSifra = New DevExpress.XtraEditors.LabelControl()
        Me.lblZSjediste = New DevExpress.XtraEditors.LabelControl()
        Me.lblZNaziv = New DevExpress.XtraEditors.LabelControl()
        Me.tabMjesta = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbMzupanija = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtMptt = New DevExpress.XtraEditors.TextEdit()
        Me.lblMNaziv = New DevExpress.XtraEditors.LabelControl()
        Me.txtMnaziv = New DevExpress.XtraEditors.TextEdit()
        Me.lblMPTT = New DevExpress.XtraEditors.LabelControl()
        Me.lblMZupanija = New DevExpress.XtraEditors.LabelControl()
        Me.tabUlice = New DevExpress.XtraTab.XtraTabPage()
        Me.cmbUmjesta = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblUNaziv = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnaziv = New DevExpress.XtraEditors.TextEdit()
        Me.lblUMjesto = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tabZupanije.SuspendLayout()
        CType(Me.txtZsifra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbZmjesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZKratica.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZNaziv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMjesta.SuspendLayout()
        CType(Me.cmbMzupanija.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMptt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMnaziv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUlice.SuspendLayout()
        CType(Me.cmbUmjesta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnaziv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Location = New System.Drawing.Point(3, 3)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabZupanije
        Me.tab.Size = New System.Drawing.Size(272, 160)
        Me.tab.TabIndex = 0
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabZupanije, Me.tabMjesta, Me.tabUlice})
        '
        'tabZupanije
        '
        Me.tabZupanije.Controls.Add(Me.txtZsifra)
        Me.tabZupanije.Controls.Add(Me.cmbZmjesto)
        Me.tabZupanije.Controls.Add(Me.txtZKratica)
        Me.tabZupanije.Controls.Add(Me.lblZKratica)
        Me.tabZupanije.Controls.Add(Me.txtZNaziv)
        Me.tabZupanije.Controls.Add(Me.lblZSifra)
        Me.tabZupanije.Controls.Add(Me.lblZSjediste)
        Me.tabZupanije.Controls.Add(Me.lblZNaziv)
        Me.tabZupanije.Name = "tabZupanije"
        Me.tabZupanije.Size = New System.Drawing.Size(266, 133)
        Me.tabZupanije.Text = "Županije"
        '
        'txtZsifra
        '
        Me.txtZsifra.Location = New System.Drawing.Point(70, 93)
        Me.txtZsifra.Name = "txtZsifra"
        Me.txtZsifra.Size = New System.Drawing.Size(42, 20)
        Me.txtZsifra.TabIndex = 7
        '
        'cmbZmjesto
        '
        Me.cmbZmjesto.Location = New System.Drawing.Point(70, 67)
        Me.cmbZmjesto.Name = "cmbZmjesto"
        Me.cmbZmjesto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbZmjesto.Size = New System.Drawing.Size(180, 20)
        Me.cmbZmjesto.TabIndex = 6
        '
        'txtZKratica
        '
        Me.txtZKratica.Location = New System.Drawing.Point(70, 41)
        Me.txtZKratica.Name = "txtZKratica"
        Me.txtZKratica.Size = New System.Drawing.Size(42, 20)
        Me.txtZKratica.TabIndex = 5
        '
        'lblZKratica
        '
        Me.lblZKratica.Location = New System.Drawing.Point(19, 45)
        Me.lblZKratica.Name = "lblZKratica"
        Me.lblZKratica.Size = New System.Drawing.Size(37, 13)
        Me.lblZKratica.TabIndex = 4
        Me.lblZKratica.Text = "Kratica:"
        '
        'txtZNaziv
        '
        Me.txtZNaziv.Location = New System.Drawing.Point(70, 15)
        Me.txtZNaziv.Name = "txtZNaziv"
        Me.txtZNaziv.Size = New System.Drawing.Size(180, 20)
        Me.txtZNaziv.TabIndex = 3
        '
        'lblZSifra
        '
        Me.lblZSifra.Location = New System.Drawing.Point(19, 97)
        Me.lblZSifra.Name = "lblZSifra"
        Me.lblZSifra.Size = New System.Drawing.Size(26, 13)
        Me.lblZSifra.TabIndex = 2
        Me.lblZSifra.Text = "Šifra:"
        '
        'lblZSjediste
        '
        Me.lblZSjediste.Location = New System.Drawing.Point(19, 71)
        Me.lblZSjediste.Name = "lblZSjediste"
        Me.lblZSjediste.Size = New System.Drawing.Size(42, 13)
        Me.lblZSjediste.TabIndex = 1
        Me.lblZSjediste.Text = "Sjedište:"
        '
        'lblZNaziv
        '
        Me.lblZNaziv.Location = New System.Drawing.Point(19, 19)
        Me.lblZNaziv.Name = "lblZNaziv"
        Me.lblZNaziv.Size = New System.Drawing.Size(30, 13)
        Me.lblZNaziv.TabIndex = 0
        Me.lblZNaziv.Text = "Naziv:"
        '
        'tabMjesta
        '
        Me.tabMjesta.Controls.Add(Me.cmbMzupanija)
        Me.tabMjesta.Controls.Add(Me.txtMptt)
        Me.tabMjesta.Controls.Add(Me.lblMNaziv)
        Me.tabMjesta.Controls.Add(Me.txtMnaziv)
        Me.tabMjesta.Controls.Add(Me.lblMPTT)
        Me.tabMjesta.Controls.Add(Me.lblMZupanija)
        Me.tabMjesta.Name = "tabMjesta"
        Me.tabMjesta.Size = New System.Drawing.Size(266, 133)
        Me.tabMjesta.Text = "Mjesta"
        '
        'cmbMzupanija
        '
        Me.cmbMzupanija.Location = New System.Drawing.Point(70, 22)
        Me.cmbMzupanija.Name = "cmbMzupanija"
        Me.cmbMzupanija.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMzupanija.Size = New System.Drawing.Size(180, 20)
        Me.cmbMzupanija.TabIndex = 11
        '
        'txtMptt
        '
        Me.txtMptt.Location = New System.Drawing.Point(70, 80)
        Me.txtMptt.Name = "txtMptt"
        Me.txtMptt.Size = New System.Drawing.Size(76, 20)
        Me.txtMptt.TabIndex = 10
        '
        'lblMNaziv
        '
        Me.lblMNaziv.Location = New System.Drawing.Point(15, 55)
        Me.lblMNaziv.Name = "lblMNaziv"
        Me.lblMNaziv.Size = New System.Drawing.Size(30, 13)
        Me.lblMNaziv.TabIndex = 9
        Me.lblMNaziv.Text = "Naziv:"
        '
        'txtMnaziv
        '
        Me.txtMnaziv.Location = New System.Drawing.Point(70, 51)
        Me.txtMnaziv.Name = "txtMnaziv"
        Me.txtMnaziv.Size = New System.Drawing.Size(180, 20)
        Me.txtMnaziv.TabIndex = 8
        '
        'lblMPTT
        '
        Me.lblMPTT.Location = New System.Drawing.Point(15, 84)
        Me.lblMPTT.Name = "lblMPTT"
        Me.lblMPTT.Size = New System.Drawing.Size(22, 13)
        Me.lblMPTT.TabIndex = 7
        Me.lblMPTT.Text = "PTT:"
        '
        'lblMZupanija
        '
        Me.lblMZupanija.Location = New System.Drawing.Point(15, 26)
        Me.lblMZupanija.Name = "lblMZupanija"
        Me.lblMZupanija.Size = New System.Drawing.Size(45, 13)
        Me.lblMZupanija.TabIndex = 6
        Me.lblMZupanija.Text = "Županija:"
        '
        'tabUlice
        '
        Me.tabUlice.Controls.Add(Me.cmbUmjesta)
        Me.tabUlice.Controls.Add(Me.lblUNaziv)
        Me.tabUlice.Controls.Add(Me.txtUnaziv)
        Me.tabUlice.Controls.Add(Me.lblUMjesto)
        Me.tabUlice.Name = "tabUlice"
        Me.tabUlice.Size = New System.Drawing.Size(266, 133)
        Me.tabUlice.Text = "Ulice"
        '
        'cmbUmjesta
        '
        Me.cmbUmjesta.Location = New System.Drawing.Point(70, 14)
        Me.cmbUmjesta.Name = "cmbUmjesta"
        Me.cmbUmjesta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbUmjesta.Size = New System.Drawing.Size(180, 20)
        Me.cmbUmjesta.TabIndex = 15
        '
        'lblUNaziv
        '
        Me.lblUNaziv.Location = New System.Drawing.Point(15, 50)
        Me.lblUNaziv.Name = "lblUNaziv"
        Me.lblUNaziv.Size = New System.Drawing.Size(30, 13)
        Me.lblUNaziv.TabIndex = 14
        Me.lblUNaziv.Text = "Naziv:"
        '
        'txtUnaziv
        '
        Me.txtUnaziv.Location = New System.Drawing.Point(70, 47)
        Me.txtUnaziv.Name = "txtUnaziv"
        Me.txtUnaziv.Size = New System.Drawing.Size(180, 20)
        Me.txtUnaziv.TabIndex = 13
        '
        'lblUMjesto
        '
        Me.lblUMjesto.Location = New System.Drawing.Point(15, 18)
        Me.lblUMjesto.Name = "lblUMjesto"
        Me.lblUMjesto.Size = New System.Drawing.Size(36, 13)
        Me.lblUMjesto.TabIndex = 12
        Me.lblUMjesto.Text = "Mjesto:"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(74, 169)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(115, 23)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Spremi"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(195, 169)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Izlaz"
        '
        'frmMjestaUnos
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 198)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMjestaUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMjestaUnos"
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tabZupanije.ResumeLayout(False)
        Me.tabZupanije.PerformLayout()
        CType(Me.txtZsifra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbZmjesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZKratica.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZNaziv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMjesta.ResumeLayout(False)
        Me.tabMjesta.PerformLayout()
        CType(Me.cmbMzupanija.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMptt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMnaziv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUlice.ResumeLayout(False)
        Me.tabUlice.PerformLayout()
        CType(Me.cmbUmjesta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnaziv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabZupanije As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabMjesta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabUlice As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtZsifra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbZmjesto As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtZKratica As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblZKratica As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtZNaziv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblZSifra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblZSjediste As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblZNaziv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbMzupanija As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtMptt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMNaziv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMnaziv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMPTT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMZupanija As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbUmjesta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblUNaziv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnaziv As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUMjesto As DevExpress.XtraEditors.LabelControl
End Class
