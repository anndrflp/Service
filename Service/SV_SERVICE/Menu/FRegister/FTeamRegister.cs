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
    public partial class FTeamRegister : Form
    {
        public FTeamRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAO.DBConnection conn = new DAO.DBConnection();
            String vTeam = cTeamTextoBox.Text;
            if (vTeam == "")
            {
                MessageBox.Show("Nome da equipe esta em branco");
            }
            else
            {
                String vQuery = "INSERT INTO SV_EQUIPE VALUES ('" + vTeam + "');";
                conn.ExecuteNonQuery(vQuery);
                MessageBox.Show("Cadastro efetuado com sucesso");
                this.Close();

            }
        }
    }
}
