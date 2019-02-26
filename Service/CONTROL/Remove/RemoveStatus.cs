using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.zCONTROL
{
    public partial class RemoveStatus : Form
    {
        public RemoveStatus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            conexao.insert("DELETE FROM SV_STATUS WHERE NOME = '" + removetextBox1.Text + "'");
            this.Close();
        }

        private void removetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
