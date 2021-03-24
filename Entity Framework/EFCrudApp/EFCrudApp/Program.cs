using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCrudApp.Model;

namespace EFCrudApp
{
    class Program
    {
        public static SwabhavDBContext db = new SwabhavDBContext();
        static void Main(string[] args)
        {
            //CreateEmployee();
            //Case1();
            Case2();
        }

        private static void Case1()
        {
            var emp = db.Employees.ToList()
                                  .Where(e => e.Salary > 10000)
                                  .Select(e => new { e.EmpName, e.Salary });

            foreach (var item in emp)
            {
                Console.WriteLine(item.EmpName);
            }
        }

        private static void Case2()
        {
            var emp = db.Employees.Where(e => e.Salary > 10000)
                                  .Select(e => new { e.EmpName, e.Salary })
                                  .ToList();

            foreach (var item in emp)
            {
                Console.WriteLine(item.EmpName);
            }
        }

        private static void CreateEmployee()
        {
            Employee[] employees = {
                new Employee { ID = 101, EmpName="Sumit", Salary=10000},
                new Employee { ID = 102, EmpName="Yogesh", Salary=15000},
                new Employee { ID = 103, EmpName="Ajay", Salary=20000},
            };

            foreach (var emp in employees)
            {
                db.Employees.Add(emp);
            }

            db.SaveChanges();
        }



    }
}
