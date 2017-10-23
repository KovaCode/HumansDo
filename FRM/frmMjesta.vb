#Region "Imports"
Imports System.Data.SqlClient
#End Region


Public Class frmMjesta

#Region "Dim's"
    Dim iZupanija As Object
    Dim iMjesto As Object
    Dim iUlica As Object
#End Region


#Region "Init form"
    Public Sub New()
        InitializeComponent()
        LocalizeME()
    End Sub

    Private Sub frmMjesta_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        fillGridZupanija()
    End Sub
#End Region


#Region "Click's"
    Private Sub cmd_Click(sender As System.Object, e As System.EventArgs) Handles cmdNew.Click
        Dim frm As New frmMjestaUnos()
        frm.Show()
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
                    CTRL.Controls(i).enabled = checkSpecial(CTRL.controls(i))

                    If CTRL.Controls(i).HasChildren Then
                        For j = 0 To CTRL.Controls(i).Controls.Count - 1
                            CTRL.Controls(i).controls(j).Text = rm.GetString(CTRL.Controls(i).Controls(j).name.ToString)
                            CTRL.Controls(i).controls(j).enabled = checkSpecial(CTRL.controls(i).controls(j))
                        Next
                    End If
                Next
            End If
            Debug.Print(CTRL.name)
        Next CTRL

        cmdNew.Text = rm.GetString(cmdNew.Name) : cmdEdit.Enabled = checkSpecial(cmdNew)
        cmdEdit.Text = rm.GetString(cmdEdit.Name) : cmdEdit.Enabled = checkSpecial(cmdEdit)        
        cmdPrint.Text = rm.GetString(cmdPrint.Name) : cmdEdit.Enabled = checkSpecial(cmdPrint)
        cmdExit.Text = rm.GetString(cmdExit.Name)


        ''grid županije
        For Each colS In gridViewZ.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid mjesto
        For Each colS In gridViewM.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        ''grid ulice
        For Each colS In gridViewU.Columns
            colS.caption = rm.GetString(colS.name.ToString)
        Next

        groupZupanija.Text = rm.GetString("groupZupanija")
        groupMjesta.Text = rm.GetString("groupMjesta")
        groupUlice.Text = rm.GetString("groupUlice")

    End Sub

#End Region


#Region "gridZupanije"
    Private Sub fillGridZupanija()
        Dim DA As SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("GridZupanija") > -1 Then
            DS.Tables("GridZupanija").Clear()
        End If

        DA = New SqlDataAdapter("select * from zupanije", gCN)
        Try
            DA.Fill(DS, "GridZupanija")
        Catch e As SqlException
            alerter.showErr("GridZupanija" + e.Message)
        End Try

        gridZupa.DataSource = DS.Tables("GridZupanija")
        gridViewZ.OptionsPrint.UsePrintStyles = True
        gridViewZ.OptionsPrint.EnableAppearanceEvenRow = True
        gridViewZ.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        'DS.Reset() : DS.Dispose()

    End Sub

    Private Sub gridViewZ_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewZ.FocusedRowChanged
        iZupanija = gridViewZ.GetRowCellValue(e.FocusedRowHandle, colIDZ)
        fillGridMjesto(iZupanija)
    End Sub

    Private Sub gridViewZ_DoubleClick(sender As Object, e As System.EventArgs) Handles gridViewZ.DoubleClick
        Dim frm As New frmMjestaUnos(frmMjestaUnos.vrstaZMU.Županija, iZupanija)
        frm.ShowDialog(Me)
    End Sub

#End Region


#Region "gridMjesto"
    Private Sub fillGridMjesto(id As Integer)
        Dim DA As SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("GridMjesto") > -1 Then
            DS.Tables("GridMjesto").Clear()
        End If

        DA = New SqlDataAdapter("select * from mjesta where zupanija=" + id.ToString + " order by naselje", gCN)
        Try
            DA.Fill(DS, "GridMjesto")
        Catch e As SqlException
            alerter.showErr("GridMjesto" + e.Message)
        End Try

        gridMjesto.DataSource = DS.Tables("GridMjesto")
        'gridMjesto.OptionsPrint.UsePrintStyles = True
        'gridMjesto.OptionsPrint.EnableAppearanceEvenRow = True
        'gridMjesto.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        'DS.Reset() : DS.Dispose()

    End Sub

    Private Sub gridViewM_DoubleClick(sender As Object, e As System.EventArgs) Handles gridViewM.DoubleClick
        Dim frm As New frmMjestaUnos(frmMjestaUnos.vrstaZMU.Mjesto, iMjesto)
        frm.ShowDialog(Me)
    End Sub

    Private Sub gridViewM_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewM.FocusedRowChanged
        iMjesto = gridViewM.GetRowCellValue(e.FocusedRowHandle, colIDM)
        fillGridUlice(iMjesto)
    End Sub
#End Region


#Region "gridUlice"
    Private Sub fillGridUlice(id As Integer)
        Dim DA As SqlDataAdapter
        Dim DS As New DataSet

        If DS.Tables.IndexOf("GridUlice") > -1 Then
            DS.Tables("GridUlice").Clear()
        End If

        DA = New SqlDataAdapter("select * from ulice where mjesto=" + id.ToString + " order by naziv", gCN)
        Try
            DA.Fill(DS, "GridUlice")
        Catch e As SqlException
            alerter.showErr("GridUlice" + e.Message)
        End Try

        gridUlica.DataSource = DS.Tables("GridUlice")
        'gridMjesto.OptionsPrint.UsePrintStyles = True
        'gridMjesto.OptionsPrint.EnableAppearanceEvenRow = True
        'gridMjesto.AppearancePrint.EvenRow.BackColor = Color.LightYellow

        'DS.Reset() : DS.Dispose()

    End Sub


    Private Sub gridViewU_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewU.FocusedRowChanged
        iUlica = gridViewU.GetRowCellValue(e.FocusedRowHandle, colIDU)
    End Sub

    Private Sub gridViewU_DoubleClick(sender As Object, e As System.EventArgs) Handles gridViewU.DoubleClick
        Dim frm As New frmMjestaUnos(frmMjestaUnos.vrstaZMU.Ulica, iUlica)
        frm.ShowDialog(Me)
    End Sub

#End Region



    Private Sub cmdExit_Click(sender As System.Object, e As System.EventArgs) Handles cmdExit.Click
        Me.Dispose()
    End Sub
End Class