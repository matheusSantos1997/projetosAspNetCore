using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pensamentos.Extensions;
using Pensamentos.Models;
using Pensamentos.Pagination;
using Pensamentos.Repository;

namespace Pensamentos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PensamentosController : ControllerBase
    {
        private readonly IPensamentoRepository _pensamentoRepository;

        public PensamentosController(IPensamentoRepository pensamentoRepository)
        {
            _pensamentoRepository= pensamentoRepository;
        }

        [HttpGet]
        [Route("PegarTodosPensamentos")]
        public IActionResult PegarTodosPensamentos([FromQuery] PageParams pageParams)
        {
            var pensamentos = _pensamentoRepository.PegarTodosPensamentos(pageParams);

            if (!pensamentos.Any())
            {
                return NoContent();
            }

            Response.AddPagination(pensamentos.CurrentPage, pensamentos.PageSize, pensamentos.TotalCount, pensamentos.TotalPages);

            // return ResponseOk(pensamentos);
            return Ok(pensamentos);
        }

        [HttpGet]
        [Route("PegarTodosPensamentosByAutoria/{conteudo}")]
        public IActionResult PegarTodosPensamentosByAutoria(string conteudo, [FromQuery] PageParams pageParams)
        {
            var pensamentos = _pensamentoRepository.PegarTodosPensamentosPorAutoria(conteudo, pageParams);

            if (!pensamentos.Any())
            {
                return NoContent();
            }

            Response.AddPagination(pensamentos.CurrentPage, pensamentos.PageSize, pensamentos.TotalCount, pensamentos.TotalPages);

            // return ResponseOk(pensamentos);
            return Ok(pensamentos);

        }

        [HttpGet]
        [Route("PegarTodosPensamentosFavoritos")]
        public IActionResult PegarTodosPensamentosFavoritos([FromQuery] PageParams pageParams)
        {
            var pensamentos = _pensamentoRepository.PegarTodosPensamentosFavoritos(pageParams);

            if (!pensamentos.Any())
            {
                return NoContent();
            }

            Response.AddPagination(pensamentos.CurrentPage, pensamentos.PageSize, pensamentos.TotalCount, pensamentos.TotalPages);

            // return ResponseOk(pensamentos);
            return Ok(pensamentos);
        }

        [HttpGet]
        [Route("PegarPensamentoPorId/{id}")]
        public IActionResult PegarPensamentoPorId(int id)
        {
            var pensamento = _pensamentoRepository.PegarPensamentoPorId(id);

            if(pensamento == null)
            {
                return NotFound(new { message = "Pensamento nao encontrado!" });
            }

            // return ResponseOk(pensamento);
            return Ok(pensamento);
        }

        [HttpPost]
        [Route("NovoPensamento")]
        public IActionResult NovoPensamento([FromBody]Pensamento? model)
        {
            _pensamentoRepository.AdicionarNovoPensamento(model);

            return Created($"/api/Pensamentos/NovoPensamento/{model.Id}", model);
            // return ResponseCreated(model);
        }

        [HttpPut]
        [Route("AtualizarPensamento/{id}")]
        public IActionResult AtualizarPensamento(int id, [FromBody]Pensamento model)
        {
            var pensamento = _pensamentoRepository.PegarPensamentoPorId(id);

            model.Id = pensamento.Id;

            if (pensamento == null) return BadRequest(new { message = "opa, algo deu errado ao tentar atualizar um pensamento" });

            _pensamentoRepository.AtualizarPensamento(id, model);

            // return ResponseOk(model);
            return Ok(model);
        }

        [HttpDelete]
        [Route("ExcluirPensamento/{id}")]
        public IActionResult ExcluirPensamento(int id)
        {
            var pensamento = _pensamentoRepository.PegarPensamentoPorId(id);

            if (pensamento == null) return NotFound(new { message = "Pensamento não encontrado para ser deletado!" });

            _pensamentoRepository.ExcluirPensamento(pensamento);

            // return ResponseOk(new { message = "Pensamento Deletado com sucesso!" });
            return Ok(new { message = "Pensamento Deletado com sucesso!" });
        }
    }
}
