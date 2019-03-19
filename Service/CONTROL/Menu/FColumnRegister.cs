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

            FillForm();

            RefreshButtons();
        }

        public FColumnRegister(int prHandle)
        {
            InitializeComponent();
            //Fill handle
            vHandle = prHandle;

            TableControl.FillForm(GetTableName(), this, vHandle);
            //FillForm
            //FillForm();

            //Refresh permissions
            RefreshButtons();
           // RefreshPermissions();
         //   RefreshForm();
        }

        private void FillForm()
        {
            if (vFatherHandle != 0)
            {
                FillFormWithFather();
            }

            //Field variables
            String vTableName = "", vNumber = "", vName = "", vLenght = "";
            Boolean vIsRequired = false, vIsForeignKey = false;

            //Fill variables
            String vQuery = "SELECT * FROM " + GetTableName() + " WHERE HANDLE = " + vHandle;
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);
            while (DataReader.Read())
            {
                vNumber = DataReader["HANDLE"].ToString();
                vName = DataReader["COLUMNNAME"].ToString();
                vTableName = DataReader["TABLE"].ToString();
                vLenght = DataReader["LENGHT"].ToString();
                vIsRequired = DataReader["ISREQUIRED"].ToString() == "1";
                vIsForeignKey = DataReader["ISFOREIGNKEY"].ToString() == "1";
            }

            //Fill fields
            Handle.Text = vNumber;
            ColumnName.Text = vName;
            Table.Text = vTableName;
            Lenght.Text = vLenght;
            IsRequired.Checked = vIsRequired;
            IsForeignKey.Checked = vIsForeignKey;
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
        //    cTableNameTextBox.Enabled = FormControl.canAlter(GetTableName(), vHandle);
        }

        private void RefreshButtons()
        {
            cActiveButton.Visible = FormControl.canActive(GetTableName(), vHandle);
            cRegisterButton.Visible = FormControl.canRegister(GetTableName(), vHandle);
            cReturnButton.Visible = FormControl.canReturn(GetTableName(), vHandle);
        }

        private void RefreshForm()
        {
            this.Text = FormControl.GetConstantTranslationAdConstantsStatus(GetTableName(), vHandle, vFormName);
        }

        private void ReturnOnClick(object sender, EventArgs e)
        {

        }

        private void RegisterOnClick(object sender, EventArgs e)
        {
            if (ValidateRequiredFields())
            {
                //Inserts
                Insert();
              //  AfterInsert();

                //Refresh permissions
                RefreshPermissions();
                RefreshButtons();
                RefreshForm();
            }
        }


        private void AfterInsert()
        {
            TableControl.UpdateStatus(AdConstants.AdConstantsStatus.Registered, GetTableName(), vHandle);
        }


        private void ActiveOnClick(object sender, EventArgs e)
        {

        }

        private Boolean ValidateRequiredFields()
        {
            if (ColumnName.Text == null || ColumnName.Text == "")
            {
                MessageBox.Show("O campo nome é obrigatório. Preencha o campo para gravar o registro.");
                return false;
            }

            if(DataType.Text == "")
            {
                MessageBox.Show("O campo tipo de dado é obrigatório. Preencha o campo para gravar o registro.");
                return false;
            }

            if((Lenght.Text == null || Lenght.Text == "") && DataType.Text == "Varchar")
            {
                MessageBox.Show("O campo tamanho é obrigatório para este tipo de dado. Preencha o campo para gravar o registro.");
                return false;
            }


            if (IsForeignKey.Checked == true && ForeignKeyTable.Text == "")
            {
                MessageBox.Show("O campo tabela da foreign key é obrigatório quando o campo representa uma chave estrangeira. Preencha o campo para gravar o registro.");
                return false;
            }

            return true;
        }

        private void DataTypeOnChanged(object sender, EventArgs e)
        {
            if (DataType.Text == "Boolean")
            {
                IsBoolean.Checked = true;
            }
            else
            {
                IsBoolean.Checked = false;
            }
        }

        private void TableForeignKeyDropDown(object sender, EventArgs e)
        {
            
        }

        private void Insert()
        {
            TableControl.Insert(GetTableName(), this);
        }

        private String GetTableName()
        {
            return "TC_COLUMN";
        }


    }
}
