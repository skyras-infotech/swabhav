using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactEFCoreApp.ModelDTO
{
    public class AddressDTO
    {
        [Required]
        public string City { get; set; }
    }
}
