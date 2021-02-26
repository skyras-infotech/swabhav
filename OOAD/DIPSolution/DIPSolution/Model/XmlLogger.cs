using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Model
{
    class XmlLogger : ILogger
    {
        public void Logger(string error)
        {
            Console.WriteLine("Writing error into the xml files.");
            Console.WriteLine(error);
        }
    }
}
