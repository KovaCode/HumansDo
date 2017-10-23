<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainNew
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainNew))
        Me.ribbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.smallImage = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cmdInfo2 = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdMessages = New DevExpress.XtraBars.BarButtonItem()
        Me.cmbFilter = New DevExpress.XtraBars.BarSubItem()
        Me.chkInactive = New DevExpress.XtraBars.BarCheckItem()
        Me.chkWork = New DevExpress.XtraBars.BarCheckItem()
        Me.chkValidate = New DevExpress.XtraBars.BarCheckItem()
        Me.chkTest = New DevExpress.XtraBars.BarCheckItem()
        Me.chkEnd = New DevExpress.XtraBars.BarCheckItem()
        Me.chkReturned = New DevExpress.XtraBars.BarCheckItem()
        Me.txtNow = New DevExpress.XtraBars.BarStaticItem()
        Me.txtOper = New DevExpress.XtraBars.BarStaticItem()
        Me.iPaint = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.largeImage = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.grid2 = New DevExpress.XtraGrid.GridControl()
        Me.grid2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUtroseno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.progressPosto = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.colStatus3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbStanjeImg = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.extraSmall = New DevExpress.Utils.ImageCollection(Me.components)
        Me.colStatus2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.panelGrid2 = New DevExpress.XtraEditors.PanelControl()
        Me.lblUkupnoI = New DevExpress.XtraEditors.LabelControl()
        Me.lblUkI = New DevExpress.XtraEditors.LabelControl()
        Me.cmdStartIzvr = New DevExpress.XtraEditors.SimpleButton()
        Me.group3 = New DevExpress.XtraEditors.GroupControl()
        Me.colUtrosenoo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVoditelj = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabDetail = New DevExpress.XtraTab.XtraTabPage()
        Me.group = New DevExpress.XtraEditors.GroupControl()
        Me.PGsystem = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.txtOperLogins = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtPravaLogins = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtIPlogins = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtUkOperLogins = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gridOperLogins = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridOper2Logins = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridOperLoginsView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtVrimLogins = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.gridtest = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtUsername = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtDatabase = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtJezik = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtSkin = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtLogged = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CategoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowOper = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowUsername = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPrava = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowVrim = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.CategoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowTotal = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowIP = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowBaza = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowJezik = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSkin = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.tabGraph = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.tab = New DevExpress.XtraTab.XtraTabControl()
        Me.colEnd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStart = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.group2 = New DevExpress.XtraEditors.GroupControl()
        Me.panelGrid = New DevExpress.XtraEditors.PanelControl()
        Me.lblUkupnoZ = New DevExpress.XtraEditors.LabelControl()
        Me.lblUkZad = New DevExpress.XtraEditors.LabelControl()
        Me.lblUkP = New DevExpress.XtraEditors.LabelControl()
        Me.lblUkupnoP = New DevExpress.XtraEditors.LabelControl()
        Me.cmdTest = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdActivate = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEndIzvr = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOvjeri = New DevExpress.XtraEditors.SimpleButton()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjekt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZadatak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioritet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrioritetIcon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repCmbPriorImg = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.colStatusOpis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjektID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrijemeZad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAktiv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbAktivZad = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.groupOperPro = New DevExpress.XtraEditors.GroupControl()
        Me.gridOper = New DevExpress.XtraGrid.GridControl()
        Me.gridViewOper = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazivOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrstaOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjektOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbAktivPro = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.chkAll = New DevExpress.XtraEditors.CheckEdit()
        Me.cmdInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.rightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolPrintPrew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolXLS = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolXLSX = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolHTML = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolRTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPoruke = New DevExpress.XtraBars.BarButtonItem()
        Me.iconOper = New DevExpress.XtraBars.BarStaticItem()
        Me.skinS = New DevExpress.XtraBars.BarLinkContainerItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.smallImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.largeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressPosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStanjeImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extraSmall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGrid2.SuspendLayout()
        CType(Me.group3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group3.SuspendLayout()
        CType(Me.group, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group.SuspendLayout()
        CType(Me.PGsystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOperLogins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPravaLogins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIPlogins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUkOperLogins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOperLogins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOper2Logins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOperLoginsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVrimLogins, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridtest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJezik, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLogged, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        CType(Me.group2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group2.SuspendLayout()
        CType(Me.panelGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGrid.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCmbPriorImg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAktivZad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.groupOperPro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupOperPro.SuspendLayout()
        CType(Me.gridOper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewOper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAktivPro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.rightClickMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbon
        '
        Me.ribbon.ApplicationButtonText = Nothing
        Me.ribbon.ApplicationIcon = CType(resources.GetObject("ribbon.ApplicationIcon"), System.Drawing.Bitmap)
        '
        '
        '
        Me.ribbon.ExpandCollapseItem.Id = 0
        Me.ribbon.ExpandCollapseItem.Name = "Null"
        Me.ribbon.Images = Me.smallImage
        Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbon.ExpandCollapseItem, Me.cmdInfo2, Me.cmdMessages, Me.cmbFilter, Me.chkInactive, Me.chkWork, Me.chkValidate, Me.chkTest, Me.chkEnd, Me.chkReturned, Me.txtNow, Me.txtOper, Me.iPaint, Me.cmdRefresh})
        Me.ribbon.LargeImages = Me.largeImage
        Me.ribbon.Location = New System.Drawing.Point(0, 0)
        Me.ribbon.MaxItemId = 22
        Me.ribbon.Name = "ribbon"
        Me.ribbon.PageHeaderItemLinks.Add(Me.cmdRefresh)
        Me.ribbon.PageHeaderItemLinks.Add(Me.cmdInfo2)
        Me.ribbon.PageHeaderItemLinks.Add(Me.iPaint)
        Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ribbon.SelectedPage = Me.RibbonPage1
        Me.ribbon.Size = New System.Drawing.Size(1280, 149)
        Me.ribbon.StatusBar = Me.RibbonStatusBar
        '
        'smallImage
        '
        Me.smallImage.ImageSize = New System.Drawing.Size(24, 24)
        Me.smallImage.ImageStream = CType(resources.GetObject("smallImage.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.smallImage.Images.SetKeyName(0, "word.ico")
        Me.smallImage.Images.SetKeyName(1, "word.ico")
        Me.smallImage.Images.SetKeyName(2, "pdf.ico")
        Me.smallImage.Images.SetKeyName(3, "xls.ico")
        Me.smallImage.Images.SetKeyName(4, "Document Code HTML.ico")
        Me.smallImage.Images.SetKeyName(5, "Control Panel 27.ico")
        Me.smallImage.Images.SetKeyName(6, "Control Panel 47.ico")
        Me.smallImage.Images.SetKeyName(7, "Folder 207.ico")
        Me.smallImage.Images.SetKeyName(8, "Control Panel 52.ico")
        Me.smallImage.Images.SetKeyName(9, "Control Panel 51.ico")
        Me.smallImage.Images.SetKeyName(10, "Start Menu 499.ico")
        Me.smallImage.Images.SetKeyName(11, "flg-m-1.gif")
        Me.smallImage.Images.SetKeyName(12, "flg-m-2.gif")
        Me.smallImage.Images.SetKeyName(13, "flg-m-3.gif")
        Me.smallImage.Images.SetKeyName(14, "flg-m-4.gif")
        Me.smallImage.Images.SetKeyName(15, "flg-m-5.gif")
        Me.smallImage.Images.SetKeyName(16, "flg-m-6.gif")
        Me.smallImage.Images.SetKeyName(17, "Start Menu 488.ico")
        Me.smallImage.Images.SetKeyName(18, "nav_plain_green.png")
        Me.smallImage.Images.SetKeyName(19, "nav_plain_red.png")
        Me.smallImage.Images.SetKeyName(20, "User 526.ico")
        '
        'cmdInfo2
        '
        Me.cmdInfo2.Glyph = CType(resources.GetObject("cmdInfo2.Glyph"), System.Drawing.Image)
        Me.cmdInfo2.Id = 3
        Me.cmdInfo2.Name = "cmdInfo2"
        '
        'cmdMessages
        '
        Me.cmdMessages.Caption = "Poruke i obavijesti"
        Me.cmdMessages.Glyph = CType(resources.GetObject("cmdMessages.Glyph"), System.Drawing.Image)
        Me.cmdMessages.Id = 4
        Me.cmdMessages.Name = "cmdMessages"
        '
        'cmbFilter
        '
        Me.cmbFilter.Caption = "Filter zadataka"
        Me.cmbFilter.Glyph = CType(resources.GetObject("cmbFilter.Glyph"), System.Drawing.Image)
        Me.cmbFilter.Id = 5
        Me.cmbFilter.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.chkInactive), New DevExpress.XtraBars.LinkPersistInfo(Me.chkWork), New DevExpress.XtraBars.LinkPersistInfo(Me.chkValidate), New DevExpress.XtraBars.LinkPersistInfo(Me.chkTest), New DevExpress.XtraBars.LinkPersistInfo(Me.chkEnd), New DevExpress.XtraBars.LinkPersistInfo(Me.chkReturned)})
        Me.cmbFilter.Name = "cmbFilter"
        '
        'chkInactive
        '
        Me.chkInactive.Caption = "Za aktivaciju"
        Me.chkInactive.Checked = True
        Me.chkInactive.Id = 6
        Me.chkInactive.Name = "chkInactive"
        '
        'chkWork
        '
        Me.chkWork.Caption = "Aktivni"
        Me.chkWork.Checked = True
        Me.chkWork.Id = 7
        Me.chkWork.Name = "chkWork"
        '
        'chkValidate
        '
        Me.chkValidate.Caption = "Poslani na uvid"
        Me.chkValidate.Checked = True
        Me.chkValidate.Id = 8
        Me.chkValidate.Name = "chkValidate"
        '
        'chkTest
        '
        Me.chkTest.Caption = "Za testiranje"
        Me.chkTest.Checked = True
        Me.chkTest.Id = 9
        Me.chkTest.Name = "chkTest"
        '
        'chkEnd
        '
        Me.chkEnd.Caption = "Završeni"
        Me.chkEnd.Checked = True
        Me.chkEnd.Id = 10
        Me.chkEnd.Name = "chkEnd"
        '
        'chkReturned
        '
        Me.chkReturned.Caption = "Vraćeni / neispravni"
        Me.chkReturned.Checked = True
        Me.chkReturned.Id = 11
        Me.chkReturned.Name = "chkReturned"
        '
        'txtNow
        '
        Me.txtNow.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.txtNow.Glyph = CType(resources.GetObject("txtNow.Glyph"), System.Drawing.Image)
        Me.txtNow.Id = 12
        Me.txtNow.Name = "txtNow"
        Me.txtNow.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'txtOper
        '
        Me.txtOper.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.txtOper.Glyph = CType(resources.GetObject("txtOper.Glyph"), System.Drawing.Image)
        Me.txtOper.Id = 14
        Me.txtOper.Name = "txtOper"
        Me.txtOper.TextAlignment = System.Drawing.StringAlignment.Near
        Me.txtOper.Width = 180
        '
        'iPaint
        '
        Me.iPaint.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.iPaint.Caption = "IpaintStyle"
        Me.iPaint.Glyph = CType(resources.GetObject("iPaint.Glyph"), System.Drawing.Image)
        Me.iPaint.Id = 19
        Me.iPaint.Name = "iPaint"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Caption = "Refresh"
        Me.cmdRefresh.Glyph = CType(resources.GetObject("cmdRefresh.Glyph"), System.Drawing.Image)
        Me.cmdRefresh.Hint = "Tipka za osvježavanje"
        Me.cmdRefresh.Id = 20
        Me.cmdRefresh.Name = "cmdRefresh"
        '
        'largeImage
        '
        Me.largeImage.ImageSize = New System.Drawing.Size(48, 48)
        Me.largeImage.ImageStream = CType(resources.GetObject("largeImage.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.largeImage.Images.SetKeyName(0, "Directory.ico")
        Me.largeImage.Images.SetKeyName(1, "Folder 186.ico")
        Me.largeImage.Images.SetKeyName(2, "Folder 187.ico")
        Me.largeImage.Images.SetKeyName(3, "Folder 191.ico")
        Me.largeImage.Images.SetKeyName(4, "Folder 194.ico")
        Me.largeImage.Images.SetKeyName(5, "Folder 196.ico")
        Me.largeImage.Images.SetKeyName(6, "Folder 201.ico")
        Me.largeImage.Images.SetKeyName(7, "User 520.ico")
        Me.largeImage.Images.SetKeyName(8, "Files 149.ico")
        Me.largeImage.Images.SetKeyName(9, "Control Panel 34.ico")
        Me.largeImage.Images.SetKeyName(10, "Hardware & Devices 330.ico")
        Me.largeImage.Images.SetKeyName(11, "Start Menu 506.ico")
        Me.largeImage.Images.SetKeyName(12, "Control Panel 47.ico")
        Me.largeImage.Images.SetKeyName(13, "Control Panel 32.ico")
        Me.largeImage.Images.SetKeyName(14, "Start Menu 479.ico")
        Me.largeImage.Images.SetKeyName(15, "Start Menu 487.ico")
        Me.largeImage.Images.SetKeyName(16, "Start Menu 507.ico")
        Me.largeImage.Images.SetKeyName(17, "Control Panel 40.ico")
        Me.largeImage.Images.SetKeyName(18, "boue.ico")
        Me.largeImage.Images.SetKeyName(19, "Start Menu 490.ico")
        Me.largeImage.Images.SetKeyName(20, "User 525.ico")
        Me.largeImage.Images.SetKeyName(21, "Control Panel 24.ico")
        Me.largeImage.Images.SetKeyName(22, "User 523.ico")
        Me.largeImage.Images.SetKeyName(23, "Control Panel 50.ico")
        Me.largeImage.Images.SetKeyName(24, "Control Panel 32.ico")
        Me.largeImage.Images.SetKeyName(25, "Control Panel 30.ico")
        Me.largeImage.Images.SetKeyName(26, "Scripta.ico")
        Me.largeImage.Images.SetKeyName(27, "Hardware & Devices 316.ico")
        Me.largeImage.Images.SetKeyName(28, "Start Menu 469.ico")
        Me.largeImage.Images.SetKeyName(29, "Start Menu 498.ico")
        Me.largeImage.Images.SetKeyName(30, "Start Menu 493.ico")
        Me.largeImage.Images.SetKeyName(31, "remote.ico")
        Me.largeImage.Images.SetKeyName(32, "notepad.ico")
        Me.largeImage.Images.SetKeyName(33, "Folder 203.ico")
        Me.largeImage.Images.SetKeyName(34, "Hardware & Devices 299.ico")
        Me.largeImage.Images.SetKeyName(35, "Folder Concept Icons 18.ico")
        Me.largeImage.Images.SetKeyName(36, "Folder Concept Icons 26.ico")
        Me.largeImage.Images.SetKeyName(37, "Folder Concept Icons 29.ico")
        Me.largeImage.Images.SetKeyName(38, "Start Menu 476.ico")
        Me.largeImage.Images.SetKeyName(39, "Start Menu 507.ico")
        Me.largeImage.Images.SetKeyName(40, "Folder 204.ico")
        Me.largeImage.Images.SetKeyName(41, "Start Menu 492.ico")
        Me.largeImage.Images.SetKeyName(42, "Security & Alert 452.ico")
        Me.largeImage.Images.SetKeyName(43, "Control Panel 66.ico")
        Me.largeImage.Images.SetKeyName(44, "power.ico")
        Me.largeImage.Images.SetKeyName(45, "Defragmentation.ico")
        Me.largeImage.Images.SetKeyName(46, "Network 413.ico")
        Me.largeImage.Images.SetKeyName(47, "humansDO.ico")
        Me.largeImage.Images.SetKeyName(48, "Network 420.ico")
        Me.largeImage.Images.SetKeyName(49, "Folder Concept Icons 34.ico")
        Me.largeImage.Images.SetKeyName(50, "ichat.ico")
        Me.largeImage.Images.SetKeyName(51, "Hardware & Devices 253.ico")
        Me.largeImage.Images.SetKeyName(52, "FileVaultIcon.ico")
        Me.largeImage.Images.SetKeyName(53, "FrontRow.ico")
        Me.largeImage.Images.SetKeyName(54, "Alarm.ico")
        Me.largeImage.Images.SetKeyName(55, "Tire #01.ico")
        Me.largeImage.Images.SetKeyName(56, "Control Panel 59.ico")
        Me.largeImage.Images.SetKeyName(57, "umbrella.ico")
        Me.largeImage.Images.SetKeyName(58, "beach_chair.ico")
        Me.largeImage.Images.SetKeyName(59, "chair.ico")
        Me.largeImage.Images.SetKeyName(60, "user.ico")
        Me.largeImage.Images.SetKeyName(61, "Keynote.ico")
        Me.largeImage.Images.SetKeyName(62, "Start Menu 515.ico")
        Me.largeImage.Images.SetKeyName(63, "bus.ico")
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.cmdMessages)
        Me.RibbonStatusBar.ItemLinks.Add(Me.cmbFilter)
        Me.RibbonStatusBar.ItemLinks.Add(Me.txtOper)
        Me.RibbonStatusBar.ItemLinks.Add(Me.txtNow)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 738)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.ribbon
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1280, 23)
        '
        'grid2
        '
        Me.grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid2.Location = New System.Drawing.Point(2, 22)
        Me.grid2.MainView = Me.grid2View
        Me.grid2.Name = "grid2"
        Me.grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbStanjeImg, Me.progressPosto})
        Me.grid2.Size = New System.Drawing.Size(343, 317)
        Me.grid2.TabIndex = 15
        Me.grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid2View, Me.GridView1})
        '
        'grid2View
        '
        Me.grid2View.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSkyBlue
        Me.grid2View.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grid2View.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grid2View.Appearance.OddRow.Options.UseBackColor = True
        Me.grid2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOpis, Me.colDatum, Me.colUtroseno, Me.colPosto, Me.colStatus3, Me.colStatus2})
        Me.grid2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grid2View.GridControl = Me.grid2
        Me.grid2View.Name = "grid2View"
        Me.grid2View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid2View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid2View.OptionsBehavior.Editable = False
        Me.grid2View.OptionsLayout.StoreAllOptions = True
        Me.grid2View.OptionsLayout.StoreAppearance = True
        Me.grid2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid2View.OptionsView.EnableAppearanceEvenRow = True
        Me.grid2View.OptionsView.EnableAppearanceOddRow = True
        Me.grid2View.OptionsView.ShowFooter = True
        Me.grid2View.OptionsView.ShowGroupPanel = False
        Me.grid2View.OptionsView.ShowIndicator = False
        Me.grid2View.RowHeight = 5
        Me.grid2View.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'colOpis
        '
        Me.colOpis.Caption = "Opis"
        Me.colOpis.FieldName = "opis"
        Me.colOpis.Name = "colOpis"
        Me.colOpis.Visible = True
        Me.colOpis.VisibleIndex = 1
        Me.colOpis.Width = 131
        '
        'colDatum
        '
        Me.colDatum.Caption = "Datum"
        Me.colDatum.FieldName = "datum"
        Me.colDatum.Name = "colDatum"
        Me.colDatum.Visible = True
        Me.colDatum.VisibleIndex = 2
        Me.colDatum.Width = 63
        '
        'colUtroseno
        '
        Me.colUtroseno.Caption = "Utrošeno"
        Me.colUtroseno.FieldName = "vrijemeRad"
        Me.colUtroseno.Name = "colUtroseno"
        Me.colUtroseno.Visible = True
        Me.colUtroseno.VisibleIndex = 3
        Me.colUtroseno.Width = 55
        '
        'colPosto
        '
        Me.colPosto.Caption = "%"
        Me.colPosto.ColumnEdit = Me.progressPosto
        Me.colPosto.FieldName = "posto"
        Me.colPosto.Name = "colPosto"
        Me.colPosto.Visible = True
        Me.colPosto.VisibleIndex = 4
        Me.colPosto.Width = 74
        '
        'progressPosto
        '
        Me.progressPosto.Name = "progressPosto"
        Me.progressPosto.ShowTitle = True
        '
        'colStatus3
        '
        Me.colStatus3.Caption = "Stanje"
        Me.colStatus3.ColumnEdit = Me.cmbStanjeImg
        Me.colStatus3.FieldName = "stanjeBool"
        Me.colStatus3.Name = "colStatus3"
        Me.colStatus3.OptionsColumn.ShowCaption = False
        Me.colStatus3.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colStatus3.Visible = True
        Me.colStatus3.VisibleIndex = 0
        Me.colStatus3.Width = 20
        '
        'cmbStanjeImg
        '
        Me.cmbStanjeImg.CycleOnDblClick = False
        Me.cmbStanjeImg.DropDownRows = 1
        Me.cmbStanjeImg.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmbStanjeImg.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rad", True, 8), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Zaustavljeno", False, -1)})
        Me.cmbStanjeImg.Name = "cmbStanjeImg"
        Me.cmbStanjeImg.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.cmbStanjeImg.SmallImages = Me.extraSmall
        '
        'extraSmall
        '
        Me.extraSmall.ImageStream = CType(resources.GetObject("extraSmall.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.extraSmall.Images.SetKeyName(0, "nav_plain_green.png")
        Me.extraSmall.Images.SetKeyName(1, "nav_plain_red.png")
        Me.extraSmall.Images.SetKeyName(2, "1.ico")
        Me.extraSmall.Images.SetKeyName(3, "2.ico")
        Me.extraSmall.Images.SetKeyName(4, "3.ico")
        Me.extraSmall.Images.SetKeyName(5, "4.ico")
        Me.extraSmall.Images.SetKeyName(6, "5.ico")
        Me.extraSmall.Images.SetKeyName(7, "0.ico")
        Me.extraSmall.Images.SetKeyName(8, "Control Panel 21.ico")
        '
        'colStatus2
        '
        Me.colStatus2.Caption = "Stanje"
        Me.colStatus2.FieldName = "stanje"
        Me.colStatus2.Name = "colStatus2"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grid2
        Me.GridView1.Name = "GridView1"
        '
        'panelGrid2
        '
        Me.panelGrid2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.panelGrid2.Appearance.Options.UseBackColor = True
        Me.panelGrid2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelGrid2.Controls.Add(Me.lblUkupnoI)
        Me.panelGrid2.Controls.Add(Me.lblUkI)
        Me.panelGrid2.Controls.Add(Me.cmdStartIzvr)
        Me.panelGrid2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelGrid2.Location = New System.Drawing.Point(2, 309)
        Me.panelGrid2.Name = "panelGrid2"
        Me.panelGrid2.Padding = New System.Windows.Forms.Padding(3)
        Me.panelGrid2.Size = New System.Drawing.Size(343, 30)
        Me.panelGrid2.TabIndex = 48
        '
        'lblUkupnoI
        '
        Me.lblUkupnoI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkupnoI.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblUkupnoI.Location = New System.Drawing.Point(291, 8)
        Me.lblUkupnoI.Name = "lblUkupnoI"
        Me.lblUkupnoI.Size = New System.Drawing.Size(38, 13)
        Me.lblUkupnoI.TabIndex = 49
        Me.lblUkupnoI.Text = "0:00:00"
        '
        'lblUkI
        '
        Me.lblUkI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkI.Location = New System.Drawing.Point(204, 8)
        Me.lblUkI.Name = "lblUkI"
        Me.lblUkI.Size = New System.Drawing.Size(86, 13)
        Me.lblUkI.TabIndex = 48
        Me.lblUkI.Text = "Utrošeno vrijeme:"
        '
        'cmdStartIzvr
        '
        Me.cmdStartIzvr.Image = CType(resources.GetObject("cmdStartIzvr.Image"), System.Drawing.Image)
        Me.cmdStartIzvr.Location = New System.Drawing.Point(6, 4)
        Me.cmdStartIzvr.Name = "cmdStartIzvr"
        Me.cmdStartIzvr.Size = New System.Drawing.Size(128, 20)
        Me.cmdStartIzvr.TabIndex = 47
        Me.cmdStartIzvr.Text = "&Novo izvršenje"
        '
        'group3
        '
        Me.group3.Controls.Add(Me.panelGrid2)
        Me.group3.Controls.Add(Me.grid2)
        Me.group3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group3.Location = New System.Drawing.Point(0, 0)
        Me.group3.Name = "group3"
        Me.group3.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.group3.Size = New System.Drawing.Size(352, 341)
        Me.group3.TabIndex = 21
        Me.group3.Text = "Moja izvršenja"
        '
        'colUtrosenoo
        '
        Me.colUtrosenoo.Caption = "Utrošeno vrijeme"
        Me.colUtrosenoo.FieldName = "vrimIzvr"
        Me.colUtrosenoo.Name = "colUtrosenoo"
        Me.colUtrosenoo.Visible = True
        Me.colUtrosenoo.VisibleIndex = 8
        Me.colUtrosenoo.Width = 105
        '
        'colVoditelj
        '
        Me.colVoditelj.Caption = "Voditelj"
        Me.colVoditelj.FieldName = "voditelj"
        Me.colVoditelj.Name = "colVoditelj"
        Me.colVoditelj.Visible = True
        Me.colVoditelj.VisibleIndex = 7
        Me.colVoditelj.Width = 84
        '
        'col7
        '
        Me.col7.Caption = "Operater"
        Me.col7.FieldName = "sOperater"
        Me.col7.Name = "col7"
        Me.col7.Width = 60
        '
        'tabDetail
        '
        Me.tabDetail.Name = "tabDetail"
        Me.tabDetail.Size = New System.Drawing.Size(720, 214)
        Me.tabDetail.Text = "Detalji"
        '
        'group
        '
        Me.group.Controls.Add(Me.PGsystem)
        Me.group.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group.Location = New System.Drawing.Point(0, 0)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(271, 240)
        Me.group.TabIndex = 45
        Me.group.Text = "Podaci o sustavu"
        '
        'PGsystem
        '
        Me.PGsystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PGsystem.ImageList = Me.smallImage
        Me.PGsystem.Location = New System.Drawing.Point(2, 22)
        Me.PGsystem.Name = "PGsystem"
        Me.PGsystem.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.PGsystem.RecordWidth = 104
        Me.PGsystem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtOperLogins, Me.txtPravaLogins, Me.txtIPlogins, Me.txtUkOperLogins, Me.gridOperLogins, Me.gridOper2Logins, Me.txtVrimLogins, Me.gridtest, Me.txtUsername, Me.txtDatabase, Me.txtJezik, Me.txtSkin, Me.txtLogged})
        Me.PGsystem.RowHeaderWidth = 96
        Me.PGsystem.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.CategoryRow2, Me.CategoryRow1})
        Me.PGsystem.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
        Me.PGsystem.Size = New System.Drawing.Size(267, 216)
        Me.PGsystem.TabIndex = 7
        '
        'txtOperLogins
        '
        Me.txtOperLogins.AutoHeight = False
        Me.txtOperLogins.Name = "txtOperLogins"
        '
        'txtPravaLogins
        '
        Me.txtPravaLogins.AutoHeight = False
        Me.txtPravaLogins.Name = "txtPravaLogins"
        '
        'txtIPlogins
        '
        Me.txtIPlogins.AutoHeight = False
        Me.txtIPlogins.Name = "txtIPlogins"
        '
        'txtUkOperLogins
        '
        Me.txtUkOperLogins.AutoHeight = False
        Me.txtUkOperLogins.Name = "txtUkOperLogins"
        '
        'gridOperLogins
        '
        Me.gridOperLogins.AutoHeight = False
        Me.gridOperLogins.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.gridOperLogins.Name = "gridOperLogins"
        Me.gridOperLogins.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gridOper2Logins
        '
        Me.gridOper2Logins.AutoHeight = False
        Me.gridOper2Logins.ImmediatePopup = True
        Me.gridOper2Logins.Name = "gridOper2Logins"
        Me.gridOper2Logins.View = Me.gridOperLoginsView
        '
        'gridOperLoginsView
        '
        Me.gridOperLoginsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridOperLoginsView.Name = "gridOperLoginsView"
        Me.gridOperLoginsView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridOperLoginsView.OptionsView.ShowGroupPanel = False
        Me.gridOperLoginsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'txtVrimLogins
        '
        Me.txtVrimLogins.AutoHeight = False
        Me.txtVrimLogins.Name = "txtVrimLogins"
        '
        'gridtest
        '
        Me.gridtest.AutoHeight = False
        Me.gridtest.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridtest.ImmediatePopup = True
        Me.gridtest.Name = "gridtest"
        Me.gridtest.PopupFormSize = New System.Drawing.Size(300, 300)
        Me.gridtest.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.gridtest.UseParentBackground = True
        Me.gridtest.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'txtUsername
        '
        Me.txtUsername.AutoHeight = False
        Me.txtUsername.Name = "txtUsername"
        '
        'txtDatabase
        '
        Me.txtDatabase.AutoHeight = False
        Me.txtDatabase.Name = "txtDatabase"
        '
        'txtJezik
        '
        Me.txtJezik.AutoHeight = False
        Me.txtJezik.Name = "txtJezik"
        '
        'txtSkin
        '
        Me.txtSkin.AutoHeight = False
        Me.txtSkin.Name = "txtSkin"
        '
        'txtLogged
        '
        Me.txtLogged.AutoHeight = False
        Me.txtLogged.Name = "txtLogged"
        '
        'CategoryRow2
        '
        Me.CategoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowOper, Me.rowUsername, Me.rowPrava, Me.rowVrim})
        Me.CategoryRow2.Height = 11
        Me.CategoryRow2.Name = "CategoryRow2"
        '
        'rowOper
        '
        Me.rowOper.Height = 20
        Me.rowOper.Name = "rowOper"
        Me.rowOper.Properties.Caption = "Operater"
        Me.rowOper.Properties.ReadOnly = True
        Me.rowOper.Properties.RowEdit = Me.txtOperLogins
        '
        'rowUsername
        '
        Me.rowUsername.Height = 20
        Me.rowUsername.Name = "rowUsername"
        Me.rowUsername.Properties.Caption = "Korisničko ime"
        Me.rowUsername.Properties.RowEdit = Me.txtUsername
        '
        'rowPrava
        '
        Me.rowPrava.Height = 20
        Me.rowPrava.Name = "rowPrava"
        Me.rowPrava.Properties.Caption = "Razina prava"
        Me.rowPrava.Properties.ReadOnly = True
        Me.rowPrava.Properties.RowEdit = Me.txtPravaLogins
        '
        'rowVrim
        '
        Me.rowVrim.Height = 20
        Me.rowVrim.Name = "rowVrim"
        Me.rowVrim.Properties.Caption = "Vrijeme logiranja"
        Me.rowVrim.Properties.RowEdit = Me.txtVrimLogins
        '
        'CategoryRow1
        '
        Me.CategoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTotal, Me.rowIP, Me.rowBaza, Me.rowJezik, Me.rowSkin})
        Me.CategoryRow1.Height = 11
        Me.CategoryRow1.Name = "CategoryRow1"
        '
        'rowTotal
        '
        Me.rowTotal.Name = "rowTotal"
        Me.rowTotal.Properties.Caption = "Logirano / Ukupno"
        Me.rowTotal.Properties.RowEdit = Me.txtLogged
        '
        'rowIP
        '
        Me.rowIP.Height = 20
        Me.rowIP.Name = "rowIP"
        Me.rowIP.Properties.Caption = "IP računala"
        Me.rowIP.Properties.ReadOnly = True
        Me.rowIP.Properties.RowEdit = Me.txtIPlogins
        '
        'rowBaza
        '
        Me.rowBaza.Height = 20
        Me.rowBaza.Name = "rowBaza"
        Me.rowBaza.Properties.Caption = "Baza"
        Me.rowBaza.Properties.FieldName = "database"
        Me.rowBaza.Properties.ReadOnly = True
        Me.rowBaza.Properties.RowEdit = Me.txtDatabase
        '
        'rowJezik
        '
        Me.rowJezik.Height = 20
        Me.rowJezik.Name = "rowJezik"
        Me.rowJezik.Properties.Caption = "Jezik:"
        Me.rowJezik.Properties.RowEdit = Me.txtJezik
        '
        'rowSkin
        '
        Me.rowSkin.Height = 20
        Me.rowSkin.Name = "rowSkin"
        Me.rowSkin.Properties.Caption = "Skin"
        Me.rowSkin.Properties.RowEdit = Me.txtSkin
        '
        'tabGraph
        '
        Me.tabGraph.ImageIndex = 240
        Me.tabGraph.Name = "tabGraph"
        Me.tabGraph.Size = New System.Drawing.Size(720, 214)
        Me.tabGraph.Text = "Grafikon"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.tab)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.group)
        Me.SplitContainer4.Size = New System.Drawing.Size(1004, 240)
        Me.SplitContainer4.SplitterDistance = 725
        Me.SplitContainer4.SplitterWidth = 8
        Me.SplitContainer4.TabIndex = 0
        '
        'tab
        '
        Me.tab.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.tab.Appearance.Options.UseBackColor = True
        Me.tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tabGraph
        Me.tab.Size = New System.Drawing.Size(725, 240)
        Me.tab.TabIndex = 20
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabGraph, Me.tabDetail})
        '
        'colEnd
        '
        Me.colEnd.Caption = "Završetak"
        Me.colEnd.FieldName = "vrijemeDO"
        Me.colEnd.Name = "colEnd"
        Me.colEnd.Visible = True
        Me.colEnd.VisibleIndex = 6
        Me.colEnd.Width = 77
        '
        'colStart
        '
        Me.colStart.Caption = "Početak"
        Me.colStart.FieldName = "vrijemeOD"
        Me.colStart.Name = "colStart"
        Me.colStart.Visible = True
        Me.colStart.VisibleIndex = 5
        Me.colStart.Width = 63
        '
        'group2
        '
        Me.group2.Controls.Add(Me.panelGrid)
        Me.group2.Controls.Add(Me.grid)
        Me.group2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.group2.Location = New System.Drawing.Point(0, 0)
        Me.group2.Name = "group2"
        Me.group2.Padding = New System.Windows.Forms.Padding(3)
        Me.group2.Size = New System.Drawing.Size(642, 341)
        Me.group2.TabIndex = 42
        Me.group2.Text = "Moji zadaci"
        '
        'panelGrid
        '
        Me.panelGrid.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.panelGrid.Appearance.Options.UseBackColor = True
        Me.panelGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelGrid.Controls.Add(Me.lblUkupnoZ)
        Me.panelGrid.Controls.Add(Me.lblUkZad)
        Me.panelGrid.Controls.Add(Me.lblUkP)
        Me.panelGrid.Controls.Add(Me.lblUkupnoP)
        Me.panelGrid.Controls.Add(Me.cmdTest)
        Me.panelGrid.Controls.Add(Me.cmdActivate)
        Me.panelGrid.Controls.Add(Me.cmdEndIzvr)
        Me.panelGrid.Controls.Add(Me.cmdOvjeri)
        Me.panelGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelGrid.Location = New System.Drawing.Point(5, 306)
        Me.panelGrid.Name = "panelGrid"
        Me.panelGrid.Padding = New System.Windows.Forms.Padding(3)
        Me.panelGrid.Size = New System.Drawing.Size(632, 30)
        Me.panelGrid.TabIndex = 47
        '
        'lblUkupnoZ
        '
        Me.lblUkupnoZ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkupnoZ.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.lblUkupnoZ.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblUkupnoZ.Location = New System.Drawing.Point(588, 8)
        Me.lblUkupnoZ.Name = "lblUkupnoZ"
        Me.lblUkupnoZ.Size = New System.Drawing.Size(38, 13)
        Me.lblUkupnoZ.TabIndex = 52
        Me.lblUkupnoZ.Text = "0:00:00"
        '
        'lblUkZad
        '
        Me.lblUkZad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkZad.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblUkZad.Location = New System.Drawing.Point(502, 8)
        Me.lblUkZad.Name = "lblUkZad"
        Me.lblUkZad.Size = New System.Drawing.Size(80, 13)
        Me.lblUkZad.TabIndex = 51
        Me.lblUkZad.Text = "Vrijeme zadatka:"
        '
        'lblUkP
        '
        Me.lblUkP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblUkP.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.lblUkP.Location = New System.Drawing.Point(345, 8)
        Me.lblUkP.Name = "lblUkP"
        Me.lblUkP.Size = New System.Drawing.Size(82, 13)
        Me.lblUkP.TabIndex = 50
        Me.lblUkP.Text = "Vrijeme projekta:"
        '
        'lblUkupnoP
        '
        Me.lblUkupnoP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUkupnoP.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblUkupnoP.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lblUkupnoP.Location = New System.Drawing.Point(433, 8)
        Me.lblUkupnoP.Name = "lblUkupnoP"
        Me.lblUkupnoP.Size = New System.Drawing.Size(38, 13)
        Me.lblUkupnoP.TabIndex = 49
        Me.lblUkupnoP.Text = "0:00:00"
        '
        'cmdTest
        '
        Me.cmdTest.Location = New System.Drawing.Point(6, 6)
        Me.cmdTest.Name = "cmdTest"
        Me.cmdTest.Size = New System.Drawing.Size(131, 19)
        Me.cmdTest.TabIndex = 48
        Me.cmdTest.Text = "&Testiranje"
        Me.cmdTest.Visible = False
        '
        'cmdActivate
        '
        Me.cmdActivate.ImageIndex = 10
        Me.cmdActivate.Location = New System.Drawing.Point(6, 6)
        Me.cmdActivate.Name = "cmdActivate"
        Me.cmdActivate.Size = New System.Drawing.Size(131, 19)
        Me.cmdActivate.TabIndex = 47
        Me.cmdActivate.Text = "Aktiviraj zadatak"
        Me.cmdActivate.Visible = False
        '
        'cmdEndIzvr
        '
        Me.cmdEndIzvr.Image = CType(resources.GetObject("cmdEndIzvr.Image"), System.Drawing.Image)
        Me.cmdEndIzvr.Location = New System.Drawing.Point(6, 5)
        Me.cmdEndIzvr.Name = "cmdEndIzvr"
        Me.cmdEndIzvr.Size = New System.Drawing.Size(131, 20)
        Me.cmdEndIzvr.TabIndex = 32
        Me.cmdEndIzvr.Text = "Zaključi izvršenja"
        Me.cmdEndIzvr.Visible = False
        '
        'cmdOvjeri
        '
        Me.cmdOvjeri.Location = New System.Drawing.Point(143, 5)
        Me.cmdOvjeri.Name = "cmdOvjeri"
        Me.cmdOvjeri.Size = New System.Drawing.Size(131, 19)
        Me.cmdOvjeri.TabIndex = 32
        Me.cmdOvjeri.Text = "&Ovjeri"
        Me.cmdOvjeri.Visible = False
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(5, 25)
        Me.grid.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCmbPriorImg, Me.cmbAktivZad})
        Me.grid.Size = New System.Drawing.Size(632, 311)
        Me.grid.TabIndex = 45
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSkyBlue
        Me.gridView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridView.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridView.Appearance.OddRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col, Me.colProjekt, Me.colZadatak, Me.colPrioritet, Me.colPrioritetIcon, Me.colStatusOpis, Me.colStart, Me.colEnd, Me.colUtrosenoo, Me.colVoditelj, Me.col7, Me.colProjektID, Me.colStatus, Me.colVrijemeZad, Me.colAktiv})
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 1
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowFooter = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProjekt, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colZadatak, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'col
        '
        Me.col.Caption = "ID"
        Me.col.FieldName = "id"
        Me.col.Name = "col"
        Me.col.Width = 53
        '
        'colProjekt
        '
        Me.colProjekt.Caption = "Projekt"
        Me.colProjekt.FieldName = "sProjekt"
        Me.colProjekt.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colProjekt.Name = "colProjekt"
        Me.colProjekt.Width = 94
        '
        'colZadatak
        '
        Me.colZadatak.Caption = "Zadatak"
        Me.colZadatak.FieldName = "zadatak"
        Me.colZadatak.Name = "colZadatak"
        Me.colZadatak.Visible = True
        Me.colZadatak.VisibleIndex = 1
        Me.colZadatak.Width = 123
        '
        'colPrioritet
        '
        Me.colPrioritet.Caption = "Prioritet"
        Me.colPrioritet.FieldName = "prioritet"
        Me.colPrioritet.Name = "colPrioritet"
        Me.colPrioritet.Visible = True
        Me.colPrioritet.VisibleIndex = 3
        Me.colPrioritet.Width = 74
        '
        'colPrioritetIcon
        '
        Me.colPrioritetIcon.ColumnEdit = Me.repCmbPriorImg
        Me.colPrioritetIcon.FieldName = "iPrior"
        Me.colPrioritetIcon.Name = "colPrioritetIcon"
        Me.colPrioritetIcon.OptionsColumn.AllowEdit = False
        Me.colPrioritetIcon.OptionsColumn.AllowFocus = False
        Me.colPrioritetIcon.OptionsColumn.AllowSize = False
        Me.colPrioritetIcon.OptionsColumn.ReadOnly = True
        Me.colPrioritetIcon.OptionsColumn.ShowCaption = False
        Me.colPrioritetIcon.Visible = True
        Me.colPrioritetIcon.VisibleIndex = 2
        Me.colPrioritetIcon.Width = 21
        '
        'repCmbPriorImg
        '
        Me.repCmbPriorImg.AutoHeight = False
        Me.repCmbPriorImg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCmbPriorImg.HideSelection = False
        Me.repCmbPriorImg.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("0", 0, 7), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", 1, 2), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", 2, 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", 3, 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", 4, 5), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("5", 5, 6)})
        Me.repCmbPriorImg.Name = "repCmbPriorImg"
        Me.repCmbPriorImg.ReadOnly = True
        Me.repCmbPriorImg.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.repCmbPriorImg.SmallImages = Me.extraSmall
        '
        'colStatusOpis
        '
        Me.colStatusOpis.Caption = "Status"
        Me.colStatusOpis.FieldName = "vezstatusOpis"
        Me.colStatusOpis.Name = "colStatusOpis"
        Me.colStatusOpis.Visible = True
        Me.colStatusOpis.VisibleIndex = 4
        Me.colStatusOpis.Width = 63
        '
        'colProjektID
        '
        Me.colProjektID.Caption = "Projekt ID"
        Me.colProjektID.FieldName = "projekt"
        Me.colProjektID.Name = "colProjektID"
        '
        'colStatus
        '
        Me.colStatus.Caption = "statusID"
        Me.colStatus.FieldName = "zadStatus"
        Me.colStatus.Name = "colStatus"
        '
        'colVrijemeZad
        '
        Me.colVrijemeZad.Caption = "Vrijeme Zadatka"
        Me.colVrijemeZad.FieldName = "zadVrim"
        Me.colVrijemeZad.Name = "colVrijemeZad"
        '
        'colAktiv
        '
        Me.colAktiv.ColumnEdit = Me.cmbAktivZad
        Me.colAktiv.FieldName = "zadStatus"
        Me.colAktiv.MaxWidth = 20
        Me.colAktiv.Name = "colAktiv"
        Me.colAktiv.OptionsColumn.AllowEdit = False
        Me.colAktiv.OptionsColumn.AllowFocus = False
        Me.colAktiv.OptionsColumn.AllowSize = False
        Me.colAktiv.OptionsColumn.ReadOnly = True
        Me.colAktiv.OptionsColumn.ShowCaption = False
        Me.colAktiv.Visible = True
        Me.colAktiv.VisibleIndex = 0
        Me.colAktiv.Width = 38
        '
        'cmbAktivZad
        '
        Me.cmbAktivZad.AutoHeight = False
        Me.cmbAktivZad.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAktivZad.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Aktivno", 3, 8)})
        Me.cmbAktivZad.Name = "cmbAktivZad"
        Me.cmbAktivZad.SmallImages = Me.extraSmall
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.group2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.group3)
        Me.SplitContainer3.Size = New System.Drawing.Size(1004, 341)
        Me.SplitContainer3.SplitterDistance = 642
        Me.SplitContainer3.SplitterWidth = 10
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(1004, 589)
        Me.SplitContainer2.SplitterDistance = 341
        Me.SplitContainer2.SplitterWidth = 8
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 149)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.groupOperPro)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(3, 10, 3, 10)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1280, 589)
        Me.SplitContainer1.SplitterDistance = 268
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 8
        '
        'groupOperPro
        '
        Me.groupOperPro.Controls.Add(Me.SimpleButton1)
        Me.groupOperPro.Controls.Add(Me.gridOper)
        Me.groupOperPro.Controls.Add(Me.chkAll)
        Me.groupOperPro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupOperPro.Location = New System.Drawing.Point(3, 10)
        Me.groupOperPro.Name = "groupOperPro"
        Me.groupOperPro.Size = New System.Drawing.Size(262, 569)
        Me.groupOperPro.TabIndex = 0
        Me.groupOperPro.Text = "Operateri "
        '
        'gridOper
        '
        Me.gridOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOper.Location = New System.Drawing.Point(2, 22)
        Me.gridOper.MainView = Me.gridViewOper
        Me.gridOper.MenuManager = Me.ribbon
        Me.gridOper.Name = "gridOper"
        Me.gridOper.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbAktivPro})
        Me.gridOper.Size = New System.Drawing.Size(258, 526)
        Me.gridOper.TabIndex = 5
        Me.gridOper.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewOper})
        '
        'gridViewOper
        '
        Me.gridViewOper.Appearance.FocusedRow.BackColor = System.Drawing.Color.SkyBlue
        Me.gridViewOper.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridViewOper.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewOper.Appearance.OddRow.Options.UseBackColor = True
        Me.gridViewOper.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDOper, Me.colNazivOper, Me.colVrstaOper, Me.colProjektOper, Me.colOper})
        Me.gridViewOper.GridControl = Me.gridOper
        Me.gridViewOper.GroupCount = 1
        Me.gridViewOper.Name = "gridViewOper"
        Me.gridViewOper.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewOper.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewOper.OptionsBehavior.AutoExpandAllGroups = True
        Me.gridViewOper.OptionsBehavior.Editable = False
        Me.gridViewOper.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gridViewOper.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gridViewOper.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewOper.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewOper.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewOper.OptionsView.ShowFooter = True
        Me.gridViewOper.OptionsView.ShowGroupPanel = False
        Me.gridViewOper.OptionsView.ShowIndicator = False
        Me.gridViewOper.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNazivOper, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colIDOper
        '
        Me.colIDOper.Caption = "ID"
        Me.colIDOper.FieldName = "id"
        Me.colIDOper.Name = "colIDOper"
        '
        'colNazivOper
        '
        Me.colNazivOper.Caption = "Operater"
        Me.colNazivOper.FieldName = "sOsoba"
        Me.colNazivOper.Name = "colNazivOper"
        Me.colNazivOper.Width = 164
        '
        'colVrstaOper
        '
        Me.colVrstaOper.Caption = "Vrsta"
        Me.colVrstaOper.FieldName = "sVrsta"
        Me.colVrstaOper.Name = "colVrstaOper"
        Me.colVrstaOper.Visible = True
        Me.colVrstaOper.VisibleIndex = 1
        Me.colVrstaOper.Width = 123
        '
        'colProjektOper
        '
        Me.colProjektOper.Caption = "Projekt"
        Me.colProjektOper.FieldName = "naziv"
        Me.colProjektOper.Name = "colProjektOper"
        Me.colProjektOper.Visible = True
        Me.colProjektOper.VisibleIndex = 0
        Me.colProjektOper.Width = 97
        '
        'colOper
        '
        Me.colOper.Caption = "Oper"
        Me.colOper.FieldName = "oper"
        Me.colOper.Name = "colOper"
        '
        'cmbAktivPro
        '
        Me.cmbAktivPro.AutoHeight = False
        Me.cmbAktivPro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAktivPro.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Aktivno", True, 0)})
        Me.cmbAktivPro.Name = "cmbAktivPro"
        Me.cmbAktivPro.SmallImages = Me.extraSmall
        '
        'chkAll
        '
        Me.chkAll.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkAll.Location = New System.Drawing.Point(2, 548)
        Me.chkAll.MenuManager = Me.ribbon
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Properties.Caption = "Svi operateri"
        Me.chkAll.Size = New System.Drawing.Size(258, 19)
        Me.chkAll.TabIndex = 4
        '
        'cmdInfo
        '
        Me.cmdInfo.Glyph = CType(resources.GetObject("cmdInfo.Glyph"), System.Drawing.Image)
        Me.cmdInfo.Id = 116
        Me.cmdInfo.Name = "cmdInfo"
        '
        'Timer1
        '
        '
        '_trayIcon
        '
        Me._trayIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me._trayIcon.Icon = CType(resources.GetObject("_trayIcon.Icon"), System.Drawing.Icon)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdOpen, Me.cmdExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'cmdOpen
        '
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(107, 22)
        Me.cmdOpen.Text = "Otvori"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(107, 22)
        Me.cmdExit.Text = "Izlaz"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Blue"
        '
        'rightClickMenu
        '
        Me.rightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolPrintPrew, Me.ToolStripSeparator1, Me.toolExport})
        Me.rightClickMenu.Name = "rightClickMenu"
        Me.rightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.rightClickMenu.Size = New System.Drawing.Size(108, 54)
        '
        'toolPrintPrew
        '
        Me.toolPrintPrew.Name = "toolPrintPrew"
        Me.toolPrintPrew.Size = New System.Drawing.Size(107, 22)
        Me.toolPrintPrew.Text = "Ispis"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'toolExport
        '
        Me.toolExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolPDF, Me.toolXLS, Me.toolXLSX, Me.toolHTML, Me.toolRTF})
        Me.toolExport.Name = "toolExport"
        Me.toolExport.Size = New System.Drawing.Size(107, 22)
        Me.toolExport.Text = "Export"
        '
        'toolPDF
        '
        Me.toolPDF.Image = CType(resources.GetObject("toolPDF.Image"), System.Drawing.Image)
        Me.toolPDF.Name = "toolPDF"
        Me.toolPDF.Size = New System.Drawing.Size(107, 22)
        Me.toolPDF.Text = "PDF"
        '
        'toolXLS
        '
        Me.toolXLS.Image = CType(resources.GetObject("toolXLS.Image"), System.Drawing.Image)
        Me.toolXLS.Name = "toolXLS"
        Me.toolXLS.Size = New System.Drawing.Size(107, 22)
        Me.toolXLS.Text = "XLS"
        '
        'toolXLSX
        '
        Me.toolXLSX.Image = CType(resources.GetObject("toolXLSX.Image"), System.Drawing.Image)
        Me.toolXLSX.Name = "toolXLSX"
        Me.toolXLSX.Size = New System.Drawing.Size(107, 22)
        Me.toolXLSX.Text = "XLSX"
        '
        'toolHTML
        '
        Me.toolHTML.Image = CType(resources.GetObject("toolHTML.Image"), System.Drawing.Image)
        Me.toolHTML.Name = "toolHTML"
        Me.toolHTML.Size = New System.Drawing.Size(107, 22)
        Me.toolHTML.Text = "HTML"
        '
        'toolRTF
        '
        Me.toolRTF.Image = CType(resources.GetObject("toolRTF.Image"), System.Drawing.Image)
        Me.toolRTF.Name = "toolRTF"
        Me.toolRTF.Size = New System.Drawing.Size(107, 22)
        Me.toolRTF.Text = "RTF"
        '
        'cmdPoruke
        '
        Me.cmdPoruke.Caption = "Poruka (0)"
        Me.cmdPoruke.Glyph = CType(resources.GetObject("cmdPoruke.Glyph"), System.Drawing.Image)
        Me.cmdPoruke.Id = 29
        Me.cmdPoruke.Name = "cmdPoruke"
        '
        'iconOper
        '
        Me.iconOper.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.iconOper.Glyph = CType(resources.GetObject("iconOper.Glyph"), System.Drawing.Image)
        Me.iconOper.Id = 28
        Me.iconOper.Name = "iconOper"
        Me.iconOper.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'skinS
        '
        Me.skinS.Caption = "BarLinkContainerItem1"
        Me.skinS.Id = 2
        Me.skinS.Name = "skinS"
        '
        'Timer2
        '
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(58, 196)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'frmMainNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 761)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.ribbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainNew"
        Me.Ribbon = Me.ribbon
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "frmMainNew"
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.smallImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.largeImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressPosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStanjeImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extraSmall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGrid2.ResumeLayout(False)
        Me.panelGrid2.PerformLayout()
        CType(Me.group3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group3.ResumeLayout(False)
        CType(Me.group, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group.ResumeLayout(False)
        CType(Me.PGsystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOperLogins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPravaLogins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIPlogins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUkOperLogins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOperLogins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOper2Logins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOperLoginsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVrimLogins, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridtest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsername, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJezik, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLogged, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        CType(Me.group2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group2.ResumeLayout(False)
        CType(Me.panelGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGrid.ResumeLayout(False)
        Me.panelGrid.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCmbPriorImg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAktivZad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.groupOperPro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupOperPro.ResumeLayout(False)
        CType(Me.gridOper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewOper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAktivPro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.rightClickMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ribbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUtroseno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents panelGrid2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdStartIzvr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents group3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents colUtrosenoo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVoditelj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents group As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabGraph As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents colEnd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents group2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents panelGrid As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdTest As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdActivate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEndIzvr As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOvjeri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjekt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZadatak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrioritet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatusOpis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdInfo2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents _trayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmdOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents largeImage As DevExpress.Utils.ImageCollection
    Friend WithEvents rightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolPrintPrew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolXLS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolXLSX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolRTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smallImage As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdMessages As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPoruke As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbFilter As DevExpress.XtraBars.BarSubItem
    Friend WithEvents chkInactive As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents chkWork As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents chkValidate As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents chkTest As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents chkEnd As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents chkReturned As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents txtNow As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txtOper As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents iconOper As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents skinS As DevExpress.XtraBars.BarLinkContainerItem
    Friend WithEvents PGsystem As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents txtOperLogins As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPravaLogins As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtIPlogins As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtUkOperLogins As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gridOperLogins As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridOper2Logins As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridOperLoginsView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CategoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowOper As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPrava As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowIP As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents CategoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowBaza As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowVrim As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowJezik As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSkin As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowUsername As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents txtVrimLogins As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gridtest As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblUkupnoI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUkI As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUkupnoZ As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUkZad As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUkP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUkupnoP As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colProjektID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtUsername As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDatabase As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtJezik As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtSkin As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtLogged As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rowTotal As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents iPaint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrijemeZad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents groupOperPro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridOper As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewOper As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazivOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrstaOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjektOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colStatus3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbStanjeImg As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents colStatus2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents extraSmall As DevExpress.Utils.ImageCollection
    Friend WithEvents progressPosto As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents colPrioritetIcon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCmbPriorImg As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents colAktiv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbAktivZad As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents cmbAktivPro As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents cmdRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton


End Class
