using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Domain
{
    public class Tenant
    {
        public Guid ID { get; set; }
        public string TenantName { get; set; }
        public List<User> Users { get; set; }

        public Tenant() 
        {
            Users = new List<User>();
        }
    }
}
