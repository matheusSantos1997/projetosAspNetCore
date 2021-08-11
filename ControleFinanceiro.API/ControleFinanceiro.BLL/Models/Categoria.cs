using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        public string Nome { get; set; }

        public string Icone { get; set; }

        public int? TipoId { get; set; }

        public Tipo Tipo { get; set; }  

        public virtual IEnumerable<Despesa> Despesas { get; set; }

        public virtual IEnumerable<Ganho> Ganhos { get; set; }

    }
}
