using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeBasedMigrationDemoApp.Model;

namespace CodeBasedMigrationDemoApp
{
    class DemoDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
