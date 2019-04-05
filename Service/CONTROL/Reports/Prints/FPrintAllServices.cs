using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.CONTROL.Reports.Prints
{
    public partial class FPrintAllServices : Form
    {
        public FPrintAllServices()
        {
            InitializeComponent();
        }

        private void FPrintAllServices_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dReportPrint.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            this.dataTable1TableAdapter.Fill(this.dReportPrint.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
