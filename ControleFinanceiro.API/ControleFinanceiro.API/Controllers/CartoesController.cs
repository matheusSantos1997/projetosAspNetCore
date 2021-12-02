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
    public class CartoesController : ControllerBase
    {
        private readonly ICartaoRepositorio _cartaoRepositorio;

        private readonly IDespesaRepositorio _despesaRepositorio;

        public CartoesController(ICartaoRepositorio cartaoRepositorio, IDespesaRepositorio despesaRepositorio)
        {
            _cartaoRepositorio = cartaoRepositorio;
            _despesaRepositorio = despesaRepositorio;
        }

        [HttpGet("PegarCartoesPeloUsuarioId/{usuarioId}")]
        public async Task<IEnumerable<Cartao>> PegarCartoesPeloUsuarioId(string usuarioId)
        {
            return await _cartaoRepositorio.PegarCartoesPeloUsuarioId(usuarioId).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cartao>> GetCartao(int id)
        {
            Cartao cartao = await _cartaoRepositorio.PegarPeloId(id);

            return cartao;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartao(int id, Cartao cartao)
        {
            if(id != cartao.CartaoId)
            {
                return BadRequest("Cartões diferentes. Não foi possível atualizar");
            }

            if (ModelState.IsValid)
            {
                await _cartaoRepositorio.Atualizar(cartao);

                return Ok(new 
                { 
                   mensagem = $"Cartão número {cartao.Numero} atualizado com sucesso"
                });
            }

            return BadRequest(cartao);
        }

        [HttpPost]
        public async Task<IActionResult> PostCartao(Cartao cartao)
        {
            if (ModelState.IsValid)
            {
                await _cartaoRepositorio.Inserir(cartao);

                return Ok(new
                {
                    mensagem = $"Cartão número {cartao.Numero} criado com sucesso"
                });
            }

            return BadRequest(cartao);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarCartao(int id)
        {
            Cartao cartao = await _cartaoRepositorio.PegarPeloId(id);

            if (cartao == null)
            {
                return NotFound();
            }

            IEnumerable<Despesa> despesas = await _despesaRepositorio.PegarDespesasPeloCartaoId(cartao.CartaoId);

            _despesaRepositorio.ExcluirDespesas(despesas);

            await _cartaoRepositorio.Excluir(cartao);

            return Ok(new
            {
                mensagem = $"Cartão número {cartao.Numero} excluido com sucesso"
            });
        }

        [HttpGet("FiltrarCartoes/{numeroCartao}")]
        public async Task<IEnumerable<Cartao>> FiltrarCartoes(string numeroCartao)
        {
            return await _cartaoRepositorio.FiltrarCartoes(numeroCartao).ToListAsync();
        }
    }
}
