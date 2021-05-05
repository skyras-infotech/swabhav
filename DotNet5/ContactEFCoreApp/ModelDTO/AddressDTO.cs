using System.ComponentModel.DataAnnotations;

namespace ContactEFCoreApp.ModelDTO
{
    public class AddressDTO
    {
        [Required]
        public string City { get; set; }
    }
}
