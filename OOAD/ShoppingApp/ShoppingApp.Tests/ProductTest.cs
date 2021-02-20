using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingApp.Model;

namespace ShoppingApp.Tests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void Test_TotalCost()
        {
            double expected = 90;
            float discountPrice = 10.0f;
            double ProductPrice = 100;

            Product p1 = new Product(Guid.NewGuid(), "Mouse", ProductPrice, discountPrice);

            Assert.AreEqual(expected, p1.TotalCost());

        }
    }
}
