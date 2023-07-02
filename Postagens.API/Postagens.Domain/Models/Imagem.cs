using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Domain.Models
{
    public class Imagem
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }

        public string URLImagem { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? SalvoEm { get; set; }

        public long? PostId { get; set; }

        public Post Post { get; set; }
    }
}
