#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraCharts
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports System.Text.RegularExpressions
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.Threading
Imports DevExpress.XtraReports.Parameters

#End Region


Public Class frmMainNew
    'Implements IMessageFilter

#Region "Dim's"
    Dim CN As SqlConnection
    Dim CM As SqlCommand
    Dim DR As SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim DT2 As DataTable
    Dim chart As ChartControl
    Dim splineChart As ChartControl
    Dim seriesR As Series
    Dim seriesK As Series
    Dim iOper As Object

    Dim rangeBarChart As New ChartControl()
    Dim series1 As New Series("Series 1", ViewType.RangeBar)
    Dim series2 As New Series("Series 2", ViewType.RangeBar)
    Dim seriesSpline As Series

    Dim g As GridView
    Public item As BarButtonItem
    Public item2 As BarStaticItem
    Dim root As TreeListNode

    Dim idTree As Integer = 0
    Dim idTreeOper As Integer = 0
    Dim iZadatak As Integer
    Dim iIzvrsenje As Integer
    Dim timeIzvr As Integer
    Dim iStanje As Integer
    Dim iStatus As Integer
    Dim idRow1 As Integer
    Dim idRow2 As Integer
    Dim idRow3 As Integer
    Dim idRowGrid As Integer
    Dim iZadatakTemp As Integer
    Dim chkStatus As Integer = 7
    Dim SQLStatus As String
    Dim tempStatus As String
    Dim flgTest As Boolean = False
    Dim flgPass As Boolean = False
    Dim iProjekt As Integer
    Dim flgAll As Boolean = False
    Dim frmOper As Integer = gOper

    Dim flgAlertPinned As Boolean = True

#End Region


#Region "Init form"

    Public Sub New()

        InitializeComponent()
        'Timer2.Interval = gActiveTime     ''//900000=15 minuta default
        Timer2.Enabled = True
        'Application.AddMessageFilter(Me)

        localizeME()

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.UserSkins.OfficeSkins.Register()
        'SkinHelper.InitSkinPopupMenu(cmdSkinS)

        Dim skins As New GalleryDropDown()
        skins.Ribbon = ribbon
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins)
        iPaint.DropDownControl = skins

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(gSKIN)
        'setSkin()



    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        CreateIconMenuStructure()
        _trayIcon.Visible = False
        Timer1.Interval = 1000
        Timer1.Enabled = True
        txtOper.Caption = rm.GetString("colOper").ToString + ": " + gOperater.ToString
        gPravaOpis = getPravaOpis(gPrava)
        frmLogin.Dispose()

        setFilter()

        'cmdPoruke.Caption = "Poruke: (" + checkNewTasks().ToString + ")"
        createRibbon()
        createChart()
        createChart2()

        fillGridOperateri()
        checkActiveTasks()

        If gPopUp = True Then
            checkNewProjects()
            checkNewTasks(True)
            setTasks2Acitvate(True)
            checkZadaciTest(True)
            checkMail()
        End If

        fillGridOper()
        podaciSystem()
        createPopUp(0, popUpnaslov.Welcome, rm.GetString("welcomeOper") + " " + gOperater.ToUpper + vbCrLf + rm.GetString("welcomeVer") + " " + gAPPVER.ToString + vbCrLf + rm.GetString("welcomePrava") + " " + gPravaOpis.ToString, "", popUpTipke.None, popUpicona.system, False)

    End Sub

#End Region


