#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Mask

#End Region

Public Class frmClients

#Region "DIM's"
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
    Dim iOrgJed As Long
    Dim iRadMj As Integer
    Dim iPrava As String
    Dim iZupanija As Integer
    Dim iMjesto As Integer
    Dim picID As Long
    Dim picFileName As String
    Dim iAktivno As Boolean = True
    Dim flgNew As Boolean = False
#End Region


#Region "Init Form"
    Dim iUlica As Object
    Dim flgChange As Boolean

    Public Sub New()

        InitializeComponent()
        localizeME()

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        setTxtMasks()
    End Sub

    Private Sub frmClients_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
        fillgridZupanija()
    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click, cmdDelete.Click, cmdPrint.Click, cmdNew.Click, cmdNewOrgJed.Click
        Select Case sender.name
            Case "cmdNew"
                Novo()

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
                        alerter.SHOW(alerter.icona.zabrana, alerter.naslov.Spremanje, rm.GetString("mess40"))
                    End If
                End If

            Case "cmdDelete"

            Case "cmdPrint"

            Case "cmdNewOrgJed"
                Dim frm As New frmOrgJed
                frm.ShowDialog(Me)
        End Select
    End Sub


    Private Sub btnPictrue_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnPictrue.ButtonClick
        If alerter.SHOW(alerter.icona.upit, alerter.naslov.Files, "Želite li spremiti datoteku?", alerter.button.DaNe) = 0 Then
            savePicture()
        End If
    End Sub



    Private Sub cmdPrilog_Click(sender As Object, e As System.EventArgs) Handles cmdPrilog.Click
        Dim frm As New frmFiles(iID, "K")
        frm.ShowDialog(Me)
    End Sub

#End Region


