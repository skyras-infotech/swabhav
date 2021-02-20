using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingApp.Model;

namespace ShoppingApp.Tests
{
    [TestClass]
    public class LineItemTest
    {
        [TestMethod]
        public void Test_CalculateItemCost()
        {
            double expected = 450;
            float discountPrice = 10.0f;
            double ProductPrice = 100;

            Product p1 = new Product(Guid.NewGuid(), "Mouse", ProductPrice, discountPrice);
            LineItem l1 = new LineItem(Guid.NewGuid(), 5, p1);

            Assert.AreEqual(expected, l1.CalculateItemCost());

        }
    }
}
