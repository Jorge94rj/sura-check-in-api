using System.ComponentModel.DataAnnotations;

namespace SuraCheckIn.API.Dtos
{
    public class UserRegisterDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password must have a lengt between 4 and 8 characters")]
        public string Password { get; set; }
    }

}