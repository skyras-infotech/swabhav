using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDoListMVCApp.Models
{
    [Table("tblSubTasks")]
    public class SubTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        public string SubTaskName { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string Status { get; set; }
        public Guid TasksID { get; set; }
        public Tasks Tasks { get; set; }
    }
}