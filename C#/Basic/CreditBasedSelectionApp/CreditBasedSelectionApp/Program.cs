using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditBasedSelectionApp.Model;

namespace CreditBasedSelectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.ID = 1;
            e1.Name = "John Dae";
            e1.CreditPoint = "A Grade";
            e1.Age = 25;
            PrintCandidateInfo(e1);

            Employee e2 = new Employee();
            e2.ID = 2;
            e2.Age = 30;
            e2.Name = "McKay";
            e2.CreditPoint = "B Grade";
            PrintCandidateInfo(e2);

            Employee better = e1.WhoIsBetter(e2);
            Console.WriteLine(better.Name+" is Better");

            Employee elder = e1.WhoIsElder(e2);
            Console.WriteLine(elder.Name + " is Elder");

        }

        public static void PrintCandidateInfo(Employee e) {
            Console.WriteLine("--------Candicate Info-----");
            Console.WriteLine($"Welcome         : {e.Name}");
            Console.WriteLine($"Your age is     : {e.Age}");
            Console.WriteLine($"Your Credit Point is  : {e.CreditPoint}");
            Console.WriteLine();
        }
    }
}
