<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNewMessage))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdSend = New DevExpress.XtraEditors.DropDownButton()
        Me.PopupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.cmdReply = New DevExpress.XtraEditors.SimpleButton()
        Me.picImages = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdForward = New DevExpress.XtraEditors.SimpleButton()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.cmdPrilog = New DevExpress.XtraBars.BarButtonItem()
        Me.subPrioritet = New DevExpress.XtraBars.BarSubItem()
        Me.cmdNisko = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdSrednje = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdVisoko = New DevExpress.XtraBars.BarButtonItem()
        Me.lblPodaci = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridPrilog = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmbOperater = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.txtSubject = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPoruka = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupControlContainer1.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPrilog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperater.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoruka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdSend)
        Me.PanelControl1.Controls.Add(Me.cmbOperater)
        Me.PanelControl1.Controls.Add(Me.txtSubject)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(430, 77)
        Me.PanelControl1.TabIndex = 0
        '
        'cmdSend
        '
        Me.cmdSend.DropDownControl = Me.PopupControlContainer1
        Me.cmdSend.ImageIndex = 3
        Me.cmdSend.ImageList = Me.picImages
        Me.cmdSend.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.cmdSend.Location = New System.Drawing.Point(5, 12)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.ShowArrowButton = False
        Me.cmdSend.Size = New System.Drawing.Size(70, 50)
        Me.cmdSend.TabIndex = 10
        Me.cmdSend.Text = "Pošalji"
        '
        'PopupControlContainer1
        '
        Me.PopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupControlContainer1.Controls.Add(Me.cmdReply)
        Me.PopupControlContainer1.Controls.Add(Me.cmdForward)
        Me.PopupControlContainer1.Location = New System.Drawing.Point(5, 72)
        Me.PopupControlContainer1.Manager = Me.BarManager1
        Me.PopupControlContainer1.Name = "PopupControlContainer1"
        Me.PopupControlContainer1.ShowCloseButton = True
        Me.PopupControlContainer1.Size = New System.Drawing.Size(84, 57)
        Me.PopupControlContainer1.TabIndex = 15
        Me.PopupControlContainer1.Visible = False
        '
        'cmdReply
        '
        Me.cmdReply.ImageIndex = 8
        Me.cmdReply.ImageList = Me.picImages
        Me.cmdReply.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdReply.Location = New System.Drawing.Point(3, 3)
        Me.cmdReply.Name = "cmdReply"
        Me.cmdReply.Size = New System.Drawing.Size(77, 20)
        Me.cmdReply.TabIndex = 2
        Me.cmdReply.Text = "Odgovori"
        '
        'picImages
        '
        Me.picImages.ImageStream = CType(resources.GetObject("picImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.picImages.TransparentColor = System.Drawing.Color.Magenta
        Me.picImages.Images.SetKeyName(0, "")
        Me.picImages.Images.SetKeyName(1, "")
        Me.picImages.Images.SetKeyName(2, "")
        Me.picImages.Images.SetKeyName(3, "")
        Me.picImages.Images.SetKeyName(4, "")
        Me.picImages.Images.SetKeyName(5, "")
        Me.picImages.Images.SetKeyName(6, "note_pinned.png")
        Me.picImages.Images.SetKeyName(7, "icon-msg-unread.gif")
        Me.picImages.Images.SetKeyName(8, "icon-msg-reply.gif")
        Me.picImages.Images.SetKeyName(9, "icon-msg-forward.gif")
        Me.picImages.Images.SetKeyName(10, "send.gif")
        '
        'cmdForward
        '
        Me.cmdForward.ImageIndex = 9
        Me.cmdForward.ImageList = Me.picImages
        Me.cmdForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.cmdForward.Location = New System.Drawing.Point(4, 29)
        Me.cmdForward.Name = "cmdForward"
        Me.cmdForward.Size = New System.Drawing.Size(77, 22)
        Me.cmdForward.TabIndex = 3
        Me.cmdForward.Text = "Proslijedi"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.picImages
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdPrilog, Me.subPrioritet, Me.cmdNisko, Me.cmdSrednje, Me.cmdVisoko, Me.lblPodaci})
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.gridPrilog})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdPrilog), New DevExpress.XtraBars.LinkPersistInfo(Me.subPrioritet), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.lblPodaci, Nothing, True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'cmdPrilog
        '
        Me.cmdPrilog.Id = 5
        Me.cmdPrilog.ImageIndex = 4
        Me.cmdPrilog.Name = "cmdPrilog"
        Me.cmdPrilog.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'subPrioritet
        '
        Me.subPrioritet.Id = 8
        Me.subPrioritet.ImageIndex = 1
        Me.subPrioritet.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdNisko), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSrednje), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdVisoko)})
        Me.subPrioritet.Name = "subPrioritet"
        Me.subPrioritet.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'cmdNisko
        '
        Me.cmdNisko.Caption = "Nisko"
        Me.cmdNisko.Id = 9
        Me.cmdNisko.ImageIndex = 0
        Me.cmdNisko.Name = "cmdNisko"
        '
        'cmdSrednje
        '
        Me.cmdSrednje.Caption = "Srednje"
        Me.cmdSrednje.Id = 10
        Me.cmdSrednje.Name = "cmdSrednje"
        '
        'cmdVisoko
        '
        Me.cmdVisoko.Caption = "Visoko"
        Me.cmdVisoko.Id = 11
        Me.cmdVisoko.ImageIndex = 1
        Me.cmdVisoko.Name = "cmdVisoko"
        '
        'lblPodaci
        '
        Me.lblPodaci.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblPodaci.Id = 13
        Me.lblPodaci.ImageIndex = 3
        Me.lblPodaci.Name = "lblPodaci"
        Me.lblPodaci.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(430, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 288)
        Me.barDockControlBottom.Size = New System.Drawing.Size(430, 24)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 288)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(430, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 288)
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'gridPrilog
        '
        Me.gridPrilog.AutoHeight = False
        Me.gridPrilog.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.gridPrilog.Name = "gridPrilog"
        Me.gridPrilog.ReadOnly = True
        Me.gridPrilog.View = Me.RepositoryItemGridLookUpEdit2View
        '
        'RepositoryItemGridLookUpEdit2View
        '
        Me.RepositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit2View.Name = "RepositoryItemGridLookUpEdit2View"
        Me.RepositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        Me.RepositoryItemGridLookUpEdit2View.OptionsView.ShowIndicator = False
        Me.RepositoryItemGridLookUpEdit2View.ViewCaptionHeight = 0
        '
        'cmbOperater
        '
        Me.cmbOperater.Location = New System.Drawing.Point(123, 13)
        Me.cmbOperater.MenuManager = Me.BarManager1
        Me.cmbOperater.Name = "cmbOperater"
        Me.cmbOperater.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOperater.Size = New System.Drawing.Size(295, 20)
        Me.cmbOperater.TabIndex = 5
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(123, 39)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(295, 20)
        Me.txtSubject.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(81, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Naslov:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(81, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Kome:"
        '
        'txtPoruka
        '
        Me.txtPoruka.Location = New System.Drawing.Point(0, 75)
        Me.txtPoruka.MenuManager = Me.BarManager1
        Me.txtPoruka.Name = "txtPoruka"
        Me.txtPoruka.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtPoruka.Properties.ValidateOnEnterKey = True
        Me.txtPoruka.Size = New System.Drawing.Size(430, 211)
        Me.txtPoruka.TabIndex = 5
        '
        'frmNewMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(430, 312)
        Me.Controls.Add(Me.PopupControlContainer1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtPoruka)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nova poruka"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupControlContainer1.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPrilog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperater.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoruka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtSubject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents gridPrilog As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtPoruka As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbOperater As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmdPrilog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents subPrioritet As DevExpress.XtraBars.BarSubItem
    Friend WithEvents cmdNisko As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdSrednje As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdVisoko As DevExpress.XtraBars.BarButtonItem
    Private WithEvents picImages As System.Windows.Forms.ImageList
    Friend WithEvents lblPodaci As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdForward As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdReply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSend As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents PopupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
End Class
