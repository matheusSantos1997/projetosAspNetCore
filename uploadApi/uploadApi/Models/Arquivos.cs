using System;

namespace uploadApi.Models
{
    public class Arquivos
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string URLImagem { get; set; }

        public DateTime? SavedAt { get; set; }
    }
}