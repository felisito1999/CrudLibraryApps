using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjectData
{
    static class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["NationalBasketballAssociationDB"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
