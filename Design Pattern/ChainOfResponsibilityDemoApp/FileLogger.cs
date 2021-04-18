using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemoApp
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void WriteMessage(string message)
        {
            Console.WriteLine("File :: Logger: " + message);
        }
    }
}
