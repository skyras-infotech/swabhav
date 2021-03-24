using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerOrderOneToManyApp.Model;

namespace CustomerOrderOneToManyApp
{
    class Program
    {
        public static CustomerDbContext db = new CustomerDbContext();
        static void Main(string[] args)
        {
            //CreateAndLoadDataInCustomerAndOrder();
            GetNoOfCustomersOrder();
            GetTotalPriceOfEachCustomerOrder();
            DisplayCustomerOrderBy();
            //GetCustomerWhoseOrderIsMaximum();
        }

        /*private static void GetCustomerWhoseOrderIsMaximum()
        {
            Console.WriteLine("Get customer whose order is maximum");
            var maxOrderCust = db.Customers.GroupJoin(db.Orders,
                                                  c => c.ID,
                                                  o => o.Customer.ID,
                                                  (cust, order) => new { customerDetails = cust, orderDetails = order });
            foreach (var item in maxOrderCust)
            {
                Console.WriteLine(item.customerDetails.Name + " --- " + item.orderDetails.);
            }
            Console.WriteLine();
        }*/

        private static void DisplayCustomerOrderBy()
        {
            Console.WriteLine("Display Customer Order by Name\n");
            var asendingOrder = db.Customers.OrderBy(x => x.Name);
            foreach (var item in asendingOrder)
            {
                Console.WriteLine(item.Name +" --- "+item.MobileNo);
            }
            Console.WriteLine();
        }

        private static void GetTotalPriceOfEachCustomerOrder()
        {
            var totalPriceOrder = db.Customers.GroupJoin(db.Orders,
                                                   c => c.ID,
                                                   o => o.Customer.ID,
                                                   (cust, order) => new { customerDetails = cust, orderDetails = order });
            Console.WriteLine("Get Total price of orders of each customer no of Orders of each customer\n");
            foreach (var item in totalPriceOrder)
            {
                double totalPrice = 0;
                foreach (var price in item.orderDetails)
                {
                    totalPrice += price.Price;
                }
                Console.WriteLine(item.customerDetails.Name + " --- " + totalPrice);
            }
            Console.WriteLine();
        }

        private static void GetNoOfCustomersOrder()
        {
            var noOfOrder = db.Customers.GroupJoin(db.Orders,
                                                   c => c.ID,
                                                   o => o.Customer.ID,
                                                   (cust, order) => new { customerDetails = cust, orderDetails = order }).ToList();
            Console.WriteLine("Get no of Orders of each customer\n");
            foreach (var item in noOfOrder)
            {
                Console.WriteLine(item.customerDetails.Name + " --- " + item.orderDetails.Count());
            }
            Console.WriteLine();
        }

        private static void CreateAndLoadDataInCustomerAndOrder()
        {
            var c1 = new Customer { ID = 101, Name = "Sumit", MobileNo = 9664695915 };
            var c2 = new Customer { ID = 102, Name = "Yogesh", MobileNo = 9517532586 };
            var c3 = new Customer { ID = 103, Name = "Ajay", MobileNo = 9874563215 };

            var o1 = new Order { OID = 201, OrderName = "Mouse", Price = 1000 };
            var o2 = new Order { OID = 202, OrderName = "Key-Board", Price = 2500 };
            var o3 = new Order { OID = 203, OrderName = "Laptop", Price = 20000 };
            var o4 = new Order { OID = 204, OrderName = "RAM", Price = 1500 };

            c1.Orders.Add(o1);
            c1.Orders.Add(o4);
            c2.Orders.Add(o2);
            c2.Orders.Add(o3);
            c3.Orders.Add(o3);
            c3.Orders.Add(o1);
            c3.Orders.Add(o2);

            db.Customers.Add(c1);
            db.Customers.Add(c2);
            db.Customers.Add(c3);

            db.SaveChanges();
        }
    }
}
