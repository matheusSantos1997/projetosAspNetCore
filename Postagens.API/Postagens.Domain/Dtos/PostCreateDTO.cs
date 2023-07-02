using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Postagens.Domain.Dtos
{
    public class PostCreateDTO
    {
        [JsonIgnore]
        [Key]
        public long Id { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public long? UsuarioId { get; set; }
    }
}
