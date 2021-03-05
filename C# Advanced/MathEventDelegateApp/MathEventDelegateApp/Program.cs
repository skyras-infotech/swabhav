using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathEventDelegateApp.Publisher;

namespace MathEventDelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.AdditionCompleted += PrintAddDetails;
            calculator.Add(5,6);
        }

        private static void PrintAddDetails(int x,int y, int answer)
        {
            Console.WriteLine("Addition of "+x+" and "+y+" is "+answer);
        }
    }
}
