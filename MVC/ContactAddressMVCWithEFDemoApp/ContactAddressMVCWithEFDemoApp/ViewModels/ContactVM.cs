using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.ViewModels
{
    public class ContactVM
    {
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }
}