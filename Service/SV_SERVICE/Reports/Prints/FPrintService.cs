using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.SV_SERVICE.Reports.Prints
{
    public partial class FPrintService : Form
    {
        String vHandleService = "";
        public FPrintService(String prHandleService)
        {
            InitializeComponent();
            vHandleService = prHandleService;
        }

        private void FPrintService_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dReportPrint.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTable1TableAdapter.Fill(this.dReportPrint.DataTable1);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("handleParamater", vHandleService));

            this.reportViewer1.RefreshReport();
        }
    }
}
