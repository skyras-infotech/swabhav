using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactEFCoreApp.ModelDTO
{
    public class ContactDTO 
    { 
        [Required]
        public string Name { get; set; }
        [Required]
        public long MobileNumber { get; set; }
        public bool IsFavorite { get; set; }
    }
}
