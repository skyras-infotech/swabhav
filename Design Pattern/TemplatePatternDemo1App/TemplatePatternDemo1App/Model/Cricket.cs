using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo1App.Model
{
    class Cricket : Game
    {
        public override void EndPlay()
        {
            Console.WriteLine("Cricket is finish");
        }

        public override void Initialize()
        {
            Console.WriteLine("Cricket Game, Initialize with toss");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Cricket is begin");
        }
    }
}
