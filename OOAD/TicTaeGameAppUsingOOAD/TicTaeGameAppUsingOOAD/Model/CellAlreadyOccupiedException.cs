using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTaeGameAppUsingOOAD.Model
{
    public class CellAlreadyOccupiedException : Exception
    {
        public CellAlreadyOccupiedException(string message) : base(message) { }
    }
}
