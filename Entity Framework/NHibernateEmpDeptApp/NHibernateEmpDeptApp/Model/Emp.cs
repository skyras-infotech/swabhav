using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateEmpDeptApp.Model
{
    public class Emp
    {
        public virtual int ID { get; set; }
        public virtual string EmpName { get; set; }
        public virtual double Salary { get; set; }
        public virtual string Job { get; set; }
        public virtual Dept Dept { get; set; }
    }
}
