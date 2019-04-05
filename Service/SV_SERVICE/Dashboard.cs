
using Service.DAO;
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

namespace Service
{
    // Visualização dos registros
    public partial class Service : Form
    {
       
        DBConnection DBConnection = new DBConnection();
        String lineTransferencia = "";

        public Service()
        {
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();
            
            InitializeComponent();
            atualizaDataGridView();

            /* Redundante pois era para antiga área de transferência
            atualizarGrid();
            setarHoraCalhasDataGridView("2018-01-01", "2058-01-01", 1);
            setarHoraVidrosDataGridView("2018-01-01", "2058-01-01", 1);
            setarHoraMedidaDataGridView("2018-01-01", "2058-01-01", 1); */


        }
        public void setarHoraCalhasDataGridView(String datainical, String datafinal, int ehiniciar)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            String horaOito = conexao.consultHandleService("Calhas", 8, datainical, datafinal, ehiniciar);
            String horanove = conexao.consultHandleService("Calhas", 9, datainical, datafinal, ehiniciar);
            String horadez = conexao.consultHandleService("Calhas", 10, datainical, datafinal, ehiniciar);
            String horaOnze = conexao.consultHandleService("Calhas", 11, datainical, datafinal, ehiniciar);
            String horaDoze = conexao.consultHandleService("Calhas", 12, datainical, datafinal, ehiniciar);
            String horaTreze = conexao.consultHandleService("Calhas", 13, datainical, datafinal, ehiniciar);
            String horaQuatorze = conexao.consultHandleService("Calhas", 14, datainical, datafinal, ehiniciar);
            String horaQuinze = conexao.consultHandleService("Calhas", 15, datainical, datafinal, ehiniciar);
            String horaDezesseis = conexao.consultHandleService("Calhas", 16, datainical, datafinal, ehiniciar);
            String horaDezessete = conexao.consultHandleService("Calhas", 17, datainical, datafinal, ehiniciar);
            String horaDezoito = conexao.consultHandleService("Calhas", 18, datainical, datafinal, ehiniciar);


            String nomeOito = conexao.consultNomeService("Calhas", 8, datainical, datafinal, ehiniciar);
            String nomenove = conexao.consultNomeService("Calhas", 9, datainical, datafinal, ehiniciar);
            String nomedez = conexao.consultNomeService("Calhas", 10, datainical, datafinal, ehiniciar);
            String nomeOnze = conexao.consultNomeService("Calhas", 11, datainical, datafinal, ehiniciar);
            String nomeDoze = conexao.consultNomeService("Calhas", 12, datainical, datafinal, ehiniciar);
            String nomeTreze = conexao.consultNomeService("Calhas", 13, datainical, datafinal, ehiniciar);
            String nomeQuatorze = conexao.consultNomeService("Calhas", 14, datainical, datafinal, ehiniciar);
            String nomeQuinze = conexao.consultNomeService("Calhas", 15, datainical, datafinal, ehiniciar);
            String nomeDezesseis = conexao.consultNomeService("Calhas", 16, datainical, datafinal, ehiniciar);
            String nomeDezessete = conexao.consultNomeService("Calhas", 17, datainical, datafinal, ehiniciar);
            String nomeDezoito = conexao.consultNomeService("Calhas", 18, datainical, datafinal, ehiniciar);


