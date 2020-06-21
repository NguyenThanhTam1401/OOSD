﻿using Project_Restaurant.DataLayers;
using Project_Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Restaurant.BusinessLayers
{
    public class BLSupplier
    {
        public BLSupplier()
        {
        }

        public List<Supplier> GetListSupplier()
        {
            List<Supplier> lst = new List<Supplier>();
            string query = "EXEC GetListSupplier";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                Supplier acc = new Supplier(item);
                lst.Add(acc);
            }

            return lst;
        }

        public bool UpdateSupplier(int idsup, string name, string sdt, string address, ref string err)
        {
            string query = "EXEC UpdateSupplier @idsup , @name , @sdt , @address";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { idsup, name, sdt, address });
        }

        public bool AddSupplier(string name, string sdt, string address, ref string err)
        {
            string query = "EXEC AddSupplier @name , @sdt , @address";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, sdt, address });
        }

        public bool DeleteSupplier(int id, ref string err)
        {
            string query = "EXEC DeleteSupplier @id";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id });
        }
    }
}