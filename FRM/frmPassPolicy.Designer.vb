<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassPolicy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassPolicy))
        Me.groupPolicy = New DevExpress.XtraEditors.GroupControl()
        Me.txtPeriod = New DevExpress.XtraEditors.SpinEdit()
        Me.cmbPeriod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lblVrijediDo = New DevExpress.XtraEditors.LabelControl()
        Me.txtPolicy = New DevExpress.XtraEditors.TextEdit()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
        Me.txtOpis = New DevExpress.XtraEditors.MemoEdit()
        Me.txtSymb = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNum = New DevExpress.XtraEditors.SpinEdit()
        Me.txtLow = New DevExpress.XtraEditors.SpinEdit()
        Me.txtUp = New DevExpress.XtraEditors.SpinEdit()
        Me.txtLen = New DevExpress.XtraEditors.SpinEdit()
        Me.lblLen = New DevExpress.XtraEditors.LabelControl()
        Me.lblSymb = New DevExpress.XtraEditors.LabelControl()
        Me.lblNum = New DevExpress.XtraEditors.LabelControl()
        Me.lblLower = New DevExpress.XtraEditors.LabelControl()
        Me.lblUpper = New DevExpress.XtraEditors.LabelControl()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNaziv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdNew = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.groupPolicy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupPolicy.SuspendLayout()
        CType(Me.txtPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPolicy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOpis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSymb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupPolicy
        '
        Me.groupPolicy.Controls.Add(Me.txtPeriod)
        Me.groupPolicy.Controls.Add(Me.cmbPeriod)
        Me.groupPolicy.Controls.Add(Me.lblVrijediDo)
        Me.groupPolicy.Controls.Add(Me.txtPolicy)
        Me.groupPolicy.Controls.Add(Me.lblName)
        Me.groupPolicy.Controls.Add(Me.lblDescription)
        Me.groupPolicy.Controls.Add(Me.txtOpis)
        Me.groupPolicy.Controls.Add(Me.txtSymb)
        Me.groupPolicy.Controls.Add(Me.txtNum)
        Me.groupPolicy.Controls.Add(Me.txtLow)
        Me.groupPolicy.Controls.Add(Me.txtUp)
        Me.groupPolicy.Controls.Add(Me.txtLen)
        Me.groupPolicy.Controls.Add(Me.lblLen)
        Me.groupPolicy.Controls.Add(Me.lblSymb)
        Me.groupPolicy.Controls.Add(Me.lblNum)
        Me.groupPolicy.Controls.Add(Me.lblLower)
        Me.groupPolicy.Controls.Add(Me.lblUpper)
        Me.groupPolicy.Location = New System.Drawing.Point(287, 5)
        Me.groupPolicy.Name = "groupPolicy"
        Me.groupPolicy.Size = New System.Drawing.Size(197, 321)
        Me.groupPolicy.TabIndex = 0
        Me.groupPolicy.Text = "Policy"
        '
        'txtPeriod
        '
        Me.txtPeriod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPeriod.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPeriod.Location = New System.Drawing.Point(153, 177)
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtPeriod.Size = New System.Drawing.Size(39, 20)
        Me.txtPeriod.TabIndex = 18
        '
        'cmbPeriod
        '
        Me.cmbPeriod.Location = New System.Drawing.Point(49, 177)
        Me.cmbPeriod.Name = "cmbPeriod"
        Me.cmbPeriod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPeriod.Size = New System.Drawing.Size(98, 20)
        Me.cmbPeriod.TabIndex = 17
        '
        'lblVrijediDo
        '
        Me.lblVrijediDo.Location = New System.Drawing.Point(10, 180)
        Me.lblVrijediDo.Name = "lblVrijediDo"
        Me.lblVrijediDo.Size = New System.Drawing.Size(33, 13)
        Me.lblVrijediDo.TabIndex = 16
        Me.lblVrijediDo.Text = "Vrijedi:"
        '
        'txtPolicy
        '
        Me.txtPolicy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPolicy.Location = New System.Drawing.Point(61, 30)
        Me.txtPolicy.Name = "txtPolicy"
        Me.txtPolicy.Size = New System.Drawing.Size(131, 20)
        Me.txtPolicy.TabIndex = 15
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(10, 33)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(31, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Policy:"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(5, 226)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(25, 13)
        Me.lblDescription.TabIndex = 13
        Me.lblDescription.Text = "Opis:"
        '
        'txtOpis
        '
        Me.txtOpis.Location = New System.Drawing.Point(5, 245)
        Me.txtOpis.Name = "txtOpis"
        Me.txtOpis.Size = New System.Drawing.Size(187, 71)
        Me.txtOpis.TabIndex = 12
        '
        'txtSymb
        '
        Me.txtSymb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSymb.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSymb.Location = New System.Drawing.Point(112, 149)
        Me.txtSymb.Name = "txtSymb"
        Me.txtSymb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtSymb.Size = New System.Drawing.Size(80, 20)
        Me.txtSymb.TabIndex = 11
        '
        'txtNum
        '
        Me.txtNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNum.Location = New System.Drawing.Point(112, 125)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtNum.Size = New System.Drawing.Size(80, 20)
        Me.txtNum.TabIndex = 10
        '
        'txtLow
        '
        Me.txtLow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLow.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLow.Location = New System.Drawing.Point(112, 101)
        Me.txtLow.Name = "txtLow"
        Me.txtLow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtLow.Size = New System.Drawing.Size(80, 20)
        Me.txtLow.TabIndex = 9
        '
        'txtUp
        '
        Me.txtUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUp.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUp.Location = New System.Drawing.Point(112, 77)
        Me.txtUp.Name = "txtUp"
        Me.txtUp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtUp.Size = New System.Drawing.Size(80, 20)
        Me.txtUp.TabIndex = 8
        '
        'txtLen
        '
        Me.txtLen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLen.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLen.Location = New System.Drawing.Point(112, 53)
        Me.txtLen.Name = "txtLen"
        Me.txtLen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtLen.Size = New System.Drawing.Size(80, 20)
        Me.txtLen.TabIndex = 7
        '
        'lblLen
        '
        Me.lblLen.Location = New System.Drawing.Point(10, 56)
        Me.lblLen.Name = "lblLen"
        Me.lblLen.Size = New System.Drawing.Size(71, 13)
        Me.lblLen.TabIndex = 4
        Me.lblLen.Text = "Dužina lozinke:"
        '
        'lblSymb
        '
        Me.lblSymb.Location = New System.Drawing.Point(10, 152)
        Me.lblSymb.Name = "lblSymb"
        Me.lblSymb.Size = New System.Drawing.Size(61, 13)
        Me.lblSymb.TabIndex = 3
        Me.lblSymb.Text = "Broj simbola:"
        '
        'lblNum
        '
        Me.lblNum.Location = New System.Drawing.Point(10, 128)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(63, 13)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "Broj brojeva:"
        '
        'lblLower
        '
        Me.lblLower.Location = New System.Drawing.Point(10, 104)
        Me.lblLower.Name = "lblLower"
        Me.lblLower.Size = New System.Drawing.Size(78, 13)
        Me.lblLower.TabIndex = 1
        Me.lblLower.Text = "Broj malih slova:"
        '
        'lblUpper
        '
        Me.lblUpper.Location = New System.Drawing.Point(10, 80)
        Me.lblUpper.Name = "lblUpper"
        Me.lblUpper.Size = New System.Drawing.Size(83, 13)
        Me.lblUpper.TabIndex = 0
        Me.lblUpper.Text = "Broj velikih slova:"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(270, 332)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(104, 23)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Spremi"
        '
        'grid
        '
        Me.grid.Location = New System.Drawing.Point(6, 5)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(276, 321)
        Me.grid.TabIndex = 3
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gridView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colNaziv})
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.ReadOnly = True
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
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colNaziv
        '
        Me.colNaziv.Caption = "Naziv"
        Me.colNaziv.FieldName = "policy"
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Visible = True
        Me.colNaziv.VisibleIndex = 0
        Me.colNaziv.Width = 114
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(380, 332)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 23)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Obriši"
        '
        'cmdNew
        '
        Me.cmdNew.Location = New System.Drawing.Point(6, 332)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(104, 23)
        Me.cmdNew.TabIndex = 5
        Me.cmdNew.Text = "&Novi unos"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'frmPassPolicy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(488, 362)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.groupPolicy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPassPolicy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "passPolicy"
        CType(Me.groupPolicy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupPolicy.ResumeLayout(False)
        Me.groupPolicy.PerformLayout()
        CType(Me.txtPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPolicy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOpis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSymb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupPolicy As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblLen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSymb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNum As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLower As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUpper As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPolicy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOpis As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtSymb As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNum As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtLow As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtUp As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtLen As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNaziv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents txtPeriod As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmbPeriod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lblVrijediDo As DevExpress.XtraEditors.LabelControl
End Class
