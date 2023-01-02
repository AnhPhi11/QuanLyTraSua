using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _164_201_QLTraSua
{
    internal class Connection
    {
        public static string stringConnection = @"data source=DESKTOP-FRCK2IT\SQLEXPRESS;Initial Catalog=QLTraSua2;integrated Security=True ";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
