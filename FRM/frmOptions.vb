#Region "Imports"
Imports System.Globalization
Imports DevExpress.Skins
Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraGrid.Views.Grid

#End Region

Public Class frmOptions

#Region "Dim's"
    Dim c As CultureInfo
    Dim chk0X As String = ""
    Dim skin As String
    Dim iPassPolicy As Integer
#End Region


#Region "Init Form"

    Dim itab As Integer


    Public Sub New()
        InitializeComponent()
        localizeME()
    End Sub

    Private Sub frmOptions_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim skins As New GalleryDropDown()
        skins.Ribbon = frmMainNew.ribbon
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins)
        DropDownButton1.DropDownControl = skins


        Dim ciHRV As New CultureInfo("hr-HR")
        Dim ciENG As New CultureInfo("en-US")

        ListBox1.Items.Add(ciHRV.NativeName)
        ListBox1.Items.Add(ciENG.NativeName)
        'ListBox1.SelectedIndex = 0

        Select Case gJEZIK
            Case "hr-HR"
                ListBox1.SelectedIndex = 0
            Case "en-US"
                ListBox1.SelectedIndex = 1
        End Select

        If gPopUp = True Then
            chkPopUp.CheckState = CheckState.Checked
        Else
            chkPopUp.CheckState = CheckState.Unchecked
        End If

        txtInactive.Value = gActiveTime / 60000


        fillCheckList()

        setFilter()

        fillcmbPassPolicy()



    End Sub

    Private Sub frmOptions_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdSave.Click, cmdExit.Click, cmdNew.Click

        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdSave"
                    spremiPostavke()
                    alerter.SHOW(alerter.icona.info, alerter.naslov.Informacija, rm.GetString("mess16"))




        End Select

    End Sub

    Private Sub chkPopUp_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPopUp.CheckedChanged
        gPopUp = chkPopUp.CheckState
    End Sub

    Private Sub cmdBrowse_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowse.Click
        Dim frm As New frmPassPolicy
        frm.ShowDialog(Me)
    End Sub

#End Region


#Region "JEZIK"
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            'Dim allCultures As CultureInfo() = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            Dim index As Integer = ListBox1.SelectedIndex

            Select Case ListBox1.SelectedIndex
                Case 0
                    c = New CultureInfo("hr-HR")
                Case 1
                    c = New CultureInfo("en-US")
                Case 2
            End Select


            ' Set Current Application and User Interface Culture

            System.Threading.Thread.CurrentThread.CurrentCulture = c
            System.Threading.Thread.CurrentThread.CurrentUICulture = c

            lblCultureName.Text = rm.GetString("lblCultureName") + c.Name
            lblCultureNameNative.Text = rm.GetString("lblCultureNameNative") + c.NativeName
            lblCultureNameEng.Text = rm.GetString("lblCultureNameEng") + c.EnglishName
            lblCultureNameNeut.Text = rm.GetString("lblCultureNameNeut") + c.TwoLetterISOLanguageName
            lblCultureLang.Text = rm.GetString("lblCultureLang") + c.ThreeLetterISOLanguageName
            lblCultureLangWin.Text = rm.GetString("lblCultureLangWin") + c.ThreeLetterWindowsLanguageName

            ' RegionInfo Object

            Dim r As New RegionInfo(c.Name)

            lblRegionCurrEng.Text = rm.GetString("lblRegionCurrEng") + r.CurrencyEnglishName
            lblRegionCurr.Text = rm.GetString("lblRegionCurr") + r.CurrencySymbol
            lblRegionEng.Text = rm.GetString("lblRegionEng") + r.EnglishName

            ' DateTimeFormatInfo Object is used
            ' to get DayNames and MonthNames

            Dim days As String() = c.DateTimeFormat.DayNames
            ListBox2.Items.Clear()
            For Each day As String In days
                ListBox2.Items.Add(day)
            Next

            Dim months As String() = c.DateTimeFormat.MonthNames
            ListBox3.Items.Clear()
            For Each month As String In months
                ListBox3.Items.Add(month)
            Next

            ' Formatting Currency and Numbers

            lblFullDate.Text = rm.GetString("lblFullDate") + c.DateTimeFormat.FullDateTimePattern
            lblFormatedDate.Text = rm.GetString("lblFormatedDate") + DateTime.Now.ToString("d", c.DateTimeFormat)
            lblFormatedNum.Text = rm.GetString("lblFormatedNum") + 65000.ToString("C", c.NumberFormat)

        Catch ex As Exception
        End Try

        'lblLangMess.Text = "Promjena će uslijediti nakon izlaza iz prozora podešavanja!"

    End Sub
#End Region


#Region "combo-si"

    Private Sub fillcmbPassPolicy()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select * from passPolicy", gCN)
        DA.Fill(DS, "passPol")
        DT = DS.Tables("passPol")
        DA.Dispose()

        cmbPassPol.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbPassPol.Properties.Items.Add(New cmbVal(row("id"), row("policy")))
        Next

        DS.Tables("passPol").Reset()
    End Sub


    Private Sub cmbPassPol_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPassPol.SelectedIndexChanged
        iPassPolicy = CType(sender.selectedItem, cmbVal).Value
    End Sub

#End Region


