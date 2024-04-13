using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace WSUniversalLibTests
{
    [TestClass]
    public class CalculationTests
    {
        private readonly Calculation _calculation;

        public CalculationTests() 
        {
            _calculation = new Calculation();
        }


        [TestMethod]
        public void GetQuantityForProduct_ValidParameters()
        {
            Assert.AreEqual(114148, _calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidProductType() 
        {
            Assert.AreEqual(-1, _calculation.GetQuantityForProduct(0, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidMaterialType()
        {
            Assert.AreEqual(-1, _calculation.GetQuantityForProduct(1, 0, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidCount() 
        {
            Assert.AreEqual(-1, _calculation.GetQuantityForProduct(3, 1, -1, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidWidth()
        {
            Assert.AreEqual(-1, _calculation.GetQuantityForProduct(3, 1, 15, -1, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidLength()
        {
            Assert.AreEqual(-1, _calculation.GetQuantityForProduct(3, 1, 15, 20, -1));
        }

        [TestMethod]
        public void GetQuantityForProduct_ValidZeroCount()
        {
            Assert.AreEqual(0, _calculation.GetQuantityForProduct(3, 1, 0, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_ValidZeroWidth()
        {
            Assert.AreEqual(0, _calculation.GetQuantityForProduct(3, 1, 15, 0, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_ValidZeroLength()
        {
            Assert.AreEqual(0, _calculation.GetQuantityForProduct(3, 1, 15, 20, 0));
        }
    }
}
