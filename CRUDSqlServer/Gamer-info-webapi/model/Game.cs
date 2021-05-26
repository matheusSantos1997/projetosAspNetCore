using System;
using System.Collections.Generic;

namespace Gamer_info_webapi.model
{
    public partial class Game
    {
        public int IdGame { get; set; }
        public string Nome { get; set; }
        public DateTime? DataLancamento { get; set; }
        public string Info { get; set; }
        public string Imagem { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
