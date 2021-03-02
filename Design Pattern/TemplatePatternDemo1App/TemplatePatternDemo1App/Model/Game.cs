using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo1App.Model
{
    abstract class Game
    {
        public void Play() {
            Initialize();
            StartPlay();
            EndPlay();
        }
        abstract public void Initialize();
        abstract public void StartPlay();
        abstract public void EndPlay();
    }
}
