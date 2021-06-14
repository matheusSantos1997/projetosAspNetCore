using System;
using System.Collections.Generic;
using System.Text;

namespace ProEventos.Domain
{
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; }

        public Palestrante Palestrante { get; set; } 
        
        public int EventoId { get; set; }

        public Evento Evento { get; set; }
    }
}
