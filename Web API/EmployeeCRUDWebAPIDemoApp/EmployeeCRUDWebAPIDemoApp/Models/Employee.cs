using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeCRUDWebAPIDemoApp.Models
{
    public class Employee
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string Department { get; set; }
    }
}