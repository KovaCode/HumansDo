Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask

Public Class alerterInput
    Dim cmdX, cmdX2 As New SimpleButton

    Public Function INPUT(Optional rule As rules = rules.SVE, Optional ikona As icona2 = 0, Optional Title As naslov2 = 0, Optional mess As String = "", Optional value As Object = "", Optional tipke As button2 = 0, Optional defbut As Integer = 0, Optional cancelbut As Integer = 0) As Object
        Dim buts As String
        Dim pic As String
        Dim i As Integer = 0

        ALERTON = False
        INPUT = -1 ' Error
        gOutput = -1

        If ALERTON Then Exit Function
        ALERTON = True

        Me.Text = gAPPNAME + " - " + gAPPVER

        Select Case rule
            Case rules.JMBG
                txtInput.Properties.Mask.IgnoreMaskBlank = False
                txtInput.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
                txtInput.Properties.Mask.MaskType = MaskType.Simple
                txtInput.Properties.Mask.EditMask = "0000000000000"
                txtInput.Properties.Mask.ShowPlaceHolders = False
                txtInput.Properties.Mask.PlaceHolder = ""
                txtInput.Properties.Mask.UseMaskAsDisplayFormat = False
                txtInput.Properties.Mask.AutoComplete = AutoCompleteType.None
                txtInput.Properties.MaxLength = 13

            Case rules.OIB
                txtInput.Properties.Mask.IgnoreMaskBlank = False
                txtInput.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
                txtInput.Properties.Mask.MaskType = MaskType.Simple
                txtInput.Properties.Mask.PlaceHolder = ""
                txtInput.Properties.Mask.ShowPlaceHolders = False
                txtInput.Properties.Mask.EditMask = "00000000000"
                txtInput.Properties.Mask.UseMaskAsDisplayFormat = False
                txtInput.Properties.Mask.AutoComplete = AutoCompleteType.None
                txtInput.Properties.MaxLength = 11

            Case rules.JMBGOIB
                txtInput.Properties.Mask.IgnoreMaskBlank = True
                txtInput.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
                txtInput.Properties.Mask.ShowPlaceHolders = False
                txtInput.Properties.Mask.PlaceHolder = ""
                txtInput.Properties.Mask.MaskType = MaskType.Simple
                txtInput.Properties.Mask.EditMask = "0000000000000"
                txtInput.Properties.Mask.UseMaskAsDisplayFormat = False
                txtInput.Properties.Mask.AutoComplete = AutoCompleteType.None
                txtInput.Properties.MaxLength = 13

            Case rules.JMBGOIBBROJ
                txtInput.Properties.Mask.IgnoreMaskBlank = True
                txtInput.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
                txtInput.Properties.Mask.ShowPlaceHolders = False
                txtInput.Properties.Mask.MaskType = MaskType.Simple
                txtInput.Properties.Mask.EditMask = "0000000000000"
                txtInput.Properties.Mask.UseMaskAsDisplayFormat = False
                txtInput.Properties.Mask.AutoComplete = AutoCompleteType.None
                txtInput.Properties.MaxLength = 13

        End Select

        Select Case Title
            Case naslov2.Aktivacija
                lblTitle.Text = rm.GetString("alertCActivation")
            Case naslov2.Brisanje
                lblTitle.Text = rm.GetString("alertCDelete")
            Case naslov2.Greška
                lblTitle.Text = rm.GetString("alertCError")
            Case naslov2.Informacija
                lblTitle.Text = rm.GetString("alertCInformation")
            Case naslov2.Izlaz
                lblTitle.Text = rm.GetString("alertCExit")
            Case naslov2.Pažnja
                lblTitle.Text = rm.GetString("alertCAttention")
            Case naslov2.Reaktivacija
                lblTitle.Text = rm.GetString("alertCReactivation")
            Case naslov2.Spremanje
                lblTitle.Text = rm.GetString("alertCSave")
            Case naslov2.Testiranje
                lblTitle.Text = rm.GetString("alertCTest")
            Case naslov2.Uređivanje
                lblTitle.Text = rm.GetString("alertCEdit")
            Case naslov2.Validiranje
                lblTitle.Text = rm.GetString("alertCValid")
            Case naslov2.Zaključenje
                lblTitle.Text = rm.GetString("alertCFinal")
            Case naslov2.System
                lblTitle.Text = rm.GetString("System")
            Case naslov2.Files
                lblTitle.Text = rm.GetString("files")
        End Select

        lblMess.Text = " " & Replace(mess, "|", vbCrLf + "  ")

        Select Case ikona
            Case icona2.info
                img.Image = My.Resources.Security___Alert_432
                pic = "i"
            Case icona2.upozorenje
                img.Image = My.Resources.Security___Alert_436
                pic = "!"
            Case icona2.upit
                img.Image = My.Resources.Security___Alert_446
                pic = "?"
            Case icona2.zabrana
                img.Image = My.Resources.Security___Alert_433
                pic = "-"
            Case icona2.greška
                img.Image = My.Resources.Security___Alert_440
                pic = "x"
            Case icona2.system
                img.Image = My.Resources.HAL_9000
                pic = "S"
        End Select


        Select Case tipke
            Case button2.Nastavak
                buts = rm.GetString("alertContinue")
            Case button2.Da
                buts = rm.GetString("alertYes")
            Case button2.Ne
                buts = rm.GetString("alertNo")
            Case button2.Odustani
                buts = rm.GetString("alertCancel")
            Case button2.Spremi
                buts = rm.GetString("alertSave")
            Case button2.Obriši
                buts = rm.GetString("alertDelete")
            Case button2.Otvori
                buts = rm.GetString("alertOpen")
            Case button2.Ispis
                buts = rm.GetString("alertPrint")
            Case button2.Izvoz
                buts = rm.GetString("alertExport")
            Case button2.Izlaz
                buts = rm.GetString("alertExit")
            Case button2.DaNe
                buts = rm.GetString("alertYesNo")
            Case button2.DaNeOdustani
                buts = rm.GetString("alertYesNoCancel")
            Case button2.SpremiNeOdustani
                buts = rm.GetString("alertSaveNoCancel")
            Case button2.SpremiNe
                buts = rm.GetString("alertCSaveNo")
            Case button2.ObrišiOdustani
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
        End Select


        Select Case cancelbut
            Case 0
                Me.CancelButton = cmdX
            Case 1
                Me.CancelButton = cmdX2
        End Select

        txtInput.Text = value

        Me.ShowDialog()

        If txtInput.Text.Length = 13 Then
            If IsNumeric(txtInput.Text) Then
                txtInput.Text = getOsobaJMBG(txtInput.Text)
            End If
        End If


        If txtInput.Text.Length = 11 Then
            If IsNumeric(txtInput.Text) Then
                txtInput.Text = getOsobaOIB(txtInput.Text)
            End If
        End If


        INPUT = txtInput.Text

        gOutput = -1
        logg("INPUT" & pic & ":" & Title & "/" & mess & " Odabrano: " + txtInput.Text)

    End Function


    Private Sub Button_click(sender As Object, e As EventArgs)
        Select Case sender.name
            Case "cmd"
                gOutput = 0
            Case "cmd2"
                gOutput = 1
        End Select
        Me.Dispose()
    End Sub


    Public Enum rules
        SVE = 0
        OIB = 1
        JMBGOIB = 2
        JMBGOIBBROJ = 3
        BROJEVI = 4
        IZNOSI = 5
        PASS = 6
        JMBG = 7
    End Enum

    Public Enum naslov2
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

    Public Enum button2
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

    Public Enum icona2
        info = 0
        upozorenje = 1
        upit = 2
        zabrana = 3
        greška = 4
        system = 5
    End Enum


End Class