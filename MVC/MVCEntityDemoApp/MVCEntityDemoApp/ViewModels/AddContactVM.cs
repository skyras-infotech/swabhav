using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCEntityDemoApp.Models;

namespace MVCEntityDemoApp.ViewModels
{
    public class AddContactVM
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}