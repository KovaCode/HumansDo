<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class repOperateri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(repOperateri))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.table = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.colID = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colOsoba = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colAdresa = New DevExpress.XtraReports.UI.XRTableCell()
        Me.colTvrtka2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.lblNaslov = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.evenRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.oddRow = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.lblGroup = New DevExpress.XtraReports.UI.XRLabel()
        Me.colOrgJed2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 40.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'table
        '
        Me.table.Dpi = 254.0!
        Me.table.EvenStyleName = "evenRow"
        Me.table.KeepTogether = True
        Me.table.LocationFloat = New DevExpress.Utils.PointFloat(24.9999905!, 0.0!)
        Me.table.Name = "table"
        Me.table.OddStyleName = "oddRow"
        Me.table.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.table.SizeF = New System.Drawing.SizeF(1476.0!, 40.0!)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.colID, Me.colOsoba, Me.colAdresa, Me.colTvrtka2, Me.colOrgJed2})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'colID
        '
        Me.colID.Dpi = 254.0!
        Me.colID.Name = "colID"
        Me.colID.Text = "colID"
        Me.colID.Weight = 0.12387656341360327R
        '
        'colOsoba
        '
        Me.colOsoba.Dpi = 254.0!
        Me.colOsoba.Name = "colOsoba"
        Me.colOsoba.Text = "colOsoba"
        Me.colOsoba.Weight = 0.57711201665609746R
        '
        'colAdresa
        '
        Me.colAdresa.Dpi = 254.0!
        Me.colAdresa.Name = "colAdresa"
        Me.colAdresa.Text = "colAdresa"
        Me.colAdresa.Weight = 0.71720099883403954R
        '
        'colTvrtka2
        '
        Me.colTvrtka2.Dpi = 254.0!
        Me.colTvrtka2.EvenStyleName = "evenRow"
        Me.colTvrtka2.Name = "colTvrtka2"
        Me.colTvrtka2.OddStyleName = "oddRow"
        Me.colTvrtka2.Text = "colTvrtka2"
        Me.colTvrtka2.Weight = 0.65462458986533256R
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.lblNaslov, Me.XrPictureBox1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 409.998291!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblNaslov
        '
        Me.lblNaslov.Dpi = 254.0!
        Me.lblNaslov.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNaslov.LocationFloat = New DevExpress.Utils.PointFloat(320.286011!, 141.181702!)
        Me.lblNaslov.Name = "lblNaslov"
        Me.lblNaslov.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblNaslov.SizeF = New System.Drawing.SizeF(903.60498!, 58.4199982!)
        Me.lblNaslov.StylePriority.UseFont = False
        Me.lblNaslov.Text = "Pregled operatera"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Dpi = 254.0!
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(55.7712212!, 80.2216873!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(249.131699!, 228.176697!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel4.BorderWidth = 2
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(795.91333!, 368.723297!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(350.825592!, 41.2750206!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseBorderWidth = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Tvrtka"
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.BorderWidth = 2
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(394.437805!, 368.723297!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(398.039612!, 41.2750206!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseBorderWidth = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "Adresa"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.BorderWidth = 2
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(82.1237793!, 368.723297!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(312.314087!, 41.2750206!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseBorderWidth = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Osoba" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.BorderWidth = 2
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(15.0859699!, 368.723297!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(67.0379181!, 41.2750206!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "ID"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo3, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo3
        '
        Me.XrPageInfo3.Dpi = 254.0!
        Me.XrPageInfo3.ForeColor = System.Drawing.Color.Silver
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(608.158325!, 24.9999905!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.UserName
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(436.347992!, 58.4199791!)
        Me.XrPageInfo3.StylePriority.UseForeColor = False
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Dpi = 254.0!
        Me.XrPageInfo2.ForeColor = System.Drawing.Color.Silver
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(1431.25305!, 3.547225!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(71.6519775!, 58.4199791!)
        Me.XrPageInfo2.StylePriority.UseForeColor = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.ForeColor = System.Drawing.Color.Silver
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(27.3049603!, 24.9999905!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(277.597992!, 58.4199791!)
        Me.XrPageInfo1.StylePriority.UseForeColor = False
        '
        'evenRow
        '
        Me.evenRow.BackColor = System.Drawing.Color.WhiteSmoke
        Me.evenRow.Name = "evenRow"
        '
        'oddRow
        '
        Me.oddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.oddRow.Name = "oddRow"
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lblGroup})
        Me.GroupHeader1.Dpi = 254.0!
        Me.GroupHeader1.HeightF = 100.541702!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'lblGroup
        '
        Me.lblGroup.BorderColor = System.Drawing.Color.Transparent
        Me.lblGroup.Dpi = 254.0!
        Me.lblGroup.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblGroup.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.0000095!)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.lblGroup.SizeF = New System.Drawing.SizeF(1491.08606!, 58.4199982!)
        Me.lblGroup.StylePriority.UseBorderColor = False
        Me.lblGroup.StylePriority.UseForeColor = False
        Me.lblGroup.Text = "lblGroup"
        '
        'colOrgJed2
        '
        Me.colOrgJed2.Dpi = 254.0!
        Me.colOrgJed2.Name = "colOrgJed2"
        Me.colOrgJed2.Text = "colOrgJed2"
        Me.colOrgJed2.Weight = 0.65462458986533256R
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel5.BorderWidth = 2
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1146.73901!, 368.723297!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(350.825592!, 41.2750206!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseBorderWidth = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Org.jed"
        '
        'repOperateri
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.Dpi = 254.0!
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(315, 318, 410, 100)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 31.75!
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.evenRow, Me.oddRow})
        Me.Version = "10.2"
        CType(Me.table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents table As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents colID As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colOsoba As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colAdresa As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents evenRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents oddRow As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents colTvrtka2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblNaslov As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents lblGroup As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents colOrgJed2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class
