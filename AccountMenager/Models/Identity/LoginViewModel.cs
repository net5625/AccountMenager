using System.ComponentModel.DataAnnotations;

namespace AccountMenager.Models.Identity
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Adres E-mail jest wymagany."),
        EmailAddress(ErrorMessage = "Proszę podać prawidłowy adres mailowy!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane."),
        DataType(DataType.Password,ErrorMessage = "Hasło nie przeszło walidacji!"),
        RegularExpression(@"^[A-Z][0-9A-Za-z.]{8,32}")]
        public string Password { get; set; }
    }
}
