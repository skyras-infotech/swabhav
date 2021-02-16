using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISocializableApp.Model
{
    class Boy : IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }
    }
}
