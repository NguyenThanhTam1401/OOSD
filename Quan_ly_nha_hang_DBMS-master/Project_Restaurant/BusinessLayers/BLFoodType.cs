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
    public class BLFoodType
    {
        public BLFoodType()
        {
        }

        public List<FoodType> GetListTypeFood()
        {
            List<FoodType> lstype = new List<FoodType>();
            string query = "EXEC GetListFoodType";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                FoodType type = new FoodType(item);
                lstype.Add(type);
            }
            return lstype;
        }
        public bool AddFoodType(string typename, int idsup, ref string err)
        {
            err = "";
            string query = "EXEC AddFoodType @NewName , @idsup";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { typename, idsup });
        }
        public bool UpdateFoodType(int idtype, string typename, int idsup, ref string err)
        {
            err = "";
            string query = "EXEC UpdateFoodType @IdType , @NewName , @idsup";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtype, typename, idsup });
        }
        public bool DeleteFoodType(int idtype, ref string err)
        {
            err = "";
            string query = "EXEC DeleteFoodType @IdType";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idtype });
        }

    }
}
