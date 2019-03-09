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

        public static void Insert(String prTableName, Control prParent)
        {
            TextBox vTextBox;
            var vFields = new List<String>();
            int vHandle = 0;
            String vValues = "", vFieldsInsert = "";

            vHandle = GetHandle(prTableName);

            //Get Fields from table
            vFields = TableControl.GetTableFields(prTableName);

            //Fill fields
            foreach (var vFieldName in vFields)
            {
                vTextBox = prParent.Controls.Find(vFieldName, true).FirstOrDefault() as TextBox;
                vValues = vValues + ", '" + vTextBox.Text + "'";
            }

            //Trim field value
            vValues = vValues.TrimStart(',');

            //Fill Columns
            vFields.ForEach(el => vFieldsInsert = vFieldsInsert + el + ", ");
            vFieldsInsert = vFieldsInsert.TrimEnd(',', ' ') + ")";

            //Insert query
            String vQuery = "INSERT INTO " + prTableName + "(HANDLE, " + vFieldsInsert + ") VALUES (" + vHandle + ", " + vValues + ")";
            MessageBox.Show(vQuery);
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

        public static List<String> GetTableFields(String prTableName)
        {
            var vFields = new List<String>();

            DBConnection DBConnection = new DBConnection();
            String vQuery = "SELECT COLUMNNAME FROM TC_COLUMN WHERE ISCOMPONENT = 1 AND [TABLE] = (SELECT HANDLE FROM TC_TABLE WHERE NAME LIKE '" + prTableName + "')";
            Console.WriteLine(vQuery);
            SqlDataReader DataReader = DBConnection.DataReader(vQuery);

            if (DataReader.HasRows)
            {
                while (DataReader.Read())
                {
                    vFields.Add(DataReader.GetString(0));
                }
            }
            else
            {
                return null;
            }

            return vFields;
        }

    }
}
