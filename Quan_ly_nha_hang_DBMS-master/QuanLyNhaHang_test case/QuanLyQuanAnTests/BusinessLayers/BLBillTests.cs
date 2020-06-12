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
    public class BLBillTests
    {
        [TestMethod()]
        public void InSertBillExceptionTest1()
        {
            BLBill bl = new BLBill();
            string err = "";
           
            try
            {
                bl.InSertBill(-1, "admin", ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }

        [TestMethod()]
        public void InSertBillExceptionTest2()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.InSertBill(5, "", ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestInSertBill1()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.InSertBill(10, "abc", ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TestInSertBill2()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.InSertBill(1234, "Admin", ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TestInSertBill3()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.InSertBill(10, "Admin", ref err);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void PayExceptionTest1()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.Pay(-1, 10, 12, 12, 120, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void PayExceptionTest2()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.Pay(10, 10, 12, 12, -1, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void PayExceptionTest3()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.Pay(10, 10, -1, 12, 120, ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestPay1()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.Pay(3210, 12, 1, 15, 120000, ref err);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TestPay2()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.Pay(1234, 10, -1, 0, 120000, ref err);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void TestPay3()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.Pay(10, 10, 1, 15, 120000, ref err);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ChuyenBanExceptionTest1()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.ChuyenBan(10, 11, "", ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void ChuyenBanExceptionTest2()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.ChuyenBan(0, 11, "admin", ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void ChuyenBanExceptionTest3()
        {
            BLBill bl = new BLBill();
            string err = "";

            try
            {
                bl.ChuyenBan(10, 0, "admin", ref err);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Tham số truyền vào không hợp lệ!");
                return;
            }
            Assert.Fail("không có lỗi được ném ra");
        }
        [TestMethod()]
        public void TestChuyenBan1()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.ChuyenBan(10, 100, "admin", ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TestChuyenBan2()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.ChuyenBan(100, 10, "admin", ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TestChuyenBan3()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.ChuyenBan(12, 10, "admin", ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void TestChuyenBan4()
        {
            BLBill bl = new BLBill();
            string err = "";
            bool result = bl.ChuyenBan(10, 12, "admin", ref err);
            Assert.IsTrue(result);
        }
    }
}