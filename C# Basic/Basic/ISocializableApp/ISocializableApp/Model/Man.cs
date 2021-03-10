using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISocializableApp.Model
{
    class Man : ISocializable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Man is crying");
        }

        public void Laugh()
        {
            Console.WriteLine("Man is Laughing");
        }

        public void Depart()
        {
            Console.WriteLine("Man is departing");
        }

        public void Wish()
        {
            Console.WriteLine("Man is Wishing");
        }
    }
}
