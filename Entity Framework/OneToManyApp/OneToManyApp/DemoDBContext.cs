using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using OneToManyApp.Model;

namespace OneToManyApp
{
    class DemoDBContext : DbContext
    {
        public DbSet<Emp> Employees { get; set; }
        public DbSet<Dept> Departments { get; set; }
    }
}
