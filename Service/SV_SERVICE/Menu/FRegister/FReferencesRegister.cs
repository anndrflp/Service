using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.zCONTROL.Menu
{
    public partial class Referencia : Form

    {
        Boolean vEhEdicao = false;
        int vHandleReference = 0;

        public Referencia(int prHandleReference)
        {
           
            InitializeComponent();
            vHandleReference = prHandleReference;
            if (prHandleReference != 0)
            {
                vEhEdicao = true;
                vLoadField(prHandleReference);
            }


        }

        private void vLoadField(int prHandleReference)
        {
            DAO.DBConnection conn = new DAO.DBConnection();
            SqlDataReader vReader = conn.DataReader("SELECT * FROM SV_REFERENCIA WHERE HANDLE = " + prHandleReference);


            while (vReader.Read())
            {
                referenciatextBox1.Text = vReader["referencia"].ToString();
                ruatextBox2.Text = vReader["Rua"].ToString();
                bairrotextBox3.Text = vReader["bairro"].ToString();
                cidadetextBox5.Text = vReader["cidade"].ToString();
                numerotextBox4.Text = vReader["numero"].ToString();
            }
            

        }





        private void CadastrarButton_Click(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            DAO.DBConnection conn = new DAO.DBConnection();

            String rua = "";
            String numero = "";
            String bairro = "";
            String cidade = "";
            if (ruatextBox2.Text == "")
            {
                rua = "Sem rua";
            }
            else
            {
                rua = ruatextBox2.Text;
            }

            if (numerotextBox4.Text == "")
            {
                numero = "1";
            }
            else
            {
                numero = numerotextBox4.Text;
            }

            if (bairrotextBox3.Text == "")
            {
                bairro = "Sem Bairro";
            }
            else
            {
                bairro = bairrotextBox3.Text;
            }
            if (cidadetextBox5.Text == "")
            {
                cidade = "Sem Cidade";
            }
            else
            {
                cidade = cidadetextBox5.Text;
            }

            if (vEhEdicao == false)
            {


                String queryReferencia = "INSERT INTO SV_REFERENCIA VALUES ( "
                                                             + "'" + referenciatextBox1.Text + "',"
                                                             + "'" + rua + "',"
                                                             + "'" + bairro + "',"
                                                             + numero + ","
                                                             + "'" + cidade + "');";

                conexao.insert(queryReferencia);

                MessageBox.Show("Cadastro efetuado com sucesso");
                limparCampos();
            }
            else
            {
                String vQueryRefreshData = " UPDATE SV_REFERENCIA SET REFERENCIA = '" + referenciatextBox1.Text + "', RUA = '" + rua + "', BAIRRO = '" + bairro + "',  NUMERO = " + numero + ", CIDADE = '" + cidade + "' WHERE HANDLE = " + vHandleReference;
                conn.ExecuteNonQuery(vQueryRefreshData);
                MessageBox.Show("Cadastro alterado com sucesso");
                this.Close();
            }
            vEhEdicao = false;
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
