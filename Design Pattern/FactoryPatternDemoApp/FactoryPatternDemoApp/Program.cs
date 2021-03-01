using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternDemoApp.Model;

namespace FactoryPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number ==> ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number ==> ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            CalculateFactory factory = new CalculateFactory();
            Console.Write("Enter add subtract or divide ==> ");
            string type = Console.ReadLine();
            ICalculate calculate = factory.GetCalculation(type);
            Console.WriteLine(type+" is "+ calculate.Calculate(n1,n2));
        }
    }
}
