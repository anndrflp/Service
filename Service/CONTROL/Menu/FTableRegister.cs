using Service.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Constants;

namespace Service.CONTROL.Menu
{
    public partial class FTableRegister : Form
    {
        //Database class
        DBConnection DBConnection = new DBConnection();

        public FTableRegister()
        {
            InitializeComponent();
        }
        
        private void Insert()
        {

        }
        private void AfterInsert()
        {
            int v = AdConstants.AdConstantsStatus.Active;
            MessageBox.Show(v.ToString());
        }
        private void GravarOnClick(object sender, EventArgs e)
        {
            Insert();
            AfterInsert();
        }
    }
}
