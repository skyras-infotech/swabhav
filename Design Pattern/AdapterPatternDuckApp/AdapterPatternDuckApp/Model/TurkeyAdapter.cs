using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDuckApp.Model
{
    class TurkeyAdapter : IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        public void Fly()
        {
            _turkey.Fly();
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
