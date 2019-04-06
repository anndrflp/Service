using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DAO;
using Service.Constants;
namespace Service.CONTROL.Menu
{
    static class uScriptGenerator
    {
        //Default variables
        static int vHandle = 0, vType = 0;

        public static void TableScriptGenerator(String prTableName)
        {
            DBConnection DBConnection = new DBConnection();
            //Create the command
            String vCommand = " CREATE TABLE " + prTableName +
                              " (HANDLE INT PRIMARY KEY)";

            //Insert variables
            vHandle = TableControl.GetHandle(GetTableName());
            vType = TcConstants.TcConstantsCommandType.Create;

            //Insert the command
            String vInsertQuery = "INSERT INTO " + GetTableName() + "(HANDLE, COMMAND, TYPE) VALUES (" + vHandle + ", '" + vCommand + "', " + vType + ")";
           // DBConnection.ExecuteNonQuery(vInsertQuery);
        }

        public static void AlterTableScriptGenerator(String prTableName, String prLastTableName)
        {
            DBConnection DBConnection = new DBConnection();
            //Create the command
            String vCommand = "EXEC SP_RENAME ''" + prLastTableName + "'', ''" + prTableName + "''"; 

            //Insert variables
            vHandle = TableControl.GetHandle(GetTableName());
            vType = TcConstants.TcConstantsCommandType.Alter;

            //Insert the command
            String vInsertQuery = "INSERT INTO " + GetTableName() + "(HANDLE, COMMAND, TYPE, GUID) VALUES (" + vHandle + ", '" + vCommand + "', " + vType + ")";
            Console.WriteLine(vInsertQuery);
         //   DBConnection.ExecuteNonQuery(vInsertQuery);
        }

        static private String GetTableName()
        {
            return "TC_COMMAND";
        }
    }
}
