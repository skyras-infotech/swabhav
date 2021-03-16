using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonApp.Model;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John Doe", 20);
            PrintPersonInfo(p1);

            Person p2 = new Person("McKay", "Male", 25, 1.5f, 60);
            PrintPersonInfo(p2);

        }

        public static void PrintPersonInfo(Person p)
        {
            p.Eat();
            p.Workout();
            p.Eat();
            p.Workout();
            Console.WriteLine();
            Console.WriteLine("---------------User Info-------------");
            Console.WriteLine($"Welcome         : {p.Name}");
            Console.WriteLine($"You are         : {p.Gender}");
            Console.WriteLine($"Your age is     : {p.Age}");
            Console.WriteLine($"Your weight is  : {p.Weight}");
            Console.WriteLine($"Your height is  : {p.Height}");
            double result = p.CalculateBMIIndex();
            if (result > 25) 
            {
                Console.WriteLine($"According to your weight and height you are overweight");
            }
            else if (result < 18.5)
            {
                Console.WriteLine($"According to your weight and height you are underweight");
            }
            else
            {
                Console.WriteLine($"According to your weight and height you are healthy");
            }
            Console.WriteLine("\n");
        }

    }
}
