using System;
using System.Collections.Generic;

namespace ContactApp.Domain
{
    public class Contact
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public List<Address> Addresses { get; set; }
        public Contact() 
        {
            Addresses = new List<Address>();
        }
    }
}
