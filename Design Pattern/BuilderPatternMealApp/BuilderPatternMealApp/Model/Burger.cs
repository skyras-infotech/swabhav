using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMealApp.Model
{
    abstract class Burger : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}
