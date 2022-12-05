using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyCafe.DAO
{
    internal class ConnectSQL
    {
        string sql = @"Data Source=DESKTOP-841FQQB;Initial Catalog=DHCoffee;Integrated Security=True;trusted_connection=true;encrypt=false";
        SqlConnection sqlConnection;
        public ConnectSQL()
        {
            sqlConnection = new SqlConnection(sql);
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
