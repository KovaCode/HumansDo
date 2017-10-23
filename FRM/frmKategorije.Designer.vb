<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKategorije
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKategorije))
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBoja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repBoja = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit()
        Me.colMoje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chk = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEdit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBoja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.Location = New System.Drawing.Point(2, 2)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBoja, Me.chk})
        Me.grid.Size = New System.Drawing.Size(243, 289)
        Me.grid.TabIndex = 0
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNaziv, Me.colBoja, Me.colMoje})
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "naziv"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 0
        Me.colNaziv.Width = 162
        '
        'colBoja
        '
        Me.colBoja.Caption = "Boja"
        Me.colBoja.ColumnEdit = Me.repBoja
        Me.colBoja.FieldName = "color"
        Me.colBoja.Name = "colBoja"
        Me.colBoja.OptionsColumn.AllowSize = False
        Me.colBoja.Visible = True
        Me.colBoja.VisibleIndex = 1
        Me.colBoja.Width = 31
        '
        'repBoja
        '
        Me.repBoja.AutoHeight = False
        Me.repBoja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBoja.ColorText = DevExpress.XtraEditors.Controls.ColorText.[Integer]
        Me.repBoja.CustomColors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty}
        Me.repBoja.Name = "repBoja"
        '
        'colMoje
        '
        Me.colMoje.Caption = "Moje"
        Me.colMoje.ColumnEdit = Me.chk
        Me.colMoje.FieldName = "tip"
        Me.colMoje.Name = "colMoje"
        Me.colMoje.Visible = True
        Me.colMoje.VisibleIndex = 2
        Me.colMoje.Width = 46
        '
        'chk
        '
        Me.chk.AutoHeight = False
        Me.chk.Name = "chk"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(2, 297)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(107, 23)
        Me.cmdNew.TabIndex = 1
        Me.cmdNew.Text = "Novi unos"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(183, 297)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(62, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Obriši"
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(115, 297)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(62, 23)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "Uredi"
        '
        'frmKategorije
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(249, 325)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKategorije"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kategorije"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBoja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBoja As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colMoje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chk As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
