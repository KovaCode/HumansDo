#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider
#End Region

Public Class frmNatjecajiU

#Region "Dim's"
    Dim iRadMj As Integer
    Dim iOrgJed As Integer
    Dim iStatus As Integer
    Dim iVrsta As Integer
    Dim idBroj As Integer
    Dim redBroj As Integer
    Dim WithEvents err As New DXErrorProvider

    Dim DT As DataTable
    Dim CM As SqlCommand
    Dim CB As SqlCommandBuilder

    Dim DA As New SqlDataAdapter
    Dim DS As New DataSet
    Dim DT As New DataTable

#End Region


#Region "Init form"


    Public Sub New(Optional id As Integer = 0)
        InitializeComponent()
        localizeME()

        idBroj = id
        If idBroj > 0 Then
            fillData(idBroj)
        End If

    End Sub


    Private Sub frmNatjecajiU_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillCmbRadnoMjesto()
        fillcmbStatusi()
        fillCmbOrgJed()
        fillcmbVrsta()

        If idBroj = 0 Then

            Dim Cm As New SqlCommand("select max(id)as maxID from natjecaji", gCN)
            Dim DR As SqlDataReader

            DR = Cm.ExecuteReader

            While DR.Read
                redBroj = iNull0(DR("maxID")) + 1
            End While
            DR.Close()

            lblNatjecajBroj.Text = redBroj.ToString + "/" + Year(Now).ToString
        Else
            lblNatjecajBroj.Text = idBroj.ToString + "/" + Year(Now).ToString
        End If

    End Sub

#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click, cmdExit.Click, cmdBrowse.Click, cmdBrowse2.Click
        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdSave"
                If chkValues() Then
                    spremi(idBroj)
                End If

            Case "cmdBrowse"    ''radno mjesto

            Case "cmdBrowse2"   ''org.jedinica



        End Select
    End Sub
#End Region


