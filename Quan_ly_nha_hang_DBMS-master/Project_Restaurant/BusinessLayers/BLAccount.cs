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
    public class BLAccount
    {
        public BLAccount()
        {
        }
        public Account GetAccount(string username, string pass)
        {
            string query = "EXEC GetAccount @UserName , @PassWord";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { username, pass });


            if (ds.Tables[0].Rows.Count == 0)
                return null;
            Account account = new Account(ds.Tables[0].Rows[0]);
            return account;

        }

        public bool ChangeInfo(string username, string oldpass, string newpass, int id,
            string name, string gioitinh, string cmnd, string diachi, string sdt, string ngaysinh, ref string err)
        {
            if (this.GetAccount(username, oldpass) == null)
            {
                err = "Mật khẩu cũ không chính xác!";
                return false;
            }
            string query = "EXEC UpdateInfo @username , @oldpass , @newpass , @id , @name , @gioitinh , @cmnd , @diachi , @sdt , @ngaysinh";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err,
                new object[] { username, oldpass, newpass, id, name, gioitinh, cmnd, diachi, sdt, ngaysinh });
        }


        public List<Account> GetListAccount()
        {
            List<Account> lstAccount = new List<Account>();
            string query = "EXEC GetListAccount";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                Account acc = new Account(item);
                lstAccount.Add(acc);
            }

            return lstAccount;
        }
        public bool AddAccount(string username, int id, int type, ref string err)
        {
            string query = "EXEC AddAccount @UserName , @id , @IsAdmin";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { username, id, type });
        }
        public bool ResetPass(string username, ref string err)
        {
            string query = "EXEC ResetPassword @UserName";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { username });
        }
        public bool DeleteAccount(string username, ref string err)
        {
            string q = "EXEC DeleteAccount @UserName";
            return DataProvider.Instance.MyExecuteNonQuery(q, CommandType.Text, ref err, new object[] { username });
        }
    }
}
