using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ApiClient.model
{
    public class APINasaClient
    {
        private HttpClient _client;
        private IConfiguration _configuration;

        public APINasaClient(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            _configuration = configuration;
        }

        public ImagemNasa ObterDadosImagem()
        {
            DateTime dataBase = DateTime.Now.Date.AddDays(
                new Random().Next(0, 7) * -1);

            string baseURL =
                _configuration.GetSection("NASA_OpenAPIs:BaseURL").Value;
            string key =
                _configuration.GetSection("NASA_OpenAPIs:Key").Value;
            var response = _client.GetAsync(
                baseURL + $"apod?api_key={key}" +
                $"&date={dataBase.ToString("yyyy-MM-dd")}").Result;

            response.EnsureSuccessStatusCode();
            string conteudo =
                response.Content.ReadAsStringAsync().Result;
            dynamic resultado =
                JsonConvert.DeserializeObject(conteudo);

            ImagemNasa imagem = new ImagemNasa();
            imagem.Data = dataBase;
            imagem.Titulo = resultado.title;
            imagem.Descricao = resultado.explanation;
            imagem.Url = resultado.url;
            imagem.MediaType = resultado.media_type;

            return imagem;
        }
    }
}