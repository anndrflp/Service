
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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
            DAO.DBConnection conn = new DAO.DBConnection();
            String vQuery = "SELECT * FROM SV_STATUS";

            cStatusDataGridView.DataSource = conn.DataAdapter(vQuery);
            cStatusDataGridView.Columns[0].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CONTROL.Menu.Register.FStatusRegister statusRegister = new CONTROL.Menu.Register.FStatusRegister();
            statusRegister.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Status_Load(object sender, EventArgs e)
        {

        }
    }
}
