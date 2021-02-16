using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionThrowAndThrowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                m1();
            } catch  {
               
            }
             Console.WriteLine("End of program");
        }
        static void m1() {
            Console.WriteLine("m1 is called");
            m2();
        }
        static void m2()
        {
            Console.WriteLine("m2 is called");
            m3();
        }
        static void m3()
        {
            Console.WriteLine("m3 is called");
            throw new Exception();
        }
    }


}
