using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Model
{
    class Robot : IWorkable
    {
        public void StartEat()
        {
           
        }

        public void StartWork()
        {
            Console.WriteLine("Robot start working");
        }

        public void StopEat()
        {
           
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stop working");
        }
    }
}