            calhasDataGridView.Rows.Add("08:00", horaOito, nomeOito);
            calhasDataGridView.Rows.Add("09:00", horanove, nomenove);
            calhasDataGridView.Rows.Add("10:00", horadez, nomedez);
            calhasDataGridView.Rows.Add("11:00", horaOnze, nomeOnze);
            calhasDataGridView.Rows.Add("12:00", horaDoze, nomeDoze);
            calhasDataGridView.Rows.Add("13:00", horaTreze, nomeTreze);
            calhasDataGridView.Rows.Add("14:00", horaQuatorze, nomeQuatorze);
            calhasDataGridView.Rows.Add("15:00", horaQuinze, nomeQuinze);
            calhasDataGridView.Rows.Add("16:00", horaDezesseis, nomeDezesseis);
            calhasDataGridView.Rows.Add("17:00", horaDezessete, nomeDezessete);
            calhasDataGridView.Rows.Add("18:00", horaDezoito, nomeDezoito);



        }
        public void setarHoraVidrosDataGridView(String datainical, String datafinal, int ehiniciar)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            String horaOito = conexao.consultHandleService("Vidros", 8, datainical, datafinal, ehiniciar);
            String horanove = conexao.consultHandleService("Vidros", 9, datainical, datafinal, ehiniciar);
            String horadez = conexao.consultHandleService("Vidros", 10, datainical, datafinal, ehiniciar);
            String horaOnze = conexao.consultHandleService("Vidros", 11, datainical, datafinal, ehiniciar);
            String horaDoze = conexao.consultHandleService("Vidros", 12, datainical, datafinal, ehiniciar);
            String horaTreze = conexao.consultHandleService("Vidros", 13, datainical, datafinal, ehiniciar);
            String horaQuatorze = conexao.consultHandleService("Vidros", 14, datainical, datafinal, ehiniciar);
            String horaQuinze = conexao.consultHandleService("Vidros", 15, datainical, datafinal, ehiniciar);
            String horaDezesseis = conexao.consultHandleService("Vidros", 16, datainical, datafinal, ehiniciar);
            String horaDezessete = conexao.consultHandleService("Vidros", 17, datainical, datafinal, ehiniciar);
            String horaDezoito = conexao.consultHandleService("Vidros", 18, datainical, datafinal, ehiniciar);


            String nomeOito = conexao.consultNomeService("Vidros", 8, datainical, datafinal, ehiniciar);
            String nomenove = conexao.consultNomeService("Vidros", 9, datainical, datafinal, ehiniciar);
            String nomedez = conexao.consultNomeService("Vidros", 10, datainical, datafinal, ehiniciar);
            String nomeOnze = conexao.consultNomeService("Vidros", 11, datainical, datafinal, ehiniciar);
            String nomeDoze = conexao.consultNomeService("Vidros", 12, datainical, datafinal, ehiniciar);
            String nomeTreze = conexao.consultNomeService("Vidros", 13, datainical, datafinal, ehiniciar);
            String nomeQuatorze = conexao.consultNomeService("Vidros", 14, datainical, datafinal, ehiniciar);
            String nomeQuinze = conexao.consultNomeService("Vidros", 15, datainical, datafinal, ehiniciar);
            String nomeDezesseis = conexao.consultNomeService("Vidros", 16, datainical, datafinal, ehiniciar);
            String nomeDezessete = conexao.consultNomeService("Vidros", 17, datainical, datafinal, ehiniciar);
            String nomeDezoito = conexao.consultNomeService("Vidros", 18, datainical, datafinal, ehiniciar);

