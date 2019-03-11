using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.CONTROL.Relatorio
{
    public partial class fmr_PrintService : Form
    {
        public fmr_PrintService()
        {
            InitializeComponent();
        }

        private void fmr_PrintService_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'paypeYan.DataTable1'. Você pode movê-la ou removê-la conforme necessário.
            //this.dataTable1TableAdapter.Fill(this.paypeYan.DataTable1);

           // this.reportViewer1.RefreshReport();
        }
    }
}
