using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.CONTROL.Menu.Register
{
    public partial class FStatusRegister : Form
    {
        public FStatusRegister()
        {
            InitializeComponent();
        }

        private void cCadastrarButton_Click(object sender, EventArgs e)
        {
            DAO.DBConnection conn = new DAO.DBConnection();

            if (cStatusTextBox.Text == "")
            {
                MessageBox.Show("Mensagem em braco");
            }
            else
            {
            
                String vQuery = "INSERT INTO SV_STATUS VALUES ('" + cStatusTextBox.Text + "');";
                conn.ExecuteNonQuery(vQuery);
                MessageBox.Show("Cadastro efetuado com sucesso");
                this.Close();

            }
        }
    }
}
