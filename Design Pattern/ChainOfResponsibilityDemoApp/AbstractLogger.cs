using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemoApp
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int FILE = 2;
        public static int ERROR = 3;

        protected int level;
        protected AbstractLogger nextLogger;
        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }
        public void LogMessage(int level, String message)
        {
            if (this.level <= level)
            {
                WriteMessage(message);
            }
            if (nextLogger != null)
            {
                nextLogger.LogMessage(level, message);
            }
        }

        abstract protected void WriteMessage(String message);
    }
}
