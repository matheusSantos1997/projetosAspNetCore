using System;

namespace ProAgil.Domain
{
    public class Lote
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int quantidade { get; set; }
        public int EventoId { get; set; } // chave estrangeira da entidade Evento
        public Evento Evento { get; } // referencia o relacionamento com a entidade Evento
    }
}