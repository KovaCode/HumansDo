#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class frmNewMessage

#Region "Dim's"
    Dim CM As New SqlCommand
    Dim CN As New SqlConnection
    Dim DA As New SqlDataAdapter
    Dim DR As SqlDataReader
    Dim DS As New DataSet
    Dim DT As New DataTable
    Dim iID As Integer
    Dim ukOper As String = ""
    Dim iOper As Integer
    Dim iPrior As Integer
    Dim flgImaPrilog As Boolean
    Dim flgNew As Boolean
    Dim idVeza As Integer
    Dim sOdKoga As String
#End Region


#Region "Init form"
    Public Sub New(Optional ByVal id As Integer = 0, Optional ByVal FlgNew2 As Boolean = True)

        ' This call is required by the designer.
        InitializeComponent()
        iID = id
        flgNew = FlgNew2

        If flgNew = True Then
            cmdSend.ShowArrowButton = False
        Else
            cmdSend.ShowArrowButton = True
        End If


        ' Add any initialization after the InitializeComponent() call.
        CN = New SqlConnection(gDATABASE)
        CN.Open()
    End Sub

    Private Sub frmNewMessage_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flgNew = False Then
            procitano(iID)
        End If
    End Sub

    Private Sub frmNewMessage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillCmbOper()
        'checkPrilog()
        If iID > 0 Then
            fillEmailData()
        End If
    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReply.Click, cmdForward.Click, cmdSend.Click

        Select Case sender.name

            Case "cmdSend"
                flgImaPrilog = checkPrilog()
                sendMessage()
                Me.Dispose()

            Case "cmdReply"
                cmdSend.ImageIndex = 8
                cmbOperater.Text = sOdKoga
                cmbOperater.Enabled = False
                txtPoruka.Enabled = True
                txtSubject.Text = "RE: " + txtSubject.Text

            Case "cmdForward"
                cmdSend.ImageIndex = 9
                cmbOperater.Text = ""
                cmbOperater.Enabled = True
                txtPoruka.Enabled = True
                txtSubject.Text = "FW: " + txtSubject.Text
        End Select


    End Sub

    Private Sub cmdPrilog_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrilog.ItemClick
        If flgNew = True Then
            Dim frm As New frmFiles(0, "M")
            frm.ShowDialog(Me)
        Else
            Dim frm As New frmFiles(idVeza, "M", False)
            frm.ShowDialog(Me)
        End If

    End Sub


    Private Sub cmd_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdNisko.ItemClick, cmdSrednje.ItemClick, cmdVisoko.ItemClick
        Select Case e.Item.Name
            Case "cmdNisko"
                subPrioritet.ImageIndex = 0
                iPrior = 1
            Case "cmdSrednje"
                subPrioritet.ImageIndex = -1
                iPrior = 0
            Case "cmdVisoko"
                subPrioritet.ImageIndex = 1
                iPrior = 2
        End Select
    End Sub
#End Region


#Region "cmbOper"

    Private Sub fillCmbOper()

        DA = New SqlDataAdapter("select id,dbo.getOsoba(id)oper from operateri", gDATABASE)
        DA.Fill(DS, "oper")

        DT = DS.Tables("oper")
        DA.Dispose()


        cmbOperater.Properties.Items.Clear()
        For Each row As DataRow In DT.Rows
            cmbOperater.Properties.Items.Add(New cmbVal(row("id"), row("oper")))
        Next

        DS.Tables("oper").Reset()
    End Sub

    Private Sub cmbOperater_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOperater.EditValueChanged
        For i = 0 To cmbOperater.Properties.Items.Count - 1
            If cmbOperater.Properties.Items(i).CheckState = CheckState.Checked Then
                iOper = CType(cmbOperater.Properties.Items(i).Value, cmbVal).Value
                If ukOper = "" Then
                    ukOper = iOper.ToString
                Else
                    ukOper = String.Concat(ukOper, "," + iOper.ToString)
                End If
            End If
        Next i
    End Sub

#End Region


#Region "Procedure i funkcije"

    Private Sub procitano(id As Integer)
        Dim CM As New SqlCommand
        CM = New SqlCommand("update message set procitano =1 where id=" + id.ToString, gCN)
        CM.ExecuteNonQuery()
        CM.Dispose()
    End Sub

    Private Function checkPrilog() As Boolean
        If flgNew = True Then
            CM = New SqlCommand("select id from images where veza=0 and vrsta='M'", CN)
        Else
            'CM = New SqlCommand("select id from images where veza="+ veza +" and vrsta='M'", CN)
        End If
        DR = CM.ExecuteReader

        If DR.HasRows Then
            checkPrilog = True
        End If
        DR.Close()
    End Function

    Private Sub sendMessage()
        Dim words As String() = ukOper.Split(New Char() {","c})
        Dim id As Integer
        ' Use For Each loop over words and display them

        For Each iOper In words
            Debug.WriteLine(iOper)

            CM = New SqlCommand("insert into message (naslov,poruka,odKoga,kome,vrijeme,status,prioritet,prilog,imaPrilog,procitano,flag,tip,veza) values " _
                                & " ('" + txtSubject.Text + "','" + txtPoruka.Text + "'," + gOper.ToString + "," + iOper.ToString + ",'" + SQLTime(Now).ToString + "',0," + iPrior.ToString + ",0," + Convert.ToInt32(flgImaPrilog).ToString + ",0,0,1,-99)SELECT SCOPE_IDENTITY()as iID", CN)

            id = CM.ExecuteScalar()
        Next

        DR.Close()
        CM = New SqlCommand("update message set veza=" + id.ToString + " where veza=-99 and tip =1", CN)
        CM.ExecuteNonQuery()
        DR.Close()

        CM = New SqlCommand("update images set veza=" + id.ToString + " where veza=0 and vrsta='M'", CN)
        CM.ExecuteNonQuery()
        DR.Close()




        'Sql = "INSERT INTO...;SELECT @@IDENTITY..."
        'Dim id = SqlCommand.ExecuteScalar(Sql)


    End Sub

    Private Sub fillEmailData()
        CM = New SqlCommand("select *,dbo.getOsoba(kome)sKome,dbo.getOsoba(OdKoga)sOdKoga from message where id=" + iID.ToString, CN)
        DR = CM.ExecuteReader

        txtPoruka.Properties.ReadOnly = True
        txtSubject.Properties.ReadOnly = True

        cmdSend.Text = "Odgovori"
        cmdSend.ImageIndex = 8

        While DR.Read
            txtSubject.Text = DR("naslov")
            txtPoruka.Text = DR("poruka")
            cmbOperater.Text = DR("sKome")

            Select Case DR("prioritet")
                Case 0
                    subPrioritet.ImageIndex = 0
                Case 1
                    subPrioritet.ImageIndex = -1
                Case 2
                    subPrioritet.ImageIndex = 1
            End Select

            lblPodaci.Caption = "Poruka poslana:" + DR("vrijeme") + "(" + DR("sOdKoga") + ")"
            idVeza = DR("veza")
            sOdKoga = DR("sOdKoga")
        End While
        DR.Close()



    End Sub


#End Region






End Class