
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

            String query = "SELECT * FROM SV_STATUS";


            var connString = "Data Source=localhost;Initial Catalog=Paype;User ID=paype;Password=orkut22";
            SqlDataAdapter data = new SqlDataAdapter(query, connString);
            DataSet tabela = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(data);
            data.Fill(tabela);
            dataGridView1.DataSource = tabela.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            String query = "INSERT INTO SV_STATUS VALUES ('" + nometextBox1.Text + "');";
            conexao.insert(query);
            MessageBox.Show("Cadastro efetuado com sucesso");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Status_Load(object sender, EventArgs e)
        {

        }
    }
}
