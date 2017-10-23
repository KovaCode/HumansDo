
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Public Class frmOperStat
    Dim chart As New ChartControl()
    Dim chart2 As New ChartControl()
    'Dim chartControl1 As New ChartControl()

    Dim iOper As Integer
    Dim iZadatak As Integer

    Dim DS As New DataSet
    Dim DA As New SqlDataAdapter

    Dim DS2 As New DataSet
    Dim DA2 As New SqlDataAdapter

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        fillGrid()
        createChart()
    End Sub


    Private Sub fillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select voditelj,naziv,dbo.getOsoba(voditelj)Osoba from projekti", gDATABASE)
        DA.Fill(DS, "grid")

        grid.DataSource = DS.Tables("grid")
        gridView.MoveBy(1)
    End Sub

    Private Sub fillGrid2(oper As Integer)
        If iOper > 0 Then
            If DS2.Tables.IndexOf("grid2") > -1 Then
                DS2.Tables("grid2").Clear()
            End If

            DA2 = New SqlDataAdapter("exec dbo.statistikaOper " + oper.ToString, gCN)
            DA2.Fill(DS2, "grid2")

            grid2.DataSource = DS2.Tables("grid2")
            GridView2.SetRowExpanded(-1, True)
            GridView2.SetRowExpanded(-2, True)
            GridView2.MoveBy(1)
        End If
    End Sub


    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        iOper = gridView.GetRowCellValue(e.FocusedRowHandle, colVoditeljID)
        createChart()
        fillGrid2(iOper)
    End Sub

    Private Sub gridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        iZadatak = GridView2.GetRowCellValue(e.FocusedRowHandle, colID2)

        If iZadatak > 0 Then
            createMultipleCharts()
        End If
    End Sub

    Private Sub gridView2_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView2.RowCellStyle
        Dim sVal As Integer

        If e.Column.Name = "colPositive" Then

            sVal = CType(GridView2.GetRowCellValue(e.RowHandle, e.Column), Integer)

            If sVal = 0 Then
                e.Appearance.BackColor = Color.PaleVioletRed
            Else
                'e.Appearance.BackColor = Color.LawnGreen
            End If

            '    Select Case sVal
            '        Case "Završeno"
            '            e.Appearance.Options.UseFont = FontStyle.Strikeout
            '            e.Appearance.ForeColor = Color.Gray

            '            '        Case "Srednja važnost"
            '            '            e.Appearance.BackColor = Color.Orange
            '            '            e.Appearance.ForeColor = Color.Black

            '            '        Case "Razmotriti"
            '            '            e.Appearance.BackColor = Color.Green
            '            '            e.Appearance.ForeColor = Color.Black
            '    End Select
        End If
        ' ''End If
    End Sub


    Private Sub createChart()
        Dim DT As New DataTable
        Dim DS As New DataSet
        Dim DA As New SqlDataAdapter

        If IsNothing(chart) = False Then
            chart.Dispose()
        End If
        chart = New ChartControl()

        ' Create two area series.
        Dim series1 As New Series("Series 1", ViewType.Area)
        Dim series2 As New Series("Series 2", ViewType.Area)


        DA = New SqlDataAdapter("exec dbo.statistikaOper 37", gCN)
        DA.Fill(DS, "chart2")
        DT = DS.Tables("chart2")


        ' Add points to them.
        If series1.Points.Count = 1 Then
            series1.Points.RemoveAt(0)
            series1.Points.RemoveAt(0)
            series1.ResetLegendPointOptions()
            series1.ResetLegendPointOptions()
        End If


        For Each row As DataRow In DT.Rows
            series1.Points.Add(New SeriesPoint(row("zadatak"), TimeSpan.Parse(row("planirano")).TotalHours))
            series2.Points.Add(New SeriesPoint(row("zadatak"), TimeSpan.Parse(row("realno")).TotalHours))
        Next


        series1.Label.Visible = False
        series2.Label.Visible = False

        ' Add both series to the chart.
        chart.Series.AddRange(New Series() {series1, series2})

        ' Set the numerical argument scale types for the series,
        ' as it is qualitative, by default.


        series1.ArgumentScaleType = ScaleType.Qualitative
        series1.LegendText = "Planirano"
        series2.ArgumentScaleType = ScaleType.Qualitative
        series2.LegendText = "Napravljeno"


        series1.View.Color = Color.LightGreen
        series2.View.Color = Color.Red

        ' Access the view-type-specific options of the series.
        CType(series1.View, AreaSeriesView).Transparency = 150
        CType(series2.View, AreaSeriesView).Transparency = 150

        ' Access the type-specific options of the diagram.
        CType(chart.Diagram, XYDiagram).EnableAxisXZooming = True

        ' Hide the legend (optional).
        chart.Legend.Visible = True

        ' Add the chart to the form.
        chart.Dock = DockStyle.Fill

        tabChart1.Controls.Remove(chart)
        tabChart1.Controls.Add(chart)
        DA.Dispose() : DS.Dispose() : DT.Dispose()


    End Sub


    Private Sub createMultipleCharts()
        Dim DTC As New DataTable
        Dim DSC As New DataSet
        Dim DAC As New SqlDataAdapter

        If IsNothing(chart2) = False Then
            chart2.Dispose()
        End If
        chart2 = New ChartControl

        ' Create two series.
        Dim series1 As New Series("Series 1", ViewType.Bar)
        Dim series2 As New Series("Series 2", ViewType.Line)

        If series1.Points.Count = 1 Then
            series1.Points.RemoveAt(0)
            series1.Points.RemoveAt(0)
            series1.ResetLegendPointOptions()
            series1.ResetLegendPointOptions()
        End If

        DAC = New SqlDataAdapter("select * from izvrsenja where zadatak=" + iZadatak.ToString + " and stanje =100 and opis<>'' ", gCN)
        DAC.Fill(DSC, "chart")
        DTC = DSC.Tables("chart")

        For Each row As DataRow In DTC.Rows
            series1.Points.Add(New SeriesPoint(iNull(row("opis")), row("vrimSec")))
        Next


        series2.Points.Add(New SeriesPoint("I", 2500))
        series2.Points.Add(New SeriesPoint("II", 3800))
        series2.Points.Add(New SeriesPoint("III", 1500))
        series2.Points.Add(New SeriesPoint("IV", 1300))

        ' Add both series to the chart.
        chart2.Series.AddRange(New Series() {series1, series2})

        series1.Label.Visible = False
        series2.Label.Visible = False

        ' Hide the legend (optional).
        chart2.Legend.Visible = False

        ' Cast the chart's diagram to the XYDiagram type, 
        ' to access its axes and panes.
        Dim diagram As XYDiagram = CType(chart2.Diagram, XYDiagram)

        ' Add secondary axes to the diagram, and adjust their options.
        diagram.SecondaryAxesX.Add(New SecondaryAxisX("My Axis X"))
        diagram.SecondaryAxesY.Add(New SecondaryAxisY("My Axis Y"))
        diagram.SecondaryAxesX(0).Alignment = AxisAlignment.Near
        diagram.SecondaryAxesY(0).Alignment = AxisAlignment.Near

        ' Add a new additional pane to the diagram.
        diagram.Panes.Add(New XYDiagramPane("My Pane"))

        ' Assign both the additional pane and, if required,
        ' the secondary axes to the second series. 
        Dim myView As LineSeriesView = CType(series2.View, LineSeriesView)
        myView.AxisX = diagram.SecondaryAxesX(0)
        myView.AxisY = diagram.SecondaryAxesY(0)
        ' Note that the created pane has the zero index in the collection,
        ' because the existing Default pane is a separate entity.
        myView.Pane = diagram.Panes(0)

        ' Customize the layout of the diagram's panes.
        diagram.PaneDistance = 10
        diagram.PaneLayoutDirection = PaneLayoutDirection.Horizontal
        diagram.DefaultPane.SizeMode = PaneSizeMode.UseWeight
        diagram.DefaultPane.Weight = 1.2


        ' Add the chart to the form.
        chart2.Dock = DockStyle.Fill

        tabChart2.Controls.Remove(chart2)
        tabChart2.Controls.Add(chart2)
        DAC.Dispose() : DSC.Dispose() : DTC.Dispose()
    End Sub

End Class