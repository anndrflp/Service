using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Constants;
using Service.DAO;

namespace Service.CONTROL.Menu
{
    static class TableControl
    {

        public static int GetHandle(String prTableName)
        {
            DBConnection DBConnection = new DBConnection();

            int vHandle = 0;

            String vQuery = "SELECT MAX(HANDLE) " +
                            " FROM " + prTableName;
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    vHandle = DataReader.GetInt32(0);
                }
                return vHandle + 1;
            }
            else
            {
                return vHandle = 1;
            }
        }

        public static int GetStatus(String prTableName, int prHandle)
        {
            DBConnection DBConnection = new DBConnection();

            int vStatus = 0;

            String vQuery = " SELECT STATUS " +
                            "   FROM " + prTableName + " " +
                            "  WHERE HANDLE = " + prHandle;

            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    vStatus = DataReader.GetInt32(0);
                }
                return vStatus;
            }
            else
            {
                return 0;
            }
        }

        public static void UpdateStatus(int prStatus, String prTableName, int prHandle, Control prControl)
        {
            DBConnection DBConnection = new DBConnection();

            String vQuery = "";

            vQuery = " UPDATE " + prTableName +
                     " SET STATUS = " + prStatus +
                     " WHERE HANDLE = " + prHandle;
            DBConnection.ExecuteNonQuery(vQuery);

            RefreshPermissions(prTableName, prControl, prHandle);
        }

        public static String GetTableGuid(String prTableName, String prTable)
        {
            DBConnection DBConnection = new DBConnection();

            String vGuid = "";

            String vQuery = " SELECT GUID " +
                            "   FROM " + prTableName + " " +
                            "  WHERE TABLENAME LIKE '" + prTable + "'";
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    vGuid = DataReader.GetString(0);
                }
                return vGuid;
            }
            else
            {
                return "";
            }
        }
        public static String GetTableColumns(String prTableName)
        {
            var vFields = new List<String>();
            String vFieldsInsert = "";

            //Get Fields from table
            vFields = GetTableFields(prTableName, 0, 0, null, "Field", 0);
            vFields.ForEach(el => vFieldsInsert = vFieldsInsert + el + ", ");

            vFields = GetTableFields(prTableName, 1, 0, null, "Field", 0);
            vFields.ForEach(el => vFieldsInsert = vFieldsInsert + el + ", ");

            vFields = GetTableFields(prTableName, 0, 1, null, "Field", 0);
            foreach (var vFieldName in vFields)
            {
                if (vFieldName == "TABLE")
                {
                    vFieldsInsert = vFieldsInsert + "[" + vFieldName + "],";
                }
                else
                {
                    vFieldsInsert = vFieldsInsert + vFieldName + ",";
                }
            }
            vFieldsInsert = vFieldsInsert.TrimEnd(',', ' ');

            return vFieldsInsert;

        }
        public static int Insert(String prTableName, Control prParent)
        {
            DBConnection DBConnection = new DBConnection();
            int vHandle = 0;
            String vFieldsInsert = "", vFieldsValues = "";

            //Fill column names
            vFieldsInsert = GetTableColumns(prTableName);

            //Fill column values
            vFieldsValues = GetTextValuesQuery(prTableName, prParent) + GetBooleanValuesQuery(prTableName, prParent) + GetListValuesQuery(prTableName, prParent);
            vHandle = GetHandle(prTableName);

            //Insert query

            String vQuery = "INSERT INTO " + prTableName + "(HANDLE, " + vFieldsInsert + ") VALUES (" + vHandle + "" + vFieldsValues + ")";
            DBConnection.ExecuteNonQuery(vQuery);

            return vHandle;
        }

        public static String GetTextValuesQuery(String prTableName, Control prParent)
        {
            TextBox vTextBox;
            String vValues = "";
            var vFields = new List<String>();

            //Get Fields from table
            vFields = TableControl.GetTableFields(prTableName, 0, 0, null, "Field", 0);

            //Fill fields
            foreach (var vFieldName in vFields)
            {
                vTextBox = prParent.Controls.Find(vFieldName, true).FirstOrDefault() as TextBox;
                vValues = vValues + ", '" + vTextBox.Text + "'";
            }

            return vValues;
        }

        public static String GetBooleanValuesQuery(String prTableName, Control prParent)
        {
            CheckBox vCheckBox;
            String vValues = "";
            var vFields = new List<String>();

            //Get Fields from table
            vFields = TableControl.GetTableFields(prTableName, 1, 0, null, "Field", 0);

            //Fill fields
            foreach (var vFieldName in vFields)
            {
                vCheckBox = prParent.Controls.Find(vFieldName, true).FirstOrDefault() as CheckBox;
                if (vCheckBox.Checked)
                {
                    vValues = vValues + ", 1";
                }
                else
                {
                    vValues = vValues + ", 0";
                }
            }

            return vValues;
        }

        public static String GetListValuesQuery(String prTableName, Control prParent)
        {
            DBConnection DBConnection = new DBConnection();
            SqlDataReader vDataReader;
            ComboBox vComboBox;

            String vValues = "", vListText = "", vQuery = "";

            var vFields = new List<String>();
            var vFk = new List<String>();
            var vFkName = new List<String>();
            var vTranslateField = new List<String>();
            int vCount = 0;

            //Get Fields from table
            vFields = GetTableFields(prTableName, 0, 1, null, "Field", 0);
            vFk = GetTableFields(prTableName, 0, 1, null, "FK", 0);
            vTranslateField = GetTableFields(prTableName, 0, 1, null, null, 0);

            foreach (var vTableHandle in vFk)
            {
                vQuery = "SELECT TABLENAME FROM TC_TABLE WHERE HANDLE = " + vTableHandle;
                vDataReader = DBConnection.DataReader(vQuery);

                if (vDataReader.HasRows)
                {
                    while (vDataReader.Read())
                    {
                        vFkName.Add(vDataReader.GetString(0));
                    }
                }
            }
            //Fill fields
            foreach (var vFieldName in vFields)
            {
                vComboBox = prParent.Controls.Find(vFieldName, true).FirstOrDefault() as ComboBox;
                if (vComboBox.Text == "")
                {
                    vListText = "0";
                }
                else
                {
                    vListText = vComboBox.Text;
                }
                vQuery = "SELECT COLUMNNAME FROM TC_COLUMN WHERE HANDLE = " + vTranslateField[vCount];
                vDataReader = DBConnection.DataReader(vQuery);
                vDataReader.Read();
                String vTranslateFieldName = vDataReader["COLUMNNAME"].ToString();


                vQuery = "SELECT HANDLE FROM " + vFkName[vCount] + " WHERE " + vTranslateFieldName + " = '" + vListText + "'";
                vDataReader = DBConnection.DataReader(vQuery);

                if (vDataReader.HasRows)
                {
                    while (vDataReader.Read())
                    {
                        vValues = vValues + ", " + vDataReader.GetInt32(0).ToString();
                    }
                }
                else
                {
                    vValues = vValues + ", " + 0;
                }
                vCount++;
            }
            return vValues;
        }

        public static String GetFieldTranslate(String prTableName, String prField, String prWhereField, String prWhereOperator, String prValue)
        {
            DBConnection DBConnection = new DBConnection();
            String vQuery = "";

            if (prWhereOperator == "IN")
            {
                vQuery = "SELECT " + prField + " FROM " + prTableName + " WHERE " + prWhereField + " " + prWhereOperator + " (" + prValue + ")";
            }
            else
            {
                vQuery = "SELECT " + prField + " FROM " + prTableName + " WHERE " + prWhereField + " " + prWhereOperator + " " + prValue;
            }

            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    return DataReader.GetString(0);
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public static List<String> GetTableFields(String prTableName, int prIsBoolean, int prIsList, String prCondition, String prReturn, int isPrimaryKey)
        {
            DBConnection DBConnection = new DBConnection();
            var vFields = new List<String>();
            var vFkTable = new List<String>();
            var vTranslateField = new List<String>();

            String vQuery = "";
            if (prCondition == "ALL")
            {
                vQuery = " SELECT COLUMNNAME, CAST(COALESCE(FOREIGNKEYTABLE, 0) AS VARCHAR(10)), CAST(COALESCE(TRANSLATEFIELD, '') AS VARCHAR(10)) " +
                               "  FROM TC_COLUMN " +
                               " WHERE ISCOMPONENT = 1 " +
                               "   AND (ISPRIMARYKEY = " + isPrimaryKey + " OR ISPRIMARYKEY = 0) " +
                               "   AND [TABLE] = (SELECT HANDLE " +
                               "                    FROM TC_TABLE " +
                               "                   WHERE TABLENAME LIKE '" + prTableName + "')";
            }
            else
            {
                vQuery = " SELECT COLUMNNAME, CAST(COALESCE(FOREIGNKEYTABLE, 0) AS VARCHAR(10)), CAST(COALESCE(TRANSLATEFIELD, '') AS VARCHAR(10))" +
                               "  FROM TC_COLUMN " +
                               " WHERE ISCOMPONENT = 1 " +
                               "   AND ISBOOLEAN = " + prIsBoolean + " " +
                               "   AND ISLIST = " + prIsList + " " +
                               "   AND (ISPRIMARYKEY = " + isPrimaryKey + " OR ISPRIMARYKEY = 0) " +
                               "   AND [TABLE] = (SELECT HANDLE " +
                               "                    FROM TC_TABLE " +
                               "                   WHERE TABLENAME LIKE '" + prTableName + "')";
            }
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);
            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    vFields.Add(DataReader.GetString(0));
                    vFkTable.Add(DataReader.GetString(1));
                    vTranslateField.Add(DataReader.GetString(2));
                }
            }
            else
            {
                return null;
            }

            if (prReturn == "Field")
            {
                return vFields;
            }
            else
            {
                if (prReturn == "FK")
                {
                    return vFkTable;
                }
                else
                {
                    return vTranslateField;
                }
            }

        }

        public static List<Int32> GetFkTable(String prTableName)
        {
            DBConnection DBConnection = new DBConnection();
            var vForeignTable = new List<Int32>();
            String vQuery = "";

            vQuery = " SELECT FOREIGNKEYTABLE " +
               "  FROM TC_COLUMN " +
               " WHERE ISCOMPONENT = 1 " +
               "   AND ISLIST = 1 " +
               "   AND [TABLE] = (SELECT HANDLE " +
               "                    FROM TC_TABLE " +
               "                   WHERE TABLENAME LIKE '" + prTableName + "')";

            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    vForeignTable.Add(DataReader.GetInt32(0));
                }
            }
            else
            {
                return null;
            }

            return vForeignTable;
        }


        public static void FillForm(String prTableName, Control prControl, int prHandle)
        {
            DBConnection DBConnection = new DBConnection();
            String vFieldsValues = "", vQuery = "", vQuery2 = "";
            TextBox vTextBox = null;
            CheckBox vCheckBox = null;
            ComboBox vComboBox = null;
            SqlDataReader vDataReader2 = null;

            var vFields = new List<String>();

            vQuery = "SELECT * FROM " + prTableName + " WHERE HANDLE = " + prHandle;
            SqlDataReader vDataReader = DBConnection.DataReader(vQuery);
            vDataReader.Read();

            //Fill Text box
            vFields = GetTableFields(prTableName, 0, 0, null, "Field", 1);
            if (vFields != null)
            {
                foreach (var vFieldName in vFields)
                {
                    vTextBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as TextBox;
                    vTextBox.Text = vDataReader[vFieldName].ToString();
                }
            }

            //Fill Check box
            vFields = GetTableFields(prTableName, 1, 0, null, "Field", 0);
            if (vFields != null)
            {
                foreach (var vFieldName in vFields)
                {
                    vCheckBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as CheckBox;
                    vCheckBox.Checked = vDataReader[vFieldName].ToString() == "1";
                }
            }

            // Fill Combo box
            vFields = GetTableFields(prTableName, 0, 1, null, "Field", 0);
            if (vFields != null)
            {
                foreach (var vFieldName in vFields)
                {
                    vQuery2 = "	SELECT B.TABLENAME FOREIGNKEYTABLE," +
                              "        C.COLUMNNAME TRANSLATEFIELD" +
                              "   FROM TC_COLUMN A" +
                              "       INNER JOIN TC_TABLE B ON B.HANDLE = A.FOREIGNKEYTABLE" +
                              "       INNER JOIN TC_COLUMN C ON C.HANDLE = A.TRANSLATEFIELD" +
                              "  WHERE A.HANDLE = (SELECT HANDLE " +
                              "                      FROM TC_COLUMN " +
                              "                     WHERE COLUMNNAME LIKE '" + vFieldName + "' " +
                              "                       AND[TABLE] = (SELECT HANDLE " +
                              "                                       FROM TC_TABLE " +
                              "                                      WHERE TABLENAME LIKE '" + prTableName + "'))";
                    vDataReader2 = DBConnection.DataReader(vQuery2);
                    vDataReader2.Read();

                    if (vDataReader[vFieldName].ToString() != "" && vDataReader2.HasRows)
                    {
                        vQuery2 = "SELECT " + vDataReader2["TRANSLATEFIELD"].ToString() + " TRANSLATEFIELD FROM " + vDataReader2["FOREIGNKEYTABLE"] + " WHERE HANDLE = " + vDataReader[vFieldName];
                        vDataReader2 = DBConnection.DataReader(vQuery2);
                        vDataReader2.Read();
                        if (vDataReader2.HasRows)
                        {
                            vComboBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as ComboBox;
                            vComboBox.Text = vDataReader2["TRANSLATEFIELD"].ToString();
                        }
                    }
                }
            }
        }

        public static void ComboBoxDropDown(String prTableName, String prFieldName, Control prControl, String prParameter)
        {
            ComboBox vComboBox = null;
            DBConnection DBConnection = new DBConnection();

            vComboBox = prControl.Controls.Find(prFieldName, true).FirstOrDefault() as ComboBox;
            vComboBox.Items.Clear();

            String vTranslateField = "", vTableForeignKey = "";

            String vQuery = " SELECT B.COLUMNNAME TRANSLATEFIELD, " +
                            "        C.TABLENAME TABLEFOREIGNKEY " +
                            "   FROM TC_COLUMN A " +
                            "       INNER JOIN TC_COLUMN B ON B.HANDLE = A.TRANSLATEFIELD " +
                            "       INNER JOIN TC_TABLE C ON C.HANDLE = A.FOREIGNKEYTABLE " +
                            "  WHERE A.COLUMNNAME LIKE '" + prFieldName + "' " +
                            "    AND A.[TABLE] = (SELECT HANDLE " +
                            "                     FROM TC_TABLE " +
                            "                    WHERE TABLENAME LIKE '" + prTableName + "') ";

            SqlDataReader vDataReader = DBConnection.DataReader(vQuery);

            if (vDataReader.HasRows)
            {
                while (vDataReader.Read())
                {
                    vTranslateField = vDataReader["TRANSLATEFIELD"].ToString();
                    vTableForeignKey = vDataReader["TABLEFOREIGNKEY"].ToString();
                }
            }
            vDataReader.Close();

            vQuery = " SELECT " + vTranslateField + " " +
                     "   FROM " + vTableForeignKey + " " +
                     "  WHERE STATUS = " + AdConstants.AdConstantsStatus.Active +
                     " " + prParameter;
            vDataReader = DBConnection.DataReader(vQuery);

            if (vDataReader.HasRows)
            {
                while (vDataReader.Read())
                {
                    vComboBox.Items.Add(vDataReader[vTranslateField].ToString());
                }
            }
            vDataReader.Close();
        }

        public static int GetTableTranslate(String prTableName, String prFieldName, Control prControl)
        {
            ComboBox vComboBox = null;
            DBConnection DBConnection = new DBConnection();

            String vTranslateField = "", vTableForeignKey = "";

            String vQuery = " SELECT B.COLUMNNAME TRANSLATEFIELD, " +
                            "        C.TABLENAME TABLEFOREIGNKEY " +
                            "   FROM TC_COLUMN A " +
                            "       INNER JOIN TC_COLUMN B ON B.HANDLE = A.TRANSLATEFIELD " +
                            "       INNER JOIN TC_TABLE C ON C.HANDLE = A.FOREIGNKEYTABLE " +
                            "  WHERE A.COLUMNNAME LIKE '" + prFieldName + "' " +
                            "    AND A.[TABLE] = (SELECT HANDLE " +
                            "                     FROM TC_TABLE " +
                            "                    WHERE TABLENAME LIKE '" + prTableName + "') ";

            SqlDataReader vDataReader = DBConnection.DataReader(vQuery);

            if (vDataReader.HasRows)
            {
                while (vDataReader.Read())
                {
                    vTranslateField = vDataReader["TRANSLATEFIELD"].ToString();
                    vTableForeignKey = vDataReader["TABLEFOREIGNKEY"].ToString();
                }
            }
            vDataReader.Close();

            vComboBox = prControl.Controls.Find(prFieldName, true).FirstOrDefault() as ComboBox;
            vQuery = " SELECT HANDLE " +
                     "   FROM " + vTableForeignKey + " " +
                     "  WHERE " + vTranslateField + " LIKE '" + vComboBox.Text + "'";
            vDataReader = DBConnection.DataReader(vQuery);

            if (vDataReader.HasRows)
            {
                vDataReader.Read();
                return Convert.ToInt32(vDataReader["HANDLE"]);
            }

            return 0;
        }

        public static void ClearComponents(String[] prFields, String prTableName, Control prControl)
        {
            DBConnection DBConnection = new DBConnection();
            SqlDataReader vDataReader;

            ComboBox vComboBox = null;
            TextBox vTextBox = null;
            CheckBox vCheckBox = null;

            String vQuery = "";

            foreach (var vFieldName in prFields)
            {
                vQuery = " SELECT ISCOMPONENT, " +
                         "        ISBOOLEAN, " +
                         "        ISLIST " +
                         "   FROM TC_COLUMN" +
                         "  WHERE COLUMNNAME = '" + vFieldName + "'" +
                         "    AND [TABLE] = (SELECT HANDLE FROM TC_TABLE WHERE TABLENAME LIKE '" + prTableName + "')";
                vDataReader = DBConnection.DataReader(vQuery);

                if (vDataReader.HasRows)
                {
                    vDataReader.Read();
                    if (Convert.ToInt32(vDataReader["ISCOMPONENT"]) == 0)
                    {
                        new Exception("Este campo não é um componente! Campo: " + vFieldName);
                    }
                    else
                    {
                        if (Convert.ToInt32(vDataReader["ISBOOLEAN"]) == 1)
                        {
                            vCheckBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as CheckBox;
                            vCheckBox.Checked = false;
                        }
                        else
                        {
                            if (Convert.ToInt32(vDataReader["ISLIST"]) == 1)
                            {
                                vComboBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as ComboBox;
                                vComboBox.Text = null;
                            }
                            else
                            {
                                vTextBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as TextBox;
                                vTextBox.Clear();
                            }
                        }
                    }
                }
            }
        }

        public static Boolean CheckRequiredFields(String prTableName, Control prControl)
        {
            DBConnection DBConnection = new DBConnection();
            SqlDataReader vDataReader;

            ComboBox vComboBox = null;
            TextBox vTextBox = null;

            String vQuery = "", vField = "", vFieldNickName = "";

            vQuery = "SELECT COLUMNNAME," +
                     "       ISLIST, " +
                     "       NICKNAME " +
                     "  FROM TC_COLUMN " +
                     " WHERE ISREQUIRED = 1 " +
                     "   AND [TABLE] = (SELECT HANDLE " +
                     "                    FROM TC_TABLE " +
                     "                   WHERE TABLENAME LIKE '" + prTableName + "') ";
            vDataReader = DBConnection.DataReader(vQuery);
            try
            {
                if (vDataReader.HasRows)
                {
                    while (vDataReader.Read())
                    {
                        vField = vDataReader["COLUMNNAME"].ToString();
                        vFieldNickName = vDataReader["NICKNAME"].ToString();

                        if (Convert.ToInt32(vDataReader["ISLIST"]) == 1)
                        {
                            vComboBox = prControl.Controls.Find(vField, true).FirstOrDefault() as ComboBox;
                            if (vComboBox.Text == "" || vComboBox.Text == null)
                            {
                                MessageBox.Show("O campo " + vFieldNickName + " é obrigatório, preencha o campo para salvar o registro.", "Campo obrigatório!");
                                return false;
                            }
                        }
                        else
                        {
                            vTextBox = prControl.Controls.Find(vField, true).FirstOrDefault() as TextBox;

                            if (vTextBox.Text == "" || vTextBox.Text == null)
                            {
                                MessageBox.Show("O campo " + vFieldNickName + " é obrigatório, preencha o campo para salvar o registro.", "Campo obrigatório!");
                                return false;
                            }
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                vDataReader.Close();
            }

            return true;
        }

        public static void RefreshPermissions(String prTableName, Control prControl, int prHandle)
        {
            int vStatus = TableControl.GetStatus(prTableName, prHandle);

            RefreshForm(prTableName, prControl, prHandle, vStatus);
        }

        private static void RefreshForm(String prTableName, Control prControl, int prHandle, int prStatus)
        {
            //Set readonly
            RefreshFormReadOnly(prControl, prTableName, prStatus);

            //Set title
            RefreshFormTitle(prTableName, prControl, prStatus);
        }

        private static void RefreshFormReadOnly(Control prControl, String prTableName, int prStatus)
        {

            var vFields = new List<String>();

            Boolean vCanAlter = FormControl.canAlter(prStatus);

            vFields = GetTableFields(prTableName, 0, 0, "ALL", "Field", 0);

            ComboBox vComboBox = null;
            TextBox vTextBox = null;
            CheckBox vCheckBox = null;

            MessageBox.Show(vCanAlter.ToString());
            foreach (var vFieldName in vFields)
            {
                vComboBox = null;
                vTextBox = null;
                vCheckBox = null;

                vComboBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as ComboBox;
                if (vComboBox != null)
                {
                    vComboBox.Enabled = vCanAlter;
                }

                vTextBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as TextBox;
                if (vTextBox != null)
                {
                    vTextBox.ReadOnly = !vCanAlter;
                }

                vCheckBox = prControl.Controls.Find(vFieldName, true).FirstOrDefault() as CheckBox;
                if (vCheckBox != null)
                {
                    vCheckBox.Enabled = vCanAlter;
                }
            }

        }

        private static void RefreshFormTitle(String prTableName, Control prControl, int prStatus)
        {
            DBConnection DBConnection = new DBConnection();
            SqlDataReader vDataReader;

            String vQuery = "", vFormName = "";

            vQuery = " SELECT FORM " +
                     "   FROM TC_TABLE " +
                     "  WHERE TABLENAME LIKE '" + prTableName + "'";
            vDataReader = DBConnection.DataReader(vQuery);

            if (vDataReader.HasRows)
            {
                vDataReader.Read();
                vFormName = vDataReader["FORM"].ToString();
            }
            vDataReader.Close();

            vFormName = vFormName + FormControl.GetConstantTranslationAdConstantsStatus(prStatus);

            prControl.Text = vFormName;
        }

        private static void RefreshFormButtons(Control prControl, int prStatus)
        {
            Button vActive = prControl.Controls.Find("Active", true).FirstOrDefault() as Button;
            Button vRegister = prControl.Controls.Find("Register", true).FirstOrDefault() as Button;
            Button vReturn = prControl.Controls.Find("Return", true).FirstOrDefault() as Button;
            Button vCancel = prControl.Controls.Find("Cancel", true).FirstOrDefault() as Button;

            if(vActive != null)
            {
                vActive.Visible = FormControl.canActive(prStatus);
            }

            if (vRegister != null)
            {
                vRegister.Visible = FormControl.canRegister(prStatus);
            }

            if (vReturn != null)
            {
                MessageBox.Show(FormControl.canReturn(prStatus).ToString());
                vReturn.Visible = FormControl.canReturn(prStatus);
            }

            if (vCancel != null)
            {
                vCancel.Visible = FormControl.canCancel(prStatus);
            }
        }

    }
}
