using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Domain
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
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
