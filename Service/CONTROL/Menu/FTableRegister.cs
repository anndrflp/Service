using Service.DAO;
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
using System.Data.SqlClient;

namespace Service.CONTROL.Menu
{
    public partial class FTableRegister : Form
    {
        //Database class
        DBConnection DBConnection = new DBConnection();

        //Default Variables
        int vHandle;
        String vFormName = "Tabela";


        //Overloading
        public FTableRegister(int prHandle)
        {
            InitializeComponent();
            //Fill handle
            vHandle = prHandle;

            //FillForm
            FillForm();

            //Refresh permissions
            RefreshAll();

            FillColumnDataGridView();
        }

        public FTableRegister()
        {
            InitializeComponent();
            RefreshAll();
        }

        private void Insert()
        {
            TableControl.Insert(GetTableName(), this);
        }

        private void AfterInsert()
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Registered, GetTableName(), vHandle);
        }

        private void RegisterOnClick(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                //Save the name in a non visible field
                cLastTableNameTextBox.Text = TableName.Text;

                //Inserts
                Insert();
                AfterInsert();

                //Refresh permissions
                RefreshAll();

                //Script generator
                uScriptGenerator.TableScriptGenerator(TableName.Text);
            }
        }

        private String GetTableName()
        {
            return "TC_TABLE";
        }

        private Boolean ValidateRequiredFields()
        {
            if (TableName.Text == null || TableName.Text == "")
            {
                MessageBox.Show("O campo nome é obrigatório. Preencha o campo para gravar o registro.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void RefreshPermissions()
        {
            TableName.Enabled = FormControl.canAlter(GetTableName(), vHandle);
        }

        private void RefreshButtons()
        {
            cActiveButton.Visible = FormControl.canActive(GetTableName(), vHandle);
            cRegisterButton.Visible = FormControl.canRegister(GetTableName(), vHandle);
            cReturnButton.Visible = FormControl.canReturn(GetTableName(), vHandle);

            //Column tabpage
            cNewColumnButton.Enabled = FormControl.canAlterChild(GetTableName(), vHandle);
        }

        private void RefreshForm()
        {
            this.Text = FormControl.GetConstantTranslationAdConstantsStatus(GetTableName(), vHandle, vFormName);
        }

        private void FillColumnDataGridView()
        {
            String vQuery = " SELECT HANDLE, " +
                            "        COLUMNNAME Nome, " +
                            "        DATATYPE 'Tipo de dado', " +
                            "        LENGHT Tamanho, " +
                            "        ISREQUIRED 'Obrigatório', " +
                            "        ISFOREIGNKEY ForeignKey, " +
                            "        FOREIGNKEYTABLE 'Tabela ForeingKey', " +
                            "        ISCOMPONENT Componente, " +
                            "        ISBOOLEAN Booleano, " +
                            "        ISLIST Lista" +
                            "  FROM TC_COLUMN" +
                            "  WHERE [TABLE] = " + vHandle;
            columnDataGridView.DataSource = DBConnection.DataAdapter(vQuery);

            columnDataGridView.Columns[0].Visible = false;
        }

        private void ActiveButtonOnClick(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                UpdateData();
                RefreshAll();
            }
        }

        private void UpdateData()
        {
            String vLastTableName = cLastTableNameTextBox.Text;
            String vTableName = TableName.Text;
            String vGuid = TableControl.GetTableGuid(GetTableName(), vLastTableName);

            if (TableName.Text != cLastTableNameTextBox.Text)
            {
                uScriptGenerator.AlterTableScriptGenerator(vTableName, vLastTableName);
                cLastTableNameTextBox.Text = TableName.Text;
            }

            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Active, GetTableName(), vHandle);
        }

        private void ReturnOnClick(object sender, EventArgs e)
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.AwModification, GetTableName(), vHandle);
            RefreshAll();
        }

        private void NewColumnOnClick(object sender, EventArgs e)
        {
            FColumnRegister FColumnRegister = new FColumnRegister(vHandle, GetTableName());
            FColumnRegister.Show();
        }

        private void ColumnCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get handle from first column
            int vHandle = Int32.Parse(columnDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            FColumnRegister FColumnRegister = new FColumnRegister(vHandle);
            FColumnRegister.ShowDialog();
        }

        private void FillForm()
        {
            TableControl.FillForm(GetTableName(), this, vHandle);
        }

        private void RefreshAll()
        {
            RefreshButtons();
            RefreshPermissions();
            RefreshForm();
        }
    }

}
