using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class Calculator
    {
        public int CubeEven(int no) {
            if (no % 2 == 0) {
                return no * no * no;
            }
            throw new Exception(string.Format("Number {0} is not evenn", no));
        }

        public string OddEven(int no) {
            if (no % 2 == 0)
            {
                return "Even";
            }
            else {
                return "Odd";
            }
        }
    }
}
