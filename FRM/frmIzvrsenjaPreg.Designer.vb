<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIzvrsenjaPreg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIzvrsenjaPreg))
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.rightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolPrintPrew = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolExport = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolXLS = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolXLSX = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolHTML = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolRTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjekt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZadatak = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOper = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVrijeme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpisRada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtDetOpis = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colPosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblUkupno = New DevExpress.XtraEditors.LabelControl()
        Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
        Me.progress = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.rightClickMenu.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetOpis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(626, 3)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(122, 23)
        Me.cmdExit.TabIndex = 23
        Me.cmdExit.Text = "&Odustani"
        '
        'cmdPrint
        '
        Me.cmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrint.Location = New System.Drawing.Point(498, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(122, 23)
        Me.cmdPrint.TabIndex = 24
        Me.cmdPrint.Text = "Is&pis"
        '
        'rightClickMenu
        '
        Me.rightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolPrintPrew, Me.ToolStripSeparator1, Me.toolExport})
        Me.rightClickMenu.Name = "rightClickMenu"
        Me.rightClickMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.rightClickMenu.Size = New System.Drawing.Size(147, 54)
        '
        'toolPrintPrew
        '
        Me.toolPrintPrew.Name = "toolPrintPrew"
        Me.toolPrintPrew.Size = New System.Drawing.Size(146, 22)
        Me.toolPrintPrew.Text = "Pregled ispisa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'toolExport
        '
        Me.toolExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolPDF, Me.toolXLS, Me.toolXLSX, Me.toolHTML, Me.toolRTF})
        Me.toolExport.Name = "toolExport"
        Me.toolExport.Size = New System.Drawing.Size(146, 22)
        Me.toolExport.Text = "Export"
        '
        'toolPDF
        '
        Me.toolPDF.Name = "toolPDF"
        Me.toolPDF.Size = New System.Drawing.Size(107, 22)
        Me.toolPDF.Text = "PDF"
        '
        'toolXLS
        '
        Me.toolXLS.Name = "toolXLS"
        Me.toolXLS.Size = New System.Drawing.Size(107, 22)
        Me.toolXLS.Text = "XLS"
        '
        'toolXLSX
        '
        Me.toolXLSX.Name = "toolXLSX"
        Me.toolXLSX.Size = New System.Drawing.Size(107, 22)
        Me.toolXLSX.Text = "XLSX"
        '
        'toolHTML
        '
        Me.toolHTML.Name = "toolHTML"
        Me.toolHTML.Size = New System.Drawing.Size(107, 22)
        Me.toolHTML.Text = "HTML"
        '
        'toolRTF
        '
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.grid)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblUkupno)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdPrint)
        Me.SplitContainer1.Size = New System.Drawing.Size(751, 328)
        Me.SplitContainer1.SplitterDistance = 293
        Me.SplitContainer1.TabIndex = 26
        '
        'grid
        '
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txtDetOpis, Me.progress})
        Me.grid.Size = New System.Drawing.Size(751, 293)
        Me.grid.TabIndex = 26
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNaziv, Me.colProjekt, Me.colZadatak, Me.colOper, Me.colVrijeme, Me.colOpisRada, Me.colPosto})
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.RowHeight = 20
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Width = 81
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Opis"
        Me.colNaziv.FieldName = "opis"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.OptionsColumn.AllowEdit = False
        Me.colNaziv.OptionsColumn.AllowFocus = False
        Me.colNaziv.OptionsColumn.ReadOnly = True
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 2
        Me.colNaziv.Width = 176
        '
        'colProjekt
        '
        Me.colProjekt.Caption = "Projekt"
        Me.colProjekt.FieldName = "sProjekt"
        Me.colProjekt.Name = "colProjekt"
        Me.colProjekt.OptionsColumn.AllowEdit = False
        Me.colProjekt.OptionsColumn.AllowFocus = False
        Me.colProjekt.OptionsColumn.ReadOnly = True
        Me.colProjekt.Visible = True
        Me.colProjekt.VisibleIndex = 0
        Me.colProjekt.Width = 120
        '
        'colZadatak
        '
        Me.colZadatak.Caption = "Zadatak"
        Me.colZadatak.FieldName = "sZadatak"
        Me.colZadatak.Name = "colZadatak"
        Me.colZadatak.OptionsColumn.AllowEdit = False
        Me.colZadatak.OptionsColumn.AllowFocus = False
        Me.colZadatak.OptionsColumn.ReadOnly = True
        Me.colZadatak.Visible = True
        Me.colZadatak.VisibleIndex = 1
        Me.colZadatak.Width = 126
        '
        'colOper
        '
        Me.colOper.Caption = "Operater"
        Me.colOper.FieldName = "oper"
        Me.colOper.Name = "colOper"
        Me.colOper.OptionsColumn.AllowEdit = False
        Me.colOper.OptionsColumn.AllowFocus = False
        Me.colOper.OptionsColumn.ReadOnly = True
        Me.colOper.Visible = True
        Me.colOper.VisibleIndex = 3
        Me.colOper.Width = 76
        '
        'colVrijeme
        '
        Me.colVrijeme.Caption = "Vrijeme rada"
        Me.colVrijeme.FieldName = "vrijemeRad"
        Me.colVrijeme.Name = "colVrijeme"
        Me.colVrijeme.OptionsColumn.AllowEdit = False
        Me.colVrijeme.OptionsColumn.AllowFocus = False
        Me.colVrijeme.OptionsColumn.ReadOnly = True
        Me.colVrijeme.Visible = True
        Me.colVrijeme.VisibleIndex = 4
        Me.colVrijeme.Width = 60
        '
        'colOpisRada
        '
        Me.colOpisRada.Caption = "Opis rada"
        Me.colOpisRada.ColumnEdit = Me.txtDetOpis
        Me.colOpisRada.FieldName = "detOpis"
        Me.colOpisRada.Name = "colOpisRada"
        Me.colOpisRada.Visible = True
        Me.colOpisRada.VisibleIndex = 5
        Me.colOpisRada.Width = 50
        '
        'txtDetOpis
        '
        Me.txtDetOpis.AutoHeight = False
        Me.txtDetOpis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDetOpis.Name = "txtDetOpis"
        '
        'colPosto
        '
        Me.colPosto.Caption = "%"
        Me.colPosto.ColumnEdit = Me.progress
        Me.colPosto.FieldName = "posto"
        Me.colPosto.Name = "colPosto"
        Me.colPosto.OptionsColumn.AllowEdit = False
        Me.colPosto.OptionsColumn.AllowFocus = False
        Me.colPosto.OptionsColumn.ReadOnly = True
        Me.colPosto.Visible = True
        Me.colPosto.VisibleIndex = 6
        Me.colPosto.Width = 42
        '
        'lblUkupno
        '
        Me.lblUkupno.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblUkupno.Location = New System.Drawing.Point(104, 8)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(6, 13)
        Me.lblUkupno.TabIndex = 27
        Me.lblUkupno.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(9, 8)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 13)
        Me.lblTotal.TabIndex = 26
        Me.lblTotal.Text = "Ukupno aktivnosti:"
        '
        'progress
        '
        Me.progress.Name = "progress"
        Me.progress.ShowTitle = True
        '
        'frmIzvrsenjaPreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(751, 328)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIzvrsenjaPreg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pregled trenutnih izvršenja"
        Me.rightClickMenu.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetOpis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rightClickMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents toolPrintPrew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolExport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents toolPDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolXLS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolXLSX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolRTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProjekt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZadatak As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOper As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVrijeme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpisRada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDetOpis As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents colPosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblUkupno As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents progress As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
End Class
