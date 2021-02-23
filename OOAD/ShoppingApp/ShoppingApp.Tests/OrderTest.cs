using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingApp.Model;

namespace ShoppingApp.Tests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void Test_CheckoutCost()
        {
            double expected = 4450;
            Product Mouse = new Product(Guid.NewGuid(), "Mouse", 250, 10.0f);
            Product Keyboard = new Product(Guid.NewGuid(), "KeyBoard", 500, 5.0f);

            Order order1 = new Order(Guid.NewGuid(), new DateTime(2021, 01, 15));
            order1.AddItem(new LineItem(Guid.NewGuid(), 5, Mouse));
            order1.AddItem(new LineItem(Guid.NewGuid(), 7, Keyboard));

            Assert.AreEqual(expected, order1.CheckoutCost());

        }

        [TestMethod]
        public void Test_AddItem()
        {
            double expected = 12;
            Product Mouse = new Product(Guid.NewGuid(), "Mouse", 250, 10.0f);
            Product Keyboard = new Product(Guid.NewGuid(), "KeyBoard", 500, 5.0f);

            Order order1 = new Order(Guid.NewGuid(), new DateTime(2021, 01, 15));
            order1.AddItem(new LineItem(Guid.NewGuid(), 5, Mouse));
            order1.AddItem(new LineItem(Guid.NewGuid(), 7, Keyboard));
            order1.AddItem(new LineItem(Guid.NewGuid(), 5, Keyboard));

            double actual = 0.0;
            foreach (var item in order1.GetLineItems)
            {
                if (item.GetProduct.ProductName.Equals("KeyBoard")) {
                    actual = item.Quantity;
                }
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_AddItemForUniquesness()
        {
            Product Mouse = new Product(Guid.NewGuid(), "Mouse", 250, 10.0f);
            Product Keyboard = new Product(Guid.NewGuid(), "KeyBoard", 500, 5.0f);

            Order order1 = new Order(Guid.NewGuid(), new DateTime(2021, 01, 15));
            order1.AddItem(new LineItem(Guid.NewGuid(), 5, Mouse));
            order1.AddItem(new LineItem(Guid.NewGuid(), 7, Keyboard));
            order1.AddItem(new LineItem(Guid.NewGuid(), 5, Keyboard));

            CollectionAssert.AllItemsAreUnique(order1.GetLineItems);
        }
    }
}
