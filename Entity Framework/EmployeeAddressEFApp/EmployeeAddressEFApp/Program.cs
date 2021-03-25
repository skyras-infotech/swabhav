using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAddressEFApp.Model;

namespace EmployeeAddressEFApp
{
    class Program
    {
        public static EmployeeDBContext db = new EmployeeDBContext();
        static void Main(string[] args)
        {
            //CreateAndLoadDataInEmployeeAndAddress();
            //Top3EmployeeWhoseMaxSalary();
            //DisplayEmployeeDesignationBy();
            //DisplayEmployeeWithAddressIfAny();
            //DisplayAllEmployeeWithAddress();
            //DisplayEmployeeSalaryAndJobWise();
            DisplayEmployeeWhoLiveInMumbai();
           

        }

        private static void DisplayEmployeeWhoLiveInMumbai()
        {
            var empLiveMumbai = db.Employees.Join(
               db.Addresses,
               e => e.ID,
               a => a.Employee.ID,
               (emp, addr) => new { employees = emp, addresses = addr }).Where(x => x.addresses.City == "Mumbai");
            Console.WriteLine("Find all employees who leave in mumbai");
            foreach (var item in empLiveMumbai)
            {
                Console.WriteLine(item.employees.EmpName + " --- " + item.addresses.City);
            }
        }

        private static void DisplayEmployeeSalaryAndJobWise()
        {
            var empSalJob = db.Employees.Where(x => x.Job.Equals("Manager") && x.Salary > 20000);
            Console.WriteLine("Find all employees whose designation is manager and salary is greater than 20000");
            foreach (var item in empSalJob)
            {
                Console.WriteLine(item.EmpName +" --- "+item.Job +" --- "+item.Salary);
            }
        }

        private static void DisplayAllEmployeeWithAddress()
        {
            var allEmpAddr = db.Employees.GroupJoin(
               db.Addresses,
               e => e.ID,
               a => a.Employee.ID,
               (emp, addr) => new { employees = emp, addresses = addr }).SelectMany(z => z.addresses,
               (a, b) => new { EmpName = a.employees.EmpName, Adddress = b.City });

            Console.WriteLine("Display All Employee with address\n");
            foreach (var item in allEmpAddr)
            {
                Console.WriteLine(item.EmpName + " --- " + item.Adddress);
            }
            Console.WriteLine();
        }

        private static void DisplayEmployeeWithAddressIfAny()
        {
            var empAddrIfAny = db.Employees.GroupJoin(
                db.Addresses,
                e => e.ID,
                a => a.Employee.ID,
                (emp, addr) => new { employees = emp, addresses = addr }).SelectMany(z => z.addresses.DefaultIfEmpty(),
                (a, b) => new { EmpName = a.employees.EmpName, Adddress = b.City });

            Console.WriteLine("Display Employee with address if any\n");
            foreach (var item in empAddrIfAny)
            {
                Console.WriteLine(item.EmpName + " --- " + item.Adddress);
            }
            Console.WriteLine();
        }

        private static void DisplayEmployeeDesignationBy()
        {
            Console.WriteLine("Display Employee Designation wise");
            var empDesig = db.Employees.OrderBy(x => x.Job);
            foreach (var item in empDesig)
            {
                Console.WriteLine(item.EmpName + " --- " + item.Job);
            }
        }

        private static void Top3EmployeeWhoseMaxSalary()
        {
            Console.WriteLine("Display Top 3 employee who have max salary");
            var maxSalary = db.Employees.OrderByDescending(x => x.Salary).Take(3);
            foreach (var item in maxSalary)
            {
                Console.WriteLine(item.EmpName +" --- "+item.Salary);
            }
        }

        private static void CreateAndLoadDataInEmployeeAndAddress()
        {
            var e1 = new Employee { ID = 101, EmpName = "Sumit", Job="Manager", Salary=15000};
            var e2 = new Employee { ID = 102, EmpName = "Yogesh", Job = "Clerk", Salary = 20000 };
            var e3 = new Employee { ID = 103, EmpName = "Ramesh", Job = "Developer", Salary = 21000 };
            var e4 = new Employee { ID = 104, EmpName = "Suresh", Job = "Manager", Salary = 22000 };
            var e5 = new Employee { ID = 105, EmpName = "Mukesh", Job = "Clerk", Salary = 23000 };
            var e6 = new Employee { ID = 106, EmpName = "Rakesh", Job = "Manager", Salary = 10000 };
            var e7 = new Employee { ID = 107, EmpName = "Mahesh", Job = "Developer", Salary = 30000 };
            var e8 = new Employee { ID = 108, EmpName = "Raju", Job = "Manager", Salary = 35000 };

            var a1 = new Address { AID = 101, City = "Navsari" };
            var a2 = new Address { AID = 102, City = "Surat" };
            var a3 = new Address { AID = 103, City = "Ahemdabad" };
            var a4 = new Address { AID = 104, City = "Mumbai" };
            var a5 = new Address { AID = 105, City = "Valsad" };

            e1.Addresses.Add(a1);
            e2.Addresses.Add(a2);
            e3.Addresses.Add(a4);
            e4.Addresses.Add(a5);
            e5.Addresses.Add(a3);
            e6.Addresses.Add(a2);
            e1.Addresses.Add(a4);
            e2.Addresses.Add(a5);

            db.Employees.Add(e1);
            db.Employees.Add(e2);
            db.Employees.Add(e3);
            db.Employees.Add(e4);
            db.Employees.Add(e5);
            db.Employees.Add(e6);
            db.Employees.Add(e7);
            db.Employees.Add(e8);

            db.SaveChanges();
        }
    }
}
