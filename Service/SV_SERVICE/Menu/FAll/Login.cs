using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.CONTROL;

namespace Service.CONTROL.Menu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterOnClick(object sender, EventArgs e)
        {
            //Security validation here
            //------------------------


        }

        private String GetTableName()
        {
            return "MS_LOGIN";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customInstaller1_AfterInstall(object sender, System.Configuration.Install.InstallEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tecnologiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DAO.DBCommandDML dml = new DAO.DBCommandDML();
            dml.CommandDML();
            GTableRegister GTableRegister = new GTableRegister();
            GTableRegister.ShowDialog();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.ShowDialog();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FN_FISCAL.FFiscal.FUserRegister fUserRegister = new FN_FISCAL.FFiscal.FUserRegister();
            fUserRegister.ShowDialog();
        }
    }
}
