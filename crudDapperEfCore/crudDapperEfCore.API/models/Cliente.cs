using System.ComponentModel.DataAnnotations;

namespace crudDapperEfCore.API.models
{
    public class Cliente
    {
        [Key]
        public long Id { get; set; }

        public string? NomeCliente { get; set; }

        public string? Email { get; set; }

        public string? Endereco { get; set; }

        public IList<Produto>? Produtos { get; set; }
    }
}