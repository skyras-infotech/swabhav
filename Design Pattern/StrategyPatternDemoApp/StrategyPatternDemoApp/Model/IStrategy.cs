using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemoApp.Model
{
    interface IStrategy
    {
        int DoOperation(int n1, int n2);
    }
}
