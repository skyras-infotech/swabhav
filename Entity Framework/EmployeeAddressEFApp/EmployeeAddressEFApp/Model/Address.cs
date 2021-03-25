using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAddressEFApp.Model
{
    [Table("tblAddress")]
    class Address
    {
        [Key]
        public int AID { get; set; }
        public string City { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
