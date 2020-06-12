using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanAn.BusinessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.BusinessLayers.Tests
{
    [TestClass()]
    public class BLBillInfoTests
    {
    //Function InsertBillInfo
        [TestMethod()]
        public void TestInsertBillInfoExceptionCase1()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            try
            {
                bl.InsertBillInfo(0, 2, 2, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestInsertBillInfoExceptionCase2()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            try
            {
                bl.InsertBillInfo(2, -1, 2, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestInsertBillInfoExceptionCase3()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            try
            {
                bl.InsertBillInfo(2, 2, -1, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }

        [TestMethod()]
        public void TestInsertBillInfo1()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.InsertBillInfo(1000, 5, 2, ref err);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void TestInsertBillInfo2()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.InsertBillInfo(10, 1000, 1, ref err);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void TestInsertBillInfo3()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.InsertBillInfo(5, 12, 3, ref err);
            Assert.AreEqual(true, result);
        }

    //Function GetCountByIDFood
        [TestMethod()]
        public void TestGetCountByIDFoodExceptionCase1()
        {
            BLBillInfo bl = new BLBillInfo();
            try
            {
                bl.GetCountByIDFood(-10, 10);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestGetCountByIDFoodExceptionCase2()
        {
            BLBillInfo bl = new BLBillInfo();
            try
            {
                bl.GetCountByIDFood(10, 0);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestGetCountByIDFood1()
        {
            BLBillInfo bl = new BLBillInfo();
            int result = bl.GetCountByIDFood(10, 10);
            Assert.AreEqual(0, result);
        }
        [TestMethod()]
        public void TestGetCountByIDFood2()
        {
            BLBillInfo bl = new BLBillInfo();
            int result = bl.GetCountByIDFood(46, 2);
            Assert.AreEqual(2, result);
        }
        // Function UpdateCount
        [TestMethod()]
        public void TestUpdateCountExceptionCase1()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            try
            {
                bl.UpdateCount(0, 2, 2, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestUpdateCountExceptionCase2()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            try
            {
                bl.UpdateCount(2, -1, 2, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestUpdateCountExceptionCase3()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            try
            {
                bl.UpdateCount(2, 2, -1, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestUpdateCount1()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.UpdateCount(2, 5, 3, ref err);
            Assert.AreEqual(true, result);
        }
        [TestMethod()]
        public void TestUpdateCount2()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.UpdateCount(3, 100, 5, ref err);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void TestUpdateCount3()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.UpdateCount(3, 46, 10, ref err);
            Assert.AreEqual(false, result);
        }
        [TestMethod()]
        public void TestChuyenBillInfoExceptionCase1()
        {
            BLBillInfo bl = new BLBillInfo();
            string err = "";
            bool result = bl.ChuyenBillInfo(-1, 2,ref err);
            try
            {
                bl.ChuyenBillInfo(-1, 2, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");

        }
    }
}