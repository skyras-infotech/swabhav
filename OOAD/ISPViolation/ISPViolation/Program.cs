using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolation.Model;

namespace ISPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorkable workable = new Manager();
            IWorkable workable1 = new Robot();
            workable.StartEat();
            workable.StopEat();
            workable.StartWork();
            workable.StopWork();
            workable1.StartWork();
            workable1.StopWork();
        }
    }
}
