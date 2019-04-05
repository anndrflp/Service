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

namespace Service.FN_FISCAL.FFiscal
{
    public partial class FCompanyRegister : Form
    {
        public FCompanyRegister()
        {
            InitializeComponent();
            vPreencheCampos();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cCancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cCadastrarButton_Click(object sender, EventArgs e)
        {
            Boolean  vValidate = vValidateFielNull();
            DAO.DBConnection dBConnection = new DAO.DBConnection();
            if (vValidate == true )
            {
                MessageBox.Show("Campos obrigatórios não preenchido");
            }
            else
            {
                if (cHandleText.Text == "")
                {
                    String vQuery = "INSERT INTO SV_ENDERECO(RUA, BAIRRO, NUM, CIDADE, COMPLEMENTO) VALUES (' " + cRuaText.Text + " ',' " + cBairroText.Text + " ', " + 1 + ", '" + cCidadeText.Text + "',' " + cComplText.Text + " ' );";
                    dBConnection.ExecuteNonQuery(vQuery);
                    String vQuery1 = "INSERT INTO FN_EMPRESA VALUES (' " + cNomeText.Text + " ',' " + cApelidoText.Text + " ',' " + cCnpjText.Text + " ',' " + cContatoText.Text + " ', (SELECT MAX(HANDLE)  FROM SV_ENDERECO) );";
                    dBConnection.ExecuteNonQuery(vQuery1);
                    MessageBox.Show("Cadastro efetuado!");
                    this.Close();
                }
                else
                {
                    String vQuery = "UPDATE FN_EMPRESA SET NOME = '" + cNomeText.Text +  "' , NOMEFANTASIA =  '" + cApelidoText.Text + "', CNPJ = '" + cCnpjText.Text + "', CONTATO = ' " + cContatoText.Text + "' WHERE HANDLE = " + cHandleText.Text ;
                    dBConnection.ExecuteNonQuery(vQuery);
                    String vQuery2 = "UPDATE SV_ENDERECO SET RUA = '" + cRuaText.Text + "', BAIRRO = '" + cBairroText.Text + "', CIDADE = '" + cCidadeText.Text + "', COMPLEMENTO = '" + cComplText.Text + "' WHERE EXISTS (SELECT XX.HANDLE FROM FN_EMPRESA XX WHERE XX.HANDLE = " + cHandleText.Text + " AND XX.ENDERECO = SV_ENDERECO.HANDLE )";
                    dBConnection.ExecuteNonQuery(vQuery2);
                    MessageBox.Show("Registro Alterado");
                    this.Close();
                }

            }

        }

        private Boolean  vValidateFielNull()
        {
            Boolean vValidate = false;

            if (cApelidoText.Text == "")
            {
                vValidate = true;

            }
            if (cNomeText.Text == "")
            {
                vValidate = true;
            }
            if (cCnpjText.Text == "")
            {
                vValidate = true;
            }
            if (cRuaText.Text == "")
            {
                vValidate = true;
            }
            if (cBairroText.Text == "")
            {
                vValidate = true;
            }
            if (cCidadeText.Text == "")
            {
                vValidate = true;
            }
            if (cComplText.Text == "")
            {
                vValidate = true;
            }
            if (cContatoText.Text == "")
            {
                vValidate = true;
            }

            return vValidate;
        }

        private void vBlockFields()
        {
            cNomeText.Enabled = false;
            cApelidoText.Enabled = false;
            cCnpjText.Enabled = false;
            cRuaText.Enabled = false;
            cBairroText.Enabled = false;
            cCidadeText.Enabled = false;
            cComplText.Enabled = false;
            cContatoText.Enabled = false;

        }
        private void vDesblockFields()
        {
            cNomeText.Enabled = true;
            cApelidoText.Enabled = true;
            cCnpjText.Enabled = true;
            cRuaText.Enabled = true;
            cBairroText.Enabled = true;
            cCidadeText.Enabled = true;
            cComplText.Enabled = true;
            cContatoText.Enabled = true;

        }

        private void vPreencheCampos()
        {
            DAO.DBConnection dBConnection = new DAO.DBConnection();
            SqlDataReader vSql = dBConnection.DataReader("SELECT A.HANDLE, A.NOME,  A.NOMEFANTASIA, A.CNPJ, A.CONTATO, B.RUA, B.BAIRRO, B.NUM, B.CIDADE, B.COMPLEMENTO FROM FN_EMPRESA A INNER JOIN SV_ENDERECO B ON A.ENDERECO = B.HANDLE");
            String vName = "";
            String vNameFantasy = "";
            String vCnpj = "";
            String vRua = "";
            String vBairro = "";
            String vCidade = "";
            String vCompl = "";
            String vContato = "";
            String vHandle = "";

            while (vSql.Read())
            {
                vName = vSql["NOME"].ToString();
                 vNameFantasy = vSql["NOMEFANTASIA"].ToString();
                vCnpj = vSql["CNPJ"].ToString();
                vRua = vSql["RUA"].ToString();
                vBairro = vSql["BAIRRO"].ToString();
                vCidade = vSql["CIDADE"].ToString();
                vCompl = vSql["COMPLEMENTO"].ToString();
                vContato = vSql["CONTATO"].ToString();
                vHandle = vSql["HANDLE"].ToString();
            }


               if (vName == "")
                {
                    // Apenas para iniciar o cadastro sem nada
                }
                else
                {
                    cCadastrarButton.Enabled = false;
                    cNomeText.Text = vName;
                    cApelidoText.Text = vNameFantasy;
                    cCnpjText.Text = vCnpj;
                    cRuaText.Text = vRua;
                    cBairroText.Text = vBairro;
                    cCidadeText.Text = vCidade;
                    cComplText.Text = vCompl;
                    cContatoText.Text = vContato;
                    cHandleText.Text = vHandle;
                     vBlockFields();
                }
               

        }

        private void cEditarButton_Click(object sender, EventArgs e)
        {
            vDesblockFields();
            cEditarButton.Enabled = false;
            cCadastrarButton.Enabled = true;
        }
    }
}
