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
    public partial class FUserRegister : Form
    {
        DAO.DBConnection dBConnection = new DAO.DBConnection();
        public FUserRegister()
        {
            InitializeComponent();

            String vQuery = "SELECT LOGIN FROM FN_USUARIO";
            cUserDataGrid.DataSource = dBConnection.DataAdapter(vQuery);

        }

        private void cCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cRegisterButton_Click(object sender, EventArgs e)
        {
            
            
            if (cLoginText.Text == "" || cPasswordText.Text == "" || cEmailText.Text == "")
            {
                MessageBox.Show("Campos obrigatório não preenchido");
            }
            else
            {

                SqlDataReader vSql = dBConnection.DataReader("SELECT HANDLE FROM FN_USUARIO WHERE LOGIN =  ' " + cLoginText.Text + " ';");
                String vHandle = "";
                while (vSql.Read())
                {
                    vHandle = vSql["HANDLE"].ToString();
                }

                if (vHandle != "")
                {
                    MessageBox.Show("Existe outro usuário com o mesmo login");
                }
                else
                {
                    String vQuery = "INSERT INTO FN_USUARIO VALUES (' " + cLoginText.Text + " ',  ' " + cPasswordText.Text + " ', ' " + cEmailText.Text + " ');";
                    dBConnection.ExecuteNonQuery(vQuery);
                    MessageBox.Show("Cadastro efetuado");
                    this.Close();
                }
                


;            }


        }
    }
}
