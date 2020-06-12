using QuanLyQuanAn.DataLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BusinessLayers
{
    public class BLBill
    {
        public BLBill()
        {
        }

        public int GetUnCheckBillID(int idtable)
        {
            DataSet ds = DataProvider.Instance.ExecuteQueryDS("EXEC GetUnpaidBillID @idtable", CommandType.Text, new object[] { idtable });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                //cBill bill = new cBill(row);
                return Convert.ToInt32(row["IDBILL"]);
            }
            return -1;
        }
        public bool InSertBill(int IDtable, string username, ref string err)
        {
            if (IDtable <= 0 || username.Trim() == "")
            {
                throw new ArgumentOutOfRangeException("Tham số truyền vào không hợp lệ!");
            }
            err = "";
            string query = "EXEC InSertBill @idtable ,  @username";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { IDtable, username });
        }
        public int GetMaxIDBill()
        {
            int max = -1;
            string query = "EXEC GetMaxIDBill";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            max = Convert.ToInt32(dt.Rows[0]["idbill"]);
            return max;
        }

        public DataTable ThongKe(DateTime Dfrom, DateTime Dto, string colname, bool isA)
        {
            string query = "EXEC ThongKe @datefrom , @dateto , @colname , @isA";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { Dfrom, Dto, colname, isA });
            return ds.Tables[0];
        }
        public bool Pay(int idbill, int idtable, int idvoucher, int giamgia, double tongtien, ref string err)
        {
            if (idbill <= 0 || idtable <= 0 || idvoucher < -1 || giamgia < 0 || tongtien < 0)
            {
                throw new ArgumentOutOfRangeException("Tham số truyền vào không hợp lệ!");
            }
            err = "";
            string query = "EXEC Pay @idbill , @idtable , @idvouher , @giamgia , @tongtien";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idbill, idtable, idvoucher, giamgia, tongtien });
        }

        public bool ChuyenBan(int idtable1, int idtable2, string user, ref string err)
        {
            if (idtable1 <= 0 || idtable2 <= 0 || user.Trim() == "")
            {
                throw new ArgumentOutOfRangeException("Tham số truyền vào không hợp lệ!");
            }
            err = "";
            string query = "EXEC GopBan @idtable1 , @idtable2 , @user";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtable1, idtable2, user });

        }
        public DataTable BillDetails(int idbill)
        {
            string query = "EXEC BillDetails @idbill";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { idbill });
            return ds.Tables[0];
        }
    }
}
