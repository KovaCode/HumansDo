Imports System.Data.SqlClient

Public Class frmKategorije

#Region "Dim's"
    Dim CN As SqlClient.SqlConnection
    Dim CM As SqlClient.SqlCommand
    Dim DR As SqlClient.SqlDataReader
    Dim DS As New DataSet
    Dim DA As SqlDataAdapter
    Dim DT As DataTable
    Dim iID As Integer
#End Region


#Region "Init Form"
    Public Sub New()
        InitializeComponent()
        localizeME()
    End Sub


    Private Sub frmKategorije_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        fillGrid()
    End Sub
#End Region


#Region "Click's"

    Private Sub cmdEdit_Click(sender As System.Object, e As System.EventArgs) Handles cmdEdit.Click, cmdNew.Click, cmdDelete.Click
        Select Case sender.name
            Case "cmdEdit"
                Dim frm As New frmKategUnos(iID)
                frm.ShowDialog(Me)
                fillGrid()

            Case "cmdNew"
                Dim frm As New frmKategUnos
                frm.ShowDialog(Me)
                fillGrid()

            Case "cmdDelete"
                If alerter.SHOW(alerter.icona.upit, alerter.naslov.Brisanje, rm.GetString("mess7")) = 0 Then
                    Obrisi(iID)
                    fillGrid()
                    alerter.SHOW(alerter.icona.info, alerter.naslov.Brisanje, rm.GetString("mess8"))
                End If

        End Select

    End Sub
#End Region


#Region "procedure i funkcije"

    Private Sub localizeME()
        Me.Text = gAPPNAME + " - (" + gAPPVER + ") - " + rm.GetString(Me.Name)

        For Each CTRL In Me.Controls
            CTRL.text = rm.GetString(CTRL.name.ToString)
            If CTRL.GetType.Name = "SimpleButton" Then
                CTRL.enabled = checkSpecial(CTRL)
            End If

            If CTRL.name <> "tab" Then
                If CTRL.HasChildren Then
                    For i = 0 To CTRL.Controls.Count - 1
                        CTRL.Controls(i).Text = rm.GetString(CTRL.Controls(i).name.ToString)
                        If CTRL.Controls(i).GetType.Name = "SimpleButton" Then
                            CTRL.Controls(i).enabled = checkSpecial(CTRL.Controls(i))
                        End If
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


        ''grid
        For Each colS In gridView.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next


    End Sub

    Private Sub Obrisi(ByVal id As Integer)
        CN = New SqlConnection(gDATABASE)
        CN.Open()

        DA.DeleteCommand = CN.CreateCommand()
        DA.DeleteCommand.CommandText = "delete from kategorije where id=" + id.ToString
        DA.DeleteCommand.ExecuteNonQuery()

    End Sub

#End Region


#Region "grid"

    Private Sub fillGrid()
        If DS.Tables.IndexOf("grid") > -1 Then
            DS.Tables("grid").Clear()
        End If


        DA = New SqlDataAdapter("select * from kategorije where tip =0 UNION select * from kategorije where tip =1 and oper=" + gOper.ToString, gCN)
        DA.Fill(DS, "grid")


        If DS.Tables("grid").Rows.Count > 0 Then
            grid.DataSource = DS.Tables("grid")
        End If
    End Sub

    Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        grid.DefaultView.GetRow(e.FocusedRowHandle)
        iID = gridView.GetRowCellValue(e.FocusedRowHandle, colID)
    End Sub

#End Region


End Class