
#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class frmOperWorkToday

#Region "Dim's"
    Dim iOper As Integer
#End Region


#Region "Init form"

    Public Sub New()
        InitializeComponent()
        localizeME()
    End Sub

    Private Sub frmSatnica_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        fillCMBOperater()

        dtp.DateTime = Now
        fillGrid(dtp.DateTime.Date)
    End Sub
#End Region


#Region "Click's"

    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click, cmdPrint.Click, cmdPreview.Click
        Select Case sender.name
            Case "cmdPreview"
                fillGrid(dtp.DateTime)

            Case "cmdExit"
                Me.Dispose()

            Case "cmdPrint"
                Dim frm As New frmPrint(grid, "Pregled dnevno obavljenog posla operatera " + gOperater.ToString, True)
                frm.ShowDialog(Me)

        End Select
    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Function fillGrid(datum As Date)
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        da = New SqlDataAdapter("select id,zadatak,dbo.getZadatak(zadatak)sZadatak,opis,detOpis,operater, " _
                            + " dbo.getProjekt(dbo.getZad2Projekt(zadatak)) sProjekt, " _
                            + " dbo.getstatus(dbo.getStatusZadOp(zadatak," + iOper.ToString + "))statusZad, " _
                            + " vrijemeOD,vrijemeDO,posto,vrijemeRad, " _
                            + " dbo.getTimeDiffSEC2((select sum(vrimSec) from izvrsenja where vrijemeOD between convert(date,'" + SQLDate(datum) + "') and    " _
                            + " DATEADD(day,+1,CONVERT(date,'" + SQLDate(datum) + "'))and operater =" + iOper.ToString + "))ukupSec   " _
                            + " from izvrsenja  where  " _
                            + " vrijemeOD between convert(date,'" + SQLDate(datum) + "') and DateAdd(Day, +1, Convert(Date, '" + SQLDate(datum) + "')) " _
                            + " and operater = " + iOper.ToString + "", gCN)


        da.Fill(ds, "todayWork")

        lblCount.Text = ds.Tables("todayWork").Rows.Count
        If ds.Tables("todayWork").Rows.Count > 0 Then
            lblCountTime.Text = iNullTime(ds.Tables("todayWork").Rows(0)("ukupSec"))
        Else
            lblCountTime.Text = "0:00:00"
        End If

        grid.DataSource = ds.Tables("todayWork")
    End Function

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        cmdPreview.Text = rm.GetString("cmdPreview")
        lblDatum.Text = rm.GetString("lblDatum")
        lblUkupno.Text = rm.GetString("lblUkupno")
        cmdPrint.Text = rm.GetString("cmdPrint")
        cmdExit.Text = rm.GetString("cmdExit")


        ''grid
        For Each colS In gridView.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

    End Sub

#End Region


#Region "Combo-si"

    Private Sub fillCMBOperater()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select id,dbo.getOsoba(id)as naziv from operateri order by prezime", gDATABASE)
        DA.Fill(DS, "projekt")

        DT = DS.Tables("projekt")
        DA.Dispose()

        cmbOper.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbOper.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next
        cmbOper.SelectedIndex = 0

        DS.Tables("projekt").Reset()


    End Sub

    Private Sub cmbOper_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOper.SelectedIndexChanged
        'If cmbOper.SelectedIndex > -1 Then
        iOper = CType(cmbOper.Properties.Items(cmbOper.SelectedIndex()), cmbVal).Value
        'End If
    End Sub
#End Region




End Class