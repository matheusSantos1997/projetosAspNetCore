using VendasLanches.Context;
using VendasLanches.Interfaces;
using VendasLanches.Models;

namespace VendasLanches.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly LanchesContext _appDbContext;

        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(LanchesContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;

            foreach(var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe
                {
                    Quantidade = carrinhoItem.Quantidade,
                    LancheId = carrinhoItem.Lanche.LancheId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Lanche.Preco
                };

                _appDbContext.PedidoDetalhes.Add(pedidoDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
