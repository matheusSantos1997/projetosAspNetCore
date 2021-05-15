using System.Collections.Generic;

namespace EFDomain
{
    public class Heroi
    {
        public int Id { get; set; }

        public string nome { get; set; }

        public IdentidadeSecreta Identidade { get; set; }

        public List<Arma> Armas { get; set; }

        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}