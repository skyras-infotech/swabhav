using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractLogger loggerChain = getChainOfLoggers();
            loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");
            loggerChain.LogMessage(AbstractLogger.FILE, "This is an file level information.");
            loggerChain.LogMessage(AbstractLogger.ERROR, "This is an error information.");
        }

        private static AbstractLogger getChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.FILE);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}
