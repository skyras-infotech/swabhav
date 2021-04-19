using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Domain
{
    public class User
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Contact> Contacts { get; set; }
        public Tenant Tenant { get; set; }
        public Guid TenantID { get; set; }

        public User() 
        {
            Contacts = new List<Contact>();
        }
    }
}
