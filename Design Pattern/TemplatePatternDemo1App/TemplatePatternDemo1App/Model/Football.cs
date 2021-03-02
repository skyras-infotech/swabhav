using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo1App.Model
{
    class Football : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Football is finish");
        }

        public override void Initialize()
        {
            Console.WriteLine("Football Game, Initialize with toss");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football is begin");
        }
    }
}
