using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEventDelegateApp.Publisher
{
    public delegate void DCalcOperationAlert(int x, int y,int answer);
    class Calculator
    {
        public event DCalcOperationAlert AdditionCompleted;

        public void Add(int a, int b) {
            AdditionCompleted?.Invoke(a,b,a+b);
        }
    }
}
 