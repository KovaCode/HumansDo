#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

#End Region

Public Class frmMjestaUnos

#Region "Dim's"

    Dim WithEvents err As New DXErrorProvider
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder
    Dim iTab As Integer = 0
    Dim izupanija As Integer
    Dim iMjestoU As Integer
    Dim iMjestoZ As Integer
    Dim iID As Integer
    Dim iTip As Integer
#End Region


#Region "Enum's"
    Enum vrstaZMU
        Sve = 0
        Županija = 1
        Mjesto = 2
        Ulica = 3
    End Enum
#End Region


#Region "Init form"


    Public Sub New(Optional tip As vrstaZMU = vrstaZMU.Sve, Optional id As Integer = 0)
        InitializeComponent()
        localizeME()

        iID = id

        Select Case tip
            Case vrstaZMU.Sve
                tabZupanije.PageVisible = True
                tabMjesta.PageVisible = True
                tabUlice.PageVisible = True
                iTip = 0

            Case vrstaZMU.Županija
                tabZupanije.PageVisible = True
                tabMjesta.PageVisible = False
                tabUlice.PageVisible = False
                iTip = 1

            Case vrstaZMU.Mjesto
                tabZupanije.PageVisible = False
                tabMjesta.PageVisible = True
                tabUlice.PageVisible = False
                iTip = 2

            Case vrstaZMU.Ulica
                tabZupanije.PageVisible = False
                tabMjesta.PageVisible = False
                tabUlice.PageVisible = True
                iTip = 3
        End Select

        If iID > 0 Then
            fillData(iID, iTip)
        End If

    End Sub

    Private Sub frmMjestaUnos_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillCmbZupanije()
        fillCmbMjesta()
    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click, cmdSave.Click
        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdSave"
                'If chkPolja() = True Then
                Select Case iTab
                    Case 0      'zupanija
                        If check(tabZupanije) = True Then
                            SpremiZupaniju(iID)
                            Me.Dispose()
                        End If

                    Case 1      'mjesta
                        If check(tabMjesta) = True Then
                            SpremiZupaniju(iID)
                            Me.Dispose()
                        End If


                    Case 2      'ulice
                        If check(tabUlice) = True Then
                            SpremiZupaniju(iID)
                            Me.Dispose()
                        End If

                End Select
                'End If

        End Select
    End Sub

    Private Sub tab_Selected(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageEventArgs) Handles tab.Selected
        iTab = e.PageIndex
        clearErr(tab.SelectedTabPage)
        resetValues(tab.SelectedTabPage)
        'groupVrste.Text = rm.GetString("groupVrste") + ": (" + e.Page.Text.ToString + ")"
    End Sub

#End Region


#Region "Combo-si"

    Private Sub fillCmbZupanije()
        DA = New SqlDataAdapter("select sifra as id,naziv from zupanije", gDATABASE)
        DA.Fill(DS, "zupanijeCMB")

        DT = DS.Tables("zupanijeCMB")
        DA.Dispose()

        cmbMzupanija.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbMzupanija.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next

        DS.Tables("zupanijeCMB").Reset()
    End Sub
    Private Sub cmbMZupanije_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMzupanija.SelectedIndexChanged
        If sender.selectedindex <> Nothing And sender.selectedindex <> -1 Then
            izupanija = CType(cmbMzupanija.Properties.Items(sender.selectedindex()), cmbVal).Value
        End If
    End Sub


    Private Sub fillCmbMjesta()
        DA = New SqlDataAdapter("select ID,naselje as naziv from mjesta", gDATABASE)
        DA.Fill(DS, "mjestaCmb")

        DT = DS.Tables("mjestaCmb")
        DA.Dispose()

        cmbUmjesta.Properties.Items.Clear()
        cmbZmjesto.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbUmjesta.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
            cmbZmjesto.Properties.Items.Add(New cmbVal(row("id"), row("naziv")))
        Next

        DS.Tables("mjestaCmb").Reset()
    End Sub

    Private Sub cmbUMjesto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUmjesta.SelectedIndexChanged
        If sender.selectedindex <> Nothing And sender.selectedindex <> -1 Then
            iMjestoU = CType(cmbUmjesta.Properties.Items(sender.selectedindex()), cmbVal).Value
        End If
    End Sub

    Private Sub cmbZMjesto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbZmjesto.SelectedIndexChanged
        If sender.selectedindex <> Nothing And sender.selectedindex <> -1 Then
            iMjestoZ = CType(cmbZmjesto.Properties.Items(sender.selectedindex()), cmbVal).Value
        End If
    End Sub



