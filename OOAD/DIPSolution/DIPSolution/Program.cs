using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSolution.Model;

namespace DIPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new XmlLogger();
            TaxCalculation taxCalculation = new TaxCalculation(logger);
            Console.WriteLine(taxCalculation.Calculation(10,0));
        }
    }
}
