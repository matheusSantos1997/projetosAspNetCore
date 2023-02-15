using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaleriaImagens.Business.Models
{
    public class Imagem
    {
        [Key]
        public long Id { get; set; }
        
        [Column(TypeName = "varchar(200)")]
        public string Nome { get; set; }
         
        [Column(TypeName = "varchar(200)")]
        public string URLImagem { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? SavedAt { get; set; }

        public long? UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}