using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernetApp.Model;

namespace FluentNHibernetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession()) {

                using (var transaction = session.BeginTransaction())
                {
                    var customer1 = new Customer { FirstName = "Sumit", LastName = "Gupta" };
                    var customer2 = new Customer { FirstName = "Yogesh", LastName = "Patel" };

                    session.Save(customer1);
                    session.Save(customer2);

                    transaction.Commit();
                    Console.WriteLine("Table Added Successfully...");
                }
            }
        }
    }
}
