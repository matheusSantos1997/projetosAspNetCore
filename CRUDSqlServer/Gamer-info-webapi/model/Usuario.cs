using System;
using System.Collections.Generic;

namespace Gamer_info_webapi.model
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public int? IdGame { get; set; }
        public virtual Game IdGameNavigation { get; set; }
    }
}
