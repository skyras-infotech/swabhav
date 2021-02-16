using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes.Model
{
    [NeedToFactor]
    class Foo
    {
        [NeedToFactor]
        public void m1() {
            Console.WriteLine("Inside m1");
        }

        public void m2()
        {
            Console.WriteLine("Inside m2");
        }

        [NeedToFactor]
        public void m3()
        {
            Console.WriteLine("Inside m3");
        }

        [NeedToFactor]
        public void m4()
        {
            Console.WriteLine("Inside m4");
        }
    }
}
