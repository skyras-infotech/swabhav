using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPSolution.Model;

namespace ISPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            Robot robot = new Robot();
            manager.StartEat();
            manager.StopEat();
            manager.StartWork();
            manager.StopWork();
            robot.StartWork();
            robot.StopWork();
        }
    }
}