#Region "Combo-si"
    Private Sub fillCmbRadnoMjesto()


        DA = New SqlDataAdapter("select id,naziv from radnoMjesto", gDATABASE)
        DA.Fill(DS, "radMj")

        DT = DS.Tables("radMj")
        DA.Dispose()

        cmbRadnoMjesto.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbRadnoMjesto.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next

        DS.Tables("radMj").Reset()
    End Sub

    Private Sub cmbRadnoMjesto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRadnoMjesto.SelectedIndexChanged
        If IsNothing(sender.selectedindex) = False Or sender.selectedindex > 0 Then
            iRadMj = CType(cmbRadnoMjesto.Properties.Items(sender.selectedindex), cmbVal).Value
        End If
    End Sub


    Private Sub fillCmbOrgJed()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select * from orgJed", gCN)
        DA.Fill(DS, "orgJed")
        DT = DS.Tables("orgJed")
        DA.Dispose()

        cmbOrgJed.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbOrgJed.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next

        DS.Tables("orgJed").Reset()
    End Sub


    Private Sub cmbOrgJed_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOrgJed.SelectedIndexChanged
        iOrgJed = CType(cmbOrgJed.SelectedItem, cmbVal).Value
    End Sub

    Private Sub fillcmbStatusi()
        cmbStatusi.Properties.Items.Clear()
        cmbStatusi.Properties.Items.Add(New cmbVal(1, "Aktivno"))
        cmbStatusi.Properties.Items.Add(New cmbVal(2, "Završeno"))
        cmbStatusi.SelectedIndex = 0

    End Sub


    Private Sub cmbStatusi_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStatusi.SelectedIndexChanged
        iStatus = CType(cmbStatusi.SelectedItem, cmbVal).Value
    End Sub

    Private Sub fillcmbVrsta()

        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select * from vrstaZaposlenja", gCN)
        DA.Fill(DS, "vrstaZaposlenja")
        DT = DS.Tables("vrstaZaposlenja")
        DA.Dispose()

        cmbVrsta.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbVrsta.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next
        cmbVrsta.SelectedIndex = 0

        DS.Tables("vrstaZaposlenja").Reset()

    End Sub


    Private Sub cmbVrsta_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVrsta.SelectedIndexChanged
        iVrsta = CType(cmbVrsta.SelectedItem, cmbVal).Value
    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            Select Case CTRL.GetType.Name
                Case "LabelControl"
                    CTRL.text = rm.GetString(CTRL.name)

                Case "SimpleButton"
                    CTRL.enabled = checkSpecial(CTRL)
                    CTRL.text = rm.GetString(CTRL.name)

            End Select

            'CTRL.foreColor = Color.Black

        Next CTRL
    End Sub

    Private Sub spremi(Optional ByVal id As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select * from natjecaji where id=" + id.ToString

        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "natjecaji")

        CB = New SqlCommandBuilder(DA)

        If DS.Tables("natjecaji").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("natjecaji")
                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated
                row = DS.Tables("natjecaji").NewRow()

                row.Item("naziv") = txtNaziv.Text
                row.Item("radnoMj") = iRadMj
                row.Item("status") = iStatus
                row.Item("pocetak") = dtpOtvaranje.DateTime
                row.Item("planKraj") = dtpPlanirano.DateTime
                row.Item("kraj") = dtpZavrseno.DateTime
                row.Item("orgJed") = iOrgJed
                row.Item("lokacija") = txtLokacija.Text
                row.Item("vrstaZaposl") = iVrsta
                row.Item("opis") = iNull(txtOpis.Text)
                row.Item("oper") = gOper
                row.Item("vrijeme") = Now

                DS.Tables("natjecaji").Rows.Add(row)
                DA.Update(DS, "natjecaji")

                DS.Reset()
                DA.Dispose()

                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4") + getZadatak(id).ToString + " ?", alerter.button.DaNe) = 0 Then
                With DS.Tables("natjecaji")
                    .Rows(0)("naziv") = txtNaziv.Text
                    .Rows(0)("radnoMj") = iRadMj
                    .Rows(0)("status") = iStatus
                    .Rows(0)("pocetak") = dtpOtvaranje.DateTime
                    .Rows(0)("planKraj") = dtpPlanirano.DateTime
                    .Rows(0)("kraj") = dtpZavrseno.DateTime
                    .Rows(0)("orgJed") = iOrgJed
                    .Rows(0)("lokacija") = txtLokacija.Text
                    .Rows(0)("vrstaZaposl") = iVrsta
                    .Rows(0)("opis") = iNull(txtOpis.Text)
                    .Rows(0)("vrijeme") = Now.ToShortTimeString
                    .Rows(0)("oper") = gOper
                End With
                DA.Update(DS, "natjecaji")

                DS.Reset()
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Uređivanje, rm.GetString("mess3"))
            End If
        End If
    End Sub

    Private Function chkValues() As Boolean
        chkValues = True
        For Each ctrl As Control In Me.Controls
            Select Case ctrl.GetType.Name
                Case "TextEdit"
                    If ctrl.Text.Length = 0 Then
                        err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                        err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                        chkValues = False
                    Else
                        err.SetError(ctrl, String.Empty)
                    End If
                Case "ComboBoxEdit"
                    If ctrl.Text = "" Then
                        err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                        err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                        chkValues = False
                    Else
                        err.SetError(ctrl, String.Empty)
                    End If

                Case "DateEdit"
                    If ctrl.Text = "" Then
                        err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                        err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                        chkValues = False
                    Else
                        err.SetError(ctrl, String.Empty)
                    End If

                Case "SpinEdit"
                    If ctrl.Text = "0" Then
                        err.SetError(ctrl, rm.GetString("validate1"), ErrorType.Critical)
                        err.SetIconAlignment(ctrl, ErrorIconAlignment.MiddleRight)
                        chkValues = False
                    Else
                        err.SetError(ctrl, String.Empty)
                    End If

            End Select
        Next







    End Function

    Private Sub fillData(id As Integer)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        DA = New SqlDataAdapter("select *, " _
                                + " (select naziv from radnoMjesto where id=natjecaji.radnoMj)as sRadMjesto, " _
                                + " (select naziv from orgjed where id=natjecaji.orgjed)as odjel, " _
                                + " (select naziv from vrstaZaposlenja where id=natjecaji.vrstaZaposl)as vrstaZaposlenja, " _
                                + " (case status when 1 then 'Aktivno' else 'Neaktivno' end)as sstatus   " _
                                + " from natjecaji where id=" + id.ToString, gCN)

        DA.Fill(DS, "natjecaji")

        With DS.Tables("natjecaji")
            txtNaziv.Text = .Rows(0)("naziv")
            iRadMj = .Rows(0)("radnoMj")
            cmbRadnoMjesto.Text = iNull(.Rows(0)("sRadMjesto"))

            iStatus = .Rows(0)("status")
            cmbStatusi.Text = .Rows(0)("sstatus")

            dtpOtvaranje.DateTime = .Rows(0)("pocetak")
            dtpPlanirano.DateTime = .Rows(0)("planKraj")
            dtpZavrseno.DateTime = .Rows(0)("kraj")

            iOrgJed = .Rows(0)("orgJed")
            cmbOrgJed.Text = .Rows(0)("odjel")

            txtLokacija.Text = .Rows(0)("lokacija")

            iVrsta = .Rows(0)("vrstaZaposl")
            cmbVrsta.Text = .Rows(0)("vrstaZaposlenja")

            txtOpis.Text = .Rows(0)("opis")
        End With

        DS.Reset()
        DA.Dispose()

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
            idBroj = e.Row("id")
        End If
    End Sub
#End Region

End Class