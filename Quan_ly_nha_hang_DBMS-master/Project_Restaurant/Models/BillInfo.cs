using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.Models
{
    public class BillInfo
    {
        private int iD;
        private int iDBill;
        private int iDFood;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }
        public int Count { get => count; set => count = value; }

        public BillInfo(int id, int idbill, int idfood, int count)
        {
            this.iD = id;
            this.iDBill = idbill;
            this.iDFood = idfood;
            this.count = count;
        }

        public BillInfo(DataRow row)
        {
            this.iD = Convert.ToInt32(row["IDBILLINFO"]);
            this.iDBill = Convert.ToInt32(row["IDBILL"]);
            this.iDFood = Convert.ToInt32(row["IDFOOD"]);
            this.count = Convert.ToInt32(row["COUNT"]);

        }
    }
}
