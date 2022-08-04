using System.ComponentModel.DataAnnotations.Schema;

namespace GaleriaImagens.Business.ViewModels
{
    public class UsuarioLogin
    {
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string Senha { get; set; }
    }
}