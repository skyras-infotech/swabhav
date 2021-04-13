using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ContactDynamicCore.Models;

namespace ContactDynamicMVC.ViewModels
{
    public class AddContactVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}