using System;

namespace EqualsMethodOverridenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // if the instance is value type then equals is used to check value equality
            int a1 = 12;
            byte a2 = 12;
            Console.WriteLine($"a1.Equals(a2) is {a1.Equals(a2)}\n");

            //if we give an value type to object then it check the type of value if it is same then give true
            object o1 = a1;
            object o2 = a2;
            Console.WriteLine($"o1.Equals(o2) is {o1.Equals(o2)}\n");

            //if the instance is reference type then equals is used to check reference equality
            Person p1 = new Person("123", "John");
            Person p2 = new Person("123", "Sumit");
            Console.WriteLine($"p1.Equals(p2) is {p1.Equals(p2)}");
            Console.WriteLine($"P1 Hascode is {p1.GetHashCode()}");
            Console.WriteLine($"P2 Hascode is {p2.GetHashCode()}\n");

            //if the instance is reference type and we want to check value equality then 
            //we have to override Equals() and GetHaseCode() method value equality
            Employee p3 = new Employee("123", "John");
            Employee p4 = new Employee("123", "Sumit");
            Console.WriteLine($"p3.Equals(p4) is {p3.Equals(p4)}");
            Console.WriteLine($"P3 Hascode is {p3.GetHashCode()}");
            Console.WriteLine($"P4 Hascode is {p4.GetHashCode()}");
        }
    }
}
