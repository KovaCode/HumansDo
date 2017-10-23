
#Region "imports"
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports System.Threading
Imports System.Globalization
Imports System.Resources
Imports System.Reflection
Imports System.ComponentModel
Imports HumansDo.My.Resources
Imports DevExpress.XtraBars.Alerter
Imports System.Configuration
#End Region

Public Class frmLogin

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

    Sub New()

        'saveconfig("cn", encryptString("Server=SKYNET;Database=humanWorks;User ID=ivan;Password=skyline;Trusted_Connection=False"))
        'saveconfig("skin", "Office 2010 Blue")

        If ReadSetting("setup") = "" Then
            saveconfig("setup", "True")
        End If

        If ReadSetting("jezik") = "" Then
            saveconfig("jezik", "hr-HR")
        End If

        saveconfig("compID", Environment.MachineName.ToString)
        saveconfig("logg", Environment.MachineName.ToString + "_logg.xml")

        If initSetup() = False Then
            initializeSystem()
            'CN = New SqlConnection(gDATABASE)
            'CN.Open()
            'CloseWaitDialog()
            'Dim frm As New frmLogin
            'frm.Show()
        Else
            'CloseWaitDialog()
            Dim frm As New setup
            frm.ShowDialog(Me)

        End If

        InitializeComponent()
        localizeME()
        lblVer.Text = "ver. " + gAPPVER.ToString

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(gSKIN)






        'CreateWaitDialog(rm.GetString("waitCaption0"), rm.GetString("waitTitle"))
        'If initSetup() = False Then
        '    initializeSystem()
        'Else
        '    Dim frm As New setup
        '    frm.Show()
        'End If
        'CloseWaitDialog()

        'saveconfig("cn", encryptString("Server=ERC5N/IVANSQL;Database=humanWorks;User ID=ivan;Password=skyline;Trusted_Connection=False"))
        'saveconfig("skin", "Office 2010 Blue")
        'saveconfig("logg", "logg.xml")
        'saveconfig("jezik", "hr-HR")

    End Sub



    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

#End Region


