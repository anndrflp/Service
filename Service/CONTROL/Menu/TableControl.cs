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

            String vQuery = "SELECT HANDLE " +
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
    }
}
