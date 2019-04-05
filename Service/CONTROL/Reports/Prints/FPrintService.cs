using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalendarDemo;
using System.Windows.Forms.Calendar;

namespace Service.CONTROL.Relatorio
{
    public partial class FServiceWeek : Form
    {
        String vHandleService = "";

        public FServiceWeek(String prHandleService)
        {
            InitializeComponent();
            vHandleService = prHandleService;

        }

        private void FServiceWeek_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dReportPrint.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTable1TableAdapter.Fill(this.dReportPrint.DataTable1);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("handleServiceParameter", vHandleService));
            this.reportViewer1.RefreshReport();
        }
    }
}
