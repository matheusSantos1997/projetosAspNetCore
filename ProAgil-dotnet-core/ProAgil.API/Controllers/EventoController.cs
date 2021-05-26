using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.Dtos;
using ProAgil.Domain;
using ProAgil.Repository;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private readonly IProAgilRepository _repository; // injetando por meio da interface o repositorio
        private readonly IMapper _mapper; // injetando por meio da interface o autoMapper

        public EventoController(IProAgilRepository repository, IMapper mapper) // IMapper é injetado em EventoController
        {
            _mapper = mapper;
            _repository = repository;
        }

        //RETURNING ALL DATAS

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get() //rota que vai retornar todos os resultados
        {
            try
            {
                var eventos = await _repository.GetAllEventoAsync(true);
                var results = _mapper.Map<EventoDto[]>(eventos);
                return Ok(results); //vai listar os registros do banco de dados

            }
            catch (System.Exception ex)
            {
                 return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
                //BadRequest();
                
            }
            

        }

        // upload de imagens
        [HttpPost("upload")]
        public async Task<IActionResult> upload() //rota que vai retornar todos os resultados
        {
            try
            {
                var file = Request.Form.Files[0]; // pega o arquivo escolhido 
                var folderName = Path.Combine("Resources", "Images"); // pega o diretorio onde vai salvar
                // combina o diretorio onde vai armazerar + diretorio da aplicaçao
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName); // salva no diretorio

                // varificação se o arquivo existir no diretório
                if (file.Length > 0)
                {
                    // vai pegar o nome do arquivo e montar o arquivo
                    var filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName;

                    // se vier aspas duplas ou espaçamentos no nome do arquivo, vai ser removido
                    var fullPath = Path.Combine(pathToSave, filename.Replace("\"", " ").Trim());

                    using (var stream = new FileStream(fullPath, FileMode.Create)) // salva o arquivo
                    {
                        await file.CopyToAsync(stream); // realiza uma copia para o stream
                    }
                }

                return Ok();
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
                //BadRequest();
            }

        }

        //Retornando um evento que tiver aquele Id especifico

        [HttpGet("{EventoId}")]
        public async Task<IActionResult> Get(int EventoId) //rota que vai retornar todos os resultados
        {
            try
            {
                var evento = await _repository.GetEventoAsyncById(EventoId, true);

                var results = _mapper.Map<EventoDto>(evento);

                return Ok(results); //vai listar os registros do banco de dados
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
                //BadRequest();
            }

        }

        //vai retornar um lista de todos os Eventos de um determinado tema diferente
        [HttpGet("getByTema/{tema}")]
        public async Task<IActionResult> Get(string tema) //rota que vai retornar todos os resultados
        {
            try
            {
                var eventos = await _repository.GetAllEventoAsyncByTema(tema, true);

                var results = _mapper.Map<EventoDto[]>(eventos);

                return Ok(results); //vai listar os registros do banco de dados
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
                //BadRequest();
            }

        }

        //cadastra novos Eventos 
        [HttpPost]
        public async Task<IActionResult> Post(EventoDto model) //rota que vai retornar todos os resultados
        {
            // recebe o eventoDTO e faz o mapeamento na classe principal Evento = reverseMap
            try
            {
                var evento = _mapper.Map<Evento>(model);

                _repository.Add(evento);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/evento/{model.Id}", _mapper.Map<EventoDto>(evento));
                }

            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de dados Falhou! {ex.Message}");
            }

            // caso nao retorne alguma exceçao
            return BadRequest();

        }

        // atualiza os Eventos cadastrados
        [HttpPut("{EventoId}")]
        public async Task<IActionResult> Put(int EventoId, EventoDto model) //rota que vai retornar todos os resultados
        {
            try
            {       
                // caso o Id passado por parametro nao encontrar um elemento cadastrado
                var evento = await _repository.GetEventoAsyncById(EventoId, false);
                
                if (evento == null) return NotFound(); //nao vai encontrar

                var idLotes = new List<int>();
                var idRedesSociais = new List<int>();

                model.Lotes.ForEach(item => idLotes.Add(item.Id));
                model.RedesSociais.ForEach(item => idRedesSociais.Add(item.Id));
                
                var lotes = evento.Lotes.Where(
                    lote => !idLotes.Contains(lote.Id)
                    ).ToArray();
                
                var redesSociais = evento.RedesSociais.Where(
                    rede => !idLotes.Contains(rede.Id)
                    ).ToArray();

                if (lotes.Length > 0) {
                      _repository.DeleteRange(lotes);
                }

                if (redesSociais.Length > 0) {
                     _repository.DeleteRange(redesSociais);
                }

                _mapper.Map(model, evento);

                _repository.Update(evento);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/evento/{model.Id}", _mapper.Map<EventoDto>(evento));
                }

            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!" + ex.Message);
            }

            return BadRequest();

        }

        [HttpDelete("{EventoId}")]
        public async Task<IActionResult> Delete(int EventoId) //rota que vai retornar todos os resultados
        {
            try
            {
                // caso o Id passado por parametro nao encontrar um elemento
                var evento = await _repository.GetEventoAsyncById(EventoId, false);

                if (evento == null)
                {
                    return NotFound();
                }

                _repository.Delete(evento);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok();
                }

            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados Falhou!");
            }

            return BadRequest();

        }

    }
}