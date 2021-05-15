using System;

namespace ApiClient.model
{
    public class ImagemNasa
    {
        public DateTime Data { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Url { get; set; }

        public string MediaType { get; set; }
    }
}