#region #usings
using System;
using System.Windows.Forms;
using System.Diagnostics;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
// ...
#endregion #usings

namespace ExportToXlsCS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #export
        private void ExportToXLS() {
            // A path to export a report.
            string reportPath = "c:\\Test.xls";

            // Create a report instance.
            XtraReport1 report = new XtraReport1();

            // Get its XLS export options.
            XlsExportOptions xlsOptions = report.ExportOptions.Xls;

            // Set XLS-specific export options.
            xlsOptions.ShowGridLines = true;
            xlsOptions.TextExportMode = TextExportMode.Value;

            // Export the report to XLS.
            report.ExportToXls(reportPath);

            // Show the result.
            StartProcess(reportPath);
        }
        #endregion #export

        private void button1_Click(object sender, EventArgs e) {
            ExportToXLS();
        }

        #region #startprocess
        // Use this method if you want to automaically open
        // the created XLS file in the default program.
        public void StartProcess(string path) {
            Process process = new Process();
            try {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }
        #endregion #startprocess
    }
}