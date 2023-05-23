using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private readonly FilmeContext _context;

        private readonly IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context= context;
            _mapper= mapper;
        }


        [HttpGet]
        public IActionResult MostrarFilmes([FromQuery]int skip = 0, [FromQuery]int take = 50)
        {
            var resultado = _context.Filmes.Skip(skip).Take(take);
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public IActionResult MostrarFilmePorId(int id)
        {
            var filme = _context.Filmes.Where(x => x.Id == id).FirstOrDefault();
            if(filme == null) return NotFound();
            return Ok(filme);
        }

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreateFilmeDTO filmeDTO)
        {
            /*  Filme filme = new Filme
              {
                  Titulo = filmeDTO.Titulo,
                  Genero = filmeDTO.Genero,
                  Duracao = filmeDTO.Duracao,
              }; */
            var filme = _mapper.Map<Filme>(filmeDTO);

            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(MostrarFilmePorId), new { id = filme.Id}, filme);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFilme(int id, [FromBody]UpdateFilmeDTO filmeDTO)
        {
            var filme = _context.Filmes.Where(x => x.Id == id).FirstOrDefault();

            if(filme == null) return NotFound();

            _mapper.Map(filmeDTO, filme);

            _context.Update(filme);

            _context.SaveChanges();

            return Ok(filme);


        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirFilme(int id)
        {
            var filme = _context.Filmes.Where(x => x.Id == id).FirstOrDefault();

            if(filme == null) return NotFound();

            _context.Filmes.Remove(filme);

            return NoContent();
        }
    }
}
