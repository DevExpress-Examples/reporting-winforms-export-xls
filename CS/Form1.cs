using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System;

namespace XlsExportExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            // Create a report.
            XtraReport report = new XtraReport() {
                Name = "Report Example",
                Bands = {
                    new DetailBand() {
                        Controls = {
                            new XRLabel() {
                                Text = "Some content goes here...",
                            }
                        }
                    }
                }
            };

            // Specify export options.
            XlsExportOptions xlsExportOptions = new XlsExportOptions() {
                ExportMode = XlsExportMode.SingleFile,
                ShowGridLines = true,
                FitToPrintedPageHeight = true
            };

            // Export the report.
            report.ExportToXls("test.xls", xlsExportOptions);
            System.Diagnostics.Process.Start("test.xls");
        }
    }
}
