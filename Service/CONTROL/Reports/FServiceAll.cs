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

namespace Service.CONTROL.Relatorio
{
    public partial class FServiceAll : Form
    {
        public FServiceAll()
        {

            //diaTimePicker.Text

            DateTime dataSemConversao = DateTime.Parse("2019-01-01");
            String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");
            InitializeComponent();
            atualizaDataGridTotal(dataConvertida);
            


        }

        public void carregaComboBoxEquipe()
        {

            DAO.conexaoSql conexao = new DAO.conexaoSql();
            DataTable dt = new DataTable();
            String query = "SELECT NOME FROM SV_EQUIPE";

            // Executando a consulta Sql e colocando no combobox1
            dt = conexao.consultCombobox(query);
            equipecomboBox.DataSource = dt;
            equipecomboBox.ValueMember = "nome";

           
        }

        public void carregaComboBoxStatus()
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            DataTable dt2 = new DataTable();
            String query2 = "SELECT NOME FROM SV_STATUS";
            dt2 = conexao.consultCombobox(query2);

            statuscomboBox.DataSource = dt2;
            statuscomboBox.ValueMember = "nome";
        }
        public void carregaComboBoxReferencia()
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            DataTable dt3 = new DataTable();
            String query3 = "SELECT REFERENCIA FROM SV_REFERENCIA";
            dt3 = conexao.consultCombobox(query3);

            referenciacomboBox.DataSource = dt3;
            referenciacomboBox.ValueMember = "REFERENCIA";
        }

        public void atualizaDataGrid(String datainicial)
        {
            DAO.DBConnection conn = new DAO.DBConnection();

            String vQuery2 =
                " SELECT                                                                    " +
                "   CAST(A.HANDLE AS VARCHAR(4)) ORDEM ," +
                "   B.NOME CLIENTE ,                                                " +
                "   D.NOME    SITUACAO ,                                                        " +
                "   A.DATAINICIAL DATA,                                               " +
                "   C.NOME EQUIPE     ,                                             " +
                "   A.SERVICO,                                                           " +

                "   F.REFERENCIA                         " +
                "  FROM SV_SERVICO A                                           " +
                "  INNER JOIN SV_EQUIPE  C ON A.EQUIPE   = C.HANDLE " +
                "  INNER JOIN SV_CLIENTE B ON A.CLIENTE  = B.HANDLE " +
                "  INNER JOIN SV_STATUS  D ON A.STATUS   = D.HANDLE " +
                "  INNER JOIN SV_ENDERECO E ON B.ENDERECO = E.HANDLE" +
                "  INNER JOIN SV_REFERENCIA F ON E.REFERENCIA= F.HANDLE" +
                "  WHERE DAY(A.DATAINICIAL) = DAY('" + datainicial + "')" +
                "  AND MONTH(A.DATAINICIAL) = MONTH('" + datainicial + "')" +
                "  AND  YEAR(A.DATAINICIAL) = YEAR('" + datainicial + "')" +
                "  ORDER BY A.DATAINICIAL  ;";


            serviceGridView.DataSource = conn.DataAdapter(vQuery2);




        }

        public void limpaDataGrid()
        {

            DAO.DBConnection conn = new DAO.DBConnection();
            String vQuery =

                " SELECT                                                                    " +
                "   CAST(A.HANDLE AS VARCHAR(4)) ORDEM ," +
                "   D.NOME    SITUACAO ,                                                        " +
                "   A.DATAINICIAL DATA,                                               " +
                "   C.NOME EQUIPE     ,                                             " +
                "   A.SERVICO,                                                           " +
                "   B.NOME CLIENTE                                                 " +
                "  FROM SV_SERVICO A                                           " +
                "  INNER JOIN SV_EQUIPE  C ON A.EQUIPE   = C.HANDLE " +
                "  INNER JOIN SV_CLIENTE B ON A.CLIENTE  = B.HANDLE " +
                "  INNER JOIN SV_STATUS  D ON A.STATUS   = D.HANDLE " +
                "  WHERE 1 = 2 ";

            serviceGridView.DataSource = conn.DataAdapter(vQuery);

        }

        public void atualizaDataGridTotal(String datainicial)
        {

            DAO.DBConnection conn = new DAO.DBConnection();
            String vQuery =
                " SELECT                                                                    " +
                "   A.HANDLE ORDEM ," +
                 "   B.NOME CLIENTE,                                                " +
                "   D.NOME    SITUACAO ,                                                        " +
                "   A.DATAINICIAL DATA,                                               " +
                "   C.NOME EQUIPE     ,                                             " +
                "   A.SERVICO,                                                           " +

                "   F.REFERENCIA                         " +
                "  FROM SV_SERVICO A                                           " +
                "  INNER JOIN SV_EQUIPE  C ON A.EQUIPE   = C.HANDLE " +
                "  INNER JOIN SV_CLIENTE B ON A.CLIENTE  = B.HANDLE " +
                "  INNER JOIN SV_STATUS  D ON A.STATUS   = D.HANDLE " +
               "  INNER JOIN SV_ENDERECO E ON B.ENDERECO = E.HANDLE" +
                "  INNER JOIN SV_REFERENCIA F ON E.REFERENCIA= F.HANDLE" +
                "  WHERE 1 = 1" + 
                "  ORDER BY A.DATAINICIAL  ;";

            serviceGridView.DataSource = conn.DataAdapter(vQuery);
        }

        private void ateData_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime dataSemConversao = DateTime.Parse(diaTimePicker.Text);
            String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");
            atualizaDataGrid(dataConvertida);

        }

        private void serviceDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = serviceGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (convertLine == "")
            {
                MessageBox.Show("Registro em branco");
            }
            else
            {

                int line = Convert.ToInt32(convertLine);
                zCONTROL.RegisterService service = new zCONTROL.RegisterService(line, "", "");
                service.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void deData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void diaTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime dataSemConversao = DateTime.Parse(diaTimePicker.Text);
            String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");
            limpaDataGrid();
            atualizaDataGrid(dataConvertida);
        }

        private void serviceGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = serviceGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (convertLine == "")
            {
                MessageBox.Show("Registro em branco");
            }
            else
            {

                int line = Convert.ToInt32(convertLine);
                zCONTROL.RegisterService service = new zCONTROL.RegisterService(line, "", "");
                service.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();

            if (referenciacomboBox.Text == "" || statuscomboBox.Text == "" || equipecomboBox.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os filtros disponíveis");
            }
            else
            {
                String equipe = equipecomboBox.Text;
                String status = statuscomboBox.Text;
                String referencia = referenciacomboBox.Text;
                DateTime dataSemConversao = DateTime.Parse(diaTimePicker.Text);

                String query = comandos.queryConsultaTodosServico(equipe, status, referencia);
                var connString = "Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655";
                SqlDataAdapter date2 = new SqlDataAdapter(query, connString);
                DataSet tabela2 = new DataSet();
                SqlCommandBuilder cmd2 = new SqlCommandBuilder(date2);
                date2.Fill(tabela2);
                serviceGridView.DataSource = tabela2.Tables[0];
            }
        }

        private void equipecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void equipecomboBox_Click(object sender, EventArgs e)
        {
            carregaComboBoxEquipe();
        }

        private void statuscomboBox_Click(object sender, EventArgs e)
        {
            carregaComboBoxStatus();
        }

        private void referenciacomboBox_Click(object sender, EventArgs e)
        {
            carregaComboBoxReferencia();
        }
    }
}