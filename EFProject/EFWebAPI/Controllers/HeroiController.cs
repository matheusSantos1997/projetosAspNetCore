using System;
using System.Threading.Tasks;
using EFDomain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {
        private readonly IEFRepository _context;
        public HeroiController(IEFRepository context)
        {
            _context = context;
        }
        
        // retornando todos os herois
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var herois = await _context.GetAllHeroiAsync(true);
                return Ok(herois);
            }
            catch(System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
            }
        }

        // retornando por id 
        [HttpGet("{HeroiId}")]
        public async Task<IActionResult> Get(int HeroiId)
        {
            try
            {
                var heroi = await _context.GetHeroiAsyncById(HeroiId, true);

                return Ok(heroi);
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }
        }

        // retornando por nome
        [HttpGet("getByName/{name}")]
        public async Task<IActionResult> Get(string name)
        {
            try 
            {
                var heroi = await _context.GetAllHeroiAsyncByName(name, true);

                return Ok(heroi);
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }
        }

        // inserindo novo registro
        [HttpPost]
        public async Task<IActionResult> Post(Heroi model)
        {
            try
            {
               _context.Add(model);

               if (await _context.SaveChangesAsync())
               {
                   return Created($"/api/heroi/{model.Id}", model);
               }
            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
            }

            return BadRequest();
        }

        // atualizando registro existente
        [HttpPut("{HeroiId}")]
        public async Task<IActionResult> Put(int HeroiId, Heroi model)
        {
            try
            {
                var heroi = await _context.GetHeroiAsyncById(HeroiId, false);

                // verificaçao se caso nao foi encontrado algum heroipara ser editado
                if (heroi == null)
                {
                    return NotFound();
                }

                _context.Update(model);

                 if (await _context.SaveChangesAsync())
                {
                    return Created($"/api/heroi/{model.Id}", model);
                }

            }
            catch(System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!" + ex.Message);
            }

            return BadRequest();
            
        }

        [HttpDelete("{HeroiId}")]
        public async Task<IActionResult> Delete(int HeroiId)
        {
            try
            {
                var heroi = await _context.GetHeroiAsyncById(HeroiId, false);

                if (heroi == null)
                {
                     return NotFound();
                }

                _context.Delete(heroi);

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