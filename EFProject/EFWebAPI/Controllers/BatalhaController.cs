using System.Threading.Tasks;
using EFDomain;
using EFRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatalhaController : ControllerBase
    {
        private readonly IEFRepository _context;

        public BatalhaController(IEFRepository context)
        {
            _context = context;
        }

        [HttpGet("{BatalhaId}")]
        public async Task<IActionResult> Get(int BatalhaId)
        {
            try
            {
                var batalha = await _context.GetBatalhaAsync(BatalhaId, true);

                return Ok(batalha);
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }
        }

        [HttpGet("getByName/{nameBatalha}")]
        public async Task<IActionResult> Get(string nameBatalha)
        {
            try
            {
                 var batalha = await _context.GetAllBatalhaAsyncByName(nameBatalha, true);

                 return Ok(batalha);
            }
            catch(System.Exception)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Batalha model)
        {
            try
            {
                _context.Add(model);

                if(await _context.SaveChangesAsync())
                {
                     return Created($"/api/batalha/{model.Id}", model);
                }

            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
            }

            return BadRequest();
        }

        [HttpPut("BatalhaId")]
        public async Task<IActionResult> Put(int BatalhaId, Batalha model)
        {
             try
             {
                 var batalha = await _context.GetBatalhaAsync(BatalhaId, false);

                 if (batalha == null)
                 {
                     return NotFound();
                 }

                 _context.Update(model);

                 if(await _context.SaveChangesAsync())
                 {
                     return Created($"/api/batalha/{model.Id}", model);
                 }
             }
             catch(System.Exception ex)
             {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!" + ex.Message);
             }

             return BadRequest();
        }
        [HttpDelete("{BatalhaId}")]
        public async Task<IActionResult> Delete(int BatalhaId)
        {
            try
            {
                var batalha = await _context.GetBatalhaAsync(BatalhaId, false);

                if (batalha == null)
                {
                    return NotFound();
                }

                _context.Delete(batalha);

                if (await _context.SaveChangesAsync())
                {
                    return Ok();
                }
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }

            return BadRequest();
        } 
    }
}