namespace EFDomain
{
    public class Arma
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Heroi Heroi { get; }

        public int HeroiId { get; set; }
    }
}