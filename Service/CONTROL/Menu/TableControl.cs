using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public static void UpdateStatus(int prStatus, String prTableName, int prHandle)
        {
            DBConnection DBConnection = new DBConnection();

            String vQuery = "";

            vQuery = " UPDATE " + prTableName +
                     " SET STATUS = " + prStatus +
                     " WHERE HANDLE = " + prHandle;
            DBConnection.ExecuteNonQuery(vQuery);
        }

        public static String GetTableGuid(String prTableName, String prTable)
        {
            DBConnection DBConnection = new DBConnection();

            String vGuid = "";

            String vQuery = " SELECT GUID " +
                            "   FROM " + prTableName + " " +
                            "  WHERE NAME LIKE '" + prTable + "'";
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
            TextBox vTextBox;
            var vFields = new List<String>();
            String vFieldsInsert = "";

            //Get Fields from table
            vFields = GetTableFields(prTableName, 0, 0, null, "Field");

            //Fill Columns
            vFields.ForEach(el => vFieldsInsert = vFieldsInsert + el + ", ");

            vFields = GetTableFields(prTableName, 1, 0, null, "Field");
            vFields.ForEach(el => vFieldsInsert = vFieldsInsert + el + ", ");

            vFields = GetTableFields(prTableName, 0, 1, null, "Field");
            vFields.ForEach(el => vFieldsInsert = vFieldsInsert + el + ", ");

            vFieldsInsert = vFieldsInsert.TrimEnd(',', ' ');

            return vFieldsInsert;

        }
        public static void Insert(String prTableName, Control prParent)
        {
            DBConnection DBConnection = new DBConnection();
            int vHandle = 0;
            String vFieldsInsert = "", vFieldsValues = "";

            //Fill column names
            vFieldsInsert = GetTableColumns(prTableName);

            //Fill column values
            vFieldsValues = GetTextValuesQuery(prTableName, prParent);
            vFieldsValues = vFieldsValues + GetBooleanValuesQuery(prTableName, prParent) + GetListValuesQuery(prTableName, prParent);
            vHandle = GetHandle(prTableName);

            //Insert query
            
            String vQuery = "INSERT INTO " + prTableName + "(HANDLE, " + vFieldsInsert + ") VALUES (" + vHandle + "" + vFieldsValues + ")";
            MessageBox.Show(vQuery);
            DBConnection.ExecuteNonQuery(vQuery);
        }

        public static String GetTextValuesQuery(String prTableName, Control prParent)
        {
            TextBox vTextBox;
            String vValues = ""; 
            var vFields = new List<String>();

            //Get Fields from table
            vFields = TableControl.GetTableFields(prTableName, 0, 0, null, "Field");

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
            vFields = TableControl.GetTableFields(prTableName, 1, 0, null, "Field");

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
            vFields = GetTableFields(prTableName, 0, 1, null, "Field");
            vFk = GetTableFields(prTableName, 0, 1, null, "FK");
            vTranslateField = GetTableFields(prTableName, 0, 1, null, null);
            
            foreach(var vTableHandle in vFk)
            {
                vQuery = "SELECT NAME FROM TC_TABLE WHERE HANDLE = " + vTableHandle;
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
                if(vComboBox.Text == "")
                {
                    vListText = vListText + "0";
                }
                else
                {
                    vListText = vComboBox.Text;
                }

                vQuery = "SELECT HANDLE FROM " + vFkName[vCount] + " WHERE " + vTranslateField[vCount] + " = '" + vListText + "'";
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

        public static List<String> GetTableFields(String prTableName, int prIsBoolean, int prIsList, String prCondition, String prReturn)
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
                               "   AND [TABLE] = (SELECT HANDLE " +
                               "                    FROM TC_TABLE " +
                               "                   WHERE NAME LIKE '" + prTableName + "')";
            }
            else
            {
                vQuery = " SELECT COLUMNNAME, CAST(COALESCE(FOREIGNKEYTABLE, 0) AS VARCHAR(10)), CAST(COALESCE(TRANSLATEFIELD, '') AS VARCHAR(10))" +
                               "  FROM TC_COLUMN " +
                               " WHERE ISCOMPONENT = 1 " +
                               "   AND ISBOOLEAN = " + prIsBoolean + " " +
                               "   AND ISLIST = " + prIsList + " " +
                               "   AND [TABLE] = (SELECT HANDLE " +
                               "                    FROM TC_TABLE " +
                               "                   WHERE NAME LIKE '" + prTableName + "')";
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
               "                   WHERE NAME LIKE '" + prTableName + "')";

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

    }
}
