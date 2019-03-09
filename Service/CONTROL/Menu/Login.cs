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
            GTableRegister GTableRegister = new GTableRegister();
            GTableRegister.ShowDialog();
        }

        private String GetTableName()
        {
            return "MS_LOGIN";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.ShowDialog();
        }
    }
}
