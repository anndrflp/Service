using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.SV_SERVICE.Menu.FAll
{
    public partial class FUpdateDate : Form
    {
        public FUpdateDate()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))

            {

                e.Handled = true;

            }
        }

        private void cCancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cAtualizar_Click(object sender, EventArgs e)
        {
            if (cDiasBox.Text == "")
            {
                MessageBox.Show("Por favor, preencha um valor válido nos dias");
            }
            else
            {
                String vOperacao = cOperacaoBox.Text;
                String vOp = "";

                if (vOperacao == "Mais")
                {
                    vOp = "+";
                }
                else
                {
                    vOp = "-";
                }

                String vQuery = "UPDATE SV_SERVICO SET DATAINICIAL = DATAINICIAL " + vOp + cDiasBox.Text + " ,  DATAFINAL = DATAFINAL" + vOp + cDiasBox.Text +
                                            " WHERE STATUS NOT IN (SELECT XX.HANDLE FROM SV_STATUS XX WHERE XX.NOME LIKE '%FINALIZADO%' AND SV_SERVICO.STATUS = XX.HANDLE )";

                DAO.DBConnection dBConnection = new DAO.DBConnection();
                dBConnection.ExecuteNonQuery(vQuery);
                MessageBox.Show("Datas atualizadas");

                this.Close();
            }
        }
    }
}