#Region "Procedure i funkcije"

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
            Debug.Print(CTRL.name)
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
    End Sub

    Private Sub setTxtMasks()
        txtTel.Mask.IgnoreMaskBlank = True
        txtTel.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtTel.Mask.MaskType = MaskType.Simple
        txtTel.Mask.EditMask = "+385 (99) 999-9999"
        txtTel.Mask.UseMaskAsDisplayFormat = True
        txtTel.Mask.AutoComplete = AutoCompleteType.None

        'txtTelS.Mask.IgnoreMaskBlank = True
        'txtTelS.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        'txtTelS.Mask.MaskType = MaskType.Simple
        'txtTelS.Mask.EditMask = "+385 (99) 999-9999"
        'txtTelS.Mask.UseMaskAsDisplayFormat = True
        'txtTelS.Mask.AutoComplete = AutoCompleteType.None


        txtMob.Mask.IgnoreMaskBlank = True
        txtMob.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtMob.Mask.MaskType = MaskType.Simple
        txtMob.Mask.EditMask = "+385 (99) 999-9999"
        txtMob.Mask.UseMaskAsDisplayFormat = True
        txtMob.Mask.AutoComplete = AutoCompleteType.None

        'txtMobS.Mask.IgnoreMaskBlank = True
        'txtMobS.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        'txtMobS.Mask.MaskType = MaskType.Simple
        'txtMobS.Mask.EditMask = "+385 (99) 9999-9999"
        'txtMobS.Mask.UseMaskAsDisplayFormat = True
        'txtMobS.Mask.AutoComplete = AutoCompleteType.None

        txtEmail.Mask.IgnoreMaskBlank = True
        txtEmail.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        txtEmail.Mask.MaskType = MaskType.RegEx
        txtEmail.Mask.EditMask = "[a-zA-Z0-9_\-\.]+)@((\[[0-9{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?"
        txtEmail.Mask.UseMaskAsDisplayFormat = True
        txtEmail.Mask.AutoComplete = AutoCompleteType.Optimistic

        'txtEmailS.Mask.IgnoreMaskBlank = True
        'txtEmailS.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
        'txtEmailS.Mask.MaskType = MaskType.RegEx
        'txtEmailS.Mask.EditMask = "[a-zA-Z0-9_\-\.]+)@((\[[0-9{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?"
        'txtEmailS.Mask.UseMaskAsDisplayFormat = True
        'txtEmailS.Mask.AutoComplete = AutoCompleteType.Optimistic

    End Sub

    'Private Sub checkDocCount(ByVal id As Integer)
    '    Dim ukDoc As Integer

    '    CM = New SqlCommand("select count(id)as uk from images where veza=" + id.ToString + " and vrsta='O'", CN)
    '    DR = CM.ExecuteReader

    '    While (DR.Read)
    '        ukDoc = DR("uk")
    '    End While
    '    DR.Close()

    '    rowPrilog.Properties.Value = rm.GetString("UkupnoDokumenata") + ukDoc.ToString
    'End Sub

    Private Sub Novo()
        With DS.Tables("grid2")
            flgNew = True
            iID = 0
            iRow = 0
            ItemSelected = 0
            iOrgJed = 0
            iRadMj = 0
            iPrava = 0
            iZupanija = 0
            iMjesto = 0
            picID = 0
            picFileName = ""
            flgNew = True
            flgChange = True
            grid2.Rows("rowMB").Properties.Value = ""
            grid2.Rows("rowNaziv").Properties.Value = ""
            grid2.Rows("rowZupa").Properties.Value = ""
            colMjesto.Value = ""
            colPTT.Value = ""
            colAdresa.Value = ""
            colKucaBr.Value = ""
            optSpol.Items(0).Value = 1
            grid2.Rows("rowTelefon").Properties.Value = ""
            grid2.Rows("rowMobitel").Properties.Value = ""
            grid2.Rows("rowEmail").Properties.Value = ""

        End With
    End Sub

    Private Function CheckOperPic() As Boolean
        DA = New SqlDataAdapter("select top 1 * from images where id=" + picID.ToString, gCN)
        DA.Fill(DS, "check")

        CheckOperPic = True
        If alerter.SHOW(alerter.icona.upozorenje, alerter.naslov.Files, "Želite li zamijeniti postojeću sliku?", alerter.button.DaNe) = 0 Then
            DA.DeleteCommand = CN.CreateCommand
            DA.DeleteCommand.CommandText = "delete from  images where id=" + picID.ToString
            DA.DeleteCommand.ExecuteNonQuery()
            CheckOperPic = True
            alerter.SHOW(alerter.icona.info, alerter.naslov.Files, "Slika spremljena!")
        Else
            CheckOperPic = False
        End If
        'End If
    End Function
    Private Sub savePicture()
        If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            CheckOperPic()

            picFileName = Me.OpenFileDialog1.FileName
            picID = saveFileSQL(OpenFileDialog1.FileName, iID, "K")


            DA.UpdateCommand = gCN.CreateCommand()
            DA.UpdateCommand.CommandText = "update klijenti set logo=" + picID.ToString + " where id=" + iID.ToString
            DA.UpdateCommand.ExecuteNonQuery()
        End If
    End Sub


    Private Sub Spremi(Optional ByVal id As Long = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select * from klijenti where id=" + id.ToString

        DA = New SqlDataAdapter(CM.CommandText, gDATABASE)
        DA.Fill(DS, "klijent")

        CB = New SqlCommandBuilder(DA)

        If DS.Tables("klijent").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("klijent")

                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated

                row = DS.Tables("klijent").NewRow()
                row.Item("naziv") = grid2.Rows("rowNaziv").Properties.Value.ToString
                row.Item("zupanija") = iZupanija
                row.Item("MB") = grid2.Rows("rowMB").Properties.Value
                row.Item("Mjesto") = iMjesto
                row.Item("ptt") = colPTT.Value.ToString()
                row.Item("adresa") = iUlica
                row.Item("kucniBr") = colKucaBr.Value
                row.Item("tel") = grid2.Rows("rowTelefon").Properties.Value.ToString
                row.Item("mob") = grid2.Rows("rowMobitel").Properties.Value.ToString
                row.Item("mail") = iNull(grid2.Rows("rowEmail").Properties.Value)
                row.Item("datum") = Now.ToShortTimeString
                row.Item("aktiv") = rowAktiv.Index
                row.Item("logo") = picID

                DS.Tables("klijent").Rows.Add(row)
                DA.Update(DS, "klijent")
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                With DS.Tables("klijent")
                    .Rows(0)("naziv") = grid2.Rows("rowNaziv").Properties.Value.ToString
                    .Rows(0)("MB") = grid2.Rows("rowMB").Properties.Value
                    .Rows(0)("zupanija") = iZupanija
                    .Rows(0)("ptt") = colPTT.Value.ToString
                    .Rows(0)("Mjesto") = iMjesto
                    .Rows(0)("adresa") = iUlica
                    .Rows(0)("kucniBr") = colKucaBr.Value
                    .Rows(0)("tel") = grid2.Rows("rowTelefon").Properties.Value.ToString
                    .Rows(0)("mob") = grid2.Rows("rowMobitel").Properties.Value.ToString
                    .Rows(0)("mail") = grid2.Rows("rowEmail").Properties.Value.ToString
                    .Rows(0)("aktiv") = iAktivno
                End With
                DA.Update(DS, "klijent")
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If

        End If
        flgNew = False
    End Sub

    Private Function checkGridValues() As Boolean
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
                            "rowOrgJed", "rowRadMj", "rowBoja", "rowPrava", "rowHint"
                            If Convert.ToString(rowItem.Properties.Value) = "" Then
                                grid2.SetRowError(rowItem.Properties, "Potrebno je popuniti/odabrati vrijednost polja!", ErrorType.Critical)
                                checkGridValues = False
                            Else
                                grid2.SetRowError(rowItem.Properties, "", ErrorType.None)
                            End If



                        Case "rowTelefon", "rowMobitel", "rowEmail"
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


        'DR.Close()
    End Function

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


#Region "combo-si"

    Private Sub fillcmbUlice(mjesto As Integer)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select br as id,naziv from ulice where mjesto=" + mjesto.ToString + " order by naziv", gDATABASE)
        DA.Fill(DS, "ulice")

        DT = DS.Tables("ulice")
        DA.Dispose()

        cmbUlica.Items.Clear()
        cmbUlica.Items.Add("")

        For Each row As DataRow In DT.Rows
            cmbUlica.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next

        DA.Dispose() : DS.Dispose() : DT.Dispose()
    End Sub

    Private Sub cmbAdresa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUlica.SelectedIndexChanged
        If IsNothing(sender.selectedindex) = False And sender.selectedindex > 0 Then
            iUlica = CType(cmbUlica.Items(sender.selectedindex), cmbVal).Value
        End If
    End Sub
#End Region


#Region "grid"

    Private Sub FillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select id, naziv from klijenti", gCN)
        DA.Fill(DS, "grid")

        grid.DataSource = DS.Tables("grid")
    End Sub

    Private Sub grid_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
        iRow = e.FocusedRowHandle

        rowPrilog.Properties.Value = rm.GetString("UkupnoDokumenata") + checkDocCount(iID, "K").ToString

        fillgrid2(iID)
    End Sub

#End Region


#Region "grid2"

    Private Sub fillgrid2(ByVal id As Integer)

        If DS.Tables.IndexOf("grid2") > -1 Then
            DS.Tables("grid2").Clear()
        End If

        DA = New SqlDataAdapter("select *, " _
                                + "(select naziv from zupanije where sifra=klijenti.zupanija)sZupanija, " _
                                + " dbo.getMjesto(mjesto)as sMjesto, " _
                                + " dbo.getUlica(adresa)as sUlica " _
                                + "from klijenti where id=" + id.ToString, gCN)
        DA.Fill(DS, "grid2")

        If DS.Tables("grid2").Rows.Count > 0 Then
            With DS.Tables("grid2")
                grid2.Rows("rowNaziv").Properties.Value = .Rows(0)("naziv").ToString
                grid2.Rows("rowMB").Properties.Value = .Rows(0)("MB").ToString
                iZupanija = .Rows(0)("zupanija").ToString

                grid2.Rows("rowZupa").Properties.Value = .Rows(0)("sZupanija").ToString

                iMjesto = .Rows(0)("mjesto").ToString
                fillGridMjesto(iZupanija)
                colMjesto.Value = .Rows(0)("sMjesto").ToString
                colPTT.Value = .Rows(0)("ptt").ToString

                iUlica = .Rows(0)("adresa")
                colAdresa.Value = .Rows(0)("sUlica")
                colKucaBr.Value = .Rows(0)("kucniBr").ToString
                grid2.Rows("rowTelefon").Properties.Value = .Rows(0)("tel")
                grid2.Rows("rowMobitel").Properties.Value = .Rows(0)("mob")
                grid2.Rows("rowEmail").Properties.Value = .Rows(0)("mail")
                grid2.Rows("rowDatumOd").Properties.Value = .Rows(0)("datum")
                rowAktiv.Properties.Value = .Rows(0)("aktiv")
                colLogo.Value = getPicDB(.Rows(0)("logo"))
                pic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            End With
        End If

    End Sub

    Private Sub grid2_CellValueChanging(sender As Object, e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles grid2.CellValueChanging
        flgChange = True
        cmdSave.Enabled = True
    End Sub

#End Region


#Region "grid ostali"

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

        colMjesto.Value = gridMjesto.GetDisplayValue(e.RowHandle)(1).ToString
        colPTT.Value = gridMjesto.GetDisplayValue(e.RowHandle)(2).ToString

        fillcmbUlice(iMjesto)
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

        gridViewZupanije.Columns.Clear()
        gridViewZupanije.Columns.Add(colID)
        gridViewZupanije.Columns.Add(colZupanija)

        gridViewZupanije.OptionsView.ShowGroupPanel = False
        gridViewZupanije.OptionsBehavior.AllowIncrementalSearch = True
        gridViewZupanije.OptionsFind.FindMode = FindMode.Always
        gridViewZupanije.OptionsSelection.EnableAppearanceFocusedCell = False

        gridZupa.DataSource = DS.Tables("zupa")
    End Sub

    Private Sub gridViewZupanija_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridViewZupanije.RowClick
        colZupanija.Value = gridZupa.GetDisplayValue(e.RowHandle)("naziv").ToString
        iZupanija = gridZupa.GetDisplayValue(e.RowHandle)("id")

        CreateWaitDialog(rm.GetString("waitCapiton15"), rm.GetString("waitTitle"))
        fillGridMjesto(iZupanija)
        CloseWaitDialog()
    End Sub
#End Region


#Region "Ostalo"

    Private Function GetIdentity(ByRef cnn As SqlConnection) As Integer
        Dim oCmd As New SqlCommand("SELECT @@IDENTITY", cnn)
        Dim x As Object = oCmd.ExecuteScalar()
        Return CInt(x)
    End Function

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

    Private Sub chkAktiv_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAktiv.EditValueChanged
        iAktivno = sender.checked
    End Sub

#End Region


End Class