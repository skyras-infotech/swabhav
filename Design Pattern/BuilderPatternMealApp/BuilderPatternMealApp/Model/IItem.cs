﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMealApp.Model
{
    interface IItem
    {
        string Name();
        IPacking Packing();
        float Price();
    }
}
