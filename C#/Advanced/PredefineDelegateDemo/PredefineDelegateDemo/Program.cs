using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefineDelegateDemo
{
    
    class Program
    {
        private static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void SayGoodBye(string name)
        {
            Console.WriteLine("Good Bye! " + name + "\n");
        }

        static void Main(string[] args)
        {
            Action<string> obj = SayHello;
            obj("Sumit");

            Action<string> obj1 = SayGoodBye;
            obj("Sumit");

        }


    }
}