using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactDynamicCore.Models;

namespace ContactDynamicMVC.ViewModels
{
    public class AllContactVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long MobileNumber { get; set; }
        public string Address { get; set; }
    }
}