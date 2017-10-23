<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelpdesk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelpdesk))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarCheckItem4 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem5 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem6 = New DevExpress.XtraBars.BarCheckItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.VGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.CategoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.EditorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.EditorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOznaka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repOznaka = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKlijent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repOpis = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colDetOpis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repDetOpis = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colRok = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repDatum = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colPrioritet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbPrior = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.cmdKlijent = New DevExpress.XtraNavBar.NavBarItem()
        Me.cmdStatusi = New DevExpress.XtraNavBar.NavBarItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repOznaka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repOpis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDetOpis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDatum.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPrior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.BarStaticItem1, Me.BarSubItem1, Me.BarCheckItem2, Me.BarCheckItem1, Me.BarCheckItem3, Me.BarSubItem2, Me.BarCheckItem4, Me.BarCheckItem5, Me.BarCheckItem6})
        Me.BarManager1.MaxItemId = 23
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Tools"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Ukupno stavki: 0"
        Me.BarStaticItem1.Id = 3
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Filter podataka"
        Me.BarSubItem2.Id = 14
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem6)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarCheckItem4
        '
        Me.BarCheckItem4.Caption = "Greška"
        Me.BarCheckItem4.Checked = True
        Me.BarCheckItem4.Id = 15
        Me.BarCheckItem4.Name = "BarCheckItem4"
        '
        'BarCheckItem5
        '
        Me.BarCheckItem5.Caption = "Izmjena / dorada"
        Me.BarCheckItem5.Checked = True
        Me.BarCheckItem5.Id = 16
        Me.BarCheckItem5.Name = "BarCheckItem5"
        '
        'BarCheckItem6
        '
        Me.BarCheckItem6.Caption = "Prijedlog"
        Me.BarCheckItem6.Checked = True
        Me.BarCheckItem6.Id = 17
        Me.BarCheckItem6.Name = "BarCheckItem6"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(870, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 394)
        Me.barDockControlBottom.Size = New System.Drawing.Size(870, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 365)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(870, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 365)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Filter"
        Me.BarSubItem1.Id = 5
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarCheckItem3)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarCheckItem2
        '
        Me.BarCheckItem2.Caption = "Greške"
        Me.BarCheckItem2.Id = 7
        Me.BarCheckItem2.Name = "BarCheckItem2"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Izmjene / Dorade"
        Me.BarCheckItem1.Id = 8
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarCheckItem3
        '
        Me.BarCheckItem3.Caption = "Prijedlozi"
        Me.BarCheckItem3.Id = 9
        Me.BarCheckItem3.Name = "BarCheckItem3"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.VGridControl1)
        Me.GroupControl1.Controls.Add(Me.grid)
        Me.GroupControl1.Location = New System.Drawing.Point(150, 29)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(712, 356)
        Me.GroupControl1.TabIndex = 16
        Me.GroupControl1.Text = "Pregled helpdesk zahtjeva"
        '
        'VGridControl1
        '
        Me.VGridControl1.Location = New System.Drawing.Point(-221, 5)
        Me.VGridControl1.Name = "VGridControl1"
        Me.VGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.CategoryRow1})
        Me.VGridControl1.Size = New System.Drawing.Size(215, 326)
        Me.VGridControl1.TabIndex = 32
        '
        'CategoryRow1
        '
        Me.CategoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.EditorRow1, Me.EditorRow3, Me.EditorRow2, Me.EditorRow4})
        Me.CategoryRow1.Name = "CategoryRow1"
        '
        'EditorRow1
        '
        Me.EditorRow1.Name = "EditorRow1"
        '
        'EditorRow3
        '
        Me.EditorRow3.Name = "EditorRow3"
        '
        'EditorRow2
        '
        Me.EditorRow2.Name = "EditorRow2"
        '
        'EditorRow4
        '
        Me.EditorRow4.Name = "EditorRow4"
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(2, 22)
        Me.grid.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repOznaka, Me.repOpis, Me.repDetOpis, Me.repDatum, Me.cmbPrior})
        Me.grid.Size = New System.Drawing.Size(708, 332)
        Me.grid.TabIndex = 46
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridView.Appearance.OddRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOznaka, Me.colNaziv, Me.colKlijent, Me.colOpis, Me.colDetOpis, Me.colRok, Me.colPrioritet})
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 1
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowFooter = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colKlijent, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'colOznaka
        '
        Me.colOznaka.Caption = "Oznaka"
        Me.colOznaka.ColumnEdit = Me.repOznaka
        Me.colOznaka.FieldName = "oznaka"
        Me.colOznaka.Name = "colOznaka"
        Me.colOznaka.Visible = True
        Me.colOznaka.VisibleIndex = 0
        Me.colOznaka.Width = 42
        '
        'repOznaka
        '
        Me.repOznaka.AutoHeight = False
        Me.repOznaka.Name = "repOznaka"
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "naziv"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 1
        Me.colNaziv.Width = 216
        '
        'colKlijent
        '
        Me.colKlijent.Caption = "Klijent"
        Me.colKlijent.FieldName = "klijent"
        Me.colKlijent.Name = "colKlijent"
        '
        'colOpis
        '
        Me.colOpis.Caption = "Opis"
        Me.colOpis.ColumnEdit = Me.repOpis
        Me.colOpis.FieldName = "opis"
        Me.colOpis.Name = "colOpis"
        Me.colOpis.Visible = True
        Me.colOpis.VisibleIndex = 2
        Me.colOpis.Width = 54
        '
        'repOpis
        '
        Me.repOpis.AutoHeight = False
        Me.repOpis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repOpis.Name = "repOpis"
        '
        'colDetOpis
        '
        Me.colDetOpis.Caption = "Det.Opis"
        Me.colDetOpis.ColumnEdit = Me.repDetOpis
        Me.colDetOpis.FieldName = "detOpis"
        Me.colDetOpis.Name = "colDetOpis"
        Me.colDetOpis.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colDetOpis.Visible = True
        Me.colDetOpis.VisibleIndex = 3
        Me.colDetOpis.Width = 394
        '
        'repDetOpis
        '
        Me.repDetOpis.AutoHeight = False
        Me.repDetOpis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDetOpis.Name = "repDetOpis"
        '
        'colRok
        '
        Me.colRok.Caption = "Rok"
        Me.colRok.ColumnEdit = Me.repDatum
        Me.colRok.FieldName = "rok"
        Me.colRok.Name = "colRok"
        Me.colRok.Visible = True
        Me.colRok.VisibleIndex = 4
        '
        'repDatum
        '
        Me.repDatum.AutoHeight = False
        Me.repDatum.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDatum.Name = "repDatum"
        Me.repDatum.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'colPrioritet
        '
        Me.colPrioritet.Caption = "Prioritet"
        Me.colPrioritet.ColumnEdit = Me.cmbPrior
        Me.colPrioritet.FieldName = "prioritet"
        Me.colPrioritet.Name = "colPrioritet"
        Me.colPrioritet.Visible = True
        Me.colPrioritet.VisibleIndex = 5
        '
        'cmbPrior
        '
        Me.cmbPrior.AutoHeight = False
        Me.cmbPrior.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPrior.Name = "cmbPrior"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.cmdKlijent, Me.cmdStatusi})
        Me.NavBarControl1.LargeImages = Me.ImageCollection1
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 29)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 193
        Me.NavBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.SideBar
        Me.NavBarControl1.Size = New System.Drawing.Size(144, 365)
        Me.NavBarControl1.TabIndex = 21
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Osnovno"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdKlijent), New DevExpress.XtraNavBar.NavBarItemLink(Me.cmdStatusi)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        '
        'cmdKlijent
        '
        Me.cmdKlijent.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.cmdKlijent.Caption = "Klijenti"
        Me.cmdKlijent.LargeImageIndex = 0
        Me.cmdKlijent.Name = "cmdKlijent"
        '
        'cmdStatusi
        '
        Me.cmdStatusi.Caption = "Statusi"
        Me.cmdStatusi.LargeImageIndex = 1
        Me.cmdStatusi.Name = "cmdStatusi"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "User 523.ico")
        Me.ImageCollection1.Images.SetKeyName(1, "Start Menu 498.ico")
        '
        'frmHelpdesk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(870, 420)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHelpdesk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Helpdesk"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.VGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repOznaka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repOpis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDetOpis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDatum.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDatum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPrior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarCheckItem2 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem3 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarCheckItem4 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem5 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarCheckItem6 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents CategoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents EditorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents EditorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents cmdKlijent As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents colOznaka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repOznaka As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKlijent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdStatusi As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents colOpis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repOpis As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colDetOpis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDetOpis As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colRok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDatum As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colPrioritet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPrior As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
End Class
