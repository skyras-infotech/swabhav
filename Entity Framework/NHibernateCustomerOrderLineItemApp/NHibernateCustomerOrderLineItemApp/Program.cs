using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateCustomerOrderLineItemApp.Model;
using NHibernate;

namespace NHibernateCustomerOrderLineItemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    //CreateTableAndInsertData(session);
                    Query1(session);
                    transaction.Commit();
                }
            }
        }

        private static void Query1(ISession session)
        {
            Console.WriteLine("Display Customer's Orders with quantity of each order\n");
            var usrsOrderItem = session.Query<Customer>().Join(session.Query<Order>(),
                                c => c.ID, o => o.Customer.ID, (cust, order) => new {
                                    Customers = cust,
                                    Orders = order,
                                }).Join(session.Query<LineItem>(), o => o.Orders.ID,l => l.Order.ID,(ordr,item) => new { 
                                    Orders = ordr,
                                    Items = item
                                }).GroupBy(x => x.Orders.Customers.Name);
            foreach (var item in usrsOrderItem)
            {
                Console.WriteLine(item.Key);
                foreach (var i1 in item)
                {
                    Console.WriteLine("Order ID : "+i1.Orders.Orders.ID +" -- Quantity : "+i1.Items.Quantity);
                }
            }
            Console.WriteLine();
        }

        private static void CreateTableAndInsertData(ISession session)
        {
            var c1 = new Customer { Name = "Sumit", MobileNo = 9664695915 };
            var c2 = new Customer { Name = "Yogesh", MobileNo = 9874563215 };
            var c3 = new Customer { Name = "Ajay", MobileNo = 9852174563 };

            var o1 = new Order { Date = DateTime.Today, Customer = c1 };
            var o2 = new Order { Date = DateTime.Today, Customer = c1 };
            var o3 = new Order { Date = DateTime.Today, Customer = c2 };
            var o4 = new Order { Date = DateTime.Today, Customer = c3 };
            var o5 = new Order { Date = DateTime.Today, Customer = c2 };
            var o6 = new Order { Date = DateTime.Today, Customer = c2 };

            var l1 = new LineItem { Quantity = 5, Order = o1 };
            var l2 = new LineItem { Quantity = 2, Order = o2 };
            var l3 = new LineItem { Quantity = 3, Order = o3 };
            var l4 = new LineItem { Quantity = 4, Order = o4 };
            var l5 = new LineItem { Quantity = 2, Order = o5 };
            var l6 = new LineItem { Quantity = 8, Order = o6 };
            var l7 = new LineItem { Quantity = 4, Order = o2 };
            var l8 = new LineItem { Quantity = 6, Order = o4 };
            var l9 = new LineItem { Quantity = 4, Order = o6 };

            o1.LineItems.Add(l1);
            o2.LineItems.Add(l2);
            o3.LineItems.Add(l3);
            o4.LineItems.Add(l4);
            o5.LineItems.Add(l5);
            o6.LineItems.Add(l6);
            o2.LineItems.Add(l7);
            o4.LineItems.Add(l8);
            o6.LineItems.Add(l9);

            c1.Orders.Add(o1);
            c1.Orders.Add(o2);
            c2.Orders.Add(o3);
            c3.Orders.Add(o4);
            c2.Orders.Add(o5);
            c2.Orders.Add(o6);

            session.Save(c1);
            session.Save(c2);
            session.Save(c3);
        }
    }
}
