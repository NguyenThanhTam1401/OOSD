using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.DataLayers
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private string ConnectionString = @"Data Source=DESKTOP-IQRBTP3\SQLEXPRESS;Initial Catalog=QUANLYNHAHANG;Integrated Security=True";
        //đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable
        SqlDataAdapter da = null;
        //Đối tượng hiển thị dữ liệu lên Form
        DataSet ds = null;
        //Lệnh
        SqlCommand comm = null;
        private DataProvider()
        {
            conn = new SqlConnection(ConnectionString);
            comm = conn.CreateCommand();
        }

        public DataSet ExecuteQueryDS(string strsql, CommandType ct, object[] parameter = null)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            comm.CommandText = strsql;
            comm.CommandType = ct;
            if (parameter != null)
            {
                string[] listPara = strsql.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        comm.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            da = new SqlDataAdapter(comm);
            ds = new DataSet();
            da.Fill(ds);
            comm.Parameters.Clear();
            return ds;
        }

        public bool MyExecuteNonQuery(string strsql, CommandType ct, ref string error, object[] parameter = null)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandType = ct;
            comm.CommandText = strsql;

            if (parameter != null)
            {
                string[] listPara = strsql.Split(' ');
                int i = 0;
                foreach (string item in listPara)
                {
                    if (item.Contains('@'))
                    {
                        comm.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }

            int number = 0;
            try
            {
                number = comm.ExecuteNonQuery();
                if (number == 0)
                {
                    f = false;
                }
                else
                {
                    f = true;
                }
            }
            catch (SqlException e)
            {
                error = e.Message;
                f = false;
            }
            finally
            {
                comm.Parameters.Clear();
                conn.Close();
            }
            return f;
        }
    }
}
