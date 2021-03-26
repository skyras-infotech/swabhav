using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyInNHibernateApp.Model
{
    class Employee
    {
        public virtual int ID { get; set; }
        public virtual string EmpName { get; set; }
        public virtual string Job { get; set; }
        public virtual double Salary { get; set; }
        public virtual IList<Address> Addresses { get; set; }

        public Employee() {
            Addresses = new List<Address>();
        }
        
    }
}
