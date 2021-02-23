using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPViolationApp.Model;

namespace SRPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------SRP Violation-------------\n");
            Invoice invoice = new Invoice(101,"Printer",30000,15,18);
            invoice.PrintToConsole();
        }
    }
}
