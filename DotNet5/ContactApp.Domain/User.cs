using System;
using System.Collections.Generic;

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
        public Guid TenantId { get; set; }

        public User()
        {
            Contacts = new List<Contact>();
        }
    }
}
