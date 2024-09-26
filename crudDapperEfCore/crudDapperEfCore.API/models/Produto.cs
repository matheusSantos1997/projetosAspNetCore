using System.ComponentModel.DataAnnotations;

namespace crudDapperEfCore.API.models
{
    public class Produto
    {
        [Key]
        public long Id { get; set; }

        public string? NomeProduto { get; set; }

        public string? TipoProduto { get; set; }

        public decimal? Preco { get; set; }

        public long? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }
    }
}