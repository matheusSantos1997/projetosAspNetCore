using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroPessoa.Domain.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        public required string NomeProduto { get; set; }

        public required string TipoProduto { get; set; }

        public required string Preco { get; set; }
        
        public int? PessoaId { get; set; }

        public Pessoa? Pessoa { get; set; }
    }
}