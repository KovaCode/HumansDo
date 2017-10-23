
#Region "Imports"
Imports System.Data.SqlClient
Imports System.IO
#End Region

Public Class frmFiles

#Region "Dim's"
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable

    Dim picFileName As String
    Dim picID As Long
    Dim idBroj As Integer
    Dim picExt As String
    Dim idGrid As Integer
    Dim iTip As String
    Dim flgSpremi As Boolean
#End Region


#Region "Init Form"
    Public Sub New(Optional ByVal id As Integer = 0, Optional ByVal tip As String = "*", Optional ByVal spremanje As Boolean = True)
        InitializeComponent()
        localizeME()

        CN = New SqlConnection(gDATABASE)
        CN.Open()

        idBroj = id
        iTip = tip
        flgSpremi = spremanje

        If flgSpremi = False Then
            cmdSave.Visible = False
        Else
            cmdSave.Visible = True
        End If
    End Sub

    Private Sub frmFiles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillGrid()
    End Sub

    Private Sub frmFiles_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        clearTEMP()
    End Sub
#End Region


#Region "grid"

    Private Sub fillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If

        DA = New SqlDataAdapter("select naziv,id,tip,(cast(sizeKB as varchar(10)) + ' KB')sizeKB from images where veza=" + idBroj.ToString + " and vrsta='" + iTip.ToString + "'", gCN)
        DA.Fill(DS, "grid")


        If DS.Tables("grid").Rows.Count > 0 Then
            cmdOpen.Enabled = True
        Else
            cmdOpen.Enabled = False
        End If

        grid.DataSource = DS.Tables("grid")
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        idGrid = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        loadFileSQL(idGrid)
    End Sub

    Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView.CustomUnboundColumnData
        Dim img As Image = Nothing

        If e.Column.FieldName = "Image" AndAlso e.IsGetData Then
            Select Case gridView.GetRowCellValue(e.RowHandle, colImageID)
                Case "png"

                Case "pdf"
                    img = getPicDB(38)

                Case "docx", "doc"
                    img = getPicDB(40)

                Case "xls", "xlsx"
                    img = getPicDB(41)
                Case "msg"
                    img = getPicDB(57)
                Case "jpg", "jpeg"
                    img = getPicDB(59)
            End Select

            e.Value = img
        End If
    End Sub
#End Region


#Region "Click's"

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click, cmdSave.Click
        Select Case sender.name
            Case "cmdOpen.Click"
                loadFileSQL(idGrid)

            Case "cmdExit"
                Me.Dispose()
                clearTEMP()

            Case "cmdSave"
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Pažnja, rm.GetString("mess5"), alerter.button.DaNe) = 0 Then
                    saveFile()
                End If
        End Select
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
                    If CTRL.Controls(i).HasChildren Then
                        For j = 0 To CTRL.Controls(i).Controls.Count - 1
                            CTRL.Controls(i).controls(j).Text = rm.GetString(CTRL.Controls(i).Controls(j).name.ToString)
                            If CTRL.Controls(i).Controls(j).HasChildren Then
                                For k = 0 To CTRL.Controls(i).Controls(j).Controls.Count - 1
                                    CTRL.Controls(i).controls(j).Controls(k).Text = rm.GetString(CTRL.Controls(i).Controls(j).Controls(k).name.ToString)
                                Next
                            End If

                        Next
                    End If
                Next
            End If
        Next CTRL


        ''grid
        For Each colS In gridView.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next
    End Sub


    Private Sub saveFile()
        Me.OpenFileDialog1.Filter = "Adobe PDF|*.pdf|Microsoft Word 97-2003 document|*.doc|Microsoft Word document|*.docx|Microsoft Excel 97/03 document|*.xls|Microsoft Excel document|*.xlsx|Power point|*.ppt|Outlook message|*msg|All Files|*.*"
        If (Me.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            picFileName = Me.OpenFileDialog1.FileName
            'picID = SavePicDB(OpenFileDialog1.FileName, idBroj)

            picID = saveFileSQL(OpenFileDialog1.FileName, idBroj, iTip)
            fillGrid()
        End If
    End Sub

#End Region


End Class