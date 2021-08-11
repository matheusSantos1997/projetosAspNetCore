using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Tipo
    {
        [Key]
        public int TipoId { get; set; }

        public string Nome { get; set; }

        public virtual IEnumerable<Categoria> Categorias { get; set; } // muitas categorias
    }
}
