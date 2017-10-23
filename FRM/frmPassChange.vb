Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmPassChange

    Dim err As New DXErrorProvider

    Public Sub New(Optional flgUnosPassword As Boolean = False)
        InitializeComponent()
        localizeME()
    End Sub

    Private Sub frmPassChange_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        txtUser.Text = gOperater
    End Sub

    Private Sub spremi()
        Dim di As DateInterval
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim CB As New SqlCommandBuilder

        DA = New SqlDataAdapter("select top 1 id,lozinka,datumIstekaPass,(select period from passPolicy where id=operateri.pol)as period,(select periodType from passPolicy where id=operateri.pol)as periodType from operateri where id=" + gOper.ToString, gCN)

        DA.Fill(DS, "passChange")
        CB = New SqlCommandBuilder(DA)

        Select Case DS.Tables("passChange").Rows(0)("periodType")
            Case 0
                di = DateInterval.Hour
            Case 1
                di = DateInterval.Day
            Case 2
                di = DateInterval.Month
            Case 3
                di = DateInterval.Year
        End Select


        If DS.Tables("passChange").Rows.Count = 1 Then
            With DS.Tables("passChange")
                .Rows(0)("lozinka") = encryptString(txtPass.Text)
                .Rows(0)("datumIstekaPass") = DateAdd(di, .Rows(0)("period"), Now)
            End With
            DA.Update(DS, "passChange")
            alerter.SHOW(alerter.icona.info, alerter.naslov.Spremanje, rm.GetString("mess3"))
        End If

        'DT.Clear()
        DS.Clear() : DA.Dispose()

    End Sub


    Private Sub localizeME()

        Me.Text = gAPPNAME + " - (" + gAPPVER + ")"

        lblKorisnik.Text = rm.GetString("lblKorisnik")
        lblLozinka.Text = rm.GetString("lblLozinka")
        lblLozinka2.Text = rm.GetString("lblLozinka2")
        lblKorisnik.Text = rm.GetString("lblKorisnik")
        cmdSave.Text = rm.GetString("cmdSave")
    End Sub



#Region "txt_actions"

    Private Sub txt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating, txtPass.Validating, txtPass2.Validating
        ''ako je polje prazno
        Dim tip As String

        Try
            If sender.Text.Length = 0 Then
                err.SetError(sender, rm.GetString("validate1"), ErrorType.Critical)
                'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                err.SetIconAlignment(sender, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            Else
                err.SetError(sender, String.Empty)
            End If

            'If txtPass.Text <> txtPass2.Text Then
            '    err.SetError(sender, rm.GetString("validate2"), ErrorType.Critical)
            '    'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
            '    err.SetIconAlignment(txtPass2, ErrorIconAlignment.MiddleRight)
            '    e.Cancel = True
            'Else
            '    err.SetError(sender, String.Empty)
            'End If


            If PassWordPolicy(1, txtPass.Text, tip) Then
                MsgBox(tip)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown, txtUser.KeyDown, txtPass.KeyDown
        If e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress, txtUser.KeyPress, txtPass2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.GotFocus, txtUser.GotFocus, txtPass.GotFocus
        sender.SelectAll()
    End Sub

#End Region

    Private Sub cmdSave_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click
        spremi()
        Me.Dispose()
    End Sub
End Class