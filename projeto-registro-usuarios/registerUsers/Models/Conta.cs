namespace registerUsers.Models
{
    public class Conta
    {
        public int IdConta { get; set; }

        public string Agencia { get; set; }

        public string ContaCorrente { get; set; }

        public int? UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}