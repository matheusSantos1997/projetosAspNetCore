using System.Collections.Generic;

namespace ProAgil.Domain
{
    public class Palestrante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string MiniCurriculo { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string email { get; set; }
        public List<RedeSocial> RedesSociais { get; set; } // referencia com a entidade Rede Social
        public List<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}