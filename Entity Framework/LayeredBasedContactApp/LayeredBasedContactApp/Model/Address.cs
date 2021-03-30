using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredBasedContactApp.Model
{
    [Table("tblAddress")]
    class Address
    {
        public int ID { get; set; }
        public string City { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
