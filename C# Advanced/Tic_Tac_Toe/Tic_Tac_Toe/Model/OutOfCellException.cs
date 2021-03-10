using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Model
{
    public class OutOfCellException : Exception
    {
        public OutOfCellException(string message): base(message) { }
    }
}