            vidrosdataGridView.Rows.Add("08:00", horaOito, nomeOito);
            vidrosdataGridView.Rows.Add("09:00", horanove, nomenove);
            vidrosdataGridView.Rows.Add("10:00", horadez, nomedez);
            vidrosdataGridView.Rows.Add("11:00", horaOnze, nomeOnze);
            vidrosdataGridView.Rows.Add("12:00", horaDoze, nomeDoze);
            vidrosdataGridView.Rows.Add("13:00", horaTreze, nomeTreze);
            vidrosdataGridView.Rows.Add("14:00", horaQuatorze, nomeQuatorze);
            vidrosdataGridView.Rows.Add("15:00", horaQuinze, nomeQuinze);
            vidrosdataGridView.Rows.Add("16:00", horaDezesseis, nomeDezesseis);
            vidrosdataGridView.Rows.Add("17:00", horaDezessete, nomeDezessete);
            vidrosdataGridView.Rows.Add("18:00", horaDezoito, nomeDezoito);



        }
        public void setarHoraMedidaDataGridView(String datainical, String datafinal, int ehiniciar)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            String horaOito = conexao.consultHandleService("Medidas", 8, datainical, datafinal, ehiniciar);
            String horanove = conexao.consultHandleService("Medidas", 9, datainical, datafinal, ehiniciar);
            String horadez = conexao.consultHandleService("Medidas", 10, datainical, datafinal, ehiniciar);
            String horaOnze = conexao.consultHandleService("Medidas", 11, datainical, datafinal, ehiniciar);
            String horaDoze = conexao.consultHandleService("Medidas", 12, datainical, datafinal, ehiniciar);
            String horaTreze = conexao.consultHandleService("Medidas", 13, datainical, datafinal, ehiniciar);
            String horaQuatorze = conexao.consultHandleService("Medidas", 14, datainical, datafinal, ehiniciar);
            String horaQuinze = conexao.consultHandleService("Medidas", 15, datainical, datafinal, ehiniciar);
            String horaDezesseis = conexao.consultHandleService("Medidas", 16, datainical, datafinal, ehiniciar);
            String horaDezessete = conexao.consultHandleService("Medidas", 17, datainical, datafinal, ehiniciar);
            String horaDezoito = conexao.consultHandleService("Medidas", 18, datainical, datafinal, ehiniciar);


            String nomeOito = conexao.consultNomeService("Medidas", 8, datainical, datafinal, ehiniciar);
            String nomenove = conexao.consultNomeService("Medidas", 9, datainical, datafinal, ehiniciar);
            String nomedez = conexao.consultNomeService("Medidas", 10, datainical, datafinal, ehiniciar);
            String nomeOnze = conexao.consultNomeService("Medidas", 11, datainical, datafinal, ehiniciar);
            String nomeDoze = conexao.consultNomeService("Medidas", 12, datainical, datafinal, ehiniciar);
            String nomeTreze = conexao.consultNomeService("Medidas", 13, datainical, datafinal, ehiniciar);
            String nomeQuatorze = conexao.consultNomeService("Medidas", 14, datainical, datafinal, ehiniciar);
            String nomeQuinze = conexao.consultNomeService("Medidas", 15, datainical, datafinal, ehiniciar);
            String nomeDezesseis = conexao.consultNomeService("Medidas", 16, datainical, datafinal, ehiniciar);
            String nomeDezessete = conexao.consultNomeService("Medidas", 17, datainical, datafinal, ehiniciar);
            String nomeDezoito = conexao.consultNomeService("Medidas", 18, datainical, datafinal, ehiniciar);

            medidasdataGridView.Rows.Add("08:00", horaOito, nomeOito);
            medidasdataGridView.Rows.Add("09:00", horanove, nomenove);
            medidasdataGridView.Rows.Add("10:00", horadez, nomedez);
            medidasdataGridView.Rows.Add("11:00", horaOnze, nomeOnze);
            medidasdataGridView.Rows.Add("12:00", horaDoze, nomeDoze);
            medidasdataGridView.Rows.Add("13:00", horaTreze, nomeTreze);
            medidasdataGridView.Rows.Add("14:00", horaQuatorze, nomeQuatorze);
            medidasdataGridView.Rows.Add("15:00", horaQuinze, nomeQuinze);
            medidasdataGridView.Rows.Add("16:00", horaDezesseis, nomeDezesseis);
            medidasdataGridView.Rows.Add("17:00", horaDezessete, nomeDezessete);
            medidasdataGridView.Rows.Add("18:00", horaDezoito, nomeDezoito);

        }



        public void atualizaDataGridView()
        {

            String vQuery = "SELECT A.SERVICO FROM SV_SERVICO A";


            cEquipesQntDataGridView.DataSource = DBConnection.DataAdapter(vQuery);

            String query =

           " SELECT" +
             "   A.HANDLE ORDEM, " +
             "   D.NOME SITUACAO," +
             "   A.DATAINICIAL DATA,            " +
             "   A.SERVICO,                           " +
             "   C.NOME EQUIPE,                  " +
             "   B.NOME CLIENTE                 " +
             "  FROM SV_SERVICO A          " +
             "  INNER JOIN SV_CLIENTE B ON A.CLIENTE = B.HANDLE " +
             "  INNER JOIN SV_EQUIPE  C ON A.EQUIPE = C.HANDLE " +
             "  INNER JOIN SV_STATUS  D ON A.STATUS = D.HANDLE" +

             "   WHERE DAY(A.DATAINICIAL) = DAY(GETDATE())              " +
             "  AND 1 = 1"  +
              "  AND MONTH(A.DATAINICIAL) = MONTH(GETDATE())  AND YEAR(A.DATAINICIAL) = YEAR(GETDATE());";

            
            var connString = "Server=localhost;database=paype;Uid=sa;Pwd=orkut22";
            SqlDataAdapter data = new SqlDataAdapter(query, connString);
            DataSet tabela = new DataSet();
            SqlCommandBuilder cmd = new SqlCommandBuilder(data);
            data.Fill(tabela);
            servicoHojesDataGrid.DataSource = tabela.Tables[0];


            String queryAtrasados =

                    " SELECT" +
                     "   A.HANDLE ORDEM, " +
                     "   D.NOME SITUACAO," +
                     "   A.DATAINICIAL DATA,            " +
                     "   A.SERVICO,                           " +
                     "   C.NOME EQUIPE,                  " +
                     "   B.NOME CLIENTE                 " +
                     "  FROM SV_SERVICO A          " +
                     "  INNER JOIN SV_CLIENTE B ON A.CLIENTE = B.HANDLE " +
                     "  INNER JOIN SV_EQUIPE  C ON A.EQUIPE = C.HANDLE " +
                     "  INNER JOIN SV_STATUS  D ON A.STATUS = D.HANDLE" +

                     "   WHERE A.DATAINICIAL < GETDATE() " +
                     "  AND 1 = 1" +
                     "  AND D.NOME NOT LIKE '%FINALIZADO%'            ";




            SqlDataAdapter data1 = new SqlDataAdapter(queryAtrasados, connString);
            DataSet tabela1 = new DataSet();
            SqlCommandBuilder cmd1 = new SqlCommandBuilder(data1);
            data1.Fill(tabela1);
            atrasadosDataGridView.DataSource = tabela1.Tables[0];


        }
        private void button1_Click(object sender, EventArgs e)
        {

            zCONTROL.RegisterService ser = new zCONTROL.RegisterService(1, "", "");
            ser.ShowDialog();


        }
        private void lineServiceDataGridView(object sender, DataGridViewCellEventArgs e)
        {


            String convertLine = servicoHojesDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();


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
        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void equipesToolStripMenuItem_Click(object sender, EventArgs e) // Cadastro de serviço
        {
            
            zCONTROL.Team team = new zCONTROL.Team();
            team.ShowDialog();
        }
        private void situacõesToolStripMenuItem_Click(object sender, EventArgs e) // Cadastro de situações
        {
            zCONTROL.Status status = new zCONTROL.Status();
            status.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            zCONTROL.RegisterService ser = new zCONTROL.RegisterService(0, "", "");
            ser.ShowDialog();
        }
        public void serviceDataGridViewDoubleClick(object sender, DataGridViewCellEventArgs e) // Dois cliques no datagrid view - pegando o handle e repassando no método da chamada
        {

            String convertLine = servicoHojesDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();


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


        private void Service_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            atualizaDataGridView();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            atualizaDataGridView();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void referenciaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            CONTROL.Menu.ListRegistration.FReferencesList listReferences= new CONTROL.Menu.ListRegistration.FReferencesList();
            listReferences.ShowDialog();

        }
        public void BotaoAtualizar(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();
            conexao.insert(comandos.queryDesatualizaAreaDeTransferencia());
            atualizaDataGridView();

        }

        public void atualizarGrid()
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();
            conexao.insert(comandos.queryDesatualizaAreaDeTransferencia());
            atualizaDataGridView();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }





        internal class serviceDataSet2TableAdapters
        {
            internal class sv_enderecoTableAdapter
            {
                public sv_enderecoTableAdapter()
                {
                }

                public bool ClearBeforeFill { get; internal set; }
            }
        }

        private void todosOsServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zCONTROL.RegisterService ser = new zCONTROL.RegisterService(0, "", "");
            ser.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {




        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void todosOsServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //CONTROL.Relatorio.Agendamento relatorio = new CONTROL.Relatorio.Agendamento();
            //relatorio.ShowDialog();
        }

        private void serviçosDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROL.Relatorio.FServiceAll service = new CONTROL.Relatorio.FServiceAll();
            service.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hourDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }


        // Clicando no dataGridView do calhas;
        private void hourDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = calhasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void vidrosdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = vidrosdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void medidasdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = medidasdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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
        public void limpaDataGridView(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            dataGrid.Refresh();
        }



        private void atrasadosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = atrasadosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
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

        private void deDatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            String dedate = deDatePicker.Text;
            String atedate = deDatePicker.Text;  // Redundante apagar

            DateTime dataSemConversao = DateTime.Parse(deDatePicker.Text);
            String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");

            DateTime dataFinalSemConversao = DateTime.Parse(deDatePicker.Text);
            String dataFinalConvertida = dataFinalSemConversao.ToString("yyyy/MM/dd HH:mm:ss");


            limpaDataGridView(calhasDataGridView);
            limpaDataGridView(vidrosdataGridView);
            limpaDataGridView(medidasdataGridView);
            setarHoraCalhasDataGridView(dataConvertida, dataConvertida, 0);
            setarHoraVidrosDataGridView(dataConvertida, dataConvertida, 0);
            setarHoraMedidaDataGridView(dataConvertida, dataConvertida, 0);
        }

        private void calhasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = calhasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void vidrosdataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = vidrosdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void medidasdataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = medidasdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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

        private void atrasadosDataGridView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String convertLine = atrasadosDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
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
        private void calhasDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();
            CONTROL.Banco.controles controles = new CONTROL.Banco.controles();
            String convertLine = calhasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (convertLine == "" && transferenciaCheckBox.Checked == false)
            {
                MessageBox.Show("Registro em branco");
            }
            else
            {


                if (transferenciaCheckBox.Checked == false)
                {
                    try
                    {

                        int line = Convert.ToInt32(convertLine);
                        String nomeCliente = conexao.consultCliente(line);
                        transferenciaDataGridView.Rows.Add(convertLine, nomeCliente);
                        conexao.insert(comandos.queryAtualizaTranferenciaServico(convertLine));


                        DateTime dataSemConversao = DateTime.Parse(deDatePicker.Text);
                        String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");
                       
                        // Atualiza datagridview
                        String dedate = deDatePicker.Text;
                        String atedate = deDatePicker.Text;  // Redundante apagar
                        limpaDataGridView(calhasDataGridView);
                        setarHoraCalhasDataGridView(dataConvertida, dataConvertida, 0);

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    String vTeam = conexao.consultEquipeService("Calhas", lineTransferencia);
                    if (vTeam == "1")
                    {


                        String duracao = conexao.consultDuracao(Convert.ToInt32(lineTransferencia));
                        String vClient = conexao.consultCliente(Convert.ToInt32(lineTransferencia));
                        int validador = Convert.ToInt32(duracao);
                        int linhaData = e.RowIndex;

                        while (validador > 0)
                        {
                            calhasDataGridView.Rows[linhaData].Cells[1].Value = lineTransferencia;
                            calhasDataGridView.Rows[linhaData].Cells[2].Value = vClient;
                            validador = validador - 1;
                            linhaData = linhaData + 1;
                        }

                        // Pega a nova data inicial com horas
                        DateTime convertData = DateTime.Parse(deDatePicker.Text);
                        String dataConvertida = convertData.ToString("yyyy/MM/dd");
                        dataConvertida = dataConvertida + " " + calhasDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                        conexao.insert(comandos.queryAtualizaDataInicial(lineTransferencia, dataConvertida));

                        // Pega a nova data final com horas      
                        String horaInicial = calhasDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        String horaInicialCerta = horaInicial.Substring(0, 2); // Pega os dois primeiros valores
                        int totalGeral = Convert.ToInt32(horaInicialCerta) + Convert.ToInt32(duracao);
                        String dataFinalConvertida = convertData.ToString("yyyy/MM/dd");
                        dataFinalConvertida = dataFinalConvertida + " " + Convert.ToString(totalGeral) + ":00:00";
                        conexao.insert(comandos.queryAtualizaDataFinal(lineTransferencia, dataFinalConvertida));
                        controles.alteratabelaDataAgendamento(lineTransferencia, dataConvertida, dataFinalConvertida);
                    }
                    else
                    {
                        MessageBox.Show("Equipe inválida, favor direcionar a equipe válida");
                    }

                }
            }
        }

        private void vidrosdataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();
            CONTROL.Banco.controles controles = new CONTROL.Banco.controles();
            String convertLine = vidrosdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (convertLine == "" && transferenciaCheckBox.Checked == false)
            {
                MessageBox.Show("Registro em branco");
            }
            else
            {


                if (transferenciaCheckBox.Checked == false)
                {
                    try
                    {

                        int line = Convert.ToInt32(convertLine);
                        String nomeCliente = conexao.consultCliente(line);
                        transferenciaDataGridView.Rows.Add(convertLine, nomeCliente);
                        conexao.insert(comandos.queryAtualizaTranferenciaServico(convertLine));


                        DateTime dataSemConversao = DateTime.Parse(deDatePicker.Text);
                        String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");


                        // Atualiza datagridview
                        String dedate = deDatePicker.Text;
                        String atedate = deDatePicker.Text;  // Redundante apagar
                        limpaDataGridView(vidrosdataGridView);
                        setarHoraVidrosDataGridView(dataConvertida, dataConvertida, 0);

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    String vTeam = conexao.consultEquipeService("Vidros", lineTransferencia);

                    if (vTeam == "2")
                    {
                        String duracao = conexao.consultDuracao(Convert.ToInt32(lineTransferencia));
                        String vClient = conexao.consultCliente(Convert.ToInt32(lineTransferencia));
                        int validador = Convert.ToInt32(duracao);
                        int linhaData = e.RowIndex;

                        while (validador > 0)
                        {
                            vidrosdataGridView.Rows[linhaData].Cells[1].Value = lineTransferencia;
                            vidrosdataGridView.Rows[linhaData].Cells[2].Value = vClient;
                            validador = validador - 1;
                            linhaData = linhaData + 1;
                        }

                        // Pega a nova data inicial com horas
                        DateTime convertData = DateTime.Parse(deDatePicker.Text);
                        String dataConvertida = convertData.ToString("yyyy/MM/dd");
                        dataConvertida = dataConvertida + " " + vidrosdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                        conexao.insert(comandos.queryAtualizaDataInicial(lineTransferencia, dataConvertida));

                        // Pega a nova data final com horas      
                        String horaInicial = vidrosdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        String horaInicialCerta = horaInicial.Substring(0, 2); // Pega os dois primeiros valores
                        int totalGeral = Convert.ToInt32(horaInicialCerta) + Convert.ToInt32(duracao);
                        String dataFinalConvertida = convertData.ToString("yyyy/MM/dd");
                        dataFinalConvertida = dataFinalConvertida + " " + Convert.ToString(totalGeral) + ":00:00";
                        conexao.insert(comandos.queryAtualizaDataFinal(lineTransferencia, dataFinalConvertida));
                        controles.alteratabelaDataAgendamento(lineTransferencia, dataConvertida, dataFinalConvertida);
                    }
                    else
                    {
                        MessageBox.Show("Equipe inválida, favor direcionar a equipe válida");
                    }

                }
            }
        }


        private void medidasdataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandos = new CONTROL.Banco.comandosSql();
            CONTROL.Banco.controles controles = new CONTROL.Banco.controles();
            String convertLine = medidasdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (convertLine == "" && transferenciaCheckBox.Checked == false)
            {
                MessageBox.Show("Registro em branco");
            }
            else
            {

                if (transferenciaCheckBox.Checked == false)
                {
                    try
                    {

                        int line = Convert.ToInt32(convertLine);
                        String nomeCliente = conexao.consultCliente(line);
                        transferenciaDataGridView.Rows.Add(convertLine, nomeCliente);
                        conexao.insert(comandos.queryAtualizaTranferenciaServico(convertLine));

                        // Atualiza datagridview
                        String dedate = deDatePicker.Text;
                        String atedate = deDatePicker.Text;  // Redundante apagar

                        DateTime dataSemConversao = DateTime.Parse(deDatePicker.Text);
                        String dataConvertida = dataSemConversao.ToString("yyyy/MM/dd HH:mm:ss");

                        limpaDataGridView(medidasdataGridView);
                        setarHoraMedidaDataGridView(dataConvertida, dataConvertida, 0);
                        

                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    String vTeam = conexao.consultEquipeService("Medidas", lineTransferencia);
                    

                    if (vTeam == "3")
                    {
                        String duracao = conexao.consultDuracao(Convert.ToInt32(lineTransferencia));
                        String vClient = conexao.consultCliente(Convert.ToInt32(lineTransferencia));
                        int validador = Convert.ToInt32(duracao);
                        int linhaData = e.RowIndex;

                        while (validador > 0)
                        {
                            medidasdataGridView.Rows[linhaData].Cells[1].Value = lineTransferencia;
                            medidasdataGridView.Rows[linhaData].Cells[2].Value = vClient;
                            validador = validador - 1;
                            linhaData = linhaData + 1;
                        }

                        // Pega a nova data inicial com horas
                        DateTime convertData = DateTime.Parse(deDatePicker.Text);
                        String dataConvertida = convertData.ToString("yyyy/MM/dd");
                        dataConvertida = dataConvertida + " " + medidasdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                        conexao.insert(comandos.queryAtualizaDataInicial(lineTransferencia, dataConvertida));

                        // Pega a nova data final com horas      
                        String horaInicial = medidasdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        String horaInicialCerta = horaInicial.Substring(0, 2); // Pega os dois primeiros valores
                        int totalGeral = Convert.ToInt32(horaInicialCerta) + Convert.ToInt32(duracao);
                        String dataFinalConvertida = convertData.ToString("yyyy/MM/dd");
                        dataFinalConvertida = dataFinalConvertida + " " + Convert.ToString(totalGeral) + ":00:00";
                        conexao.insert(comandos.queryAtualizaDataFinal(lineTransferencia, dataFinalConvertida));
                        controles.alteratabelaDataAgendamento(lineTransferencia, dataConvertida, dataFinalConvertida);

                    }
                    else
                    {
                        MessageBox.Show("Equipe inválida, favor direcionar a equipe válida");
                    }
                    
                }
            }
        }

        private void transferenciaDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String validaLinhaVazia = transferenciaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql command = new CONTROL.Banco.comandosSql();

            if (validaLinhaVazia == "")
            {
                MessageBox.Show("Linha vazia, altere-a");
            }
            else
            {
                if (transferenciaCheckBox.Checked == true)
                {
                    lineTransferencia = transferenciaDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    SqlDataReader reader = DBConnection.DataReader(command.vQueryConsultServices(lineTransferencia));


                    while (reader.Read())
                    {
                        duracaotextBox.Text = reader["duracao"].ToString();
                        serviceTextBox.Text = reader["Numero"].ToString();
                        clientetextBox.Text = reader["cliente"].ToString();
                        equipeTextBox.Text  = reader["equipe"].ToString();
                    }

                    transferenciaDataGridView.Rows[e.RowIndex].Cells[0].Value = "";
                    transferenciaDataGridView.Rows[e.RowIndex].Cells[1].Value = "";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void serviçosSemanaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* SV_SERVICE.Relatorio.FServiceWeek servicosSemanais = new CONTROL.Relatorio.FServiceWeek("1");
            servicosSemanais.ShowDialog();*/
        }

        private void imprimirOsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONTROL.Reports.Prints.FPrintAllServices fPrintAllServices = new CONTROL.Reports.Prints.FPrintAllServices();
            fPrintAllServices.ShowDialog();

        }

        private void calendárioAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

           /* DateTime prStartTime = DateTime.Now; 
            DateTime prEndTime = DateTime.Now;

            CalendarDemo.DemoForm demoForm = new CalendarDemo.DemoForm("Não cadastrar", prStartTime, prEndTime, 50, "White");
            demoForm.ShowDialog();*/
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime prStartTime = DateTime.Now;
            DateTime prEndTime = DateTime.Now;

            CalendarDemo.DemoForm demoForm = new CalendarDemo.DemoForm("Não cadastrar", prStartTime, prEndTime, 50, "White");
            demoForm.ShowDialog();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime prStartTime = DateTime.Now;
            DateTime prEndTime = DateTime.Now;

            CalendarDemo.DemoForm demoForm = new CalendarDemo.DemoForm("Não cadastrar", prStartTime, prEndTime, 50, "White");
            demoForm.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FN_FISCAL.FPaype fPaype = new FN_FISCAL.FPaype();
            fPaype.ShowDialog();
        }
    }
    }

