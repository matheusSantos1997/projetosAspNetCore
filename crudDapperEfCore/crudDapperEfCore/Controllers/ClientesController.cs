using crudDapperEfCore.Models;
using crudDapperEfCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudDapperEfCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [Route("GetAllClientes")]
        [HttpGet]
        public async Task<IActionResult> GetAllClientes()
        {
            try
            {
                var clientes = await _clienteService.ListarTodosClientes();
                return Ok(clientes);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Route("GetAllClientesByNome/GetByNome/{nome}")]
        [HttpGet]
        public async Task<IActionResult> GetAllClientesByNome(string nome)
        {
            try
            {
                var clientes = await _clienteService.ListarTodosClientesPorNome(nome);
                return Ok(clientes);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Route("GetClienteById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetClienteById(long id)
        {
            try
            {
                var cliente = await _clienteService.ListarClientePorId(id);

                return Ok(cliente);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Route("InsertNewCliente")]
        [HttpPost]
        public async Task<IActionResult> InsertNewCliente(Cliente model)
        {
            try
            {
                var cliente = await _clienteService.AdicionarNovoCliente(model);

                if (cliente == null) return BadRequest(new { message = $"Erro ao tentar adicionar Cliente." });

                return Created($"/api/clientes/{model.Id}", cliente);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Route("UpdateClientes/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateClientes(long id, Cliente model)
        {
            try
            {
                var cliente = await _clienteService.AtualizarCliente(id, model);

                if (cliente == null) return BadRequest(new { message = $"Erro ao tentar atualizar cliente." });

                return Ok(cliente);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [Route("DeleteCliente/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteCliente(long id)
        {
            try
            {
                var deleted = await _clienteService.DeletarCliente(id);

                if(deleted == false) return BadRequest(new { message = $"Cliente não deletado." });

                return Ok(new { message = $"Cliente Deletado com sucesso." });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
