'#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports System.Diagnostics
Imports DevExpress.XtraPrinting

' ...
'#End Region  ' #usings
Namespace ExportToXlsCS

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

'#Region "#export"
        Private Sub ExportToXLS()
            ' A path to export a report.
            Dim reportPath As String = "c:\Test.xls"
            ' Create a report instance.
            Dim report As XtraReport1 = New XtraReport1()
            ' Get its XLS export options.
            Dim xlsOptions As XlsExportOptions = report.ExportOptions.Xls
            ' Set XLS-specific export options.
            xlsOptions.ShowGridLines = True
            xlsOptions.TextExportMode = TextExportMode.Value
            ' Export the report to XLS.
            report.ExportToXls(reportPath)
            ' Show the result.
            StartProcess(reportPath)
        End Sub

'#End Region  ' #export
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            ExportToXLS()
        End Sub

'#Region "#startprocess"
        ' Use this method if you want to automaically open
        ' the created XLS file in the default program.
        Public Sub StartProcess(ByVal path As String)
            Dim process As Process = New Process()
            Try
                process.StartInfo.FileName = path
                process.Start()
                process.WaitForInputIdle()
            Catch
            End Try
        End Sub
'#End Region  ' #startprocess
    End Class
End Namespace
