using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.ViewModels
{
    public class TasksVM
    {
        public Guid ID { get; set; }
        [Required]
        public string TaskName { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string Status { get; set; }
        public Guid UserID { get; set; }
    }

    public enum Status
    {
        Pending,
        Complete
    }
}