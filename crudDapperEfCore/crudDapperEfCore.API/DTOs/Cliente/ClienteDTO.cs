using crudDapperEfCore.API.DTOs.Produto;
using Newtonsoft.Json;

namespace crudDapperEfCore.API.DTOs.Cliente
{
    public class ClienteDTO
    {
        public long Id { get; set; }

        public string NomeCliente { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public IList<ProdutoDTO> Produtos { get; set; }

        [JsonIgnore]
        public string NomesProdutos => string.Join(",", Produtos.Select(p => p.NomeProduto ?? string.Empty));
    }
}