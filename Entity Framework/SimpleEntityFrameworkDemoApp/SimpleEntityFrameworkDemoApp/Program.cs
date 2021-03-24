using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEntityFrameworkDemoApp.Model;

namespace SimpleEntityFrameworkDemoApp
{
    class Program
    {
        public static DemoDBContext db = new DemoDBContext();
        static void Main(string[] args)
        {
            //CreateEmployee();
            //AddEmployee();
            //DeleteEmployee();
            UpdateEmployee();
        }

        private static void UpdateEmployee()
        {
            foreach (var item in db.Employees)
            {
                if (item.Name == "Sumit")
                {
                    item.Name = "Sumit Gupta";
                    Console.WriteLine("Data Updated Sucessfully..");
                }
            }
            db.SaveChanges();
        }

        private static void DeleteEmployee()
        {
            foreach (var item in db.Employees)
            {
                if (item.Name == "Ajay") { 
                     db.Employees.Remove(item);
                    Console.WriteLine("Data Deleted Sucessfully..");
                }
            }
            db.SaveChanges();
        }

        private static void AddEmployee()
        {
            db.Employees.Add(new Employee { ID = 104, Name="Ramesh", Salary=17000});
            db.SaveChanges();
        }

        private static void CreateEmployee()
        {
            Employee[] employees = {
                new Employee { ID = 101, Name="Sumit", Salary=10000},
                new Employee { ID = 102, Name="Yogesh", Salary=15000},
                new Employee { ID = 103, Name="Ajay", Salary=20000},
            };

            foreach (var emp in employees)
            {
                db.Employees.Add(emp);
            }

            db.SaveChanges();
        }
    }
}
