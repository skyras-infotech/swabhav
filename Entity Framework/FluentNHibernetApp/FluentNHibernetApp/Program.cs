using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernetApp.Model;
using NHibernate;

namespace FluentNHibernetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession()) 
            {

                using (var transaction = session.BeginTransaction())
                {
                    CreateTableAndInsertRecord(session);
                    //AddCustomer(session);
                    //UpdateCustomer(session);
                    //DeleteCustomer(session);

                    transaction.Commit();
                }
            }
        }

        private static void DeleteCustomer(ISession session)
        {
            var customers = session.CreateCriteria<Customer>().List<Customer>();
            
            foreach (var item in customers)
            {
                if (item.FirstName == "Karan")
                {
                    var customer = session.Get<Customer>(item.ID);
                    session.Delete(customer);
                    session.Flush();
                    Console.WriteLine("Data Deleted Sucessfully..");
                }
            }
        }

        private static void UpdateCustomer(ISession session)
        {
            var customers = session.CreateCriteria<Customer>().List<Customer>();
                foreach (var item in customers)
                {
                    if (item.FirstName == "Ravi")
                    {
                        item.FirstName = "Ravi Kumar";
                        Console.WriteLine("Data Updated Sucessfully..");
                        session.Save(item);
                    }
                }
        }

        private static void AddCustomer(ISession session)
        {
            var customer = new Customer { FirstName = "Mika", LastName = "Singh" };
            session.Save(customer);
        }

        private static void CreateTableAndInsertRecord(ISession session)
        {
            var customer1 = new Customer { FirstName = "Sumit", LastName = "Gupta" };
            var customer2 = new Customer { FirstName = "Yogesh", LastName = "Patel" };
            var customer3 = new Customer { FirstName = "Raju", LastName = "Rathod" };
            var customer4 = new Customer { FirstName = "Ajay", LastName = "Patil" };
            var customer5 = new Customer { FirstName = "Karan", LastName = "Patel" };

            session.Save(customer1);
            session.Save(customer2);
            session.Save(customer3);
            session.Save(customer4);
            session.Save(customer5);
        }
    }
}
