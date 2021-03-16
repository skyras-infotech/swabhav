using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Hello";
            Console.WriteLine("Name is " + str.GetHashCode());
            Console.WriteLine(str.ToUpper().GetHashCode());
            Console.WriteLine(str.ToLower().GetHashCode());
            str = "hii";
            Console.WriteLine(str.GetHashCode());
            Console.ReadLine();
        }
    }
}
