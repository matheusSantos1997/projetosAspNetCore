using System.ComponentModel.DataAnnotations;

namespace CadastroPessoa.Domain.Models
{
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }

        public required string NomeContato { get; set; }

        public required string Telefone { get; set; }

        public int? PessoaId { get; set; }

        public Pessoa? Pessoa{ get; set; }
    }
}