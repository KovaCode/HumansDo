#Region "Imports"
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

#End Region

Public Class alerter

#Region "Dim's"
    Dim logmsg As String
    Dim cmdX, cmdX2, cmdX3 As New SimpleButton
#End Region

#Region "Enum's"
    Public Enum naslov
        Informacija = 0
        Spremanje = 1
        Brisanje = 2
        Uređivanje = 3
        Pažnja = 3
        Zaključenje = 4
        Izlaz = 5
        Validiranje = 6
        Aktivacija = 7
        Reaktivacija = 8
        Testiranje = 9
        Greška = 10
        Files = 11
        System = 12
    End Enum

    Public Enum button
        Nastavak = 0
        Da = 1
        Ne = 2
        Odustani = 3
        Spremi = 4
        Obriši = 5
        Otvori = 6
        Ispis = 7
        Izvoz = 8
        Izlaz = 9
        DaNe = 11
        DaNeOdustani = 12
        SpremiNeOdustani = 13
        SpremiNe = 14
        ObrišiOdustani = 15
    End Enum

    Public Enum icona
        info = 0
        upozorenje = 1
        upit = 2
        zabrana = 3
        greška = 4
        system = 5
    End Enum
#End Region


#Region "Click's"

    Private Sub cmdErrDetails_Click(sender As System.Object, e As System.EventArgs) Handles cmdErrDetails.Click
        If Me.Height = 280 Then
            Me.Height = 190
            groupError.Visible = False
            groupError.SendToBack()
        Else
            Me.Height = 280
            groupError.Visible = True
            groupError.BringToFront()
        End If
    End Sub

    Private Sub Button_click(sender As Object, e As EventArgs)
        Select Case sender.name
            Case "cmd"
                gOutput = 0
            Case "cmd2"
                gOutput = 1
            Case "cmd3"
                gOutput = 2
        End Select
        Me.Dispose()
    End Sub

#End Region


#Region "funkcija SHOW"

    Public Function SHOW(Optional ikona As icona = 0, Optional Title As naslov = 0, Optional mess As String = "", Optional tipke As button = 0, Optional defbut As Integer = 0, Optional cancelbut As Integer = 0) As Integer
        Dim buts As String
        Dim pic As String
        Dim i As Integer = 0

        cmdErrDetails.Visible = False
        groupError.Visible = False

        ALERTON = False
        SHOW = -1 ' Error
        gOutput = -1

        If ALERTON Then Exit Function
        ALERTON = True

        Me.Text = gAPPNAME + " - " + gAPPVER

        Select Case Title
            Case naslov.Aktivacija
                lblTitle.Text = rm.GetString("alertCActivation")
            Case naslov.Brisanje
                lblTitle.Text = rm.GetString("alertCDelete")
            Case naslov.Greška
                lblTitle.Text = rm.GetString("alertCError")
            Case naslov.Informacija
                lblTitle.Text = rm.GetString("alertCInformation")
            Case naslov.Izlaz
                lblTitle.Text = rm.GetString("alertCExit")
            Case naslov.Pažnja
                lblTitle.Text = rm.GetString("alertCAttention")
            Case naslov.Reaktivacija
                lblTitle.Text = rm.GetString("alertCReactivation")
            Case naslov.Spremanje
                lblTitle.Text = rm.GetString("alertCSave")
            Case naslov.Testiranje
                lblTitle.Text = rm.GetString("alertCTest")
            Case naslov.Uređivanje
                lblTitle.Text = rm.GetString("alertCEdit")
            Case naslov.Validiranje
                lblTitle.Text = rm.GetString("alertCValid")
            Case naslov.Zaključenje
                lblTitle.Text = rm.GetString("alertCFinal")
            Case naslov.System
                lblTitle.Text = rm.GetString("System")
            Case naslov.Files
                lblTitle.Text = rm.GetString("files")

        End Select


        lblMess.Text = " " & Replace(mess, "|", vbCrLf + "  ")

        Select Case ikona
            Case icona.info
                img.Image = My.Resources.Security___Alert_432
                pic = "i"
            Case icona.upozorenje
                img.Image = My.Resources.Security___Alert_436
                pic = "!"
            Case icona.upit
                img.Image = My.Resources.Security___Alert_446
                pic = "?"
            Case icona.zabrana
                img.Image = My.Resources.Security___Alert_433
                pic = "-"
            Case icona.greška
                img.Image = My.Resources.Security___Alert_440
                pic = "x"
            Case icona.system
                img.Image = My.Resources.HAL_9000
                pic = "S"
        End Select


        Select Case tipke
            Case button.Nastavak
                buts = rm.GetString("alertContinue")
            Case button.Da
                buts = rm.GetString("alertYes")
            Case button.Ne
                buts = rm.GetString("alertNo")
            Case button.Odustani
                buts = rm.GetString("alertCancel")
            Case button.Spremi
                buts = rm.GetString("alertSave")
            Case button.Obriši
                buts = rm.GetString("alertDelete")
            Case button.Otvori
                buts = rm.GetString("alertOpen")
            Case button.Ispis
                buts = rm.GetString("alertPrint")
            Case button.Izvoz
                buts = rm.GetString("alertExport")
            Case button.Izlaz
                buts = rm.GetString("alertExit")
            Case button.DaNe
                buts = rm.GetString("alertYesNo")
            Case button.DaNeOdustani
                buts = rm.GetString("alertYesNoCancel")
            Case button.SpremiNeOdustani
                buts = rm.GetString("alertSaveNoCancel")
            Case button.SpremiNe
                buts = rm.GetString("alertCSaveNo")
            Case button.ObrišiOdustani
                buts = rm.GetString("alertCDeleteNo")
        End Select

        Dim parts As String() = buts.Split(New Char() {"|"c})
        Dim part As String

        For Each part In parts
            Select Case i
                Case 0
                    cmdX = New SimpleButton
                    cmdX.Name = "cmd"
                    cmdX.Text = part
                    AddHandler cmdX.Click, AddressOf Button_click
                    layout2.Left = layout2.Left + 15
                    layout2.Controls.Add(cmdX)

                Case 1
                    cmdX2 = New SimpleButton
                    cmdX2.Name = "cmd2"
                    cmdX2.Text = part
                    AddHandler cmdX2.Click, AddressOf Button_click
                    'layout.ColumnCount = 2
                    layout2.Width = 200
                    layout2.Left = layout2.Left - 80
                    layout2.Controls.Add(cmdX2)

                Case 2
                    cmdX3 = New SimpleButton
                    cmdX3.Name = "cmd3"
                    cmdX3.Text = part
                    AddHandler cmdX3.Click, AddressOf Button_click
                    'layout.ColumnCount = 3
                    layout2.Width = 300
                    layout2.Left = layout2.Left - 80
                    layout2.Controls.Add(cmdX3)

                Case Else
                    'logg("Dozvoljene samo  tri tipke!")
            End Select
            i += 1
        Next

        Select Case defbut
            Case 0
                Me.AcceptButton = cmdX
            Case 1
                Me.AcceptButton = cmdX2
            Case 2
                Me.AcceptButton = cmdX
        End Select


        Select Case cancelbut
            Case 0
                Me.CancelButton = cmdX
            Case 1
                Me.CancelButton = cmdX2
            Case 2
                Me.CancelButton = cmdX3
        End Select

        Me.ShowDialog()

        SHOW = gOutput
        gOutput = -1
        logg("Alert" & pic & ":" & Title & "/" & mess & " Odabrano: " + SHOW.ToString)

    End Function

