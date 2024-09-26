using crudDapperEfCore.API.DTOs.Produto;

namespace crudDapperEfCore.API.DTOs.Cliente
{
    public class CreateNewClienteDTO
    {
        public string NomeCliente { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public IList<CreateNewProdutoDTO> Produtos { get; set; }
    }
}