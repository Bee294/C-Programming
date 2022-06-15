using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Assignment1
{
    public class ConnectionDb
    {
        public SqlConnection GetConnection()
        {
            string connectionString = "Data source = localhost; Initial Catalog =myjdbcapp;User = sa; password = sa";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
