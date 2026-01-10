using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    internal abstract class Repository
    {
        protected string connectionString;
        protected Repository()
        {
            connectionString = ConfigSetter.Load().ConnectionString;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
