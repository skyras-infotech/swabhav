using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyApp.Model;

namespace OneToManyApp
{
    class Program
    {
        public static DemoDBContext db = new DemoDBContext();
        static void Main(string[] args)
        {
            var d1 = new Dept { DeptID = 101, DeptName = "IT", Location = "Gujarat"};
            var d2 = new Dept { DeptID = 102, DeptName = "Computer", Location = "Mumbai" };

            var e1 = new Emp { EmpID = 1, EmpName = "Sumit", Salary = 15000  };
            var e2 = new Emp { EmpID = 2, EmpName = "Yogesh", Salary = 20000 };
            var e3 = new Emp { EmpID = 3, EmpName = "Ajay", Salary = 12500};

            d1.DeptEmployees.Add(e1);
            d1.DeptEmployees.Add(e2);
            d2.DeptEmployees.Add(e3);

            db.Departments.Add(d1);
            db.Departments.Add(d2);

            db.SaveChanges();
            
        }
    }
}
