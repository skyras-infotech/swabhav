using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCrudApp.Model;

namespace EFCrudApp
{
    class SwabhavDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}
