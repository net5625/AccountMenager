using System.ComponentModel.DataAnnotations;

namespace AccountMenager.Models.Identity
{
    public class LoginViewModel
    {
        [Required,
        EmailAddress]
        public string Email { get; set; }
        [Required,
        DataType(DataType.Password,ErrorMessage = "Hasło nie przeszło walidacji!"),
        RegularExpression(@"^[A-Z][0-9A-Za-z.]{8,32}")]
        public string Password { get; set; }
    }
}
