<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoggPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoggPreview))
        Me.tl = New DevExpress.XtraTreeList.TreeList()
        Me.colDateTime = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colDescription = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colChkSum = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.cmdExit = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.optExport = New DevExpress.XtraEditors.RadioGroup()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdExport = New DevExpress.XtraEditors.DropDownButton()
        CType(Me.tl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupControlContainer1.SuspendLayout()
        CType(Me.optExport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tl
        '
        Me.tl.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.tl.Appearance.Empty.Options.UseBackColor = True
        Me.tl.Appearance.EvenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tl.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.EvenRow.Options.UseBackColor = True
        Me.tl.Appearance.EvenRow.Options.UseForeColor = True
        Me.tl.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.tl.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.FocusedCell.Options.UseBackColor = True
        Me.tl.Appearance.FocusedCell.Options.UseForeColor = True
        Me.tl.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.tl.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.tl.Appearance.FocusedRow.Options.UseBackColor = True
        Me.tl.Appearance.FocusedRow.Options.UseForeColor = True
        Me.tl.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tl.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tl.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tl.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.tl.Appearance.FooterPanel.Options.UseBackColor = True
        Me.tl.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.tl.Appearance.FooterPanel.Options.UseForeColor = True
        Me.tl.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tl.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tl.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.GroupButton.Options.UseBackColor = True
        Me.tl.Appearance.GroupButton.Options.UseBorderColor = True
        Me.tl.Appearance.GroupButton.Options.UseForeColor = True
        Me.tl.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tl.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.tl.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.GroupFooter.Options.UseBackColor = True
        Me.tl.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.tl.Appearance.GroupFooter.Options.UseForeColor = True
        Me.tl.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tl.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tl.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tl.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.tl.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.tl.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.tl.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.tl.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.tl.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.tl.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.tl.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.tl.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.tl.Appearance.HorzLine.Options.UseBackColor = True
        Me.tl.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.tl.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.OddRow.Options.UseBackColor = True
        Me.tl.Appearance.OddRow.Options.UseForeColor = True
        Me.tl.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tl.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.tl.Appearance.Preview.Options.UseBackColor = True
        Me.tl.Appearance.Preview.Options.UseForeColor = True
        Me.tl.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.tl.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.tl.Appearance.Row.Options.UseBackColor = True
        Me.tl.Appearance.Row.Options.UseForeColor = True
        Me.tl.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.tl.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.tl.Appearance.SelectedRow.Options.UseBackColor = True
        Me.tl.Appearance.SelectedRow.Options.UseForeColor = True
        Me.tl.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.tl.Appearance.TreeLine.Options.UseBackColor = True
        Me.tl.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.tl.Appearance.VertLine.Options.UseBackColor = True
        Me.tl.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colDateTime, Me.colDescription, Me.colChkSum})
        Me.tl.Location = New System.Drawing.Point(2, 3)
        Me.tl.Name = "tl"
        Me.tl.OptionsView.EnableAppearanceEvenRow = True
        Me.tl.OptionsView.EnableAppearanceOddRow = True
        Me.tl.Size = New System.Drawing.Size(787, 437)
        Me.tl.TabIndex = 1
        '
        'colDateTime
        '
        Me.colDateTime.Caption = "Datum/Vrijeme"
        Me.colDateTime.FieldName = "Logovi"
        Me.colDateTime.Name = "colDateTime"
        Me.colDateTime.OptionsColumn.AllowEdit = False
        Me.colDateTime.OptionsColumn.AllowFocus = False
        Me.colDateTime.OptionsColumn.AllowMove = False
        Me.colDateTime.OptionsColumn.FixedWidth = True
        Me.colDateTime.OptionsColumn.ReadOnly = True
        Me.colDateTime.Visible = True
        Me.colDateTime.VisibleIndex = 0
        Me.colDateTime.Width = 116
        '
        'colDescription
        '
        Me.colDescription.Caption = "Opis"
        Me.colDescription.FieldName = "Opis"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.OptionsColumn.AllowMove = False
        Me.colDescription.OptionsColumn.FixedWidth = True
        Me.colDescription.OptionsColumn.ReadOnly = True
        Me.colDescription.OptionsColumn.ShowInCustomizationForm = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 1
        Me.colDescription.Width = 538
        '
        'colChkSum
        '
        Me.colChkSum.Caption = "chkSum"
        Me.colChkSum.FieldName = "chkSum"
        Me.colChkSum.Name = "colChkSum"
        Me.colChkSum.OptionsColumn.AllowEdit = False
        Me.colChkSum.OptionsColumn.AllowFocus = False
        Me.colChkSum.OptionsColumn.AllowMove = False
        Me.colChkSum.OptionsColumn.FixedWidth = True
        Me.colChkSum.OptionsColumn.ReadOnly = True
        Me.colChkSum.Visible = True
        Me.colChkSum.VisibleIndex = 2
        Me.colChkSum.Width = 74
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(694, 446)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(95, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "I&zlaz"
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(492, 446)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(95, 23)
        Me.cmdPrint.TabIndex = 5
        Me.cmdPrint.Text = "Is&pis"
        '
        'PopupControlContainer1
        '
        Me.PopupControlContainer1.Appearance.BackColor = System.Drawing.Color.White
        Me.PopupControlContainer1.Appearance.Options.UseBackColor = True
        Me.PopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupControlContainer1.Controls.Add(Me.optExport)
        Me.PopupControlContainer1.Location = New System.Drawing.Point(38, 513)
        Me.PopupControlContainer1.Manager = Me.BarManager1
        Me.PopupControlContainer1.Name = "PopupControlContainer1"
        Me.PopupControlContainer1.Size = New System.Drawing.Size(69, 141)
        Me.PopupControlContainer1.TabIndex = 23
        Me.PopupControlContainer1.Visible = False
        '
        'optExport
        '
        Me.optExport.EditValue = CType(0, Short)
        Me.optExport.Location = New System.Drawing.Point(4, 3)
        Me.optExport.Name = "optExport"
        Me.optExport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(0, Short), "PDF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "XLS"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "XLSX"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "RTF"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(4, Short), "HTML"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(5, Short), "TXT")})
        Me.optExport.Size = New System.Drawing.Size(62, 134)
        Me.optExport.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(790, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 474)
        Me.barDockControlBottom.Size = New System.Drawing.Size(790, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 474)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(790, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 474)
        '
        'cmdExport
        '
        Me.cmdExport.DropDownControl = Me.PopupControlContainer1
        Me.cmdExport.Location = New System.Drawing.Point(593, 446)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(95, 23)
        Me.cmdExport.TabIndex = 22
        Me.cmdExport.Text = "Izvoz"
        '
        'frmLoggPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 474)
        Me.Controls.Add(Me.PopupControlContainer1)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.tl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoggPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pregled logg-ova"
        CType(Me.tl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupControlContainer1.ResumeLayout(False)
        CType(Me.optExport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tl As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colDateTime As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents cmdExit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents optExport As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdExport As DevExpress.XtraEditors.DropDownButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colDescription As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colChkSum As DevExpress.XtraTreeList.Columns.TreeListColumn
End Class
