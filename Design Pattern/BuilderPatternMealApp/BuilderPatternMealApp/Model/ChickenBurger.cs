using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMealApp.Model
{
    class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 50.0f;
        }
    }
}
