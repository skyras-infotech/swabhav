﻿using System.ComponentModel.DataAnnotations;

namespace ContactEFCoreApp.ModelDTO
{
    public class SuperLoginDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
