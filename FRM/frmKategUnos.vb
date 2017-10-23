#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class frmKategUnos

#Region "Dim's"
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable

    Dim CB As SqlCommandBuilder

    Dim R As Integer
    Dim G As Integer
    Dim B As Integer
    Dim idBroj As Integer
#End Region


#Region "Init Form"
    Public Sub New()
        InitializeComponent()
        localizeME()

        CN = New SqlConnection(gDATABASE)
        CN.Open()
    End Sub


    Public Sub New(ByVal id As Integer)
        InitializeComponent()
        localizeME()

        idBroj = id

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        fillForm(idBroj)
    End Sub
#End Region


#Region "Click's"

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click, cmdExit.Click
        Select Case sender.name
            Case "cmdSave"
                Spremi(idBroj)
                Me.Dispose()

            Case "cmdExit"
                Me.Dispose()
        End Select

    End Sub
#End Region


#Region "procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.enabled = checkSpecial(CTRL)
        Next CTRL

    End Sub

    Private Sub Spremi(Optional ByVal id As Long = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow


        CM = New SqlCommand
        CM.CommandText = "select * from kategorije where id=" + id.ToString

        DA = New SqlDataAdapter(CM.CommandText, gDATABASE)
        DA.Fill(DS, "kategUnos")

        CB = New SqlCommandBuilder(DA)

        If DS.Tables("kategUnos").Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Spremanje, rm.GetString("mess2") + "|" + txtNaziv.Text + "?", alerter.button.SpremiNe) = 0 Then

                DT = DS.Tables("kategUnos")

                AddHandler DA.RowUpdated, AddressOf da_Handle_RowUpdated

                row = DS.Tables("kategUnos").NewRow()
                row.Item("naziv") = txtNaziv.Text
                row.Item("color") = repColor.Text
                row.Item("oper") = gOper
                row.Item("tip") = chkMine.CheckState

                DS.Tables("kategUnos").Rows.Add(row)
                DA.Update(DS, "kategUnos")
                DA.Dispose()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Uređivanje, rm.GetString("mess2"), alerter.button.SpremiNe) = 0 Then
                With DS.Tables("kategUnos")
                    .Rows(0)("naziv") = txtNaziv.Text
                    .Rows(0)("color") = repColor.Text
                    .Rows(0)("oper") = gOper
                    .Rows(0)("tip") = chkMine.CheckState
                End With
                DA.Update(DS, "kategUnos")
                alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If

        End If


    End Sub

    Private Sub fillForm(Optional ByVal id As Integer = 0)
        CM = New SqlCommand("select * from kategorije where id=" + id.ToString, CN)
        DR = CM.ExecuteReader()

        While (DR.Read)
            txtNaziv.Text = DR("naziv")
            repColor.Text = DR("color")
            chkMine.CheckState = iNull0(DR("tip"))
        End While
        DR.Close()
    End Sub
#End Region


#Region "Ostalo"
    Private Sub color_ColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles repColor.ColorChanged
        R = sender.color.R
        G = sender.color.G
        B = sender.color.B
    End Sub

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