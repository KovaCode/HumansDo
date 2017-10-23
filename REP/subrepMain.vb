Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class subrepMain
    Dim id As Integer

    Private Sub xrSubreport1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles XrSubreport1.BeforePrint
        'CType((CType(sender, XRSubreport)).ReportSource, repMain).colID.Text = Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
        id = CType((CType(sender, XRSubreport)).ReportSource, repMain).Report.GetCurrentColumnValue(0)    '''= Convert.ToInt32(GetCurrentColumnValue("CategoryID"))
        Dim report As New subrepMain

        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        'DA = New SqlDataAdapter("select *,dbo.getPrioritet(prioritet)sPrioritet,(dbo.getOsoba(voditelj))as sVoditelj from zadaci", gCN)
        DA = New SqlDataAdapter("select * from zadaci where id=" + id.ToString, gCN)
        DA.Fill(DS, "repSubreport")

        ' Bind the report to data.
        report.DataSource = DS.Tables("repSubreport")
        report.DataAdapter = DA
        report.DataMember = "repSubreport"

        With report
            .colID.DataBindings.Add("Text", DS, "id")
            .colZadatakNaziv.DataBindings.Add("Text", DS, "naziv")
        End With

    End Sub
End Class