#Region "procedure i funkcije"

    Private Sub fillCheckList()
        chkStatusList.Items.Add("chkInactive", rm.GetString("chkInactive"))
        chkStatusList.Items.Add("chkWork", rm.GetString("chkWork"))
        chkStatusList.Items.Add("chkValidate", rm.GetString("chkValidate"))
        chkStatusList.Items.Add("chkTest", rm.GetString("chkTest"))
        chkStatusList.Items.Add("chkEnd", rm.GetString("chkEnd"))
        chkStatusList.Items.Add("chkReturned", rm.GetString("chkReturned"))
    End Sub




    Private Sub setFilter()
        Dim x As String
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        DA = New SqlDataAdapter("select checkDEF from logins where oper=" + gOper.ToString, gCN)
        DA.Fill(DS, "checkDef")

        If DS.Tables("checkDef").Rows.Count > 0 Then
            x = DS.Tables("checkDef").Rows(0)("checkDEF")
        End If

        DA.Dispose() : DS.Dispose()

        If Mid(x, 1, 1) = "X" Then
            chkStatusList.Items(0).CheckState = CheckState.Checked
        Else
            chkStatusList.Items(0).CheckState = CheckState.Unchecked
        End If

        If Mid(x, 2, 1) = "X" Then
            chkStatusList.Items(1).CheckState = CheckState.Checked
        Else
            chkStatusList.Items(1).CheckState = CheckState.Unchecked
        End If

        If Mid(x, 3, 1) = "X" Then
            chkStatusList.Items(2).CheckState = CheckState.Checked
        Else
            chkStatusList.Items(2).CheckState = CheckState.Unchecked
        End If

        If Mid(x, 4, 1) = "X" Then
            chkStatusList.Items(3).CheckState = CheckState.Checked
        Else
            chkStatusList.Items(3).CheckState = CheckState.Unchecked
        End If


        If Mid(x, 5, 1) = "X" Then
            chkStatusList.Items(4).CheckState = CheckState.Checked
        Else
            chkStatusList.Items(4).CheckState = CheckState.Unchecked
        End If

        If Mid(x, 6, 1) = "X" Then
            chkStatusList.Items(5).CheckState = CheckState.Checked
        Else
            chkStatusList.Items(5).CheckState = CheckState.Unchecked
        End If

    End Sub

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)

            If CTRL.name <> "tabOptions" Then
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
    End Sub

    Private Sub spremiPostavke()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim DT As New DataTable
        Dim row As DataRow
        Dim CB As New SqlCommandBuilder

        Dim currentSkin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        skin = currentSkin.Name


        DA = New SqlDataAdapter("select top 1 * from logins where oper= " + gOper.ToString, gCN)
        DA.Fill(DS, "postavke")
        DT = DS.Tables("postavke")
        CB = New SqlCommandBuilder(DA)



        If DT.Rows.Count = 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.System, "Želite li spremiti sistemske postavke?", alerter.button.DaNe) = 0 Then
                row = DS.Tables("postavke").NewRow()
                row.Item("jezik") = c.Name
                row.Item("popUp") = gPopUp
                row.Item("checkDef") = chk0X
                row.Item("skin") = skin
                row.Item("activeTime") = txtInactive.Value * 60000

                DS.Tables("postavke").Rows.Add(row)
                DA.Update(DS, "postavke")
                DS.Reset()
                DA.Dispose()

                saveconfig("jezik", c.Name)
                saveconfig("skin", skin)

                alerter.SHOW(alerter.icona.system, alerter.naslov.Spremanje, rm.GetString("mess3"))

            End If

        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.System, "Želite li urediti sistemske postavke?", alerter.button.DaNe) = 0 Then
                With DS.Tables("postavke")
                    .Rows(0)("jezik") = c.Name
                    .Rows(0)("popUp") = gPopUp
                    .Rows(0)("checkDef") = chk0X
                    .Rows(0)("skin") = skin
                    .Rows(0)("activeTime") = txtInactive.Value * 60000
                End With

                DA.Update(DS, "postavke")
                DS.Reset()
                DA.Dispose()

                saveconfig("jezik", c.Name)
                saveconfig("skin", skin)

                alerter.SHOW(alerter.icona.system, alerter.naslov.Spremanje, rm.GetString("mess3"))
            End If
        End If

    End Sub


#End Region

    Private Sub chkStatusList_ItemCheck(sender As Object, e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles chkStatusList.ItemCheck
        chk0X = ""
        For Each chk In chkStatusList.Items
            If chk.checkState = 1 Then
                chk0X = chk0X + "X"
            Else
                chk0X = chk0X + "0"
            End If
        Next
    End Sub


    Private Sub DropDownButton1_Click(sender As System.Object, e As System.EventArgs) Handles DropDownButton1.Click
        Dim currentSkin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        skin = currentSkin.Name

    End Sub

    Private Sub DropDownButton1_StyleChanged(sender As Object, e As System.EventArgs) Handles DropDownButton1.StyleChanged
        Dim currentSkin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        skin = currentSkin.Name
    End Sub

    Private Sub txtInactive_EditValueChanged(sender As Object, e As System.EventArgs) Handles txtInactive.EditValueChanged
        If txtInactive.Value > 0 Then
            gActiveTime = txtInactive.Value * 60000
        End If
    End Sub




    Private Sub tabOptions_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tabOptions.SelectedPageChanged
        itab = tabOptions.SelectedTabPageIndex

    End Sub





End Class



'"chkInactive"
'"chkWork"
'"chkReturned"
'"chkTest"
'"chkValidate"
'"chkEnd"
