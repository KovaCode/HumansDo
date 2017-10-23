#Region "Imports"
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
#End Region


Public Class frmIzvrsenje

#Region "Dim's"
    Const WM_SYSCOMMAND As Int32 = &H112
    Const SC_MINIMIZE As Int32 = &HF020
    Const SC_RESTORE As Int32 = &HF120

    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable

    Dim CB As SqlCommandBuilder

    Dim iIzvID As Integer
    Dim pocVrijeme As Date
    Dim vrijeme As Date
    Dim IDizvrsenje As Integer
    Dim item As New DevExpress.XtraBars.BarEditItem
    Dim progress As New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Dim itemSub As New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Dim itemClock As New DevExpress.XtraBars.BarStaticItem
    Dim flgAktivno As Boolean = False
    Dim postotak As String
    Dim istanje As Integer
#End Region


#Region "Init Form"
    Public Sub New(ByVal id As Integer, Optional ByVal stanje As Integer = 2)

        InitializeComponent()
        localizeME()

        CN = New SqlConnection(gDATABASE)
        CN.Open()
        istanje = stanje
        iIzvID = id

        If istanje = 3 Then
            cmdStart.Text = rm.GetString("zaustavi")
            cmdStart.ImageIndex = 2
            fillOsnovno()
        Else
            cmdStart.Text = rm.GetString("pokreni")
            cmdStart.ImageIndex = 3
        End If

    End Sub

    Private Sub frmIzvrsenje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillOsnovno()
    End Sub
#End Region


#Region "SYSTEM"

    Private Sub frmIzvrsenje_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If flgAktivno = True Then

            Select Case alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess6"), alerter.button.DaNeOdustani)
                Case 0
                    krajIzvrsenje(IDizvrsenje, txtDetOpis.Text, trackPosto.Value)
                    frmMainNew.izbaciIzvrRibbon()
                Case 1
                    e.Cancel = True
                Case 2
                    Me.Hide()
            End Select
        End If
    End Sub

#End Region


#Region "Click's"
    Private Sub trackPosto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackPosto.EditValueChanged
        postotak = trackPosto.Value
        lblPosto.Text = postotak.ToString + " %"
    End Sub

    Private Sub cmdZakljuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        krajIzvrsenje(IDizvrsenje, txtDetOpis.Text, trackPosto.Value)
        flgAktivno = False
    End Sub

    Private Sub cmdStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.CheckedChanged
        If istanje = -100 Or istanje = 0 Or istanje = 100 Then
            cmdStart.ImageIndex = 1S
            cmdStart.Text = rm.GetString("zaustavi")
            'Timer1.Interval = 1000
            'Timer1.Enabled = True
            gIzvrsenje = startIzvrsenje(iIzvID, txtOpis.Text, txtDetOpis.Text, trackPosto.Value)
            gZadatak = Izvrsenje2Zad(gIzvrsenje)
            gProjekt = zadatak2Projekt(gZadatak)
            'IDizvrsenje = startIzvrsenje2()

            Me.Dispose()
        ElseIf istanje = 3 Then
            cmdStart.ImageIndex = 3
            cmdStart.Text = rm.GetString("pokreni")
            Timer1.Enabled = False
            krajIzvrsenje(iIzvID, txtDetOpis.Text, trackPosto.Value)
            gIzvrsenje = 0
            flgAktivno = False
            Me.Dispose()
        End If

    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.enabled = checkSpecial(CTRL)

            If CTRL.HasChildren Then
                For i = 0 To CTRL.Controls.Count - 1
                    CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)
                    CTRL.Controls(i).enabled = checkSpecial(CTRL.Controls(i))
                Next
            End If
        Next CTRL


    End Sub

    Private Sub fillOsnovno()
        'CM = New SqlCommand("select naziv, dbo.timeFormat(vrijemeOD,vrijemeDO)timeRazlika from zadaci where id=" + iZadatak.ToString, CN)

        If istanje = 3 Then
            CM = New SqlCommand("select z.naziv,dbo.timeFormat(z.vrijemeOD,z.vrijemeDO)timeRazlika, " _
                     + " i.opis,i.detopis,i.posto from izvrsenja i JOIN zadaci z on i.zadatak=z.id where i.id=" + iIzvID.ToString, CN)
        Else
            CM = New SqlCommand("select z.naziv,dbo.timeFormat(z.vrijemeOD,z.vrijemeDO)timeRazlika, " _
                     + " i.opis,i.detopis,i.posto from izvrsenja i JOIN zadaci z on i.zadatak=z.id where i.id=" + iIzvID.ToString, CN)
        End If


        DR = CM.ExecuteReader

        While DR.Read
            groupIzvrsenja.Text = rm.GetString("groupIzvrsenja") + DR("naziv")
            If istanje = 3 Then
                trackPosto.Value = DR("posto")
                txtOpis.Text = DR("opis")
                txtDetOpis.Text = DR("detOpis")
            End If
        End While
        DR.Close()
    End Sub

#End Region


End Class