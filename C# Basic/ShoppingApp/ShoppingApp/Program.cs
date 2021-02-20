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
            int count = 0;
            string path = @"D:\shopping.txt";
            List<LineItem> lineItems = new List<LineItem>();
            Customer customer = new Customer(Guid.NewGuid(), "Sumit", "Navsari");
            if (File.Exists(path))
            {
                customer.GetOrders = DeserializeListOfContacts(path);
            }
            List<Product> products = new List<Product>();
            products.Add(new Product(Guid.NewGuid(), "Mouse", 250, 10.0f));
            products.Add(new Product(Guid.NewGuid(), "KeyBoard", 500, 8.0f));
            products.Add(new Product(Guid.NewGuid(), "Laptop", 34000, 20.0f));
            products.Add(new Product(Guid.NewGuid(), "Printer", 25000, 15.0f));
            products.Add(new Product(Guid.NewGuid(), "Scanner", 17000, 12.0f));

            // Display products
            Console.WriteLine("============= List of product =========");
            foreach (var item in products)
            {
                Console.WriteLine("Product ID   :   " + item.PID);
                Console.WriteLine("Product Name :   " + item.ProductName);
                Console.WriteLine("Price        :   " + item.Price);
                Console.WriteLine("Discount     :   " + item.DiscountPrice + "%\n");
            }

            String option = "y";
            while (option == "Y" || option == "y") {
                Console.WriteLine("1 - Buy an item\n2 - See the Order details\n3 - Change the order details\n4 - Delete the Order\n5 - See the summary\n");
                Console.Write("Enter your choice ==> ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch) {
                    case 1:
                        lineItems.Clear();
                        string y = "y";
                        while (y == "Y" || y == "y") {
                            Console.WriteLine("Choose Products");
                            Console.Write("Enter Product name ==> ");
                            string product = Console.ReadLine();
                            foreach (var item in products)
                            {
                                count = 0;
                                if (item.ProductName.Equals(product))
                                {
                                    count++;
                                    Console.Write("Enter quantity ==> ");
                                    int qty = Convert.ToInt32(Console.ReadLine());
                                    lineItems.Add(new LineItem(Guid.NewGuid(), qty, item));
                                    break;
                                }
                            }
                            if (count == 0) {
                                Console.WriteLine("Sorry you entered wrong product name");
                            }
                            Console.Write("Wants another products ? enter y : ");
                            y = Console.ReadLine();
                            if (y != "y" && y != "Y") {
                                if (lineItems.Count != 0)
                                {
                                    Order order = new Order(Guid.NewGuid(), DateTime.Now);
                                    foreach (var item in lineItems)
                                    {
                                        order.AddItem(item);
                                    }
                                    customer.AddOrder(order);
                                    SerializeListOfContacts(path, customer.GetOrders);
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        PrintOrderDetails(customer.GetOrders);
                        break;
                    case 3:
                        Console.Write("Enter order no to update quantity ==> ");
                        int update_no = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter product name which quantity to be update ==> ");
                        string p = Console.ReadLine();
                        foreach (var item in customer.GetOrders[--update_no].GetLineItems)
                        {
                            if (item.GetProduct.ProductName.Equals(p)) {
                                Console.Write("Enter quantity ==> ");
                                int qty = Convert.ToInt32(Console.ReadLine());
                                item.Quantity = qty;
                                Console.WriteLine("quantity has been updated...");
                            }
                        }
                        SerializeListOfContacts(path, customer.GetOrders);
                        break;
                    case 4:
                        Console.Write("Enter order no to be delete ==> ");
                        int delete_no = Convert.ToInt32(Console.ReadLine());
                        customer.GetOrders.RemoveAt(--delete_no);
                        Console.WriteLine("Order has been deleted...");
                        SerializeListOfContacts(path, customer.GetOrders);
                        break;
                    case 5:
                        PrintSummary(customer);
                        break;
                    default:
                        Console.WriteLine("You entered wrong choice..");
                        break;
                }
            }
        }

        private static void PrintOrderDetails(List<Order> orders) {
            if (orders.Count != 0)
            {
                for (int i = 0; i < orders.Count; i++)
                {
                    int no = i;
                    Order order = orders[i];
                    Console.WriteLine("Order no ==> " + ++no);
                    for (int j = 0; j < order.GetLineItems.Count; j++)
                    {
                        LineItem item = order.GetLineItems[j];
                        Console.WriteLine("Product Name          :  " + item.GetProduct.ProductName);
                        Console.WriteLine("Product Price         :  " + item.CalculateItemCost());
                    }
                    Console.WriteLine("Booking Time          :  " + order.GetDateTime);
                    Console.WriteLine("Total Price of orders :  " + order.CheckoutCost() + "\n");
                }
            }
            else {
                Console.WriteLine("There is no order. Please buy an item!\n");
            }
        }

        private static void PrintSummary(Customer customer)
        {
            Console.WriteLine("========== Summry of Customer and its's Order =========\n");
            Console.WriteLine("Customer ID      :   "+customer.CID);
            Console.WriteLine("Customer Name    :   "+customer.CustomerName);
            Console.WriteLine("Customer Address :   "+customer.Address+"\n");
            Console.WriteLine("============= List of Ordered Items =============\n");
            PrintOrderDetails(customer.GetOrders);
        }

        static void SerializeListOfContacts(string path, List<Order> listOfContacts)
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, listOfContacts);
            stream.Close();
        }
        static List<Order> DeserializeListOfContacts(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            List<Order> list = (List<Order>)formatter.Deserialize(fileStream);
            fileStream.Close();
            return list;
        }
    }
}
