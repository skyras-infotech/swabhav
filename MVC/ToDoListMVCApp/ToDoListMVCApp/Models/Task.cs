using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListMVCApp.Models
{
    [Table("tblTasks")]
    public class Tasks
    {
        public int ID { get; set; }
        public string TaskName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public List<SubTask> SubTasks { get; set; }
        public Tasks() 
        {
            SubTasks = new List<SubTask>();
        }
    }
}
