using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoApp
{
    // declare a delegate
    public delegate void DSayAnything(string name);
    class Program
    {
        private static void SayHello(string name) 
        {
            Console.WriteLine("Hello "+name);
        }

        public static void SayGoodBye(string name)
        {
            Console.WriteLine("Good Bye! "+name+"\n");
        }

        public static void TakeDelegateAsParameter(DSayAnything obj4) {
            Console.Write("Call the method in another method : ");
            obj4("Raju");
        }

        public static void TakeDelegateAsAnonymouseMethod(DSayAnything obj)
        {
            Console.Write("Call the anonymous method in another method : ");
            obj("Dipak");
        }

        static void Main(string[] args)
        {
            // ===== case 1 (Simple Delegate)==========

            // instantiate the delegate (either this way)
            Console.WriteLine("===== case 1 (Simple Delegate)==========");
            DSayAnything obj = new DSayAnything(SayHello);

            // invoke/call the delegate
            obj("Sumit");

            // instantiate the delegate (or this way)
            DSayAnything obj2 = SayGoodBye;

            // invoke/call using invoke() method
            obj2.Invoke("Yogesh");


            // ===== case 2 (Multicast Delegate)==========

            Console.WriteLine("===== case 2 (Multicast Delegate)==========");
            DSayAnything obj3 = SayHello;
            obj3 += SayGoodBye;
            obj3.Invoke("Ramesh");


            // ===== case 3 (Pass delegate as a parameter)==========

            Console.WriteLine("===== case 3 (Pass delegate as a parameter)==========");
            TakeDelegateAsParameter(SayHello);
            Console.WriteLine();


            // ===== case 4 (Anonymous Method)==========

            Console.WriteLine("===== case 4 (Anonymous Method)==========");
            TakeDelegateAsAnonymouseMethod(delegate (string name)
            {
                Console.WriteLine("Good morning! "+name+"\n");
            });


            // ===== case 5 (Lambda Expression for anonymous method)==========

            Console.WriteLine("===== case 5 (Lambda Expression for anonymous method)==========");
            DSayAnything obj6 = (name) => Console.WriteLine("Good Night! " + name + "\n");
            obj6("Paresh");

        }

        
    }
}
