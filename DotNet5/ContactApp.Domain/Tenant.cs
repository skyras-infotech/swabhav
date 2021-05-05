using System.Collections.Generic;

namespace ContactApp.Domain
{
    public class Tenant : BaseEntity
    {
        public string TenantName { get; set; }
        public int CompanyStrength { get; set; }
        public List<User> Users { get; set; }

        public Tenant()
        {
            Users = new List<User>();
        }
    }
}
