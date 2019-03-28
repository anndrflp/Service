using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DAO
{
    class DBCommandDML
    {

        public void CommandDML()
        {
            DAO.DBConnection conn = new DBConnection();
            String[] vCommandDML = new String[200];

            vCommandDML[0] = "ALTER TABLE SV_SERVICO ADD DATAORIGINAL DATETIME;";
            // vCommandDML[1] = "UPDATE SV_SERVICO SET DATAORIGINAL = DATAINICIAL;";

            int vCont = 0;

            while (vCommandDML[vCont] != "")
            {
                conn.ExecuteNonQuery(vCommandDML[vCont]);
                vCont++;
            }
        }


    }
}
