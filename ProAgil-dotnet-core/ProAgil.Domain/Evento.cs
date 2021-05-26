using System;
using System.Collections.Generic;

namespace ProAgil.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemUrl { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Lote> Lotes { get; set; } // relaciona com a classe lote
        public List<RedeSocial> RedesSociais { get; set; } // relaciona com a classe redeSocial

        //referencia o relacionamento entre palestrantes na entidade PalestranteEvento
        public List<PalestranteEvento> PalestrantesEventos { get; set; } 

    }
}