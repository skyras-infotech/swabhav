using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyInNHibernateApp.Model;

namespace OneToManyInNHibernateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession()) 
            {
                using (var transaction = session.BeginTransaction()) 
                {
                    var e1 = new Employee { EmpName = "Sumit", Job = "Manager", Salary = 15000 };
                    var e2 = new Employee { EmpName = "Yogesh", Job = "Clerk", Salary = 20000 };
                    var e3 = new Employee { EmpName = "Ramesh", Job = "Developer", Salary = 21000 };

                    var a1 = new Address { City = "Navsari", Employees = e1 };
                    var a2 = new Address { City = "Surat", Employees = e2 };
                    var a3 = new Address { City = "Ahemdabad", Employees = e3 };
                    var a4 = new Address { City = "Mumbai", Employees = e1 };
                    var a5 = new Address { City = "Valsad", Employees = e1 };

                    e1.Addresses.Add(a1);
                    e1.Addresses.Add(a5);
                    e2.Addresses.Add(a2);
                    e2.Addresses.Add(a4);
                    e3.Addresses.Add(a3);

                    session.Save(e1);
                    session.Save(e2);
                    session.Save(e3);

                    transaction.Commit();
                    Console.WriteLine("Sucesss");

                }
            }
        }
    }
}
