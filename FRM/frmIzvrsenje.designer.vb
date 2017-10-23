<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIzvrsenje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIzvrsenje))
        Me.img = New DevExpress.Utils.ImageCollection(Me.components)
        Me.txtDetOpis = New DevExpress.XtraEditors.MemoExEdit()
        Me.cmdStart = New DevExpress.XtraEditors.CheckButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.groupIzvrsenja = New DevExpress.XtraEditors.GroupControl()
        Me.lblPosto = New DevExpress.XtraEditors.LabelControl()
        Me.trackPosto = New DevExpress.XtraEditors.TrackBarControl()
        Me.RangeTrackBarControl1 = New DevExpress.XtraEditors.RangeTrackBarControl()
        Me.txtOpis = New System.Windows.Forms.TextBox()
        Me.lblNaziv = New System.Windows.Forms.Label()
        Me.lblDescription = New DevExpress.XtraEditors.LabelControl()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDetOpis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupIzvrsenja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupIzvrsenja.SuspendLayout()
        CType(Me.trackPosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackPosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeTrackBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.img.Images.SetKeyName(0, "stopwatch.png")
        Me.img.Images.SetKeyName(1, "stopwatch_pause.png")
        Me.img.Images.SetKeyName(2, "stopwatch_reset.png")
        Me.img.Images.SetKeyName(3, "stopwatch_run.png")
        '
        'txtDetOpis
        '
        Me.txtDetOpis.Location = New System.Drawing.Point(62, 58)
        Me.txtDetOpis.Name = "txtDetOpis"
        Me.txtDetOpis.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtDetOpis.Properties.MaxLength = 500
        Me.txtDetOpis.Size = New System.Drawing.Size(110, 20)
        Me.txtDetOpis.TabIndex = 7
        '
        'cmdStart
        '
        Me.cmdStart.ImageIndex = 3
        Me.cmdStart.ImageList = Me.img
        Me.cmdStart.Location = New System.Drawing.Point(313, 25)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(84, 78)
        Me.cmdStart.TabIndex = 20
        Me.cmdStart.Text = "Pokreni"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(414, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 115)
        Me.barDockControlBottom.Size = New System.Drawing.Size(414, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 115)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(414, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 115)
        '
        'groupIzvrsenja
        '
        Me.groupIzvrsenja.Controls.Add(Me.lblPosto)
        Me.groupIzvrsenja.Controls.Add(Me.trackPosto)
        Me.groupIzvrsenja.Controls.Add(Me.RangeTrackBarControl1)
        Me.groupIzvrsenja.Controls.Add(Me.txtOpis)
        Me.groupIzvrsenja.Controls.Add(Me.lblNaziv)
        Me.groupIzvrsenja.Controls.Add(Me.lblDescription)
        Me.groupIzvrsenja.Controls.Add(Me.cmdStart)
        Me.groupIzvrsenja.Controls.Add(Me.txtDetOpis)
        Me.groupIzvrsenja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupIzvrsenja.Location = New System.Drawing.Point(0, 0)
        Me.groupIzvrsenja.Name = "groupIzvrsenja"
        Me.groupIzvrsenja.Size = New System.Drawing.Size(414, 115)
        Me.groupIzvrsenja.TabIndex = 25
        Me.groupIzvrsenja.Text = "Naziv izvrsenja"
        '
        'lblPosto
        '
        Me.lblPosto.Location = New System.Drawing.Point(233, 90)
        Me.lblPosto.Name = "lblPosto"
        Me.lblPosto.Size = New System.Drawing.Size(17, 13)
        Me.lblPosto.TabIndex = 35
        Me.lblPosto.Text = "0%"
        '
        'trackPosto
        '
        Me.trackPosto.EditValue = Nothing
        Me.trackPosto.Location = New System.Drawing.Point(204, 58)
        Me.trackPosto.MenuManager = Me.BarManager1
        Me.trackPosto.Name = "trackPosto"
        Me.trackPosto.Properties.LargeChange = 25
        Me.trackPosto.Properties.Maximum = 100
        Me.trackPosto.Properties.SmallChange = 10
        Me.trackPosto.Properties.TickFrequency = 10
        Me.trackPosto.Size = New System.Drawing.Size(94, 45)
        Me.trackPosto.TabIndex = 34
        '
        'RangeTrackBarControl1
        '
        Me.RangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
        Me.RangeTrackBarControl1.Location = New System.Drawing.Point(-21, -43)
        Me.RangeTrackBarControl1.MenuManager = Me.BarManager1
        Me.RangeTrackBarControl1.Name = "RangeTrackBarControl1"
        Me.RangeTrackBarControl1.Size = New System.Drawing.Size(104, 45)
        Me.RangeTrackBarControl1.TabIndex = 33
        '
        'txtOpis
        '
        Me.txtOpis.Location = New System.Drawing.Point(62, 32)
        Me.txtOpis.MaxLength = 50
        Me.txtOpis.Name = "txtOpis"
        Me.txtOpis.Size = New System.Drawing.Size(236, 20)
        Me.txtOpis.TabIndex = 32
        '
        'lblNaziv
        '
        Me.lblNaziv.AutoSize = True
        Me.lblNaziv.Location = New System.Drawing.Point(12, 35)
        Me.lblNaziv.Name = "lblNaziv"
        Me.lblNaziv.Size = New System.Drawing.Size(37, 13)
        Me.lblNaziv.TabIndex = 31
        Me.lblNaziv.Text = "Naziv:"
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(15, 65)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(25, 13)
        Me.lblDescription.TabIndex = 21
        Me.lblDescription.Text = "Opis:"
        '
        'frmIzvrsenje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(414, 115)
        Me.Controls.Add(Me.groupIzvrsenja)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIzvrsenje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Izvršenje"
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDetOpis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupIzvrsenja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupIzvrsenja.ResumeLayout(False)
        Me.groupIzvrsenja.PerformLayout()
        CType(Me.trackPosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackPosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeTrackBarControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RangeTrackBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDetOpis As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents img As DevExpress.Utils.ImageCollection
    Friend WithEvents cmdStart As DevExpress.XtraEditors.CheckButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents groupIzvrsenja As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblDescription As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOpis As System.Windows.Forms.TextBox
    Friend WithEvents lblNaziv As System.Windows.Forms.Label
    Friend WithEvents RangeTrackBarControl1 As DevExpress.XtraEditors.RangeTrackBarControl
    Friend WithEvents lblPosto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents trackPosto As DevExpress.XtraEditors.TrackBarControl
End Class
