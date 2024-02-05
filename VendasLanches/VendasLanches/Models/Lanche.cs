using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        
        #nullable disable
        [Required(ErrorMessage = "o nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "o {0} deve ter no mínimo {1} e no máximo {2}")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "o nome do lanche deve ser informado")]
        [Display(Name = "Descição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição pode exercer {1} caracteres")]
        public string DescricaoCurta { get; set; }
        
        [Required(ErrorMessage = "o nome do lanche deve ser informado")]
        [Display(Name = "Descição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exercer {1} caracteres")]
        public string DescricaoDetalhada { get; set; }
        
        #nullable disable
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10, 2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,999")]
        public decimal Preco { get; set; }
        
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }
        
        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }
        
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}