using System.ComponentModel.DataAnnotations;

namespace Clinic2104API.Model
{
    public class SignIn
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
