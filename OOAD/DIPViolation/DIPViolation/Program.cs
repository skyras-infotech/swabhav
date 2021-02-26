using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPViolation.Model;

namespace DIPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculation taxCalculation = new TaxCalculation(LogType.TXT);
            Console.WriteLine(taxCalculation.Calculation(5, 0));
        }
    }
}
