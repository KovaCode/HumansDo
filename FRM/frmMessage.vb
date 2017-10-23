Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.Utils

Public Class frmMessage
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder
    Dim flgPrilog As Boolean

    Dim iID As Integer
    Dim iPrior As Integer
    Dim flgRead As Boolean
    Dim flgFlag As Boolean
    Dim flgAttach As Boolean
    Dim sFrom As String
    Dim sSubject As String
    Dim sMessage As String
    Dim iVeza As Integer
    Dim iTip As Integer = 1


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        CN = New SqlConnection(gDATABASE)
        CN.Open()
        'checkMessages()
    End Sub

    Private Sub frmZadatak_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - Pregled Poruka i Obavijesti"

        fillGrid()
        fillGrid2()

    End Sub


    'Private Sub checkMessages()
    '    CM = New SqlCommand("select (select COUNT(id) from message where tip=0 and procitano=0 and kome=" + gOper.ToString + ") as cntOb, " _
    '                    + " (select COUNT(id) from message where tip=1 and procitano=0 and kome=" + gOper.ToString + ") as cntPo", CN)
    '    DR = CM.ExecuteReader

    '    While DR.Read
    '        cmdObavijesti.Caption = "Obavijest (" + DR("cntOb").ToString + ")"
    '        cmdPoruke.Caption = "Poruke (" + DR("cntPo").ToString + ")"

    '    End While
    '    DR.Close()
    'End Sub

    Private Sub fillGrid(Optional ByVal tip As Integer = 0)
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select ID,naslov,poruka,dbo.getOsoba(odkoga)sOdKoga,dbo.getOsoba(kome)sKome,vrijeme,status, " _
                                + " isnull(prioritet,0)prioritet,isnull(prilog,0)prilog, isnull(flag,'false')flag, " _
                                + "isnull(imaPrilog,'false')imaPrilog,isnull(procitano,'false')procitano " _
                                + " from message where kome=" + gOper.ToString + "and tip = 1", gCN)
        DA.Fill(DS, "grid")


        grid.DataSource = DS.Tables("grid")
        grid.ForceInitialize()

        gridView.SetRowExpanded(-1, True)
        gridView.SetRowExpanded(-2, True)
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        'Dim Col As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridView.GetRowCellValue(e.FocusedRowHandle, colID)

        iPrior = gridView.GetRowCellValue(e.FocusedRowHandle, colPrioritet)
        flgRead = gridView.GetRowCellValue(e.FocusedRowHandle, colRead)
        flgFlag = gridView.GetRowCellValue(e.FocusedRowHandle, colFlag)
        flgAttach = gridView.GetRowCellValue(e.FocusedRowHandle, colAttachment)
        sFrom = gridView.GetRowCellValue(e.FocusedRowHandle, colOdKoga)
        sSubject = gridView.GetRowCellValue(e.FocusedRowHandle, colSubject)
        sMessage = gridView.GetRowCellValue(e.FocusedRowHandle, colPoruka)
        iVeza = gridView.GetRowCellValue(e.FocusedRowHandle, colVeza)

    End Sub





    'update promjene stanja na gridu
    Private Sub cmbFlag_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        CM = New SqlCommand("update message set flag=" + Convert.ToInt32(sender.value).ToString + " where id = " + iID.ToString, CN)
        CM.ExecuteNonQuery()

        CM.Dispose()
    End Sub

    Private Sub cmbPrioritet_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        CM = New SqlCommand("update message set prioritet=" + sender.value.ToString + " where id = " + iID.ToString, CN)
        CM.ExecuteNonQuery()
        CM.Dispose()
    End Sub

    Private Sub cmbProcitano_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        CM = New SqlCommand("update message set procitano=" + Convert.ToInt32(sender.value).ToString + " where id = " + iID.ToString, CN)
        CM.ExecuteNonQuery()
        CM.Dispose()
    End Sub


    Public Sub createPopUp(ByVal Naslov As String, ByVal text As String, Optional ByVal hyperText As String = "", Optional ByVal buttons As String = "", Optional ByVal icon As String = "i")
        Dim images As Image
        Dim parts As String() = buttons.Split(New Char() {"|"c})
        Dim info As AlertInfo

        AddHandler AlertControl1.ButtonClick, AddressOf alertControl1_ButtonClick
        AddHandler AlertControl1.ButtonDownChanged, _
        AddressOf alertControl1_ButtonDownChanged

        Select Case icon
            Case "i"
                images = Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\i.png")
            Case "!"
                images = Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\!.png")
            Case "upitnik"
                images = Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\upitnik.png")
            Case "x"
                images = Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\x.png")
        End Select


        'frmMain.AlertControl1.Buttons.PinButton.State = AlertButtonState.NormalChecked

        info = New AlertInfo(Naslov, text, hyperText, images)
        AlertControl1.Show(frmMainNew, info)
        AlertControl1.Dispose()

    End Sub


    Private Sub alertControl1_ButtonDownChanged(ByVal sender As Object, ByVal e As AlertButtonDownChangedEventArgs)
        If e.ButtonName = "buttonOpen" Then
            MsgBox("open")
        End If
    End Sub

    Private Sub alertControl1_ButtonClick(ByVal sender As Object, ByVal e As AlertButtonClickEventArgs)
        Select Case e.ButtonName
            Case "Flag"
                If flgFlag = True Then
                    CM = New SqlCommand("update message set flag=0 where id = " + iID.ToString, CN)
                Else
                    CM = New SqlCommand("update message set flag=1 where id = " + iID.ToString, CN)
                End If
                CM.ExecuteNonQuery()
                fillGrid(iTip)

            Case "Read"
                If flgRead = True Then
                    CM = New SqlCommand("update message set procitano=0 where id = " + iID.ToString, CN)
                Else
                    CM = New SqlCommand("update message set procitano=1 where id = " + iID.ToString, CN)
                End If
                CM.ExecuteNonQuery()
                fillGrid(iTip)

            Case "Attachment"
                Dim frm As New frmFiles(iID)
                frm.ShowDialog(Me)
        End Select


    End Sub



    Public Sub ShowAlert()
        InitButtonsStyle()
        AddHandler AlertControl1.ButtonClick, AddressOf alertControl1_ButtonClick
        AddHandler AlertControl1.ButtonDownChanged, _
        AddressOf alertControl1_ButtonDownChanged
        If iTip = 0 Then
            AlertControl1.Show(Me, "Obavijest: " + sFrom, sMessage, Nothing, GetMailImage(), Nothing)
        Else
            AlertControl1.Show(Me, "humansDO-Poruka: " + sFrom, sMessage, Nothing, GetMailImage(), Nothing)
        End If

    End Sub

    Private Sub InitButtonsStyle()
        AlertControl1.Buttons("Flag").Down = 0.Equals(flgFlag)
        AlertControl1.Buttons("Read").Down = 1.Equals(flgRead)
        AlertControl1.Buttons("Attachment").Visible = flgAttach
    End Sub

    Private Function GetMailImage() As Image
        Dim Images As Image
        If 0.Equals(flgAttach) Then
            Images = Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\mail.png")
        Else
            Images = Image.FromFile("C:\Users\Ivan Kovačić\Desktop\HumansDo\HumansDo\MISC\Icons\attach.png")
        End If
        Return Images
    End Function

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewMessage.Click, cmdOpen.Click
        Select Case sender.name
            Case "cmdNewMessage"
                Dim frm As New frmNewMessage()
                frm.ShowDialog(Me)

            Case "cmdOpen"
                If iTip = 0 Then
                    ShowAlert()
                Else
                    Dim frm As New frmNewMessage(iID, False)
                    frm.ShowDialog(Me)
                    ShowAlert()
                End If

                CM = New SqlCommand("update message set procitano=1 where id = " + iID.ToString, CN)
                CM.ExecuteNonQuery()
                fillGrid(iTip)


            Case "cmdDelete"


            Case "cmdEdit"



        End Select
    End Sub

    'Private Sub cmd_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdObavijesti.LinkClicked, cmdPoruke.LinkClicked
    '    Select Case sender.name
    '        Case "cmdObavijesti"
    '            iTip = 0
    '            fillGrid(iTip)
    '            cmdNew.Visible = False


    '        Case "cmdPoruke"
    '            iTip = 1
    '            fillGrid(iTip)
    '            cmdNew.Visible = True


    '    End Select
    'End Sub


    Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        If iTip = 0 Then
            ShowAlert()
        Else
            Dim frm As New frmNewMessage(iID, False)
            frm.ShowDialog(Me)
            ShowAlert()
        End If

        CM = New SqlCommand("update message set procitano=1 where id = " + iID.ToString, CN)
        CM.ExecuteNonQuery()
        fillGrid(iTip)

    End Sub


    Private Sub GroupControl1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles groupMailTree.Paint

    End Sub

    Private Sub grid_Click(sender As System.Object, e As System.EventArgs) Handles grid.Click

    End Sub

    Private Sub fillGrid2()
        Dim DA As New SqlDataAdapter
        Dim DS As New DataSet

        DA = New SqlDataAdapter("select (select 1 as ID,'Inbox' as Naziv)as g1; select 2 as ID,'Outbox' as Naziv", gCN)
        DA.Fill(DS, "grid2")

        grid2.DataSource = DS
    End Sub

End Class