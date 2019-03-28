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

namespace Service.CONTROL.Menu.ListRegistration
{
    public partial class FReferencesList : Form
    {
        public FReferencesList()
        {
            InitializeComponent();

            DAO.DBConnection conn = new DAO.DBConnection();
            CONTROL.Banco.comandosSql sql = new Banco.comandosSql();

            cReferencesDataGridView.DataSource = conn.DataAdapter(sql.vQueryConsultAllFromReferences());
            cReferencesDataGridView.Columns[0].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zCONTROL.Menu.Referencia referencia = new zCONTROL.Menu.Referencia(0);
            referencia.ShowDialog();
        }

        private void cReferencesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String vHandleReference = cReferencesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            zCONTROL.Menu.Referencia referencia = new zCONTROL.Menu.Referencia(Convert.ToInt32(vHandleReference));
            referencia.ShowDialog();


        }
    }
}

