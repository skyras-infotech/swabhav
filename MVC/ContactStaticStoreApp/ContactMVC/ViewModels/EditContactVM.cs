using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ContactCore.Models;

namespace ContactMVC.ViewModels
{
    public class EditContactVM
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}