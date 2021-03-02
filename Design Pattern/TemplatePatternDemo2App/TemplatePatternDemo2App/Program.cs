using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePatternDemo2App.Model;

namespace TemplatePatternDemo2App
{
    class Program
    {
        static void Main(string[] args)
        {
            University mu = new MU();
            mu.StartProcess();
            Console.WriteLine();
            mu = new GTU();
            mu.StartProcess();
        }
    }
}
