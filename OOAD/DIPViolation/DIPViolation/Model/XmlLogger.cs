using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.Model
{
    class XmlLogger
    {
        public void Log(string logError)
        {
            Console.WriteLine("Writing error into the xml files.");
            Console.WriteLine(logError);
        }
    }
}
