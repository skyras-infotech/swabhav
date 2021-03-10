using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorBehaveInheritanceApp
{

    //Single Level Inheritance
    class Parent
    {
        private int number;

        public Parent(int number)
        {
            this.number = number;
        }
        public int Number
        {
            get { return number; }

        }
    }
}

