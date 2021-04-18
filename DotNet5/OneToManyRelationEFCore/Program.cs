using System;
using System.Collections.Generic;
using System.Linq;

namespace OneToManyRelationEFCore
{
    class Program
    {

        static void Main(string[] args)
        {
            EmployeeDBContext _context = new EmployeeDBContext();
            //AddDepartments(_context);
            var empDept = _context.Departments.ToList().GroupJoin(_context.Employees.ToList(), d => d.ID, e => e.DepartmentID, (dept, emp) => new { Depts = dept, Emps = emp });
            foreach (var dept in empDept)
            {
                Console.WriteLine("Department ID    :\t" + dept.Depts.ID);
                Console.WriteLine("Department Name  :\t" + dept.Depts.Name);
                foreach (var emp in dept.Depts.Employees)
                {
                    Console.WriteLine("\tEmp ID      :\t" + emp.ID);
                    Console.WriteLine("\tEmp Name    :\t" + emp.EmpName);
                    Console.WriteLine("\tEmp Salary  :\t" + emp.Salary);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        private static void AddDepartments(EmployeeDBContext employeeDBContext)
        {
            employeeDBContext.Departments.Add(new Department { Name = "IT"});
            employeeDBContext.Departments.Add(new Department { Name = "Finance"});
            employeeDBContext.Departments.Add(new Department { Name = "HR"});
            employeeDBContext.SaveChanges();
        }
    }
}
