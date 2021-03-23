using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp.Model
{
    class Emp
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public virtual Dept Dept { get; set; }
    }
}
