using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postagens.Domain.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}
