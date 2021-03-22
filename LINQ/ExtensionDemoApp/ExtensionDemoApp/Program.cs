using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionDemoApp.ExtensionMethods;

namespace ExtensionDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SnakeCase.ToSnackCase("This is written snack case"));
        }
    }
}
