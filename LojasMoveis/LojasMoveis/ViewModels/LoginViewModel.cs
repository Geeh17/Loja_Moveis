using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LojasMoveis.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; } = string.Empty;

        public string? ReturnUrl { get; set; }
    }
}
