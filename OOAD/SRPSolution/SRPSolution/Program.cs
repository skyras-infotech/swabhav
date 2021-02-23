using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRPSolution.Model;

namespace SRPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------SRP Solution-------------\n");
            Invoice invoice = new Invoice(101, "Printer", 30000, 15, 18);
            InvoicePrinter printer = new InvoicePrinter(invoice);
            printer.PrintToConsole();
        }
       
    }
}
