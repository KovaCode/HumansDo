<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMjesta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMjesta))
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.groupZupanija = New DevExpress.XtraEditors.GroupControl()
        Me.gridZupa = New DevExpress.XtraGrid.GridControl()
        Me.gridViewZ = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDZ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazivZ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.groupMjesta = New DevExpress.XtraEditors.GroupControl()
        Me.gridMjesto = New DevExpress.XtraGrid.GridControl()
        Me.gridViewM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazivM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPTTM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZupanijaM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.groupUlice = New DevExpress.XtraEditors.GroupControl()
        Me.gridUlica = New DevExpress.XtraGrid.GridControl()
        Me.gridViewU = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazivU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.groupZupanija, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupZupanija.SuspendLayout()
        CType(Me.gridZupa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.groupMjesta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupMjesta.SuspendLayout()
        CType(Me.gridMjesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupUlice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupUlice.SuspendLayout()
        CType(Me.gridUlica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.cmdNew)
        Me.SplitContainer3.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer3.Panel2.Controls.Add(Me.cmdExit)
        Me.SplitContainer3.Panel2.Controls.Add(Me.cmdEdit)
        Me.SplitContainer3.Size = New System.Drawing.Size(836, 458)
        Me.SplitContainer3.SplitterDistance = 414
        Me.SplitContainer3.SplitterWidth = 6
        Me.SplitContainer3.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.groupZupanija)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.SplitContainer1.Size = New System.Drawing.Size(836, 414)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 4
        '
        'groupZupanija
        '
        Me.groupZupanija.Controls.Add(Me.gridZupa)
        Me.groupZupanija.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupZupanija.Location = New System.Drawing.Point(5, 5)
        Me.groupZupanija.Name = "groupZupanija"
        Me.groupZupanija.Size = New System.Drawing.Size(237, 404)
        Me.groupZupanija.TabIndex = 1
        Me.groupZupanija.Text = "Županije"
        '
        'gridZupa
        '
        Me.gridZupa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridZupa.Location = New System.Drawing.Point(2, 22)
        Me.gridZupa.MainView = Me.gridViewZ
        Me.gridZupa.Name = "gridZupa"
        Me.gridZupa.Size = New System.Drawing.Size(233, 380)
        Me.gridZupa.TabIndex = 6
        Me.gridZupa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewZ, Me.GridView3})
        '
        'gridViewZ
        '
        Me.gridViewZ.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridViewZ.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewZ.Appearance.FocusedRow.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.gridViewZ.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridViewZ.Appearance.OddRow.BackColor = System.Drawing.Color.Transparent
        Me.gridViewZ.Appearance.OddRow.Options.UseBackColor = True
        Me.gridViewZ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDZ, Me.colNazivZ})
        Me.gridViewZ.GridControl = Me.gridZupa
        Me.gridViewZ.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "id", Nothing, Nothing)})
        Me.gridViewZ.Name = "gridViewZ"
        Me.gridViewZ.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewZ.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewZ.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridViewZ.OptionsBehavior.AutoExpandAllGroups = True
        Me.gridViewZ.OptionsBehavior.Editable = False
        Me.gridViewZ.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gridViewZ.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gridViewZ.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.gridViewZ.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewZ.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewZ.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewZ.OptionsView.ShowFooter = True
        Me.gridViewZ.OptionsView.ShowGroupPanel = False
        Me.gridViewZ.OptionsView.ShowIndicator = False
        Me.gridViewZ.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        '
        'colIDZ
        '
        Me.colIDZ.Caption = "ID"
        Me.colIDZ.FieldName = "sifra"
        Me.colIDZ.Name = "colIDZ"
        Me.colIDZ.OptionsColumn.AllowEdit = False
        '
        'colNazivZ
        '
        Me.colNazivZ.Caption = "Naziv"
        Me.colNazivZ.FieldName = "naziv"
        Me.colNazivZ.Name = "colNazivZ"
        Me.colNazivZ.Visible = True
        Me.colNazivZ.VisibleIndex = 0
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.gridZupa
        Me.GridView3.Name = "GridView3"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(5, 5)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.groupMjesta)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.groupUlice)
        Me.SplitContainer2.Size = New System.Drawing.Size(573, 404)
        Me.SplitContainer2.SplitterDistance = 287
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 0
        '
        'groupMjesta
        '
        Me.groupMjesta.Controls.Add(Me.gridMjesto)
        Me.groupMjesta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupMjesta.Location = New System.Drawing.Point(0, 0)
        Me.groupMjesta.Name = "groupMjesta"
        Me.groupMjesta.Size = New System.Drawing.Size(287, 404)
        Me.groupMjesta.TabIndex = 2
        Me.groupMjesta.Text = "Mjesta"
        '
        'gridMjesto
        '
        Me.gridMjesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridMjesto.Location = New System.Drawing.Point(2, 22)
        Me.gridMjesto.MainView = Me.gridViewM
        Me.gridMjesto.Name = "gridMjesto"
        Me.gridMjesto.Size = New System.Drawing.Size(283, 380)
        Me.gridMjesto.TabIndex = 7
        Me.gridMjesto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewM, Me.GridView2})
        '
        'gridViewM
        '
        Me.gridViewM.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridViewM.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewM.Appearance.OddRow.BackColor = System.Drawing.Color.Transparent
        Me.gridViewM.Appearance.OddRow.Options.UseBackColor = True
        Me.gridViewM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDM, Me.colNazivM, Me.colPTTM, Me.colZupanijaM})
        Me.gridViewM.GridControl = Me.gridMjesto
        Me.gridViewM.Name = "gridViewM"
        Me.gridViewM.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewM.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewM.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridViewM.OptionsBehavior.AutoExpandAllGroups = True
        Me.gridViewM.OptionsBehavior.Editable = False
        Me.gridViewM.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gridViewM.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gridViewM.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewM.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewM.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewM.OptionsView.ShowFooter = True
        Me.gridViewM.OptionsView.ShowGroupPanel = False
        Me.gridViewM.OptionsView.ShowIndicator = False
        '
        'colIDM
        '
        Me.colIDM.Caption = "ID"
        Me.colIDM.FieldName = "ID"
        Me.colIDM.Name = "colIDM"
        '
        'colNazivM
        '
        Me.colNazivM.Caption = "Naziv"
        Me.colNazivM.FieldName = "Naselje"
        Me.colNazivM.Name = "colNazivM"
        Me.colNazivM.Visible = True
        Me.colNazivM.VisibleIndex = 0
        Me.colNazivM.Width = 192
        '
        'colPTTM
        '
        Me.colPTTM.Caption = "PTT"
        Me.colPTTM.FieldName = "PTT"
        Me.colPTTM.Name = "colPTTM"
        Me.colPTTM.Width = 68
        '
        'colZupanijaM
        '
        Me.colZupanijaM.Caption = "ZupanijaID"
        Me.colZupanijaM.FieldName = "zupanija"
        Me.colZupanijaM.Name = "colZupanijaM"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gridMjesto
        Me.GridView2.Name = "GridView2"
        '
        'groupUlice
        '
        Me.groupUlice.Controls.Add(Me.gridUlica)
        Me.groupUlice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupUlice.Location = New System.Drawing.Point(0, 0)
        Me.groupUlice.Name = "groupUlice"
        Me.groupUlice.Size = New System.Drawing.Size(280, 404)
        Me.groupUlice.TabIndex = 3
        Me.groupUlice.Text = "Ulice"
        '
        'gridUlica
        '
        Me.gridUlica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridUlica.Location = New System.Drawing.Point(2, 22)
        Me.gridUlica.MainView = Me.gridViewU
        Me.gridUlica.Name = "gridUlica"
        Me.gridUlica.Size = New System.Drawing.Size(276, 380)
        Me.gridUlica.TabIndex = 8
        Me.gridUlica.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewU, Me.GridView1})
        '
        'gridViewU
        '
        Me.gridViewU.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridViewU.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridViewU.Appearance.OddRow.BackColor = System.Drawing.Color.Transparent
        Me.gridViewU.Appearance.OddRow.Options.UseBackColor = True
        Me.gridViewU.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDU, Me.colNazivU})
        Me.gridViewU.GridControl = Me.gridUlica
        Me.gridViewU.Name = "gridViewU"
        Me.gridViewU.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewU.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridViewU.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridViewU.OptionsBehavior.AutoExpandAllGroups = True
        Me.gridViewU.OptionsBehavior.Editable = False
        Me.gridViewU.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.gridViewU.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
        Me.gridViewU.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewU.OptionsView.EnableAppearanceEvenRow = True
        Me.gridViewU.OptionsView.EnableAppearanceOddRow = True
        Me.gridViewU.OptionsView.ShowFooter = True
        Me.gridViewU.OptionsView.ShowGroupPanel = False
        Me.gridViewU.OptionsView.ShowIndicator = False
        '
        'colIDU
        '
        Me.colIDU.Caption = "ID"
        Me.colIDU.FieldName = "mjesto"
        Me.colIDU.Name = "colIDU"
        '
        'colNazivU
        '
        Me.colNazivU.Caption = "Naziv"
        Me.colNazivU.FieldName = "naziv"
        Me.colNazivU.Name = "colNazivU"
        Me.colNazivU.Visible = True
        Me.colNazivU.VisibleIndex = 0
        Me.colNazivU.Width = 192
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridUlica
        Me.GridView1.Name = "GridView1"
        '
        'cmdNew
        '
        Me.cmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdNew.Location = New System.Drawing.Point(7, 5)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(95, 24)
        Me.cmdNew.TabIndex = 3
        Me.cmdNew.Text = "Novi unos"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(635, 5)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(95, 24)
        Me.cmdPrint.TabIndex = 2
        Me.cmdPrint.Text = "Ispis"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(734, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(95, 24)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Izlaz"
        '
        'cmdEdit
        '
        Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdEdit.Location = New System.Drawing.Point(111, 5)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(95, 24)
        Me.cmdEdit.TabIndex = 0
        Me.cmdEdit.Text = "Uredi"
        '
        'frmMjesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(836, 458)
        Me.Controls.Add(Me.SplitContainer3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(647, 496)
        Me.Name = "frmMjesta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMjesta"
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.groupZupanija, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupZupanija.ResumeLayout(False)
        CType(Me.gridZupa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.groupMjesta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupMjesta.ResumeLayout(False)
        CType(Me.gridMjesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupUlice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupUlice.ResumeLayout(False)
        CType(Me.gridUlica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents groupZupanija As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridZupa As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewZ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazivZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents groupMjesta As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridMjesto As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazivM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPTTM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZupanijaM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents groupUlice As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridUlica As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewU As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazivU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
End Class
