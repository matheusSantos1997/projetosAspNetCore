namespace crudDapperEfCore.DTOs.Produto
{
    public class CreateNewProdutoDTO
    {
        public string NomeProduto { get; set; }

        public string TipoProduto { get; set; }

        public decimal Preco { get; set; }
    }
}
