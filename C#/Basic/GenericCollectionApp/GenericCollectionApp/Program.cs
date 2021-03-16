using System;
using System.Collections.Generic;
using GenericCollectionApp.Model;

namespace GenericCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listOfProducts = new List<Product>();
            listOfProducts.Add(new Product(101, "Mouse", 200, 6));
            listOfProducts.Add(new Product(102, "Key-Board", 250.3, 5));
            listOfProducts.Add(new Product(103, "Hard-Drive", 850, 2));
            listOfProducts.Add(new Product(104, "SSD",3000, 4));
            listOfProducts.Add(new Product(105, "Headphone", 750, 2));
                Console.WriteLine("------------- Product Info ---------------\n");
            foreach (var item in listOfProducts)
            {
                Console.WriteLine("Product ID       :   " + item.ID);
                Console.WriteLine("Product Name     :   " + item.Name);
                Console.WriteLine("Product Price    :   " + item.UnitPrice);
                Console.WriteLine("Product Quantity :   " + item.Quantity);
                Console.WriteLine("GrandTotal       :   " + item.GetGrandTotal());
                Console.WriteLine();
            }

        }
    }
}
