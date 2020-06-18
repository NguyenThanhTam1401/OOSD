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
    public class BLFood
    {
        public BLFood()
        {
        }
        public List<OrderedViewModel> GetListOrdered(int idtable)
        {
            List<OrderedViewModel> listMenu = new List<OrderedViewModel>();
            string query = "EXEC GetListOrder @idtable";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { idtable });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                OrderedViewModel menu = new OrderedViewModel(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<Food> GetListFood(int IDType)
        {
            List<Food> lsfood = new List<Food>();
            string query = "EXEC GetFoodsByIDType @idtype";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { IDType });
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                Food type = new Food(item);
                lsfood.Add(type);
            }
            return lsfood;
        }

        public bool AddFood(string foodname, int idtype, double gia, ref string err)
        {
            err = "";
            string query = "EXEC AddFood @FoodName , @Price , @IdType";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { foodname, gia, idtype });
        }
        public bool UpdateFood(int idfood, string foodname, int idtype, double gia, ref string err)
        {
            err = "";
            string query = "EXEC UpdateFood @IdFood , @NewName , @NewIdType , @NewPrice";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idfood, foodname, idtype, gia });
        }
        public bool DeleteFood(int idfood, ref string err)
        {
            err = "";
            string query = "EXEC DeleteFood @id";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idfood });
        }
        public DataTable GetListFood()
        {
            string query = "EXEC GetListFood";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text);
            return ds.Tables[0];
        }
        public List<Food> SearchFood(string name)
        {
            string searchname = "N'%" + name + "%'";
            string query = "EXEC SearchFood @name";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { name });
            DataTable dt = ds.Tables[0];
            List<Food> lst = new List<Food>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Add(new Food(dt.Rows[i]));
            }
            return lst;
        }

    }
}