#End Region


#Region "funkcija ShowErr"

    Public Function showErr(mess As String) As Integer
        Dim buts As String
        Dim pic As String
        Dim i As Integer = 0


        cmdErrDetails.Visible = True
        groupError.Visible = False

        ALERTON = False
        showErr = -1 ' Error
        gOutput = -1

        If ALERTON Then Exit Function
        ALERTON = True

        Me.Text = gAPPNAME + " - " + gAPPVER


        lblTitle.Text = rm.GetString("alertCErr")       ''greška
        lblMess.Text = " " & Replace(mess, "|", vbCrLf + "  ")


        img.Image = My.Resources.Security___Alert_440
        pic = "x"


        buts = rm.GetString("alertContinue")

        cmdX = New SimpleButton
        cmdX.Name = "cmd"
        cmdX.Text = buts.ToString
        AddHandler cmdX.Click, AddressOf Button_click
        layout2.Controls.Add(cmdX)

        Me.ShowDialog()

        showErr = gOutput
        gOutput = -1
        logg("Alert-Error" & pic & ":" + rm.GetString("alertCErr") + "/" & mess)

    End Function
    Public Function showErr(err As Exception) As Integer
        Dim buts As String
        Dim pic As String
        Dim i As Integer = 0
        Dim mess As String
        Dim mess2 As String
        Dim code As Long
        Dim lineNumber As Integer
        Dim source As String
        Dim stackTrace As String
        Dim server As String
        Dim procedure As String
        Dim errCode As String
        Dim type As String
        cmdErrDetails.Visible = True
        groupError.Visible = False

        ALERTON = False
        showErr = -1 ' Error
        gOutput = -1

        If ALERTON Then Exit Function
        ALERTON = True

        Me.Text = gAPPNAME + " - " + gAPPVER


        type = err.GetType.Name

        Select Case type
            Case "SqlException"
                Dim e As SqlException

                e = err
                mess = e.Message.ToString
                code = e.Number
                mess2 = e.Procedure.ToString
                lineNumber = e.LineNumber
                source = e.Source
                stackTrace = e.StackTrace
                server = e.Server.ToString
                procedure = e.Procedure.ToString
                errCode = e.ErrorCode
            Case "ArgumentException"
                Dim e As ArgumentException

                e = err
                mess = e.Message.ToString
                code = e.InnerException.ToString
                lineNumber = e.TargetSite.ToString
                stackTrace = e.StackTrace
        End Select

        lblTitle.Text = rm.GetString("alertCErr")       ''greška
        lblMess.Text = " " & Replace(mess, "|", vbCrLf + "  ")

        groupError.Text = type.ToString + ": " + code.ToString + " - (" + errCode.ToString + ")"
        txtError.Text = "Poruka:   " + mess.ToString + vbCrLf + "Code:     " + code.ToString + vbCrLf + "Procedure:" + procedure + vbCrLf + "Line:     " + lineNumber.ToString + vbCrLf + "Source:   " + source.ToString + vbCrLf + "Trace:    " + stackTrace.ToString


        img.Image = My.Resources.Security___Alert_440
        pic = "x"


        buts = rm.GetString("alertContinue")

        cmdX = New SimpleButton
        cmdX.Name = "cmd"
        cmdX.Text = buts.ToString
        AddHandler cmdX.Click, AddressOf Button_click
        layout2.Controls.Add(cmdX)

        Me.ShowDialog()

        showErr = gOutput
        gOutput = -1
        logg("Alert-Error" & pic & ":" + rm.GetString("alertCErr") + "/" & mess)

    End Function

#End Region


End Class
