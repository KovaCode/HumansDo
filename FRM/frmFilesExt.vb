#Region "Imports"
Imports System.Data.SqlClient
#End Region

Public Class frmFilesExt

#Region "Dim's"
    Dim idGrid As Integer
#End Region


#Region "Init Form"
    Public Sub New()
        InitializeComponent()
        localizeME()
    End Sub


    Private Sub frmFilesExt_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillgrids()
    End Sub
#End Region


#Region "Click's"

    Private Sub cmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click, cmdExit.Click
        Select Case sender.name
            Case "cmdOpen.Click"
                loadFileSQL(idGrid)

            Case "cmdExit"
                Me.Dispose()
                clearTEMP()

            Case "cmdPrint"
                Dim frm As New frmPrint(grid, rm.GetString("pregledPriloga"), False)
                frm.ShowDialog(Me)

        End Select
    End Sub

#End Region


#Region "grid"
    Private Sub fillgrids()
        Dim DA As New SqlDataAdapter
        Dim DS As DataSet = New DataSet

        DA = New SqlDataAdapter("select id,image,dbo.getOsoba(oper)sOper,naziv,(cast(sizeKB as varchar(10)) + ' KB')as sizeKB,tip,vrsta, " _
                              + " (case vrsta  " _
                              + " when '*' then '" + rm.GetString("System") + "'  " _
                              + " when 'TEZ' then '" + rm.GetString("Tezina") + "'  " _
                              + " when 'M' then '" + rm.GetString("Poruke") + "'   " _
                              + " when 'PR' then '" + rm.GetString("Projekt") + "'  " _
                              + " when 'P' then '" + rm.GetString("Prioritet") + "'  " _
                              + " when 'O' then '" + rm.GetString("Operateri") + "'  " _
                              + " when 'Z' then '" + rm.GetString("Zadatak") + "'  " _
                              + " when 'TST' then '" + rm.GetString("Test") + "' " _
                              + " when 'K' then '" + rm.GetString("Klijent") + "' end)AS sVrsta " _
                               + " from images where vrsta <> '*' order by tip", gCN)

        Try
            DA.Fill(DS, "files")
        Catch ex As Exception
            alerter.showErr(ex)
        End Try

        grid.DataSource = DS.Tables("files")
        grid.ForceInitialize()

    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        idGrid = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
    End Sub

    Private Sub grid_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grid.DoubleClick
        If idGrid > 0 Then
            loadFileSQL(idGrid)
        End If
    End Sub

    Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView.CustomUnboundColumnData
        Dim img As Image = Nothing

        If e.Column.FieldName = "Image" AndAlso e.IsGetData Then
            Select Case gridView.GetRowCellValue(e.RowHandle, colTip)
                Case "png"

                Case "pdf"
                    img = getPicDB(38)

                Case "docx", "doc"
                    img = getPicDB(40)

                Case "xls", "xlsx"
                    img = getPicDB(41)
                Case "msg"
                    img = getPicDB(57)
                    'Case "jpg", "jpeg"
                    '    img = getPicDB(59)
            End Select

            e.Value = img
        End If
    End Sub

#End Region


#Region "procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            CTRL.enabled = checkSpecial(CTRL)

            If CTRL.HasChildren Then
                For i = 0 To CTRL.Controls.Count - 1
                    CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)
                    CTRL.Controls(i).enabled = checkSpecial(CTRL)
                    If CTRL.Controls(i).HasChildren Then
                        For j = 0 To CTRL.Controls(i).Controls.Count - 1
                            CTRL.Controls(i).controls(j).Text = rm.GetString(CTRL.Controls(i).Controls(j).name.ToString)
                            CTRL.Controls(i).controls(j).enabled = checkSpecial(CTRL)
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

        'lblTotal.Text = rm.GetString("lblTotal")
    End Sub

#End Region


End Class