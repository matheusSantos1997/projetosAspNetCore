using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.Repository;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly ProAgilContext _context;

        public ValuesController(ProAgilContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get() //rota que vai retornar todos os resultados
        {
            try
            {
                var results = await _context.Eventos.ToListAsync(); 
                return Ok(results); //vai listar os registros do banco de dados
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
                //BadRequest();
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) //rota que vai retornar apenas um resultado por vez
        {
            try
            {
                var result = await _context.Eventos.FirstOrDefaultAsync(x => x.Id == id);
                return Ok(result);
            }
            catch(System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou");
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
