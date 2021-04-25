using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ContactEFCoreApp.ModelDTO
{
    public class TenantDTO
    {
        [Required]
        public string TenantName { get; set; }
        public int CompanyStrength { get; set; }
    }
}
