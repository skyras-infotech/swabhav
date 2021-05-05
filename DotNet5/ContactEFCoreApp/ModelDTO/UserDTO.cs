using System.ComponentModel.DataAnnotations;

namespace ContactEFCoreApp.ModelDTO
{
    public class UserDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
