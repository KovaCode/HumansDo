#Region "Imports"
Imports System.Data.SqlClient
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraGrid
#End Region

Public Class frmIzvrsenjaPreg

#Region "Dim's"
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder
#End Region


#Region "Init Form"
    Public Sub New()
        InitializeComponent()
        localizeSystem()

        CN = New SqlConnection(gDATABASE)
        CN.Open()
    End Sub

    Private Sub frmIzvrsenjaPreg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillGrid()
    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdPrint.Click
        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdPrint"
                Dim frm As New frmPrint(grid, rm.GetString("pregledTrenutno") + Now.ToShortDateString + ", " + Now.ToShortTimeString, True)
                frm.Show()
        End Select
        Me.Dispose()
    End Sub
#End Region


#Region "grid"

    Private Sub fillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select dbo.getTimeDiffSec(DATEDIFF(SECOND,vrijemeOD,GETDATE()))vrijemeRad, " _
                                + "opis,dbo.getZadatak(zadatak)sZadatak, dbo.getProjekt(dbo.getZad2Projekt(zadatak))sProjekt, " _
                                + " dbo.getOsoba(operater)oper,posto,detOpis " _
                                + " from izvrsenja where stanje =3", gCN)
        DA.Fill(DS, "grid")

        lblUkupno.Text = DS.Tables("grid").Rows.Count.ToString

        grid.DataSource = DS.Tables("grid")

        gridView.OptionsPrint.UsePrintStyles = True
        gridView.OptionsPrint.EnableAppearanceEvenRow = True
        gridView.AppearancePrint.EvenRow.BackColor = Color.LightYellow
    End Sub

    Private Sub gridView_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView.PopupMenuShowing
        Dim View As Views.Grid.GridView = CType(sender, Views.Grid.GridView)

        If e.HitInfo.InRow Then
            rightClickMenu.Show(View.GridControl, e.Point)

        End If
    End Sub

    Private Sub rightClickMenu_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles rightClickMenu.ItemClicked
        Select Case e.ClickedItem.ToString
            Case "Pregled ispisa"
                If sender.sourceControl.name.ToString = "grid" Then
                    Dim frm As New frmPrint(grid, rm.GetString("pregledZadatka") + Now.ToShortDateString, True)
                    frm.Show()
                End If


        End Select
    End Sub

    Private Sub toolExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolXLS.Click, toolXLSX.Click, toolPDF.Click, toolHTML.Click, toolRTF.Click
        Select Case sender.name.ToString
            Case "toolXLS"
                CreateXLS(gridView)
            Case "toolXLSX"
                CreateXLSX(gridView)
            Case "toolPDF"
                createPDF(gridView)
            Case "toolHTML"
                createHTML(gridView)
            Case "toolRTF"
                createRTF(gridView)
        End Select
    End Sub
#End Region


#Region "procedure i funkcije"
    Private Sub localizeSystem()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.enabled = checkSpecial(CTRL)
            If CTRL.HasChildren Then
                For i = 0 To CTRL.Controls.Count - 1
                    CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)
                    CTRL.Controls(i).enabled = checkSpecial(CTRL.Controls(i))
                    If CTRL.Controls(i).HasChildren Then
                        For j = 0 To CTRL.Controls(i).Controls.Count - 1
                            CTRL.Controls(i).controls(j).Text = rm.GetString(CTRL.Controls(i).Controls(j).name.ToString)
                            CTRL.Controls(i).controls(j).enabled() = checkSpecial(CTRL.Controls(i).controls(j))
                        Next
                    End If
                Next
            End If
            Debug.Print(CTRL.name)
        Next CTRL


        ''grid
        For Each colS In gridView.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        'lblTotal.Text = rm.GetString("lblTotal")
    End Sub
#End Region


End Class