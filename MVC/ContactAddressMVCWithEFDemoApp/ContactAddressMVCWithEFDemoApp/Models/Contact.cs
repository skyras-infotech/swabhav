using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAddressMVCWithEFDemoApp.Models
{
    [Table("tblContact")]
    public class Contact
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public List<Address> Addresses { get; set; }
   
        public Contact() 
        {
            Addresses = new List<Address>();
        }
    }
}
