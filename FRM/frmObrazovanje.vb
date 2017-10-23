#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

#End Region

Public Class frmObrazovanje

#Region "Dim's"

    Dim iTab As Object
    Dim err As New DXErrorProvider
    Dim iStupanj As Integer
    Dim iMjesto As Object
    'Dim DA As New SqlDataAdapter
    'Dim DS As New DataSet
    Dim iID As Integer
    Dim iOper As Integer

    Dim flgNew As Boolean = False
    Dim flgChange As Boolean = False

#End Region


#Region "Init form"


    Public Sub New(Optional operater As Integer = 0)
        InitializeComponent()
        localizeME()
        Me.iOper = operater
    End Sub


    Private Sub frmObrazovanje_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillCmbMjesta()
        fillCmbStupanjObrazovanja()
        fillGrid()
        fillGrid2()
        'fillGrid3()
    End Sub
#End Region


#Region "Click's"

    Private Sub tab_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tab.SelectedPageChanged
        iTab = tab.SelectedTabPageIndex
        iID = 0

        Select Case iTab
            Case 0
                fillGrid()

            Case 1
                fillGrid2()

            Case 2

        End Select

    End Sub
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click, cmdExit.Click, cmdNew.Click

        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdSave"
                If checkVal() Then
                    spremi(iID)
                    flgNew = False
                    flgChange = False
                    fillGrid()
                    fillGrid2()
                End If

            Case "cmdNew"
                novo()
                flgNew = True
                flgChange = True

        End Select
    End Sub
#End Region


#Region "Grid"
    Private Sub fillGrid()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select * from obrazovanje where oper=" + iOper.ToString, gCN)
        DA.Fill(DS, "grid")

        gridFormal.DataSource = DS.Tables("grid")
        gridViewFormal.MoveBy(0)
    End Sub

    Private Sub gridViewFormal_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewFormal.FocusedRowChanged
        gridFormal.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridViewFormal.GetRowCellValue(e.FocusedRowHandle, colID)
        'iRow = e.FocusedRowHandle
        If iID > 0 Then
            fillData(iID)
        End If

    End Sub

#End Region


#Region "Grid2"
    Private Sub fillGrid2()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("grid2") > -1 Then
            DS.Tables("grid2").Clear()
        End If

        DA = New SqlDataAdapter("select * from certifikati where oper=" + iOper.ToString, gCN)
        DA.Fill(DS, "grid2")

        gridCert.DataSource = DS.Tables("grid2")
        gridViewCertifikat.MoveBy(-1)
    End Sub

    Private Sub gridViewCertifikat_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewCertifikat.FocusedRowChanged
        gridCert.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridViewCertifikat.GetRowCellValue(e.FocusedRowHandle, colID)
        'iRow = e.FocusedRowHandle
        If iID > 0 Then
            fillData(iID)
        End If
    End Sub

#End Region



