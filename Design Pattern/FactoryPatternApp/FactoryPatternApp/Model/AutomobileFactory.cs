using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.Model
{
    class AutomobileFactory
    {
        public IAutomobile make(AutomobileType type) {
            IAutomobile automobile = null;
            if (type == AutomobileType.Audi)
            {
                automobile = new Audi();
            }
            else if (type == AutomobileType.BMW)
            {
                automobile = new BMW();
            }
            else if (type == AutomobileType.Tesla)
            {
                automobile = new Tesla();
            }
            else {
                Console.WriteLine("Sorry! there is no car having this name");
                return null;
            }
            return automobile;
        }
    }
}
