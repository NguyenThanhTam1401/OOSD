using Project_Restaurant.DataLayers;
using Project_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.BusinessLayers
{

    public class BLFoodTable
    {
        public BLFoodTable()
        {
        }

        public List<Table> LayDanhSachbBanAn()
        {
            List<Table> tbl = new List<Table>();
            DataSet ds = DataProvider.Instance.ExecuteQueryDS("EXEC GetListTable", CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                Table tb = new Table(item);

                tbl.Add(tb);
            }
            return tbl;
        }

        public DataTable GetTableInfo()
        {
            DataSet ds = DataProvider.Instance.ExecuteQueryDS("EXEC GetTableInfo", CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return dt;
        }

        public bool CheckOutTable(int idtable, ref string err)
        {
            string query = "EXEC CheckOutTable @id";
            err = "";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable });
        }
        public bool ClearTable(int idtable, ref string err)
        {
            string query = "EXEC ClearTable @id";
            err = "";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable });
        }
        public bool AddTable(string name, int idarea, ref string err)
        {
            err = "";
            string query = "EXEC AddTable @name , @id";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, idarea });
        }
        public bool DeleteTable(int idtalbe, ref string err)
        {
            err = "";
            string query = "EXEC DeleteTable @id";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtalbe });
        }
        public bool UpdateTable(int idtable, string newname, int newidarea, ref string err)
        {
            err = "";
            string query = "EXEC UpdateTable @id , @name , @idarea";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable, newname, newidarea });
        }
    }
}
