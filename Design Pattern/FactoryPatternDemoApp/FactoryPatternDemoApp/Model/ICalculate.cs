using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoApp.Model
{
    public interface ICalculate
    {
        double Calculate(double n1, double n2);
    }
}
