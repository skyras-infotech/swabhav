using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp
{
    public class TaskDBContext : DbContext
    {
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
    }
}