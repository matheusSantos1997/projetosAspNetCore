using System.ComponentModel.DataAnnotations;

namespace CadastroPessoa.Domain.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        public required string NomePessoa { get; set; }

        public required string Documento { get; set; }

        public required string Email { get; set; }

        public int? ContatoId { get; set; }

        public Contato? Contato { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}