namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string URL { get; set; }

        public int? EventoId { get; set; } // chave estrangeira de evento

        public Evento Evento { get; set; } // relacionamento 1:1

        public int? PalestranteId { get; set; } // chave estrangeira de Palestrante
      
        public Palestrante Palestrante { get; set; } // relacionamento 1:1 
    }
}
