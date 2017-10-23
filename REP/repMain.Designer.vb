<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repMain
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.colID = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colNaziv = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colPrioritet = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colAnaliza = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colPlan = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colDemo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colTest = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colImplement = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colVoditelj = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 19.3333302!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(649.999878!, 16.5540504!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.colID, Me.colNaziv, Me.colPrioritet, Me.colAnaliza, Me.colPlan, Me.colDemo, Me.colTest, Me.colImplement, Me.colVoditelj})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'colID
        '
        Me.colID.Name = "colID"
        Me.colID.Text = "id"
        Me.colID.Weight = 0.11538456662871219R
        '
        'colNaziv
        '
        Me.colNaziv.Name = "colNaziv"
        Me.colNaziv.Text = "colNaziv"
        Me.colNaziv.Weight = 0.57835235893411185R
        '
        'colPrioritet
        '
        Me.colPrioritet.Name = "colPrioritet"
        Me.colPrioritet.Text = "colPrioritet"
        Me.colPrioritet.Weight = 0.32307698375093596R
        '
        'colAnaliza
        '
        Me.colAnaliza.Name = "colAnaliza"
        Me.colAnaliza.Text = "colAnaliza"
        Me.colAnaliza.Weight = 0.32307698375093596R
        '
        'colPlan
        '
        Me.colPlan.Name = "colPlan"
        Me.colPlan.Text = "colPlan"
        Me.colPlan.Weight = 0.32307698375093585R
        '
        'colDemo
        '
        Me.colDemo.Name = "colDemo"
        Me.colDemo.Text = "colDemo"
        Me.colDemo.Weight = 0.32307698375093596R
        '
        'colTest
        '
        Me.colTest.Name = "colTest"
        Me.colTest.Text = "colTest"
        Me.colTest.Weight = 0.32307698375093596R
        '
        'colImplement
        '
        Me.colImplement.Name = "colImplement"
        Me.colImplement.Text = "colImplement"
        Me.colImplement.Weight = 0.32307698375093591R
        '
        'colVoditelj
        '
        Me.colVoditelj.Name = "colVoditelj"
        Me.colVoditelj.Text = "colVoditelj"
        Me.colVoditelj.Weight = 0.36780117193156031R
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 8.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'repMain
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(100, 99, 100, 8)
        Me.Version = "10.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents colNaziv As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colAnaliza As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colTest As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colPrioritet As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colPlan As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colDemo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colID As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colImplement As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colVoditelj As DevExpress.XtraReports.UI.XRTableCell
End Class
