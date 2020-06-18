using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.Models
{
    public class Area
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public Area(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }

        public Area(DataRow row)
        {
            this.iD = Convert.ToInt32(row["IDAREA"]);
            this.name = row["NAME"].ToString();
        }
    }
}
