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
using Service.DAO;
using Service.Constants;
namespace Service.CONTROL.Menu
{
    public partial class FColumnRegister : Form
    {
        //Database class
        DBConnection DBConnection = new DBConnection();

        //Default Variables
        int vHandle, vFatherHandle;
        String vFormName = "Coluna", vFatherTable = "";

        public FColumnRegister(int prFatherHandle, String prFatherTable)
        {
            InitializeComponent();

            //Fill father infos
            vFatherHandle = prFatherHandle;
            vFatherTable = prFatherTable;

            FillFormWithFather();

            //Refresh permissions
            RefreshPermissions();
        }

        public FColumnRegister(int prHandle)
        {
            InitializeComponent();
            //Fill handle
            vHandle = prHandle;

            FillForm();

            //Refresh permissions
            RefreshPermissions();
        }

        private void FillForm()
        {
            TableControl.FillForm(GetTableName(), this, vHandle);
        }

        private void FillFormWithFather()
        {
            //Field variables
            String vTableName = "";

            //Fill variables
            String vQuery = "SELECT * FROM " + vFatherTable + " WHERE HANDLE = " + vFatherHandle;
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            while (DataReader.Read())
            {
                vTableName = DataReader["TABLENAME"].ToString();
            }

            //Fill fields
            Table.Text = vTableName;
        }

        private void RefreshPermissions()
        {
            TableControl.RefreshPermissions(GetTableName(), this, vHandle);
        }

        private void ReturnOnClick(object sender, EventArgs e)
        {

        }

        private void RegisterOnClick(object sender, EventArgs e)
        {
            if (TableControl.CheckRequiredFields(GetTableName(), this))
            {
                //Inserts
                Insert();
                AfterInsert();

                //Refresh permissions
                RefreshPermissions();
            }
        }


        private void AfterInsert()
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Registered, GetTableName(), vHandle, this);
        }


        private void ActiveOnClick(object sender, EventArgs e)
        {

        }

        private void DataTypeOnChanged(object sender, EventArgs e)
        {

        }

        private void TableForeignKeyDropDown(object sender, EventArgs e)
        {
            TableControl.ComboBoxDropDown(GetTableName(), "ForeignKeyTable", this, null);
        }

        private void DataTypeOnDropDown(object sender, EventArgs e)
        {
            TableControl.ComboBoxDropDown(GetTableName(), "DataType", this, null);
        }

        private void TranslateFieldOnDropDown(object sender, EventArgs e)
        {
            String vParamenter = " AND [TABLE] = " + TableControl.GetTableTranslate(GetTableName(), "FOREIGNKEYTABLE", this);
            TableControl.ComboBoxDropDown(GetTableName(), "TranslateField", this, vParamenter);
        }

        private void TableForeignKeyOnChanged(object sender, EventArgs e)
        {
            String[] vFields = new String[] {"TRANSLATEFIELD"};
            TableControl.ClearComponents(vFields, GetTableName(), this);
        }

        private void Insert()
        {
            vHandle = TableControl.Insert(GetTableName(), this);
        }

        private String GetTableName()
        {
            return "TC_COLUMN";
        }




    }
}
