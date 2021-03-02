using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemoApp.Model
{
    class Subtract : IStrategy
    {
        public int DoOperation(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}