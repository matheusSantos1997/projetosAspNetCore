using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        
        #nullable disable
        [StringLength(100, ErrorMessage = "o tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }
        
        [StringLength(100, ErrorMessage = "o tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}