using ControleFinanceiro.BLL.Models;
using ControleFinanceiro.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleFinanceiro.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        private readonly IDespesaRepositorio _depesaRepositorio;

        public DespesasController(IDespesaRepositorio despesaRepositorio)
        {
            _depesaRepositorio = despesaRepositorio;
        }

        [HttpGet("PegarDespesasPeloUsuarioId/{usuarioId}")]
        public async Task<ActionResult<IEnumerable<Despesa>>> PegarDespesasPeloUsuarioId(string usuarioId)
        {
            return await _depesaRepositorio.PegarDespesaPeloUsuarioId(usuarioId).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Despesa>> GetDespesa(int id)
        {
            var despesa = await _depesaRepositorio.PegarPeloId(id);

            if (despesa == null)
            {
                return NotFound();
            }

            return Ok(despesa);
        }

        [HttpPost]
        public async Task<ActionResult<Despesa>> PostDespesa(Despesa despesa)
        {
            if (ModelState.IsValid)
            {
                await _depesaRepositorio.Inserir(despesa);

                return Ok(new
                {
                    mensagem = $"Despesa no valor de R$ {despesa.valor} criada com sucesso."
                });
            }

            return BadRequest(despesa);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Despesa>> PutDespesa(int id, Despesa despesa)
        {
            if (id != despesa.DespesaId)
                return BadRequest();

            if (ModelState.IsValid)
            {
                await _depesaRepositorio.Atualizar(despesa);

                return Ok(new
                {
                    mensagem = $"Despesa no valor de R$ {despesa.valor} Atualizada com sucesso."
                });
            }

            return BadRequest(despesa);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDespesa(int id)
        {
            var despesa = await _depesaRepositorio.PegarPeloId(id);

            if (despesa == null)
            {
                return NotFound();
            }

            await _depesaRepositorio.Excluir(despesa);

            return Ok(new
            {
                mensagem = $"Despesa no valor de R$ {despesa.valor} Excluida com sucesso."
            });
        }

        [HttpGet("FiltrarDespesas/{nomeCategoria}")]
        public async Task<IEnumerable<Despesa>> FiltrarDespesas(string nomeCategoria)
        {
             return await _depesaRepositorio.FiltrarDespesas(nomeCategoria).ToListAsync();
        }
    }
}
