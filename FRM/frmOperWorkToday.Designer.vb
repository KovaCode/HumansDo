<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperWorkToday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperWorkToday))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjekt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZadatak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpisIzvr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetOpisIzvr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reptxtDetOpis = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colStatusZad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrijemeOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrijemeDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repProgress = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.colVrijeme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repTxtOpis = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbOper = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblOper = New DevExpress.XtraEditors.LabelControl()
        Me.dtp = New DevExpress.XtraEditors.DateEdit()
        Me.lblDatum = New DevExpress.XtraEditors.LabelControl()
        Me.cmdPreview = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCountTime = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lblCount = New DevExpress.XtraEditors.LabelControl()
        Me.lblUkupno = New DevExpress.XtraEditors.LabelControl()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reptxtDetOpis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repProgress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTxtOpis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbOper.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCountTime)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblUkupno)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdExit)
        Me.SplitContainer1.Size = New System.Drawing.Size(769, 377)
        Me.SplitContainer1.SplitterDistance = 341
        Me.SplitContainer1.TabIndex = 0
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(0, 39)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repTxtOpis, Me.reptxtDetOpis, Me.repProgress})
        Me.grid.Size = New System.Drawing.Size(769, 302)
        Me.grid.TabIndex = 6
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colProjekt, Me.colZadatak, Me.colOpisIzvr, Me.colDetOpisIzvr, Me.colStatusZad, Me.colVrijemeOD, Me.colVrijemeDO, Me.colPosto, Me.colVrijeme})
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 1
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
        Me.gridView.OptionsCustomization.AllowColumnResizing = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProjekt, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        '
        'colProjekt
        '
        Me.colProjekt.Caption = "Projekt"
        Me.colProjekt.FieldName = "sProjekt"
        Me.colProjekt.Name = "colProjekt"
        Me.colProjekt.Visible = True
        Me.colProjekt.VisibleIndex = 0
        Me.colProjekt.Width = 150
        '
        'colZadatak
        '
        Me.colZadatak.Caption = "Zadatak"
        Me.colZadatak.FieldName = "sZadatak"
        Me.colZadatak.Name = "colZadatak"
        Me.colZadatak.OptionsColumn.AllowEdit = False
        Me.colZadatak.Visible = True
        Me.colZadatak.VisibleIndex = 0
        Me.colZadatak.Width = 155
        '
        'colOpisIzvr
        '
        Me.colOpisIzvr.Caption = "Opis izvršenja"
        Me.colOpisIzvr.FieldName = "opis"
        Me.colOpisIzvr.Name = "colOpisIzvr"
        Me.colOpisIzvr.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colOpisIzvr.Visible = True
        Me.colOpisIzvr.VisibleIndex = 1
        Me.colOpisIzvr.Width = 79
        '
        'colDetOpisIzvr
        '
        Me.colDetOpisIzvr.Caption = "Det.opis izvršenja"
        Me.colDetOpisIzvr.ColumnEdit = Me.reptxtDetOpis
        Me.colDetOpisIzvr.FieldName = "detOpis"
        Me.colDetOpisIzvr.Name = "colDetOpisIzvr"
        Me.colDetOpisIzvr.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colDetOpisIzvr.Visible = True
        Me.colDetOpisIzvr.VisibleIndex = 2
        Me.colDetOpisIzvr.Width = 92
        '
        'reptxtDetOpis
        '
        Me.reptxtDetOpis.AutoHeight = False
        Me.reptxtDetOpis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reptxtDetOpis.Name = "reptxtDetOpis"
        '
        'colStatusZad
        '
        Me.colStatusZad.Caption = "Status zadatka"
        Me.colStatusZad.FieldName = "statusZad"
        Me.colStatusZad.Name = "colStatusZad"
        Me.colStatusZad.OptionsColumn.AllowEdit = False
        Me.colStatusZad.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colStatusZad.Visible = True
        Me.colStatusZad.VisibleIndex = 3
        Me.colStatusZad.Width = 107
        '
        'colVrijemeOD
        '
        Me.colVrijemeOD.Caption = "Vrijeme OD"
        Me.colVrijemeOD.FieldName = "vrijemeOD"
        Me.colVrijemeOD.Name = "colVrijemeOD"
        Me.colVrijemeOD.OptionsColumn.AllowEdit = False
        Me.colVrijemeOD.Visible = True
        Me.colVrijemeOD.VisibleIndex = 4
        Me.colVrijemeOD.Width = 69
        '
        'colVrijemeDO
        '
        Me.colVrijemeDO.Caption = "Vrijeme DO"
        Me.colVrijemeDO.FieldName = "vrijemeDO"
        Me.colVrijemeDO.Name = "colVrijemeDO"
        Me.colVrijemeDO.OptionsColumn.AllowEdit = False
        Me.colVrijemeDO.Visible = True
        Me.colVrijemeDO.VisibleIndex = 5
        Me.colVrijemeDO.Width = 70
        '
        'colPosto
        '
        Me.colPosto.ColumnEdit = Me.repProgress
        Me.colPosto.FieldName = "posto"
        Me.colPosto.Name = "colPosto"
        Me.colPosto.OptionsColumn.AllowEdit = False
        Me.colPosto.OptionsColumn.ShowCaption = False
        Me.colPosto.Visible = True
        Me.colPosto.VisibleIndex = 7
        Me.colPosto.Width = 70
        '
        'repProgress
        '
        Me.repProgress.Name = "repProgress"
        Me.repProgress.ShowTitle = True
        '
        'colVrijeme
        '
        Me.colVrijeme.Caption = "Vrijeme rada"
        Me.colVrijeme.FieldName = "vrijemeRad"
        Me.colVrijeme.Name = "colVrijeme"
        Me.colVrijeme.OptionsColumn.AllowEdit = False
        Me.colVrijeme.Visible = True
        Me.colVrijeme.VisibleIndex = 6
        Me.colVrijeme.Width = 85
        '
        'repTxtOpis
        '
        Me.repTxtOpis.AutoHeight = False
        Me.repTxtOpis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTxtOpis.Name = "repTxtOpis"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmbOper)
        Me.PanelControl1.Controls.Add(Me.lblOper)
        Me.PanelControl1.Controls.Add(Me.dtp)
        Me.PanelControl1.Controls.Add(Me.lblDatum)
        Me.PanelControl1.Controls.Add(Me.cmdPreview)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(769, 39)
        Me.PanelControl1.TabIndex = 7
        '
        'cmbOper
        '
        Me.cmbOper.Location = New System.Drawing.Point(230, 9)
        Me.cmbOper.Name = "cmbOper"
        Me.cmbOper.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOper.Properties.DropDownRows = 25
        Me.cmbOper.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmbOper.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbOper.Size = New System.Drawing.Size(155, 20)
        Me.cmbOper.TabIndex = 10
        '
        'lblOper
        '
        Me.lblOper.Location = New System.Drawing.Point(175, 12)
        Me.lblOper.Name = "lblOper"
        Me.lblOper.Size = New System.Drawing.Size(48, 13)
        Me.lblOper.TabIndex = 8
        Me.lblOper.Text = "Operater:"
        '
        'dtp
        '
        Me.dtp.EditValue = Nothing
        Me.dtp.Location = New System.Drawing.Point(53, 9)
        Me.dtp.Name = "dtp"
        Me.dtp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtp.Size = New System.Drawing.Size(100, 20)
        Me.dtp.TabIndex = 5
        '
        'lblDatum
        '
        Me.lblDatum.Location = New System.Drawing.Point(12, 12)
        Me.lblDatum.Name = "lblDatum"
        Me.lblDatum.Size = New System.Drawing.Size(35, 13)
        Me.lblDatum.TabIndex = 4
        Me.lblDatum.Text = "Datum:"
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(391, 6)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(102, 23)
        Me.cmdPreview.TabIndex = 3
        Me.cmdPreview.Text = "Pregled"
        '
        'lblCountTime
        '
        Me.lblCountTime.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCountTime.Location = New System.Drawing.Point(175, 7)
        Me.lblCountTime.Name = "lblCountTime"
        Me.lblCountTime.Size = New System.Drawing.Size(38, 13)
        Me.lblCountTime.TabIndex = 7
        Me.lblCountTime.Text = "0:00:00"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(83, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Utrošeno vrijeme:"
        '
        'lblCount
        '
        Me.lblCount.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCount.Location = New System.Drawing.Point(58, 7)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(6, 13)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "0"
        '
        'lblUkupno
        '
        Me.lblUkupno.Location = New System.Drawing.Point(12, 7)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(40, 13)
        Me.lblUkupno.TabIndex = 2
        Me.lblUkupno.Text = "Ukupno:"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(547, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(102, 23)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.Text = "Is&pis"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(655, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(102, 23)
        Me.cmdExit.TabIndex = 0
        Me.cmdExit.Text = "&Izlaz"
        '
        'frmOperWorkToday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 377)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOperWorkToday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmOperWorkToday"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reptxtDetOpis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repProgress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTxtOpis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbOper.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZadatak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpisIzvr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repTxtOpis As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colDetOpisIzvr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reptxtDetOpis As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colStatusZad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrijemeOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrijemeDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repProgress As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents colVrijeme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDatum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtp As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblUkupno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colProjekt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCountTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblOper As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbOper As DevExpress.XtraEditors.ComboBoxEdit
End Class