#Region "Click's"

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnter.Click, cmdExit.Click
        Static cntErrLogin As Integer
        Dim hint As String = ""

        If sender.Equals(cmdEnter) Then
            CreateWaitDialog(rm.GetString("waitCaption2"), rm.GetString("waitTitle"))
            If checkUser() > 0 Then
                If datePassExpiry() = True Then
                    If saveLogin() = True Then
                        SetWaitDialogCaption(rm.GetString("waitCaption3"))
                        Dim frm As New frmMainNew
                        frm.Show()
                        logg("Ulaz u aplikaciju: " + gOperater.ToString + "(" + gOper.ToString + ")")
                    End If
                End If
            Else
                CloseWaitDialog()
                alerter.SHOW(alerter.icona.zabrana, alerter.naslov.Greška, rm.GetString("mess1"))
                cntErrLogin += 1
                If cntErrLogin >= 3 Then
                    hint = iNull(getHint(txtUser.Text).ToString())
                End If
                If hint.Length > 0 Or IsNothing(hint) Then
                    Dim info As New AlertInfo("Više puta unešeni krivi podaci!", "Hint:" + hint.ToString, "", Image.FromFile(Application.StartupPath + "\MISC\ICONS\keys.ico"))
                    Dim ac As New AlertControl
                    ac.Show(Me, info)
                End If

            End If
            CloseWaitDialog()
        Else
            Me.Dispose()
        End If

    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Function checkConfig() As Boolean
        Dim s As String

        s = ReadSetting("cn")
        If s = "" Then checkConfig = False
    End Function


    Private Function getHint(username As String) As String
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As DataTable

        DA = New SqlDataAdapter("select hint from operateri where korisnik ='" + username.ToString + "'", gCN)
        DA.Fill(DS, "hint")

        DT = DS.Tables("hint")
        DA.Dispose() : DS.Dispose()



        If DT.Rows.Count > 0 Then
            getHint = DT.Rows(0)("hint")
        Else
            getHint = ""
        End If


    End Function

    Private Function checkUser() As Integer

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        CM = New SqlCommand("select top 1 id,(ime+' '+prezime)as sOper,pravaCustom,korisnik,lozinka,prava from operateri where lozinka ='" + encryptString(txtPass.Text) + "' and korisnik ='" + txtUser.Text + "'", gCN)
        DR = CM.ExecuteReader


        If DR.HasRows Then
            While DR.Read
                gOper = DR("id")
                gOperater = DR("sOper")
                gUser = DR("korisnik")
                gLogin = txtUser.Text

                'gIP = getExternalIP("http://whatismyip.org/")
                gIP = getIP()
                gPrava = DR("prava")
                gSpecialPrava = DR("pravaCustom")
                If gPrava >= 5 Then
                    flgAdmin = True
                End If

                checkUser = gOper
                'setSkin()
            End While
        Else
            gOperater = "SYSTEM"
            gOper = 0
            checkUser = 0
        End If
        DR.Close()

        CM = New SqlCommand("SELECT id from menuPravaCustom where operater=" + gOper.ToString, gCN)
        DR = CM.ExecuteReader

        If DR.HasRows Then
            gFlgCustomPrava = True
        Else
            gFlgCustomPrava = False
        End If
        DR.Close()


        'MsgBox(PassWordPolicy("sKyL1n3"))
    End Function


    Private Function datePassExpiry() As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        datePassExpiry = True

        DA = New SqlDataAdapter("select dbo.checkPassExp (" + gOper.ToString + ")as passExp", gCN)
        DA.Fill(DS, "checkPassDate")


        If Convert.ToDateTime(DS.Tables("checkPassDate").Rows(0)("passExp")) <= Now.Date Then
            datePassExpiry = False

            Select Case alerter.SHOW(alerter.icona.zabrana, alerter.naslov.System, "Istekla Vam je lozinka|Želite li je sada promijeniti?", alerter.button.DaNeOdustani)
                Case 0
                    CloseWaitDialog()
                    Dim frm As New frmPassChange()
                    frm.ShowDialog(Me)

                Case 1
                    alerter.SHOW(alerter.icona.zabrana, alerter.naslov.System, "Neispravna lozinka!|Izlaz iz aplikacije.")
                    Me.Dispose()
            End Select
        End If

    End Function

    Private Function saveLogin() As Boolean
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim row As DataRow

        CM = New SqlCommand
        CM.CommandText = "select top 1 * from logins where oper=" + gOper.ToString

        DA = New SqlDataAdapter(CM.CommandText, CN)

        Try
            DA.Fill(DS, "logins")


            CB = New SqlCommandBuilder(DA)

            If DS.Tables("logins").Rows.Count = 0 Then
                DT = DS.Tables("logins")

                row = DS.Tables("logins").NewRow()
                row.Item("oper") = gOper
                row.Item("vrijeme") = Now
                row.Item("aktiv") = 1
                row.Item("ip") = gIP
                row.Item("popUp") = 1
                row.Item("checkDef") = "XXXXXX"
                row.Item("skin") = ReadSetting("skin")
                row.Item("jezik") = ReadSetting("jezik")

                DS.Tables("logins").Rows.Add(row)
                DA.Update(DS, "logins")
                DA.Dispose()
            Else
                With DS.Tables("logins")
                    .Rows(0)("oper") = gOper
                    .Rows(0)("vrijeme") = Now
                    .Rows(0)("aktiv") = 1
                    .Rows(0)("ip") = gIP
                    '.Rows(0)("popUp") = gPopUp
                    .Rows(0)("skin") = ReadSetting("skin")
                    .Rows(0)("jezik") = ReadSetting("jezik")
                End With
                DA.Update(DS, "logins")
            End If

            gPopUp = isNull(DS.Tables("logins").Rows(0)("popUp"), 1)
            gActiveTime = DS.Tables("logins").Rows(0)("activeTime")

            'DT.Clear()
            DS.Clear()
            saveLogin = True
        Catch ex As SqlException
            alerter.showErr(ex)
            saveLogin = False
        End Try

    End Function

    Private Sub localizeME()

        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        lblKorisnik.Text = rm.GetString("lblKorisnik")
        lblLozinka.Text = rm.GetString("lblLozinka")
        lblOpis.Text = rm.GetString("lblOpis")
        lblWelcome.Text = rm.GetString("lblWelcome")
        lblKorisnik.Text = rm.GetString("lblKorisnik")
        cmdEnter.Text = rm.GetString("cmdEnter")
        cmdExit.Text = rm.GetString("cmdExit")

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
        Next CTRL
    End Sub

#End Region


#Region "txt_actions"

    Private Sub txtUser_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUser.Validating, txtPass.Validating
        ''ako je polje prazno
        Try
            If sender.Text.Length = 0 Then
                DxErrorProvider1.SetError(sender, rm.GetString("validate1"), ErrorType.Critical)
                'lblOpis.Text = "Nisu unešene sve potrebne vrijednosti!"
                DxErrorProvider1.SetIconAlignment(sender, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            Else
                DxErrorProvider1.SetError(sender, String.Empty)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown, txtUser.KeyDown
        If e.KeyCode = Keys.Down Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        ElseIf e.KeyCode = Keys.Up Then
            SendKeys.Send("+{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress, txtUser.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.GotFocus, txtUser.GotFocus
        sender.SelectAll()
    End Sub

#End Region


    Private Sub cmdSetup_Click(sender As System.Object, e As System.EventArgs) Handles cmdSetup.Click
        If alerter.SHOW(alerter.icona.system, alerter.naslov.System, "Za pristup ovoj opciji potrebna su prava Super administratora!|Nastavak?", alerter.button.DaNe) = 0 Then
            If checkSuperAdmin() = True Then
                Dim frm As New setup
                frm.Show()
            End If
        End If
    End Sub

    Private Function checkSuperAdmin() As Boolean
        checkSuperAdmin = True

        'Dim frm As New frmPassChange(True)
    End Function

End Class