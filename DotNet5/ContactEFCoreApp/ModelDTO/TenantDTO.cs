using System.ComponentModel.DataAnnotations;


namespace ContactEFCoreApp.ModelDTO
{
    public class TenantDTO
    {
        [Required]
        public string TenantName { get; set; }
        public int CompanyStrength { get; set; }
    }
}
