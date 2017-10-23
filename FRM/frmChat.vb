#Region "Imports"
Imports System.Net
Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Data.SqlClient
#End Region

Public Class frmChat

#Region "DIM's"

    Public Shared connectDone As New ManualResetEvent(False)
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim CB As SqlCommandBuilder

    Dim tts
    Dim trd As Thread
    Dim trd2 As Thread
    Dim iID As Integer
    Dim iIP As String
    Dim gIp As String
    Dim idRow As Integer

    Private Delegate Sub NoParamsDelegate()
    Private Delegate Sub OneStringDelegate(ByVal Data As String)

    Private ASCII As New ASCIIEncoding
    Dim mess As String
    Dim client As TcpClient
    Dim listener As New TcpListener(44444)
    Private connected As Boolean
    Dim asyncResult As IAsyncResult

    Private Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Const SND_FILENAME As Integer = &H20000
    Const SND_ALIAS As Integer = &H10000
    Const SND_SYNC As Integer = &H0
    Declare Auto Function waveOutGetNumDevs Lib "winmm.dll" Alias "waveOutGetNumDevs" () As Int32
    Declare Auto Function sndPlaySound Lib "WINMM.DLL" (ByVal FileName As String, ByVal Options As Int32) As Int32
    Private Const SND_MEMORY As Integer = &H4
    Private Const SND_ASYNC As Integer = &H1
    Private Const PROCESS_DOMAIN As String = ""
    Const SND_SYNC1 = &H0
    Const SND_ASYNC1 = &H1
    Const SND_NODEFAULT = &H2
    Const SND_LOOP = &H8
    Const SND_NOSTOP = &H10
#End Region


#Region "Init Form"
    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - Chat"

        fillGrid()
        listener.Start()
        Timer1.Enabled = True
        Timer1.Start()

        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        trd.Start()
    End Sub
#End Region


#Region "SYSTEM"

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            'If connected = True Then
            If listener.Pending = True Then
                mess = ""
                client = listener.AcceptTcpClient

                Dim reader As New StreamReader(client.GetStream)
                While reader.Peek > -1
                    mess = mess + Convert.ToChar(reader.Read).ToString
                End While
                Me.Focus()
                TXTMSG.Text = TXTMSG.Text + mess + vbCrLf
                PlaySound("recycle.wav", 0, SND_ALIAS Or SND_SYNC)
                System.Media.SystemSounds.Question.Play()
                'tts = CreateObject("sapi.spvoice")
                'tts.speak()
            End If
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsNothing(gIp) = False Then
            Dim ipHost As IPHostEntry = Dns.GetHostEntry(gIp)
            Dim ipAddr As IPAddress = ipHost.AddressList(0)
            Dim ipEndPoint As New IPEndPoint(ipAddr, 44444)

            Dim clientSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

            ' Connect the socket to the remote end point.
            clientSocket.Connect(ipEndPoint)

            Dim data As String = "Konekcija terminirana!"
            Dim buffer() As Byte = Encoding.ASCII.GetBytes(data)
            Dim bytesTransferred As Integer = clientSocket.Send(buffer)


            Dim dlg As New NoParamsDelegate(AddressOf DisconnectedUI)
            Me.Invoke(dlg)
            Timer1.Stop()
            client.Close()
            listener.Stop()
            clientSocket.Shutdown(SocketShutdown.Both)
        End If
    End Sub

#End Region


