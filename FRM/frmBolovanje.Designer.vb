<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBolovanje
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
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.checkAktiv = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.groupDetalji = New DevExpress.XtraEditors.GroupControl()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.dtpOD = New DevExpress.XtraEditors.DateEdit()
        Me.dtpDO = New DevExpress.XtraEditors.DateEdit()
        Me.lblTrajanje = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblHZZOperiod = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpHZZOdo = New DevExpress.XtraEditors.DateEdit()
        Me.dtpHZZOod = New DevExpress.XtraEditors.DateEdit()
        Me.lblSifra = New DevExpress.XtraEditors.LabelControl()
        Me.txtSifra = New DevExpress.XtraEditors.TextEdit()
        Me.lblPrilog = New DevExpress.XtraEditors.LabelControl()
        Me.cmdBrowse = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAktiv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.groupDetalji, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupDetalji.SuspendLayout()
        CType(Me.dtpOD.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDO.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHZZOdo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHZZOdo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHZZOod.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpHZZOod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSifra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.Location = New System.Drawing.Point(8, 12)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.checkAktiv})
        Me.grid.Size = New System.Drawing.Size(206, 278)
        Me.grid.TabIndex = 41
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.NavajoWhite
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colOD, Me.colDO})
        Me.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsView.EnableAppearanceEvenRow = True
        Me.gridView.OptionsView.EnableAppearanceOddRow = True
        Me.gridView.OptionsView.ShowFooter = True
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        Me.gridView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.gridView.ViewCaption = "Lista bolovanja"
        Me.gridView.ViewCaptionHeight = 50
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'checkAktiv
        '
        Me.checkAktiv.AutoHeight = False
        Me.checkAktiv.Name = "checkAktiv"
        '
        'colOD
        '
        Me.colOD.Caption = "Početak"
        Me.colOD.FieldName = "od"
        Me.colOD.Name = "colOD"
        Me.colOD.Visible = True
        Me.colOD.VisibleIndex = 0
        '
        'colDO
        '
        Me.colDO.Caption = "Kraj"
        Me.colDO.FieldName = "do"
        Me.colDO.Name = "colDO"
        Me.colDO.Visible = True
        Me.colDO.VisibleIndex = 1
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdSave)
        Me.PanelControl1.Controls.Add(Me.cmdNew)
        Me.PanelControl1.Controls.Add(Me.cmdExit)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 296)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(545, 31)
        Me.PanelControl1.TabIndex = 42
        '
        'groupDetalji
        '
        Me.groupDetalji.AutoSize = True
        Me.groupDetalji.Controls.Add(Me.cmdBrowse)
        Me.groupDetalji.Controls.Add(Me.lblPrilog)
        Me.groupDetalji.Controls.Add(Me.txtSifra)
        Me.groupDetalji.Controls.Add(Me.lblSifra)
        Me.groupDetalji.Controls.Add(Me.LabelControl3)
        Me.groupDetalji.Controls.Add(Me.dtpHZZOdo)
        Me.groupDetalji.Controls.Add(Me.dtpHZZOod)
        Me.groupDetalji.Controls.Add(Me.lblHZZOperiod)
        Me.groupDetalji.Controls.Add(Me.LabelControl1)
        Me.groupDetalji.Controls.Add(Me.lblTrajanje)
        Me.groupDetalji.Controls.Add(Me.dtpDO)
        Me.groupDetalji.Controls.Add(Me.dtpOD)
        Me.groupDetalji.Location = New System.Drawing.Point(220, 12)
        Me.groupDetalji.Name = "groupDetalji"
        Me.groupDetalji.Size = New System.Drawing.Size(319, 278)
        Me.groupDetalji.TabIndex = 43
        Me.groupDetalji.Text = "Detalji"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.Location = New System.Drawing.Point(440, 5)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 23)
        Me.cmdExit.TabIndex = 0
        Me.cmdExit.Text = "&Izlaz"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(12, 5)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(100, 23)
        Me.cmdNew.TabIndex = 1
        Me.cmdNew.Text = "&Novi unos"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(118, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(100, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Spremi"
        '
        'dtpOD
        '
        Me.dtpOD.EditValue = Nothing
        Me.dtpOD.Location = New System.Drawing.Point(103, 39)
        Me.dtpOD.Name = "dtpOD"
        Me.dtpOD.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpOD.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpOD.Size = New System.Drawing.Size(87, 20)
        Me.dtpOD.TabIndex = 0
        '
        'dtpDO
        '
        Me.dtpDO.EditValue = Nothing
        Me.dtpDO.Location = New System.Drawing.Point(206, 39)
        Me.dtpDO.Name = "dtpDO"
        Me.dtpDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDO.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpDO.Size = New System.Drawing.Size(87, 20)
        Me.dtpDO.TabIndex = 1
        '
        'lblTrajanje
        '
        Me.lblTrajanje.Location = New System.Drawing.Point(16, 42)
        Me.lblTrajanje.Name = "lblTrajanje"
        Me.lblTrajanje.Size = New System.Drawing.Size(44, 13)
        Me.lblTrajanje.TabIndex = 2
        Me.lblTrajanje.Text = "Trajanje:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(196, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "-"
        '
        'lblHZZOperiod
        '
        Me.lblHZZOperiod.Location = New System.Drawing.Point(16, 70)
        Me.lblHZZOperiod.Name = "lblHZZOperiod"
        Me.lblHZZOperiod.Size = New System.Drawing.Size(72, 13)
        Me.lblHZZOperiod.TabIndex = 4
        Me.lblHZZOperiod.Text = "HZZO trajanje:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(196, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(4, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "-"
        '
        'dtpHZZOdo
        '
        Me.dtpHZZOdo.EditValue = Nothing
        Me.dtpHZZOdo.Location = New System.Drawing.Point(206, 67)
        Me.dtpHZZOdo.Name = "dtpHZZOdo"
        Me.dtpHZZOdo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHZZOdo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpHZZOdo.Size = New System.Drawing.Size(87, 20)
        Me.dtpHZZOdo.TabIndex = 6
        '
        'dtpHZZOod
        '
        Me.dtpHZZOod.EditValue = Nothing
        Me.dtpHZZOod.Location = New System.Drawing.Point(103, 67)
        Me.dtpHZZOod.Name = "dtpHZZOod"
        Me.dtpHZZOod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpHZZOod.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpHZZOod.Size = New System.Drawing.Size(87, 20)
        Me.dtpHZZOod.TabIndex = 5
        '
        'lblSifra
        '
        Me.lblSifra.Location = New System.Drawing.Point(16, 102)
        Me.lblSifra.Name = "lblSifra"
        Me.lblSifra.Size = New System.Drawing.Size(76, 13)
        Me.lblSifra.TabIndex = 8
        Me.lblSifra.Text = "Šifra bolovanja:"
        '
        'txtSifra
        '
        Me.txtSifra.Location = New System.Drawing.Point(103, 99)
        Me.txtSifra.Name = "txtSifra"
        Me.txtSifra.Properties.MaxLength = 5
        Me.txtSifra.Size = New System.Drawing.Size(58, 20)
        Me.txtSifra.TabIndex = 9
        '
        'lblPrilog
        '
        Me.lblPrilog.Location = New System.Drawing.Point(16, 132)
        Me.lblPrilog.Name = "lblPrilog"
        Me.lblPrilog.Size = New System.Drawing.Size(54, 13)
        Me.lblPrilog.TabIndex = 11
        Me.lblPrilog.Text = "Dokumenti:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(103, 128)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(20, 20)
        Me.cmdBrowse.TabIndex = 12
        Me.cmdBrowse.Text = "..."
        '
        'frmBolovanje
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(545, 327)
        Me.Controls.Add(Me.groupDetalji)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBolovanje"
        Me.Text = "frmBolovanje"
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAktiv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.groupDetalji, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupDetalji.ResumeLayout(False)
        Me.groupDetalji.PerformLayout()
        CType(Me.dtpOD.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDO.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHZZOdo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHZZOdo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHZZOod.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpHZZOod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSifra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkAktiv As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents groupDetalji As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSifra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpHZZOdo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpHZZOod As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblHZZOperiod As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTrajanje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpDO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpOD As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblPrilog As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSifra As DevExpress.XtraEditors.TextEdit
End Class
