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
    public class BLFoodTests
    {
        [TestMethod()]
        public void AddFood1()
        {
            BLFood bLFood = new BLFood();
            string err = null;
            var result = bLFood.AddFood("Strongbow", 16, 20000, ref err);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void AddFood2()
        {
            BLFood bLFood = new BLFood();
            string err = null;
            var result = bLFood.AddFood("Strongbow", 17, 20000, ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void UpdateFood1()
        {
            BLFood bLFood = new BLFood();
            string err = null;
            var result = bLFood.UpdateFood(36, "Chân gà hầm xả ớt", 8, 10000, ref err);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void UpdateFood2()
        {
            BLFood bLFood = new BLFood();
            string err = null;
            var result = bLFood.UpdateFood(1263, "Chân gà hầm xả ớt", 8, 10000, ref err);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void DeleteFood1()
        {
            BLFood bLFood = new BLFood();
            string err = null;
            var result = bLFood.DeleteFood(3, ref err);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void DeleteFood2()
        {
            BLFood bLFood = new BLFood();
            string err = null;
            var result = bLFood.DeleteFood(156849, ref err);
            Assert.IsFalse(result);
        }

    }
}