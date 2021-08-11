using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Mes
    {
        [Key]
        public int MesId { get; set; }

        public string Nome { get; set; }

        public virtual IEnumerable<Ganho> Ganhos { get; set; }

        public virtual IEnumerable<Despesa> Despesas { get; set; }
    }
}
