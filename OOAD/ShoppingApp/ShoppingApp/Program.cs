using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ShoppingApp.Model;

namespace ShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer(Guid.NewGuid(), "Sumit", "Navsari");

            Product Mouse = new Product(Guid.NewGuid(), "Mouse", 250, 10.0f);
            Product Laptop = new Product(Guid.NewGuid(), "Laptop", 34000, 20.0f);
            Product Keyboard = new Product(Guid.NewGuid(), "KeyBoard", 500, 8.0f);


            Order order1 = new Order(Guid.NewGuid(), new DateTime(2021, 01, 15));
            order1.AddItem(new LineItem(Guid.NewGuid(), 5, Mouse));
            order1.AddItem(new LineItem(Guid.NewGuid(), 3, Laptop));
            order1.AddItem(new LineItem(Guid.NewGuid(), 7, Keyboard));
            order1.AddItem(new LineItem(Guid.NewGuid(), 6, Keyboard));

            Order order2 = new Order(Guid.NewGuid(), new DateTime(2020, 12, 03));
            order2.AddItem(new LineItem(Guid.NewGuid(), 3, Keyboard));
            order2.AddItem(new LineItem(Guid.NewGuid(), 1, Mouse));

            customer.AddOrder(order1);
            customer.AddOrder(order2);

            PrintInfo(customer); 

        }

        private static void PrintInfo(Customer customer)
        {
            Console.WriteLine("Customer Details : "+customer.CID+", "+customer.CustomerName+", "+customer.Address);
            customer.GetOrders.ForEach(Console.WriteLine);
        }
    }
}
