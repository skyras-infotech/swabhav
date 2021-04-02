using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEntityDemoApp.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
    }
}