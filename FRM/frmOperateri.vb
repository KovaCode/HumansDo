#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Mask

#End Region

Public Class frmOperateri

#Region "Dim's"
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder
    Dim iID As Long
    Dim iRow As Integer
    Dim ItemSelected As Integer
    Dim iOrgJed As Integer
    Dim iRadMj As Integer
    Dim iPrava As String
    Dim iZupanija As Integer
    Dim iMjesto As Long
    Dim iSpol As Integer = 1
    Dim A As Integer
    Dim R As Integer
    Dim G As Integer
    Dim B As Integer
    Dim picID As Long
    Dim picFileName As String
    Dim iAktivno As Boolean = True
    Dim flgNew As Boolean = False
    Dim flgChange As Boolean = False
    Dim iTvrtka As Integer
    Dim iUlica As Integer
#End Region


#Region "Init Form"

    Public Sub New()
        InitializeComponent()
        localizeME()
    End Sub

    Private Sub frmOper_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CN = New SqlConnection(gDATABASE)
        CN.Open()

        setTxtMasks()

        fillgridTvrtka()
        fillgridZupanija()
        FillGrid()
        fillTrack()
    End Sub
#End Region


#Region "Click's"

    Private Sub cmd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click, cmdNew.Click, btnPictrue.Click, cmdSave.Click, cmdPrint.Click
        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdNew"
                Novo()

            Case "cmdDelete"



            Case "btnPicture"
                If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                    CheckOperPic()
                    picFileName = Me.OpenFileDialog1.FileName
                    picID = saveFileSQL(OpenFileDialog1.FileName, iID, "O")
                    DA.UpdateCommand = CN.CreateCommand()
                    DA.UpdateCommand.CommandText = "update operateri set slika=" + picID.ToString + " where id=" + iID.ToString
                    DA.UpdateCommand.ExecuteNonQuery()
                End If

            Case "cmdSave"
                If checkGridValues() = True Then
                    iUlica = checkNewUlica()
                    If iUlica > 0 Then
                        Spremi(iID)
                        flgChange = False
                        cmdSave.Enabled = False
                        FillGrid()
                        fillgrid2(iID)
                    Else
                        alerter.SHOW(alerter.icona.zabrana, alerter.naslov.Spremanje, "Korisnik je odustao od unosa ulice!|Pokušajte odabrati postojeću ulicu!")
                    End If
                End If

            Case "cmdPrint"
                If IsNothing(grid2.Rows(0).ChildRows(0).Properties.Value) = False Then
                    Dim osoba As String = grid2.Rows(0).ChildRows(0).Properties.Value + " " + grid2.Rows(0).ChildRows(1).Properties.Value
                    Dim frm As New frmPrint(grid2, "Ispis podataka o operateru " + osoba.ToString, False)
                    frm.ShowDialog(Me)
                End If


        End Select

    End Sub



    Private Sub cmdPrilog_Click(sender As Object, e As System.EventArgs) Handles cmdPrilog.Click
        Dim frm As New frmFiles(iID, "O")
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnPictrue_Click(sender As Object, e As System.EventArgs) Handles btnPictrue.Click
        If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            CheckOperPic()
            picFileName = Me.OpenFileDialog1.FileName
            picID = saveFileSQL(OpenFileDialog1.FileName, iID, "O")
            DA.UpdateCommand = CN.CreateCommand()
            DA.UpdateCommand.CommandText = "update operateri set slika=" + picID.ToString + " where id=" + iID.ToString
            DA.UpdateCommand.ExecuteNonQuery()

            colPicture.Value = getPicDB(picID)
            pic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        End If

    End Sub

    Private Sub cmdTvrtka_Click(sender As Object, e As System.EventArgs) Handles cmdTvrtka.Click
        Dim frm As New frmClients
        frm.ShowDialog(Me)
        fillgridTvrtka()
    End Sub

    Private Sub cmdOrgJed_Click(sender As Object, e As System.EventArgs) Handles cmdOrgJed.Click
        Dim frm As New frmOrgJed
        frm.ShowDialog(Me)
        fillgridOrgJed(iTvrtka)
    End Sub

    Private Sub cmdRadMjesto_Click(sender As Object, e As System.EventArgs) Handles cmdRadMjesto.Click
        Dim frm As New frmRadnoMjestoUnos
        frm.ShowDialog(Me)
        fillgridRadMj(iTvrtka)
    End Sub


    Private Sub cmdObrazovanje_Click(sender As Object, e As System.EventArgs) Handles cmdObrazovanje.Click
        Dim frm As New frmObrazovanje(iID)
        frm.ShowDialog(Me)
    End Sub

#End Region


#Region "combo-si"

    'Private Sub fillcmbOrgJedinica(tvrtka As Integer)
    '    Dim DA As New SqlDataAdapter
    '    Dim DS As New DataSet
    '    Dim DT As New DataTable

    '    DA = New SqlDataAdapter("select id,naziv from orgjed where tvrtka=" + tvrtka.ToString + " order by naziv", gDATABASE)
    '    DA.Fill(DS, "orgJed")

    '    DT = DS.Tables("orgJed")
    '    DA.Dispose()

    '    cmbOrgJedinica.Items.Clear()
    '    cmbOrgJedinica.Items.Add("")
    '    For Each row As DataRow In DT.Rows
    '        cmbOrgJedinica.Items.Add(New cmbVal(row("id"), row("naziv")))
    '    Next

    '    DS.Tables("orgJed").Reset()
    'End Sub

    'Private Sub cmbOrgJedinica_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If IsNothing(sender.selectedindex) = False And sender.selectedindex > 0 Then
    '        iOrgJed = CType(cmbOrgJedinica.Items(sender.selectedindex), cmbVal).Value
    '    End If

    '    fillgridRadMj(iOrgJed)
    'End Sub


    Private Sub fillcmbUlice(mjesto As Integer)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select br as id,naziv from ulice where mjesto=" + mjesto.ToString + " order by naziv", gDATABASE)
        DA.Fill(DS, "ulice")

        DT = DS.Tables("ulice")
        DA.Dispose()

        cmbAdresa.Items.Clear()
        cmbAdresa.Items.Add("")

        For Each row As DataRow In DT.Rows
            cmbAdresa.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next

        DA.Dispose() : DS.Dispose() : DT.Dispose()
    End Sub

    Private Sub cmbAdresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAdresa.SelectedIndexChanged
        If IsNothing(sender.selectedindex) = False And sender.selectedindex > 0 Then
            iUlica = CType(cmbAdresa.Items(sender.selectedindex), cmbVal).Value
        End If
    End Sub
