using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaleriaImagens.Business.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string Nome { get; set; }
        
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }
        
        [Column(TypeName = "varchar(14)")]
        public string CPF { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string Profissao { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string NomeUsuario { get; set; }
        
        [Column(TypeName = "varchar(255)")]
        public string Senha { get; set; }

        public virtual IEnumerable<Imagem> Imagens { get; set; }
    }
}