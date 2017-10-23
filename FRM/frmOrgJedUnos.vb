#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

#End Region

Public Class frmOrgJedUnos

#Region "Dim's"
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable

    Dim iTvrtka As Integer
    Dim iOrgJed As Integer
    Dim CB As SqlCommandBuilder
    Dim idBroj As Object
#End Region


#Region "Init Form"

    Public Sub New(Optional idOrg As Integer = 0)
        If idOrg > 0 Then
            iOrgJed = idOrg
        End If

        InitializeComponent()
        LocalizeME()
    End Sub

    Private Sub frmOrgJedUnos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillcmbTvrtka()
        FillForm(iOrgJed)
    End Sub

#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click, cmdSave.Click
        Select Case sender.name
            Case "cmdSave"
                Spremi(iOrgJed)
                Me.Dispose()

            Case "cmdExit"
                Me.Dispose()

        End Select

    End Sub
#End Region


#Region "combo-si"
    Private Sub fillcmbTvrtka()
        DA = New SqlDataAdapter("select id,naziv from klijenti", gDATABASE)
        DA.Fill(DS, "klijenti")
        DT = DS.Tables("klijenti")
        DA.Dispose()

        cmbTvrtka.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbTvrtka.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next
        cmbTvrtka.SelectedIndex = 0
        DS.Tables("klijenti").Reset()
    End Sub

    Private Sub cmbTvrtka_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTvrtka.SelectedIndexChanged
        If sender.selectedindex <> Nothing Or sender.selectedindex > -1 Then
            iTvrtka = CType(cmbTvrtka.Properties.Items(sender.selectedindex()), cmbVal).Value
        End If
    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Sub LocalizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)



        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.Enabled = checkSpecial(CTRL)
        Next CTRL
    End Sub


    Private Sub FillForm(id As Integer)
        CM = New SqlCommand
        CM.CommandText = "select *,(select naziv from klijenti where id=orgJed.tvrtka)as sTvrtka from orgJed where id=" + id.ToString

        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "orgJedinica")

        With DS.Tables("orgJedinica")
            iTvrtka = .Rows(0)("tvrtka")
            cmbTvrtka.Text = .Rows(0)("sTvrtka")
            txtNazivSkr.Text = .Rows(0)("orgJed")
            txtNazivFull.Text = .Rows(0)("naziv")
            txtSifra.Text = .Rows(0)("sifra")
            chkAktiv.CheckState = .Rows(0)("aktiv")
        End With
        DA.Dispose()
    End Sub


    Private Sub Spremi(Optional ByVal id As Long = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select * from orgJed where id=" + id.ToString

        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "orgJedinica")

        CB = New SqlCommandBuilder(DA)

        If DS.Tables("orgJedinica").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("orgJedinica")

                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated
                row = DS.Tables("orgJedinica").NewRow()

                row.Item("tvrtka") = iTvrtka
                row.Item("orgJed") = txtNazivSkr.Text
                row.Item("naziv") = txtNazivFull.Text
                row.Item("sifra") = txtSifra.Text
                row.Item("aktiv") = chkAktiv.CheckState

                DS.Tables("orgJedinica").Rows.Add(row)
                DA.Update(DS, "orgJedinica")
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                With DS.Tables("orgJedinica")
                    .Rows(0)("tvrtka") = iTvrtka
                    .Rows(0)("orgJed") = txtNazivSkr.Text
                    .Rows(0)("naziv") = txtNazivFull.Text
                    .Rows(0)("sifra") = txtSifra.Text
                    .Rows(0)("aktiv") = chkAktiv.CheckState
                End With
                DA.Update(DS, "orgJedinica")
                DA.Dispose()

                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        End If

    End Sub

#End Region



#Region "txt_actions"

    Private Sub txt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNazivFull.Validating, txtNazivSkr.Validating, txtSifra.Validating
        ''ako je polje prazno
        Try
            If sender.Text.Length = 0 Then
                DxErrorProvider1.SetError(sender, "Obavezan unos vrijednosti!", ErrorType.Critical)
                'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                DxErrorProvider1.SetIconAlignment(sender, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            Else
                DxErrorProvider1.SetError(sender, String.Empty)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNazivFull.KeyDown, txtNazivSkr.KeyDown, txtSifra.KeyDown
        If e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNazivFull.KeyPress, txtNazivSkr.KeyPress, txtSifra.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNazivFull.GotFocus, txtNazivSkr.GotFocus, txtSifra.GotFocus
        sender.SelectAll()
    End Sub

#End Region


#Region "Ostalo"
    Private Sub da_Handle_RowUpdated(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue And e.StatementType = StatementType.Insert Then
            e.Row("id") = GetIdentity(e.Command.Connection)
            e.Row.AcceptChanges()
            idBroj = e.Row("id")
        End If
    End Sub

    Private Function GetIdentity(ByRef cnn As SqlConnection) As Integer
        Dim oCmd As New SqlCommand("SELECT @@IDENTITY", cnn)
        Dim x As Object = oCmd.ExecuteScalar()
        Return CInt(x)
    End Function
#End Region



End Class