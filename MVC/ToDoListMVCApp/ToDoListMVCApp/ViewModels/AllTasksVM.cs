using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.ViewModels
{
    public class AllTasksVM
    {
        public List<Tasks> Tasks { get; set; }
        public Guid UserID { get; set; }
     
    }
}