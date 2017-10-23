<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKomentari
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKomentari))
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExport = New DevExpress.XtraEditors.SimpleButton()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDZAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpisZAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperZAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjektID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colZadatakIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpisIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatusIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKomentIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repKomentar = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colVrijemeIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOsobaIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDIZV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDPRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpisPRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperPRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmbPrioritet = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.CardView2 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjekt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVoditelj = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKomentar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPrioritet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(510, 394)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(95, 23)
        Me.cmdPrint.TabIndex = 33
        Me.cmdPrint.Text = "Is&pis"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(611, 394)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 23)
        Me.cmdExit.TabIndex = 32
        Me.cmdExit.Text = "&Odustani"
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(409, 394)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(95, 23)
        Me.cmdExport.TabIndex = 34
        Me.cmdExport.Text = "I&zvoz"
        '
        'grid
        '
        GridLevelNode1.LevelTemplate = Me.GridView2
        GridLevelNode2.LevelTemplate = Me.GridView3
        GridLevelNode2.RelationName = "subGrid2"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        GridLevelNode1.RelationName = "subGrid"
        Me.grid.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grid.Location = New System.Drawing.Point(1, 0)
        Me.grid.MainView = Me.GridView1
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repKomentar, Me.RepositoryItemImageEdit1, Me.RepositoryItemComboBox1, Me.cmbPrioritet})
        Me.grid.Size = New System.Drawing.Size(699, 388)
        Me.grid.TabIndex = 35
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView3, Me.GridView1, Me.CardView2, Me.gridView4})
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Purple
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Purple
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.GridView2.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView2.Appearance.Preview.ForeColor = System.Drawing.Color.Purple
        Me.GridView2.Appearance.Preview.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.Silver
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDZAD, Me.colOpisZAD, Me.colOperZAD, Me.colProjektID})
        Me.GridView2.GridControl = Me.grid
        Me.GridView2.LevelIndent = 50
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        Me.GridView2.SynchronizeClones = False
        '
        'colIDZAD
        '
        Me.colIDZAD.Caption = "ID"
        Me.colIDZAD.FieldName = "idZAD"
        Me.colIDZAD.Name = "colIDZAD"
        Me.colIDZAD.Visible = True
        Me.colIDZAD.VisibleIndex = 0
        Me.colIDZAD.Width = 56
        '
        'colOpisZAD
        '
        Me.colOpisZAD.Caption = "Zadatak"
        Me.colOpisZAD.FieldName = "nazivZad"
        Me.colOpisZAD.Name = "colOpisZAD"
        Me.colOpisZAD.Visible = True
        Me.colOpisZAD.VisibleIndex = 1
        Me.colOpisZAD.Width = 252
        '
        'colOperZAD
        '
        Me.colOperZAD.Caption = "Voditelj"
        Me.colOperZAD.FieldName = "voditelj"
        Me.colOperZAD.Name = "colOperZAD"
        Me.colOperZAD.Visible = True
        Me.colOperZAD.VisibleIndex = 2
        Me.colOperZAD.Width = 275
        '
        'colProjektID
        '
        Me.colProjektID.Caption = "ProjektID"
        Me.colProjektID.FieldName = "projekt"
        Me.colProjektID.Name = "colProjektID"
        '
        'GridView3
        '
        Me.GridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView3.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView3.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colZadatakIZV, Me.colOpisIZV, Me.colStatusIZV, Me.colKomentIZV, Me.colVrijemeIZV, Me.colOsobaIZV, Me.colIDIZV})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.GridControl = Me.grid
        Me.GridView3.GroupCount = 1
        Me.GridView3.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView3.OptionsView.EnableAppearanceOddRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        Me.GridView3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.GridView3.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOsobaIZV, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colZadatakIZV
        '
        Me.colZadatakIZV.Caption = "GridColumn8"
        Me.colZadatakIZV.FieldName = "zadatak"
        Me.colZadatakIZV.Name = "colZadatakIZV"
        '
        'colOpisIZV
        '
        Me.colOpisIZV.Caption = "Naziv"
        Me.colOpisIZV.FieldName = "sZadatak"
        Me.colOpisIZV.Name = "colOpisIZV"
        Me.colOpisIZV.Visible = True
        Me.colOpisIZV.VisibleIndex = 1
        Me.colOpisIZV.Width = 147
        '
        'colStatusIZV
        '
        Me.colStatusIZV.Caption = "Status"
        Me.colStatusIZV.FieldName = "Status"
        Me.colStatusIZV.Name = "colStatusIZV"
        Me.colStatusIZV.Visible = True
        Me.colStatusIZV.VisibleIndex = 2
        Me.colStatusIZV.Width = 221
        '
        'colKomentIZV
        '
        Me.colKomentIZV.Caption = "Komentar"
        Me.colKomentIZV.ColumnEdit = Me.repKomentar
        Me.colKomentIZV.FieldName = "komentar"
        Me.colKomentIZV.Name = "colKomentIZV"
        Me.colKomentIZV.Visible = True
        Me.colKomentIZV.VisibleIndex = 3
        Me.colKomentIZV.Width = 65
        '
        'repKomentar
        '
        Me.repKomentar.AutoHeight = False
        Me.repKomentar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKomentar.Name = "repKomentar"
        '
        'colVrijemeIZV
        '
        Me.colVrijemeIZV.Caption = "Vrijeme"
        Me.colVrijemeIZV.FieldName = "vrijeme"
        Me.colVrijemeIZV.Name = "colVrijemeIZV"
        Me.colVrijemeIZV.Visible = True
        Me.colVrijemeIZV.VisibleIndex = 4
        Me.colVrijemeIZV.Width = 67
        '
        'colOsobaIZV
        '
        Me.colOsobaIZV.Caption = "Osoba"
        Me.colOsobaIZV.FieldName = "Osoba"
        Me.colOsobaIZV.Name = "colOsobaIZV"
        Me.colOsobaIZV.Visible = True
        Me.colOsobaIZV.VisibleIndex = 5
        Me.colOsobaIZV.Width = 110
        '
        'colIDIZV
        '
        Me.colIDIZV.Caption = "ID"
        Me.colIDIZV.FieldName = "id"
        Me.colIDIZV.Name = "colIDIZV"
        Me.colIDIZV.Visible = True
        Me.colIDIZV.VisibleIndex = 0
        Me.colIDIZV.Width = 44
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDPRO, Me.GridColumn6, Me.colOpisPRO, Me.colOperPRO})
        Me.GridView1.GridControl = Me.grid
        Me.GridView1.LevelIndent = 2
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'colIDPRO
        '
        Me.colIDPRO.Caption = "ID"
        Me.colIDPRO.FieldName = "id"
        Me.colIDPRO.Name = "colIDPRO"
        Me.colIDPRO.Visible = True
        Me.colIDPRO.VisibleIndex = 0
        Me.colIDPRO.Width = 34
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "oper.ID"
        Me.GridColumn6.FieldName = "oper"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'colOpisPRO
        '
        Me.colOpisPRO.Caption = "Projekt"
        Me.colOpisPRO.FieldName = "naziv"
        Me.colOpisPRO.Name = "colOpisPRO"
        Me.colOpisPRO.Visible = True
        Me.colOpisPRO.VisibleIndex = 1
        Me.colOpisPRO.Width = 361
        '
        'colOperPRO
        '
        Me.colOperPRO.Caption = "Voditelj"
        Me.colOperPRO.FieldName = "sVoditelj"
        Me.colOperPRO.Name = "colOperPRO"
        Me.colOperPRO.Visible = True
        Me.colOperPRO.VisibleIndex = 2
        Me.colOperPRO.Width = 176
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'cmbPrioritet
        '
        Me.cmbPrioritet.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.cmbPrioritet.AutoHeight = False
        Me.cmbPrioritet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPrioritet.DropDownRows = 5
        Me.cmbPrioritet.ImmediatePopup = True
        Me.cmbPrioritet.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("0", CType(0, Short), 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", CType(1, Short), 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", CType(2, Short), 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", CType(3, Short), 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", CType(4, Short), 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("5", CType(5, Short), 5)})
        Me.cmbPrioritet.Name = "cmbPrioritet"
        '
        'CardView2
        '
        Me.CardView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.CardView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.CardView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.CardView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.CardView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.CardView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.CardView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.CardView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.CardView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.CardView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.CardView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.CardView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.CardView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.CardView2.FocusedCardTopFieldIndex = 0
        Me.CardView2.GridControl = Me.grid
        Me.CardView2.Name = "CardView2"
        Me.CardView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.CardView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.CardView2.OptionsBehavior.Editable = False
        Me.CardView2.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.CardView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 35
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "oper.ID"
        Me.GridColumn2.FieldName = "oper"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Projekt"
        Me.GridColumn3.FieldName = "sProjekt"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 180
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Voditelj"
        Me.GridColumn4.FieldName = "oper"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 86
        '
        'gridView4
        '
        Me.gridView4.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView4.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gridView4.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView4.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gridView4.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gridView4.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gridView4.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gridView4.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gridView4.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gridView4.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gridView4.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gridView4.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gridView4.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView4.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gridView4.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gridView4.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gridView4.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gridView4.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gridView4.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOperID, Me.colProjekt, Me.colVoditelj})
        Me.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView4.GridControl = Me.grid
        Me.gridView4.Name = "gridView4"
        Me.gridView4.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView4.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView4.OptionsBehavior.Editable = False
        Me.gridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView4.OptionsView.ShowGroupPanel = False
        Me.gridView4.OptionsView.ShowIndicator = False
        Me.gridView4.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 35
        '
        'colOperID
        '
        Me.colOperID.Caption = "oper.ID"
        Me.colOperID.FieldName = "oper"
        Me.colOperID.Name = "colOperID"
        '
        'colProjekt
        '
        Me.colProjekt.Caption = "Projekt"
        Me.colProjekt.FieldName = "sProjekt"
        Me.colProjekt.Name = "colProjekt"
        Me.colProjekt.Visible = True
        Me.colProjekt.VisibleIndex = 1
        Me.colProjekt.Width = 180
        '
        'colVoditelj
        '
        Me.colVoditelj.Caption = "Voditelj"
        Me.colVoditelj.FieldName = "oper"
        Me.colVoditelj.Name = "colVoditelj"
        Me.colVoditelj.Visible = True
        Me.colVoditelj.VisibleIndex = 2
        Me.colVoditelj.Width = 86
        '
        'frmKomentari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(700, 421)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKomentari"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pregled komentara"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKomentar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPrioritet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDZAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpisZAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperZAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjektID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colZadatakIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpisIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKomentIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repKomentar As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colVrijemeIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOsobaIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDIZV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDPRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpisPRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperPRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbPrioritet As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents CardView2 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjekt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVoditelj As DevExpress.XtraGrid.Columns.GridColumn
End Class
