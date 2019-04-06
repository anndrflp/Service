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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cRefresButton_Click(object sender, EventArgs e)
        {


            this.dataTable1TableAdapter.Fill(this.dReportPrint.DataTable1);


            // REPASSANDO OS PARÂMETROS PARA O RELATÓRIO


            MessageBox.Show(Convert.ToString(cEhRebocada.Checked));

             /*reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehCobertaParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehRebocadaParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehObraProntaParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehMedidaCombinadaParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehClienteAvisaParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehConfirmadoParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehEncomendadoParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehRecebidoParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehSeparadoParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehProntoInstalacaoParameter"));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehEntregueParameter"));*/



             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehRebocadaParameter", Convert.ToString(cEhRebocada.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehObraProntaParameter", Convert.ToString(cEhObraPronta.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehMedidaCombinadaParameter", Convert.ToString(cEhMedida.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehClienteAvisaParameter", Convert.ToString(cEhClienteAvisa.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehConfirmadoParameter", Convert.ToString(cEhConfirmado.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehEncomendadoParameter", Convert.ToString(cEhEncomendado.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehRecebidoParameter", Convert.ToString(cEhRecebido.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehSeparadoParameter", Convert.ToString(cEhSeparado.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehProntoInstalacaoParameter", Convert.ToString(cEhProntoInstalacao.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehEntregueParameter", Convert.ToString(cEhEntregue.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehFundamentoParameter", Convert.ToString(cEhFundamento.Checked)));
             reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ehCobertaParameter", Convert.ToString(cEhCoberta.Checked)));

            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            this.reportViewer1.RefreshReport();
        }
    }
}
