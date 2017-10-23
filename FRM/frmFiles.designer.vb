<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFiles))
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repImage = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.colImageID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdOpen = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.Location = New System.Drawing.Point(2, 3)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repImage})
        Me.grid.Size = New System.Drawing.Size(253, 298)
        Me.grid.TabIndex = 0
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNaziv, Me.colVel, Me.colImage, Me.colImageID})
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsSelection.UseIndicatorForSelection = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "naziv"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 1
        Me.colNaziv.Width = 157
        '
        'colVel
        '
        Me.colVel.Caption = "Vel.[kB]"
        Me.colVel.FieldName = "sizeKB"
        Me.colVel.Name = "colVel"
        Me.colVel.Visible = True
        Me.colVel.VisibleIndex = 2
        Me.colVel.Width = 74
        '
        'colImage
        '
        Me.colImage.Caption = "#"
        Me.colImage.ColumnEdit = Me.repImage
        Me.colImage.FieldName = "Image"
        Me.colImage.Name = "colImage"
        Me.colImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
        Me.colImage.Visible = True
        Me.colImage.VisibleIndex = 0
        Me.colImage.Width = 20
        '
        'repImage
        '
        Me.repImage.Name = "repImage"
        '
        'colImageID
        '
        Me.colImageID.Caption = "idImage"
        Me.colImageID.FieldName = "tip"
        Me.colImageID.Name = "colImageID"
        Me.colImageID.Width = 58
        '
        'cmdOpen
        '
        Me.cmdOpen.Enabled = False
        Me.cmdOpen.Location = New System.Drawing.Point(180, 307)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(75, 23)
        Me.cmdOpen.TabIndex = 1
        Me.cmdOpen.Text = "&Otvori"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(83, 307)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(91, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Spremi"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(263, 335)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dokumenti"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdOpen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repImage As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colImageID As DevExpress.XtraGrid.Columns.GridColumn
End Class
