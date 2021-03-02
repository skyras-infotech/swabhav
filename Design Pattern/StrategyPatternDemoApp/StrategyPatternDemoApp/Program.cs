using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDemoApp.Model;

namespace StrategyPatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new Add());
            Console.WriteLine("15 + 6 ==> " + context.DoOpration(15, 6));
            context = new Context(new Subtract());
            Console.WriteLine("15 - 6 ==> " + context.DoOpration(15, 6));
            context = new Context(new Divide());
            Console.WriteLine("15 / 3 ==> " + context.DoOpration(15, 3));
        }
    }
}
