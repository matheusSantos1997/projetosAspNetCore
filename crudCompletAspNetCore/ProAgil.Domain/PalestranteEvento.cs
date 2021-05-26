namespace ProAgil.Domain
{
    // classe de relacionamento N:N que relaciona os Eventos com palestrantes
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; } // chave primaria de palestrante
        public Palestrante Palestrante { get; set; }
        public int EventoId { get; set; } // chave primaria de evento
        public Evento Evento { get; set; }
    }
}