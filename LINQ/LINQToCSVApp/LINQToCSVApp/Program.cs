using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQToCSVApp.Model;
using System.IO;

namespace LINQToCSVApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\swabhav\LINQ\Employee.csv";
            string deptPath = @"C:\swabhav\LINQ\Department.csv";
            IEnumerable <Employee> employees = LoadEmployees(path1).ToList();
            IEnumerable <Department> departments = LoadDepartments(deptPath).ToList();

            Console.WriteLine("Display all employees in dept 10,20");
            var empDept1020 = employees.Where(e => e.DepartmentNo == 10 || e.DepartmentNo == 20);
            foreach (var emp in empDept1020)
            {
                Console.WriteLine(emp.Name);
            }

            Console.WriteLine("\nDisplay all employees who have same job designation as smith");
            var desigAsSmith = employees.Where(x => x.Job.Equals(employees.Where(y => y.Name.Equals("SMITH")).Select(z => z.Job).First()));
            foreach (var emp in desigAsSmith)
            {
                Console.WriteLine(emp.Name +" --- "+emp.Job);
            }

            Console.WriteLine("\nDisplay all the departments, With employee names");
            var getEmpNameAndDept = employees.Join(departments,e => e.DepartmentNo, d => d.DepartmentNo,(emp,dept) => new { EmpName = emp.Name, DeptName = dept.DepartmentName });
            foreach (var emp in getEmpNameAndDept)
            {
                Console.WriteLine(emp.EmpName + " --- " + emp.DeptName);
            }

            Console.WriteLine("\nDisplay sum of all employee salaries");
            var sumOfAllEmpSalary = employees.Sum(x => x.Salary);
            Console.WriteLine("Sum of all employees salary is "+sumOfAllEmpSalary);

            Console.WriteLine("\nDisplay count of employee department wise");
            var deptWiseEmp = departments.GroupJoin(employees, d => d.DepartmentNo, e => e.DepartmentNo, (dept, emp) => new {departments = dept,employees = emp});
            Console.WriteLine("Departwise no of employees");
            foreach (var item in deptWiseEmp.ToList())
            {
                Console.WriteLine(item.departments.DepartmentName+" --- "+item.employees.Count());
            }
            Console.WriteLine();
        }

        private static IEnumerable<Employee> LoadEmployees(string path) {
           return File.ReadLines(path)
                .Skip(1)
                .Where(data => data.Length > 0)
                .Select(Employee.ParseData)
                .ToList();
        }

        private static IEnumerable<Department> LoadDepartments(string path)
        {
            return File.ReadLines(path)
                .Skip(1)
                .Where(data => data.Length > 0)
                .Select(Department.ParseData)
                .ToList();
        }
    }
}
