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
            vLoadBox();
        }

        private void FPrintAllServices_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cRefresButton_Click(object sender, EventArgs e)
        {


            this.dataTable1TableAdapter.Fill(this.dReportPrint.DataTable1);

            // REPASSANDO OS PARÂMETROS PARA O RELATÓRIO

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            this.reportViewer1.RefreshReport();
        }

        private void vLoadBox()
        {
            DAO.DBConnection dBConnection = new DAO.DBConnection();

            DataTable vDataReferences = dBConnection.DataAdapter("SELECT REFERENCIA FROM SV_REFERENCIA");
            cReferenciaBox.DataSource = vDataReferences;
            cReferenciaBox.ValueMember = "REFERENCIA";

            DataTable vDataTeam = dBConnection.DataAdapter("SELECT NOME FROM SV_EQUIPE");
            cTeamBox.DataSource = vDataTeam;
            cTeamBox.ValueMember = "NOME";

            DataTable vDataStatus = dBConnection.DataAdapter("SELECT NOME FROM SV_STATUS");
            cStatusBox.DataSource = vDataStatus;
            cStatusBox.ValueMember = "NOME";


        }

        private void cDeDate_ValueChanged(object sender, EventArgs e)
        {

            DateTime vDateNotConverted = DateTime.Parse(cDeDate.Text);
            cDeBox.Text = vDateNotConverted.ToString("dd/MM/yyyy HH:mm:ss");
             
        }

        private void cAteDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime vDateNotConverted = DateTime.Parse(cAteDate.Text);
            cAteBox.Text = vDateNotConverted.ToString("dd/MM/yyyy HH:mm:ss");
        }


    }
}
