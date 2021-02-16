using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() { }
        public InsufficientBalanceException(string exception) : base(exception){
        }
    }
}
