using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Excercise
{
    interface Nose {
        int IMethod();
    }
    abstract class Picasso : Nose { 
        public int IMethod()
        {
            return 7;
        }
    }
    class Clows : Picasso { }
    class Acts : Picasso
    {
        public int IMethod()
        {
            return 5;
        }
    }
    class Program : Clows
    {
        static void Main(string[] args)
        {
            Nose[] i = new Nose[3];
            i[0] = new Acts();
            i[1] = new Clows();
            i[2] = new Program();
            for (int x = 0; x < 3; x++) {
                Console.WriteLine(i[x].IMethod());
            }
            Console.ReadLine();
        }
    }
}
