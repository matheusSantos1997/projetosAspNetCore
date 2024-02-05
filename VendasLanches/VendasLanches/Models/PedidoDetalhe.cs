using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches.Models
{
    #nullable disable
    public class PedidoDetalhe
    {
        [Key]
        public int PedidoDetalhaId { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public virtual Lanche Lanche { get; set; }
        public int LancheId { get; set; }

        public virtual Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}