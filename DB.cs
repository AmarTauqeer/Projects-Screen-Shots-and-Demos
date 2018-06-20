using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Gentry
{
    public class DB
    {
        public static SqlConnection GetConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            return con;
        }
        public static void Dispose(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            con.Dispose();
        }
    }
}
