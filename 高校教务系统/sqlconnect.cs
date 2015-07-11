using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using 高校教务系统.Properties;



namespace 高校教务系统
{
    public class sqlconnect
    {
        public SqlConnection con = null;
        private static string AppConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        public bool Login(string uid, string pwd)
        {
            var connectionStr = AppConnectionString + "User ID=" + uid + ";Password=" + pwd;
            con = new SqlConnection(connectionStr);
            bool sucess = false;

            try
            {
                con.Open();
                sucess = true;
                AppConnectionString = connectionStr;
            }

            catch
            {
                sucess = false;
            }
            finally
            {

            }

            return sucess;
        }



        public DataSet Getds(string sql)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public int OperateData(string sql)
        {
            using (SqlConnection con = new SqlConnection(AppConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    int x = cmd.ExecuteNonQuery();
                    return x;
                }
            }
        }
        public DataTable BindDataGrid(string sql)
        {
            using (SqlConnection con = new SqlConnection(AppConnectionString))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    DataTable table1 = new DataTable();
                    da.Fill(ds);
                    return ds.Tables[0];
                }
            }
        }
    }
}
