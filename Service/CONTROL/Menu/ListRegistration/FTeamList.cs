
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

namespace Service.zCONTROL
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();

     

            String vQuery = "SELECT * FROM SV_EQUIPE";
            DAO.DBConnection conn = new DAO.DBConnection();
            dataGridView1.DataSource = conn.DataAdapter(vQuery);
            dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CONTROL.Menu.Register.FTeamRegister registerTeam = new CONTROL.Menu.Register.FTeamRegister();
            registerTeam.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Team_Load(object sender, EventArgs e)
        {

        }
    }
}
