using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBehaveInheritanceApp
{
    class Child : Parent
    {
        Child(int foo) : base(foo)
        {
            Console.WriteLine(foo);
            //Console.WriteLine("I am inside child class and value is "+foo);
        }

        static void Main(string[] ar)
        {

            Child c1 = new Child(100);
            Console.WriteLine(c1.Number);
            Child c2 = new Child(200);
            Console.WriteLine(c2.Number);
        }
    }
}
