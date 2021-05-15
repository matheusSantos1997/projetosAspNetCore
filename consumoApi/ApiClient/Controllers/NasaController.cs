using System;
using System.Net.Http;
using ApiClient.model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NasaController : ControllerBase
    {
        public IActionResult OnGet([FromServices]APINasaClient client)
        {
            var result = client.ObterDadosImagem();

            return Ok(result);
        }
    }
}