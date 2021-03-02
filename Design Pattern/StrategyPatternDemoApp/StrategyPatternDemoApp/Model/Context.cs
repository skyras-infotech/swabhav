using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDemoApp.Model
{
    class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int DoOpration(int n1,int n2) {
            return strategy.DoOperation(n1, n2);
        }
    }
}
