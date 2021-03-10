using System;

namespace StackoverflowExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am inside main...");
            try
            {
                m1();
            }
            catch (StackOverflowException e) {
                Console.WriteLine(e.GetType() + "Ohh no overflow error occurred");
            }
            
        }

        private static void m1()
        {
            Console.WriteLine("I am inside m1...");
            Main(null);
            m2();
        }

        private static void m2()
        {
            Console.WriteLine("I am inside m2...");
        }

    }
   
}
