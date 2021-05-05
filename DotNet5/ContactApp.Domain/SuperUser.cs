namespace ContactApp.Domain
{
    public class SuperUser : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

    }
}
