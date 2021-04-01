using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LoginDemoApp.Models
{
    public class Employee
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}