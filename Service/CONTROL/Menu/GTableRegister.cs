using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.DAL;

namespace Service.CONTROL.Menu
{
    public partial class GTableRegister : Form
    {
        //Database class
        DBConnection DBConnection = new DBConnection();

        public GTableRegister()
        {
            InitializeComponent();
            FillDataGridView();
        }

        //Fills the data grid view with data
        private void FillDataGridView()
        {
            String vQuery = " SELECT HANDLE Handle, " +
                            "        NAME Name " +
                            " FROM " + GetTableName();
            cDataGridView.DataSource = DBConnection.DataAdapter(vQuery); 
        }
        private void NewOnClick(object sender, EventArgs e)
        {
            FTableRegister FTableRegister = new FTableRegister();
            FTableRegister.ShowDialog();
        }
        
        private String GetTableName()
        {
            return "TC_TABLE";
        }
    }
}