#End Region


#Region "grid"
    Private Sub FillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select id, ime, prezime,orgjed,(select naziv from radnoMjesto where id=operateri.RadnoMj)sRadnoMj, " _
                              + " (select naziv from klijenti where id=operateri.tvrtka)sTvrtka, " _
                              + " (select naziv from vrste where tip=2 and tezina=operateri.prava)sPrava from operateri", gDATABASE)
        DA.Fill(DS, "grid")

        grid.DataSource = DS.Tables("grid")
        gridView.SetRowExpanded(-1, True)
        gridView.SetRowExpanded(-2, True)
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
        iRow = e.FocusedRowHandle

        rowPrilog.Properties.Value = rm.GetString("UkupnoDokumenata") + checkDocCount(iID, "O").ToString
        fillgrid2(iID)
    End Sub

    'Private Sub grid_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridView.RowClick
    '    colOrgJed.Value = gridOrgJed.GetDisplayValue(e.RowHandle)("naziv").ToString
    '    iOrgJed = gridOrgJed.GetDisplayValue(e.RowHandle)("ID")

    '    fillgridRadMj(iOrgJed)
    'End Sub

    Private Sub gridView_BeforeLeaveRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles gridView.BeforeLeaveRow
        If flgChange = True Then
            Select Case alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, "Podaci su izmjenjeni!|Želite li ih spremiti?", alerter.button.DaNeOdustani)
                Case 0
                    If checkGridValues() = True Then
                        Spremi(iID)
                        grid.Refresh()
                    End If
                    flgChange = False
                    cmdSave.Enabled = False

                Case 1
                    flgChange = False
                    cmdSave.Enabled = False

                Case 2
                    e.Allow = False
            End Select
        End If
    End Sub

    Private Sub rightClickMenu_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles rightClickMenu.ItemClicked
        Select Case e.ClickedItem.ToString
            Case "Ispis"
                If sender.sourceControl.name.ToString = "grid" Then
                    Dim frm As New frmPrint(grid, "Pregled zadataka na projektu  na " + Now.ToShortDateString, True)
                    frm.Show()
                Else
                    'Dim frm As New frmPrint(grid2, "Pregled podataka osobe " + gridOrgJed.GetDisplayValue(e.RowHandle)("naziv").ToString + " na " + Now.ToShortDateString.ToString, False)
                    'frm.Show()
                End If

            Case "Izvoz"


        End Select
    End Sub

    Private Sub toolExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolXLS.Click, toolXLSX.Click, toolPDF.Click, toolHTML.Click, toolRTF.Click
        Select Case sender.name.ToString
            Case "toolXLS"
                CreateXLS(grid)
            Case "toolXLSX"
                CreateXLSX(grid)
            Case "toolPDF"
                createPDF(grid)
            Case "toolHTML"
                createHTML(grid)
            Case "toolRTF"
                createRTF(grid)
        End Select
    End Sub

#End Region


