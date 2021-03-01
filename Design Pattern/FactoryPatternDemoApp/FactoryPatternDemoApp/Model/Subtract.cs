using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoApp.Model
{
    public class Subtract : ICalculate
    {
        public double Calculate(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}
