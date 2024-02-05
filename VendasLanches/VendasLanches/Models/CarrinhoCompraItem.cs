using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches.Models
{
    #nullable disable
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
       [Key]
       public int CarrinhoCompraItemId { get; set; }  

       public Lanche Lanche { get; set; }

       public int Quantidade { get; set; }
       
       [StringLength(200)]
       public string CarrinhoCompraId { get; set; }      
    }
}