#End Region


#Region "Procedure i funkcije"



    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)

            If CTRL.name <> "tab" Then
                If CTRL.HasChildren Then
                    For i = 0 To CTRL.Controls.Count - 1
                        CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)

                    Next
                End If
            Else
                If CTRL.HasChildren Then
                    For i = 0 To CTRL.Controls.Count - 1
                        CTRL.TabPages(i).Text = rm.GetString(CTRL.TabPages(i).Name)
                    Next
                End If
            End If
        Next CTRL

        tabZupanije.Text = rm.GetString(tabZupanije.Name)
        tabMjesta.Text = rm.GetString(tabMjesta.Name)
        tabUlice.Text = rm.GetString(tabUlice.Name)


    End Sub

    Private Sub fillData(id As Integer, tip As Integer)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        Select Case tip
            Case 1          'Županija
                DA = New SqlDataAdapter("select top 1 * from zupanije where sifra=" + id.ToString, gCN)
                DA.Fill(DS, "Z")

                cmbZmjesto.Text = DS.Tables("Z").Rows(0)("sjediste")
                txtZKratica.Text = DS.Tables("Z").Rows(0)("kratica")
                txtZNaziv.Text = DS.Tables("Z").Rows(0)("naziv")
                txtZsifra.Text = DS.Tables("Z").Rows(0)("sifra")
                DA.Dispose() : DS.Dispose()


            Case 2          'Mjesto
                DA = New SqlDataAdapter("select top 1 *,(select naziv from zupanije where sifra=mjesta.zupanija)as sZupanija from mjesta where id=" + id.ToString, gCN)
                DA.Fill(DS, "M")

                cmbMzupanija.Text = DS.Tables("M").Rows(0)("sZupanija")
                txtMnaziv.Text = DS.Tables("M").Rows(0)("naselje")
                txtMptt.Text = DS.Tables("M").Rows(0)("PTT")
                DA.Dispose() : DS.Dispose()

            Case 3         'Ulice
                DA = New SqlDataAdapter("select top 1 *,(select naselje from mjesta where id=ulice.mjesto)as sMjesto from ulice where br=" + id.ToString, gCN)
                DA.Fill(DS, "U")

                txtUnaziv.Text = DS.Tables("U").Rows(0)("naziv")
                cmbUmjesta.Text = DS.Tables("U").Rows(0)("sMjesto")
                DA.Dispose() : DS.Dispose()
        End Select
    End Sub


    Private Sub resetValues(Container As Control)
        If Not IsNothing(Container) Then
            For Each ctrl In Container.Controls
                If ctrl.GetType.Name = "TextEdit" Then
                    ctrl.text = ""
                ElseIf ctrl.GetType.Name = "ComboBoxEdit" Then
                    ctrl.SelectedIndex = 0
                End If
            Next
        End If
    End Sub

    Private Sub clearErr(Container As Control)
        If Not IsNothing(Container) Then
            For Each ctrl In Container.Controls
                err.SetError(ctrl, String.Empty)
            Next
        End If
    End Sub

    Private Function check(container As Control) As Boolean
        check = True

        For Each tx In container.Controls
            If tx.GetType.Name = "TextEdit" Then
                If tx.Text.Length = 0 Then
                    err.SetError(tx, "Obavezan unos vrijednosti!", ErrorType.Critical)
                    err.SetIconAlignment(tx, ErrorIconAlignment.MiddleRight)
                    check = False
                Else
                    err.SetError(tx, String.Empty)
                End If
            ElseIf tx.GetType.Name = "ComboBoxEdit" Then
                If tx.SelectedIndex = -1 Or tx.SelectedText = "" Then
                    err.SetError(tx, "Obavezan odabir iz padajučeg izbornika!", ErrorType.Critical)
                    err.SetIconAlignment(tx, ErrorIconAlignment.MiddleRight)
                    check = False
                Else
                    err.SetError(tx, String.Empty)
                End If
            End If
        Next
    End Function


    Private Sub SpremiZupaniju(Optional id As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select TOP 1 * from zupanije where id=" + id.ToString
        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "zupanija")
        CB = New SqlCommandBuilder(DA)

        If DS.Tables("zupanija").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("zupanija")

                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated

                row = DS.Tables("zupanija").NewRow()
                row.Item("kratica") = txtZKratica.Text
                row.Item("naziv") = txtZNaziv.Text
                row.Item("sjediste") = iMjestoZ
                row.Item("sifra") = txtZsifra.Text

                DS.Tables("zupanija").Rows.Add(row)
                DA.Update(DS, "zupanija")
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If

        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                With DS.Tables("zupanija")
                    .Rows(0)("kratica") = txtZKratica.Text
                    .Rows(0)("naziv") = txtZNaziv.Text
                    .Rows(0)("sjediste") = iMjestoZ
                    .Rows(0)("sifra") = txtZsifra.Text
                End With

                DA.Update(DS, "zupanija")
                alerter.SHOW(alerter.icona.info, alerter.naslov.Uređivanje, rm.GetString("mess3"))

            End If
        End If
    End Sub

    Private Sub SpremiMjesto(Optional id As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select TOP 1 * from mjesta where id=" + id.ToString
        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "mjesta")
        CB = New SqlCommandBuilder(DA)

        If DS.Tables("mjesta").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("mjesta")
                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated
                row = DS.Tables("mjesta").NewRow()
                row.Item("zupanija") = izupanija
                row.Item("naziv") = txtMnaziv.Text
                row.Item("PTT") = txtMptt

                DS.Tables("mjesta").Rows.Add(row)
                DA.Update(DS, "mjesta")
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If

        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                With DS.Tables("mjesta")
                    .Rows(0)("zupanija") = izupanija
                    .Rows(0)("naziv") = txtMnaziv.Text
                    .Rows(0)("PTT") = txtMptt.Text
                End With

                DA.Update(DS, "mjesta")
                alerter.SHOW(alerter.icona.info, alerter.naslov.Uređivanje, rm.GetString("mess3"))

            End If
        End If
    End Sub


    Private Sub SpremiUlicu(Optional id As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select TOP 1 * from ulice where br=" + id.ToString
        DA = New SqlDataAdapter(CM.CommandText, gCN)
        DA.Fill(DS, "ulice")
        CB = New SqlCommandBuilder(DA)

        If DS.Tables("ulice").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2"), alerter.button.DaNe) = 0 Then
                DT = DS.Tables("ulice")
                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated

                row = DS.Tables("ulice").NewRow()

                row.Item("mjesto") = iMjestoU
                row.Item("naziv") = txtUnaziv.Text

                DS.Tables("ulice").Rows.Add(row)
                DA.Update(DS, "ulice")
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If

        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess4"), alerter.button.DaNe) = 0 Then
                With DS.Tables("ulice")
                    .Rows(0)("mjesto") = iMjestoU
                    .Rows(0)("naziv") = txtUnaziv.Text

                End With

                DA.Update(DS, "ulice")
                alerter.SHOW(alerter.icona.info, alerter.naslov.Uređivanje, rm.GetString("mess3"))

            End If
        End If
    End Sub

    Private Sub fillVal(ByVal id As Integer)
        'CM = CN.CreateCommand()
        'CM.CommandText = "select id,naziv,tezina,napomena,aktiv from vrste where id=" + id.ToString
        'DR = CM.ExecuteReader

        'While DR.Read
        '    txtNaziv.Text = DR("naziv")
        '    track.Value = DR("tezina")
        '    txtNapomena.Text = iNull(DR("Napomena"))
        '    chkAktiv.Checked = DR("aktiv")
        'End While
        'DR.Close()
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

#End Region


#Region "txt-actions"

    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtZNaziv.GotFocus, txtZKratica.GotFocus, txtZsifra.GotFocus, txtMnaziv.GotFocus, txtMptt.GotFocus, txtUnaziv.GotFocus
        sender.SelectAll()
        'lblOpis.Text = ""
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtZNaziv.KeyPress, txtZKratica.KeyPress, txtZsifra.KeyPress, txtMnaziv.KeyPress, txtMptt.KeyPress, txtUnaziv.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtZNaziv.KeyDown, txtZKratica.KeyDown, txtZsifra.KeyDown, txtMnaziv.KeyDown, txtMptt.KeyDown, txtUnaziv.KeyDown
        If e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtZNaziv.Validating, txtZKratica.Validating, txtZsifra.Validating, txtMnaziv.Validating, txtMptt.Validating, txtUnaziv.Validating
        Try
            If sender.Text.Length = 0 Then
                err.SetError(sender, "Obavezan unos vrijednosti!", ErrorType.Critical)
                err.SetIconAlignment(sender, ErrorIconAlignment.MiddleRight)
            Else
                err.SetError(sender, String.Empty)
            End If

        Catch ex As Exception
            alerter.SHOW("x", "Greška!", ex.Message)
        End Try
    End Sub

#End Region


End Class