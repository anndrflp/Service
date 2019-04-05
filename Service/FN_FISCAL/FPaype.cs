using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.FN_FISCAL
{
    public partial class FPaype : Form
    {
        public FPaype()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FN_FISCAL.FFiscal.FCompanyRegister fCompany = new FFiscal.FCompanyRegister();
            fCompany.ShowDialog();
        }
    }
}
