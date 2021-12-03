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
        RegularExpression(@"^[A-Z][0-9A-Za-z.]{8,32}")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Powtórne podanie hasła jest konieczne."),
        Compare(nameof(Password),ErrorMessage = "Hasła nie są identyczne.")] //TODO: Hasła nie są identyczne - podczas gdy fizycznie są
        public string ConfirmPassword { get; set; }
    }
}
