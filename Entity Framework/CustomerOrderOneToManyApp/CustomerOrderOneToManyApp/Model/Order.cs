using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderOneToManyApp.Model
{
    [Table("tblOrder")]
    class Order
    {
        [Key]
        public int OID { get; set; }
        public string OrderName { get; set; }
        public double Price { get; set; }
        public virtual Customer Customer { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
