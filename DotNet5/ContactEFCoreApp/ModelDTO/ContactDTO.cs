using System.ComponentModel.DataAnnotations;

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
