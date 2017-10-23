#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class frmNatjecaji

#Region "Dim's"
    Dim idBroj As Object
#End Region


#Region "Init form"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmNatjecaji_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillGrid()
    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click, cmdExit.Click, cmdNew.Click, cmdPrint.Click
        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdNew"
                Dim frm As New frmNatjecajiU
                frm.ShowDialog(Me)

            Case "cmdEdit"
                Dim frm As New frmNatjecajiU(idBroj)
                frm.ShowDialog(Me)

            Case "cmdPrint"


        End Select
    End Sub
#End Region


#Region "grid"

    Private Sub fillGrid()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select * , " _
                                + " (select naziv from radnoMjesto where id=natjecaji.radnoMj)as radMjesto, " _
                                + " (select naziv from orgjed where id=natjecaji.orgjed)as odjel, " _
                                + " (select naziv from vrstaZaposlenja where id=natjecaji.vrstaZaposl)as vrstaZaposlenja, " _
                                + " cast (status as bit)as status  " _
                                + " from natjecaji", gCN)
        DA.Fill(DS, "grid")

        grid.DataSource = DS.Tables("grid")
        gridView.MoveBy(1)
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        idBroj = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
    End Sub

#End Region


#Region "Procedure i funkcije"

#End Region



End Class