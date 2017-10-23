<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperateri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperateri))
        Me.GalleryControlGallery1 = New DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.rightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolPrintPrew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolXLS = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolXLSX = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolHTML = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolRTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrezime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTvrtka = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRadnoMj = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.groupOper = New DevExpress.XtraEditors.GroupControl()
        Me.grid2 = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmdFile = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmbVoditelj = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmbPrioritet = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.dtpRok = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.cmbVrsta = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.gridVoditelj = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridVoditeljiView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.pic = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.optSpol = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.boja = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
        Me.cmbOrgJed = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmbRadMj = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.trackPrava = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
        Me.RepositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
        Me.cmbOrg = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.gridOrgJed = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridOrgJedView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridRadMj = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridRadMjView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.trackPrava2 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
        Me.dtpDo = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.dtpOd = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.chkAktiv = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.gridMjesto = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridViewMjesto = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridZupa = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridViewZupanija = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtUserName = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtPass = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnPictrue = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmdPrilog = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.repBirthDay = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.cmbTvrtka = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmdTvrtka = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmbOrgJedinica = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cmdOrgJed = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmbTvrtka2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.gridTvrtka = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.gridViewTvrtka = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdRadMjesto = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmbAdresa = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.txtTel = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtMob = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtTelS = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtMobS = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtEmailS = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cmdObrazovanje = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.categOsnovno = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowIme = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPrezime = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSlika = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colPicture = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowAktiv = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.CategoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowJMBG = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowOIB = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categOsobni = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowBirthDay = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowObrazovanje = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowZupa = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colZupanija = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colZupa = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowMjesto = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colMjestoNaziv = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colPtt = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colMjesto = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowAdresa = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colAdresa = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colKucaBr = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowSpol = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowTelefon = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMobitel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEmail = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categPodaci1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowTvrtka = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.MultiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowOrgJed = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colOrgJed = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colOrgJed2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties7 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowRadMj = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colRadMj = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colRadMj2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.MultiEditorRowProperties9 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.rowBoja = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPrava = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
        Me.colPrava0 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.colPrava = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
        Me.categOfficial = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowTelefonS = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMobitelS = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEmailS = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categKorisnik = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowUsername = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPass = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categBlank = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowHint = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDatumOd = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDatumDo = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.categDoc = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
        Me.rowPrilog = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.txtJMBG = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtOIB = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightClickMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupOper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupOper.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVoditelj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPrioritet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpRok.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbVrsta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVoditelj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridVoditeljiView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.optSpol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrgJed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRadMj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackPrava, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOrgJed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridOrgJedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRadMj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridRadMjView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackPrava2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDo.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpOd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpOd.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAktiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridMjesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewMjesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridZupa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewZupanija, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPictrue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdPrilog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBirthDay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBirthDay.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTvrtka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdTvrtka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrgJedinica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdOrgJed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTvrtka2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridTvrtka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewTvrtka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdRadMjesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAdresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmailS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdObrazovanje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJMBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOIB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(773, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 629)
        Me.barDockControlBottom.Size = New System.Drawing.Size(773, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 629)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(773, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 629)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 3
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 4
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarManager2
        '
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl4)
        Me.BarManager2.Form = Me
        Me.BarManager2.MaxItemId = 0
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(773, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 629)
        Me.BarDockControl2.Size = New System.Drawing.Size(773, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 629)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(773, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 629)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdNew)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdExit)
        Me.SplitContainer1.Size = New System.Drawing.Size(773, 629)
        Me.SplitContainer1.SplitterDistance = 587
        Me.SplitContainer1.TabIndex = 40
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grid)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.groupOper)
        Me.SplitContainer2.Size = New System.Drawing.Size(773, 587)
        Me.SplitContainer2.SplitterDistance = 368
        Me.SplitContainer2.TabIndex = 0
        '
        'grid
        '
        Me.grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(368, 587)
        Me.grid.TabIndex = 4
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIme, Me.colPrezime, Me.colTvrtka, Me.colRadnoMj})
        Me.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 1
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
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTvrtka, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.Width = 150
        '
        'colIme
        '
        Me.colIme.Caption = "Ime"
        Me.colIme.FieldName = "ime"
        Me.colIme.Name = "colIme"
        Me.colIme.Visible = True
        Me.colIme.VisibleIndex = 0
        Me.colIme.Width = 125
        '
        'colPrezime
        '
        Me.colPrezime.Caption = "Prezime"
        Me.colPrezime.FieldName = "prezime"
        Me.colPrezime.Name = "colPrezime"
        Me.colPrezime.Visible = True
        Me.colPrezime.VisibleIndex = 1
        Me.colPrezime.Width = 150
        '
        'colTvrtka
        '
        Me.colTvrtka.Caption = "Tvrtka"
        Me.colTvrtka.FieldName = "sTvrtka"
        Me.colTvrtka.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DisplayText
        Me.colTvrtka.Name = "colTvrtka"
        Me.colTvrtka.Width = 124
        '
        'colRadnoMj
        '
        Me.colRadnoMj.Caption = "Radno mjesto"
        Me.colRadnoMj.FieldName = "sRadnoMj"
        Me.colRadnoMj.Name = "colRadnoMj"
        Me.colRadnoMj.Visible = True
        Me.colRadnoMj.VisibleIndex = 2
        Me.colRadnoMj.Width = 139
        '
        'groupOper
        '
        Me.groupOper.Controls.Add(Me.grid2)
        Me.groupOper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupOper.Location = New System.Drawing.Point(0, 0)
        Me.groupOper.Name = "groupOper"
        Me.groupOper.Size = New System.Drawing.Size(401, 587)
        Me.groupOper.TabIndex = 5
        Me.groupOper.Text = "Unos \ Pregled podataka"
        '
        'grid2
        '
        Me.grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid2.Location = New System.Drawing.Point(2, 22)
        Me.grid2.Name = "grid2"
        Me.grid2.RecordWidth = 221
        Me.grid2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.cmdFile, Me.cmbVoditelj, Me.cmbPrioritet, Me.dtpRok, Me.cmbVrsta, Me.gridVoditelj, Me.RepositoryItemPictureEdit1, Me.pic, Me.optSpol, Me.boja, Me.cmbOrgJed, Me.cmbRadMj, Me.trackPrava, Me.RepositoryItemTrackBar1, Me.cmbOrg, Me.gridOrgJed, Me.gridRadMj, Me.trackPrava2, Me.dtpDo, Me.dtpOd, Me.chkAktiv, Me.gridMjesto, Me.RepositoryItemGridLookUpEdit1, Me.gridZupa, Me.txtUserName, Me.txtPass, Me.btnPictrue, Me.cmdPrilog, Me.repBirthDay, Me.cmbTvrtka, Me.cmdTvrtka, Me.cmbOrgJedinica, Me.cmdOrgJed, Me.cmbTvrtka2, Me.gridTvrtka, Me.cmdRadMjesto, Me.cmbAdresa, Me.txtTel, Me.txtMob, Me.txtEmail, Me.txtTelS, Me.txtMobS, Me.txtEmailS, Me.RepositoryItemImageEdit1, Me.RepositoryItemCheckEdit1, Me.cmdObrazovanje, Me.txtJMBG, Me.txtOIB})
        Me.grid2.RowHeaderWidth = 150
        Me.grid2.RowHeaderWidthChangeStep = 5
        Me.grid2.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.categOsnovno, Me.categOsobni, Me.categPodaci1, Me.categOfficial, Me.categKorisnik, Me.categBlank, Me.categDoc})
        Me.grid2.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
        Me.grid2.Size = New System.Drawing.Size(397, 563)
        Me.grid2.TabIndex = 13
        Me.grid2.TreeButtonStyle = DevExpress.XtraVerticalGrid.TreeButtonStyle.TreeView
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'cmdFile
        '
        Me.cmdFile.AutoHeight = False
        Me.cmdFile.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cmdFile.Name = "cmdFile"
        '
        'cmbVoditelj
        '
        Me.cmbVoditelj.AutoHeight = False
        Me.cmbVoditelj.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbVoditelj.Name = "cmbVoditelj"
        '
        'cmbPrioritet
        '
        Me.cmbPrioritet.AutoHeight = False
        Me.cmbPrioritet.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPrioritet.Name = "cmbPrioritet"
        '
        'dtpRok
        '
        Me.dtpRok.AutoHeight = False
        Me.dtpRok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpRok.Name = "dtpRok"
        Me.dtpRok.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'cmbVrsta
        '
        Me.cmbVrsta.AutoHeight = False
        Me.cmbVrsta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbVrsta.Name = "cmbVrsta"
        '
        'gridVoditelj
        '
        Me.gridVoditelj.AutoHeight = False
        Me.gridVoditelj.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.gridVoditelj.Name = "gridVoditelj"
        Me.gridVoditelj.View = Me.gridVoditeljiView
        '
        'gridVoditeljiView
        '
        Me.gridVoditeljiView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridVoditeljiView.Name = "gridVoditeljiView"
        Me.gridVoditeljiView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridVoditeljiView.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'pic
        '
        Me.pic.AutoHeight = False
        Me.pic.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.pic.Name = "pic"
        '
        'optSpol
        '
        Me.optSpol.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "Žensko"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Muško")})
        Me.optSpol.Name = "optSpol"
        '
        'boja
        '
        Me.boja.AutoHeight = False
        Me.boja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.boja.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.boja.Name = "boja"
        '
        'cmbOrgJed
        '
        Me.cmbOrgJed.AllowFocused = False
        Me.cmbOrgJed.AutoHeight = False
        Me.cmbOrgJed.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrgJed.Name = "cmbOrgJed"
        '
        'cmbRadMj
        '
        Me.cmbRadMj.AutoHeight = False
        Me.cmbRadMj.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbRadMj.Name = "cmbRadMj"
        '
        'trackPrava
        '
        Me.trackPrava.LargeChange = 2
        Me.trackPrava.Maximum = 3
        Me.trackPrava.Name = "trackPrava"
        '
        'RepositoryItemTrackBar1
        '
        Me.RepositoryItemTrackBar1.Name = "RepositoryItemTrackBar1"
        '
        'cmbOrg
        '
        Me.cmbOrg.AutoHeight = False
        Me.cmbOrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrg.Name = "cmbOrg"
        '
        'gridOrgJed
        '
        Me.gridOrgJed.AutoHeight = False
        Me.gridOrgJed.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridOrgJed.Name = "gridOrgJed"
        Me.gridOrgJed.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.gridOrgJed.View = Me.gridOrgJedView
        '
        'gridOrgJedView
        '
        Me.gridOrgJedView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridOrgJedView.Name = "gridOrgJedView"
        Me.gridOrgJedView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridOrgJedView.OptionsView.ShowGroupPanel = False
        '
        'gridRadMj
        '
        Me.gridRadMj.AutoHeight = False
        Me.gridRadMj.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridRadMj.Name = "gridRadMj"
        Me.gridRadMj.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.gridRadMj.View = Me.gridRadMjView
        '
        'gridRadMjView
        '
        Me.gridRadMjView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridRadMjView.Name = "gridRadMjView"
        Me.gridRadMjView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridRadMjView.OptionsView.ShowGroupPanel = False
        '
        'trackPrava2
        '
        Me.trackPrava2.LargeChange = 2
        Me.trackPrava2.Maximum = 3
        Me.trackPrava2.Name = "trackPrava2"
        Me.trackPrava2.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
        '
        'dtpDo
        '
        Me.dtpDo.AutoHeight = False
        Me.dtpDo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDo.Name = "dtpDo"
        Me.dtpDo.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'dtpOd
        '
        Me.dtpOd.AutoHeight = False
        Me.dtpOd.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpOd.Name = "dtpOd"
        Me.dtpOd.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'chkAktiv
        '
        Me.chkAktiv.AutoHeight = False
        Me.chkAktiv.Name = "chkAktiv"
        '
        'gridMjesto
        '
        Me.gridMjesto.AutoHeight = False
        Me.gridMjesto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridMjesto.Name = "gridMjesto"
        Me.gridMjesto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.gridMjesto.View = Me.gridViewMjesto
        Me.gridMjesto.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'gridViewMjesto
        '
        Me.gridViewMjesto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridViewMjesto.Name = "gridViewMjesto"
        Me.gridViewMjesto.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewMjesto.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.GridView3
        '
        'GridView3
        '
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'gridZupa
        '
        Me.gridZupa.AutoHeight = False
        Me.gridZupa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridZupa.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.gridZupa.Name = "gridZupa"
        Me.gridZupa.NullText = "Odaberite županiju"
        Me.gridZupa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.gridZupa.View = Me.gridViewZupanija
        Me.gridZupa.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView
        '
        'gridViewZupanija
        '
        Me.gridViewZupanija.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridViewZupanija.Name = "gridViewZupanija"
        Me.gridViewZupanija.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewZupanija.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewZupanija.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewZupanija.OptionsView.ShowGroupPanel = False
        '
        'txtUserName
        '
        Me.txtUserName.AutoHeight = False
        Me.txtUserName.MaxLength = 10
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'txtPass
        '
        Me.txtPass.AutoHeight = False
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        'btnPictrue
        '
        Me.btnPictrue.AutoHeight = False
        Me.btnPictrue.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.btnPictrue.Name = "btnPictrue"
        Me.btnPictrue.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cmdPrilog
        '
        Me.cmdPrilog.AutoHeight = False
        Me.cmdPrilog.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cmdPrilog.Name = "cmdPrilog"
        '
        'repBirthDay
        '
        Me.repBirthDay.AutoHeight = False
        Me.repBirthDay.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBirthDay.Mask.UseMaskAsDisplayFormat = True
        Me.repBirthDay.Name = "repBirthDay"
        Me.repBirthDay.NullDate = New Date(2012, 1, 24, 16, 27, 21, 887)
        Me.repBirthDay.ValidateOnEnterKey = True
        Me.repBirthDay.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.repBirthDay.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        '
        'cmbTvrtka
        '
        Me.cmbTvrtka.AutoHeight = False
        Me.cmbTvrtka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTvrtka.DropDownRows = 50
        Me.cmbTvrtka.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmbTvrtka.Name = "cmbTvrtka"
        Me.cmbTvrtka.NullText = "***Odaberite tvrtku***"
        Me.cmbTvrtka.ValidateOnEnterKey = True
        '
        'cmdTvrtka
        '
        Me.cmdTvrtka.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.cmdTvrtka.AutoHeight = False
        Me.cmdTvrtka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmdTvrtka.Name = "cmdTvrtka"
        Me.cmdTvrtka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cmbOrgJedinica
        '
        Me.cmbOrgJedinica.AutoHeight = False
        Me.cmbOrgJedinica.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOrgJedinica.Name = "cmbOrgJedinica"
        '
        'cmdOrgJed
        '
        Me.cmdOrgJed.AutoHeight = False
        Me.cmdOrgJed.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmdOrgJed.Name = "cmdOrgJed"
        Me.cmdOrgJed.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cmbTvrtka2
        '
        Me.cmbTvrtka2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTvrtka2.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmbTvrtka2.Name = "cmbTvrtka2"
        Me.cmbTvrtka2.Sorted = True
        '
        'gridTvrtka
        '
        Me.gridTvrtka.AutoHeight = False
        Me.gridTvrtka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
        Me.gridTvrtka.Name = "gridTvrtka"
        Me.gridTvrtka.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.gridTvrtka.View = Me.gridViewTvrtka
        '
        'gridViewTvrtka
        '
        Me.gridViewTvrtka.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridViewTvrtka.Name = "gridViewTvrtka"
        Me.gridViewTvrtka.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewTvrtka.OptionsView.ShowGroupPanel = False
        '
        'cmdRadMjesto
        '
        Me.cmdRadMjesto.AutoHeight = False
        Me.cmdRadMjesto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.cmdRadMjesto.Name = "cmdRadMjesto"
        Me.cmdRadMjesto.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'cmbAdresa
        '
        Me.cmbAdresa.AutoHeight = False
        Me.cmbAdresa.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAdresa.Name = "cmbAdresa"
        '
        'txtTel
        '
        Me.txtTel.AutoHeight = False
        Me.txtTel.Name = "txtTel"
        '
        'txtMob
        '
        Me.txtMob.AutoHeight = False
        Me.txtMob.Name = "txtMob"
        '
        'txtEmail
        '
        Me.txtEmail.AutoHeight = False
        Me.txtEmail.Name = "txtEmail"
        '
        'txtTelS
        '
        Me.txtTelS.AutoHeight = False
        Me.txtTelS.Name = "txtTelS"
        '
        'txtMobS
        '
        Me.txtMobS.AutoHeight = False
        Me.txtMobS.Name = "txtMobS"
        '
        'txtEmailS
        '
        Me.txtEmailS.AutoHeight = False
        Me.txtEmailS.Name = "txtEmailS"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'cmdObrazovanje
        '
        Me.cmdObrazovanje.AutoHeight = False
        Me.cmdObrazovanje.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cmdObrazovanje.Name = "cmdObrazovanje"
        '
        'categOsnovno
        '
        Me.categOsnovno.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowIme, Me.rowPrezime, Me.rowSlika, Me.rowAktiv, Me.CategoryRow1, Me.rowJMBG, Me.rowOIB})
        Me.categOsnovno.Height = 17
        Me.categOsnovno.Name = "categOsnovno"
        Me.categOsnovno.Properties.Caption = "Osnovno"
        '
        'rowIme
        '
        Me.rowIme.Name = "rowIme"
        Me.rowIme.Properties.Caption = "Ime"
        '
        'rowPrezime
        '
        Me.rowPrezime.Name = "rowPrezime"
        Me.rowPrezime.Properties.Caption = "Prezime"
        '
        'rowSlika
        '
        Me.rowSlika.Name = "rowSlika"
        Me.rowSlika.OptionsRow.AllowMove = False
        Me.rowSlika.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowSlika.OptionsRow.AllowSize = False
        Me.rowSlika.OptionsRow.DblClickExpanding = False
        Me.rowSlika.OptionsRow.ShowInCustomizationForm = False
        Me.rowSlika.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colPicture, Me.MultiEditorRowProperties2})
        '
        'colPicture
        '
        Me.colPicture.Caption = "Logo"
        Me.colPicture.CellWidth = 5000
        Me.colPicture.RowEdit = Me.pic
        '
        'MultiEditorRowProperties2
        '
        Me.MultiEditorRowProperties2.RowEdit = Me.btnPictrue
        '
        'rowAktiv
        '
        Me.rowAktiv.Name = "rowAktiv"
        Me.rowAktiv.Properties.Caption = "Aktivno"
        Me.rowAktiv.Properties.RowEdit = Me.chkAktiv
        '
        'CategoryRow1
        '
        Me.CategoryRow1.Name = "CategoryRow1"
        '
        'rowJMBG
        '
        Me.rowJMBG.Name = "rowJMBG"
        Me.rowJMBG.Properties.Caption = "JMBG:"
        Me.rowJMBG.Properties.FieldName = "jmbg"
        Me.rowJMBG.Properties.RowEdit = Me.txtJMBG
        '
        'rowOIB
        '
        Me.rowOIB.Name = "rowOIB"
        Me.rowOIB.Properties.Caption = "OIB:"
        Me.rowOIB.Properties.FieldName = "oib"
        Me.rowOIB.Properties.RowEdit = Me.txtOIB
        '
        'categOsobni
        '
        Me.categOsobni.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowBirthDay, Me.rowObrazovanje, Me.rowZupa, Me.rowMjesto, Me.rowAdresa, Me.rowSpol, Me.rowTelefon, Me.rowMobitel, Me.rowEmail})
        Me.categOsobni.Height = 17
        Me.categOsobni.Name = "categOsobni"
        Me.categOsobni.Properties.Caption = "Osobni podaci"
        '
        'rowBirthDay
        '
        Me.rowBirthDay.Name = "rowBirthDay"
        Me.rowBirthDay.Properties.Caption = "Datum rođenja"
        Me.rowBirthDay.Properties.FieldName = "datumRodj"
        Me.rowBirthDay.Properties.RowEdit = Me.repBirthDay
        '
        'rowObrazovanje
        '
        Me.rowObrazovanje.Name = "rowObrazovanje"
        Me.rowObrazovanje.Properties.Caption = "Obrazovanje"
        Me.rowObrazovanje.Properties.RowEdit = Me.cmdObrazovanje
        '
        'rowZupa
        '
        Me.rowZupa.Name = "rowZupa"
        Me.rowZupa.OptionsRow.AllowMove = False
        Me.rowZupa.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowZupa.OptionsRow.AllowSize = False
        Me.rowZupa.OptionsRow.DblClickExpanding = False
        Me.rowZupa.OptionsRow.ShowInCustomizationForm = False
        Me.rowZupa.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colZupanija, Me.colZupa})
        '
        'colZupanija
        '
        Me.colZupanija.Caption = "Županija"
        Me.colZupanija.CellWidth = 190
        Me.colZupanija.Width = 50000
        '
        'colZupa
        '
        Me.colZupa.RowEdit = Me.gridZupa
        Me.colZupa.Width = 15
        '
        'rowMjesto
        '
        Me.rowMjesto.Name = "rowMjesto"
        Me.rowMjesto.OptionsRow.AllowMove = False
        Me.rowMjesto.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowMjesto.OptionsRow.AllowSize = False
        Me.rowMjesto.OptionsRow.DblClickExpanding = False
        Me.rowMjesto.OptionsRow.ShowInCustomizationForm = False
        Me.rowMjesto.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colMjestoNaziv, Me.colPtt, Me.colMjesto})
        '
        'colMjestoNaziv
        '
        Me.colMjestoNaziv.Caption = "Mjesto"
        Me.colMjestoNaziv.CellWidth = 120
        Me.colMjestoNaziv.Width = 50000
        '
        'colPtt
        '
        Me.colPtt.CellWidth = 50
        '
        'colMjesto
        '
        Me.colMjesto.CellWidth = 18
        Me.colMjesto.RowEdit = Me.gridMjesto
        Me.colMjesto.Width = 15
        '
        'rowAdresa
        '
        Me.rowAdresa.Name = "rowAdresa"
        Me.rowAdresa.OptionsRow.AllowMove = False
        Me.rowAdresa.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowAdresa.OptionsRow.AllowSize = False
        Me.rowAdresa.OptionsRow.DblClickExpanding = False
        Me.rowAdresa.OptionsRow.ShowInCustomizationForm = False
        Me.rowAdresa.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colAdresa, Me.colKucaBr})
        '
        'colAdresa
        '
        Me.colAdresa.Caption = "Adresa"
        Me.colAdresa.CellWidth = 180
        Me.colAdresa.RowEdit = Me.cmbAdresa
        '
        'colKucaBr
        '
        Me.colKucaBr.Caption = "Kucni br."
        '
        'rowSpol
        '
        Me.rowSpol.Name = "rowSpol"
        Me.rowSpol.Properties.Caption = "Spol"
        Me.rowSpol.Properties.RowEdit = Me.optSpol
        Me.rowSpol.Properties.Value = True
        '
        'rowTelefon
        '
        Me.rowTelefon.Name = "rowTelefon"
        Me.rowTelefon.Properties.Caption = "Telefon"
        Me.rowTelefon.Properties.RowEdit = Me.txtTel
        '
        'rowMobitel
        '
        Me.rowMobitel.Name = "rowMobitel"
        Me.rowMobitel.Properties.Caption = "Mobitel"
        Me.rowMobitel.Properties.RowEdit = Me.txtMob
        '
        'rowEmail
        '
        Me.rowEmail.Name = "rowEmail"
        Me.rowEmail.Properties.Caption = "Email"
        Me.rowEmail.Properties.RowEdit = Me.txtEmail
        '
        'categPodaci1
        '
        Me.categPodaci1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTvrtka, Me.rowOrgJed, Me.rowRadMj, Me.rowBoja, Me.rowPrava})
        Me.categPodaci1.Name = "categPodaci1"
        Me.categPodaci1.Properties.Caption = "Podaci potrebni za rad aplikacije"
        '
        'rowTvrtka
        '
        Me.rowTvrtka.Expanded = False
        Me.rowTvrtka.Name = "rowTvrtka"
        Me.rowTvrtka.OptionsRow.AllowMove = False
        Me.rowTvrtka.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowTvrtka.OptionsRow.AllowSize = False
        Me.rowTvrtka.OptionsRow.DblClickExpanding = False
        Me.rowTvrtka.OptionsRow.ShowInCustomizationForm = False
        Me.rowTvrtka.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.MultiEditorRowProperties1, Me.MultiEditorRowProperties3, Me.MultiEditorRowProperties4})
        '
        'MultiEditorRowProperties1
        '
        Me.MultiEditorRowProperties1.Caption = "Tvrtka"
        Me.MultiEditorRowProperties1.CellWidth = 180
        Me.MultiEditorRowProperties1.Width = 500000
        '
        'MultiEditorRowProperties3
        '
        Me.MultiEditorRowProperties3.RowEdit = Me.gridTvrtka
        '
        'MultiEditorRowProperties4
        '
        Me.MultiEditorRowProperties4.RowEdit = Me.cmdTvrtka
        '
        'rowOrgJed
        '
        Me.rowOrgJed.Expanded = False
        Me.rowOrgJed.Name = "rowOrgJed"
        Me.rowOrgJed.OptionsRow.AllowMove = False
        Me.rowOrgJed.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowOrgJed.OptionsRow.AllowSize = False
        Me.rowOrgJed.OptionsRow.DblClickExpanding = False
        Me.rowOrgJed.OptionsRow.ShowInCustomizationForm = False
        Me.rowOrgJed.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colOrgJed, Me.colOrgJed2, Me.MultiEditorRowProperties7})
        '
        'colOrgJed
        '
        Me.colOrgJed.Caption = "Org.jedinica"
        Me.colOrgJed.CellWidth = 180
        Me.colOrgJed.Width = 50000
        '
        'colOrgJed2
        '
        Me.colOrgJed2.RowEdit = Me.gridOrgJed
        '
        'MultiEditorRowProperties7
        '
        Me.MultiEditorRowProperties7.RowEdit = Me.cmdOrgJed
        '
        'rowRadMj
        '
        Me.rowRadMj.Expanded = False
        Me.rowRadMj.Name = "rowRadMj"
        Me.rowRadMj.OptionsRow.AllowMove = False
        Me.rowRadMj.OptionsRow.AllowMoveToCustomizationForm = False
        Me.rowRadMj.OptionsRow.AllowSize = False
        Me.rowRadMj.OptionsRow.DblClickExpanding = False
        Me.rowRadMj.OptionsRow.ShowInCustomizationForm = False
        Me.rowRadMj.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colRadMj, Me.colRadMj2, Me.MultiEditorRowProperties9})
        '
        'colRadMj
        '
        Me.colRadMj.Caption = "Radno mj."
        Me.colRadMj.CellWidth = 180
        Me.colRadMj.Width = 50000
        '
        'colRadMj2
        '
        Me.colRadMj2.CellWidth = 18
        Me.colRadMj2.RowEdit = Me.gridRadMj
        Me.colRadMj2.Width = 15
        '
        'MultiEditorRowProperties9
        '
        Me.MultiEditorRowProperties9.RowEdit = Me.cmdRadMjesto
        '
        'rowBoja
        '
        Me.rowBoja.Name = "rowBoja"
        Me.rowBoja.Properties.Caption = "Boja korisnika"
        Me.rowBoja.Properties.RowEdit = Me.boja
        '
        'rowPrava
        '
        Me.rowPrava.Name = "rowPrava"
        Me.rowPrava.OptionsRow.AllowSize = False
        Me.rowPrava.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() {Me.colPrava0, Me.colPrava})
        '
        'colPrava0
        '
        Me.colPrava0.Caption = "Prava"
        Me.colPrava0.CellWidth = 80
        Me.colPrava0.RowEdit = Me.trackPrava2
        Me.colPrava0.Width = 50000
        '
        'colPrava
        '
        Me.colPrava.CellWidth = 100
        '
        'categOfficial
        '
        Me.categOfficial.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowTelefonS, Me.rowMobitelS, Me.rowEmailS})
        Me.categOfficial.Name = "categOfficial"
        Me.categOfficial.Properties.Caption = "Službeni kontakt podaci"
        '
        'rowTelefonS
        '
        Me.rowTelefonS.Name = "rowTelefonS"
        Me.rowTelefonS.Properties.Caption = "Telefon"
        Me.rowTelefonS.Properties.RowEdit = Me.txtTelS
        '
        'rowMobitelS
        '
        Me.rowMobitelS.Name = "rowMobitelS"
        Me.rowMobitelS.Properties.Caption = "Mobitel"
        Me.rowMobitelS.Properties.RowEdit = Me.txtMobS
        '
        'rowEmailS
        '
        Me.rowEmailS.Name = "rowEmailS"
        Me.rowEmailS.Properties.Caption = "Email"
        Me.rowEmailS.Properties.RowEdit = Me.txtEmailS
        '
        'categKorisnik
        '
        Me.categKorisnik.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowUsername, Me.rowPass})
        Me.categKorisnik.Name = "categKorisnik"
        Me.categKorisnik.Properties.Caption = "Korisnički podaci"
        '
        'rowUsername
        '
        Me.rowUsername.Name = "rowUsername"
        Me.rowUsername.Properties.Caption = "Username"
        Me.rowUsername.Properties.RowEdit = Me.txtUserName
        '
        'rowPass
        '
        Me.rowPass.Name = "rowPass"
        Me.rowPass.Properties.Caption = "Password"
        Me.rowPass.Properties.RowEdit = Me.txtPass
        '
        'categBlank
        '
        Me.categBlank.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowHint, Me.rowDatumOd, Me.rowDatumDo})
        Me.categBlank.Name = "categBlank"
        '
        'rowHint
        '
        Me.rowHint.Name = "rowHint"
        Me.rowHint.Properties.Caption = "Hint"
        '
        'rowDatumOd
        '
        Me.rowDatumOd.Name = "rowDatumOd"
        Me.rowDatumOd.Properties.Caption = "Datum unosa"
        Me.rowDatumOd.Properties.ReadOnly = True
        Me.rowDatumOd.Properties.RowEdit = Me.dtpOd
        '
        'rowDatumDo
        '
        Me.rowDatumDo.Enabled = False
        Me.rowDatumDo.Name = "rowDatumDo"
        Me.rowDatumDo.Properties.Caption = "Promjena lozinke"
        Me.rowDatumDo.Properties.RowEdit = Me.dtpDo
        '
        'categDoc
        '
        Me.categDoc.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowPrilog})
        Me.categDoc.Name = "categDoc"
        Me.categDoc.Properties.Caption = "Dokumenti"
        '
        'rowPrilog
        '
        Me.rowPrilog.Name = "rowPrilog"
        Me.rowPrilog.Properties.Caption = "Prilog"
        Me.rowPrilog.Properties.ReadOnly = True
        Me.rowPrilog.Properties.RowEdit = Me.cmdPrilog
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(479, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(95, 23)
        Me.cmdPrint.TabIndex = 36
        Me.cmdPrint.Text = "Is&pis"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(6, 7)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(146, 23)
        Me.cmdNew.TabIndex = 35
        Me.cmdNew.Text = "&Novi unos"
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Enabled = False
        Me.cmdSave.Location = New System.Drawing.Point(580, 7)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(95, 23)
        Me.cmdSave.TabIndex = 33
        Me.cmdSave.Text = "&Spremi"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(681, 7)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(89, 23)
        Me.cmdExit.TabIndex = 32
        Me.cmdExit.Text = "&Odustani"
        '
        'txtJMBG
        '
        Me.txtJMBG.AutoHeight = False
        Me.txtJMBG.MaxLength = 13
        Me.txtJMBG.Name = "txtJMBG"
        '
        'txtOIB
        '
        Me.txtOIB.AutoHeight = False
        Me.txtOIB.MaxLength = 11
        Me.txtOIB.Name = "txtOIB"
        '
        'frmOperateri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 629)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmOperateri"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pregled operatera"
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightClickMenu.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupOper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupOper.ResumeLayout(False)
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVoditelj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPrioritet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRok.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpRok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbVrsta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVoditelj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridVoditeljiView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.optSpol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrgJed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRadMj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackPrava, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOrgJed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridOrgJedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRadMj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridRadMjView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackPrava2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDo.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpOd.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpOd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAktiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridMjesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewMjesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridZupa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewZupanija, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPictrue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdPrilog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBirthDay.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBirthDay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTvrtka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdTvrtka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrgJedinica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdOrgJed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTvrtka2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridTvrtka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewTvrtka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdRadMjesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAdresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmailS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdObrazovanje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJMBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOIB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GalleryControlGallery1 As DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents rightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolPrintPrew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolXLS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolXLSX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolRTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrezime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTvrtka As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRadnoMj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents groupOper As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid2 As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmdFile As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbVoditelj As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbPrioritet As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents dtpRok As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbVrsta As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents gridVoditelj As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridVoditeljiView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents pic As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents optSpol As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents boja As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Public WithEvents cmbOrgJed As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmbRadMj As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents trackPrava As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents RepositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents cmbOrg As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents gridOrgJed As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridOrgJedView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridRadMj As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridRadMjView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents trackPrava2 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
    Friend WithEvents dtpDo As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpOd As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents chkAktiv As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gridMjesto As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridViewMjesto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridZupa As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridViewZupanija As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtUserName As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPass As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnPictrue As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmdPrilog As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents repBirthDay As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbTvrtka As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmdTvrtka As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbOrgJedinica As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cmdOrgJed As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbTvrtka2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents gridTvrtka As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents gridViewTvrtka As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdRadMjesto As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbAdresa As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtTel As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMob As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtTelS As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtMobS As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtEmailS As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents categOsnovno As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowIme As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPrezime As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSlika As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents categOsobni As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowBirthDay As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowZupa As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowMjesto As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowAdresa As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowSpol As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowTelefon As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMobitel As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEmail As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categPodaci1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowTvrtka As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowOrgJed As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowRadMj As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents rowBoja As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPrava As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
    Friend WithEvents categOfficial As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowTelefonS As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMobitelS As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEmailS As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categKorisnik As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowUsername As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPass As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categBlank As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowHint As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDatumOd As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDatumDo As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAktiv As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents categDoc As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowPrilog As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents colPicture As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colZupanija As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colZupa As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colAdresa As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colKucaBr As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colMjestoNaziv As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colPtt As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colMjesto As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colOrgJed As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colOrgJed2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties7 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colRadMj As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colRadMj2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents MultiEditorRowProperties9 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colPrava0 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents colPrava As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmdObrazovanje As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents rowObrazovanje As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents CategoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
    Friend WithEvents rowJMBG As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowOIB As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents txtJMBG As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtOIB As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
