<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClock))
        Me.DigitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clock = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.DigitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
        Me.DigitalBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        Me.DigitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DigitalBackgroundLayerComponent1
        '
        Me.DigitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(403.700012!, 99.9625015!)
        Me.DigitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent13"
        Me.DigitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style12
        Me.DigitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
        Me.DigitalBackgroundLayerComponent1.ZOrder = 1000
        '
        'Timer1
        '
        '
        'clock
        '
        Me.clock.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.DigitalGauge1})
        Me.clock.Location = New System.Drawing.Point(0, 0)
        Me.clock.Name = "clock"
        Me.clock.Size = New System.Drawing.Size(265, 105)
        Me.clock.TabIndex = 0
        '
        'DigitalGauge1
        '
        Me.DigitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
        Me.DigitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
        Me.DigitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.DigitalBackgroundLayerComponent3})
        Me.DigitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 253, 93)
        Me.DigitalGauge1.DigitCount = 5
        Me.DigitalGauge1.Name = "DigitalGauge1"
        Me.DigitalGauge1.Text = "00,000"
        '
        'DigitalBackgroundLayerComponent3
        '
        Me.DigitalBackgroundLayerComponent3.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625015!)
        Me.DigitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent6"
        Me.DigitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style6
        Me.DigitalBackgroundLayerComponent3.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
        Me.DigitalBackgroundLayerComponent3.ZOrder = 1000
        '
        'DigitalBackgroundLayerComponent2
        '
        Me.DigitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(259.8125!, 99.9625015!)
        Me.DigitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent13"
        Me.DigitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style1
        Me.DigitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20.0!, 0.0!)
        Me.DigitalBackgroundLayerComponent2.ZOrder = 1000
        '
        'frmClock
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 104)
        Me.Controls.Add(Me.clock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vrijeme"
        CType(Me.DigitalBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DigitalBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents DigitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents clock As DevExpress.XtraGauges.Win.GaugeControl
    Private WithEvents DigitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    Friend WithEvents DigitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge
    Private WithEvents DigitalBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
End Class
