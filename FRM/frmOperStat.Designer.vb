<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperStat))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjekt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVoditeljID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.grid2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZadatak2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRazlika = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPositive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVoditelj = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabChart1 = New DevExpress.XtraTab.XtraTabPage()
        Me.tabChart2 = New DevExpress.XtraTab.XtraTabPage()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupControl1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1003, 518)
        Me.SplitContainer1.SplitterDistance = 304
        Me.SplitContainer1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grid)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(304, 518)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(2, 22)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(300, 394)
        Me.grid.TabIndex = 4
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOper, Me.colProjekt, Me.colVoditeljID})
        Me.gridView.GridControl = Me.grid
        Me.gridView.GroupCount = 1
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOper, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'colOper
        '
        Me.colOper.Caption = "Operater"
        Me.colOper.FieldName = "Osoba"
        Me.colOper.Name = "colOper"
        '
        'colProjekt
        '
        Me.colProjekt.Caption = "Projekt"
        Me.colProjekt.FieldName = "naziv"
        Me.colProjekt.Name = "colProjekt"
        Me.colProjekt.Visible = True
        Me.colProjekt.VisibleIndex = 0
        '
        'colVoditeljID
        '
        Me.colVoditeljID.Caption = "Voditelj"
        Me.colVoditeljID.FieldName = "voditelj"
        Me.colVoditeljID.Name = "colVoditeljID"
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 416)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(300, 100)
        Me.PanelControl1.TabIndex = 5
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grid2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(695, 518)
        Me.SplitContainer2.SplitterDistance = 284
        Me.SplitContainer2.TabIndex = 0
        '
        'grid2
        '
        Me.grid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid2.Location = New System.Drawing.Point(0, 0)
        Me.grid2.MainView = Me.GridView2
        Me.grid2.Name = "grid2"
        Me.grid2.Size = New System.Drawing.Size(695, 284)
        Me.grid2.TabIndex = 3
        Me.grid2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID2, Me.colZadatak2, Me.colPlan, Me.colReal, Me.colRazlika, Me.colPositive, Me.colVoditelj})
        Me.GridView2.GridControl = Me.grid2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colID2
        '
        Me.colID2.Caption = "ID"
        Me.colID2.FieldName = "id"
        Me.colID2.Name = "colID2"
        '
        'colZadatak2
        '
        Me.colZadatak2.Caption = "Zadatak"
        Me.colZadatak2.FieldName = "zadatak"
        Me.colZadatak2.Name = "colZadatak2"
        Me.colZadatak2.Visible = True
        Me.colZadatak2.VisibleIndex = 0
        Me.colZadatak2.Width = 269
        '
        'colPlan
        '
        Me.colPlan.Caption = "Planirano"
        Me.colPlan.FieldName = "planirano"
        Me.colPlan.Name = "colPlan"
        Me.colPlan.Visible = True
        Me.colPlan.VisibleIndex = 1
        Me.colPlan.Width = 68
        '
        'colReal
        '
        Me.colReal.Caption = "Utrošeno"
        Me.colReal.FieldName = "realno"
        Me.colReal.Name = "colReal"
        Me.colReal.Visible = True
        Me.colReal.VisibleIndex = 2
        Me.colReal.Width = 86
        '
        'colRazlika
        '
        Me.colRazlika.Caption = "Razlika"
        Me.colRazlika.FieldName = "razlika"
        Me.colRazlika.Name = "colRazlika"
        Me.colRazlika.Visible = True
        Me.colRazlika.VisibleIndex = 3
        Me.colRazlika.Width = 78
        '
        'colPositive
        '
        Me.colPositive.FieldName = "positive"
        Me.colPositive.Name = "colPositive"
        Me.colPositive.OptionsColumn.ShowCaption = False
        Me.colPositive.Visible = True
        Me.colPositive.VisibleIndex = 4
        Me.colPositive.Width = 50
        '
        'colVoditelj
        '
        Me.colVoditelj.Caption = "voditelj"
        Me.colVoditelj.Name = "colVoditelj"
        Me.colVoditelj.Visible = True
        Me.colVoditelj.VisibleIndex = 5
        Me.colVoditelj.Width = 142
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tabChart1
        Me.XtraTabControl1.Size = New System.Drawing.Size(695, 230)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabChart1, Me.tabChart2})
        '
        'tabChart1
        '
        Me.tabChart1.Name = "tabChart1"
        Me.tabChart1.Size = New System.Drawing.Size(689, 203)
        Me.tabChart1.Text = "XtraTabPage1"
        '
        'tabChart2
        '
        Me.tabChart2.Name = "tabChart2"
        Me.tabChart2.Size = New System.Drawing.Size(689, 203)
        Me.tabChart2.Text = "XtraTabPage2"
        '
        'frmOperStat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 518)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmOperStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabChart1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabChart2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents colZadatak2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRazlika As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPositive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVoditelj As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjekt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVoditeljID As DevExpress.XtraGrid.Columns.GridColumn
End Class
