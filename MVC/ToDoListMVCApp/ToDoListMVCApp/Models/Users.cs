using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ToDoListMVCApp.Models;

namespace ToDoListMVCApp.Models
{
    [Table("tblUser")]
    public class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
        public List<Tasks> Tasks { get; set; }
        public Users() 
        {
            Tasks = new List<Tasks>();
        }
    }
}