Imports System.Data.SqlClient
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Public Class frmHelpdesk

    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder
    Dim idTree As Integer
    Dim iID As Integer
    Dim iRow As Integer


    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        CN = New SqlConnection(gDATABASE)
        CN.Open()
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub frmHelpdesk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - Ticketing Sustav / Helpdesk"

        FillGrid()
    End Sub

    Private Sub grid_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
        iRow = e.FocusedRowHandle
    End Sub


    Private Sub FillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select * from helpdesk", gDATABASE)
        DA.Fill(DS, "grid")

        grid.DataSource = DS.Tables("grid")
    End Sub


End Class