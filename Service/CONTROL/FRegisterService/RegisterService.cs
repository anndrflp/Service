﻿using CalendarDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;


namespace Service.zCONTROL
{
    public partial class RegisterService : Form
    {
        Boolean editar = false;
        int valida = 0;
        String handle = "";



        // Chama o cadastro de serviõ
        public RegisterService(int tipoFormulario, String prStartDate, String prEndDate)
        {
            InitializeComponent();

            if (tipoFormulario == 0)
            {
                editar = false;
                buttonEditar.Enabled = false;
                iniciaCadastro();
                dateTextBox.Text = prStartDate;
                datefinalTextBox.Text = prEndDate;
            }
            else
            {
                editar = true;
                int linha = tipoFormulario;
                String linha1 = Convert.ToString(linha);
                handleTextBox.Text = linha1;
                preencheCampos(linha);
                bloquearCampos(); 
            }

        }


        // Métodos de validações
        public void validaCamposVazios()
        {

            if(valorTextBox.Text == "")
            {
                valida = 1;
            }

            if (serviceTextbox.Text == "")
            {
                valida = 1;
            }


            if (dateTextBox.Text == "")
            {
                valida = 1;
            }


            if (clienteTextBox.Text == "")
            {
                valida = 1;
            }


            if (contatoTextBox.Text == "")
            {
                valida = 1;
            }


        }
        // Caso seja cadastro
        public void iniciaCadastro()
        {
            // Instância do banco
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            DataTable dt = new DataTable();
            String query = "SELECT NOME FROM SV_EQUIPE";

            // Executando a consulta Sql e colocando no combobox1
            dt = conexao.consultCombobox(query);
            equipecomboBox1.DataSource = dt;
            equipecomboBox1.ValueMember = "nome";


            DataTable dt2 = new DataTable();
            String query2 = "SELECT NOME FROM SV_STATUS";
            dt2 = conexao.consultCombobox(query2);

            statuscomboBox2.DataSource = dt2;
            statuscomboBox2.ValueMember = "nome";
            equipecomboBox1.Text = String.Empty;


            DataTable dt3 = new DataTable();
            String query3 = "SELECT REFERENCIA FROM SV_REFERENCIA";
            dt3 = conexao.consultCombobox(query3);

            referenciacomboBox1.DataSource = dt3;
            referenciacomboBox1.ValueMember = "REFERENCIA";
            referenciacomboBox1.Text = String.Empty;
        }
        // Caso seja edição - 
        public void preencheCampos(int line)
        {
            int linha = line;
             DAO.conexaoSql conexao = new DAO.conexaoSql();

            // Referencia comboBox
            DataTable dt3 = new DataTable();
            String query3 =

               " SELECT D.REFERENCIA FROM SV_SERVICO A " +
                      " INNER JOIN SV_CLIENTE B ON A.CLIENTE = B.HANDLE " +
                      "   INNER JOIN SV_ENDERECO C ON B.ENDERECO = C.HANDLE " +
                      "  INNER JOIN SV_REFERENCIA D ON C.REFERENCIA = D.HANDLE " +
                      "  WHERE A.HANDLE = " + line;


            dt3 = conexao.consultCombobox(query3);

            referenciacomboBox1.DataSource = dt3;
            referenciacomboBox1.ValueMember = "REFERENCIA";
            equipecomboBox1.Text = String.Empty;

            DataTable dt = new DataTable();
            String query = " SELECT A.NOME FROM SV_EQUIPE A " +
                            " INNER JOIN SV_SERVICO B ON B.EQUIPE = A.HANDLE" +
                            " WHERE B.HANDLE = " + line;

            // Executando a consulta Sql e colocando no combobox1
            dt = conexao.consultCombobox(query);
            equipecomboBox1.DataSource = dt;
            equipecomboBox1.ValueMember = "nome";


            DataTable dt2 = new DataTable();
            String query2 = "SELECT A.NOME FROM SV_STATUS A" +
                            " INNER JOIN SV_SERVICO B ON B.STATUS = A.HANDLE" +
                            " WHERE B.HANDLE = " + line;
            dt2 = conexao.consultCombobox(query2);

            statuscomboBox2.DataSource = dt2;
            statuscomboBox2.ValueMember = "nome";


            //SV_CLIENTE
            clienteTextBox.Text = conexao.consultCliente(line);
            contatoTextBox.Text = conexao.consultContato(line);
            //SV_ENDERECO
            bairroTextBox.Text = conexao.consultBairro(line);
            cidadeTextBox.Text = conexao.consultCidade(line);
            ruaTextBox.Text = conexao.consultRua(line);
            numTextBox.Text = conexao.consultNum(line);
            //SV_SERVICE
            serviceTextbox.Text = conexao.consultService(line);
            dateTextBox.Text = conexao.consultDatainicial(line);
            datefinalTextBox.Text = conexao.consultDatafinal(line);
            obsTextBox.Text = conexao.consultObs(line);
            duracaoTextBox.Text = conexao.consultDuracao(line);
            valorTextBox.Text = conexao.consultValor(line);
        


            



        }
        public void bloquearCampos()
        {
            clienteTextBox.Enabled = false;
            referenciacomboBox1.Enabled = false;
            numTextBox.Enabled = false;
            cidadeTextBox.Enabled = false;
            ruaTextBox.Enabled = false;
            bairroTextBox.Enabled = false;
            contatoTextBox.Enabled = false;
            equipecomboBox1.Enabled = false;
            statuscomboBox2.Enabled = false;
            serviceTextbox.Enabled = false;
            dateTextBox.Enabled = false;
            datefinalTextBox.Enabled = false;
            valorTextBox.Enabled = false;
            obsTextBox.Enabled = false;
            duracaoTextBox.Enabled = false;
            entreguecheckBox.Enabled = false;
            recebidocheckBox.Enabled = false;
            obraProntocheckBox.Enabled = false;
            encomendadocheckBox.Enabled = false;
            semDataCheckBox.Enabled = false;
        }
        public void liberarCampos()
        {
            clienteTextBox.Enabled = true;
            referenciacomboBox1.Enabled = true;
            numTextBox.Enabled = true;
            cidadeTextBox.Enabled = true;
            ruaTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            contatoTextBox.Enabled = true;
            equipecomboBox1.Enabled = true;
            statuscomboBox2.Enabled = true;
            serviceTextbox.Enabled = true;
            dateTextBox.Enabled = true;
            datefinalTextBox.Enabled = true;
            valorTextBox.Enabled = true;
            obsTextBox.Enabled = true;
            duracaoTextBox.Enabled = true;
            entreguecheckBox.Enabled = true;
            recebidocheckBox.Enabled = true;
            obraProntocheckBox.Enabled = true;
            encomendadocheckBox.Enabled = true;
            semDataCheckBox.Enabled = true;
        }
        public void recalculaComboBox()
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            DataTable dt = new DataTable();
            String query = " SELECT A.NOME FROM SV_EQUIPE A ";
            dt = conexao.consultCombobox(query);
            equipecomboBox1.DataSource = dt;
            equipecomboBox1.ValueMember = "nome";


