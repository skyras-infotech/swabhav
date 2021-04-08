using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactAddressMVCWithEFDemoApp.Models
{
    [Table("tblAddress")]
    public class Address
    {
        public int ID { get; set; }
        [Required]
        public string City { get; set; }
        public int ContactID { get; set; }
        public Contact Contact { get; set; }
    }
}