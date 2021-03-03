using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMealApp.Model
{
    class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 30.0f;
        }
    }
}