            DataTable dt2 = new DataTable();
            String query2 = "SELECT A.NOME FROM SV_STATUS A";
            dt2 = conexao.consultCombobox(query2);
            statuscomboBox2.DataSource = dt2;
            statuscomboBox2.ValueMember = "nome";

            DataTable dt3 = new DataTable();
            String query3 = "SELECT A.REFERENCIA FROM SV_REFERENCIA A";
            dt3 = conexao.consultCombobox(query3);
            referenciacomboBox1.DataSource = dt3;
            referenciacomboBox1.ValueMember = "REFERENCIA";

        }


        private void buttonCancelar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Service_Load(object sender, EventArgs e)
        {

        }

        public Boolean validaDataFinalMenorQueDataInicial(int dataInicial, int dataFinal) {
            Boolean ehvalida = true;

            if (dataFinal - dataInicial < 0)
            {
                ehvalida = false;
            }

            return ehvalida;
        }
        public void inseretabelaDataAgendamento()
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            

            DateTime dataSemConversao = DateTime.Parse(dateTextBox.Text);
            String dataConvertida = dataSemConversao.ToString("yyyy/dd/MM HH:mm:ss");

            DateTime dataFinalSemConversao = DateTime.Parse(datefinalTextBox.Text);
            String dataFinalConvertida = dataFinalSemConversao.ToString("yyyy/dd/MM HH:mm:ss");

