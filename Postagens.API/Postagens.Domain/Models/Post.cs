using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Domain.Models
{
    public class Post
    {
        [Key]
        public long Id { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public long? UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        public Imagem Imagem { get; set; }

    }
}
