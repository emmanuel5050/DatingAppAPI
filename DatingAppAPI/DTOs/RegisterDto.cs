using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace DatingAppAPI.DTOs
{
    public class RegisterDto
    { 
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