            String dia = dataSemConversao.ToString("dd");
            String mes = dataSemConversao.ToString("MM");
            String hora = dataSemConversao.ToString("HH");
            String ano = dataSemConversao.ToString("yyyy");
            String horaFinal = dataFinalSemConversao.ToString("HH");


            int ihoraInicial = Convert.ToInt32(hora);
            int ihoraFinal = Convert.ToInt32(horaFinal);

            int salvarHora = -50;

            while (ihoraFinal - ihoraInicial >= 0)
            {
                 if (salvarHora == -50)
                {
                    String query = "INSERT INTO SV_DATAAGENDAMENTO VALUES (" +
                                                                       ihoraFinal + "," +
                                                                       mes + "," +
                                                                       ano + "," +
                                                                       dia + "," +
                                                                       "(SELECT MAX(HANDLE) FROM SV_SERVICO))";

                    conexao.insert(query);
                    salvarHora = ihoraFinal - ihoraInicial;
                    ihoraFinal = ihoraFinal - 1;
                }
                else
                {

                    String query = "INSERT INTO SV_DATAAGENDAMENTO VALUES (" +
                                                                       ihoraFinal + "," +
                                                                       mes + "," +
                                                                       ano + "," +
                                                                       dia + "," +
                                                                       "(SELECT MAX(HANDLE) FROM SV_SERVICO)" + ")";
                    conexao.insert(query);
                    ihoraFinal = ihoraFinal - 1;
                }
            }


        }
        public void alteratabelaDataAgendamento(int servico)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();

            String queryDelete = "DELETE FROM SV_DATAAGENDAMENTO WHERE SERVICO = " + servico;
            conexao.insert(queryDelete);


            DateTime dataSemConversao = DateTime.Parse(dateTextBox.Text);
            String dataConvertida = dataSemConversao.ToString("yyyy/dd/MM HH:mm:ss");

            DateTime dataFinalSemConversao = DateTime.Parse(datefinalTextBox.Text);
            String dataFinalConvertida = dataFinalSemConversao.ToString("yyyy/dd/MM HH:mm:ss");

            String dia = dataSemConversao.ToString("dd");
            String mes = dataSemConversao.ToString("MM");
            String hora = dataSemConversao.ToString("HH");
            String ano = dataSemConversao.ToString("yyyy");
            String horaFinal = dataFinalSemConversao.ToString("HH");


            int ihoraInicial = Convert.ToInt32(hora);
            int ihoraFinal = Convert.ToInt32(horaFinal);

            int salvarHora = -50;

            while (ihoraFinal - ihoraInicial >= 0)
            {
                if (salvarHora == -50)
                {
                    String query = "INSERT INTO SV_DATAAGENDAMENTO VALUES (" +
                                                                       ihoraFinal + "," +
                                                                       mes + "," +
                                                                       ano + "," +
                                                                       dia + "," +
                                                                       servico + ")";

                    conexao.insert(query);
                    salvarHora = ihoraFinal - ihoraInicial;
                    ihoraFinal = ihoraFinal - 1;
                }
                else
                {

                    String query = "INSERT INTO SV_DATAAGENDAMENTO VALUES (" +
                                                                       ihoraFinal + "," +
                                                                       mes + "," +
                                                                       ano + "," +
                                                                       dia + "," +
                                                                       servico + ")";
                    conexao.insert(query);
                    ihoraFinal = ihoraFinal - 1;
                }
            }


        }
        // Botão cadastrar
        private void buttonCadastrar(object sender, EventArgs e)
        {
            DateTime vDateNotConverted = DateTime.Parse(dateTextBox.Text);
            String vDateConverted = vDateNotConverted.ToString("yyyy/dd/MM HH:mm:ss");
            DateTime vDateFinalNotConverted = DateTime.Parse(datefinalTextBox.Text);
            String vDateFinalConverted = vDateFinalNotConverted.ToString("yyyy/dd/MM HH:mm:ss");


            // Chamando a parte visual para cadastro
            CONTROL.FControlCalender controlCalender = new CONTROL.FControlCalender();
            controlCalender.FRegisterDataInCalender(vDateNotConverted, vDateFinalNotConverted, serviceTextbox.Text, handleTextBox.Text, equipecomboBox1.Text, clienteTextBox.Text, referenciacomboBox1.Text, ruaTextBox.Text, bairroTextBox.Text, numTextBox.Text, contatoTextBox.Text, cidadeTextBox.Text);


            DAO.conexaoSql conexao = new DAO.conexaoSql();
            CONTROL.Banco.comandosSql comandosSql = new CONTROL.Banco.comandosSql();




            String horadataConvertida = vDateNotConverted.ToString("HH");
            String horadataFinalConvertida = vDateFinalNotConverted.ToString("HH");
            
            Convert.ToInt32(horadataFinalConvertida);
            Boolean ehvalidaData = validaDataFinalMenorQueDataInicial(Convert.ToInt32(horadataConvertida), Convert.ToInt32(horadataFinalConvertida));

       


            String service = serviceTextbox.Text;
            String valor = valorTextBox.Text;
            if(valor is null)
            {
                valor = "1";
            }
            String obs = obsTextBox.Text;
            String cliente = clienteTextBox.Text;
            String rua = ruaTextBox.Text;
            String contato = contatoTextBox.Text;
            String cidade = cidadeTextBox.Text;
            String bairro = bairroTextBox.Text;
            String num = numTextBox.Text;
            if (num is null)
            {
                num = "0";
            }
            String equipe = equipecomboBox1.Text;
            String status = statuscomboBox2.Text;
            String duracao = duracaoTextBox.Text;
            if (duracao is null)
            {
                duracao = "0";
            }
            String handleServico = handleTextBox.Text;
            Boolean ehsemdata = semDataCheckBox.Checked;    
            Boolean ehobrapronta = obraProntocheckBox.Checked;
            Boolean ehencomendado = encomendadocheckBox.Checked;
            Boolean ehrecebido = obraProntocheckBox.Checked;
            Boolean ehentregue = entreguecheckBox.Checked;
            

            int intehsemdata;
            int intehobrapronta;
            int intehemcomendado;
            int intehrecebido;
            int intehentregue;
            int ehtransferencia = 0; 
            if (ehobrapronta == true)
            {
                intehobrapronta = 1;
            }
            else
            {
                intehobrapronta = 0;
            }

            if (ehsemdata == true)
            {
                intehsemdata = 1;
            }
            else
            {
                intehsemdata = 0;
            }

            if(ehencomendado == true)
            {
                intehemcomendado = 1;
            }
            else
            {
                intehemcomendado = 0;
            }

            if(ehrecebido == true)
            {
                intehrecebido = 1;
            }
            else
            {
                intehrecebido = 0;
            }

            if (ehentregue == true)
            {
                intehentregue = 1;
            }
            else
            {
                intehentregue = 0;
            }

            if (ehvalidaData == true)
            {
                // Verifica se é uma edição ou um cadastro novo
                if (editar == false)
                {

                    validaCamposVazios();

                    if (valida == 1)
                    {
                        MessageBox.Show("Existem campos obrigatórios não cadastrados");
                    }
                    else
                    {

                        int referencia = 0;
                        referencia = conexao.consultReferenciaHandle(referenciacomboBox1.Text);

                        String queryEndereco = "INSERT INTO SV_ENDERECO VALUES ( "
                                                                        + "'" + rua + "',"
                                                                        + "'" + bairro + "',"
                                                                        + num + ","
                                                                        + "'" + cidade + "',"
                                                                        + referencia +
                                                                         ");";

                        conexao.insert(queryEndereco);

                        // Insere na tabelas pessoas
                        String query = "INSERT INTO SV_CLIENTE VALUES ( "
                                                                        + "'" + cliente + "',"
                                                                        + "'" + contato + "',"
                                                                        + "(SELECT MAX(HANDLE) FROM SV_ENDERECO)"
                                                                        + ");";

                        conexao.insert(query);
                        // Insere na tabelas serviço
                        String query2 = "INSERT INTO SV_SERVICO VALUES ( "
                                                                        + "'" + service + "',"
                                                                        + "'" + vDateConverted + "',"
                                                                        + valor + ",'"
                                                                        + vDateFinalConverted + "',"
                                                                        + "'" + obs + "',"
                                                                        + "(SELECT HANDLE FROM SV_EQUIPE WHERE NOME = '" + equipe + "'),"
                                                                        + "(SELECT HANDLE FROM SV_STATUS WHERE NOME = '" + status + "'),"
                                                                        + "(SELECT MAX(HANDLE) FROM SV_CLIENTE),"
                                                                        + intehsemdata + ","
                                                                        + intehobrapronta + ","
                                                                        + intehentregue + ","
                                                                        + intehemcomendado + ","
                                                                        + intehrecebido + ","
                                                                        + 0 + ","
                                                                        + ehtransferencia + ");";

                        conexao.insert(query2);
                        conexao.insert(comandosSql.queryAtualizaDuracao());
                        //Insere dados na tabela data agendamento

                        inseretabelaDataAgendamento();

                        MessageBox.Show("Serviço cadastrado com sucesso");
                        limparCampos();

                    }
                }
                else
                {
                    validaCamposVazios();
                    if (valida != 1)
                    {
                        int handleReferencia = conexao.consultReferenciaHandle(referenciacomboBox1.Text);
                        int handleEquipe = conexao.consultEquipeHandle(equipe);
                        int handleCliente = conexao.consultClienteHandle(cliente);
                        int handleStatus = conexao.consultStatusHandle(status);

                        String queryEndereco = "UPDATE SV_ENDERECO SET " +
                            "                           RUA                   = '" + rua + "'," +
                            "                           BAIRRO                = '" + bairro + "'," +
                            "                           NUM                   = '" + num + "'," +
                            "                           CIDADE                = '" + cidade + "'," +
                            "                           REFERENCIA            = " + handleReferencia +
                            "                           WHERE HANDLE = (SELECT XX.ENDERECO FROM SV_CLIENTE XX WHERE XX.HANDLE = " + handleCliente + ");";

                        String queryCliente = "UPDATE SV_CLIENTE SET" +
                            "                           NOME                   = '" + cliente + "'," +
                            "                           CONTATO                = '" + contato + "'" +
                            "                           WHERE HANDLE           = '" + handleCliente + ";";

                        String query = "UPDATE SV_SERVICO SET " +
                            "                           SERVICO                 = '" + service + "'," +
                            "                           DATAINICIAL             = '" + vDateConverted + "'," +
                            "                           VALOR                   =  " + valor + "," +
                            "                           DATAFINAL               = '" + vDateFinalConverted + "'," +
                            "                           OBS                     = '" + obs + "'," +
                            "                           EQUIPE                  =  " + handleEquipe + "," +
                            "                           STATUS                  =  " + handleStatus + "," +
                            "                           CLIENTE                 =  " + handleCliente + "," +
                            "                           EHSEMDATA               =  " + intehsemdata + "," +
                            "                           EHOBRAPRONTA            =  " + intehobrapronta + "," +
                            "                           EHENCOMENDADO           =  " + intehemcomendado + "," +
                            "                           EHENTREGUE              =  " + intehentregue + "," +
                            "                           EHRECEBIDO              =  " + intehrecebido + "," +
                            "                           DURACAO                 =  " + duracao + "," +
                            "                           EHTRANSFERENCIA = " + ehtransferencia +
                            "                           WHERE HANDLE            =  " + handleServico + ";";


                        conexao.insert(query);
                        conexao.insert(comandosSql.queryAtualizaDuracaoHandle(handleServico));
                        int servicoHandle = Convert.ToInt32(handleServico);
                        alteratabelaDataAgendamento(servicoHandle);

                        MessageBox.Show("Cadastro alterado");
                        this.Close();
                        editar = false;
                    }
                    else
                    {
                        MessageBox.Show("Campos obrigatorios não preenchidos");
                        valida = 0;
                        editar = true;

                    }
                }
            }
            else
            {
                MessageBox.Show("Data Final menor que a data Inicial");
            }
            
            valida = 0;






        }

        private void valorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void duracaoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }


        }

        private void numTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) // Botão limpar
        {
         
            limparCampos();
        }

        private void limparCampos()
        {
            serviceTextbox.Text = String.Empty;
            dateTextBox.Text = String.Empty;
            datefinalTextBox.Text = String.Empty;
            valorTextBox.Text = String.Empty;
            obsTextBox.Text = String.Empty;

            clienteTextBox.Text = String.Empty;
            ruaTextBox.Text = String.Empty;
            contatoTextBox.Text = String.Empty;
            cidadeTextBox.Text = String.Empty;
            bairroTextBox.Text = String.Empty;
            numTextBox.Text = String.Empty;
            equipecomboBox1.Text = String.Empty;
            statuscomboBox2.Text = String.Empty;
            obraProntocheckBox.Checked = false;
            entreguecheckBox.Checked = false;
            recebidocheckBox.Checked = false;
            encomendadocheckBox.Checked = false;
            semDataCheckBox.Checked = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void referenciacomboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DAO.conexaoSql conexao = new DAO.conexaoSql();
            cidadeTextBox.Text = conexao.consultReferenciaCidade(referenciacomboBox1.Text);
            bairroTextBox.Text = conexao.consultReferenciaCidade(referenciacomboBox1.Text);
            ruaTextBox.Text = conexao.consultReferenciaCidade(referenciacomboBox1.Text);
            numTextBox.Text = conexao.consultReferenciaCidade(numTextBox.Text);

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            liberarCampos();
            recalculaComboBox();
        }

        private void semDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            datefinalTextBox.Enabled = false;
            dateTextBox.Enabled = false;
        }

        private void numTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dateTextBox_KeyDown(object sender, KeyEventArgs e)
        {
     
            if (e.KeyCode == Keys.F4)
            {

                DateTime dataSemConversao = DateTime.Now;
                String dataConvertida = dataSemConversao.ToString("dd/MM/yyyy HH:mm:ss");
                dateTextBox.Text = dataConvertida;
                datefinalTextBox.Text = dataConvertida;


            }
        }

        private void datefinalTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {

                DateTime dataSemConversao = DateTime.Now;
                String dataConvertida = dataSemConversao.ToString("dd/MM/yyyy HH:mm:ss");
                datefinalTextBox.Text = dataConvertida;
            }
        }

        private void datefinalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            DateTime horaInicial = DateTime.Parse(dateTextBox.Text);
            String dataConvertida = horaInicial.ToString("HH");

            DateTime horaFinal = DateTime.Parse(dateTextBox.Text);
            String dataConvertidaFinal = horaFinal.ToString("HH");

            int totalDuracao = Convert.ToInt32(dataConvertida) - Convert.ToInt32(dataConvertidaFinal);

            duracaoTextBox.AppendText(Convert.ToString(totalDuracao));

        }

        private void datefinalTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }
    }
}