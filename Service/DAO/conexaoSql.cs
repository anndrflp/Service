using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerTypes;

namespace Service.DAO
{
    class conexaoSql
    {


        public void insert(String query)
        {
            // Insert
            var connString = "Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655";
            var connection = new SqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        public DataTable consultCombobox(String query)
        {

            var connString = "Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655";
            var connection = new SqlConnection(connString);
            var command = connection.CreateCommand();


            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;

                reader.Close();
                reader.Dispose();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }



        }
        public string consultService(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String servico = "Sem resultado";
            String data = "Sem data";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT SERVICO FROM SV_SERVICO WHERE HANDLE = " + handle, Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    servico = (Dr["servico"].ToString());


                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return servico;
        }
        public string consultDatainicial(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "Sem resultado";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT DATAINICIAL FROM SV_SERVICO WHERE HANDLE = " + handle, Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["DATAINICIAL"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultDatafinal(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT DATAFINAL FROM SV_SERVICO WHERE HANDLE = " + handle, Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["DATAFINAL"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultObs(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT obs FROM SV_SERVICO WHERE HANDLE = " + handle, Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["obs"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultCliente(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT B.NOME FROM SV_SERVICO A" +
                    "                   INNER JOIN SV_CLIENTE B ON A.CLIENTE = B.HANDLE  WHERE A.HANDLE = " + handle, Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["NOME"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultRua(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand(" SELECT C.RUA FROM SV_SERVICO     A" +
                                                               "                   INNER JOIN SV_CLIENTE           B ON A.CLIENTE = B.HANDLE " +
                                                               "                   INNER JOIN SV_ENDERECO          C ON B.ENDERECO = C.HANDLE " +
                                                               "                   WHERE A.HANDLE = " + handle, Conn);





                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["rua"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultBairro(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand(" SELECT C.BAIRRO FROM SV_SERVICO     A" +
                                                               "                   INNER JOIN SV_CLIENTE           B ON A.CLIENTE = B.HANDLE " +
                                                               "                   INNER JOIN SV_ENDERECO          C ON B.ENDERECO = C.HANDLE " +
                                                               "                   WHERE A.HANDLE = " + handle, Conn);

                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["BAIRRO"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultCidade(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand(" SELECT C.CIDADE FROM SV_SERVICO     A" +
                                                               "                   INNER JOIN SV_CLIENTE           B ON A.CLIENTE = B.HANDLE " +
                                                               "                   INNER JOIN SV_ENDERECO          C ON B.ENDERECO = C.HANDLE " +
                                                               "                   WHERE A.HANDLE = " + handle, Conn);



                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["CIDADE"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultContato(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT B.contato FROM SV_SERVICO A" +
                    "                   INNER JOIN SV_CLIENTE B ON A.CLIENTE = B.HANDLE  WHERE A.HANDLE = " + handle, Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["contato"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultNum(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand(" SELECT C.NUM FROM SV_SERVICO     A" +
                                                               "                   INNER JOIN SV_CLIENTE           B ON A.CLIENTE = B.HANDLE " +
                                                               "                   INNER JOIN SV_ENDERECO          C ON B.ENDERECO = C.HANDLE " +
                                                               "                   WHERE A.HANDLE = " + handle, Conn);



                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["NUM"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultDuracao(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT DURACAO FROM SV_SERVICO WHERE HANDLE = '" + handle + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["duracao"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();

            return variavel;
        }
        public String consultValor(int handle)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT VALOR FROM SV_SERVICO WHERE HANDLE = '" + handle + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["VALOR"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }

            Conn.Close();
            return variavel;
        }

        // Consultar referencias


        public int consultReferenciaHandle(String referencia)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT HANDLE FROM SV_REFERENCIA WHERE REFERENCIA = '" + referencia + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["handle"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            int retorno = Convert.ToInt32(variavel);
            Conn.Close();
            return retorno;
        }
        public String consultReferenciaRua(String referencia)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT RUA FROM SV_REFERENCIA WHERE REFERENCIA = '" + referencia + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["RUA"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultReferenciaNum(String referencia)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT NUM FROM SV_REFERENCIA WHERE REFERENCIA = '" + referencia + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["NUM"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultReferenciaBairro(String referencia)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT BAIRRO FROM SV_REFERENCIA WHERE REFERENCIA = '" + referencia + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["BAIRRO"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }
        public String consultReferenciaCidade(String referencia)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";

            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT CIDADE FROM SV_REFERENCIA WHERE REFERENCIA = '" + referencia + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["CIDADE"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            Conn.Close();
            return variavel;
        }

        public int consultEquipeHandle(String equipe)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT HANDLE FROM SV_EQUIPE WHERE NOME = '" + equipe + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["handle"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            int retorno = Convert.ToInt32(variavel);
            Conn.Close();
            return retorno;

        }
        public String consultEquipeService(String equipe, String prHandleService)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT A.HANDLE FROM SV_EQUIPE A INNER JOIN SV_SERVICO B ON B.EQUIPE = A.HANDLE WHERE B.HANDLE = " + prHandleService + " AND A.NOME = '" + equipe + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["HANDLE"].ToString());
                }
              
            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            return variavel;
            Conn.Close();

        }


        public int consultStatusHandle(String status)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT HANDLE FROM SV_STATUS WHERE NOME = '" + status + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["handle"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            int retorno = Convert.ToInt32(variavel);
            Conn.Close();
            return retorno;
        }

        public int consultClienteHandle(String cliente)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                Cmd = new SqlCommand("SELECT HANDLE FROM SV_CLIENTE WHERE NOME = '" + cliente + "';", Conn);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    variavel = (Dr["handle"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }
            int retorno = Convert.ToInt32(variavel);
            Conn.Close();
            return retorno;
        }
        public int consultDataIgualHandle(String dataInicial, String dataFinal, String equipe)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");
            Conn.Open();
            try
            {

                Cmd = new SqlCommand("SELECT XX.HANDLE FROM sv_servico XX " +
                                                                          "INNER JOIN SV_EQUIPE X1 ON XX.EQUIPE = X1.HANDLE " +
                                                "   WHERE XX.DATAINICIAL >= '" + dataInicial + "'" +
                                                "                  AND XX.DATAFINAL <= '" + dataFinal +
                                                "                  AND X1.NOME =           '" + equipe + "';");

                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {

                    variavel = (Dr["handle"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }

            int retorno = Convert.ToInt32(variavel);
            Conn.Close();
            return retorno;
        }

        public String consultHandleService(String equipe, int hora, String datainicial, String datafinal, int ehiniciar)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {

                Conn.Open();
                if (ehiniciar == 1)
                {

                    Cmd = new SqlCommand(" SELECT  B.HANDLE " +
                                                                                   " FROM SV_DATAAGENDAMENTO A " +
                                                                                   " INNER JOIN sv_servico B ON A.SERVICO = B.HANDLE " +
                                                                                   " INNER JOIN SV_EQUIPE C ON B.EQUIPE = C.HANDLE " +
                                                                                   " AND A.DIA = DAY(GETDATE()) " +
                                                                                   " AND A.MES = MONTH(GETDATE()) " +
                                                                                   " AND A.ANO = YEAR(GETDATE()) " +
                                                                                   "AND B.EHTRANSFERENCIA = 0 " +
                                                                                   " AND A.HORA =" + hora +
                                                                                   " AND C.NOME = '" + equipe + "';", Conn);
                    Dr = Cmd.ExecuteReader();
                }
                else
                {
                    Cmd = new SqlCommand(" SELECT  B.HANDLE " +
                                                               " FROM SV_DATAAGENDAMENTO A " +
                                                               " INNER JOIN sv_servico B ON A.SERVICO = B.HANDLE " +
                                                               " INNER JOIN SV_EQUIPE C ON B.EQUIPE = C.HANDLE " +
                                                                " AND MONTH(B.DATAINICIAL) = DAY('" + datainicial + "') " + // UTILIZADO PORQUE A DATA ESTA INVERTIDA
                                                               // " AND B.DATAFINAL <= CAST(('" + datafinal + "') AS DATETIME) + 1" +
                                                               "AND B.EHTRANSFERENCIA = 0 " +
                                                               " AND A.HORA =" + hora +
                                                               " AND C.NOME = '" + equipe + "';", Conn);
                    Dr = Cmd.ExecuteReader();
                }
                while (Dr.Read())
                {
                    variavel = (Dr["handle"].ToString());
                }

            }
            catch (SqlException Sql)
            {
                throw Sql;
            }

            Conn.Close();
            return variavel;
        }
        public String consultNomeService(String equipe, int hora, String datainicial, String datafinal, int ehiniciar)
        {
            SqlConnection Conn;
            SqlCommand Cmd;
            SqlDataReader Dr;
            String variavel = "";


            Conn = new SqlConnection("Server=25.38.6.103;database=paype;Uid=yan;Pwd=33226655");

            try
            {
                Conn.Open();
                if (ehiniciar == 1)
                {

                    Cmd = new SqlCommand(" SELECT  D.NOME " +
                                                                                   " FROM SV_DATAAGENDAMENTO A " +
                                                                                   " INNER JOIN sv_servico B ON A.SERVICO = B.HANDLE " +
                                                                                   " INNER JOIN SV_CLIENTE D ON B.CLIENTE = D.HANDLE" +
                                                                                   " INNER JOIN SV_EQUIPE C ON B.EQUIPE = C.HANDLE " +
                                                                                   " AND A.DIA = DAY(GETDATE()) " +
                                                                                   " AND A.MES = MONTH(GETDATE()) " +
                                                                                   "AND B.EHTRANSFERENCIA = 0 " +
                                                                                   " AND A.ANO = YEAR(GETDATE()) " +
                                                                                   " AND A.HORA =" + hora +
                                                                                   " AND C.NOME = '" + equipe + "';", Conn);
                    Dr = Cmd.ExecuteReader();
                }
                else
                {
                    Cmd = new SqlCommand(" SELECT  D.NOME " +
                                           " FROM SV_DATAAGENDAMENTO A " +
                                           " INNER JOIN sv_servico B ON A.SERVICO = B.HANDLE " +
                                            " INNER JOIN SV_CLIENTE D ON B.CLIENTE = D.HANDLE" +
                                           " INNER JOIN SV_EQUIPE C ON B.EQUIPE = C.HANDLE " +
                                            " AND MONTH(B.DATAINICIAL) = DAY('" + datainicial + "') " +
                                            "AND B.EHTRANSFERENCIA = 0 " +
                                           // " AND B.DATAFINAL <= CAST(('" + datafinal + "') AS DATETIME) + 1" +
                                           " AND A.HORA =" + hora +
                                           " AND C.NOME = '" + equipe + "';", Conn);

                    Dr = Cmd.ExecuteReader();
                }
                while (Dr.Read())
                {
                    variavel = (Dr["NOME"].ToString());
                }


            }
            catch (SqlException Sql)
            {
                throw Sql;
            }

            Conn.Close();
            return variavel;
        }

    }
}


