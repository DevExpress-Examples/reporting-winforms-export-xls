Imports System.Diagnostics
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
' ...

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' A path to export a report.
        Dim reportPath As String = "c:\\Test.xls"

        ' Create a report instance.
        Dim report As New XtraReport1()

        ' Get its XLS export options.
        Dim xlsOptions As XlsExportOptions = report.ExportOptions.Xls

        ' Set XLS-specific export options.
        xlsOptions.ShowGridLines = True
        xlsOptions.UseNativeFormat = True

        ' Export the report to XLS.
        report.ExportToXls(reportPath)

        ' Show the result.
        StartProcess(reportPath)
    End Sub

    ' Use this method if you want to automaically open
    ' the created XLS file in the default program.
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub
End Class
