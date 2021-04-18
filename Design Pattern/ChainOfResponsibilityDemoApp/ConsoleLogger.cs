﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemoApp
{
    class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void WriteMessage(string message)
        {
            Console.WriteLine("Console :: Logger: " + message);
        }
    }
}
