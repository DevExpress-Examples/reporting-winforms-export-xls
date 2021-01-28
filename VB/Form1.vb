Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports System

Namespace XlsExportExample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a report.
			Dim report As New XtraReport() With {
				.Name = "Report Example",
				.Bands = {
					New DetailBand() With {
						.Controls = {
							New XRLabel() With {.Text = "Some content goes here..."}
						}
					}
				}
			}

			' Specify export options.
			Dim xlsExportOptions As New XlsExportOptions() With {
				.ExportMode = XlsExportMode.SingleFile,
				.ShowGridLines = True,
				.FitToPrintedPageHeight = True
			}

			' Specify the path for the exported XLS file.  
			Dim xlsExportFile As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads\" & report.Name & ".xls"

			' Export the report.
			report.ExportToXls(xlsExportFile, xlsExportOptions)
		End Sub
	End Class
End Namespace
