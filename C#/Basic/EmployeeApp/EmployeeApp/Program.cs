using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer(2000,101,"John",12000.0f,new DateTime(1998,12,03),"Programmer");
            PrintEmployeeInfo(p1,p1.TotalSalaryOfProgrammer());

            Analyst a1= new Analyst(14, 102, "Rihana", 20000.0f, new DateTime(1985, 05, 25),"Analyst");
            PrintEmployeeInfo(a1, a1.TotalSalaryOfAnalyst());

            Manager m1 = new Manager(7.5f,5,8.5f, 103, "Watson", 10000.0f, new DateTime(1990, 07, 12),"Manger");
            PrintEmployeeInfo(m1, m1.TotalSalaryOfManager());
        }

        static void PrintEmployeeInfo(Employee e,float TotalSalary) {
            Console.WriteLine("-----------Employee Info---------\n");
            Console.WriteLine("Employee ID              : "+e.ID);
            Console.WriteLine("Employee Name            : " + e.Name);
            Console.WriteLine("Employee Type            : " + e.EMPType);
            Console.WriteLine("Employee date of birth   : " + e.DOB.ToString("dd/MM/yyyy"));
            Console.WriteLine("Employee Total salary    : "+TotalSalary);
            Console.WriteLine("\n");
        }
    }
}
