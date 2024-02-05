using Microsoft.EntityFrameworkCore;
using VendasLanches.Context;

namespace VendasLanches.Models
{
    #nullable disable
    public class CarrinhoCompra
    {
        private readonly LanchesContext _context;

        public CarrinhoCompra(LanchesContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }

        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            // define a sessao
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um serviço do tipo do nosso contexto
            var context = services.GetService<LanchesContext>();

            // obtem ou gera o Id do Carrinho
            string carrinhoId = session.GetString("carrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("carrinhoId", carrinhoId);

            // retorna o carrinho com o contexto  e o Id atribuido ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId && 
                s.CarrinhoCompraId == CarrinhoCompraId);
            
            if(carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                   CarrinhoCompraId = CarrinhoCompraId,
                   Lanche = lanche,
                   Quantidade = 1
                };

                _context.CarrinhoCompraItems.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }

            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(
                s => s.Lanche.LancheId == lanche.LancheId && 
                s.CarrinhoCompraId == CarrinhoCompraId);

            var quantidadeLocal = 0;

            if(carrinhoCompraItem != null)
            {
                if(carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    quantidadeLocal = carrinhoCompraItem.Quantidade;
                }
                else
                {
                    _context.CarrinhoCompraItems.Remove(carrinhoCompraItem);
                }
            }
            _context.SaveChanges();

            return quantidadeLocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            var compraItems = CarrinhoCompraItems ?? (
                CarrinhoCompraItems = _context.CarrinhoCompraItems
                                              .Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                                              .Include(s => s.Lanche)
                                              .ToList());
            return compraItems;
        }

        public void LimparCarrinho()
        {
            var carrinhoItems = _context.CarrinhoCompraItems.Where(carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItems.RemoveRange(carrinhoItems);

            _context.SaveChanges();
        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoCompraItems.Where(c => c.CarrinhoCompraId == CarrinhoCompraId)
                                                    .Select(c => c.Lanche.Preco * c.Quantidade).Sum();
            
            return total;
        }
    }
}