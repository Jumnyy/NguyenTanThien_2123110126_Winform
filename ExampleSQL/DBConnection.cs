using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQL
{
    public class DBConnection
    {
        public SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost,1433;Initial Catalog=sale;User Id=sa;Password=sa;TrustServerCertificate=true";
            return conn;
        }
    }
}
