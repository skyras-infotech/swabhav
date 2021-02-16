using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man();
            Kid k = new Kid();
            Boy b = new Boy();
            Infant i = new Infant();
            /*
                        case1();
                        Console.WriteLine();
                        case2();
                        Console.WriteLine();
                        case3();
                        Console.WriteLine();
                        case4();
            */
            try {
                Man m1 = new Boy();
                m1.Play();
                Boy b1;
                b1 = (Boy)m1;
                b1.Eat();
                
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine(k is Man);
            Console.WriteLine(b is Man);
            Console.WriteLine(i is Man);
        }

        static void case4()
        {
            Object x;
            x = 4;
            Console.WriteLine(x.GetType());
            x = "String";
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
        }

        static void case1() {
            Man m = new Man();
            m.Play();
            m.Read();
        }

        static void case2() {
            Boy b = new Boy();
            b.Play();
            b.Read();
            b.Eat();
        }

        static void case3() {
            Man m = new Boy();
            m.Play();
            m.Read();
            
        }
    }
}
