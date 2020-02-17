using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebPlatformAPI.Angular.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="User or Password is invalid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User or Password is invalid.")]
        public string Password { get; set; }

        public string Token { get; set; }
    }
}
