using ControleFinanceiro.API.ViewModels;
using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrador")]
    public class FuncoesController : ControllerBase
    {
        private readonly IFuncaoRepositorio _funcaoRepositorio;

        public FuncoesController(IFuncaoRepositorio funcaoRepositorio)
        {
            _funcaoRepositorio = funcaoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Funcao>>> GetFuncoes()
        {
            return await _funcaoRepositorio.PegarTodos().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Funcao>> GetFuncao(string id)
        {
            var funcao = await _funcaoRepositorio.PegarPeloId(id);

            if (funcao == null)
            {
                return NotFound();
            }

            return Ok(funcao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFuncao(string id, FuncoesViewModel funcoes)
        {
            if (id != funcoes.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                Funcao funcao = new Funcao
                {
                    Id = funcoes.Id,
                    Name = funcoes.Name,
                    Descricao = funcoes.Descricao
                };

                await _funcaoRepositorio.AtualizarFuncao(funcao);

                return Ok(new { mensagem = $"Função {funcao.Name} atualizada com sucesso" });
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<Funcao>> PostFuncao(FuncoesViewModel funcoes)
        {
            // se os dados sao validos
            if (ModelState.IsValid)
            {
                Funcao funcao = new Funcao
                {
                    Name = funcoes.Name,
                    Descricao = funcoes.Descricao
                };

                await _funcaoRepositorio.AdicionarFuncao(funcao);

                return Ok(new { mensagem = $"Função {funcao.Name} adicionada com sucesso" });
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Funcao>> DeleteFuncao(string id)
        {
            var funcao = await _funcaoRepositorio.PegarPeloId(id);

            if(funcao == null)
            {
                return NotFound();
            }

            await _funcaoRepositorio.Excluir(funcao);

            return Ok(new { mensagem = $"Função {funcao.Name} excluida com sucesso" });
        }

        [HttpGet("FiltrarFuncoes/{nomeFuncao}")]
        public async Task<ActionResult<IEnumerable<Funcao>>> FiltrarFuncoes(string nomeFuncao)
        {
            return await _funcaoRepositorio.FiltrarFuncoes(nomeFuncao).ToListAsync();

        }
    }
}
