using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class TxtLogger
    {
        public void Log(string error) {
            Console.WriteLine("Writing error into txt files.");
            Console.WriteLine(error);
        }
    }
}
