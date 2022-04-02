using System.Collections.Generic;

namespace registerUsers.Models
{
    public class Usuario
    {
        public int IdUsuario {get; set;}

        public string Name { get; set; }

        public string Email {get; set; }

        public string Telefone {get; set; }

        public virtual IEnumerable<Conta> Contas { get; set; }
    }
}