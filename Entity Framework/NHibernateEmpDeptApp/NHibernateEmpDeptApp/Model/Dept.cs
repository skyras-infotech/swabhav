using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateEmpDeptApp.Model
{
    public class Dept
    {
         public virtual int ID { get; set; }
         public virtual string DeptName { get; set; }
         public virtual string Location { get; set; }
         public virtual IList<Emp> DeptEmployees { get; set; }

        public Dept()
        {
            DeptEmployees = new List<Emp>();
        }
    }
}
