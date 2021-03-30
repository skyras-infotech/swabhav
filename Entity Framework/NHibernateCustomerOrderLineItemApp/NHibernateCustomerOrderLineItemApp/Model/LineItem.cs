using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomerOrderLineItemApp.Model
{
    public class LineItem
    {
        public virtual int ID { get; set; }
        public virtual int Quantity { get; set; }
        public virtual Order Order { get; set; }
    }
}
