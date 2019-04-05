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

            vCommandDML[1] = " CREATE TABLE  SV_SERVICOPARAMETRO " +
                                                     "   (HANDLE INT NOT NULL IDENTITY,          " +
                                                   "     EHFUNDAMENTO BIT, " +
                                                   "    EHCOBERTA BIT, " +
                                                   "    EHREBOCADA BIT, " +
                                                   "    EHOBRAPRONTA BIT , " +
                                                   "    EHMEDIDACOMBINADA BIT, " +
                                                   "    EHCLIENTEAVISO BIT, " +
                                                   "    EHCONFIRMADO BIT, " +
                                                   "     EHENCOMENDADO BIT,  " +
                                                   "     EHRECEBIDO BIT, " +
                                                    "    EHSEPARADO BIT, " +
                                                    "    EHPRONTOINSTALACAO BIT, " +
                                                    "    EHENTREGUE BIT, " +
                                                    "    PRIMARY KEY (HANDLE) ); ";


            vCommandDML[2] = "ALTER TABLE SV_SERVICO ADD SERVICOPARAMETRO INT;";

            vCommandDML[3] = "ALTER TABLE SV_SERVICO ADD CONSTRAINT FK_SERVICOPARAMETRO " +
                                                    "FOREIGN KEY(SERVICOPARAMETRO) REFERENCES SV_SERVICOPARAMETRO(HANDLE);";



            int vCont = 0;

            /*while (vCommandDML[vCont] != "")
            {
                conn.ExecuteNonQuery(vCommandDML[vCont]);
                vCont++;
            }*/
        }


    }
}
