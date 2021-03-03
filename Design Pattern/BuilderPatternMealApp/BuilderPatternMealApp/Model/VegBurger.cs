using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMealApp.Model
{
    class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 25.5f;
        }
    }
}
