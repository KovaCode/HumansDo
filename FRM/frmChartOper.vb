
#Region "imports"
Imports DevExpress.XtraCharts
Imports System.Data.SqlClient
#End Region

Public Class frmChartPRO

#Region "Dim's"
    Dim iZadatak As Integer
    Dim iParam As Object
    Dim naslov As String
    Dim forma As String
    Dim chart As New ChartControl()
    'Dim DoughnutChart As New ChartControl()
#End Region


    Public Sub New(Optional frm As String = "frmSatnica", Optional param As Object = "")
        InitializeComponent()

        forma = frm

        Me.iParam = param
        Me.Text = gAPPNAME.ToString + " (" + gAPPVER.ToString + ") - " + rm.GetString("tabGraph")
    End Sub


#Region "Init Form"
    'Public Sub New(izadatak As Integer, Optional snaslov As String = "Pregled faze razvoja projekta (%)")
    '    InitializeComponent()

    '    Me.naslov = rm.GetString("frmChartOper")
    '    Me.iZadatak = izadatak
    '    Me.Text = gAPPNAME.ToString + " (" + gAPPVER.ToString + ") - " + rm.GetString("tabGraph")
    'End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Select Case forma
            Case "frmSatnica"
                Me.naslov = rm.GetString(forma)
                createChartSatnica(iParam)


            Case "frmProjekt"
                Me.naslov = rm.GetString(forma)
                createChartProjekti(iParam)

        End Select



    End Sub
#End Region


#Region "procedure i funkcije"
    Private Sub createChartProjekti(ByVal id As Integer, Optional ByVal naslov As String = "")
        Dim DS As New DataSet

        Dim DA As New SqlDataAdapter("Select naziv,timeAnaliza, timePlan,timeDemo,timetest,timeImplement from projekti where id = " + id.ToString, gCN)
        DA.Fill(DS, "chartPRO")
        ' Create a doughnut series.
        Dim series1 As New Series("Series 1", ViewType.Doughnut)

        ' Add points to them
        series1.Points.Add(New SeriesPoint(rm.GetString("Analiza"), DS.Tables("chartPRO").Rows(0)("timeAnaliza").totalMinutes))
        series1.Points.Add(New SeriesPoint(rm.GetString("Plan"), DS.Tables("chartPRO").Rows(0)("timePlan").totalMinutes))
        series1.Points.Add(New SeriesPoint(rm.GetString("Demo"), DS.Tables("chartPRO").Rows(0)("timeDemo").totalMinutes))
        series1.Points.Add(New SeriesPoint(rm.GetString("Test"), DS.Tables("chartPRO").Rows(0)("timetest").totalMinutes))
        series1.Points.Add(New SeriesPoint(rm.GetString("Implement"), DS.Tables("chartPRO").Rows(0)("timeImplement").totalMinutes))

        ' Add the series to the chart.
        chart.Series.Add(series1)

        ' Adjust the value numeric options of the series.
        series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
        series1.PointOptions.ValueNumericOptions.Precision = 0

        ' Specify how series points are sorted.
        series1.SeriesPointsSorting = SortingMode.Ascending
        series1.SeriesPointsSortingKey = SeriesPointKey.Argument

        ' Specify the behavior of series labels.
        CType(series1.Label, DoughnutSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns
        CType(series1.Label, DoughnutSeriesLabel).ResolveOverlappingMode = _
            ResolveOverlappingMode.Default
        CType(series1.Label, DoughnutSeriesLabel).ResolveOverlappingMinIndent = 5
        CType(series1.PointOptions, PiePointOptions).PointView = PointView.ArgumentAndValues

        ' Adjust the view-type-specific options of the series.
        CType(series1.View, DoughnutSeriesView).ExplodedPoints.Add(series1.Points(0))
        CType(series1.View, DoughnutSeriesView).ExplodedDistancePercentage = 30

        ' Access the diagram's options.
        CType(chart.Diagram, SimpleDiagram).Dimension = 2

        ' Add a title to the chart and hide the legend.
        Dim chartTitle1 As New ChartTitle()
        chartTitle1.Text = Me.naslov + ": " + getProjekt(id).ToString
        chart.Titles.Add(chartTitle1)
        chart.Legend.Visible = True

        ' Add the chart to the form.
        chart.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(chart)
    End Sub


    Private Sub createChartSatnica(datum As DateTime, Optional naslov As String = "")
        Dim series As New Series

        ' Create a spline series.

        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim CM As New SqlCommand

        CM.CommandText = "satnica2"
        CM.Connection = gCN
        CM.CommandType = CommandType.StoredProcedure

        CM.Parameters.Add("@datum", SqlDbType.DateTime2) : CM.Parameters("@datum").Value = datum.Date

        da.SelectCommand = CM
        Try
            da.Fill(ds, "satnicaChart")
            dt = ds.Tables("satnicaChart")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim i As Integer = 0
        For Each row As DataRow In dt.Rows
            series = New Series(row("oper"), ViewType.Spline)

            For i = 1 To 30
                If row(i) <> "-" Then
                    series.Points.Add(New SeriesPoint(i, TimeSpan.Parse(ds.Tables("satnicaChart").Rows(0)(i)).TotalHours))
                End If
            Next
        Next

        chart.Series.Add(series)
        series.ArgumentScaleType = ScaleType.Numerical
        CType(series.View, SplineSeriesView).LineTensionPercent = 10

        ' Access the type-specific options of the diagram.
        CType(chart.Diagram, XYDiagram).EnableAxisXZooming = True

        ' Hide the legend (if necessary).
        chart.Legend.Visible = True

        ' Add a title to the chart (if necessary).
        chart.Titles.Add(New ChartTitle())
        chart.Titles(0).Text = Me.naslov + " (" + MonthName(datum.Month).ToUpper + " " + datum.Year.ToString + ")"

        ' Add the chart to the form.
        chart.Dock = DockStyle.Fill
        SplitContainer1.Panel1.Controls.Add(chart)
    End Sub



#End Region

    Private Sub cmdPrint_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click

        Dim frm As New frmPrint(chart)
        frm.ShowDialog(Me)

    End Sub
End Class