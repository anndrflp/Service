using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.zCONTROL.Alter
{
    public partial class AlterDate : Form
    {
        public AlterDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)

        {

            DateTime dataSemConversao = DateTime.Parse(datemaskedTextBox1.Text);
            String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");

            DateTime dataFinalSemConversao = DateTime.Parse(dataFinalmaskedTextBox1.Text);
            String dataFinalConvertida = dataFinalSemConversao.ToString("yyyy/MM/dd HH:mm:ss");

            DAO.conexaoSql conexao = new DAO.conexaoSql();
            String query = "UPDATE SV_SERVICO SET DATAINICIAL = '" + dataConvertida + "', DATAFINAL = '" + dataFinalConvertida + "'  WHERE HANDLE = " + ordemtextBox1.Text + ";";
            conexao.insert(query);
            MessageBox.Show("Data alterada com sucesso");
        }
    }
}
