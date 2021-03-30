using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomerOrderLineItemApp.Model
{
    public class Customer
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual long MobileNo { get; set; }
        public virtual IList<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
