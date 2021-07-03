using System;
using System.Collections.Generic;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int EventoId { get; set; }

        public string Local { get; set; }

        public DateTime? DataEvento { get; set; } // data pode ser nula

        public string Tema { get; set; }

        public int QtdPessoas { get; set; }

        public string ImagemURL { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public IEnumerable<Lote> Lotes { get; set; } // relacionamento 1:N

        public IEnumerable<RedeSocial> RedesSociais { get; set; } // relacionamento 1:N

        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; } // relacionamento N:N
    }
}