#Region "Click's"

    'Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
    'Dim frmT As Form = asm.CreateInstance("HumansDo" + e.Item.Tag)
    'frmT.ShowDialog(Me)

    Private Sub button_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        Select Case e.Item.Name
            Case "menuOper"
                Dim frm As New frmOperateri
                frm.ShowDialog(Me)

            Case "menuPro"
                Dim frm As New frmProjekt
                frm.ShowDialog(Me)
                fillGridOperateri()
                'fillGrid(iZadatak)
                'fillTree(TreeList1)

            Case "menuZad"
                Dim frm As New frmZadatak
                frm.ShowDialog(Me)
                fillGridOperateri()

            Case "menuHistory"
                Dim frm As New frmZadatakHist
                frm.ShowDialog(Me)

            Case "menuIzvr"
                Dim frm As New frmIzvrsenjaPreg()
                frm.ShowDialog(Me)

            Case "menuVrste"
                Dim frm As New frmVrste
                frm.ShowDialog(Me)

            Case "menuKateg"
                Dim frm As New frmKategorije
                frm.ShowDialog(Me)

            Case "menuPrior"
                Dim frm As New frmPrioritet
                frm.ShowDialog(Me)

            Case "menuPassPol"
                Dim frm As New frmPassPolicy
                frm.ShowDialog(Me)

            Case "menuPrava"
                Dim frm As New frmPrava
                frm.ShowDialog(Me)

            Case "menuTezina"
                Dim frm As New frmTezina
                frm.ShowDialog(Me)


            Case "menuKoment"
                Dim frm As New frmKomentari
                frm.ShowDialog(Me)


            Case "menuPrilog"
                Dim frm As New frmFilesExt
                frm.ShowDialog(Me)

            Case "menuPrilog"
                'Dim frm As New frmPrilog
                'frm.ShowDialog(Me)

            Case "menuPlanner"
                Dim frm As New frmPlanner
                frm.ShowDialog(Me)

            Case "menuTasks"
                Dim frm As New frmTasks
                frm.ShowDialog(Me)

            Case "menuLogg"
                Dim frm As New frmLoggPreview
                frm.ShowDialog(Me)

            Case "menuScripta"
                CreateWaitDialog(rm.GetString("waitCaption4"), rm.GetString("waitTitle"))
                Dim frm As New frmSCRIPT()
                CloseWaitDialog()
                frm.ShowDialog(Me)

            Case "menuCalc"
                System.Diagnostics.Process.Start("calc")

            Case "menuRemote"
                System.Diagnostics.Process.Start("mstsc")

            Case "menuNotes"
                'System.Diagnostics.Process.Start("StikyNot")

            Case "menuNotepad"
                System.Diagnostics.Process.Start("notepad")

            Case "menuAbout"
                CreateWaitDialog(rm.GetString("waitCaption5"), rm.GetString("waitTitle"))
                Dim frm As New frmSytemInfo
                CloseWaitDialog()
                frm.ShowDialog(Me)

            Case "menubuSQL"
                CreateWaitDialog(rm.GetString("waitCaption6"), rm.GetString("waitTitle"))
                Dim frm As New frmSQL
                CloseWaitDialog()
                frm.ShowDialog(Me)

            Case "menuChat"
                Dim frm As New frmChat
                frm.ShowDialog(Me)

            Case "menuHelp"
                Dim frm As New frmWorkInProgress
                'Dim frm As New frmHelpdesk
                frm.ShowDialog(Me)

            Case "menuPrint"
                Dim frm As New frmPrint(grid, rm.GetString("pregledZadatka") + Now.ToShortDateString, True)
                frm.ShowDialog(Me)

            Case "menuClient"
                Dim frm As New frmClients
                frm.ShowDialog(Me)

            Case "menuMyDocs"
                System.Diagnostics.Process.Start("explorer.exe", gMYDOCS)

            Case "menuOptions"
                Dim frm As New frmOptions
                frm.ShowDialog(Me)
                removePages()
                createRibbon()
                localizeME()

            Case "menuOrgJed"
                Dim frm As New frmOrgJed
                frm.ShowDialog(Me)

            Case "menuAboutApp"
                Dim frm As New frmAbout
                frm.ShowDialog(Me)

            Case "menuExit"
                If Izlaz() = True Then
                    Me.Dispose() : End
                End If

            Case "menuMjesta"
                Dim frm As New frmMjesta
                frm.ShowDialog(Me)

            Case "menuSatnica"
                Dim frm As New frmSatnica
                frm.ShowDialog(Me)

            Case "menuStatusi"
                Dim frm As New frmStatus
                frm.ShowDialog(Me)

            Case "menuUpute"
                Dim tempPathManual As String
                tempPathManual = gManualPath + "\" + gAPPNAME.ToString + " - upute v." + gAPPVER.ToString + ".pdf"
                If fileExists(tempPathManual) = True Then
                    System.Diagnostics.Process.Start(tempPathManual)
                Else
                    alerter.SHOW(alerter.icona.greška, alerter.naslov.Files, "Datoteka nedostaje!")
                End If

            Case "menuPassPolicyPreview"
                Dim frm As New frmPassPolicyPreg
                frm.ShowDialog(Me)

            Case "menuDailyPreg"
                Dim frm As New frmOperWorkToday
                frm.ShowDialog(Me)

            Case "menuStatOP"
                Dim frm As New frmOperStat
                frm.ShowDialog(Me)

            Case "menuBolovanje"
                Dim frm As New frmBolovanje
                frm.ShowDialog(Me)

            Case "menuObrazovanje"
                gValue = iNull0(alerterInput.INPUT(alerterInput.rules.JMBGOIBBROJ, alerterInput.icona2.upit, alerterInput.naslov2.Validiranje, "Unesite JMBG ili OIB", 0))
                If gValue > 0 Then
                    Dim frm As New frmObrazovanje(gValue)
                    frm.ShowDialog(Me)
                End If

            Case "menuNatjecaji"
                Dim frm As New frmNatjecaji()
                frm.ShowDialog(Me)

            Case "menuSatnicaTvrtke"
                Dim frm As New frmSatnicaTvrtke()
                frm.ShowDialog(Me)

            Case "menuRadnoMj"
                Dim frm As New frmRMJKatalog
                frm.ShowDialog(Me)


        End Select
    End Sub

    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdOvjeri.Click, cmdPoruke.ItemClick, cmdActivate.Click, cmdEndIzvr.Click, cmdTest.Click
        Select Case sender.name
            Case "cmdOvjeri"
                Dim frm As New frmVerify(iZadatak)
                frm.ShowDialog(Me)

            Case "cmdPoruke"
                Dim frm As New frmMessage
                frm.ShowDialog(Me)

            Case "cmdActivate"
                aktivirajIzvrsenje(iZadatak)


            Case "cmdEndIzvr"
                EndIzvrsenje()

            Case "cmdTest"
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Testiranje, rm.GetString("MESS9") + "|""" + getZadatak(iZadatak).ToString + """?", alerter.button.DaNe) = 0 Then
                    gIzvrsenje = startIzvrsenje(iZadatak, "***TEST***", rm.GetString("dodTesiranje"), 0, 1)
                    gZadatak = Izvrsenje2Zad(gIzvrsenje)
                    dodajIzvrsenjeStatuBar(iZadatak, True)
                    setStatusZad(27, iZadatak)
                    fillGrid()

                    Dim frm As New frmZadTest(iZadatak)
                    frm.ShowDialog(Me)
                    krajIzvrsenje(gIzvrsenje, rm.GetString("testZavrsen"), 100)
                    izbaciIzvrRibbon()
                    gIzvrsenje = 0
                    gZadatak = 0
                End If
        End Select

    End Sub

    Private Sub txtNow_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles txtNow.ItemClick
        Dim frm As New frmClock
        frm.ShowDialog(Me)
    End Sub

    Private Sub cmdMessages_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdMessages.ItemClick
        Dim frm As New frmMessage
        frm.ShowDialog(Me)
    End Sub

    Private Sub cmdInfo_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdInfo2.ItemClick
        Dim frm As New frmSytemInfo
        frm.ShowDialog(Me)
    End Sub

    Private Sub chk_CheckedChanged(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkInactive.CheckedChanged, chkWork.CheckedChanged, chkValidate.CheckedChanged, chkEnd.CheckedChanged, chkTest.CheckedChanged, chkReturned.CheckedChanged
        If IsNothing(CN) = False Then
            fillGrid(iProjekt)
        End If
    End Sub

    Private Sub cmdRefresh_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRefresh.ItemClick
        CreateWaitDialog("Osvježavam", rm.GetString("waitTitle"))
        checkNewProjects()
        checkNewTasks()
        setTasks2Acitvate()
        checkZadaciTest()
        checkMail()
        fillGrid(iProjekt)
        CloseWaitDialog()
    End Sub

#End Region


#Region "SYSTEM"

    Public Structure LASTINPUTINFO
        Public cbSize As Int32
        Public dwTime As Int32

    End Structure

    Declare Function GetLastInputInfo Lib "User32.dll" (ByRef plii As LASTINPUTINFO) As Boolean

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim LII As New LASTINPUTINFO, TicksSinceLastInput As Int32 = 0


        'size the return buffer...
        LII.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(LII)

        'call the function and store the result...
        If GetLastInputInfo(LII) Then TicksSinceLastInput = (Environment.TickCount - LII.dwTime)

        ' For demo purposes I'm writing the ticks value to the output window. Of course you won't need to do this; you can just check for the count exceeding a certain value and then taking action accordingly (but it's useful to see in the Output that it's working)
        Console.WriteLine(TicksSinceLastInput.ToString)

        If TicksSinceLastInput >= gActiveTime Then
            'Timer2.Stop()

            'Console.WriteLine(TicksSinceLastInput.ToString)

            If gIzvrsenje > 0 Then
                logg("SYSTEM: gasim izvršenje radi neaktivnosti!")
                krajIzvrsenje(gIzvrsenje, "SYSTEM: gasim izvršenje radi neaktivnosti!", 0)
                setStatusZad(24, gZadatak)
                izbaciIzvrRibbon()
                gIzvrsenje = 0
                gZadatak = 0
                gProjekt = 0
                Dim tempTime As Integer = (gActiveTime / 60000)

                createPopUp(0, popUpnaslov.System, "Gasim izvršenje radi neaktivnosti u periodu od " + tempTime.ToString + " min.!", , popUpTipke.None, popUpicona.system, True)
                fillGrid()
            ElseIf TicksSinceLastInput = 1800000 Then    'pola sata
                createPopUp(0, popUpnaslov.System, "NEAKTIVNOST U PERIODU OD 30min!", , popUpTipke.None, popUpicona.system, True)
                logg("NEAKTIVNOST od 30min!")
            ElseIf TicksSinceLastInput = 3600000 Then    'sat
                createPopUp(0, popUpnaslov.System, "NEAKTIVNOST U PERIODU OD 1h!", , popUpTipke.None, popUpicona.system, True)
                logg("NEAKTIVNOST od 1h, Obavještavam nadređene!")
            End If

        End If
    End Sub

    'Public Structure LASTINPUTINFO
    '    Public cbSize As Int32
    '    Public dwTime As Int32

    'End Structure


    'Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
    '    Dim mouse As Boolean = (m.Msg >= &H200 And m.Msg <= &H20D) Or (m.Msg >= &HA0 And m.Msg <= &HAD)
    '    Dim kbd As Boolean = (m.Msg >= &H100 And m.Msg <= &H109)


    '    If mouse Or kbd Then
    '        If Not Timer2.Enabled Then Console.WriteLine("Waking up")
    '        Timer2.Enabled = False
    '        Timer2.Enabled = True
    '    End If
    'End Function

    'Private Sub AppInactive(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
    '    Timer2.Enabled = False
    '    Console.WriteLine("Going to sleep")

    '    If gIzvrsenje > 0 Then
    '        logg("SYSTEM: gasim izvršenje radi neaktivnosti!")
    '        krajIzvrsenje(gIzvrsenje, "SYSTEM: gasim izvršenje radi neaktivnosti!", 0)
    '        setStatusZad(24, gZadatak)
    '        izbaciIzvrRibbon()
    '        gIzvrsenje = 0
    '        gZadatak = 0
    '        gProjekt = 0
    '        createPopUp(0, popUpnaslov.System, "Gasim izvršenje radi neaktivnosti u periodu od 15 min.!", , popUpTipke.None, popUpicona.system, True)
    '        fillGrid()
    '    End If

    'End Sub

    Private Sub Timer1_Tick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static timeMess As Integer = 0

        If timeMess = 120 Then  ''svakih 5 minuta
            checkNewProjects()
            checkNewTasks()
            setTasks2Acitvate()
            checkZadaciTest()
            checkMail()
            fillGrid(iProjekt)
            timeMess = 0
        End If

        If IsNothing(item2) = False Then
            timeIzvr += 1
            item2.Caption = "(" + GetTime(timeIzvr).ToString + ")"
        Else
            timeIzvr = 0
        End If

        txtNow.Caption = DateTime.Now.ToLongDateString + " - " + DateTime.Now.ToLongTimeString()
        timeMess += 1
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Izlaz() = False Then
            e.Cancel = True
        Else
            Me.Dispose() : End
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        Me._trayIcon.Visible = (Me.WindowState = FormWindowState.Minimized)
        MyBase.OnResize(e)
    End Sub

    Private Sub Form_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            Me._trayIcon.Visible = True
            'createPopUp(gAPPNAME.ToUpper, "Aplikacija je smanjena u tray, te se može tu povratiti na desni klik!", "", "", "")
            createPopUp(0, popUpnaslov.System, rm.GetString("popUpTray"), , popUpTipke.None, popUpicona.system, False)
        End If
    End Sub

    ''DESNI KLIK u TRAY-u

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.Name

            Case "cmdOpen"
                Me.Visible = True
                Me.WindowState = FormWindowState.Normal
                Me._trayIcon.Visible = True

            Case "cmdExit"
                If Izlaz() = True Then
                    Me.Dispose() : End
                End If


        End Select
    End Sub

    Public Sub CreateIconMenuStructure()
        _trayIcon.Visible = True
        _trayIcon.Text = "HumansDO"
    End Sub

#End Region


#Region "Ribbon"

    Friend Sub createRibbon()
        Dim CM As New SqlCommand
        Dim DR As SqlDataReader

        Dim page As New RibbonPage
        Dim group As New RibbonPageGroup
        Dim menu As New BarSubItem
        Dim button As New BarButtonItem
        Dim subButton As New BarButtonItem
        Dim links As New BarLinkContainerItem

        'ribbon.Dispose()

        CM = gCN.CreateCommand()
        If gFlgCustomPrava = False Then
            CM.CommandText = "select isnull(rp.prava,'True')prava,r.butGroup,r.id,r.naziv,r.tip,r.red,r.forma,r.iconSize,r.ctrl,r.grupa,r.image " _
                            + " from ribbonMenu r left outer join ribbonMenuPrava rp on r.id=rp.idRibbon where rp.veza=" + gPrava.ToString + " " _
                            + " order by r.grupa,r.veza,r.red"
        Else
            CM.CommandText = "select isnull(rp.prava,'True')prava,r.butGroup,r.id,r.naziv,r.tip,r.red,r.forma,r.iconSize,r.ctrl,r.grupa,r.image " _
                    + " from ribbonMenu r left outer join MenuPravaCustom rp on r.id=rp.idRibbon where rp.grupa=" + gPrava.ToString + " " _
                    + " order by r.grupa,r.veza,r.red"
        End If
        Try
            DR = CM.ExecuteReader

            While (DR.Read)
                Select Case DR("tip")
                    Case 0      'page
                        page = New RibbonPage(DR("Naziv"))
                        page.Name = DR("ctrl")
                        page.Text = rm.GetString(DR("ctrl"))
                        ribbon.Pages.Add(page)

                    Case 1      'group
                        group = New RibbonPageGroup(DR("Naziv"))
                        group.Name = DR("ctrl")
                        group.ShowCaptionButton = False
                        group.AllowTextClipping = False
                        group.Text = rm.GetString(DR("ctrl"))
                        page.Groups.Add(group)

                    Case 2      'button group 
                        menu = New BarSubItem(ribbon.Manager, DR("Naziv"))
                        menu.Name = DR("ctrl")
                        menu.Caption = rm.GetString(DR("ctrl"))
                        If iNull0(DR("image")) > 0 Then
                            If DR("iconSize") = False Then
                                menu.ImageIndex = DR("image")
                            Else
                                menu.LargeImageIndex = DR("image")
                            End If
                        End If
                        group.ItemLinks.Add(menu)


                    Case 3      'button
                        button = New BarButtonItem(ribbon.Manager, DR("Naziv"))
                        button.Name = DR("ctrl")
                        button.Caption = rm.GetString(DR("ctrl"))
                        button.Tag = DR("forma").ToString
                        If iNull0(DR("image")) > 0 Then
                            If DR("iconSize") = False Then
                                button.ImageIndex = DR("image")
                            Else
                                button.LargeImageIndex = DR("image")
                            End If
                        End If


                        If DR("prava") = True Then
                            button.Enabled = True
                        Else
                            button.Enabled = False
                        End If

                        AddHandler button.ItemClick, AddressOf button_ItemClick
                        If DR("butGroup") = True Then
                            group.ItemLinks.Add(button).BeginGroup = True
                        Else
                            group.ItemLinks.Add(button)
                        End If


                    Case 4      'sub button
                        subButton = New BarButtonItem(ribbon.Manager, DR("Naziv"))
                        subButton.Name = DR("ctrl")
                        subButton.Caption = rm.GetString(DR("ctrl"))
                        If iNull0(DR("image")) > 0 Then
                            If DR("iconSize") = False Then
                                subButton.ImageIndex = DR("image")
                            Else
                                subButton.LargeImageIndex = DR("image")
                            End If
                        End If
                        AddHandler button.ItemClick, AddressOf button_ItemClick
                        menu.ItemLinks.Add(subButton)

                End Select
            End While

        Catch ex As Exception
            alerter.showErr(ex)
        End Try
        DR.Close()

        RibbonPage1.Visible = False
    End Sub

    Friend Sub removePages()
        For i = 0 To ribbon.Pages.Count - 1
            ribbon.Pages.RemoveAt(0)
        Next
    End Sub

#End Region


#Region "gridOper"

    Private Sub fillGridOperateri()
        Dim DA As SqlDataAdapter
        Dim DS As New DataSet
        Dim tempID As Integer
        Dim RowHandle As Integer

        If iProjekt > 0 Then
            tempID = iProjekt
        End If

        If DS.Tables.IndexOf("gridOperateri") > -1 Then
            DS.Tables("gridOperateri").Clear()
        End If

        If flgAll = False Then
            DA = New SqlDataAdapter("select distinct dbo.getprojekt(dbo.getZad2Projekt(zadatak))naziv, " _
                                        + " dbo.getZad2Projekt(zadatak)id, dbo.getVrsta(vrsta)sVrsta, " _
                                        + " dbo.getOsoba(oper)as sOsoba,oper " _
                                        + " from vezazadoper where oper = " + frmOper.ToString + " and zadatak <> 0 group by dbo.getZad2Projekt(zadatak),oper,vrsta,zadatak", gCN)
        Else
            DA = New SqlDataAdapter("select distinct dbo.getprojekt(dbo.getZad2Projekt(zadatak))naziv, " _
                                        + " dbo.getZad2Projekt(zadatak)id, dbo.getVrsta(vrsta)sVrsta, " _
                                        + " dbo.getOsoba(oper)as sOsoba,oper " _
                                        + " from vezazadoper where zadatak <> 0 group by dbo.getZad2Projekt(zadatak),oper,vrsta,zadatak", gCN)
        End If

        Try
            DA.Fill(DS, "gridOperateri")
        Catch e As SqlException
            alerter.showErr("gridOper - " + e.Message)
        End Try

        gridOper.DataSource = DS.Tables("gridOperateri")

        If tempID = 0 Then
            gridViewOper.MoveBy(-1)
        Else
            gridViewOper.MoveBy(GetRowHandleByColumnValue(gridViewOper, colID, tempID))
        End If



    End Sub


    Private Sub gridOper_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewOper.FocusedRowChanged
        gridOper.DefaultView.GetRow(e.FocusedRowHandle)

        iProjekt = gridViewOper.GetRowCellValue(e.FocusedRowHandle, colIDOper)
        iOper = gridViewOper.GetRowCellValue(e.FocusedRowHandle, colOper)

        If iOper = 0 Then
            frmOper = gOper
        Else
            frmOper = iOper
        End If


        fillGrid(iProjekt)
    End Sub


    Private Function GetRowHandleByColumnValue(ByVal view As GridView, ByVal column As DevExpress.XtraGrid.Columns.GridColumn, ByVal value As Object) As Integer
        Dim result As Integer = GridControl.InvalidRowHandle
        Dim red As Integer

        red = view.LocateByDisplayText(0, column, value)
        red = red + view.GroupCount

        view.MoveBy(red)

    End Function

    ''menu na desni klik
    Private Sub gridViewOper_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridViewOper.PopupMenuShowing
        Dim View As GridView = CType(sender, GridView)

        If e.HitInfo.InRow Then
            g = grid2View
            rightClickMenu.Show(View.GridControl, e.Point)
        End If
    End Sub

    'prikaz svih operatera
    Private Sub chkAll_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkAll.CheckedChanged
        If chkAll.CheckState = CheckState.Checked Then
            flgAll = True
            frmOper = iOper
            fillGridOperateri()

        Else
            flgAll = False
            frmOper = gOper
            fillGridOperateri()
        End If
    End Sub

#End Region


#Region "grid - zadaci"

    Private Sub fillGrid(Optional ByVal projekt As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim tempID As Integer
        Dim RowHandle As Integer

        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If


        If iZadatak > 0 Then
            tempID = iZadatak
        End If


        SQLStatus = ""
        tempStatus = ""

        If chkInactive.Checked = True Then
            If tempStatus = "" Then
                tempStatus = "0,-201"
            Else
                tempStatus = tempStatus + ",0,-201"
            End If
        End If

        If chkWork.Checked = True Then
            If tempStatus = "" Then
                tempStatus = "3,24,20"
            Else
                tempStatus = tempStatus + ",3,24,20"
            End If
        End If

        If chkValidate.Checked = True Then
            If tempStatus = "" Then
                tempStatus = "-202,-100"
            Else
                tempStatus = tempStatus + ",-202,-100"
            End If
        End If

        If chkTest.Checked = True Then
            If tempStatus = "" Then
                tempStatus = "27,31,28"
            Else
                tempStatus = tempStatus + ",27,31,28"
            End If
        End If

        If chkEnd.Checked = True Then
            If tempStatus = "" Then
                tempStatus = "-100,-101,100,26"
            Else
                tempStatus = tempStatus + ",-100,-101,100"
            End If
        End If

        If chkReturned.Checked = True Then
            If tempStatus = "" Then
                tempStatus = "-2,-3,-4,-10"
            Else
                tempStatus = tempStatus + ",-2,-3,-4,-10"
            End If
        End If

        If projekt = 0 Then

            If tempStatus = "" Then
                SQLStatus = ""
            Else
                SQLStatus = "and dbo.getZadStatus(z.id," + gOper.ToString + ") in (" + tempStatus.ToString + ")"
            End If

            DA = New SqlDataAdapter("select z.id,z.naziv as zadatak,dbo.getStatus(zo.zadStatus)vezstatusOpis, " _
                                  + " zo.zadStatus,dbo.getProjekt(z.projekt)sProjekt, " _
                                  + " dbo.getPrioritet(z.prioritet)prioritet, " _
                                  + " (select vrijednost from prioritet where ID=z.prioritet)as iPrior, " _
                                  + " dbo.getUkupVrimIzvrsenja(z.id," + frmOper.ToString + ")as vrimIzvr, " _
                                  + " dbo.getTimeDiffSec(datediff(SECOND,vrijemeOD,vrijemeDo))as zadVrim, " _
                                  + " (select zadatak from vezazadOper where zadStatus=3 and oper=" + frmOper.ToString + ")aktivZad, " _
                                  + " z.vrijemeOD,vrijemeDO,dbo.getOsoba(z.voditelj)as voditelj, " _
                                  + " isnull(dbo.getUkVrijemeIzvr(z.id),'00:00:00')as VrijemeI " _
                                  + " from zadaci z JOIN vezaZadOper zo ON z.id=zo.zadatak  where zo.oper=" + gOper.ToString + SQLStatus.ToString, gCN)
        Else

            If tempStatus = "" Then
                SQLStatus = ""
            Else
                SQLStatus = "and dbo.getZadStatus(z.id," + frmOper.ToString + ") in (" + tempStatus.ToString + ")"
            End If

            DA = New SqlDataAdapter("select z.vrijemeOD,vrijemeDO,z.projekt,z.id,z.naziv as zadatak,dbo.getProjekt(z.projekt)sProjekt, " _
                        + " zo.oper,zo.zadStatus,(DBO.TIMEFORMAT(VRIJEMEod,VRIJEMEdO))as ukupZad, " _
                        + " dbo.getUkupVrimIzvrsenja(z.id," + frmOper.ToString + ") vrimIzvr, " _
                        + " (select ime +' '+ prezime from operateri where id=z.voditelj)voditelj, " _
                        + " (select naziv from prioritet where id=z.prioritet)prioritet, " _
                        + " (select vrijednost from prioritet where ID=z.prioritet)as iPrior, " _
                        + " dbo.getTimeDiffSec(datediff(SECOND,vrijemeOD,vrijemeDo))as zadVrim, " _
                        + " (select zadatak from vezazadOper where zadStatus=3 and oper=" + frmOper.ToString + ")aktivZad, " _
                        + " (dbo.getUkVrijemeIzvr(z.id))as VrijemeI, " _
                        + " (select zadStatus from vezaZadOper where zadatak = z.id and oper=" + frmOper.ToString + ") vezStatus, " _
                        + " dbo.getStatus((select zadStatus from vezaZadOper where zadatak = z.id and oper=" + frmOper.ToString + ")) vezstatusOpis " _
                        + " from zadaci z JOIN vezaZadOper zo ON z.id=zo.zadatak where zo.oper=" + frmOper.ToString + "  " _
                        + " and z.projekt=" + projekt.ToString + SQLStatus + " and z.aktiv=1", gCN)
        End If

        Try
            DA.Fill(DS, "grid")
        Catch e As Exception
            'alerter.SHOW("x", "Greška", e.Message)
            alerter.showErr("grid-" + e.Message)
        End Try

        If projekt > 0 Then
            lblUkupnoP.Text = getProjektTime(projekt)
        End If

        grid.DataSource = DS.Tables("grid")
        gridView.OptionsPrint.UsePrintStyles = True
        gridView.OptionsPrint.EnableAppearanceEvenRow = True
        gridView.AppearancePrint.EvenRow.BackColor = Color.LightYellow
        gridView.SetRowExpanded(-1, True)
        gridView.SetRowExpanded(-2, True)

        'RowHandle = gridView.LocateByDisplayText(-1, col, tempID)


        If tempID = 0 Then
            gridView.MoveBy(-1)
        Else
            GetRowHandleByColumnValue(gridView, col, tempID)
        End If

        'DS.Clear() : DS.Dispose()
    End Sub



    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged

        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iZadatak = iNull0(gridView.GetRowCellValue(e.FocusedRowHandle, col))
        iStatus = gridView.GetRowCellValue(e.FocusedRowHandle, colStatus)

        changeButtons(iStatus)

        lblUkupnoI.Text = iNullTime(getGridVal(gridView, colUtrosenoo))

        If e.FocusedRowHandle >= 0 Then
            lblUkupnoZ.Text = iNullTime(getGridVal(gridView, colVrijemeZad))
        End If

        fillGrid2(iZadatak)
        createChart(iZadatak)
        createChart2(iZadatak)
    End Sub




    ''menu na desni klik
    Private Sub gridView_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gridView.PopupMenuShowing
        Dim View As GridView = CType(sender, GridView)
        If e.HitInfo.InRow Then
            g = gridView
            rightClickMenu.Show(View.GridControl, e.Point)
        End If
    End Sub

    'promjena boje u odnosu na vrijednost
    Private Sub gridView_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles gridView.RowCellStyle
        'Dim sVal As String

        'If e.Column.Name = "colStatusOpis" AndAlso TypeOf gridView.GetRowCellValue(e.RowHandle, e.Column) Is System.String Then

        '    sVal = CType(gridView.GetRowCellValue(e.RowHandle, e.Column), String)

        '    Select Case sVal
        '        Case "Završeno"
        '            e.Appearance.Options.UseFont = FontStyle.Strikeout
        '            e.Appearance.ForeColor = Color.Gray

        '            '        Case "Srednja važnost"
        '            '            e.Appearance.BackColor = Color.Orange
        '            '            e.Appearance.ForeColor = Color.Black

        '            '        Case "Razmotriti"
        '            '            e.Appearance.BackColor = Color.Green
        '            '            e.Appearance.ForeColor = Color.Black
        '    End Select
        'End If
        ' ''End If
    End Sub

    Private Sub gridView_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles gridView.RowStyle
        Dim sVal As String

        sVal = getGridVal(gridView, e.RowHandle, colStatusOpis)

        'sVal = CType(gridView.GetRowCellValue(e.RowHandle, e.Column), String)

        Select Case sVal
            Case "Završeno"
                e.Appearance.Options.UseFont = FontStyle.Strikeout
                e.Appearance.ForeColor = Color.LightGray
        End Select
    End Sub

    Private Sub grid_DoubleClick(sender As Object, e As System.EventArgs) Handles grid.DoubleClick
        Dim frm As New frmZadatak(iZadatak)
        frm.ShowDialog(Me)
    End Sub

    Private Sub rightClickMenu_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles rightClickMenu.ItemClicked
        Select Case e.ClickedItem.ToString
            Case "Ispis"
                If sender.sourceControl.name.ToString = "grid" Then
                    Dim frm As New frmPrint(grid, "Pregled zadataka na projektu " + getGridVal(gridViewOper, colProjekt) + " na " + Now.ToShortDateString, True)
                    frm.Show()
                Else
                    Dim frm As New frmPrint(grid2, "Pregled izvršenja zadatka " + getZadatak(iZadatak) + " na " + Now.ToShortDateString, False)
                    frm.Show()
                End If

            Case "Izvoz"

        End Select
    End Sub

    Private Sub toolExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolXLS.Click, toolXLSX.Click, toolPDF.Click, toolHTML.Click, toolRTF.Click
        Select Case sender.name.ToString
            Case "toolXLS"
                CreateXLS(g)
            Case "toolXLSX"
                CreateXLSX(g)
            Case "toolPDF"
                createPDF(g)
            Case "toolHTML"
                createHTML(g)
            Case "toolRTF"
                createRTF(g)
        End Select
    End Sub
#End Region


#Region "grid2 - izvrsenja"
    Private Sub fillGrid2(ByVal zadatak As Integer)
        Dim DA As SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("grid2") > -1 Then
            DS.Tables("grid2").Clear()
        End If

        DA = New SqlDataAdapter("select id,opis,stanje,detOpis,vrijemeRad,vrijemeOD as datum,dbo.timeFormat(vrijemeOD,vrijemeDO)as utroseno " _
                              + " ,posto,cast((case stanje when 100 then 'False' when 3 then 'True' end)as bit)as stanjeBool from izvrsenja " _
                              + " where zadatak = " + zadatak.ToString + " and operater=" + frmOper.ToString, gCN)
        Try
            DA.Fill(DS, "grid2")
        Catch e As SqlException
            alerter.showErr("grid2" + e.Message)
        End Try

        'progressIzvr.PercentView = True


        grid2.DataSource = DS.Tables("grid2")
        grid2View.OptionsPrint.UsePrintStyles = True
        grid2View.OptionsPrint.EnableAppearanceEvenRow = True
        grid2View.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        'DS.Reset() : DS.Dispose()

    End Sub

    Private Sub grid2View_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grid2View.FocusedRowChanged
        iIzvrsenje = 0
        grid2.DefaultView.GetRow(e.FocusedRowHandle)
        iStanje = grid2View.GetRowCellValue(e.FocusedRowHandle, colStatus2)
        iIzvrsenje = grid2View.GetRowCellValue(e.FocusedRowHandle, colID)
        idRow2 = e.FocusedRowHandle
        changeButtons(iStatus)
    End Sub

    ''menu na desni klik
    Private Sub grid2View_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles grid2View.PopupMenuShowing
        Dim View As GridView = CType(sender, GridView)

        If e.HitInfo.InRow Then
            g = grid2View
            rightClickMenu.Show(View.GridControl, e.Point)
        End If
    End Sub
#End Region


#Region "grid - ostalo"
    Private Sub fillGridOper()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("grid3") > -1 Then
            DS.Tables("grid3").Clear()
        End If

        DA = New SqlDataAdapter("select dbo.getOsoba(oper)as sOper,aktiv from logins", gCN)
        Try
            DA.Fill(DS, "grid3")
        Catch e As Exception
            alerter.showErr(e.Message)
        End Try

        gridtest.PopulateViewColumns()
        gridtest.DataSource = DS.Tables("grid3")

    End Sub


#End Region


#Region "CHART"

    Private Sub createChart(Optional izad As Integer = 0)
        Dim myDiagram As GanttDiagram
        Dim flgFormat As Boolean

        If IsNothing(chart) = False Then
            chart.Dispose()
        End If
        chart = New ChartControl

        seriesR = New Series(rm.GetString("PlaniranoVrijeme"), ViewType.Gantt)
        seriesK = New Series(rm.GetString("UtrosenoVrijeme"), ViewType.Gantt)

        Dim trenutno As Double
        Dim progress As New ConstantLine("", trenutno)

        seriesR.ValueScaleType = ScaleType.Numerical
        seriesK.ValueScaleType = ScaleType.Numerical

        'CM = CN.CreateCommand()
        'If izad > 0 Then
        '    CM.CommandText = "select naziv,DBO.TIMEFORMAT(VRIJEMEod,VRIJEMEdO)as vrimZad, " _
        '                    + " isnull((select dbo.gettimeDiffSec(SUM(vrimSec))vrimIzvr from izvrsenja where zadatak=zadaci.id),0) as VrimRad " _
        '                    + " FROM ZADACI where ID=" + izad.ToString
        'Else
        '    CM.CommandText = "select naziv,DBO.TIMEFORMAT(VRIJEMEod,VRIJEMEdO)as vrimZad, " _
        '                    + " isnull((select dbo.gettimeDiffSec(SUM(vrimSec))vrimIzvr from izvrsenja where zadatak=zadaci.id),0) as VrimRad " _
        '                    + " FROM ZADACI"
        'End If


        If izad > 0 Then
            DA = New SqlDataAdapter("select naziv,DBO.TIMEFORMAT(VRIJEMEod,VRIJEMEdO)as vrimZad, " _
                            + " isnull((select dbo.gettimeDiffSec(SUM(vrimSec))vrimIzvr from izvrsenja where zadatak=zadaci.id),0) as VrimRad " _
                            + " FROM ZADACI where ID=" + izad.ToString, gCN)
        Else
            DA = New SqlDataAdapter("select naziv,DBO.TIMEFORMAT(VRIJEMEod,VRIJEMEdO)as vrimZad, " _
                            + " isnull((select dbo.gettimeDiffSec(SUM(vrimSec))vrimIzvr from izvrsenja where zadatak=zadaci.id),0) as VrimRad " _
                            + " FROM ZADACI", gCN)
        End If

        Try
            DA.Fill(DS, "chart")
        Catch e As Exception
            alerter.showErr(e.Message)
        End Try
        DT = DS.Tables("chart")

        'DR = CM.ExecuteReader

        If seriesK.Points.Count = 1 Then
            seriesR.Points.RemoveAt(0)
            seriesK.Points.RemoveAt(0)
            seriesR.ResetLegendPointOptions()
            seriesK.ResetLegendPointOptions()

        ElseIf seriesR.Points.Count = 0 Then

        End If


        'If DR.HasRows Then
        '    While (DR.Read)
        ' Add points to them.

        With DT

            For i = 0 To .Rows.Count - 1
                Try
                    If TimeSpan.Parse(.Rows(0)("vrimZad")).TotalMinutes <= 60 And TimeSpan.Parse(.Rows(0)("VrimRad")).TotalMinutes <= 60 Then        'ako je > 2 sati 
                        seriesR.Points.Add(New SeriesPoint(.Rows(0)("naziv").ToString, New Double() {0.0, TimeSpan.Parse(.Rows(0)("vrimZad")).TotalMinutes}))
                        seriesK.Points.Add(New SeriesPoint(.Rows(0)("naziv").ToString, New Double() {0.0, TimeSpan.Parse(.Rows(0)("VrimRad")).TotalMinutes}))
                        trenutno = TimeSpan.Parse(.Rows(0)("VrimRad")).TotalMinutes
                        progress.LegendText = rm.GetString("min")
                        flgFormat = False
                    ElseIf TimeSpan.Parse(.Rows(0)("vrimZad")).TotalHours <= 24 And TimeSpan.Parse(.Rows(0)("VrimRad")).TotalHours <= 12 Then
                        seriesR.Points.Add(New SeriesPoint(.Rows(0)("naziv").ToString, New Double() {0.0, TimeSpan.Parse(.Rows(0)("vrimZad")).TotalHours}))
                        seriesK.Points.Add(New SeriesPoint(.Rows(0)("naziv").ToString, New Double() {0.0, TimeSpan.Parse(.Rows(0)("VrimRad")).TotalHours}))
                        trenutno = TimeSpan.Parse(.Rows(0)("VrimRad")).TotalHours
                        progress.LegendText = rm.GetString("sati")
                        flgFormat = False
                    ElseIf TimeSpan.Parse(.Rows(0)("vrimZad")).TotalDays >= 7 Then
                        seriesR.Points.Add(New SeriesPoint(.Rows(0)("naziv").ToString, New Double() {0.0, (TimeSpan.Parse(.Rows(0)("vrimZad")).TotalDays / 24)}))
                        seriesK.Points.Add(New SeriesPoint(.Rows(0)("naziv").ToString, New Double() {0.0, (TimeSpan.Parse(.Rows(0)("VrimRad")).TotalDays / 24)}))
                        trenutno = TimeSpan.Parse(.Rows(0)("VrimRad")).TotalDays
                        progress.LegendText = rm.GetString("dani")
                        flgFormat = False
                    End If

                Catch e As Exception
                    'MsgBox(e.Message)
                End Try
            Next i
        End With
        DT.Clear() : DT.Reset() : DT.Dispose()

        '    End While
        'End If
        'DR.Close()

        chart.Series.AddRange(New Series() {seriesR, seriesK})
        '' Hide labels of both series.
        seriesR.Label.Visible = False
        seriesK.Label.Visible = False

        ' Access the view-type-specific options of the series.
        CType(seriesR.View, GanttSeriesView).BarWidth = 0.59999999999999998
        CType(seriesK.View, GanttSeriesView).BarWidth = 0.29999999999999999

        ' Access the type-specific options of the diagram.



        myDiagram = CType(chart.Diagram, GanttDiagram)
        myDiagram.AxisY.NumericOptions.Format = NumericFormat.Number

        If flgFormat = True Then
            myDiagram.AxisY.NumericOptions.Precision = 0
            myDiagram.AxisX.GridSpacing = 10
        Else
            myDiagram.AxisY.NumericOptions.Precision = 2
        End If
        myDiagram.AxisX.Range.MaxValue = trenutno

        myDiagram.AxisX.NumericOptions.Format = NumericFormat.FixedPoint
        myDiagram.AxisX.GridSpacing = 100
        myDiagram.AxisY.ConstantLines.Add(progress)

        progress.ShowInLegend = True
        progress.Title.Alignment = ConstantLineTitleAlignment.Near
        'progress.Visible = False

        ' Add the chart to the form.
        chart.Dock = DockStyle.Fill

        tabGraph.Controls.Remove(chart)
        tabGraph.Controls.Add(chart)
    End Sub
#End Region


#Region "CHART2 - detail"

    Private Sub createChart2(Optional izad As Integer = 0)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim trenutno As Double
        Dim progress As New ConstantLine("", trenutno)

        If IsNothing(splineChart) = False Then
            splineChart.Dispose()
        End If
        splineChart = New ChartControl

        seriesSpline = New Series("Prikaz rada", ViewType.SideBySideStackedBar)

        If seriesSpline.Points.Count = 1 Then
            seriesSpline.Points.RemoveAt(0)
            seriesSpline.ResetLegendPointOptions()
        End If

        'CM = CN.CreateCommand()
        If izad > 0 Then
            'CM.CommandText = "select id,opis,stanje,vrimsec,detOpis,vrijemeRad,vrijemeOD as datum,dbo.timeFormat(vrijemeOD,vrijemeDO)as utroseno " _
            '                          + " ,posto from izvrsenja  where zadatak = " + izad.ToString + " and operater=" + frmOper.ToString

            DA = New SqlDataAdapter("select id,opis,stanje,vrimsec,detOpis,vrijemeRad,vrijemeOD as datum,dbo.timeFormat(vrijemeOD,vrijemeDO)as utroseno, " _
                                      + " posto from izvrsenja  where zadatak = " + izad.ToString + " and operater=" + frmOper.ToString, gCN)
            Try
                DA.Fill(DS, "chart2")
            Catch e As Exception
                alerter.showErr("chart2 - " + e.Message)
            End Try


            DT = DS.Tables("chart2")

            If DT.Rows.Count > 0 Then
                For i = 0 To DT.Rows.Count - 1
                    Try
                        seriesSpline.Points.Add(New SeriesPoint(DT.Rows(i)("datum"), TimeSpan.Parse(iNullTime(DT.Rows(i)("utroseno"))).TotalHours))
                        seriesSpline.Name = rm.GetString("chart2text")
                    Catch e As Exception
                        alerter.showErr(e.Message)
                    End Try
                Next
            End If
            DT.Reset() : DT.Clear() : DT.Dispose()

            splineChart.Series.Add(seriesSpline)
            seriesSpline.ValueScaleType = ScaleType.Numerical
            CType(splineChart.Diagram, XYDiagram).EnableAxisXZooming = True

            splineChart.Legend.Visible = True

            progress.ShowInLegend = True
            progress.Title.Alignment = ConstantLineTitleAlignment.Near
            splineChart.Dock = DockStyle.Fill

            tabDetail.Controls.Remove(splineChart)
            tabDetail.Controls.Add(splineChart)
        End If
    End Sub


#End Region


#Region "procedure i funkcije"


    Private Sub setFilter()
        Dim x As String

        DA = New SqlDataAdapter("select checkDEF from logins where oper=" + gOper.ToString, gCN)
        DA.Fill(DS, "checkDef")

        If DS.Tables("checkDef").Rows.Count > 0 Then
            x = DS.Tables("checkDef").Rows(0)("checkDEF")
        End If

        DA.Dispose() : DS.Dispose()

        If Mid(x, 1, 1) = "X" Then
            chkInactive.Checked = True
        Else
            chkInactive.Checked = False
        End If

        If Mid(x, 2, 1) = "X" Then
            chkWork.Checked = True
        Else
            chkWork.Checked = False
        End If

        If Mid(x, 3, 1) = "X" Then
            chkValidate.Checked = True
        Else
            chkValidate.Checked = False
        End If

        If Mid(x, 4, 1) = "X" Then
            chkTest.Checked = True
        Else
            chkTest.Checked = False
        End If


        If Mid(x, 5, 1) = "X" Then
            chkEnd.Checked = True
        Else
            chkEnd.Checked = False
        End If

        If Mid(x, 6, 1) = "X" Then
            chkReturned.Checked = True
        Else
            chkReturned.Checked = False
        End If

    End Sub

    Private Sub testiranje(izadatak As Integer)

        If alerter.SHOW(alerter.icona.upit, alerter.naslov.Testiranje, rm.GetString("mess9") + "|""" + getZadatak(izadatak).ToString + """?", alerter.button.DaNe) = 0 Then
            gIzvrsenje = startIzvrsenje(izadatak, "***TEST***", rm.GetString("dodTesiranje"), 0, 1)
            gZadatak = Izvrsenje2Zad(gIzvrsenje)
            dodajIzvrsenjeStatuBar(izadatak, True)
            setStatusZad(27, izadatak)

            Dim frm As New frmZadTest(izadatak)
            frm.ShowDialog(Me)
            krajIzvrsenje(gIzvrsenje, rm.GetString("testZavrsen"), 100)
            izbaciIzvrRibbon()
            gIzvrsenje = 0
            gZadatak = 0
        End If

    End Sub

    Private Sub setSkin()
        Dim skin As String
        DA = New SqlDataAdapter("select skin from logins where oper=" + gOper.ToString, gCN)
        DA.Fill(DS, "skin")

        skin = DS.Tables("skin").Rows(0)("skin")
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skin)
        DS.Dispose()

    End Sub

    Private Function Izlaz() As Boolean
        Izlaz = True
        If checkActiveTasks() = True Then
            Select Case alerter.SHOW(alerter.icona.upit, alerter.naslov.Izlaz, rm.GetString("mess28"), alerter.button.DaNeOdustani, 0, 0)
                Case 0
                    krajIzvrsenje(gIzvrsenje, "", 0)
                    setStatusZad(24, iZadatak)
                    logOUT()
                    CreateWaitDialog(rm.GetString("waitCaption7"), rm.GetString("waitTitle"))
                    Izlaz = True
                Case 1
                    logOUT()
                    CreateWaitDialog(rm.GetString("waitCaption7"), rm.GetString("waitTitle"))
                    Izlaz = True
                Case 2
                    Izlaz = False
            End Select
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Izlaz, rm.GetString("mess18"), alerter.button.DaNe, 0, 0) = 0 Then
                logOUT()
                Dispose()
                CreateWaitDialog(rm.GetString("waitCaption7"), rm.GetString("waitTitle"))
                End
            Else
                Izlaz = False
            End If
        End If
    End Function

    Private Sub localizeME()

        If Not IsNothing(seriesR) Then
            seriesR.Name = rm.GetString("PlaniranoVrijeme")
            seriesK.Name = rm.GetString("UtrosenoVrijeme")
        End If

        cmdOpen.Text = rm.GetString("openApp")
        cmdExit.Text = rm.GetString("exitApp")

        cmdActivate.Text = rm.GetString("cmdActivate")
        cmdEndIzvr.Text = rm.GetString("cmdEndIzvr")
        cmdExit.Text = rm.GetString("cmdExit")
        cmdOvjeri.Text = rm.GetString("cmdOvjeri")
        cmdTest.Text = rm.GetString("cmdTest")
        cmdStartIzvr.Text = rm.GetString("cmdStartIzvr")
        cmdMessages.Caption = rm.GetString("cmdMessages")
        cmbFilter.Caption = rm.GetString("cmbFilter")
        chkInactive.Caption = rm.GetString("chkInactive")
        chkWork.Caption = rm.GetString("chkWork")
        chkValidate.Caption = rm.GetString("chkValidate")
        chkTest.Caption = rm.GetString("chkTest")
        chkEnd.Caption = rm.GetString("chkEnd")
        chkReturned.Caption = rm.GetString("chkReturned")

        group.Text = rm.GetString("group")
        group2.Text = rm.GetString("group2")
        group3.Text = rm.GetString("group3")

        lblUkP.Text = rm.GetString("lblUkP")
        lblUkZad.Text = rm.GetString("lblUkZad")
        lblUkI.Text = rm.GetString("lblUkI")

        tab.TabPages(0).Text = rm.GetString("tabDetail")
        tab.TabPages(1).Text = rm.GetString("tabGraph")

        chkAll.Text = rm.GetString("chkAll")

        For Each rowCateg In PGsystem.Rows
            rowCateg.Properties.caption = rm.GetString(rowCateg.name.ToString)
            If rowCateg.hasChildren Then
                For i = 0 To rowCateg.ChildRows.Count - 1
                    rowCateg.ChildRows(i).Properties.Caption = rm.GetString(rowCateg.ChildRows(i).Properties.Row.Name.ToString)
                Next
            End If
        Next

        ''grid - operateri
        For Each colS In gridViewOper.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid
        For Each colS In gridView.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid2
        For Each colS In grid2View.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        groupOperPro.Text = rm.GetString("groupOperPro")

    End Sub

    Private Sub changeButtons(status As Integer)
        Select Case status
            Case 0
                cmdActivate.Visible = True
                cmdActivate.Enabled = False
                cmdOvjeri.Visible = False
                cmdEndIzvr.Visible = False
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = False

            Case 100
                cmdActivate.Visible = False
                cmdActivate.Enabled = False
                cmdOvjeri.Visible = False
                cmdEndIzvr.Visible = False
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = False

            Case 3          ''rad na zadatku
                cmdActivate.Visible = False
                cmdOvjeri.Visible = False
                cmdEndIzvr.Visible = True
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = True
                cmdStartIzvr.Text = rm.GetString("stopExec")
                cmdTest.Visible = False

            Case 24, 20         ''pauziran rad na zadatku
                cmdActivate.Visible = False
                cmdOvjeri.Visible = False
                cmdTest.Visible = False
                If gIzvrsenje > 0 Then
                    cmdStartIzvr.Visible = False
                Else
                    cmdStartIzvr.Visible = True
                    cmdStartIzvr.Text = rm.GetString("startExec")
                    If iIzvrsenje = 0 Then
                        cmdEndIzvr.Visible = True
                        cmdEndIzvr.Enabled = False
                    Else
                        cmdEndIzvr.Visible = True
                        cmdEndIzvr.Enabled = True
                    End If
                End If

            Case 31         ''zadatak potrebno testirati
                cmdActivate.Visible = False
                cmdOvjeri.Visible = False
                cmdEndIzvr.Visible = False
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = True
                cmdTest.Enabled = True

            Case -2, -3, -4, -10
                cmdActivate.Visible = True
                cmdActivate.Enabled = True
                cmdOvjeri.Enabled = False
                cmdEndIzvr.Visible = False
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = False
                cmdActivate.Text = "Reaktiviraj"

            Case -100       ''zadatak na validaciji
                cmdActivate.Visible = False
                cmdOvjeri.Visible = True
                If task2Validate(iZadatak) = True And gIzvrsenje = 0 Then
                    cmdOvjeri.Enabled = True
                Else
                    cmdOvjeri.Enabled = False
                End If
                cmdEndIzvr.Visible = True
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = False

                '' system šalje poruku određenim osobama/i
            Case -201       ''zadatak poslan na aktivaciju / reaktivaciju
                cmdActivate.Visible = True
                If gIzvrsenje > 0 Then
                    cmdActivate.Enabled = False
                Else
                    cmdActivate.Enabled = True
                End If
                cmdActivate.BringToFront()
                cmdOvjeri.Enabled = False
                cmdEndIzvr.Visible = False
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = False

            Case -202       ''zadatak poslan na validaciju
                If task2Validate(iZadatak) = True And gIzvrsenje = 0 Then
                    cmdOvjeri.Visible = True
                    cmdOvjeri.Enabled = False
                Else
                    cmdOvjeri.Visible = False
                    cmdOvjeri.Enabled = False
                End If
                cmdActivate.Visible = False
                cmdEndIzvr.Visible = True
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = False


            Case -204       ''zadatak poslan na testiranje
                cmdActivate.Visible = False
                cmdOvjeri.Visible = False
                cmdEndIzvr.Visible = True
                cmdEndIzvr.Enabled = False
                cmdStartIzvr.Visible = False
                cmdTest.Visible = True
                cmdTest.Enabled = True
        End Select
    End Sub

    Private Sub StartIzvrsenje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStartIzvr.Click
        If gIzvrsenje > 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess10") + "|""" + item.Caption + """ ?", alerter.button.DaNe, 0, 0) = 0 Then
                Dim frm As New frmIzvrsenje(gIzvrsenje, 3)
                frm.ShowDialog(Me)
                izbaciIzvrRibbon()
                setStatusZad(24, iZadatak)
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Aktivacija, rm.GetString("mess26"), alerter.button.DaNe) = 0 Then
                If iStanje = -100 Or iStanje = 0 Or iStanje = 2 Or iStanje = 100 Then
                    Dim frm As New frmIzvrsenje(iZadatak, iStanje)
                    frm.ShowDialog(Me)
                    dodajIzvrsenjeStatuBar(iZadatak)
                    setStatusZad(3, iZadatak)
                End If
            End If
        End If

        fillGrid()
    End Sub

    Private Sub zakljuciZadatak()
        setStatusZad(-100, iZadatak)
        fillGrid(iProjekt)

        CM = New SqlCommand("update vezaZadOper set zadStatus=-100 where zadatak=" + iZadatak.ToString + " and oper=" + gOper.ToString, gCN)
        CM.ExecuteNonQuery()
    End Sub

    Private Sub aktivirajIzvrsenje(zadatak As Integer)
        If iStatus = -2 Or iStatus = -3 Or iStatus = -4 Or iStatus = -10 Then
            If gIzvrsenje > 0 Then
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess10") + "|""" + item.Caption + """ ?", alerter.button.DaNe, 0, 0) = 0 Then
                    Dim frm As New frmIzvrsenje(gIzvrsenje, 3)
                    frm.ShowDialog(Me)
                    izbaciIzvrRibbon()
                    setStatusZad(24, gZadatak)

                    If alerter.SHOW(alerter.icona.upit, alerter.naslov.Reaktivacija, rm.GetString("mess12") + "|""" + getZadatak(iZadatak).ToString + """?", alerter.button.DaNe, 0, 0) = 0 Then
                        setStatusZad(24, zadatak)
                        fillGrid(iProjekt)
                    End If
                End If
            Else
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Aktivacija, rm.GetString("mess12") + "|""" + getZadatak(iZadatak).ToString + """?", alerter.button.DaNe, 0, 0) = 0 Then
                    setStatusZad(24, zadatak)
                    fillGrid(iProjekt)
                End If
            End If
        Else
            If gIzvrsenje > 0 Then
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess10") + "|""" + item.Caption + """ ?", alerter.button.DaNe, 0, 0) = 0 Then
                    Dim frm As New frmIzvrsenje(gIzvrsenje, 3)
                    frm.ShowDialog(Me)
                    izbaciIzvrRibbon()
                    setStatusZad(24, gZadatak)

                    If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess11") + "|""" + getZadatak(iZadatak).ToString + """?", alerter.button.DaNe, 0, 0) = 0 Then
                        setStatusZad(20, zadatak)
                        fillGrid(iProjekt)
                    End If
                End If
            Else
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Aktivacija, rm.GetString("mess11") + "|""" + getZadatak(iZadatak).ToString + """?", alerter.button.DaNe, 0, 0) = 0 Then
                    setStatusZad(20, zadatak)
                    fillGrid(iProjekt)
                End If
            End If
        End If

    End Sub



    Private Sub EndIzvrsenje()
        If gIzvrsenje > 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess10") + "|""" + item.Caption + """?", alerter.button.DaNe, 0, 0) = 0 Then
                Dim frm As New frmIzvrsenje(gIzvrsenje, 3)
                frm.ShowDialog(Me)
                izbaciIzvrRibbon()

                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Zaključenje, rm.GetString("mess13"), alerter.button.DaNe, 0, 0) = 0 Then
                    zakljuciZadatak()
                    alerter.SHOW(alerter.icona.info, alerter.naslov.Zaključenje, rm.GetString("mess14"))
                End If
            End If
        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Zaključenje, rm.GetString("mess13"), alerter.button.DaNe, 0, 0) = 0 Then
                zakljuciZadatak()
                alerter.SHOW(alerter.icona.info, alerter.naslov.Zaključenje, rm.GetString("mess14"))
            End If
        End If
    End Sub

    Public Function checkActiveTasks() As Boolean
        'If DR.IsClosed = False Then DR.Close()
        'CM = New SqlCommand("select stanje,id,zadatak,opis,DATEDIFF(SECOND,vrijemeOD,GETDATE())vrijemeRad " _
        '                    + " from izvrsenja where stanje in (3,27) and operater=" + gOper.ToString, gCN)

        DA = New SqlDataAdapter("select stanje,id,zadatak,opis,DATEDIFF(SECOND,vrijemeOD,GETDATE())vrijemeRad " _
                            + " from izvrsenja where stanje in (3,27) and operater=" + gOper.ToString, gCN)

        DA.Fill(DT)

        If DT.Rows.Count > 0 Then
            checkActiveTasks = True
            If IsNothing(item) = True Then
                For i = 0 To DT.Rows.Count - 1
                    gIzvrsenje = DT.Rows(i)("id")
                    gZadatak = Izvrsenje2Zad(gIzvrsenje)
                    gProjekt = zadatak2Projekt(gZadatak)

                    timeIzvr = DT.Rows(i)("vrijemeRad")

                    If DT.Rows(i)("stanje") = 3 Then
                        flgTest = False
                        dodajIzvrsenjeStatuBar(DT.Rows(i)("zadatak"))
                    ElseIf DT.Rows(i)("stanje") = 27 Then
                        flgTest = True
                        dodajIzvrsenjeStatuBar(DT.Rows(i)("zadatak"), True)
                    End If
                    iStanje = 3
                Next
            End If
        End If



        'If DR.HasRows Then
        '    checkActiveTasks = True
        '    If IsNothing(item) = True Then
        '        While DR.Read
        '            gIzvrsenje = DR("id")
        '            timeIzvr = DR("vrijemeRad")

        '            If DR("stanje") = 3 Then
        '                flgTest = False
        '                dodajIzvrsenjeStatuBar(DR("zadatak"))
        '            ElseIf DR("stanje") = 27 Then
        '                flgTest = True
        '                dodajIzvrsenjeStatuBar(DR("zadatak"), True)
        '            End If

        '            iStanje = 3

        '        End While
        '    End If
        'End If
        'DR.Close()
    End Function

    Public Sub dodajIzvrsenjeStatuBar(ByVal id As Integer, Optional flgTest As Boolean = False)
        Dim img As Image

        item = New DevExpress.XtraBars.BarButtonItem
        item2 = New DevExpress.XtraBars.BarStaticItem

        If flgTest = True Then
            img = My.Resources.Control_Panel_52
            item.Caption = rm.GetString("Test") + " " + getZadatak(id).ToString
        Else
            img = My.Resources.Control_Panel_21
            item.Caption = rm.GetString("Rad") + " " + getZadatak(id).ToString
        End If
        item.Glyph = img

        AddHandler item.ItemClick, AddressOf odabirIzvrsenja
        RibbonStatusBar.ItemLinks.Add(item)
        RibbonStatusBar.ItemLinks.Add(item2)
        'RibbonStatusBar.Refresh()
    End Sub


    Private Sub odabirIzvrsenja(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        If flgTest = True Then
            Dim frm As New frmZadTest(iZadatak)
            frm.ShowDialog(Me)
            krajIzvrsenje(gIzvrsenje, "Test završen!", 100)
            setStatusZad(24, iZadatak)
            izbaciIzvrRibbon()

        Else
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess6") + "|""" + item.Caption + """?", alerter.button.DaNe, 0, 0) = 0 Then
                Dim frm As New frmIzvrsenje(gIzvrsenje, 3)
                frm.ShowDialog(Me)
                setStatusZad(24, gZadatak)
                izbaciIzvrRibbon()
                fillGrid(iProjekt)
            End If
        End If

    End Sub

    Public Sub izbaciIzvrRibbon()
        ribbon.Items.Remove(item)
        ribbon.Items.Remove(item2)
        item.Dispose() : item = Nothing
        item2.Dispose() : item2 = Nothing
    End Sub

    Private Sub podaciSystem()
        Dim DT As New DataTable

        DA = New SqlDataAdapter("select *,(select count(id) from logins where aktiv=1)as loged, (select count(id) from operateri)as uk from logins where oper=" + gOper.ToString, gCN)

        Try
            DA.Fill(DS, "logSys")
            DT = DS.Tables("logSys")

            txtOperLogins.NullText = gOperater
            txtPravaLogins.NullText = gPravaOpis
            txtIPlogins.NullText = DT.Rows(0)("ip").ToString
            txtLogged.NullText = DT.Rows(0)("loged").ToString + "/" + DT.Rows(0)("uk").ToString
            txtVrimLogins.NullText = DT.Rows(0)("vrijeme").ToString
            txtUsername.NullText = gLogin.ToString
            txtDatabase.NullText = gDATABASEname.ToString
            txtJezik.NullText = Thread.CurrentThread.CurrentUICulture.NativeName.ToString
            txtSkin.NullText = gSKIN.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DT.Clear() : DS.Tables("logSys").Clear()

    End Sub


#End Region


#Region "Check funkcije"

    Private Function checkMail()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        DA = New SqlDataAdapter("select ID,naslov,poruka,dbo.getOsoba(odkoga)sOdKoga,dbo.getOsoba(kome)sKome,vrijeme,status, " _
                                + " isnull(prioritet,0)prioritet,isnull(prilog,0)prilog, isnull(flag,'false')flag, " _
                                + "isnull(imaPrilog,'false')imaPrilog,isnull(procitano,'false')procitano " _
                                + " from message where kome=" + gOper.ToString + "and tip = 1 and procitano=0", gCN)

        DA.Fill(DS, "mail")

        With DS.Tables("mail")
            For i = 0 To .Rows.Count - 1
                setStatusProjekt(500, .Rows(i)("id"))
                If gPopUp = True Then
                    createPopUp(.Rows(i)("ID"), popUpnaslov.Mail, rm.GetString("naslov") + .Rows(i)("naslov") + vbCrLf + rm.GetString("odKoga") + .Rows(i)("sOdKoga") + vbCrLf + rm.GetString("vrijeme") + .Rows(i)("vrijeme"), , popUpTipke.MailOtvori, popUpicona.mail)
                End If
            Next i

        End With

        DS.Dispose() : DA.Dispose()
    End Function


    Private Function checkActiveTask() As Boolean
        checkActiveTask = False

        If gIzvrsenje > 0 Then
            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess10") + "|""" + getZadatak(gZadatak).ToString + """ ?", alerter.button.DaNe, 0, 0) = 0 Then
                Dim frm As New frmIzvrsenje(gIzvrsenje, 3)
                frm.ShowDialog(Me)
                setStatusZad(24, gZadatak)
                izbaciIzvrRibbon()
            Else
                checkActiveTask = True
            End If
        End If

    End Function

    Public Function checkNewProjects() As Integer
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        DA = New SqlDataAdapter("select *,dbo.getProjekt(projekt)as nazivProj from vezaProjektOper where projstatus =502 and projekt in " _
                           + " (select id from projekti where voditelj =" + gOper.ToString + " and aktiv=1)", gCN)
        'DR = CM.ExecuteReader

        DA.Fill(DS, "newProjects")

        checkNewProjects = DS.Tables("newProjects").Rows.Count

        With DS.Tables("newProjects")
            For i = 0 To .Rows.Count - 1
                setStatusProjekt(500, .Rows(i)("id"))
                If gPopUp = True Then
                    createPopUp(.Rows(i)("projekt"), popUpnaslov.NoviProjek, rm.GetString("noviProjekt") + DS.Tables("newProjects").Rows(i)("nazivProj").ToString + vbCrLf + rm.GetString("voditelj") + gOperater.ToString, , popUpTipke.OtvoriProjekt, popUpicona.info)
                End If
            Next i

        End With

        DS.Dispose() : DA.Dispose()
    End Function


    Public Function checkNewTasks(Optional flgInitial As Boolean = False) As Integer
        Dim x As Integer = 0
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet


        If flgInitial = True Then
            DA = New SqlDataAdapter("select zadatak,zadStatus,(dbo.getZadatak(zadatak))as nazivZad, " _
                               + " (dbo.getProjekt(dbo.getZad2Projekt(zadatak)))as nazivProj  " _
                               + " from vezaZadOper where zadStatus in (0,-201) and oper=" + gOper.ToString, gCN)
        Else
            DA = New SqlDataAdapter("select zadatak,zadStatus,(dbo.getZadatak(zadatak))as nazivZad, " _
                               + " (dbo.getProjekt(dbo.getZad2Projekt(zadatak)))as nazivProj  " _
                               + " from vezaZadOper where zadStatus in (0) and oper=" + gOper.ToString, gCN)
        End If
        'DR = CM.ExecuteReader

        DA.Fill(DS, "newTask")

        With DS.Tables("newTask")
            For i = 0 To .Rows.Count - 1
                If gPopUp = True Then
                    createPopUp(.Rows(i)("zadatak"), popUpnaslov.NoviZadatak, rm.GetString("lblZadatak") + ": " + .Rows(i)("nazivZad") + vbCrLf + rm.GetString("lblProjekt") + ": " + .Rows(i)("nazivProj") + vbCrLf + rm.GetString("aktivZadatak"), , popUpTipke.OtvoriZadatakDa, popUpicona.upit)
                End If
                x += 1
            Next

        End With

        DA = New SqlDataAdapter("select ID,aktiv,dbo.getStatusZadOp (id," + gOper.ToString + ")as statuszad from zadaci where id in " _
                            + " (select zadatak from vezaZadOper where zadStatus=0 and oper=" + gOper.ToString + ")", gCN)
        DA.Fill(DS, "newTask2")

        With DS.Tables("newTask2")
            For i = 0 To .Rows.Count - 1
                If .Rows(i)("aktiv") = True And .Rows(i)("statuszad") = 0 Then
                    setStatusZad(-201, .Rows(i)("ID"))
                End If
            Next

        End With

        Return x
    End Function

    Public Function setTasks2Acitvate(Optional flgInitial As Boolean = False) As Integer
        Dim i As Integer = 0


        If flgInitial = True Then
            CM = New SqlCommand("select zadatak,zadStatus,(dbo.getZadatak(zadatak))as nazivZad, " _
                               + "(dbo.getProjekt(dbo.getZad2Projekt(zadatak)))as nazivProj  " _
                               + " from vezaZadOper where zadStatus in(-202,-100) and oper=" + gOper.ToString, gCN)
        Else
            CM = New SqlCommand("select zadatak,zadStatus,(dbo.getZadatak(zadatak))as nazivZad, " _
                   + "(dbo.getProjekt(dbo.getZad2Projekt(zadatak)))as nazivProj  " _
                   + " from vezaZadOper where zadStatus=-202 and oper=" + gOper.ToString, gCN)
        End If

        DR = CM.ExecuteReader

        While (DR.Read)
            If gPopUp = True Then
                createPopUp(DR("zadatak"), popUpnaslov.Validacija, rm.GetString("validZadatak") + vbCrLf + rm.GetString("lblZadatak") + ": " + DR("nazivZad").ToString + vbCrLf + rm.GetString("validZadatak1"), , popUpTipke.OtvoriValidacijaDa, popUpicona.upit)
            End If
        End While

        DR.Close()
        CM = New SqlCommand("SELECT z.id,z.aktiv,z.naziv,z.voditelj,vz.zadStatus " _
                            + "  FROM zadaci z JOIN vezaZadOper vz ON z.id=vz.zadatak " _
                            + " where vz.zadStatus = -202 and z.voditelj=" + gOper.ToString, gCN)
        DR = CM.ExecuteReader

        While (DR.Read)
            If DR("aktiv") = True And DR("zadStatus") = -202 Then
                setStatusZad(-100, DR("ID"))
            End If
        End While
        DR.Close()

        Return i
        CN.Close()
    End Function


    Public Sub checkZadaciTest(Optional flgInitial As Boolean = False)
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet
        Dim iZadatak As Integer = 0

        If flgInitial = True Then
            DA = New SqlDataAdapter("select id,oper,dbo.getOsoba(oper)sOper,zadatak from vezaZadOper where zadstatus in(-204,31)", gCN)
        Else
            DA = New SqlDataAdapter("select id,oper,dbo.getOsoba(oper)sOper,zadatak from vezaZadOper where zadstatus=-204", gCN)
        End If

        DA.Fill(DS, "test")

        With DS.Tables("test")
            For i = 0 To .Rows.Count - 1
                If .Rows(i)("oper") = gOper Then
                    If gPopUp = True Then
                        createPopUp(.Rows(i)("zadatak"), popUpnaslov.Testiranje, rm.GetString("lblZadatak") + ": " + getZadatak(.Rows(i)("zadatak")).ToString + vbCrLf + rm.GetString("testZadatak") + vbCrLf + rm.GetString("Operater") + ":" + (.Rows(i)("sOper")).ToString, , popUpTipke.OtvoriTestiranjeDa, popUpicona.upozorenje)
                    End If
                End If
            Next
        End With

        DA = New SqlDataAdapter("select ID,aktiv,dbo.getStatusZadOp (zadaci.id," + gOper.ToString + ")as statuszad from zadaci where id in(select zadatak from vezaZadOper where zadStatus=-204 and oper=" + gOper.ToString + ")", gCN)
        DA.Fill(DS, "test2")

        With DS.Tables("test2")
            For i = 0 To .Rows.Count - 1
                If .Rows(i)("aktiv") = True Then
                    setStatusZad(31, .Rows(i)("ID"))
                End If
            Next
        End With

        DA.Dispose() : DS.Dispose()
    End Sub
#End Region


#Region "popUP"
    Public WithEvents alertControl1 As New AlertControl

    Dim info As New AlertInfo(vbNull, vbNull)
    Dim cmdNE As New AlertButton
    Dim cmdDA As New AlertButton

    Dim cmdProjekt As New AlertButton
    Dim cmdZadatak As New AlertButton
    Dim cmdTestiranje As New AlertButton
    Dim cmdValid As New AlertButton

    Dim cmdMailOpen As New AlertButton
    Dim cmdMailAttach As New AlertButton
    Dim cmdMailRead As New AlertButton

    Dim tip As String = ""

    Public Enum popUpnaslov
        System = 0
        NoviProjek = 1
        NoviZadatak = 2
        Validacija = 3
        Završetak = 4
        Testiranje = 5
        Welcome = 6
        Mail = 7
    End Enum

    Public Enum popUpTipke
        None = 0
        OtvoriProjekt = 1
        OtvoriZadatak = 2
        OtvoriTestiranje = 3
        OtvoriValidacija = 4
        Da = 5
        Ne = 6
        DaNe = 7
        OtvoriProjektDa = 8
        OtvoriZadatakDa = 9
        OtvoriTestiranjeDa = 10
        OtvoriValidacijaDa = 11
        MailOtvori = 12
        MailAttach = 13
        'MailProcitano = 14
    End Enum

    Public Enum popUpicona
        info = 0
        upozorenje = 1
        upit = 2
        zabrana = 3
        greška = 4
        system = 5
        mail = 6
    End Enum

    Private Sub alertControl1_FormLoad(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Alerter.AlertFormLoadEventArgs) Handles alertControl1.FormLoad
        e.Buttons.PinButton.SetDown(flgAlertPinned)
    End Sub

    Public Sub createPopUp(id As Integer, Optional naslov As popUpnaslov = popUpnaslov.System, Optional ByVal text As String = "", Optional ByVal hyperText As String = "", Optional ByVal tipke As popUpTipke = popUpTipke.None, Optional ByVal icon As popUpicona = popUpicona.info, Optional flgPinned As Boolean = True)
        flgAlertPinned = flgPinned

        Dim images As Image
        Dim alertNaslov As String

        Select Case naslov
            Case popUpnaslov.NoviProjek
                alertNaslov = rm.GetString("popUpNaslov1")
                tip = "P"

            Case popUpnaslov.NoviZadatak
                alertNaslov = rm.GetString("popUpNaslov2")
                tip = "Z"

            Case popUpnaslov.Testiranje
                alertNaslov = rm.GetString("popUpNaslov3")
                tip = "T"

            Case popUpnaslov.Validacija
                alertNaslov = rm.GetString("popUpNaslov4")
                tip = "V"

            Case popUpnaslov.Završetak
                alertNaslov = rm.GetString("popUpNaslov5")

            Case popUpnaslov.System
                alertNaslov = rm.GetString("popUpNaslov6")

            Case popUpnaslov.Welcome
                alertNaslov = rm.GetString("popUpNaslov7") + " " + gAPPNAME.ToString + "!"

            Case popUpnaslov.Mail
                alertNaslov = rm.GetString("popUpNaslov8")
                tip = "M"
        End Select





        Select Case tipke
            Case popUpTipke.None

            Case popUpTipke.Da
                cmdDA = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\yes.png"))
                cmdDA.Visible = True
                cmdDA.Hint = rm.GetString("FileOpenItem1")
                cmdDA.Name = "cmdProjekt"
                cmdDA.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdDA)

            Case popUpTipke.Ne
                'If flgTipkaP = False Then
                cmdNE = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\no.png"))
                cmdNE.Visible = True
                cmdNE.Hint = rm.GetString("FileOpenItem1")
                cmdNE.Name = "cmdProjekt"
                cmdNE.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdNE)
                'AddHandler alertControl1.ButtonClick, AddressOf alertControl1_ButtonClick
                'End If

            Case popUpTipke.DaNe
                cmdDA = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\yes.png"))
                cmdDA.Visible = True
                cmdDA.Hint = rm.GetString("alertYes")
                cmdDA.Name = "cmdDA"
                cmdDA.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdDA)

                cmdNE = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\no.png"))
                cmdNE.Visible = True
                cmdNE.Hint = rm.GetString("alertNo")
                cmdNE.Name = "cmdNE"
                cmdNE.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdNE)


            Case popUpTipke.OtvoriProjektDa
                cmdProjekt = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdProjekt.Visible = True
                cmdProjekt.Hint = rm.GetString("FileOpenItem1")
                cmdProjekt.Name = "cmdProjekt"
                cmdProjekt.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdProjekt)

                cmdDA = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\yes.png"))
                cmdDA.Visible = True
                cmdDA.Hint = rm.GetString("alertYes")
                cmdDA.Name = "cmdDA"
                cmdDA.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdDA)


            Case popUpTipke.OtvoriZadatakDa
                cmdZadatak = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdZadatak.Visible = True
                cmdZadatak.Hint = rm.GetString("FileOpenItem1")
                cmdZadatak.Name = "cmdZadatak"
                cmdZadatak.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdZadatak)

                cmdDA = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\yes.png"))
                cmdDA.Visible = True
                cmdDA.Hint = rm.GetString("alertYes")
                cmdDA.Name = "cmdDA"
                cmdDA.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdDA)

            Case popUpTipke.OtvoriProjekt
                cmdProjekt = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdProjekt.Visible = True
                cmdProjekt.Hint = rm.GetString("FileOpenItem1")
                cmdProjekt.Name = "cmdProjekt"
                cmdProjekt.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdProjekt)

            Case popUpTipke.OtvoriZadatak
                cmdZadatak = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdZadatak.Visible = True
                cmdZadatak.Hint = rm.GetString("otvoriZadatak")
                cmdZadatak.Name = "cmdZadatak"
                cmdZadatak.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdZadatak)


            Case popUpTipke.OtvoriTestiranje
                cmdTestiranje = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdTestiranje.Visible = True
                cmdTestiranje.Hint = rm.GetString("FileOpenItem1")
                cmdTestiranje.Name = "cmdZadatak"
                cmdTestiranje.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdTestiranje)

            Case popUpTipke.OtvoriTestiranjeDa
                cmdTestiranje = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdTestiranje.Visible = True
                cmdTestiranje.Hint = rm.GetString("FileOpenItem1")
                cmdTestiranje.Name = "cmdZadatak"
                cmdTestiranje.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdTestiranje)

                cmdDA = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\test.ico"))
                cmdDA.Visible = True
                cmdDA.Hint = rm.GetString("Testiranje")
                cmdDA.Name = "cmdDA"
                cmdDA.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdDA)



            Case popUpTipke.OtvoriValidacija
                cmdValid = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdValid.Visible = True
                cmdValid.Hint = rm.GetString("validacijaZadatak")
                cmdValid.Name = "cmdZadatak"
                cmdValid.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdValid)


            Case popUpTipke.OtvoriValidacijaDa
                cmdValid = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\open.ico"))
                cmdValid.Visible = True
                cmdValid.Hint = rm.GetString("validacijaZadatak")
                cmdValid.Name = "cmdZadatak"
                cmdValid.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdValid)

                cmdDA = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\validate.ico"))
                cmdDA.Visible = True
                cmdDA.Hint = rm.GetString("validacijaZadatak")
                cmdDA.Name = "cmdDA"
                cmdDA.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdDA)

            Case popUpTipke.MailOtvori
                cmdMailOpen = New AlertButton(Image.FromFile(Application.StartupPath + "\MISC\ICONS\mail.ico"))
                cmdMailOpen.Visible = True
                cmdMailOpen.Hint = rm.GetString("otvoriMail")
                cmdMailOpen.Name = "cmdMailOpen"
                cmdMailOpen.Style = AlertButtonStyle.Button
                alertControl1.Buttons.Add(cmdMailOpen)
        End Select





        Select Case icon
            Case popUpicona.info
                images = My.Resources.Security___Alert_432
            Case popUpicona.upozorenje
                images = My.Resources.Security___Alert_436
            Case popUpicona.upit
                images = My.Resources.Security___Alert_446
            Case popUpicona.greška
                images = My.Resources.Security___Alert_440
            Case popUpicona.system
                images = My.Resources.humansDO
            Case popUpicona.zabrana

            Case popUpicona.mail
                images = My.Resources.mail
        End Select

        info = New AlertInfo(alertNaslov, text, hyperText, images, id.ToString + "|" + tip)
        'info.tag = id.ToString

        alertControl1.Show(Me, info)
        alertControl1.Dispose()

        For i = 0 To alertControl1.Buttons.Count - 1
            alertControl1.Buttons.RemoveAt(0)
        Next
    End Sub

    Private Sub alertControl1_ButtonClick1(sender As Object, e As DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs) Handles alertControl1.ButtonClick
        Dim tip As String
        Dim id As Integer

        Dim limiter As Integer = InStr(e.Info.Tag, "|")

        id = Convert.ToInt16(Mid(e.Info.Tag.ToString, 1, limiter - 1))
        tip = Mid(e.Info.Tag, limiter + 1)

        Select Case e.ButtonName
            Case "cmdProjekt"
                Dim frm As New frmProjekt()
                frm.ShowDialog(Me)

            Case "cmdZadatak"
                Dim frm As New frmZadatak(id)
                frm.ShowDialog(Me)

            Case "cmdMailOpen"
                Dim frm As New frmNewMessage(id, False)
                frm.ShowDialog(Me)


            Case "cmdDA"
                logg("(popUP) - Naslov:" + e.Info.Caption + ", Text:" + e.Info.Text + "Odabrano: DA")

                Select Case tip
                    Case "Z"
                        iZadatak = id
                        aktivirajIzvrsenje(iZadatak)
                        fillGrid()
                        e.Button.Visible = False

                    Case "T"
                        If checkActiveTask() = False Then
                            iZadatak = id
                            testiranje(iZadatak)
                            e.Button.Visible = False
                        End If

                    Case "V"
                        If checkActiveTask() = False Then
                            iZadatak = id
                            If alerter.SHOW(alerter.icona.upit, alerter.naslov.Validiranje, rm.GetString("mess37") + "|""" + getZadatak(iZadatak).ToString + """?", alerter.button.DaNe) = 0 Then
                                Dim frm As New frmVerify(iZadatak)
                                frm.ShowDialog(Me)
                                e.Button.Visible = False
                            End If
                        End If
                End Select
        End Select
    End Sub


#End Region



    'Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
    '    Dim rep As New repMain
    '    Dim subRep As New subrepMain

    '    Dim keyColumn As New DataColumn
    '    Dim foreignKeyColumn As New DataColumn

    '    Dim DA As New SqlDataAdapter
    '    Dim DS As New DataSet


    '    DA = New SqlDataAdapter("select *,dbo.getPrioritet(prioritet)sPrioritet,(dbo.getOsoba(voditelj))as sVoditelj from projekti", gCN)
    '    'DA.Fill(DS, "repMain")

    '    DA = New SqlDataAdapter("select *,id as idZad from zadaci", gCN)
    '    'DA.Fill(DS, "repSubreport")



    '    Try
    '        DA.Fill(DS, "repMain")
    '        DA.Fill(DS, "repSubreport")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    ''Set up a master-detail relationship between the DataTables 
    '    keyColumn = DS.Tables("repMain").Columns(0)
    '    foreignKeyColumn = DS.Tables("repSubreport").Columns("idZad")

    '    Try
    '        DS.Relations.Add("test", keyColumn, foreignKeyColumn)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    ' Bind the report to data.
    '    rep.DataSource = DS.Tables("repMain")
    '    rep.DataAdapter = DA
    '    rep.DataMember = "repMain"


    '    'subRep.DataSource = DS.Tables("repSubreport")
    '    'subRep.DataAdapter = DA
    '    'subRep.DataMember = "repSubreport"


    '    With rep
    '        .colID.DataBindings.Add("Text", DS, "id")
    '        '.colNaziv.DataBindings.Add("Text", DS, "naziv")
    '        '.colAnaliza.DataBindings.Add("Text", DS, "timeAnaliza")
    '        '.colDemo.DataBindings.Add("Text", DS, "timeDemo")
    '        '.colImplement.DataBindings.Add("Text", DS, "timeImplement")
    '        '.colTest.DataBindings.Add("Text", DS, "timeTest")
    '        '.colPlan.DataBindings.Add("Text", DS, "timePlan")
    '        '.colPrioritet.DataBindings.Add("Text", DS, "sPrioritet")
    '        '.colVoditelj.DataBindings.Add("Text", DS, "sVoditelj")



    '        '.Report.DataSource = subRep
    '        'rep.ApplyFiltering()

    '        rep.Detail.Controls.Add(subRep)
    '        subRep.XrSubreport1.ReportSource = New repMain


    '    End With
    '    rep.ShowPreview()
    'End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim frm As New frmSifrarnik
        frm.ShowDialog(Me)

    End Sub
End Class



