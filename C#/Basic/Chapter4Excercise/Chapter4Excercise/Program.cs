using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Puzzle4b[] obs = new Puzzle4b[6];
            int y = 1;
            int x = 0;
            int result = 0;
            while (x < 6) {
                obs[x] = new Puzzle4b();
                obs[x].ivar = y;
                y = y * 10;
                x++;
            }
            List
            while (x > 0) {
                x--;
                result = result + obs[x].DoStuff(x);
            }
            Console.WriteLine("Result is "+result);
            Console.ReadLine();
        }
        
    }

    class Puzzle4b {
        public int ivar;
        public int DoStuff(int factor) {
            if (ivar > 100) {
                return ivar * factor;
            } else{
                return ivar * (5 - factor);
            }
        }
    }
}
