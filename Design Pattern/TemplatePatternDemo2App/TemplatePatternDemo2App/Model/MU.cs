using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo2App.Model
{
    class MU : University
    {
        public override void FeePayment()
        {
            Console.WriteLine("Pay fees at the Mumbai university");
        }

        public override void FillForm()
        {
            Console.WriteLine("For admission, Fill the form");
        }

        public override void GetList()
        {
            Console.WriteLine("After admission, selected student list display here");
        }
    }
}
