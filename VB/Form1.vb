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

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			' Create a report.
			Dim report As New XtraReport() With {.Name = "SampleReport"}
			Dim detail As New DetailBand()
			detail.Controls.Add(New XRLabel() With {.Text = "Some content goes here..."})
			report.Bands.Add(detail)

			' Specify export options.
			Dim xlsExportOptions As New XlsExportOptions() With {
				.ExportMode = XlsExportMode.SingleFile,
				.ShowGridLines = True,
				.FitToPrintedPageHeight = True
			}

			' Export the report.
			report.ExportToXls("test.xls", xlsExportOptions)
			System.Diagnostics.Process.Start("test.xls")
		End Sub
	End Class
End Namespace
