namespace crudDapperEfCore.DTOs.Produto
{
    public class UpdateProdutoDTO
    {
        public long Id { get; set; }

        public string NomeProduto { get; set; }

        public string TipoProduto { get; set; }

        public decimal Preco { get; set; }

        public long? ClienteId { get; set; }
    }
}
