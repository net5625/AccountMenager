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
        RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,32}$", ErrorMessage = "Podane hasło jest nieprawidłowe")]
        public string Password { get; set; }
    }
}
