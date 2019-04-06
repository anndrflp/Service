using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.CONTROL.Menu.FDelete
{
    public partial class FStatusDelete : Form
    {
        public FStatusDelete()
        {
            InitializeComponent();
            DAO.DBConnection dBConnection = new DAO.DBConnection();

            DataTable vDataReferences = dBConnection.DataAdapter("SELECT NOME FROM SV_STATUS");
            cReferencesComboBox.DataSource = vDataReferences;
            cReferencesComboBox.ValueMember = "NOME";


        }

        private void cConfirmarButton_Click(object sender, EventArgs e)
        {
            DAO.DBConnection dBConnection = new DAO.DBConnection();
            MessageBox.Show("Tem certeza que deseja deletar o registro :" + cReferencesComboBox.Text + " -- Lembre-se se existir um registro de serviço com esta referencia não será possível a exclusão");
            dBConnection.ExecuteNonQuery("DELETE SV_STATUS WHERE NOME = '" + cReferencesComboBox.Text + "'");
            MessageBox.Show("Registro deletado com sucesso");
        }

        private void cCancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