#Region "grid2"
    Private Sub fillgrid2(ByVal id As Integer)
        clearWarnings()

        If DS.Tables.IndexOf("grid2") > -1 Then
            DS.Tables("grid2").Clear()
        End If

        DA = New SqlDataAdapter("select *, " _
                                + "(select naziv from zupanije where sifra=operateri.zupanija)sZupanija, " _
                                + " dbo.getMjesto(mjesto)as sMjesto, " _
                                + " dbo.getUlica(adresa)as sUlica, " _
                                + "(select naziv from orgjed where id=operateri.orgjed)sOrgJed, " _
                                + "(select sifra from orgjed where id=operateri.orgjed)sifraOrgJed, " _
                                + "(select naziv from vrste where tip=2 and tezina=operateri.prava)sPrava, " _
                                + "(select naziv from klijenti where id=tvrtka)sTvrtka, " _
                                + "(select naziv from radnomjesto where id=operateri.RadnoMj)sRadMj  " _
                                + "from operateri where id=" + id.ToString, gDATABASE)
        Try
            DA.Fill(DS, "grid2")
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message)
        End Try

        If DS.Tables("grid2").Rows.Count > 0 Then
            With DS.Tables("grid2")
                grid2.Rows("rowIme").Properties.Value = .Rows(0)("ime").ToString
                grid2.Rows("rowPrezime").Properties.Value = .Rows(0)("prezime").ToString
                grid2.Rows("rowBirthDay").Properties.Value = .Rows(0)("datumRodj")
                iZupanija = isNull(.Rows(0)("zupanija"), -1)
                fillGridMjesto(iZupanija)

                grid2.Rows("rowJMBG").Properties.Value = .Rows(0)("JMBG")
                grid2.Rows("rowOIB").Properties.Value = .Rows(0)("OIB")

                grid2.Rows("rowZupa").Properties.Value = .Rows(0)("szupanija").ToString
                iMjesto = isNull(.Rows(0)("mjesto"), -1)
                'fillcmbUlice(iMjesto)

                colMjestoNaziv.Value = .Rows(0)("sMjesto").ToString
                colPtt.Value = .Rows(0)("ptt").ToString


                colAdresa.Value = .Rows(0)("sUlica").ToString
                colKucaBr.Value = .Rows(0)("kucniBr").ToString
                If (isNull(.Rows(0)("spol"), 0)) = False Then
                    optSpol.Items(0).Value = True
                    optSpol.Items(1).Value = False
                Else
                    optSpol.Items(0).Value = False
                    optSpol.Items(1).Value = True
                End If
                iTvrtka = .Rows(0)("tvrtka")
                'grid2.Rows("rowTvrtka").Properties.Value = .Rows(0)("sTvrtka")

                fillgridRadMj(iTvrtka)
                'fillcmbOrgJedinica(iTvrtka)
                fillgridOrgJed(iTvrtka)

                rowTvrtka.Properties.Value = iNull(.Rows(0)("sTvrtka"))
                'cmbTvrtka.= 0 '.Rows(0)("sTvrtka")

                grid2.Rows("rowTelefon").Properties.Value = .Rows(0)("tel")
                grid2.Rows("rowMobitel").Properties.Value = .Rows(0)("mob")
                grid2.Rows("rowEmail").Properties.Value = .Rows(0)("email")

                iOrgJed = isNull(.Rows(0)("OrgJed"), 0)
                colOrgJed.Value = .Rows(0)("sOrgJed")



                colRadMj.Value = .Rows(0)("sRadMj")

                fillgridRadMj(iOrgJed)

                iRadMj = isNull(.Rows(0)("radnoMj"), 0)
                colPrava0.Value = .Rows(0)("sPrava")
                iPrava = isNull(.Rows(0)("prava"), 0)
                colPrava.Value = iPrava
                R = iNull0(.Rows(0)("R"))
                G = iNull0(.Rows(0)("G"))
                B = iNull0(.Rows(0)("B"))
                rowBoja.Properties.Value = Color.FromArgb(R, G, B)
                grid2.Rows("rowTelefonS").Properties.Value = .Rows(0)("tel2")
                grid2.Rows("rowMobitelS").Properties.Value = .Rows(0)("mob2")
                grid2.Rows("rowEmailS").Properties.Value = .Rows(0)("email2")
                grid2.Rows("rowUsername").Properties.Value = .Rows(0)("korisnik")
                grid2.Rows("rowPass").Properties.Value = decryptString(.Rows(0)("lozinka"))
                grid2.Rows("rowHint").Properties.Value = .Rows(0)("hint")
                grid2.Rows("rowDatumOd").Properties.Value = .Rows(0)("datumUnos")
                grid2.Rows("rowDatumDo").Properties.Value = .Rows(0)("datumIstekaPass")
                rowAktiv.Properties.Value = .Rows(0)("aktivno")
                colPicture.Value = getPicDB(iNull0(.Rows(0)("slika")))
                pic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            End With
        End If
    End Sub

    Private Sub grid2_CellValueChanging(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles grid2.CellValueChanging
        flgChange = True
        cmdSave.Enabled = True
    End Sub

    ''menu na desni klik
    Private Sub gridView_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView.PopupMenuShowing
        Dim View As GridView = CType(sender, GridView)
        Dim g As DevExpress.XtraGrid.Views.Grid.GridView
        If e.HitInfo.InRow Then
            g = gridView
            rightClickMenu.Show(View.GridControl, e.Point)
        End If
    End Sub
#End Region


#Region "ostali gridosi"

    Private Sub fillgridTvrtka()
        If DS.Tables.IndexOf("tvrtka") > -1 Then
            DS.Tables("tvrtka").Clear()
        End If

        DA = New SqlDataAdapter("select id,naziv from klijenti where aktiv=1 order by naziv", gCN)
        DA.Fill(DS, "tvrtka")


        Dim colIDT As New GridColumn
        colIDT.FieldName = "id"
        colIDT.Caption = "ID"
        colIDT.VisibleIndex = 0
        colIDT.Visible = False

        Dim colNazivT As New GridColumn
        colNazivT.Visible = True
        colNazivT.FieldName = "naziv"
        colNazivT.Caption = "Naziv"
        colNazivT.VisibleIndex = 1

        gridViewTvrtka.Columns.Clear()
        gridViewTvrtka.Columns.Add(colIDT)
        gridViewTvrtka.Columns.Add(colNazivT)

        gridViewTvrtka.OptionsView.ShowGroupPanel = False
        gridViewTvrtka.OptionsBehavior.AllowIncrementalSearch = True
        gridViewTvrtka.OptionsFind.FindMode = FindMode.Always
        gridViewTvrtka.OptionsSelection.EnableAppearanceFocusedCell = False

        gridTvrtka.DataSource = DS.Tables("tvrtka")
    End Sub


    Private Sub gridViewTvrtka_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridViewTvrtka.RowClick
        iTvrtka = gridTvrtka.GetDisplayValue(e.RowHandle)(0)
        rowTvrtka.Properties.Value = gridTvrtka.GetDisplayValue(e.RowHandle)(1)

        rowOrgJed.Properties.Value = ""
        'fillcmbOrgJedinica(iTvrtka)
        fillgridOrgJed(iTvrtka)
    End Sub


    Private Sub fillgridRadMj(ByVal id As Integer)
        If id <> 0 Or id <> Nothing Then
            If DS.Tables.IndexOf("radMj") > -1 Then
                DS.Tables("radMj").Clear()
            End If

            DA = New SqlDataAdapter("select id,naziv from radnoMjesto where organizacija=" + id.ToString, gDATABASE)
            DA.Fill(DS, "radMj")


            Dim colIDRM As New GridColumn
            colIDRM.FieldName = "id"
            colIDRM.Caption = "ID"
            colIDRM.VisibleIndex = 0
            colIDRM.Visible = False

            Dim colRadMj As New GridColumn
            colRadMj.FieldName = "naziv"
            colRadMj.Caption = "Naziv"
            colRadMj.VisibleIndex = 1

            gridRadMjView.Columns.Clear()
            gridRadMjView.Columns.Add(colIDRM)
            gridRadMjView.Columns.Add(colRadMj)

            gridRadMjView.OptionsView.ShowGroupPanel = False
            gridRadMjView.OptionsBehavior.AllowIncrementalSearch = True
            gridRadMjView.OptionsFind.FindMode = FindMode.Always
            gridRadMjView.OptionsSelection.EnableAppearanceFocusedCell = False

            gridRadMj.DataSource = DS.Tables("radMj")
        End If
    End Sub

    Private Sub gridRadMjView_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridRadMjView.RowClick
        colRadMj.Value = gridRadMj.GetDisplayValue(e.RowHandle)("naziv").ToString
        iRadMj = gridRadMj.GetDisplayValue(e.RowHandle)("ID")
    End Sub


    Private Sub fillgridOrgJed(ByVal id As Integer)
        If id <> 0 Or id <> Nothing Then
            If DS.Tables.IndexOf("orgJed") > -1 Then
                DS.Tables("orgJed").Clear()
            End If

            DA = New SqlDataAdapter("select id,naziv from orgjed where tvrtka =" + id.ToString, gDATABASE)
            DA.Fill(DS, "orgJed")


            Dim colIDRM As New GridColumn
            colIDRM.FieldName = "id"
            colIDRM.Caption = "ID"
            colIDRM.VisibleIndex = 0
            colIDRM.Visible = False

            Dim colRadMj As New GridColumn
            colRadMj.FieldName = "naziv"
            colRadMj.Caption = "Naziv"
            colRadMj.VisibleIndex = 1

            gridOrgJedView.Columns.Clear()
            gridOrgJedView.Columns.Add(colIDRM)
            gridOrgJedView.Columns.Add(colRadMj)

            gridOrgJedView.OptionsView.ShowGroupPanel = False
            gridOrgJedView.OptionsBehavior.AllowIncrementalSearch = True
            gridOrgJedView.OptionsFind.FindMode = FindMode.Always
            gridOrgJedView.OptionsSelection.EnableAppearanceFocusedCell = False

            gridOrgJed.DataSource = DS.Tables("orgJed")
        End If
    End Sub



    Private Sub gridOrgJedView_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridOrgJedView.RowClick
        colOrgJed.Value = gridOrgJed.GetDisplayValue(e.RowHandle)("naziv").ToString
        iOrgJed = gridOrgJed.GetDisplayValue(e.RowHandle)(0)

        fillgridRadMj(iOrgJed)

        'rowTvrtka.Properties.Value = gridTvrtka.GetDisplayValue(e.RowHandle)(1)
    End Sub

    Private Sub fillgridZupanija()
        If DS.Tables.IndexOf("zupa") > -1 Then
            DS.Tables("zupa").Clear()
        End If

        DA = New SqlDataAdapter("select sifra as id,naziv from zupanije order by naziv", gDATABASE)
        DA.Fill(DS, "zupa")

        Dim colID As New GridColumn
        colID.FieldName = "id"
        colID.Caption = "ID"
        colID.VisibleIndex = 0
        colID.Visible = False

        Dim colZupanija As New GridColumn
        colZupanija.FieldName = "naziv"
        colZupanija.Caption = "naziv"
        colZupanija.VisibleIndex = 1

        gridViewZupanija.Columns.Clear()
        gridViewZupanija.Columns.Add(colID)
        gridViewZupanija.Columns.Add(colZupanija)

        gridViewZupanija.OptionsView.ShowGroupPanel = False
        gridViewZupanija.OptionsBehavior.AllowIncrementalSearch = True
        gridViewZupanija.OptionsFind.FindMode = FindMode.Always
        gridViewZupanija.OptionsSelection.EnableAppearanceFocusedCell = False

        gridZupa.DataSource = DS.Tables("zupa")
    End Sub

    Private Sub gridViewZupanija_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridViewZupanija.RowClick
        colZupanija.Value = gridZupa.GetDisplayValue(e.RowHandle)("naziv").ToString
        iZupanija = gridZupa.GetDisplayValue(e.RowHandle)("id")

        CreateWaitDialog(rm.GetString("waitCapiton15"), rm.GetString("waitTitle"))
        fillGridMjesto(iZupanija)
        CloseWaitDialog()
    End Sub



    Private Sub fillGridMjesto(ByVal id As Integer)
        If id <> 0 Or id <> Nothing Then
            If DS.Tables.IndexOf("mjesto") > -1 Then
                DS.Tables("mjesto").Clear()
            End If

            DA = New SqlDataAdapter("select id,naselje,ptt from mjesta where zupanija=" + id.ToString + " order by naselje", gDATABASE)
            DA.Fill(DS, "mjesto")

            Dim colId As New GridColumn
            colId.FieldName = "id"
            colId.Caption = "ID"
            colId.VisibleIndex = 0
            colId.Visible = False

            Dim colName As New GridColumn
            colName.FieldName = "naselje"
            colName.Caption = "Naselje"
            colName.VisibleIndex = 1

            Dim colPtt As New GridColumn
            colPtt.FieldName = "ptt"
            colPtt.Caption = "PTT"
            colPtt.VisibleIndex = 2
            colPtt.Visible = False

            gridViewMjesto.Columns.Clear()
            gridViewMjesto.Columns.Add(colId)
            gridViewMjesto.Columns.Add(colName)
            gridViewMjesto.Columns.Add(colPtt)

            gridViewMjesto.OptionsView.ShowGroupPanel = False
            gridViewMjesto.OptionsBehavior.AllowIncrementalSearch = True
            gridViewMjesto.OptionsFind.FindMode = FindMode.Always
            gridViewMjesto.OptionsSelection.EnableAppearanceFocusedCell = False

            gridMjesto.DataSource = DS.Tables("mjesto")
        End If
    End Sub

    Private Sub gridViewMjesto_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridViewMjesto.RowClick
        iMjesto = gridMjesto.GetDisplayValue(e.RowHandle)(0)

        colMjestoNaziv.Value = gridMjesto.GetDisplayValue(e.RowHandle)(1).ToString
        colPtt.Value = gridMjesto.GetDisplayValue(e.RowHandle)(2).ToString

        fillcmbUlice(iMjesto)
    End Sub




    'Private Sub fillGridMjesto(ByVal id As Integer)
    '    If id <> 0 Or id <> Nothing Then
    '        If DS.Tables.IndexOf("mjesto") > -1 Then
    '            DS.Tables("mjesto").Clear()
    '        End If

    '        DA = New SqlDataAdapter("select id,naselje,ptt as naziv from mjesta where zupanija=" + id.ToString + " order by naziv", gDATABASE)
    '        DA.Fill(DS, "mjesto")

    '        gridMjesto.DataSource = DS.Tables("mjesto")
    '    End If
    'End Sub

    'Private Sub gridUlica_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridMjestoView2.RowClick
    '    iMjesto = gridMjesto.GetDisplayValue(e.RowHandle)(0)
    '    colMjesto.Value = gridMjesto.GetDisplayValue(e.RowHandle)(1).ToString
    '    colPtt.Value = gridMjesto.GetDisplayValue(e.RowHandle)(2).ToString
    'End Sub
#End Region


#Region "provjeras"

    Private Function checkGridValues() As Boolean
        CreateWaitDialog(rm.GetString("waitCaption10"), rm.GetString("waitTitle"))

        Dim categItem As New CategoryRow
        Dim rowItem As New EditorRow

        checkGridValues = True

        For i = 0 To grid2.Rows.Count - 1
            categItem = grid2.Rows(i)

            For j = 0 To categItem.ChildRows.Count - 1
                If TypeOf categItem.ChildRows(j) Is EditorRow Then
                    rowItem = categItem.ChildRows(j)

                    Select Case rowItem.Name
                        Case "rowIme", "rowPrezime", "rowZupa", "rowMjesto", "rowAdresa",
                             "rowPrava", "rowHint", "rowBirthday"
                            If Convert.ToString(rowItem.Properties.Value) = "" Then
                                grid2.SetRowError(rowItem.Properties, "Potrebno je popuniti/odabrati vrijednost polja!", ErrorType.Critical)
                                checkGridValues = False
                            Else
                                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                            End If

                        Case "rowOIB"
                            If CheckOIB(rowOIB.Properties.Value) = False Then
                                grid2.SetRowError(rowItem.Properties, "Neispravan OIB!", ErrorType.Critical)
                                checkGridValues = False
                            ElseIf Convert.ToString(rowItem.Properties.Value) = "" Then
                                grid2.SetRowError(rowItem.Properties, "Polje OIB mora biti popunjeno!", ErrorType.Critical)
                                checkGridValues = False
                            Else
                                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                            End If


                        Case "rowJMBG"
                            If CheckJMBG(iNull(rowJMBG.Properties.Value)) = False Then
                                grid2.SetRowError(rowItem.Properties, "Neispravan JMBG!", ErrorType.Critical)
                                checkGridValues = False
                            ElseIf Convert.ToString(rowItem.Properties.Value) = "" Then
                                grid2.SetRowError(rowItem.Properties, "Polje JMBG mora biti popunjeno!", ErrorType.Critical)
                                checkGridValues = False
                            Else
                                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                            End If

                        Case "rowUsername"
                            If flgChange = False Then
                                If flgNew = True Then
                                    If checkUser(rowItem.Properties.Value) = False Then
                                        grid2.SetRowError(rowItem.Properties, "Već postoji username s istim vrijednostima!", ErrorType.Critical)
                                        checkGridValues = False
                                    ElseIf Convert.ToString(rowItem.Properties.Value) = "" Then
                                        grid2.SetRowError(rowItem.Properties, "Polje KORISNIK mora biti popunjeno!", ErrorType.Critical)
                                        checkGridValues = False
                                    Else
                                        grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                                    End If
                                End If
                            End If





                        Case "rowBirthDay"
                            If IsNothing(rowItem.Properties.Value) = True Then
                                grid2.SetRowError(rowItem.Properties, "Potrebno odabrati datum rođenja!", ErrorType.Critical)
                                checkGridValues = False
                            Else
                                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                            End If

                        Case "rowPass"
                            Dim tips As String
                            If flgNew = True Then
                                If checkPass(rowItem.Properties.Value, rowUsername.Properties.Value, tips) = False Then
                                    grid2.SetRowError(rowItem.Properties, "Neispravna lozinka" + tips, ErrorType.Critical)
                                    checkGridValues = False
                                ElseIf Convert.ToString(rowItem.Properties.Value) = "" Then
                                    grid2.SetRowError(rowItem.Properties, "Polje LOZINKA mora biti popunjeno!", ErrorType.Critical)
                                    checkGridValues = False
                                Else
                                    grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                                End If
                            End If

                        Case "rowBoja"
                            'If checkBoja(Convert.ToInt32(rowItem.Properties.Value)) = False Then
                            '    grid2.SetRowError(rowItem.Properties, "Potrebno je popuniti/odabrati vrijednost polja!", ErrorType.Critical)
                            '    checkGridValues = False
                            'Else

                            'End If

                        Case "rowTelefonS", "rowMobitelS", "rowEmailS", "rowTelefon", "rowMobitel", "rowEmail"
                            If Convert.ToString(rowItem.Properties.Value) = "" Then
                                grid2.SetRowError(rowItem.Properties, "Nedostaju podaci!", ErrorType.Warning)
                            Else
                                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                            End If

                    End Select
                End If
            Next j

        Next i

        If IsNothing(colKucaBr.Value) = True Or colKucaBr.Value = "" Then
            grid2.SetRowError(colKucaBr, "Morate unijeti kućni broj!", ErrorType.Critical)
            checkGridValues = False
        Else
            grid2.SetRowError(colKucaBr, "", ErrorType.None)
        End If


        DR.Close()

        CloseWaitDialog()

    End Function


    Private Function checkUser(ByVal userName As String) As Boolean

        checkUser = True

        CM = New SqlCommand("select top 1 korisnik from operateri where korisnik='" + userName.ToString + "'", CN)
        DR = CM.ExecuteReader

        If DR.HasRows Then
            checkUser = False
        End If

        DR.Close()
    End Function

    Private Function checkPass(ByVal pass As String, ByVal userName As String, Optional ByRef toolTip As String = "") As Boolean
        Dim tip As String
        checkPass = True

        CM = New SqlCommand("select top 1 id,pol from operateri where lozinka='" + encryptString(pass.ToString) + "' and korisnik='" + userName.ToString + "'", CN)
        DR = CM.ExecuteReader

        If DR.HasRows Then
            checkPass = False
            'ElseIf PassWordPolicy(DR("pol"), pass, tip) = False Then
            checkPass = False
        End If

        toolTip = tip

        DR.Close()
    End Function

    Private Function CheckOperPic() As Boolean
        DA = New SqlDataAdapter("select top 1 * from images where id=" + picID.ToString, gDATABASE)
        DA.Fill(DS, "check")

        CheckOperPic = True

        If DS.Tables("check").Rows.Count > 0 Then
            If alerter.SHOW(alerter.icona.upozorenje, alerter.naslov.Uređivanje, rm.GetString("mess15"), alerter.button.DaNe) = 0 Then
                DA.DeleteCommand = CN.CreateCommand
                DA.DeleteCommand.CommandText = "delete from  images where id=" + picID.ToString
                DA.DeleteCommand.ExecuteNonQuery()
                CheckOperPic = True
            Else
                CheckOperPic = False
            End If
        End If
    End Function


    Private Function checkColor(ByVal boja As Integer) As Boolean

    End Function

#End Region


#Region "procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.enabled = checkSpecial(CTRL)
            If CTRL.HasChildren Then
                For i = 0 To CTRL.Controls.Count - 1
                    CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)
                    CTRL.Controls(i).enabled = checkSpecial(CTRL)
                Next
            End If
        Next CTRL


        ''grid
        For Each colS In gridView.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid2
        For Each rowCateg In grid2.Rows
            rowCateg.Properties.caption = rm.GetString(rowCateg.name.ToString)
            If rowCateg.hasChildren Then
                For i = 0 To rowCateg.ChildRows.Count - 1
                    rowCateg.ChildRows(i).Properties.Caption = rm.GetString(rowCateg.ChildRows(i).Properties.Row.Name.ToString)
                Next
            End If
        Next

        colAdresa.Caption = rm.GetString("colAdresa")
        colKucaBr.Caption = rm.GetString("colKucaBr")

        optSpol.Items(0).Description = rm.GetString("Z")
        optSpol.Items(1).Description = rm.GetString("M")

    End Sub

    Private Sub setTxtMasks()
        txtTel.Mask.IgnoreMaskBlank = True
        txtTel.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtTel.Mask.MaskType = MaskType.Simple
        txtTel.Mask.EditMask = "+385 (99) 999-9999"
        txtTel.Mask.UseMaskAsDisplayFormat = True
        txtTel.Mask.AutoComplete = AutoCompleteType.None

        txtTelS.Mask.IgnoreMaskBlank = True
        txtTelS.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtTelS.Mask.MaskType = MaskType.Simple
        txtTelS.Mask.EditMask = "+385 (99) 999-9999"
        txtTelS.Mask.UseMaskAsDisplayFormat = True
        txtTelS.Mask.AutoComplete = AutoCompleteType.None


        txtMob.Mask.IgnoreMaskBlank = True
        txtMob.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtMob.Mask.MaskType = MaskType.Simple
        txtMob.Mask.EditMask = "+385 (99) 999-9999"
        txtMob.Mask.UseMaskAsDisplayFormat = True
        txtMob.Mask.AutoComplete = AutoCompleteType.None

        txtMobS.Mask.IgnoreMaskBlank = True
        txtMobS.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtMobS.Mask.MaskType = MaskType.Simple
        txtMobS.Mask.EditMask = "+385 (99) 9999-9999"
        txtMobS.Mask.UseMaskAsDisplayFormat = True
        txtMobS.Mask.AutoComplete = AutoCompleteType.None

        txtEmail.Mask.IgnoreMaskBlank = True
        txtEmail.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtEmail.Mask.MaskType = MaskType.RegEx
        txtEmail.Mask.EditMask = "[a-zA-Z0-9_\-\.]+)@((\[[0-9{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?"
        txtEmail.Mask.UseMaskAsDisplayFormat = True
        txtEmail.Mask.AutoComplete = AutoCompleteType.Optimistic

        txtEmailS.Mask.IgnoreMaskBlank = True
        txtEmailS.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtEmailS.Mask.MaskType = MaskType.RegEx
        txtEmailS.Mask.EditMask = "[a-zA-Z0-9_\-\.]+)@((\[[0-9{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?"
        txtEmailS.Mask.UseMaskAsDisplayFormat = True
        txtEmailS.Mask.AutoComplete = AutoCompleteType.Optimistic

        txtJMBG.Mask.IgnoreMaskBlank = False
        txtJMBG.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtJMBG.Mask.MaskType = MaskType.Simple
        txtJMBG.Mask.EditMask = "0000000000000"
        txtJMBG.Mask.UseMaskAsDisplayFormat = True
        txtJMBG.Mask.AutoComplete = AutoCompleteType.None
        txtJMBG.MaxLength = 13

        txtOIB.Mask.IgnoreMaskBlank = False
        txtOIB.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtOIB.Mask.MaskType = MaskType.Simple
        txtOIB.Mask.EditMask = "00000000000"
        txtOIB.Mask.UseMaskAsDisplayFormat = True
        txtOIB.Mask.AutoComplete = AutoCompleteType.None
        txtOIB.MaxLength = 11


    End Sub


    Private Sub clearWarnings()
        Dim categItem As New CategoryRow
        Dim rowItem As New EditorRow

        For i = 0 To grid2.Rows.Count - 1
            categItem = grid2.Rows(i)
            For j = 0 To categItem.ChildRows.Count - 1
                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                If TypeOf categItem.ChildRows(j) Is EditorRow Then
                    rowItem = categItem.ChildRows(j)
                    grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                End If
            Next j

        Next i
    End Sub


    Private Sub Spremi(Optional ByVal id As Long = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select * from operateri where id=" + id.ToString

        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "oper")

        CB = New SqlCommandBuilder(DA)

        If DS.Tables("oper").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("oper")
                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated
                row = DS.Tables("oper").NewRow()
                row.Item("ime") = grid2.Rows("rowIme").Properties.Value.ToString
                row.Item("prezime") = grid2.Rows("rowPrezime").Properties.Value.ToString
                row.Item("datumRodj") = rowBirthDay.Properties.Value.ToString 'grid2.Rows("rowBirthDay").Properties.Value
                row.Item("zupanija") = iZupanija
                row.Item("Mjesto") = iMjesto
                row.Item("ptt") = colPtt.Value
                row.Item("adresa") = iUlica
                row.Item("kucniBr") = iNull0(colKucaBr.Value)
                row.Item("spol") = rowSpol.VisibleIndex

                row.Item("JMBG") = rowJMBG.Properties.Value
                row.Item("OIB") = rowOIB.Properties.Value


                row.Item("tel") = grid2.Rows("rowTelefon").Properties.Value.ToString
                row.Item("mob") = grid2.Rows("rowMobitel").Properties.Value.ToString
                row.Item("email") = grid2.Rows("rowEmail").Properties.Value.ToString
                row.Item("tvrtka") = iTvrtka
                row.Item("orgjed") = iOrgJed
                row.Item("radnoMj") = iRadMj
                row.Item("R") = R
                row.Item("G") = G
                row.Item("B") = B
                row.Item("prava") = iPrava
                row.Item("tel2") = grid2.Rows("rowTelefonS").Properties.Value.ToString
                row.Item("mob2") = grid2.Rows("rowMobitelS").Properties.Value.ToString
                row.Item("email2") = grid2.Rows("rowEmailS").Properties.Value.ToString
                row.Item("korisnik") = grid2.Rows("rowUsername").Properties.Value.ToString
                row.Item("lozinka") = encryptString(grid2.Rows("rowPass").Properties.Value.ToString)
                row.Item("hint") = grid2.Rows("rowHint").Properties.Value.ToString
                row.Item("datumUnos") = Now.ToShortTimeString
                row.Item("aktivno") = rowAktiv.Index
                row.Item("slika") = picID
                row.Item("pol") = 1
                row.Item("pravaCustom") = 15    'sve dozvoljeno
                DS.Tables("oper").Rows.Add(row)
                DA.Update(DS, "oper")
                DA.Dispose()

                setPassExpiry(iID)

                flgNew = False
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                With DS.Tables("oper")
                    .Rows(0)("ime") = grid2.Rows("rowIme").Properties.Value.ToString
                    .Rows(0)("prezime") = grid2.Rows("rowPrezime").Properties.Value.ToString
                    .Rows(0)("datumRodj") = rowBirthDay.Properties.Value.ToString   '' grid2.Rows("rowBirthday").Properties.Value.ToString

                    .Rows(0)("JMBG") = rowJMBG.Properties.Value
                    .Rows(0)("OIB") = rowOIB.Properties.Value

                    .Rows(0)("zupanija") = iZupanija
                    .Rows(0)("Mjesto") = iMjesto
                    .Rows(0)("ptt") = colPtt.Value
                    .Rows(0)("adresa") = iUlica
                    .Rows(0)("kucniBr") = colKucaBr.Value
                    .Rows(0)("spol") = iSpol
                    .Rows(0)("tel") = grid2.Rows("rowTelefon").Properties.Value.ToString
                    .Rows(0)("mob") = grid2.Rows("rowMobitel").Properties.Value.ToString
                    .Rows(0)("email") = grid2.Rows("rowEmail").Properties.Value.ToString
                    .Rows(0)("orgjed") = iOrgJed
                    .Rows(0)("radnoMj") = iRadMj
                    .Rows(0)("tvrtka") = iTvrtka
                    .Rows(0)("R") = R
                    .Rows(0)("G") = G
                    .Rows(0)("B") = B
                    .Rows(0)("prava") = iPrava
                    .Rows(0)("tel2") = grid2.Rows("rowTelefonS").Properties.Value.ToString
                    .Rows(0)("mob2") = grid2.Rows("rowMobitelS").Properties.Value.ToString
                    .Rows(0)("email2") = grid2.Rows("rowEmailS").Properties.Value.ToString
                    .Rows(0)("korisnik") = grid2.Rows("rowUsername").Properties.Value.ToString
                    .Rows(0)("lozinka") = encryptString(grid2.Rows("rowPass").Properties.Value.ToString)
                    .Rows(0)("hint") = grid2.Rows("rowHint").Properties.Value.ToString
                    .Rows(0)("datumUnos") = Now.ToShortTimeString
                    .Rows(0)("aktivno") = iAktivno
                    .Rows(0)("pol") = 1
                    .Rows(0)("pravaCustom") = 15    'sve dozvoljeno
                End With
                DA.Update(DS, "oper")
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        End If
    End Sub

    Private Sub setPassExpiry(oper As Integer)
        Dim di As DateInterval
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim CB As New SqlCommandBuilder

        DA = New SqlDataAdapter("select top 1 id,datumIstekaPass,(select period from passPolicy where id=operateri.pol)as period,(select periodType from passPolicy where id=operateri.pol)as periodType from operateri where id = " + oper.ToString, gCN)
        DA.Fill(DS, "passExp")

        CB = New SqlCommandBuilder(DA)

        Select Case DS.Tables("passExp").Rows(0)("periodType")
            Case 0
                di = DateInterval.Hour
            Case 1
                di = DateInterval.Day
            Case 2
                di = DateInterval.Month
            Case 3
                di = DateInterval.Year
        End Select

        With DS.Tables("passExp")
            .Rows(0).Item("datumIstekaPass") = DateAdd(di, .Rows(0)("period"), Now)
        End With
        DA.Update(DS, "passExp")

        DA.Dispose() : DS.Dispose()
    End Sub


    Private Sub Novo()
        flgNew = True
        flgChange = True
        iID = 0
        iRow = 0
        ItemSelected = 0
        iOrgJed = 0
        iRadMj = 0
        iPrava = 0
        iZupanija = 0
        iMjesto = 0
        iSpol = 1
        A = 0
        R = 0
        G = 0
        B = 0
        picID = 0
        picFileName = ""
        colPrava0.Value = "Gost"
        colPrava.Value = 0
        grid2.Rows("rowJMBG").Properties.Value = ""
        grid2.Rows("rowOIB").Properties.Value = ""
        grid2.Rows("rowBirthDay").Properties.Value = "***Odaberite Datum***"
        grid2.Rows("rowIme").Properties.Value = ""
        grid2.Rows("rowPrezime").Properties.Value = ""
        grid2.Rows("rowZupa").Properties.Value = ""
        colMjestoNaziv.Value = ""
        colPtt.Value = ""
        colAdresa.Value = ""
        colKucaBr.Value = ""
        optSpol.Items(0).Value = 1
        grid2.Rows("rowTelefon").Properties.Value = ""
        grid2.Rows("rowMobitel").Properties.Value = ""
        grid2.Rows("rowEmail").Properties.Value = ""
        colOrgJed2.Value = ""
        colRadMj2.Value = ""
        rowBoja.Properties.Value = Color.FromArgb(0, 0, 0)
        grid2.Rows("rowTelefonS").Properties.Value = ""
        grid2.Rows("rowMobitelS").Properties.Value = ""
        grid2.Rows("rowEmailS").Properties.Value = ""
        grid2.Rows("rowUsername").Properties.Value = ""
        grid2.Rows("rowPass").Properties.Value = ""
        grid2.Rows("rowDatumOd").Properties.Value = Now.ToShortDateString
        grid2.Rows("rowDatumDo").Properties.Value = DateAdd("M", 1, Now.ToShortDateString).ToString
        grid2.Rows("rowHint").Properties.Value = ""
        grid2.Rows("rowPrilog").Properties.Value = rm.GetString("UkupnoDokumenata") + "0"
        'grid2.Rows("rowTvrtka").Properties.Value = "***Odaberite Tvrtku***"

        cmbTvrtka.NullText = ""

        colPicture.Value = ""
    End Sub

    Private Sub fillTrack()
        CM = New SqlCommand("select count(id)ukup from vrste where tip=2 and aktiv=1", CN)
        DR = CM.ExecuteReader

        While (DR.Read)
            trackPrava2.Maximum = DR("ukup")
        End While
        DR.Close()
    End Sub

    Private Function UnosNoveUlice(naziv As String) As Integer
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable
        Dim row As DataRow

        DA = New SqlDataAdapter("select top 1 * from ulice", gCN)
        DA.Fill(DS, "newUlica")

        CB = New SqlCommandBuilder(DA)
        DT = DS.Tables("newUlica")

        AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated2


        row = DS.Tables("newUlica").NewRow()
        row.Item("naziv") = naziv.ToString
        row.Item("mjesto") = iMjesto
        DS.Tables("newUlica").Rows.Add(row)
        DA.Update(DS, "newUlica")
        DA.Dispose()

        UnosNoveUlice = iUlica
    End Function


    Private Function checkNewUlica() As Integer
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select br from ulice where naziv ='" + colAdresa.Value.ToString + "' and mjesto=" + iMjesto.ToString

        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "chkUlica")

        DT = DS.Tables("chkUlica")

        If DT.Rows.Count > 0 Then
            checkNewUlica = DT.Rows(0)("br")
        Else
            If alerter.SHOW(alerter.icona.upozorenje, alerter.naslov.Pažnja, rm.GetString("mess35") + colAdresa.Value.ToString, alerter.button.DaNe) = 0 Then
                checkNewUlica = UnosNoveUlice(colAdresa.Value)
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess36"))
            Else
                checkNewUlica = -1
            End If
        End If

        DA.Dispose() : DS.Dispose() : DT.Dispose()
    End Function

