using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLib
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() { }
        public InsufficientBalanceException(string exception) : base(exception){
        }
    }
}
