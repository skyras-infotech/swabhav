using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
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
                    //CreateEmployeeAndAddress(session);
                    //Query1(session);
                    //Query2(session);
                    //Query3(session);
                    Query4(session);
                    transaction.Commit();
                }
            }
        }

        private static void Query4(ISession session)
        {
            Console.WriteLine("Fetch all employee with their address\n");
            var employees = session.Query<Employee>().GroupJoin(session.Query<Address>(), e => e.ID, a => a.Employees.ID, (emp, addr) => new { employee = emp, adr = addr }).SelectMany(x => x.adr, (a, b) => new { EmpName = a.employee.EmpName, Addr = b.City });
            foreach (var item in employees)
            {
                Console.WriteLine(item.EmpName + " --- " + item.Addr);

            }
            Console.WriteLine();
        }

        private static void Query3(ISession session)
        {
            Console.WriteLine("Fetch all employee with their address\n");
            var employees = session.Query<Employee>().GroupJoin(session.Query<Address>(), e => e.ID, a => a.Employees.ID, (emp, addr) => new { employee = emp, adr = addr }).SelectMany(x => x.adr,(a,b) => new { EmpName = a.employee.EmpName, Addr = b.City});
            foreach (var item in employees)
            {
                Console.WriteLine(item.EmpName + " --- "+item.Addr);
               
            }
            Console.WriteLine();
        }

        private static void Query2(ISession session)
        {
            Console.WriteLine("Fetch address of employee whose id is 1");
            var employees = session.Query<Employee>().Join(session.Query<Address>(), e => e.ID, a => a.Employees.ID, (emp, addr) => new { employee = emp, adr = addr }).Where(x => x.employee.ID == 1).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine(item.employee.EmpName+" --- "+ item.adr.City);
            }
        }

        private static void Query1(ISession session)
        {
            Console.WriteLine("Fetching Employee whose id is 2");
            IList<Employee> employees = session.Query<Employee>().Where(x => x.ID == 2).ToList();
            foreach (var item in employees)
            {
                Console.WriteLine(item.EmpName +" --- "+item.Salary+" --- "+item.Job);
            }
        }

        private static void CreateEmployeeAndAddress(ISession session)
        {
            var e1 = new Employee { EmpName = "Sumit", Job = "Manager", Salary = 15000 };
            var e2 = new Employee { EmpName = "Yogesh", Job = "Clerk", Salary = 20000 };
            var e3 = new Employee { EmpName = "Ramesh", Job = "Developer", Salary = 21000 };

            var a1 = new Address { City = "Navsari", Employees = e1 };
            var a2 = new Address { City = "Surat", Employees = e2 };
            var a3 = new Address { City = "Ahemdabad", Employees = e3 };
            var a4 = new Address { City = "Mumbai", Employees = e1 };
            var a5 = new Address { City = "Valsad", Employees = e2 };

            e1.Addresses.Add(a1);
            e2.Addresses.Add(a2);
            e3.Addresses.Add(a3);
            e1.Addresses.Add(a4);
            e2.Addresses.Add(a5);

            session.Save(e1);
            session.Save(e2);
            session.Save(e3);
        }
    }
}
