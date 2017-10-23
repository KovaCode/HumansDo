<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObrazovanje
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
        Me.tab = New DevExpress.XtraTab.XtraTabControl()
        Me.tabFormalno = New DevExpress.XtraTab.XtraTabPage()
        Me.groupFormalno = New DevExpress.XtraEditors.GroupControl()
        Me.txtFZanimanje = New DevExpress.XtraEditors.TextEdit()
        Me.txtFUstanova = New DevExpress.XtraEditors.TextEdit()
        Me.cmbMjesta = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtp = New DevExpress.XtraEditors.DateEdit()
        Me.txtFKomentar = New DevExpress.XtraEditors.MemoExEdit()
        Me.lblFZanimanje = New DevExpress.XtraEditors.LabelControl()
        Me.cmbStupanj = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblFKomentar = New DevExpress.XtraEditors.LabelControl()
        Me.lblFDatum = New DevExpress.XtraEditors.LabelControl()
        Me.lblFMjesto = New DevExpress.XtraEditors.LabelControl()
        Me.lblFUstanova = New DevExpress.XtraEditors.LabelControl()
        Me.lblFstupanj = New DevExpress.XtraEditors.LabelControl()
        Me.gridFormal = New DevExpress.XtraGrid.GridControl()
        Me.gridViewFormal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKratica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabCertifikati = New DevExpress.XtraTab.XtraTabPage()
        Me.gridCert = New DevExpress.XtraGrid.GridControl()
        Me.gridViewCertifikat = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.groupCertifikat = New DevExpress.XtraEditors.GroupControl()
        Me.txtCCijena = New DevExpress.XtraEditors.TextEdit()
        Me.lblCCijena = New DevExpress.XtraEditors.LabelControl()
        Me.chkCRadnaKnj = New DevExpress.XtraEditors.CheckEdit()
        Me.lblCChkUpis = New DevExpress.XtraEditors.LabelControl()
        Me.txtCCertifikat = New DevExpress.XtraEditors.TextEdit()
        Me.txtCUstanova = New DevExpress.XtraEditors.TextEdit()
        Me.cmbCMjesto = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtpC = New DevExpress.XtraEditors.DateEdit()
        Me.txtCKomentar = New DevExpress.XtraEditors.MemoExEdit()
        Me.lblCertifikat = New DevExpress.XtraEditors.LabelControl()
        Me.lblCKomentar = New DevExpress.XtraEditors.LabelControl()
        Me.lblCDatum = New DevExpress.XtraEditors.LabelControl()
        Me.lblCMjesto = New DevExpress.XtraEditors.LabelControl()
        Me.lblCUstanova = New DevExpress.XtraEditors.LabelControl()
        Me.tabSeminari = New DevExpress.XtraTab.XtraTabPage()
        Me.groupSeminari = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.lblSeminarNaziv = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.gridSeminar = New DevExpress.XtraGrid.GridControl()
        Me.gridViewSeminar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabKompetencije = New DevExpress.XtraTab.XtraTabPage()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tabFormalno.SuspendLayout()
        CType(Me.groupFormalno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupFormalno.SuspendLayout()
        CType(Me.txtFZanimanje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFUstanova.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMjesta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFKomentar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStupanj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridFormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewFormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCertifikati.SuspendLayout()
        CType(Me.gridCert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewCertifikat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupCertifikat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupCertifikat.SuspendLayout()
        CType(Me.txtCCijena.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCRadnaKnj.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCCertifikat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCUstanova.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCMjesto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpC.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCKomentar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSeminari.SuspendLayout()
        CType(Me.groupSeminari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupSeminari.SuspendLayout()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridSeminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewSeminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Dock = System.Windows.Forms.DockStyle.Top
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabFormalno
        Me.tab.Size = New System.Drawing.Size(583, 351)
        Me.tab.TabIndex = 4
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabFormalno, Me.tabCertifikati, Me.tabSeminari, Me.tabKompetencije})
        '
        'tabFormalno
        '
        Me.tabFormalno.Controls.Add(Me.groupFormalno)
        Me.tabFormalno.Controls.Add(Me.gridFormal)
        Me.tabFormalno.Name = "tabFormalno"
        Me.tabFormalno.Size = New System.Drawing.Size(578, 325)
        Me.tabFormalno.Text = "Formalno obrazovanje"
        '
        'groupFormalno
        '
        Me.groupFormalno.Controls.Add(Me.txtFZanimanje)
        Me.groupFormalno.Controls.Add(Me.txtFUstanova)
        Me.groupFormalno.Controls.Add(Me.cmbMjesta)
        Me.groupFormalno.Controls.Add(Me.dtp)
        Me.groupFormalno.Controls.Add(Me.txtFKomentar)
        Me.groupFormalno.Controls.Add(Me.lblFZanimanje)
        Me.groupFormalno.Controls.Add(Me.cmbStupanj)
        Me.groupFormalno.Controls.Add(Me.lblFKomentar)
        Me.groupFormalno.Controls.Add(Me.lblFDatum)
        Me.groupFormalno.Controls.Add(Me.lblFMjesto)
        Me.groupFormalno.Controls.Add(Me.lblFUstanova)
        Me.groupFormalno.Controls.Add(Me.lblFstupanj)
        Me.groupFormalno.Location = New System.Drawing.Point(223, 8)
        Me.groupFormalno.Name = "groupFormalno"
        Me.groupFormalno.Size = New System.Drawing.Size(345, 303)
        Me.groupFormalno.TabIndex = 6
        Me.groupFormalno.Text = "Formalno obrazovanje"
        '
        'txtFZanimanje
        '
        Me.txtFZanimanje.Location = New System.Drawing.Point(125, 68)
        Me.txtFZanimanje.Name = "txtFZanimanje"
        Me.txtFZanimanje.Size = New System.Drawing.Size(207, 20)
        Me.txtFZanimanje.TabIndex = 11
        '
        'txtFUstanova
        '
        Me.txtFUstanova.Location = New System.Drawing.Point(124, 98)
        Me.txtFUstanova.Name = "txtFUstanova"
        Me.txtFUstanova.Size = New System.Drawing.Size(207, 20)
        Me.txtFUstanova.TabIndex = 10
        '
        'cmbMjesta
        '
        Me.cmbMjesta.Location = New System.Drawing.Point(124, 127)
        Me.cmbMjesta.Name = "cmbMjesta"
        Me.cmbMjesta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMjesta.Size = New System.Drawing.Size(208, 20)
        Me.cmbMjesta.TabIndex = 9
        '
        'dtp
        '
        Me.dtp.EditValue = Nothing
        Me.dtp.Location = New System.Drawing.Point(124, 157)
        Me.dtp.Name = "dtp"
        Me.dtp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtp.Size = New System.Drawing.Size(114, 20)
        Me.dtp.TabIndex = 8
        '
        'txtFKomentar
        '
        Me.txtFKomentar.Location = New System.Drawing.Point(124, 187)
        Me.txtFKomentar.Name = "txtFKomentar"
        Me.txtFKomentar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFKomentar.Size = New System.Drawing.Size(114, 20)
        Me.txtFKomentar.TabIndex = 7
        '
        'lblFZanimanje
        '
        Me.lblFZanimanje.Location = New System.Drawing.Point(14, 71)
        Me.lblFZanimanje.Name = "lblFZanimanje"
        Me.lblFZanimanje.Size = New System.Drawing.Size(53, 13)
        Me.lblFZanimanje.TabIndex = 6
        Me.lblFZanimanje.Text = "Zanimanje:"
        '
        'cmbStupanj
        '
        Me.cmbStupanj.Location = New System.Drawing.Point(124, 38)
        Me.cmbStupanj.Name = "cmbStupanj"
        Me.cmbStupanj.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStupanj.Size = New System.Drawing.Size(208, 20)
        Me.cmbStupanj.TabIndex = 5
        '
        'lblFKomentar
        '
        Me.lblFKomentar.Location = New System.Drawing.Point(14, 191)
        Me.lblFKomentar.Name = "lblFKomentar"
        Me.lblFKomentar.Size = New System.Drawing.Size(50, 13)
        Me.lblFKomentar.TabIndex = 4
        Me.lblFKomentar.Text = "Komentar:"
        '
        'lblFDatum
        '
        Me.lblFDatum.Location = New System.Drawing.Point(13, 161)
        Me.lblFDatum.Name = "lblFDatum"
        Me.lblFDatum.Size = New System.Drawing.Size(85, 13)
        Me.lblFDatum.TabIndex = 3
        Me.lblFDatum.Text = "Datum završetka:"
        '
        'lblFMjesto
        '
        Me.lblFMjesto.Location = New System.Drawing.Point(13, 131)
        Me.lblFMjesto.Name = "lblFMjesto"
        Me.lblFMjesto.Size = New System.Drawing.Size(36, 13)
        Me.lblFMjesto.TabIndex = 2
        Me.lblFMjesto.Text = "Mjesto:"
        '
        'lblFUstanova
        '
        Me.lblFUstanova.Location = New System.Drawing.Point(13, 101)
        Me.lblFUstanova.Name = "lblFUstanova"
        Me.lblFUstanova.Size = New System.Drawing.Size(105, 13)
        Me.lblFUstanova.TabIndex = 1
        Me.lblFUstanova.Text = "Obrazovna ustanova:"
        '
        'lblFstupanj
        '
        Me.lblFstupanj.Location = New System.Drawing.Point(14, 41)
        Me.lblFstupanj.Name = "lblFstupanj"
        Me.lblFstupanj.Size = New System.Drawing.Size(104, 13)
        Me.lblFstupanj.TabIndex = 0
        Me.lblFstupanj.Text = "Stupanj obrazovanja:"
        '
        'gridFormal
        '
        Me.gridFormal.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridFormal.Location = New System.Drawing.Point(8, 8)
        Me.gridFormal.MainView = Me.gridViewFormal
        Me.gridFormal.Name = "gridFormal"
        Me.gridFormal.Size = New System.Drawing.Size(209, 303)
        Me.gridFormal.TabIndex = 5
        Me.gridFormal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewFormal})
        '
        'gridViewFormal
        '
        Me.gridViewFormal.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewFormal.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewFormal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNaziv, Me.colKratica})
        Me.gridViewFormal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridViewFormal.GridControl = Me.gridFormal
        Me.gridViewFormal.Name = "gridViewFormal"
        Me.gridViewFormal.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewFormal.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewFormal.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridViewFormal.OptionsBehavior.Editable = False
        Me.gridViewFormal.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gridViewFormal.OptionsCustomization.AllowColumnResizing = False
        Me.gridViewFormal.OptionsNavigation.AutoFocusNewRow = True
        Me.gridViewFormal.OptionsNavigation.AutoMoveRowFocus = False
        Me.gridViewFormal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewFormal.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewFormal.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewFormal.OptionsView.ShowGroupPanel = False
        Me.gridViewFormal.OptionsView.ShowIndicator = False
        Me.gridViewFormal.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Width = 150
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "zanimanje"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 0
        Me.colNaziv.Width = 172
        '
        'colKratica
        '
        Me.colKratica.Caption = "Kratica"
        Me.colKratica.FieldName = "kratica"
        Me.colKratica.Name = "colKratica"
        Me.colKratica.Visible = True
        Me.colKratica.VisibleIndex = 1
        Me.colKratica.Width = 40
        '
        'tabCertifikati
        '
        Me.tabCertifikati.Controls.Add(Me.gridCert)
        Me.tabCertifikati.Controls.Add(Me.groupCertifikat)
        Me.tabCertifikati.Name = "tabCertifikati"
        Me.tabCertifikati.Size = New System.Drawing.Size(578, 325)
        Me.tabCertifikati.Text = "Certifikati"
        '
        'gridCert
        '
        Me.gridCert.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridCert.Location = New System.Drawing.Point(8, 8)
        Me.gridCert.MainView = Me.gridViewCertifikat
        Me.gridCert.Name = "gridCert"
        Me.gridCert.Size = New System.Drawing.Size(209, 303)
        Me.gridCert.TabIndex = 8
        Me.gridCert.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCertifikat})
        '
        'gridViewCertifikat
        '
        Me.gridViewCertifikat.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewCertifikat.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewCertifikat.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colNaziv2})
        Me.gridViewCertifikat.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridViewCertifikat.GridControl = Me.gridCert
        Me.gridViewCertifikat.Name = "gridViewCertifikat"
        Me.gridViewCertifikat.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewCertifikat.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewCertifikat.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridViewCertifikat.OptionsBehavior.Editable = False
        Me.gridViewCertifikat.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gridViewCertifikat.OptionsCustomization.AllowColumnResizing = False
        Me.gridViewCertifikat.OptionsNavigation.AutoFocusNewRow = True
        Me.gridViewCertifikat.OptionsNavigation.AutoMoveRowFocus = False
        Me.gridViewCertifikat.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewCertifikat.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewCertifikat.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewCertifikat.OptionsView.ShowGroupPanel = False
        Me.gridViewCertifikat.OptionsView.ShowIndicator = False
        Me.gridViewCertifikat.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'colID2
        '
        Me.colID2.Caption = "ID"
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        Me.colID2.Width = 150
        '
        'colNaziv2
        '
        Me.colNaziv2.Caption = "Naziv"
        Me.colNaziv2.FieldName = "naziv"
        Me.colNaziv2.Name = "colNaziv2"
        Me.colNaziv2.Visible = True
        Me.colNaziv2.VisibleIndex = 0
        Me.colNaziv2.Width = 172
        '
        'groupCertifikat
        '
        Me.groupCertifikat.Controls.Add(Me.txtCCijena)
        Me.groupCertifikat.Controls.Add(Me.lblCCijena)
        Me.groupCertifikat.Controls.Add(Me.chkCRadnaKnj)
        Me.groupCertifikat.Controls.Add(Me.lblCChkUpis)
        Me.groupCertifikat.Controls.Add(Me.txtCCertifikat)
        Me.groupCertifikat.Controls.Add(Me.txtCUstanova)
        Me.groupCertifikat.Controls.Add(Me.cmbCMjesto)
        Me.groupCertifikat.Controls.Add(Me.dtpC)
        Me.groupCertifikat.Controls.Add(Me.txtCKomentar)
        Me.groupCertifikat.Controls.Add(Me.lblCertifikat)
        Me.groupCertifikat.Controls.Add(Me.lblCKomentar)
        Me.groupCertifikat.Controls.Add(Me.lblCDatum)
        Me.groupCertifikat.Controls.Add(Me.lblCMjesto)
        Me.groupCertifikat.Controls.Add(Me.lblCUstanova)
        Me.groupCertifikat.Location = New System.Drawing.Point(223, 8)
        Me.groupCertifikat.Name = "groupCertifikat"
        Me.groupCertifikat.Size = New System.Drawing.Size(345, 303)
        Me.groupCertifikat.TabIndex = 7
        Me.groupCertifikat.Text = "Certifikati"
        '
        'txtCCijena
        '
        Me.txtCCijena.Location = New System.Drawing.Point(124, 214)
        Me.txtCCijena.Name = "txtCCijena"
        Me.txtCCijena.Properties.Mask.EditMask = "C"
        Me.txtCCijena.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCCijena.Properties.MaxLength = 15
        Me.txtCCijena.Size = New System.Drawing.Size(148, 20)
        Me.txtCCijena.TabIndex = 15
        '
        'lblCCijena
        '
        Me.lblCCijena.Location = New System.Drawing.Point(13, 217)
        Me.lblCCijena.Name = "lblCCijena"
        Me.lblCCijena.Size = New System.Drawing.Size(34, 13)
        Me.lblCCijena.TabIndex = 14
        Me.lblCCijena.Text = "Cijena:"
        '
        'chkCRadnaKnj
        '
        Me.chkCRadnaKnj.Location = New System.Drawing.Point(124, 160)
        Me.chkCRadnaKnj.Name = "chkCRadnaKnj"
        Me.chkCRadnaKnj.Size = New System.Drawing.Size(75, 19)
        Me.chkCRadnaKnj.TabIndex = 13
        '
        'lblCChkUpis
        '
        Me.lblCChkUpis.Location = New System.Drawing.Point(14, 163)
        Me.lblCChkUpis.Name = "lblCChkUpis"
        Me.lblCChkUpis.Size = New System.Drawing.Size(101, 13)
        Me.lblCChkUpis.TabIndex = 12
        Me.lblCChkUpis.Text = "Upis u radnu knjižicu:"
        '
        'txtCCertifikat
        '
        Me.txtCCertifikat.Location = New System.Drawing.Point(126, 42)
        Me.txtCCertifikat.Name = "txtCCertifikat"
        Me.txtCCertifikat.Size = New System.Drawing.Size(207, 20)
        Me.txtCCertifikat.TabIndex = 11
        '
        'txtCUstanova
        '
        Me.txtCUstanova.Location = New System.Drawing.Point(125, 72)
        Me.txtCUstanova.Name = "txtCUstanova"
        Me.txtCUstanova.Size = New System.Drawing.Size(207, 20)
        Me.txtCUstanova.TabIndex = 10
        '
        'cmbCMjesto
        '
        Me.cmbCMjesto.Location = New System.Drawing.Point(125, 101)
        Me.cmbCMjesto.Name = "cmbCMjesto"
        Me.cmbCMjesto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCMjesto.Size = New System.Drawing.Size(208, 20)
        Me.cmbCMjesto.TabIndex = 9
        '
        'dtpC
        '
        Me.dtpC.EditValue = Nothing
        Me.dtpC.Location = New System.Drawing.Point(125, 131)
        Me.dtpC.Name = "dtpC"
        Me.dtpC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpC.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpC.Size = New System.Drawing.Size(114, 20)
        Me.dtpC.TabIndex = 8
        '
        'txtCKomentar
        '
        Me.txtCKomentar.Location = New System.Drawing.Point(124, 188)
        Me.txtCKomentar.Name = "txtCKomentar"
        Me.txtCKomentar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCKomentar.Size = New System.Drawing.Size(114, 20)
        Me.txtCKomentar.TabIndex = 7
        '
        'lblCertifikat
        '
        Me.lblCertifikat.Location = New System.Drawing.Point(15, 45)
        Me.lblCertifikat.Name = "lblCertifikat"
        Me.lblCertifikat.Size = New System.Drawing.Size(48, 13)
        Me.lblCertifikat.TabIndex = 6
        Me.lblCertifikat.Text = "Certifikat:"
        '
        'lblCKomentar
        '
        Me.lblCKomentar.Location = New System.Drawing.Point(14, 192)
        Me.lblCKomentar.Name = "lblCKomentar"
        Me.lblCKomentar.Size = New System.Drawing.Size(50, 13)
        Me.lblCKomentar.TabIndex = 4
        Me.lblCKomentar.Text = "Komentar:"
        '
        'lblCDatum
        '
        Me.lblCDatum.Location = New System.Drawing.Point(14, 135)
        Me.lblCDatum.Name = "lblCDatum"
        Me.lblCDatum.Size = New System.Drawing.Size(85, 13)
        Me.lblCDatum.TabIndex = 3
        Me.lblCDatum.Text = "Datum završetka:"
        '
        'lblCMjesto
        '
        Me.lblCMjesto.Location = New System.Drawing.Point(14, 105)
        Me.lblCMjesto.Name = "lblCMjesto"
        Me.lblCMjesto.Size = New System.Drawing.Size(36, 13)
        Me.lblCMjesto.TabIndex = 2
        Me.lblCMjesto.Text = "Mjesto:"
        '
        'lblCUstanova
        '
        Me.lblCUstanova.Location = New System.Drawing.Point(14, 75)
        Me.lblCUstanova.Name = "lblCUstanova"
        Me.lblCUstanova.Size = New System.Drawing.Size(105, 13)
        Me.lblCUstanova.TabIndex = 1
        Me.lblCUstanova.Text = "Obrazovna ustanova:"
        '
        'tabSeminari
        '
        Me.tabSeminari.Controls.Add(Me.groupSeminari)
        Me.tabSeminari.Controls.Add(Me.gridSeminar)
        Me.tabSeminari.Name = "tabSeminari"
        Me.tabSeminari.Size = New System.Drawing.Size(578, 325)
        Me.tabSeminari.Text = "Seminari"
        '
        'groupSeminari
        '
        Me.groupSeminari.Controls.Add(Me.LabelControl11)
        Me.groupSeminari.Controls.Add(Me.TextEdit7)
        Me.groupSeminari.Controls.Add(Me.LabelControl5)
        Me.groupSeminari.Controls.Add(Me.TextEdit5)
        Me.groupSeminari.Controls.Add(Me.TextEdit6)
        Me.groupSeminari.Controls.Add(Me.lblSeminarNaziv)
        Me.groupSeminari.Controls.Add(Me.LabelControl10)
        Me.groupSeminari.Location = New System.Drawing.Point(223, 8)
        Me.groupSeminari.Name = "groupSeminari"
        Me.groupSeminari.Size = New System.Drawing.Size(345, 303)
        Me.groupSeminari.TabIndex = 7
        Me.groupSeminari.Text = "Seminari"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(142, 98)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "sati"
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(80, 95)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(56, 20)
        Me.TextEdit7.TabIndex = 19
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 98)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Trajanje:"
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(80, 36)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(207, 20)
        Me.TextEdit5.TabIndex = 17
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(80, 66)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(207, 20)
        Me.TextEdit6.TabIndex = 16
        '
        'lblSeminarNaziv
        '
        Me.lblSeminarNaziv.Location = New System.Drawing.Point(13, 39)
        Me.lblSeminarNaziv.Name = "lblSeminarNaziv"
        Me.lblSeminarNaziv.Size = New System.Drawing.Size(38, 13)
        Me.lblSeminarNaziv.TabIndex = 14
        Me.lblSeminarNaziv.Text = "Seminar"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(13, 69)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl10.TabIndex = 13
        Me.LabelControl10.Text = "Mjesto:"
        '
        'gridSeminar
        '
        Me.gridSeminar.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridSeminar.Location = New System.Drawing.Point(8, 8)
        Me.gridSeminar.MainView = Me.gridViewSeminar
        Me.gridSeminar.Name = "gridSeminar"
        Me.gridSeminar.Size = New System.Drawing.Size(209, 303)
        Me.gridSeminar.TabIndex = 6
        Me.gridSeminar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewSeminar})
        '
        'gridViewSeminar
        '
        Me.gridViewSeminar.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewSeminar.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewSeminar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.gridViewSeminar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridViewSeminar.GridControl = Me.gridSeminar
        Me.gridViewSeminar.Name = "gridViewSeminar"
        Me.gridViewSeminar.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewSeminar.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewSeminar.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridViewSeminar.OptionsBehavior.Editable = False
        Me.gridViewSeminar.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gridViewSeminar.OptionsCustomization.AllowColumnResizing = False
        Me.gridViewSeminar.OptionsNavigation.AutoFocusNewRow = True
        Me.gridViewSeminar.OptionsNavigation.AutoMoveRowFocus = False
        Me.gridViewSeminar.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewSeminar.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewSeminar.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewSeminar.OptionsView.ShowGroupPanel = False
        Me.gridViewSeminar.OptionsView.ShowIndicator = False
        Me.gridViewSeminar.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ID"
        Me.GridColumn3.FieldName = "id"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Width = 150
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Naziv"
        Me.GridColumn4.FieldName = "naziv"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'tabKompetencije
        '
        Me.tabKompetencije.Name = "tabKompetencije"
        Me.tabKompetencije.Size = New System.Drawing.Size(578, 325)
        Me.tabKompetencije.Text = "Kompetencije"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(372, 352)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 21)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "&Spremi"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(478, 352)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 21)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "I&zlaz"
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Location = New System.Drawing.Point(4, 352)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(117, 21)
        Me.cmdNew.TabIndex = 7
        Me.cmdNew.Text = "&Novi unos"
        '
        'frmObrazovanje
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 378)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmObrazovanje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmObrazovanje"
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tabFormalno.ResumeLayout(False)
        CType(Me.groupFormalno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupFormalno.ResumeLayout(False)
        Me.groupFormalno.PerformLayout()
        CType(Me.txtFZanimanje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFUstanova.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMjesta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFKomentar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStupanj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridFormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewFormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCertifikati.ResumeLayout(False)
        CType(Me.gridCert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewCertifikat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupCertifikat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupCertifikat.ResumeLayout(False)
        Me.groupCertifikat.PerformLayout()
        CType(Me.txtCCijena.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCRadnaKnj.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCCertifikat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCUstanova.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCMjesto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpC.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCKomentar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSeminari.ResumeLayout(False)
        CType(Me.groupSeminari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupSeminari.ResumeLayout(False)
        Me.groupSeminari.PerformLayout()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridSeminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewSeminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabFormalno As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents groupFormalno As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFZanimanje As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFUstanova As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbMjesta As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFKomentar As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents lblFZanimanje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStupanj As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblFKomentar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFDatum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFMjesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFUstanova As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFstupanj As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridFormal As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewFormal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabCertifikati As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents groupCertifikat As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCCertifikat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCUstanova As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbCMjesto As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents dtpC As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCKomentar As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents lblCertifikat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCKomentar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCDatum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCMjesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCUstanova As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabSeminari As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents groupSeminari As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSeminarNaziv As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridSeminar As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewSeminar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkCRadnaKnj As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblCChkUpis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colKratica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCCijena As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCCijena As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gridCert As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewCertifikat As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabKompetencije As DevExpress.XtraTab.XtraTabPage
End Class
