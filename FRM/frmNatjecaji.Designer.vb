<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNatjecaji
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
        Me.gridFormal = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRadnoMjesto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLokacija = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdjel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrsta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatumDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrijava = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridFormal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridFormal
        '
        Me.gridFormal.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.gridFormal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridFormal.Location = New System.Drawing.Point(0, 0)
        Me.gridFormal.MainView = Me.GridView1
        Me.gridFormal.Name = "gridFormal"
        Me.gridFormal.Size = New System.Drawing.Size(947, 280)
        Me.gridFormal.TabIndex = 8
        Me.gridFormal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridFormal
        Me.GridView1.Name = "GridView1"
        '
        'grid
        '
        Me.grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(937, 292)
        Me.grid.TabIndex = 9
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNaziv, Me.colRadnoMjesto, Me.colLokacija, Me.colOdjel, Me.colVrsta, Me.colDatumOD, Me.colDatumDO, Me.colStatus, Me.colPrijava})
        Me.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gridView.OptionsCustomization.AllowColumnResizing = False
        Me.gridView.OptionsNavigation.AutoFocusNewRow = True
        Me.gridView.OptionsNavigation.AutoMoveRowFocus = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
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
        Me.colNaziv.FieldName = "naziv"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 0
        Me.colNaziv.Width = 161
        '
        'colRadnoMjesto
        '
        Me.colRadnoMjesto.Caption = "Radno mjesto"
        Me.colRadnoMjesto.FieldName = "radMjesto"
        Me.colRadnoMjesto.Name = "colRadnoMjesto"
        Me.colRadnoMjesto.Visible = True
        Me.colRadnoMjesto.VisibleIndex = 1
        Me.colRadnoMjesto.Width = 161
        '
        'colLokacija
        '
        Me.colLokacija.Caption = "Lokacija"
        Me.colLokacija.FieldName = "lokacija"
        Me.colLokacija.Name = "colLokacija"
        Me.colLokacija.Visible = True
        Me.colLokacija.VisibleIndex = 2
        Me.colLokacija.Width = 96
        '
        'colOdjel
        '
        Me.colOdjel.Caption = "Odjel"
        Me.colOdjel.FieldName = "odjel"
        Me.colOdjel.Name = "colOdjel"
        Me.colOdjel.Visible = True
        Me.colOdjel.VisibleIndex = 3
        Me.colOdjel.Width = 96
        '
        'colVrsta
        '
        Me.colVrsta.Caption = "Vrsta zapošljavanja"
        Me.colVrsta.FieldName = "vrstaZaposlenja"
        Me.colVrsta.Name = "colVrsta"
        Me.colVrsta.Visible = True
        Me.colVrsta.VisibleIndex = 4
        Me.colVrsta.Width = 100
        '
        'colDatumOD
        '
        Me.colDatumOD.Caption = "Otvaranje"
        Me.colDatumOD.FieldName = "pocetak"
        Me.colDatumOD.Name = "colDatumOD"
        Me.colDatumOD.Visible = True
        Me.colDatumOD.VisibleIndex = 5
        Me.colDatumOD.Width = 62
        '
        'colDatumDO
        '
        Me.colDatumDO.Caption = "Zatvaranje"
        Me.colDatumDO.FieldName = "kraj"
        Me.colDatumDO.Name = "colDatumDO"
        Me.colDatumDO.Visible = True
        Me.colDatumDO.VisibleIndex = 6
        Me.colDatumDO.Width = 62
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 7
        Me.colStatus.Width = 115
        '
        'colPrijava
        '
        Me.colPrijava.Caption = "Prijava"
        Me.colPrijava.FieldName = "prijava"
        Me.colPrijava.Name = "colPrijava"
        Me.colPrijava.Visible = True
        Me.colPrijava.VisibleIndex = 8
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdEdit)
        Me.PanelControl1.Controls.Add(Me.cmdNew)
        Me.PanelControl1.Controls.Add(Me.cmdPrint)
        Me.PanelControl1.Controls.Add(Me.cmdExit)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 292)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(937, 39)
        Me.PanelControl1.TabIndex = 10
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(619, 6)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(103, 23)
        Me.cmdEdit.TabIndex = 17
        Me.cmdEdit.Text = "&Uredi"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(5, 6)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 23)
        Me.cmdNew.TabIndex = 16
        Me.cmdNew.Text = "&Novi unos"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(728, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(99, 23)
        Me.cmdPrint.TabIndex = 15
        Me.cmdPrint.Text = "Is&pis"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(833, 6)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 23)
        Me.cmdExit.TabIndex = 14
        Me.cmdExit.Text = "&Izlaz"
        '
        'frmNatjecaji
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 331)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.PanelControl1)
        Me.IsMdiContainer = True
        Me.Name = "frmNatjecaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNatjecaji"
        CType(Me.gridFormal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridFormal As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRadnoMjesto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLokacija As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdjel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrsta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatumDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrijava As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
