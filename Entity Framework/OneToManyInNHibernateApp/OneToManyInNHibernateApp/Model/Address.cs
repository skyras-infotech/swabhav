using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyInNHibernateApp.Model
{
    class Address
    {
        public virtual int ID { get; set; }
        public virtual string City { get; set; }
        public virtual Employee Employees { get; set; }

    }
}
