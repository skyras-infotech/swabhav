using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQToObjectApp.Model;

namespace LINQToObjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeess = new List<Employee>() {
                new Employee(101,"Sumit",50000,"Manager"),
                new Employee(102,"Yogesh",45000,"Profiler"),
                new Employee(103,"Ramesh",60000,"CEO"),
                new Employee(104,"Suresh",30000,"Developer"),
                new Employee(105,"Amit",40000,"Developer"),
            };
            Console.WriteLine("=======Employee Details======");
            foreach (var emp in employeess)
            {
                Console.WriteLine(emp.Name + " -- " + emp.Salary + " -- " + emp.Designation);
            }
            Console.WriteLine();

            IEnumerable<Employee> employees = employeess;
            Console.WriteLine("Find Top 3 Earning Employees");
            var top3EarningEmp = employees.OrderByDescending(x => x.Salary).Take(3);
            foreach (var emp in top3EarningEmp.ToList())
            {
                Console.WriteLine(emp.Name +" -- "+emp.Salary);
            }

            Console.WriteLine("\nFind employee with profile manager");
            var profileManager = employees.Where(x => x.Designation.Equals("Profiler"));
            foreach (var emp in profileManager.ToList())
            {
                Console.WriteLine(emp.Name+" -- "+emp.Designation);
            }

            Console.WriteLine("\nFind employees whose salary is more than 45000");
            var moreThan45000 = employees.Where(x => x.Salary > 45000);
            foreach (var emp in moreThan45000.ToList())
            {
                Console.WriteLine(emp.Name + " -- " + emp.Salary);
            }
        }
    }
}
