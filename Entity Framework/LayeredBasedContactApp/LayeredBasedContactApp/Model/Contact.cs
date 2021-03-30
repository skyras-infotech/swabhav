using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayeredBasedContactApp.Model
{
    [Table("tblContact")]
    class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public Contact() {
            Addresses = new List<Address>();
        }
    }
}