#End Region


#Region "OSTALO"
    Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackPrava2.EditValueChanged
        iPrava = sender.text.ToString

        Dim command As SqlCommand = New SqlCommand("select naziv from vrste where tip=2 and tezina=" + sender.text.ToString, CN)
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            Do While reader.Read()
                colPrava.Value = reader("naziv")
            Loop
        Else
            Console.WriteLine("No rows found.")
        End If
        reader.Close()
    End Sub

    Private Sub boja_ColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles boja.ColorChanged
        A = sender.color.A
        R = sender.color.R
        G = sender.color.G
        B = sender.color.B
    End Sub

    Private Sub optSpol_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optSpol.SelectedIndexChanged
        iSpol = sender.selectedIndex
    End Sub

    Private Sub chkAktiv_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAktiv.EditValueChanged
        iAktivno = sender.checked
    End Sub



    ''ID nakon unosa
    Private Sub da_Handle_RowUpdated(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue And e.StatementType = StatementType.Insert Then
            e.Row("id") = GetIdentity(e.Command.Connection)
            e.Row.AcceptChanges()
            iID = e.Row("id")
        End If
    End Sub

    Private Sub da_Handle_RowUpdated2(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue And e.StatementType = StatementType.Insert Then
            e.Row("br") = GetIdentity(e.Command.Connection)
            e.Row.AcceptChanges()
            iUlica = e.Row("br")
        End If
    End Sub


    Private Function GetIdentity(ByRef cnn As SqlConnection) As Integer
        Dim oCmd As New SqlCommand("SELECT @@IDENTITY", cnn)
        Dim x As Object = oCmd.ExecuteScalar()
        Return CInt(x)
    End Function
#End Region








End Class