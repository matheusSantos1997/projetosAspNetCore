using System.ComponentModel.DataAnnotations;

namespace CrudContatosMvc.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o login do usuário!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Senha { get; set; }
    }
}
