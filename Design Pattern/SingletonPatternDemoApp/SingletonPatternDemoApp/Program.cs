using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonPatternDemoApp.Model;

namespace SingletonPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService d1 = DataService.GetInstance;
            DataService d2 = DataService.GetInstance;
            Console.WriteLine("Hascode of d1 is " + d1.GetHashCode());
            Console.WriteLine("Hascode of d2 is " + d2.GetHashCode());
            d1.ProcessData();
            d2.ProcessData();

        }
    }
}
