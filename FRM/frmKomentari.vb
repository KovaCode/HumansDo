Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmKomentari

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub frmKomentari_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillgrids()
    End Sub


#Region "Click's"

    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrint.Click, cmdExit.Click, cmdExport.Click
        Select Case sender.name
            Case "cmdPrint"
                Dim frm As New frmPrint(grid, "Pregled Komentara", False)
                frm.ShowDialog(Me)

            Case "cmdExit"
                Me.Dispose()

            Case "cmdExport"


        End Select

    End Sub

#End Region


#Region "procedure i funkcije"

    Private Sub localizeSystem()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            If CTRL.HasChildren Then
                For i = 0 To CTRL.Controls.Count - 1
                    CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)
                Next
            End If
            Debug.Print(CTRL.name)
        Next CTRL


        ''grid
        For Each colS In GridView1.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid2
        For Each colS In GridView2.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid3
        For Each colS In GridView3.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

    End Sub

    Private Sub fillgrids()
        Dim DA As New SqlDataAdapter
        Dim DA2 As New SqlDataAdapter
        Dim DA3 As New SqlDataAdapter
        Dim DS As DataSet = New DataSet
        Dim DS2 As DataSet = New DataSet
        Dim keyColumn As DataColumn
        Dim foreignKeyColumn As DataColumn

        Dim keyColumn2 As DataColumn
        Dim foreignKeyColumn2 As DataColumn


        DA = New SqlDataAdapter("select id,naziv,dbo.getOsoba(voditelj)as sVoditelj from projekti", gCN)

        DA2 = New SqlDataAdapter("select id as idZAD,projekt,naziv as nazivZad, " _
                                + " (select vrijednost from prioritet where id=zadaci.prioritet)as iPrioritet, " _
                                + "dbo.getOsoba(voditelj)as sVoditelj from zadaci", gCN)

        DA3 = New SqlDataAdapter("select id,zadatak,vrijeme,projekt,dbo.getzadatak(zadatak)as sZadatak ,dbo.getOsoba(oper)Osoba, " _
                                                           + " from vezaZadOperHist", gCN)

        Try
            DA.Fill(DS, "projekt")
            DA2.Fill(DS, "zadatak")
            DA3.Fill(DS, "izvrsenja")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ''Set up a master-detail relationship between the DataTables 
        keyColumn = DS.Tables("projekt").Columns("id")
        foreignKeyColumn = DS.Tables("zadatak").Columns("projekt")

        keyColumn2 = DS.Tables("zadatak").Columns("idZAD")
        foreignKeyColumn2 = DS.Tables("izvrsenja").Columns("zadatak")

        Try
            DS.Relations.Add("Projekt-Zadatak", keyColumn, foreignKeyColumn)
            DS.Relations.Add("Zadatak-Komentar", keyColumn2, foreignKeyColumn2)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

        'Bind the grid control to the data source 
        grid.DataSource = DS.Tables("projekt")
        grid.ForceInitialize()

        Dim node As GridLevelNode = grid.LevelTree.Nodes.Add("Projekt-Zadatak", GridView2)
        node.LevelTemplate = GridView2
        grid.LevelTree.Nodes.Add(node)
        GridView2.OptionsPrint.UsePrintStyles = True
        GridView2.OptionsPrint.EnableAppearanceEvenRow = True
        GridView2.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        Dim node2 As GridLevelNode = grid.LevelTree.Nodes.Add("Zadatak-Izvrsenja", GridView3)
        node2.LevelTemplate = GridView3
        node.Nodes.Add(node2)
    End Sub

#End Region

End Class