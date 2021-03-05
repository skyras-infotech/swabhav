﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternShapeApp.Model
{
    class Blue : IColor
    {
        public void FillColor()
        {
            Console.WriteLine("Fill a blue color");
        }
    }
}
