using Microsoft.AspNetCore.Mvc;

namespace CadastroPessoa.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("GetEndpointTest")]
        public IActionResult Get()
        {
            string text = "Deu certo";

            return Ok(text); 
        }
    }
}