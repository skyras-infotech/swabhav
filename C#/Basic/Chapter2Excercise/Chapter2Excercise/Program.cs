using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Drumkit d = new Drumkit();
            d.PlayTopHat();
            d.PlaySnare();
            d.snare = false;
            if (d.snare == true) {
                d.PlaySnare();
            }
            Console.ReadLine();
        }
    }
    class Drumkit {
        public bool topHat = true;
        public Boolean snare = true;
        public void PlayTopHat() {
            Console.WriteLine("ding ding da-ding");
        }
        public void PlaySnare() {
            Console.WriteLine("bang bang ba-bang");
        }
    }
}
