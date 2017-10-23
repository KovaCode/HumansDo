<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChat))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.TXTMSG = New System.Windows.Forms.TextBox()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.cmdSend = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdConnect = New DevExpress.XtraEditors.CheckButton()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repCmbImage = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperater = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOperID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAktiv = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.cmdMissed = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCmbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.TXTMSG)
        Me.PanelControl2.Controls.Add(Me.txtSend)
        Me.PanelControl2.Controls.Add(Me.cmdSend)
        Me.PanelControl2.Location = New System.Drawing.Point(262, 8)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(324, 345)
        Me.PanelControl2.TabIndex = 18
        '
        'TXTMSG
        '
        Me.TXTMSG.AllowDrop = True
        Me.TXTMSG.Location = New System.Drawing.Point(10, 14)
        Me.TXTMSG.Multiline = True
        Me.TXTMSG.Name = "TXTMSG"
        Me.TXTMSG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTMSG.Size = New System.Drawing.Size(304, 258)
        Me.TXTMSG.TabIndex = 14
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(5, 307)
        Me.txtSend.Multiline = True
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(309, 33)
        Me.txtSend.TabIndex = 13
        '
        'cmdSend
        '
        Me.cmdSend.Location = New System.Drawing.Point(5, 278)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(309, 23)
        Me.cmdSend.TabIndex = 0
        Me.cmdSend.Text = "Pošalji"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdConnect)
        Me.PanelControl1.Location = New System.Drawing.Point(7, 315)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(249, 36)
        Me.PanelControl1.TabIndex = 20
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(169, 5)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(75, 23)
        Me.cmdConnect.TabIndex = 1
        Me.cmdConnect.Text = "Connect"
        '
        'grid
        '
        Me.grid.Location = New System.Drawing.Point(7, 8)
        Me.grid.MainView = Me.gridView
        Me.grid.Name = "grid"
        Me.grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCmbImage})
        Me.grid.Size = New System.Drawing.Size(249, 301)
        Me.grid.TabIndex = 19
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImage, Me.colID, Me.colOperater, Me.colOperID, Me.colAktiv, Me.colIP})
        Me.gridView.GridControl = Me.grid
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gridView.OptionsBehavior.Editable = False
        Me.gridView.OptionsBehavior.ReadOnly = True
        Me.gridView.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView.OptionsSelection.UseIndicatorForSelection = False
        Me.gridView.OptionsView.ShowGroupPanel = False
        Me.gridView.OptionsView.ShowIndicator = False
        '
        'colImage
        '
        Me.colImage.Caption = "Aktivno"
        Me.colImage.ColumnEdit = Me.repCmbImage
        Me.colImage.FieldName = "aktiv"
        Me.colImage.Name = "colImage"
        Me.colImage.OptionsColumn.AllowEdit = False
        Me.colImage.OptionsColumn.AllowFocus = False
        Me.colImage.OptionsColumn.ShowCaption = False
        Me.colImage.Visible = True
        Me.colImage.VisibleIndex = 0
        Me.colImage.Width = 30
        '
        'repCmbImage
        '
        Me.repCmbImage.AutoHeight = False
        Me.repCmbImage.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repCmbImage.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("neAktiv", False, 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Aktiv", True, 0)})
        Me.repCmbImage.Name = "repCmbImage"
        Me.repCmbImage.SmallImages = Me.ImageCollection1
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "check.png")
        Me.ImageCollection1.Images.SetKeyName(1, "delete.png")
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "id"
        Me.colID.Name = "colID"
        '
        'colOperater
        '
        Me.colOperater.Caption = "Operater"
        Me.colOperater.FieldName = "sOper"
        Me.colOperater.Name = "colOperater"
        Me.colOperater.Visible = True
        Me.colOperater.VisibleIndex = 1
        Me.colOperater.Width = 128
        '
        'colOperID
        '
        Me.colOperID.Caption = "Oper.ID"
        Me.colOperID.FieldName = "oper"
        Me.colOperID.Name = "colOperID"
        '
        'colAktiv
        '
        Me.colAktiv.Caption = "Aktivno"
        Me.colAktiv.FieldName = "aktiv"
        Me.colAktiv.Name = "colAktiv"
        Me.colAktiv.Width = 87
        '
        'colIP
        '
        Me.colIP.Caption = "IP adresa"
        Me.colIP.FieldName = "ip"
        Me.colIP.Name = "colIP"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarSubItem1, Me.cmdMissed})
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarSubItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdMissed, True)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Status"
        Me.BarSubItem1.Id = 0
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'cmdMissed
        '
        Me.cmdMissed.Id = 1
        Me.cmdMissed.Name = "cmdMissed"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(590, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 357)
        Me.barDockControlBottom.Size = New System.Drawing.Size(590, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 357)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(590, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 357)
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(590, 381)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chat"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCmbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TXTMSG As System.Windows.Forms.TextBox
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents cmdSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperater As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOperID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents cmdMissed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colImage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAktiv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCmbImage As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents colIP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdConnect As DevExpress.XtraEditors.CheckButton

End Class
