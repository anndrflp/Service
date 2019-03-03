using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.DAO;

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

            cDataGridView.Columns[0].Visible = false;
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

        private void GerenciamentoCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get handle from first column
            int vHandle = Int32.Parse(cDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            FTableRegister FTableRegister = new FTableRegister(vHandle);
            FTableRegister.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.ShowDialog();
        }
    }
}
