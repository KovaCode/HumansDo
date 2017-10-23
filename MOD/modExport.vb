
Imports System.Drawing
Imports System.Diagnostics
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid

Module modExport

    Dim g As GridControl



    Public Function CreateXLS(ByVal CTRL As Object)
        Dim sf As SaveFileDialog = New SaveFileDialog

        'If Permission <> 1 Then DevExpress.XtraEditors.XtraMessageBox.Show("You don't have permission to export data. Please contact application administrator.", "Export Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        sf.Filter = "Excel Files(*.)|*.xls"
        sf.RestoreDirectory = True


        Try
            If sf.ShowDialog = Windows.Forms.DialogResult.OK Then
                CTRL.ExportToXls(sf.FileName)
                If alerter.SHOW("i", "Izvoz podataka", "Podaci uspješno izvezeni!|Želite li otvoriti izvezenu datoteku sada?", "Da|Ne", 0, 0) = 0 Then
                    System.Diagnostics.Process.Start(sf.FileName)
                End If
            End If
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message, "Nastavak")
        End Try
    End Function


    Public Function CreateXLSX(ByVal CTRL As Object)
        Dim sf As SaveFileDialog = New SaveFileDialog

        'If Permission <> 1 Then DevExpress.XtraEditors.XtraMessageBox.Show("You don't have permission to export data. Please contact application administrator.", "Export Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        sf.Filter = "Excel Files(*.XLSX)|*.xlsx"
        sf.RestoreDirectory = True

        Try
            If sf.ShowDialog = Windows.Forms.DialogResult.OK Then
                CTRL.ExportToXlsx(sf.FileName)
                If alerter.SHOW("i", "Izvoz podataka", "Podaci uspješno izvezeni!|Želite li otvoriti izvezenu datoteku sada?", "Da|Ne", 0, 0) = 0 Then
                    System.Diagnostics.Process.Start(sf.FileName)
                End If
            End If
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message, "Nastavak")
        End Try
    End Function


    Public Function createPDF(ByVal CTRL As Object)
        Dim sf As SaveFileDialog = New SaveFileDialog

        'If Permission <> 1 Then DevExpress.XtraEditors.XtraMessageBox.Show("You don't have permission to export data. Please contact application administrator.", "Export Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        sf.Filter = "Adobe PDF(*.PDF)|*.pdf"
        sf.RestoreDirectory = True

        Try
            If sf.ShowDialog = Windows.Forms.DialogResult.OK Then
                CTRL.ExportToPdf(sf.FileName)
                If alerter.SHOW("i", "Izvoz podataka", "Podaci uspješno izvezeni!|Želite li otvoriti izvezenu datoteku sada?", "Da|Ne", 0, 0) = 0 Then
                    System.Diagnostics.Process.Start(sf.FileName)
                End If
            End If
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message, "Nastavak")
        End Try
    End Function


    Public Function createHTML(ByVal CTRL As Object)
        Dim sf As SaveFileDialog = New SaveFileDialog

        'If Permission <> 1 Then DevExpress.XtraEditors.XtraMessageBox.Show("You don't have permission to export data. Please contact application administrator.", "Export Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        sf.Filter = "Web page(*.HTML)|*.html"
        sf.RestoreDirectory = True

        Try
            If sf.ShowDialog = Windows.Forms.DialogResult.OK Then
                CTRL.ExportToPdf(sf.FileName)
                If alerter.SHOW("i", "Izvoz podataka", "Podaci uspješno izvezeni!|Želite li otvoriti izvezenu datoteku sada?", "Da|Ne", 0, 0) = 0 Then
                    System.Diagnostics.Process.Start(sf.FileName)
                End If
            End If
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message, "Nastavak")
        End Try
    End Function


    Public Function createRTF(ByVal CTRL As Object)
        Dim sf As SaveFileDialog = New SaveFileDialog

        'If Permission <> 1 Then DevExpress.XtraEditors.XtraMessageBox.Show("You don't have permission to export data. Please contact application administrator.", "Export Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        sf.Filter = "Rich text format (*.RTF)|*.rtf"
        sf.RestoreDirectory = True

        Try
            If sf.ShowDialog = Windows.Forms.DialogResult.OK Then
                CTRL.ExportToRtf(sf.FileName)
                If alerter.SHOW("i", "Izvoz podataka", "Podaci uspješno izvezeni!|Želite li otvoriti izvezenu datoteku sada?", "Da|Ne", 0, 0) = 0 Then
                    System.Diagnostics.Process.Start(sf.FileName)
                End If
            End If
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message, "Nastavak")
        End Try
    End Function


    Public Function createTXT(ByVal CTRL As Object)
        Dim sf As SaveFileDialog = New SaveFileDialog

        'If Permission <> 1 Then DevExpress.XtraEditors.XtraMessageBox.Show("You don't have permission to export data. Please contact application administrator.", "Export Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        sf.Filter = "Rich text format (*.txt)|*.txt"
        sf.RestoreDirectory = True

        Try
            If sf.ShowDialog = Windows.Forms.DialogResult.OK Then

                CTRL.ExportToText(sf.FileName)
                If alerter.SHOW("i", "Izvoz podataka", "Podaci uspješno izvezeni!|Želite li otvoriti izvezenu datoteku sada?", "Da|Ne", 0, 0) = 0 Then
                    System.Diagnostics.Process.Start(sf.FileName)
                End If
            End If
        Catch ex As Exception
            alerter.SHOW("x", "Greška", ex.Message, "Nastavak")
        End Try
    End Function

End Module
