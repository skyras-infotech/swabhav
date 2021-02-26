using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation.Model
{
    class Manager : IWorkable
    {
        public void StartEat()
        {
            Console.WriteLine("Manager start eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager start working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager stop eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager stop working");
        }
    }
}
