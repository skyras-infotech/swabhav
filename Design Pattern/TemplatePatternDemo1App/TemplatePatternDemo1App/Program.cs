using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePatternDemo1App.Model;

namespace TemplatePatternDemo1App
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Cricket();
            game.Play();
            Console.WriteLine();
            game = new Football();
            game.Play();
        }
    }
}
