using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphicApp
{       
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();
            ClassB c = b;
            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine("Comparing Objects");
            Console.WriteLine(Object.Equals(a,b));
            Console.WriteLine(Object.Equals(b, c));
            Console.WriteLine(Object.Equals(s1, s2));
            Console.WriteLine(ReferenceEquals(a,b));
            Console.WriteLine(ReferenceEquals(b, c));
            Console.WriteLine(ReferenceEquals(s1, s2)+"\n");
            
            Console.WriteLine("5"==5.ToString());
            int num = 5;
            string str = "John";
            Console.WriteLine(num.GetType().Equals(typeof(int)));
            Console.WriteLine(str.GetType().Equals(typeof(string)));
        }
    }
}
