using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnBoxingDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 1, i2 = 1;
            Console.WriteLine("i1==i2 : " + (i1 == i2));
            Int32 num1 = 1;
            int num2 = 1;
            Console.WriteLine("num1 == num2 : " + (num1 == num2));

            Int32 one = new Int32();
            one = 1;
            Int32 anotherOne = new Int32();
            anotherOne = 1;
            Console.WriteLine("one == anotherOne : " + one.Equals(anotherOne));

        }
    }
}
