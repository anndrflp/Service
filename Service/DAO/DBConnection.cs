using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service.DAO
{
    class DBConnection
    {
        //Connection String
        private string vConnectionString = "Data Source=25.38.6.103;Initial Catalog=Paype;User ID=yan;Password=33226655";

        //Returns a data reader. Data reader : Vector with columns returned by the query.
        public SqlDataReader DataReader(String prQuery = "")
        {
            SqlConnection vConnection = new SqlConnection();
            vConnection.ConnectionString = this.vConnectionString;
            vConnection.Open();

            SqlCommand vCommand = new SqlCommand();
            vCommand.CommandText = prQuery;
            vCommand.Connection = vConnection;

            SqlDataReader vReader = vCommand.ExecuteReader();

            return vReader;
        }
 
        //Returns a data table that can be used in datagridview component. 
        public DataTable DataAdapter(String prQuery = "")
        {
            DataTable vDataTable = new DataTable();

            SqlConnection vConnection = new SqlConnection();
            vConnection.ConnectionString = this.vConnectionString;
            try
            {
                vConnection.Open();
                SqlDataAdapter vAdapter = new SqlDataAdapter(prQuery, vConnection);

                vAdapter.Fill(vDataTable);

                vConnection.Dispose();
                vAdapter.Dispose();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return vDataTable;
        }
        //Execute a nonquery used to insert, update and delete.
        public bool ExecuteNonQuery(String prQuery = "")
        {
            try
            {
                SqlConnection vConnection = new SqlConnection();
                vConnection.ConnectionString = this.vConnectionString;
                vConnection.Open();

                SqlCommand vCommand = new SqlCommand();
                vCommand.CommandText = prQuery;
                vCommand.Connection = vConnection;
                vCommand.ExecuteNonQuery();

                vConnection.Dispose();
                vCommand.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
    }
}
