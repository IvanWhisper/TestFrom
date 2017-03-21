using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DBTools
{
    public class DBLINK
    {
        public DataTable ReturnDT(string con,string sqlstr)
        {
            SqlConnection cn = new SqlConnection(con);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataAdapter ap = new SqlDataAdapter(sqlstr, cn);
            ap.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable ReDT(string con, string sqlstr)
        {
            SqlConnection cn = new SqlConnection(con);
            DataTable dt = new DataTable();
            cn.Open();
            SqlCommand ap = new SqlCommand(sqlstr, cn);
            ap.ExecuteNonQuery();
            cn.Close();
            return dt;
        }
    }
}
