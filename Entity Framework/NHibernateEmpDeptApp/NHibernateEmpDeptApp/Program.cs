using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateEmpDeptApp.Model;
using NHibernate;

namespace NHibernateEmpDeptApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    //CreateEmployeeAndDept(session);
                    //Query1(session);
                    //Query2(session);
                    //Query3(session);
                    Query4(session);
                    Query5(session);
                    transaction.Commit();
                }
            }
        }

        private static void Query5(ISession session)
        {
            Console.WriteLine("Display Employee & count of employee job wise\n");
            var jobWise = session.Query<Emp>().GroupBy(x => x.Job);

            foreach (var group in jobWise)
            {
                Console.WriteLine("{0} - {1}",group.Key,group.Count());
                Console.WriteLine("-----------------");
                foreach (var emp in group)
                {
                    Console.WriteLine(emp.EmpName+"\t"+emp.Job);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void Query4(ISession session)
        {
            Console.WriteLine("Display Total salary of employees who are work in IT Department\n");
            var totalSalary = session.Query<Emp>().Join(
                session.Query<Dept>(),
                e => e.Dept.ID,
                d => d.ID,
                (emp, dept) => new { employee = emp, department = dept }).Where(x => x.department.DeptName == "IT").Sum(x => x.employee.Salary);

            Console.WriteLine("Total salary is "+totalSalary);
           
            Console.WriteLine();
        }

        private static void Query3(ISession session)
        {
            Console.WriteLine("Display employee who arre working mumbai\n");
            var empdept = session.Query<Emp>().Join(
                session.Query<Dept>(),
                e => e.Dept.ID,
                d => d.ID,
                (emp, dept) => new { employee = emp, department = dept }).Where(x => x.department.Location == "Mumbai");

            foreach (var item in empdept)
            {
                Console.WriteLine(item.employee.EmpName + "\t" + item.department.DeptName +"\t"+item.department.Location);
            }
            Console.WriteLine();
        }

        private static void Query2(ISession session)
        {
            Console.WriteLine("Display employee with his department if any employee have not any department then display No Department\n");
            var empdept = session.Query<Emp>().GroupJoin(
                session.Query<Dept>(),
                e => e.Dept.ID,
                d => d.ID,
                (emp, dept) => new { employee = emp, department = dept })
                .SelectMany(z => z.department.DefaultIfEmpty(),
                (a, b) => new { EmpName = a.employee.EmpName, DepartmentName = b == null ? "No Department" : b.DeptName });

            foreach (var item in empdept)
            {
                Console.WriteLine(item.EmpName + " --- " + item.DepartmentName);
            }
            Console.WriteLine();

        }

        private static void Query1(ISession session)
        {
            Console.WriteLine("Display Top 3 employee who have max salary");
            var maxSalary = session.Query<Emp>().OrderByDescending(x => x.Salary).Take(3);
            foreach (var item in maxSalary)
            {
                Console.WriteLine(item.EmpName +" --- "+item.Salary);
            }
            Console.WriteLine();
           
        }

        private static void CreateEmployeeAndDept(ISession session)
        {
            var d1 = new Dept { DeptName = "IT", Location = "Gujarat" };
            var d2 = new Dept { DeptName = "Computer", Location = "Mumbai" };
            var d3 = new Dept { DeptName = "Mechanical", Location = "Gujarat" };
            var d4 = new Dept { DeptName = "Electrical", Location = "Mumbai" };
            var d5 = new Dept { DeptName = "Civil", Location = "UP" };

            var e1 = new Emp { EmpName = "Sumit", Job = "Manager", Salary = 15000, Dept = d1 };
            var e2 = new Emp { EmpName = "Yogesh", Job = "Clerk", Salary = 20000,Dept =d2 };
            var e3 = new Emp { EmpName = "Ramesh", Job = "Developer", Salary = 21000,Dept = d3 };
            var e4 = new Emp { EmpName = "Suresh", Job = "Manager", Salary = 22000 ,Dept = d4 };
            var e5 = new Emp { EmpName = "Mukesh", Job = "Clerk", Salary = 23000 ,Dept = d5};
            var e6 = new Emp { EmpName = "Rakesh", Job = "Manager", Salary = 10000 ,Dept = d1};
            var e7 = new Emp { EmpName = "Mahesh", Job = "Developer", Salary = 30000 ,Dept = d2};
            var e8 = new Emp { EmpName = "Raju", Job = "Manager", Salary = 35000,Dept =d3 };

            d1.DeptEmployees.Add(e1);
            d2.DeptEmployees.Add(e2);
            d3.DeptEmployees.Add(e3);
            d4.DeptEmployees.Add(e4);
            d5.DeptEmployees.Add(e5);
            d1.DeptEmployees.Add(e6);
            d2.DeptEmployees.Add(e7);
            d3.DeptEmployees.Add(e8);

            session.Save(d1);
            session.Save(d2);
            session.Save(d3);
            session.Save(d4);
            session.Save(d5);

        }
    }
}
