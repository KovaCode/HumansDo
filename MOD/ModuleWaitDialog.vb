Module ModuleWaitDialog
    Private Dlg As DevExpress.Utils.WaitDialogForm = Nothing

    Public Sub CreateWaitDialog(Optional ByVal Caption As String = "", Optional ByVal Title As String = "")
        If Title = "" Then
            Dlg = New DevExpress.Utils.WaitDialogForm(Caption)
        Else
            Dlg = New DevExpress.Utils.WaitDialogForm(Caption, Title)
        End If
    End Sub
    Public Sub CloseWaitDialog()
        Dlg.Close()
    End Sub
    Public Sub SetWaitDialogCaption(ByVal fCaption As String)
        If Dlg IsNot Nothing Then
            Dlg.Caption = fCaption
        End If
    End Sub
End Module