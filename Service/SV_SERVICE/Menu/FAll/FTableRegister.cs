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

        //Overloading
        public FTableRegister(int prHandle)
        {
            InitializeComponent();
            //Fill handle
            vHandle = prHandle;

            //FillForm
            FillForm();

            FillColumnDataGridView();

            //Refresh permissions
            RefreshPermissions();
        }

        public FTableRegister()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            TableControl.Insert(GetTableName(), this);
        }

        private void AfterInsert()
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Registered, GetTableName(), vHandle, this);
        }

        private void RegisterOnClick(object sender, EventArgs e)
        {
            if (TableControl.CheckRequiredFields(GetTableName(), this))
            {
                //Save the name in a non visible field
                cLastTableNameTextBox.Text = TableName.Text;

                //Inserts
                Insert();
                AfterInsert();

                //Script generator
                uScriptGenerator.TableScriptGenerator(TableName.Text);
            }
        }

        private String GetTableName()
        {
            return "TC_TABLE";
        }

        private void RefreshPermissions()
        {
            TableControl.RefreshPermissions(GetTableName(), this, vHandle);
        }

        private void RefreshButtons()
        {
            //Column tabpage
            cNewColumnButton.Enabled = FormControl.canAlterChild(GetTableName(), vHandle);
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
            if (TableControl.CheckRequiredFields(GetTableName(), this))
            {
                UpdateData();
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

            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Active, GetTableName(), vHandle, this);
        }

        private void ReturnOnClick(object sender, EventArgs e)
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.AwModification, GetTableName(), vHandle, this);
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
    }

}
