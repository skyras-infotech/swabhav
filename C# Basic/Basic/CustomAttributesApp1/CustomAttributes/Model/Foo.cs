using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes.Model
{

    [Test]
    class Foo
    {
        [Test]
        protected bool m1() {
            return true;
        }

        [Test]
        public bool m2()
        {
            return true;
        }

        [Test]
        public bool m3()
        {
            return false;
        }

        [Test]
        public bool m4()
        {
            return true;
        }
    }
}
