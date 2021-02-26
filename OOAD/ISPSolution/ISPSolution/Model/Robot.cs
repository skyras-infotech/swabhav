using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution.Model
{
    class Robot : IWorkable
    {
      
        public void StartWork()
        {
            Console.WriteLine("Robot start working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stop working");
        }
    }
}
