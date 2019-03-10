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

        public FTableRegister(int prHandle)
        {
            InitializeComponent();
            //Fill handle
            vHandle = prHandle;

            //FillForm
            FillForm();

            //Refresh permissions
            RefreshButtons();
            RefreshPermissions();
            RefreshForm();
        }

        //Overloading
        public FTableRegister()
        {
            InitializeComponent();
            RefreshButtons();
        }

        private void Insert(String prGuid)
        {
            String vInsertQuery = "";

            //Variables of table columns
            String vName = "";
            vHandle = 0;

            //Inserting values to variables
            vName = cTableNameTextBox.Text;
            vHandle = TableControl.GetHandle(GetTableName());

            //Inserting command
            vInsertQuery = " INSERT INTO " + GetTableName() + " (HANDLE, NAME, GUID) VALUES (" + vHandle + ", '" + vName + "', '" + prGuid + "')";
            DBConnection.ExecuteNonQuery(vInsertQuery);
        }

        private void AfterInsert()
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Registered, GetTableName(), vHandle);
        }

        private void RegisterOnClick(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                //Generate a guid
                String vGuid = System.Guid.NewGuid().ToString();

                //Save the name in a non visible field
                cLastTableNameTextBox.Text = cTableNameTextBox.Text;

                //Inserts
                Insert(vGuid);
                AfterInsert();

                //Refresh permissions
                RefreshPermissions();
                RefreshButtons();
                RefreshForm();

                //Script generator
                uScriptGenerator.TableScriptGenerator(cTableNameTextBox.Text, vGuid);
            }
        }

        private String GetTableName()
        {
            return "TC_TABLE";
        }

        private Boolean ValidateRequiredFields()
        {
            if (cTableNameTextBox.Text == null || cTableNameTextBox.Text == "")
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
            cTableNameTextBox.Enabled = FormControl.canAlter(GetTableName(), vHandle);
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

        private void ActiveButtonOnClick(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                UpdateData();
                RefreshButtons();
                RefreshPermissions();
                RefreshForm();
            }
        }

        private void UpdateData()
        {
           String vLastTableName = cLastTableNameTextBox.Text;
           String vTableName = cTableNameTextBox.Text;
           String vGuid = TableControl.GetTableGuid(GetTableName(), vLastTableName);

            if (cTableNameTextBox.Text != cLastTableNameTextBox.Text)
            {
                uScriptGenerator.AlterTableScriptGenerator(vTableName, vLastTableName, vGuid);
                cLastTableNameTextBox.Text = cTableNameTextBox.Text;
            }

            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Active, GetTableName(), vHandle);
        }

        private void FillForm()
        {
            //Field variables
            String vTableName = "";
            String vNumber = "";

            //Fill variables
            String vQuery = "SELECT * FROM " + GetTableName() + " WHERE HANDLE = " + vHandle;
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            while (DataReader.Read())
            {
                vNumber = DataReader["HANDLE"].ToString();
                vTableName = DataReader["NAME"].ToString();
            }

            //Fill fields
            cTableNameTextBox.Text = vTableName;
            cLastTableNameTextBox.Text = vTableName;
            cNumberTextBox.Text = vNumber;
        }

        private void ReturnOnClick(object sender, EventArgs e)
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.AwModification, GetTableName(), vHandle);
            RefreshButtons();
            RefreshForm();
            RefreshPermissions();
        }

        private void NewColumnOnClick(object sender, EventArgs e)
        {
            FColumnRegister FColumnRegister = new FColumnRegister(vHandle, GetTableName());
            FColumnRegister.Show();
        }
    }
}
