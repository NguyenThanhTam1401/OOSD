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
    public class BLWork
    {
        public BLWork()
        {
        }
        public bool AddWork(string name, int luong, ref string err)
        {
            err = "";
            string query = "EXEC AddWork @name , @luong";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { name, luong });
        }
        public bool DeleteWork(int id, ref string err)
        {
            err = "";
            string query = "EXEC DeleteWork @id";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id });
        }
        public bool UpdateWork(int id, string name, int luong, ref string err)
        {
            err = "";
            string query = "EXEC UpdateWork @id , @name , @luong";
            return DataProvider.Instance.MyExecuteNonQuery(query, CommandType.Text, ref err, new object[] { id, name, luong });

        }
        public List<Work> GetListWork()
        {
            List<Work> lstwork = new List<Work>();
            string query = "EXEC GetListWork";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text);
            DataTable dt = ds.Tables[0];
            foreach (DataRow item in dt.Rows)
            {
                Work work = new Work(item);
                lstwork.Add(work);
            }
            return lstwork;
        }
        public DataTable GetListEmployeeByIdWork(int idwork)
        {
            string query = "EXEC GetListEmployeeByIdWork @idwork";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { idwork });
            DataTable dt = ds.Tables[0];
            return dt;
        }
        public DataTable GetListEmployeeByShift(int calam)
        {
            string query = "EXEC GetListEmployeeByShift @calam";
            DataSet ds = DataProvider.Instance.ExecuteQueryDS(query, CommandType.Text, new object[] { calam });
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
