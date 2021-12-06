using System.ComponentModel.DataAnnotations;

namespace AccountMenager.Models.Identity
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "E-mail jest wymagany."),
        EmailAddress(ErrorMessage = "Proszę podać poprawny adres mailowy!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane!"),
        DataType(DataType.Password, ErrorMessage = "Hasło nie przeszło walidacji!"),
        RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[#$^+=!*()@%&]).{8,32}$", ErrorMessage ="Wymagana minimum jedna duża litera, minimum jedna cyfra, minium jeden znak specjalny; minimalna długość hasła to 8 znaków, maksymalna 32.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Powtórne podanie hasła jest konieczne."),
        DataType(DataType.Password, ErrorMessage = "Hasło nie przeszło walidacji!"),
        Compare(nameof(Password),ErrorMessage = "Hasła nie są identyczne.")]
        public string ConfirmPassword { get; set; }
    }
}
