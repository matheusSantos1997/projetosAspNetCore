using System.ComponentModel.DataAnnotations;

namespace CrudContatosMvc.Models
{
    public class RedefinirSenhaModel
    {
        [Required(ErrorMessage = "Digite o login do usuário!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O Email informado não é válido!")]
        public string Email { get; set; }
    }
}
