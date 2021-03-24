using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerOrderOneToManyApp.Model
{
    [Table("tblCustomer")]
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long MobileNo { get; set; }
        public virtual List<Order> Orders { get; }

        public Customer() {
            Orders = new List<Order>();
        }
    }
}
