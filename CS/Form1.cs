using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System;

namespace XlsExportExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
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

            // Specify the path for the exported XLS file.  
            string xlsExportFile =
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                @"\Downloads\" +
                report.Name +
                ".xls";

            // Export the report.
            report.ExportToXls(xlsExportFile, xlsExportOptions);
        }
    }
}
