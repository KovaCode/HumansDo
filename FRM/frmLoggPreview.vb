#Region "Imports"
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors
Imports System.Xml
Imports DevExpress.XtraTreeList.Nodes
#End Region

Public Class frmLoggPreview

#Region "Dim's"
    Dim iopt As Integer
#End Region


#Region "Init Form"
    Public Sub New()
        InitializeComponent()
        localizeME()
    End Sub

    Private Sub frmLoggPreview_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        readXML()
        tl.MoveLast()
        tl.Nodes.FirstNode.Expanded = True
    End Sub
#End Region


#Region "Click's"

    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click, cmdPrint.Click, cmdExport.Click

        Select Case sender.name
            Case "cmdExit"
                Me.Dispose()

            Case "cmdExport"
                Select Case iopt
                    Case 0  'PDF
                        createPDF(tl)
                    Case 1  'XLS
                        CreateXLS(tl)
                    Case 2  'XLSX
                        CreateXLSX(tl)
                    Case 3  'RTF
                        createRTF(tl)
                    Case 4  'HTML
                        createHTML(tl)
                    Case 5
                        createTXT(tl)
                End Select

            Case "cmdPrint"
                Dim frmPrint As New frmPrint(tl, rm.GetString("loggPreview"), False)
                frmPrint.ShowDialog(Me)
        End Select

    End Sub

    Private Sub optExport_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles optExport.SelectedIndexChanged
        iopt = optExport.SelectedIndex
        cmdExport.Text = rm.GetString("cmdExport") + "(" + optExport.Properties.Items(iopt).Description + ")"
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
                    If CTRL.Controls(i).HasChildren Then
                        For j = 0 To CTRL.Controls(i).Controls.Count - 1
                            CTRL.Controls(i).controls(j).Text = rm.GetString(CTRL.Controls(i).Controls(j).name.ToString)
                            CTRL.Controls(i).controls(j).enabled = checkSpecial(CTRL.Controls(i).controls(j))
                            If CTRL.Controls(i).Controls(j).HasChildren Then
                                For k = 0 To CTRL.Controls(i).Controls(j).Controls.Count - 1
                                    CTRL.Controls(i).controls(j).Controls(k).Text = rm.GetString(CTRL.Controls(i).Controls(j).Controls(k).name.ToString)
                                    CTRL.Controls(i).controls(j).Controls(k).enabled = checkSpecial(CTRL.Controls(i).controls(j).Controls(k))
                                Next
                            End If

                        Next
                    End If
                Next
            End If
        Next CTRL


        ''grid
        For Each colS In tl.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

    End Sub

    Private Function formatXML(str As String, ByRef cstDate As String) As String
        Dim tempStr As String
        Dim tdate As String
        Dim tTime As String

        tempStr = str
        tempStr = Mid(str, 2)
        tdate = Mid(str, 2, (InStr(tempStr, "-") - 1)) + "."
        cstDate = tdate

        tTime = Mid(str, (InStr(tempStr, "-") + 2), 6)
        tTime = tTime.Insert(2, ":")
        tTime = tTime.Insert(5, ":")
        'tTime = tTime.Insert(8, ".")

        formatXML = "(" + tTime + ")"

    End Function

    Public Sub readXML()
        Dim sStart As String
        Dim SValue As String
        Dim line As String
        Dim CustomDate As String
        Dim tCustomDate As String
        Dim chkSum As String
        Dim reader As XmlTextReader = New XmlTextReader(gLOGGPATH)

        tl.ClearNodes()
        tl.Nodes.Clear()

        Dim root As TreeListNode = Nothing
        Dim child As TreeListNode '''= tl.AppendNode(New Object() {"loggs", ""}, root)
        Dim child2 As TreeListNode
        Dim child3 As TreeListNode


        Do While (reader.Read())
            Select Case reader.NodeType

                Case XmlNodeType.Element 'Display beginning of element.
                    'Console.Write("<" + reader.Name + ">")
                    If InStr(reader.Name, "_") = 1 Then
                        sStart = formatXML(reader.Name, CustomDate)
                        chkSum = reader.GetAttribute(0)
                    ElseIf InStr(reader.Name, "_") > 1 Then
                        child = tl.AppendNode(New Object() {reader.Name, "", ""}, root)
                    Else
                        sStart = reader.Name
                    End If

                    If CustomDate <> "" And CustomDate <> tCustomDate Then
                        child2 = tl.AppendNode(New Object() {CustomDate, "", ""}, child)
                        tCustomDate = CustomDate
                    End If

                Case XmlNodeType.Text 'Display the text in each element.
                    'Console.Write(reader.Value)
                    SValue = reader.Value
                    child3 = tl.AppendNode(New Object() {sStart, SValue, chkSum}, child2)


                Case XmlNodeType.EndElement 'Display end of element.
                    'Console.WriteLine("</" + reader.Name + ">")
                    line = ""
                    line = sStart + " - " + SValue

            End Select
        Loop
    End Sub

#End Region


End Class