using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.ViewModels
{
    public class AllSubTasksVM
    {
        public List<SubTask> SubTasks { get; set; }
        public int TaskID { get; set; }
    }
}