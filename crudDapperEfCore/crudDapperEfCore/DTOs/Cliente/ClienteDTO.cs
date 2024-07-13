using System.Collections.Generic;
using crudDapperEfCore.DTOs.Produto;

namespace crudDapperEfCore.DTOs.Cliente
{
    public class ClienteDTO
    {
        public long Id { get; set; }

        public string NomeCliente { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; }

        public IList<ProdutoDTO> Produtos { get; set; }
    }
}
