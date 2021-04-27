using System;
using System.Collections.Generic;

namespace ContactApp.Domain
{
    public class Contact : BaseEntity
    {
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public List<Address> Addresses { get; set; }
        public User User { get; set; }
        public Guid UserID { get; set; }
        public Contact() 
        {
            Addresses = new List<Address>();
        }
    }
}
