using VendasLanches.Models;

namespace VendasLanches.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
