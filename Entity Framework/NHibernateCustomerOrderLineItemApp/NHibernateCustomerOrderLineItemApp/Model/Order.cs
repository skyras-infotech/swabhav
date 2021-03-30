using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomerOrderLineItemApp.Model
{
    public class Order
    {
        public virtual int ID { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual IList<LineItem> LineItems { get; set; }

        public Order() {
            LineItems = new List<LineItem>();
        }
    }
}
