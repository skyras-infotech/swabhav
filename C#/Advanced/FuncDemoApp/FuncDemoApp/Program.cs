using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemoApp
{
    class Program
    {
        public static long InsideNameFunc(int n1,int n2)
        {
            Console.WriteLine("Inside named function");
            return n1 * n2;
        }

        public static void Case1()
        {
            Func<int, int, long> x = InsideNameFunc;
            Console.WriteLine("Multiplication in named Func is "+x(10,20));
        }

        public static void Case2()
        {
            Func<int, int, long> x = delegate (int n1,int n2) {
                Console.WriteLine("Inside anonymous fuction");
                return n1 + n2;
            };
            Console.WriteLine("Addition in anonymous Func is "+x(10,20));
        }

        public static void Case3()
        {
            Func<int, int, long> x = (n1,n2) => {
                Console.WriteLine("Inside lambda fuction");
                return n1 / n2;
            };
            Console.WriteLine("Division in lambda func is " + x(20,10));
        }

        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
        }
    }
}
