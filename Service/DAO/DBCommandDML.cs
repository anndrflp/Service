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

            vCommandDML[1] =  /* CREATE TABLE  SV_SERVICOPARAMETROS
                                                    (
                                                    HANDLE INT NOT NULL IDENTITY,
                                                    SERVICO INT NOT NULL,

                                                    EHFUNDAMENTO BIT,
                                                    EHCOBERTA BIT,
                                                    EHREBOCADA BIT,
                                                    EHOBRAPRONTA BIT,
                                                    EHMEDIDACOMBINADA BIT,
                                                    EHCLIENTEAVISO BIT,
                                                    EHCONFIRMADO BIT,
                                                    EHENCOMENDADO BIT,
                                                    EHRECEBIDO BIT,
                                                    EHSEPARADO BIT,
                                                    EHPRONTOINSTALACAO BIT,
                                                    EHENTREGUE BIT,




                                                    CONSTRAINT FK_SERVICO FOREIGN KEY(SERVICO)
                                                    REFERENCES SV_SERVICO(HANDLE),

                                                    PRIMARY KEY(HANDLE)

                                                    );  */   "";

            int vCont = 0;

            while (vCommandDML[vCont] != "")
            {
                conn.ExecuteNonQuery(vCommandDML[vCont]);
                vCont++;
            }
        }


    }
}
