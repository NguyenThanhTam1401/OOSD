using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.Models
{
    public class Food
    {
        private int foodID;
        private string foodName;
        private int foodType;
        private double price;

        public int FoodID { get => foodID; set => foodID = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int FoodType { get => foodType; set => foodType = value; }
        public double Price { get => price; set => price = value; }

        public Food(int id, string name, int type, double gia)
        {
            this.foodID = id;
            this.foodName = name;
            this.foodType = type;
            this.price = gia;
        }
        public Food(DataRow row)
        {
            this.foodID = Convert.ToInt16(row["IDFOOD"]);
            this.foodName = row["FOODNAME"].ToString();
            this.foodType = Convert.ToInt32(row["IDTYPE"]);
            this.price = Convert.ToDouble(row["PRICE"]);

        }
    }
}
