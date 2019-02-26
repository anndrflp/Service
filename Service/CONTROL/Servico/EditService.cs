using MySql.Data.MySqlClient;
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
    public partial class Service : Form
    {
        int valida = 0;
        String handle = "";

        public Service()
        {
            InitializeComponent();
            
            // Instância do banco
            zDATABASE.cnn conexao = new zDATABASE.cnn();
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
            

        }


        // Métodos de validações

        public void validaCamposVazios()
        {
            
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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

        // Botão cadastrar
        private void button2_Click(object sender, EventArgs e)
        {

            validaCamposVazios();

            if (valida == 1)
            {
                MessageBox.Show("Existem campos obrigatórios não cadastrados");
            }
            else
            {
                

                String service = serviceTextbox.Text;
                String data = dateTextBox.Text;
                String duracao = duracaoTextBox.Text;
                String valor = valorTextBox.Text;
                String obs = obsTextBox.Text;

                String cliente = clienteTextBox.Text;
                String rua = ruaTextBox.Text;
                String contato = contatoTextBox.Text;
                String cidade = cidadeTextBox.Text;
                String bairro = bairroTextBox.Text;
                String num = numTextBox.Text;
                String equipe = equipecomboBox1.Text;
                String status = statuscomboBox2.Text;

                zDATABASE.cnn conexao = new zDATABASE.cnn();

                // Insere na tabelas pessoas
                String query = "INSERT INTO SV_CLIENTE VALUES (0, " 
                                                                + "'" + cliente            + "'," 
                                                                + "'" + rua                + "'," 
                                                                + "'" + bairro             + "',"
                                                                +       num                + ","
                                                                + "'" + cidade             + "',"
                                                                + "'" + contato            + "');";
                
               conexao.insert(query);

                // Insere na tabelas serviço
                String query2 = "INSERT INTO SV_SERVICO VALUES (0, "
                                                                + "'" + service            + "',"
                                                                + "'" + data               + "',"
                                                                +       valor              + ","
                                                                +       duracao            + ","
                                                                + "'" + obs                + "',"
                                                                +     "(SELECT HANDLE FROM SV_EQUIPE WHERE NOME = '" + equipe + "'),"
                                                                +     "(SELECT HANDLE FROM SV_STATUS WHERE NOME = '" + status + "'),"
                                                                +     "(SELECT MAX(HANDLE) FROM SV_CLIENTE)"

                                                                + ");";

                conexao.insert(query2);
                MessageBox.Show("Serviço cadastrado com sucesso");
                limparCampos();


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
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
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
            duracaoTextBox.Text = String.Empty;
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
        }
    }
}
