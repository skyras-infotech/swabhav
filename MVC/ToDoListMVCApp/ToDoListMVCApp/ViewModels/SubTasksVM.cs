using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.ViewModels
{
    public class SubTasksVM
    {
        public SubTask SubTask { get; set; }
        public Guid TaskID { get; set; }
        public Guid UserID { get; set; }
    }
}