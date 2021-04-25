using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepoDemoApp
{
    public class WorkerDBContext : DbContext
    {
        public WorkerDBContext(DbContextOptions<WorkerDBContext> options) : base(options)
        {
        }
        public DbSet<Worker> Workers { get; set; }
    }
}
