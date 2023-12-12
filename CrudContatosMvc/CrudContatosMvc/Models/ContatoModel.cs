using System.ComponentModel.DataAnnotations;

namespace CrudContatosMvc.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do contato")]
        [EmailAddress(ErrorMessage = "O Email informado não é válido!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Digite o celular so contato")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string? Celular { get; set; }


    }
}
