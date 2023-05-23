using System.ComponentModel.DataAnnotations;

namespace Pensamentos.Models
{
    public class Pensamento
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Conteudo { get; set; }

        [Required]
        public string? Autoria { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public bool Favorito { get; set; }
    }
}
