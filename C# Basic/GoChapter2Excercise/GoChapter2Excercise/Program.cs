using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoChapter2Excercise
{
    class Program
    {
        int a;
        int b;
        static void Main(string[] args)
        {
            
            int x = 0;
            String Poem = "";
            while (x < 4)
            {
                Poem = Poem + "a";
                if (x < 1)
                {
                    Poem = Poem + " ";
                }
                Poem = Poem + "n";
                if (x > 1)
                {
                    Poem = Poem + " oyster";
                    x = x + 2;
                }
                if (x == 1)
                {
                    Poem = Poem + "noys ";
                }
                if (x < 1)
                {
                    Poem = Poem + "oise ";
                }
                x = x + 1;
            }
            Console.WriteLine(Poem);
        }
    }
}
