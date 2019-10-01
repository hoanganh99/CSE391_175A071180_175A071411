using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DAL_CONN
    {
        SqlConnection Connect = new SqlConnection(@"Data Source=DESKTOP-NQ8EUJV;Initial Catalog=QUANLYCUAHANG;Integrated Security=True");
        public DAL_CONN()
        {
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
            }
        }
        public DataTable Load_Data(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable Load_DataNotProcedure(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable Load_DataWithParameter(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable Load_DataWithParameterNotprocedure(string sql, string[] name, object[] values, int parameter)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            for (int i = 0; i < parameter; i++)
            {
                cmd.Parameters.AddWithValue(name[i], values[i]);

            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public int Execute(string sql, string[] name, object[] values, int parameter)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameter; i++)
                {
                    cmd.Parameters.AddWithValue(name[i], values[i]);
                }
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }
        public int ReturnInteger(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            int ValuesInteger = int.Parse(cmd.ExecuteScalar().ToString());
            return ValuesInteger;
        }
        public int ReturnIntegerWithProcedure(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            cmd.CommandType = CommandType.StoredProcedure;
            int ValuesInteger = int.Parse(cmd.ExecuteScalar().ToString());
            return ValuesInteger;
        }
        public string ReturnString(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Connect);
            string ValuesString = cmd.ExecuteScalar().ToString();
            return ValuesString;
        }
    }
}
