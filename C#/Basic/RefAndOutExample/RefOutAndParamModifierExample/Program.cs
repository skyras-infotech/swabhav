using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutExample
{
    class Program
    {
        public const int a = 5;
        static void Main(string[] args)
        {
            Console.WriteLine(a);            int a1 = 10;
            int b1;
            ChangeA(ref a1);
            ChangeB(out b1);
            Console.WriteLine("A is "+a1);
            Console.WriteLine("B is " + b1);
            int a = 10, b = 20, max = 0;
            int min = MultipleReturns(a, b, out max);
            Console.WriteLine("Minimum Value: " + min);
            Console.WriteLine("Maximum Value: " + max);
            Console.ReadLine();

        }
        static int ChangeA(ref int a ) {
            a = 50;
            return a;
        }
        static int ChangeB(out int b)
        {
            b = 60;
            return b;
        }
        public static int MultipleReturns(int a, int b, out int max)
        {
            if (a < b)
            {
                max = b;
                return a;
            }
            else
            {
                max = a;
                return b;
            }
        }
    }
}
