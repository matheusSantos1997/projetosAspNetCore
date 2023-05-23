using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace testeArquivoPSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertPsdController : ControllerBase
    {
        [HttpPost]
        public IActionResult ConvertPsdToImage()
        {
            try
            {
                var file = Request.Form.Files[0];

                using(var stream = new MemoryStream())
                {
                    file.CopyTo(stream);
                    stream.Position = 0;

                    using(var image = new MagickImage(stream))
                    {
                        image.Format = MagickFormat.Png; // Define o formato da imagem de saída (PNG, JPEG, etc.)

                        // Salve a imagem em um local acessível pela web (por exemplo, em wwwroot) ou armazene-a em algum serviço de armazenamento (como o Azure Blob Storage)
                        string outputPath = "C:/images/converted.png";
                        image.Write(outputPath);

                        // Retorne a URL da imagem convertida para o cliente
                        string imageUrl = Url.Content("~/images/converted.png");
                        return Ok(new { imageUrl });
                    }
                }
            }
            catch (MagickException ex)
            {
                return BadRequest($"Erro ao converter o arquivo PSD: {ex.Message}");
            }
        }
    }
}
