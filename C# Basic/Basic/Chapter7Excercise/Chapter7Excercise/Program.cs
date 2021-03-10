using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7Excercise
{
    class Program
    {
        static void Main(string[] args) {
            Boat b1 = new Boat();
            SailBoat b2 = new SailBoat();
            RowBoat b3 = new RowBoat();
            b1.SetLength(32);
            b1.Move();
            b3.Move();
            b2.Move();
            Console.ReadLine();
        }
    }
    public class Boat {
        private int lenght;
        public void SetLength(int len) {
            lenght = len;
        }
        public int GetLength() {
            return lenght;
        }
        public void Move() {
            Console.Write("drift ");
        }
    }
    public class RowBoat : Boat {
        public void RowTheBoat() {
            Console.Write("Stoke natasha");
        }
    }
    public class SailBoat : Boat {
        public void Move() {
             Console.Write("hoist sail");
        }
    }
}
