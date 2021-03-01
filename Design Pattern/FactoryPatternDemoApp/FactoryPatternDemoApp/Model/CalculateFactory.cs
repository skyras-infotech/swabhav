using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternDemoApp.Model
{
    class CalculateFactory
    {
        public ICalculate GetCalculation(string type) 
        {
            ICalculate calculate = null;
            if (type.ToLower().Equals("add"))
            {
                calculate = new Add();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                calculate = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                calculate = new Divide();
            }
            else {
                return null;
            }
            return calculate;
        }
    }
}
