using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace _164_201_QLTraSua
{
    internal class QLTraSua
    {
        SqlConnection s = new SqlConnection();
        void ketnoi()
        {
            s.ConnectionString = @"data source=DESKTOP-FRCK2IT\SQLEXPRESS;Initial Catalog=QLTraSua2;integrated Security=True ";

            if (s.State==ConnectionState.Closed)
                s.Open();
        }
        public QLTraSua()
        {
            ketnoi();

        }

        public int Capnhatdulieu(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = s;
            return cmd.ExecuteNonQuery();
        }

        void dongketnoi()
        {
            s.Close();
        }
        public DataSet Laydulieu(string sql)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, s);
            da.Fill(ds);
            return ds;
        }

    }
}
