using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDemo s1 = SingletonDemo.GetInstance;
            SingletonDemo s2 = SingletonDemo.GetInstance;
            Console.WriteLine("Hascode of s1 is " + s1.GetHashCode());
            Console.WriteLine("Hascode of s2 is " + s2.GetHashCode());
        }
    }
}
