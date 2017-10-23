Imports System.Data.SqlClient
Imports DevExpress.XtraGrid

Public Class frmOrgJed

#Region "Dim's"
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable

    Dim idRow As Integer
    Dim idBroj As Object
#End Region


#Region "Init Form"
    Dim idSub As Object

    Public Sub New()
        InitializeComponent()
        LocalizeME()
    End Sub


    Private Sub frmOrgJed_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillGrid()
    End Sub

#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click, cmdPrint.Click, cmdOrgJedNew.Click, cmdEdit.Click
        Select Case sender.name
            Case "cmdOrgJedNew"
                Dim frm As New frmOrgJedUnos
                frm.ShowDialog(Me)
                fillGrid()

            Case "cmdEdit"
                Dim frm As New frmOrgJedUnos(idBroj)
                frm.ShowDialog(Me)
                fillGrid()

            Case "cmdExit"
                Me.Dispose()

            Case "cmdPrint"
                Dim frm As New frmPrint(grid, rm.GetString("ispisStrukture"), False)
                frm.ShowDialog(Me)

        End Select
    End Sub

    Private Sub cmdRadMjUnos_Click(sender As System.Object, e As System.EventArgs) Handles cmdRadMjUnos.Click
        Dim frm As New frmRadnoMjestoUnos(idSub)
        frm.ShowDialog(Me)
        fillGrid()
    End Sub
#End Region


#Region "grid"

    Private Sub fillGrid()
        Dim DA As New SqlDataAdapter
        Dim DA2 As New SqlDataAdapter
        Dim DA3 As New SqlDataAdapter
        Dim DS As New DataSet
        Dim keyColumn As DataColumn
        Dim foreignKeyColumn As DataColumn

        Dim keyColumn2 As DataColumn
        Dim foreignKeyColumn2 As DataColumn

        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
            DS.Tables("subGrid").Clear()
        End If

        DA = New SqlDataAdapter("select *,(select naziv from klijenti where id=orgJed.tvrtka)as sTvrtka from orgJed", gCN)
        DA2 = New SqlDataAdapter("select *,id as idSub from radnoMjesto", gCN)
        DA3 = New SqlDataAdapter("select id,(ime+' '+ prezime) as sOsoba,radnoMj,tel,email,mob, " _
                               + " (select image from images where vrsta='O' and id=operateri.slika)as imageSlika from operateri", gCN)

        DA.Fill(DS, "grid")
        DA2.Fill(DS, "subGrid")
        DA3.Fill(DS, "subGrid2")

        keyColumn = DS.Tables("grid").Columns("id")
        foreignKeyColumn = DS.Tables("subGrid").Columns("organizacija")

        keyColumn2 = DS.Tables("subGrid").Columns("idSub")
        foreignKeyColumn2 = DS.Tables("subGrid2").Columns("radnoMj")

        Try
            DS.Relations.Add("TvrtkaRad", keyColumn, foreignKeyColumn)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        Try
            DS.Relations.Add("RadOper", keyColumn2, foreignKeyColumn2)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try


        grid.DataSource = DS.Tables("grid")
        grid.ForceInitialize()

        Dim node As GridLevelNode = grid.LevelTree.Nodes.Add("TvrtkaRad", gridViewSub)
        node.LevelTemplate = gridViewSub
        grid.LevelTree.Nodes.Add(node)
        gridViewSub.OptionsPrint.UsePrintStyles = True
        gridViewSub.OptionsPrint.EnableAppearanceEvenRow = True
        gridViewSub.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        Dim node2 As GridLevelNode = grid.LevelTree.Nodes.Add("RadOper", gridViewSub2)
        node2.LevelTemplate = gridViewSub2
        node.Nodes.Add(node2)
        gridViewSub2.OptionsPrint.EnableAppearanceEvenRow = True
        gridViewSub2.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        repImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze

    End Sub


    Private Sub gridViewSub_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewSub.FocusedRowChanged
        idSub = gridViewSub.GetRowCellValue(e.FocusedRowHandle, 1)
    End Sub

    Private Sub gridView_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gridView.DoubleClick
        Dim frm As New frmOrgJedUnos(idBroj)
        frm.ShowDialog(Me)
        fillGrid()
    End Sub

    Private Sub GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        idBroj = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
        idRow = e.FocusedRowHandle
    End Sub

    Private Sub gridViewSub_DoubleClick(sender As Object, e As System.EventArgs) Handles gridViewSub.DoubleClick
        Dim frm As New frmRadnoMjestoUnos(idSub)
        frm.ShowDialog(Me)
        fillGrid()
    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Sub LocalizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        groupStructure.Text = rm.GetString("groupStructure")

        For Each CTRL In SplitContainer1.Panel2.Controls
                CTRL.text = rm.GetString(CTRL.name.ToString)
            Next CTRL

        cmdEdit.Enabled = checkSpecial(cmdEdit)
        cmdPrint.Enabled = checkSpecial(cmdPrint)

            ''grid
            For Each colS In gridView.Columns
                colS.caption = rm.GetString(colS.name.ToString)
            Next

            ''grid
            For Each colS In gridViewSub.Columns
                colS.caption = rm.GetString(colS.name.ToString)
            Next

            ''grid
            For Each colS In gridViewSub2.Columns
                colS.caption = rm.GetString(colS.name.ToString)
            Next
    End Sub
#End Region






End Class