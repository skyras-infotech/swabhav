using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISocializableApp.Model;

namespace ISocializableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();
            PrintInfo(man);
           
        }
        public static void PrintInfo(Man obj) {
            obj.Cry();
            obj.Depart();
            obj.Laugh();
            obj.Wish();
           /* if (obj is ISocializable)
            {
                ISocializable socializable = (ISocializable)obj;
                socializable.Depart();
                socializable.Wish();
            }
            else if (obj is IEmotionable)
            {
                IEmotionable emotionable = (IEmotionable)obj;
                emotionable.Cry();
                emotionable.Laugh();
            }*/
        }
    }
}