#Region "Combo-si"
    Private Sub fillCmbStupanjObrazovanja()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select id, (kratica+' - '+naziv)as sNaziv from stupanjObrazovanja", gDATABASE)
        DA.Fill(DS, "stupanj")

        DT = DS.Tables("stupanj")
        DA.Dispose()

        cmbStupanj.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbStupanj.Properties.Items.Add(New cmbVal(row("id"), row("sNaziv")))
        Next

        DS.Tables("stupanj").Reset()
    End Sub

    Private Sub cmbStupanj_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStupanj.SelectedIndexChanged
        If IsNothing(sender.selectedindex) = False And sender.selectedindex > 0 Then
            iStupanj = CType(cmbStupanj.Properties.Items(sender.selectedindex), cmbVal).Value
        End If
    End Sub

    Private Sub fillCmbMjesta()
        Dim Da As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        If DS.Tables.IndexOf("mjesto") > -1 Then
            DS.Tables("mjesto").Clear()
        End If

        Da = New SqlDataAdapter("select id,naselje,ptt from mjesta order by naselje", gDATABASE)
        Da.Fill(DS, "mjesto")
        DT = DS.Tables("mjesto")
        Da.Dispose()

        cmbMjesta.Properties.Items.Clear()
        cmbCMjesto.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbMjesta.Properties.Items.Add(New cmbVal(row("id"), row("naselje")))
            cmbCMjesto.Properties.Items.Add(New cmbVal(row("id"), row("naselje")))
        Next

        DS.Tables("mjesto").Reset()

    End Sub

    Private Sub cmbMjesta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMjesta.SelectedIndexChanged
        If IsNothing(sender.selectedindex) = False And sender.selectedindex > 0 Then
            iMjesto = CType(cmbMjesta.Properties.Items(sender.selectedindex), cmbVal).Value
        End If
    End Sub

    Private Sub cmbCMjesto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCMjesto.SelectedIndexChanged
        If IsNothing(sender.selectedindex) = False And sender.selectedindex > 0 Then
            iMjesto = CType(cmbCMjesto.Properties.Items(sender.selectedindex), cmbVal).Value
        End If
    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        ''grid formalno
        For Each colS In gridViewFormal.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        For Each CTRL In groupFormalno.Controls
            If CTRL.GetType.Name = "LabelControl" Then
                CTRL.text = rm.GetString(CTRL.name.ToString)
            End If
        Next CTRL

        ''grid certifikat
        For Each colS In gridViewCertifikat.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        For Each CTRL In groupCertifikat.Controls
            If CTRL.GetType.Name = "LabelControl" Then
                CTRL.text = rm.GetString(CTRL.name.ToString)
            End If
        Next CTRL

        For Each CTRL In groupSeminari.Controls
            If CTRL.GetType.Name = "LabelControl" Then
                CTRL.text = rm.GetString(CTRL.name.ToString)
            End If
        Next CTRL

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.enabled = checkSpecial(CTRL)
        Next CTRL
    End Sub

    Private Function checkVal() As Boolean
        checkVal = True
        Select Case iTab
            Case 0
                For Each ctrl In groupFormalno.Controls
                    If ctrl.GetType.Name = "TextEdit" Then
                        If ctrl.Text = "" Or ctrl.Text = "0,00" Then
                            err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                            'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                            err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                            checkVal = False
                        End If
                    ElseIf ctrl.GetType.Name = "ComboBoxEdit" Then
                        If ctrl.SelectedIndex = -1 Then
                            err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                            'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                            err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                            checkVal = False
                        End If
                    End If
                Next


            Case 1
                For Each ctrl In groupCertifikat.Controls
                    If ctrl.GetType.Name = "TextEdit" Then
                        If ctrl.Text = "" Or ctrl.Text = "0,00" Then
                            err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                            'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                            err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                            checkVal = False
                        End If
                    ElseIf ctrl.GetType.Name = "ComboBoxEdit" Then
                        If ctrl.SelectedIndex = -1 Then
                            err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                            'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                            err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                            checkVal = False
                        End If
                    End If
                Next

        End Select

    End Function

    Private Sub novo()
        cmbMjesta.SelectedIndex = -1
        cmbStupanj.SelectedIndex = -1
        txtFUstanova.Text = ""
        txtFZanimanje.Text = ""
        txtFKomentar.Text = ""
        dtp.DateTime = Now.Date

        txtCCertifikat.Text = ""
        txtCUstanova.Text = ""
        cmbCMjesto.SelectedIndex = -1
        dtpC.DateTime = Now.Date
        chkCRadnaKnj.CheckState = CheckState.Unchecked
        txtCKomentar.Text = ""
        txtCCijena.Text = "0,00"
        iID = 0
    End Sub


    Private Sub fillData(id As Integer)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        Select Case iTab
            Case 0
                DA = New SqlDataAdapter("select top 1 *,(select kratica+' - '+naziv from stupanjObrazovanja where id=obrazovanje.stupanj)sStupanj " _
                      + " ,dbo.getMjesto(mjesto)sMjesto from obrazovanje where id=" + id.ToString, gCN)
                DA.Fill(DS, "obrazovanje")
                DT = DS.Tables("obrazovanje")

                With DT
                    cmbStupanj.Text = .Rows(0)("sStupanj")
                    txtFZanimanje.Text = .Rows(0)("zanimanje")
                    txtFUstanova.Text = .Rows(0)("ustanova")
                    cmbMjesta.Text = .Rows(0)("sMjesto")
                    dtp.DateTime = .Rows(0)("datumKraj")
                    txtFKomentar.Text = .Rows(0)("komentar")
                End With


            Case 1
                DA = New SqlDataAdapter("select top 1 * ,dbo.getMjesto(mjesto)sMjesto from certifikati where id=" + id.ToString, gCN)
                DA.Fill(DS, "certifikat")
                DT = DS.Tables("certifikat")

                With DT
                    txtCCertifikat.Text = .Rows(0)("naziv")
                    txtCUstanova.Text = .Rows(0)("ustanova")
                    cmbCMjesto.Text = .Rows(0)("sMjesto")
                    dtpC.DateTime = .Rows(0)("datumKraj")
                    txtCKomentar.Text = .Rows(0)("komentar")
                    chkCRadnaKnj.CheckState = .Rows(0)("upisuknjizicu")
                    txtCCijena.Text = FormatCurrency(.Rows(0)("cijena"))

                End With

            Case 2

        End Select




    End Sub

    Private Sub spremi(Optional id As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable
        Dim CB As New SqlCommandBuilder
        Dim row As DataRow

        Select Case iTab
            Case 0
                DA = New SqlDataAdapter("select top 1 * from obrazovanje where id=" + id.ToString, gCN)
                DA.Fill(DS, "obrazovanje")
                DT = DS.Tables("obrazovanje")

                CB = New SqlCommandBuilder(DA)

                If DS.Tables("obrazovanje").Rows.Count = 0 Then
                    If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                        DT = DS.Tables("obrazovanje")
                        AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated
                        row = DS.Tables("obrazovanje").NewRow()


                        row.Item("stupanj") = iStupanj
                        row.Item("zanimanje") = txtFZanimanje.Text
                        row.Item("ustanova") = txtFUstanova.Text
                        row.Item("mjesto") = iMjesto
                        row.Item("datumKraj") = dtp.DateTime
                        row.Item("komentar") = txtFKomentar.Text
                        row.Item("oper") = iOper

                        DS.Tables("obrazovanje").Rows.Add(row)
                        DA.Update(DS, "obrazovanje")
                        DA.Dispose()

                        alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
                    End If
                Else
                    If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                        With DS.Tables("obrazovanje")
                            .Rows(0)("stupanj") = iStupanj
                            .Rows(0)("zanimanje") = txtFZanimanje.Text
                            .Rows(0)("ustanova") = txtFUstanova.Text
                            .Rows(0)("mjesto") = iMjesto
                            .Rows(0)("datumKraj") = dtp.DateTime
                            .Rows(0)("komentar") = txtFKomentar.Text
                            .Rows(0)("oper") = iOper
                        End With
                        DA.Update(DS, "obrazovanje")
                        alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
                    End If
                End If



            Case 1
                DA = New SqlDataAdapter("select top 1 * from certifikati where id=" + id.ToString, gCN)
                DA.Fill(DS, "certifikat")
                DT = DS.Tables("certifikat")

                CB = New SqlCommandBuilder(DA)

                If DS.Tables("certifikat").Rows.Count = 0 Then
                    If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                        DT = DS.Tables("certifikat")
                        AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated
                        row = DS.Tables("certifikat").NewRow()

                        row.Item("naziv") = txtCCertifikat.Text
                        row.Item("ustanova") = txtCUstanova.Text
                        row.Item("mjesto") = iMjesto
                        row.Item("datumKraj") = dtpC.DateTime
                        row.Item("upisUknjizicu") = chkCRadnaKnj.CheckState
                        row.Item("komentar") = txtCKomentar.Text
                        row.Item("cijena") = GetReal(txtCCijena.Text)
                        row.Item("oper") = iOper


                        DS.Tables("certifikat").Rows.Add(row)
                        DA.Update(DS, "certifikat")
                        DA.Dispose()

                        alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
                    End If
                Else
                    If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                        With DS.Tables("certifikat")
                            .Rows(0)("naziv") = txtCCertifikat.Text
                            .Rows(0)("ustanova") = txtCUstanova.Text
                            .Rows(0)("mjesto") = iMjesto
                            .Rows(0)("datumKraj") = dtpC.DateTime
                            .Rows(0)("upisUknjizicu") = chkCRadnaKnj.CheckState
                            .Rows(0)("komentar") = txtCKomentar.Text
                            .Rows(0)("cijena") = GetReal(txtCCijena.Text)
                            .Rows(0)("oper") = iOper
                        End With
                        DA.Update(DS, "certifikat")
                        alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
                    End If
                End If



            Case 2

        End Select


    End Sub
#End Region


#Region "Ostalo"

    Private Sub txtCCijena_LostFocus(sender As Object, e As System.EventArgs) Handles txtCCijena.LostFocus
        txtCCijena.Text = FormatCurrency(txtCCijena.Text, 2, TriState.True, TriState.True, TriState.True)
    End Sub

    ''ID nakon unosa
    Private Sub da_Handle_RowUpdated(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue And e.StatementType = StatementType.Insert Then
            e.Row("id") = GetIdentity(e.Command.Connection)
            e.Row.AcceptChanges()
            iID = e.Row("id")
        End If
    End Sub

    Private Function GetIdentity(ByRef cnn As SqlConnection) As Integer
        Dim oCmd As New SqlCommand("SELECT @@IDENTITY", cnn)
        Dim x As Object = oCmd.ExecuteScalar()
        Return CInt(x)
    End Function
#End Region



End Class