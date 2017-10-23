<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrgJed
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gridViewSub = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDsub = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrgsub = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazivsub = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrijednostsub = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.trackTezina = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridViewSub2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDsub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOsobasub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRadnoMjsub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelsub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMobsub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailsub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSlikasub2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repImage = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSifra = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrgJed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTvrtkaNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTvrtkaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.progressVrijednost = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.groupStructure = New DevExpress.XtraEditors.GroupControl()
        Me.cmdRadMjUnos = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOrgJedNew = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gridViewSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackTezina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewSub2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressVrijednost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.groupStructure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupStructure.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridViewSub
        '
        Me.gridViewSub.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDsub, Me.colOrgsub, Me.colNazivsub, Me.colVrijednostsub})
        Me.gridViewSub.GridControl = Me.grid
        Me.gridViewSub.Name = "gridViewSub"
        Me.gridViewSub.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewSub.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewSub.OptionsBehavior.Editable = False
        Me.gridViewSub.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewSub.OptionsView.ShowGroupPanel = False
        Me.gridViewSub.OptionsView.ShowIndicator = False
        '
        'colIDsub
        '
        Me.colIDsub.Caption = "ID"
        Me.colIDsub.FieldName = "idsub"
        Me.colIDsub.Name = "colIDsub"
        '
        'colOrgsub
        '
        Me.colOrgsub.Caption = "Org.Id"
        Me.colOrgsub.FieldName = "organizacija"
        Me.colOrgsub.Name = "colOrgsub"
        '
        'colNazivsub
        '
        Me.colNazivsub.Caption = "Titula"
        Me.colNazivsub.FieldName = "naziv"
        Me.colNazivsub.Name = "colNazivsub"
        Me.colNazivsub.Visible = True
        Me.colNazivsub.VisibleIndex = 0
        '
        'colVrijednostsub
        '
        Me.colVrijednostsub.Caption = "Vrijednost"
        Me.colVrijednostsub.ColumnEdit = Me.trackTezina
        Me.colVrijednostsub.FieldName = "tezina"
        Me.colVrijednostsub.Name = "colVrijednostsub"
        Me.colVrijednostsub.Visible = True
        Me.colVrijednostsub.VisibleIndex = 1
        '
        'trackTezina
        '
        Me.trackTezina.Name = "trackTezina"
        Me.trackTezina.ShowValueToolTip = True
        Me.trackTezina.UseParentBackground = True
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gridViewSub
        GridLevelNode1.RelationName = "subGrid"
        GridLevelNode2.LevelTemplate = Me.gridViewSub2
        GridLevelNode2.RelationName = "subGrid2"
        Me.grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.grid.Location = New System.Drawing.Point(2, 22)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.progressVrijednost, Me.trackTezina, Me.repImage})
        Me.grid.Size = New System.Drawing.Size(613, 361)
        Me.grid.TabIndex = 7
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewSub2, Me.gridView, Me.gridViewSub})
        '
        'gridViewSub2
        '
        Me.gridViewSub2.Appearance.OddRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gridViewSub2.Appearance.OddRow.Options.UseBackColor = True
        Me.gridViewSub2.Appearance.Row.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.gridViewSub2.Appearance.Row.Options.UseBackColor = True
        Me.gridViewSub2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDsub2, Me.colOsobasub2, Me.colRadnoMjsub2, Me.colTelsub2, Me.colMobsub2, Me.colEmailsub2, Me.colSlikasub2})
        Me.gridViewSub2.GridControl = Me.grid
        Me.gridViewSub2.Name = "gridViewSub2"
        Me.gridViewSub2.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewSub2.OptionsView.ShowGroupPanel = False
        Me.gridViewSub2.OptionsView.ShowIndicator = False
        Me.gridViewSub2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'colIDsub2
        '
        Me.colIDsub2.Caption = "ID"
        Me.colIDsub2.FieldName = "id"
        Me.colIDsub2.Name = "colIDsub2"
        '
        'colOsobasub2
        '
        Me.colOsobasub2.Caption = "Osoba"
        Me.colOsobasub2.FieldName = "sOsoba"
        Me.colOsobasub2.Name = "colOsobasub2"
        Me.colOsobasub2.Visible = True
        Me.colOsobasub2.VisibleIndex = 1
        Me.colOsobasub2.Width = 112
        '
        'colRadnoMjsub2
        '
        Me.colRadnoMjsub2.Caption = "RadnoMj"
        Me.colRadnoMjsub2.FieldName = "radnoMj"
        Me.colRadnoMjsub2.Name = "colRadnoMjsub2"
        '
        'colTelsub2
        '
        Me.colTelsub2.Caption = "Tel."
        Me.colTelsub2.FieldName = "tel"
        Me.colTelsub2.Name = "colTelsub2"
        Me.colTelsub2.Visible = True
        Me.colTelsub2.VisibleIndex = 2
        Me.colTelsub2.Width = 112
        '
        'colMobsub2
        '
        Me.colMobsub2.Caption = "Mob."
        Me.colMobsub2.FieldName = "mob"
        Me.colMobsub2.Name = "colMobsub2"
        Me.colMobsub2.Visible = True
        Me.colMobsub2.VisibleIndex = 3
        Me.colMobsub2.Width = 112
        '
        'colEmailsub2
        '
        Me.colEmailsub2.Caption = "Email"
        Me.colEmailsub2.FieldName = "email"
        Me.colEmailsub2.Name = "colEmailsub2"
        Me.colEmailsub2.Visible = True
        Me.colEmailsub2.VisibleIndex = 4
        Me.colEmailsub2.Width = 112
        '
        'colSlikasub2
        '
        Me.colSlikasub2.Caption = "#"
        Me.colSlikasub2.ColumnEdit = Me.repImage
        Me.colSlikasub2.FieldName = "imageSlika"
        Me.colSlikasub2.Name = "colSlikasub2"
        Me.colSlikasub2.Visible = True
        Me.colSlikasub2.VisibleIndex = 0
        Me.colSlikasub2.Width = 40
        '
        'repImage
        '
        Me.repImage.AutoHeight = False
        Me.repImage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repImage.Name = "repImage"
        '
        'gridView
        '
        Me.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridView.Appearance.OddRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colSifra, Me.colNaziv, Me.colOrgJed, Me.colTvrtkaNaziv, Me.colTvrtkaID})
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 1
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowFooter = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTvrtkaNaziv, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSifra, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrgJed, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'colSifra
        '
        Me.colSifra.Caption = "Šifra"
        Me.colSifra.FieldName = "sifra"
        Me.colSifra.Name = "colSifra"
        Me.colSifra.Visible = True
        Me.colSifra.VisibleIndex = 2
        Me.colSifra.Width = 120
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "naziv"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 0
        Me.colNaziv.Width = 313
        '
        'colOrgJed
        '
        Me.colOrgJed.Caption = "Org.jed."
        Me.colOrgJed.FieldName = "orgJed"
        Me.colOrgJed.Name = "colOrgJed"
        Me.colOrgJed.Visible = True
        Me.colOrgJed.VisibleIndex = 1
        Me.colOrgJed.Width = 118
        '
        'colTvrtkaNaziv
        '
        Me.colTvrtkaNaziv.Caption = "Tvrtka"
        Me.colTvrtkaNaziv.FieldName = "sTvrtka"
        Me.colTvrtkaNaziv.Name = "colTvrtkaNaziv"
        '
        'colTvrtkaID
        '
        Me.colTvrtkaID.Caption = "TvrtkaID"
        Me.colTvrtkaID.FieldName = "tvrtka"
        Me.colTvrtkaID.Name = "colTvrtkaID"
        Me.colTvrtkaID.Width = 118
        '
        'progressVrijednost
        '
        Me.progressVrijednost.Name = "progressVrijednost"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.groupStructure)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdRadMjUnos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOrgJedNew)
        Me.SplitContainer1.Size = New System.Drawing.Size(617, 423)
        Me.SplitContainer1.SplitterDistance = 385
        Me.SplitContainer1.TabIndex = 10
        '
        'groupStructure
        '
        Me.groupStructure.Controls.Add(Me.grid)
        Me.groupStructure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupStructure.Location = New System.Drawing.Point(0, 0)
        Me.groupStructure.Name = "groupStructure"
        Me.groupStructure.Size = New System.Drawing.Size(617, 385)
        Me.groupStructure.TabIndex = 12
        Me.groupStructure.Text = "Struktura tvrtke"
        '
        'cmdRadMjUnos
        '
        Me.cmdRadMjUnos.Location = New System.Drawing.Point(144, 3)
        Me.cmdRadMjUnos.Name = "cmdRadMjUnos"
        Me.cmdRadMjUnos.Size = New System.Drawing.Size(135, 23)
        Me.cmdRadMjUnos.TabIndex = 4
        Me.cmdRadMjUnos.Text = "Radno mjesto"
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(371, 3)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(77, 23)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "&Uredi"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(454, 3)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(77, 23)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "Is&pis"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(537, 3)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(77, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "&Izlaz"
        '
        'cmdOrgJedNew
        '
        Me.cmdOrgJedNew.Location = New System.Drawing.Point(3, 3)
        Me.cmdOrgJedNew.Name = "cmdOrgJedNew"
        Me.cmdOrgJedNew.Size = New System.Drawing.Size(135, 23)
        Me.cmdOrgJedNew.TabIndex = 0
        Me.cmdOrgJedNew.Text = "Novi unos"
        '
        'frmOrgJed
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 423)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrgJed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmOrgJedvb"
        CType(Me.gridViewSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackTezina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewSub2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressVrijednost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.groupStructure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupStructure.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents groupStructure As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSifra As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrgJed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTvrtkaNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTvrtkaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOrgJedNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRadMjUnos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridViewSub As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDsub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrgsub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazivsub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrijednostsub As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridViewSub2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDsub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOsobasub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRadnoMjsub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents progressVrijednost As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents trackTezina As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents colTelsub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMobsub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailsub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSlikasub2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repImage As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
End Class
