using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class TxtLogger : ILogger
    {
        public void Logger(string error) {
            Console.WriteLine("Writing error into txt files.");
            Console.WriteLine(error);
        }
    }
}
