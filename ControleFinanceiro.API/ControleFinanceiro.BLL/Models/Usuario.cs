using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BLL.Models
{
    public class Usuario : IdentityUser<string>
    {
        public string CPF { get; set; }

        public string Profissao { get; set; }

        public byte[] Foto { get; set; }

        public virtual IEnumerable<Cartao> Cartoes { get; set; }

        public virtual IEnumerable<Ganho> Ganhos { get; set; }

        public virtual IEnumerable<Despesa> Despesas { get; set; }
    }
}
