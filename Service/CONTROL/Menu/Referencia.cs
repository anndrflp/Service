using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.zCONTROL.Menu
{
    public partial class Referencia : Form
    {
        public Referencia()
        {
            InitializeComponent();
        }

        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            String queryReferencia = "INSERT INTO SV_REFERENCIA VALUES ( " 
                                                         + "'" + referenciatextBox1.Text + "',"
                                                         + "'" + ruatextBox2.Text + "',"
                                                         + "'" + bairrotextBox3.Text + "',"
                                                         + numerotextBox4.Text + ","
                                                         + "'" + cidadetextBox5.Text + "');";

            conexao.insert(queryReferencia);

            MessageBox.Show("Cadastro efetuado com sucesso");
            limparCampos();

        }

        public void limparCampos()
        {
            referenciatextBox1.Text = String.Empty;
            ruatextBox2.Text = String.Empty;
            bairrotextBox3.Text = String.Empty;
            numerotextBox4.Text = String.Empty;
            cidadetextBox5.Text = String.Empty;
        }

        private void numerotextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
