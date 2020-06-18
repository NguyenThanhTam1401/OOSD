using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.Models
{
    public class Work
    {
        private int iD;
        private string name;
        private int salary;


        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        
        public Work(DataRow row)
        {
            this.ID = (int)row["IDWORK"];
            this.Name = row["NAME"].ToString();
            this.salary = (int)row["SALARY"];
        }

    }
}
