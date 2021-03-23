using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using SimpleEntityFrameworkDemoApp.Model;

namespace SimpleEntityFrameworkDemoApp
{
    class DemoDBContext : DbContext
    {
        public DemoDBContext() { 
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
