using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Database
{
    public class DatabaseLogicLayer
    {
        SqlConnection connection;
        
        public DatabaseLogicLayer()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        public void ConnectionWizard()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
            connection.Open();
        }

        public SqlDataReader GetDataList(SqlCommand command)
        {
            command.Connection = connection;
            ConnectionWizard();
            return command.ExecuteReader();
        }


    }
}
