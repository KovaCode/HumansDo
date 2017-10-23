<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilesExt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilesExt))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrsta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIcon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repImage = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOpen = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.grid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOpen)
        Me.SplitContainer1.Size = New System.Drawing.Size(562, 297)
        Me.SplitContainer1.SplitterDistance = 262
        Me.SplitContainer1.TabIndex = 4
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repImage})
        Me.grid.Size = New System.Drawing.Size(562, 262)
        Me.grid.TabIndex = 2
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colTip, Me.colOper, Me.colNaziv, Me.colVel, Me.colVrsta, Me.colIcon})
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 2
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsSelection.UseIndicatorForSelection = False
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOper, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVrsta, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.Width = 56
        '
        'colTip
        '
        Me.colTip.Caption = "Tip"
        Me.colTip.FieldName = "tip"
        Me.colTip.Name = "colTip"
        Me.colTip.Width = 201
        '
        'colOper
        '
        Me.colOper.Caption = "Operater"
        Me.colOper.FieldName = "sOper"
        Me.colOper.Name = "colOper"
        Me.colOper.Width = 208
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "naziv"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 0
        Me.colNaziv.Width = 415
        '
        'colVel
        '
        Me.colVel.Caption = "Vel.[kb]"
        Me.colVel.FieldName = "sizeKB"
        Me.colVel.Name = "colVel"
        Me.colVel.Visible = True
        Me.colVel.VisibleIndex = 1
        Me.colVel.Width = 69
        '
        'colVrsta
        '
        Me.colVrsta.Caption = "Vrsta"
        Me.colVrsta.FieldName = "sVrsta"
        Me.colVrsta.Name = "colVrsta"
        Me.colVrsta.Visible = True
        Me.colVrsta.VisibleIndex = 2
        Me.colVrsta.Width = 137
        '
        'colIcon
        '
        Me.colIcon.Caption = "#"
        Me.colIcon.ColumnEdit = Me.repImage
        Me.colIcon.FieldName = "image"
        Me.colIcon.Name = "colIcon"
        Me.colIcon.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colIcon.Visible = True
        Me.colIcon.VisibleIndex = 2
        Me.colIcon.Width = 74
        '
        'repImage
        '
        Me.repImage.LookAndFeel.SkinName = "Blue"
        Me.repImage.Name = "repImage"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.Location = New System.Drawing.Point(383, 2)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(86, 18)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Is&pis"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Enabled = False
        Me.cmdExit.Location = New System.Drawing.Point(475, 3)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(84, 18)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "&Izlaz"
        '
        'cmdOpen
        '
        Me.cmdOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdOpen.Enabled = False
        Me.cmdOpen.Location = New System.Drawing.Point(12, 3)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(119, 18)
        Me.cmdOpen.TabIndex = 4
        Me.cmdOpen.Text = "&Otvori"
        '
        'frmFilesExt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 297)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFilesExt"
        Me.Text = "frmFilesExt"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrsta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIcon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repImage As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOpen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
End Class
