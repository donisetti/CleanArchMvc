using System.ComponentModel.DataAnnotations;

namespace Vasis.Gestor.WebUI.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O Email é obrigatório")]
        [EmailAddress(ErrorMessage = "formato o")]

        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max " +
            "{1} characters long.", MinimumLength = 10)]
        [DataType(DataType.Password)]

        [Display(Name = "Senha")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
