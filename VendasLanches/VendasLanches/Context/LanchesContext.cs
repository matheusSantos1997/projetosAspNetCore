using Microsoft.EntityFrameworkCore;
using VendasLanches.Models;

namespace VendasLanches.Context
{
    public class LanchesContext : DbContext
    {
        #nullable disable
        public LanchesContext(DbContextOptions<LanchesContext> options) : base(options){}

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}