#Region "Click's"

    Private Sub cmdConnect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConnect.CheckedChanged
        If cmdConnect.Checked = True Then
            cmdConnect.Text = "Disconnect"

            If connected = True Then
                connected = False

                listener.Start()
                Timer1.Enabled = True
                Timer1.Start()

                trd = New Thread(AddressOf ThreadTask)
                trd.IsBackground = True
                trd.Start()

                'connected = True
                client = New TcpClient(iIP, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write("Connection quest")
                writer.Flush()

            Else
                connected = True
                client = New TcpClient(iIP, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write("Connection quest")
                writer.Flush()
                listener.Start()
            End If
        Else
            cmdConnect.Text = "Connect"

            Dim ipHost As IPHostEntry = Dns.GetHostEntry(gIp)
            Dim ipAddr As IPAddress = ipHost.AddressList(0)
            Dim ipEndPoint As New IPEndPoint(ipAddr, 44444)

            Dim clientSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

            ' Connect the socket to the remote end point.
            clientSocket.Connect(ipEndPoint)

            Dim data As String = "Konekcija terminirana!"
            Dim buffer() As Byte = Encoding.ASCII.GetBytes(data)
            Dim bytesTransferred As Integer = clientSocket.Send(buffer)


            Dim dlg As New NoParamsDelegate(AddressOf DisconnectedUI)
            Me.Invoke(dlg)
            Timer1.Stop()
            client.Close()
            listener.Stop()
            clientSocket.Shutdown(SocketShutdown.Both)

        End If
    End Sub

    Private Sub cmdSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSend.Click
        Try
            If txtSend.Text = "" Then
                MsgBox("Unesite vrijednosti!", MsgBoxStyle.Exclamation)
            Else
                client = New TcpClient(gIp, 44444)
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write(gOperater.ToString + " : " + txtSend.Text)
                writer.Flush()
                TXTMSG.Text = TXTMSG.Text + gOperater.ToString + ": " + txtSend.Text + vbCrLf
                txtSend.Text = ""


            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region


#Region "Grid"

    Private Sub fillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select id,oper,aktiv,ip,dbo.getOsoba(oper)sOper from logins", gCN)
        DA.Fill(DS, "grid")

        grid.DataSource = DS.Tables("grid")
        grid.ForceInitialize()
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
        iIP = gridView.GetRowCellValue(e.FocusedRowHandle, colIP)
        idRow = e.FocusedRowHandle
    End Sub
#End Region


#Region "Procedure i funkcije"

    Public Sub endSession()
        Dim ipHost As IPHostEntry = Dns.GetHostEntry(gIp)
        Dim ipAddr As IPAddress = ipHost.AddressList(0)
        Dim ipEndPoint As New IPEndPoint(ipAddr, 44444)

        Dim clientSocket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        ' Connect the socket to the remote end point.
        clientSocket.Connect(ipEndPoint)

        ' Send some data to the remote device.
        Dim data As String = "This is a string of data <EOF>"
        Dim buffer() As Byte = Encoding.ASCII.GetBytes(data)
        Dim bytesTransferred As Integer = clientSocket.Send(buffer)

        ' Write to the console the number of bytes transferred.
        'Console.WriteLine("{0} bytes were sent." & vbLf, bytesTransferred)

        ' Release the socket.
        clientSocket.Shutdown(SocketShutdown.Both)
        clientSocket.Disconnect(True)
        If clientSocket.Connected Then
            'Console.WriteLine("We're still connnected")
        Else
            'Console.WriteLine("We're disconnected")
            Dim dlg As New NoParamsDelegate(AddressOf DisconnectedUI)
            Me.Invoke(dlg)
            Timer1.Stop()
            client.Close()
            listener.Stop()
        End If
    End Sub

    Public Shared Sub ConnectCallback(ByVal ar As IAsyncResult)
        connectDone.Set()
        Dim t As TcpClient = CType(ar.AsyncState, TcpClient)
        t.EndConnect(ar)
    End Sub


    Private Sub DisconnectedUI()
        'Make the UI disabled and show 'disconnected' controls
        Me.Text = Application.ProductName & " - Not Connected"
        'frmChat.btnSend.Enabled = False
        'frmChat.txtSend.Enabled = False
        ''frmChat.Icon = IPChat.My.Resources.Resources.icn_disconnected
        TXTMSG.Text += "Veza prekinuta: " & Now.ToString & "." & vbCrLf
    End Sub

    Private Sub ConnectedUI()
        'Make the UI enabled and show 'connected' controls
        'Me.Hide()
        Me.Text = Application.ProductName & " - Connected"
        'frmChat.btnSend.Enabled = True
        'frmChat.txtSend.Enabled = True
        ''frmChat.Icon = IPChat.My.Resources.Resources.icn_connected
        TXTMSG.Text += "Veza uspostavljena: " & Now.ToString & "." & vbCrLf
        'frmChat.Show()
        'frmChat.txtSend.Focus()
    End Sub

    Private Sub DisplayReceivedData(ByVal Data As String)
        'Display data in the socket stream received from the server
        With TXTMSG
            .SelectionStart = .Text.Length
            .SelectedText = Data & vbCrLf
        End With
    End Sub

    Public Sub test()
        ' Accepts the pending client connection and returns a socket for communciation.
        Dim socket As Socket '''= listener.AcceptSocket()
        Dim responseString As String = "responseString"

        If connected = False Then
            socket = listener.AcceptSocket
            'Console.WriteLine("Connection accepted.")
        End If


        Dim s As String = Convert.ToString(socket.RemoteEndPoint)
        Dim ss(2) As String
        ss = s.Split(":"c)
        gIp = ss(0).ToString
        Application.DoEvents()


        If connected = True Then
            Dim dlg2 As New OneStringDelegate(AddressOf DisplayReceivedData)
            Dim args As String = "Konekcija uspješna s serverom " + gIp.ToString
            Me.Invoke(dlg2, args)

            client = New TcpClient(gIp, 44444)
            listener.Start()
            Dim writer As New StreamWriter(client.GetStream())
            writer.Write("Zahtjev prihvaćen!")
            writer.Flush()


            'trd2 = New Thread(AddressOf endSession)
            'trd2.IsBackground = True
            'trd2.Start()


            Application.DoEvents()
            Application.DoEvents()
            Application.DoEvents()

        Else
            If MessageBox.Show("Želite li otvoriti konekciju prema serveru """ + gIp + """", "Naslov", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Dim dlg As New NoParamsDelegate(AddressOf ConnectedUI)
                Me.Invoke(dlg)
                Application.DoEvents()

                'CheckClients()

                client = New TcpClient(gIp, 44444)
                'listener.Start()
                Dim writer As New StreamWriter(client.GetStream())
                writer.Write("Zahtjev prihvaćen!")
                writer.Flush()


                'trd2 = New Thread(AddressOf endSession)
                'trd2.IsBackground = True
                'trd2.Start()


                ''Forms and sends a response string to the connected client.
                'Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(responseString)
                'Dim i As Integer = socket.Send(sendBytes)
                'Console.WriteLine(("Message Sent /> : " + responseString))
            Else
                ''zatvoriti konekciju
                cmdConnect.Text = "Disconnect"
            End If


        End If

    End Sub


    Public Sub ThreadTask()
        test()
    End Sub

#End Region


End Class

