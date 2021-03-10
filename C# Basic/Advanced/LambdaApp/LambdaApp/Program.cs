using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaApp
{
    public delegate void DSayAnything(string name);

    class Program
    {
        public static void InsideNameFunc(string name)
        {
            Console.WriteLine("Inside named fuction");
            Console.WriteLine("Hello " + name);
        }

        public static void Case1() {
            DSayAnything x = InsideNameFunc;
            x("Sumit");
        }

        public static void Case2()
        {
            DSayAnything x = delegate (string name) {
                Console.WriteLine("Inside anonymous fuction");
                Console.WriteLine("Hello " + name);
            };
            x("Suresh");
        }

        public static void Case3()
        {
            DSayAnything x =  (name) => {
                Console.WriteLine("Inside lambda fuction");
                Console.WriteLine("Hello " + name);
            };
            x("Ramesh");
        }

        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
        }
    }
}
