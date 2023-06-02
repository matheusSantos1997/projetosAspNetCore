using crudDapperEfCore.Attributes;
using crudDapperEfCore.Controllers.Shared;
using crudDapperEfCore.Extensions;
using crudDapperEfCore.Models;
using crudDapperEfCore.Pagination;
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
    public class ClientesController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [CustomResponse(StatusCodes.Status200OK)]
        [Route("GetAllClientes")]
        [HttpGet]
        public async Task<IActionResult> GetAllClientes([FromQuery]PageParams pageParams)
        {
            try
            {
                var clientes = await _clienteService.ListarTodosClientes(pageParams);

                Response.AddPagination(clientes.CurrentPage, clientes.PageSize, clientes.TotalCount, clientes.TotalPages);

                return ResponseOk(clientes);
            }
            catch(Exception ex)
            {
                return ResponseInternalServerError(ex.Message);
            }
        }

        [CustomResponse(StatusCodes.Status200OK)]
        [Route("GetAllClientesByNome/GetByNome/{nome}")]
        [HttpGet]
        public async Task<IActionResult> GetAllClientesByNome(string nome, [FromQuery]PageParams pageParams)
        {
            try
            {
                var clientes = await _clienteService.ListarTodosClientesPorNome(nome, pageParams);

                Response.AddPagination(clientes.CurrentPage, clientes.PageSize, clientes.TotalCount, clientes.TotalPages);

                return ResponseOk(clientes);
            }
            catch(Exception ex)
            {
                return ResponseInternalServerError(ex.Message);
            }
        }

        [CustomResponse(StatusCodes.Status200OK)]
        [Route("GetClienteById/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetClienteById(long id)
        {
            try
            {
                var cliente = await _clienteService.ListarClientePorId(id);

                return ResponseOk(cliente);
            }
            catch(Exception ex)
            {
                return ResponseInternalServerError(ex.Message);
            }
        }

        [CustomResponse(StatusCodes.Status201Created)]
        [Route("InsertNewCliente")]
        [HttpPost]
        public async Task<IActionResult> InsertNewCliente(Cliente model)
        {
            try
            {
                var cliente = await _clienteService.AdicionarNovoCliente(model);

                if (cliente == null) return ResponseBadRequest();

                return ResponseCreated(cliente);
            }
            catch(Exception ex)
            {
                return ResponseInternalServerError(ex.Message);
            }
        }

        [CustomResponse(StatusCodes.Status200OK)]
        [Route("UpdateClientes/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateClientes(long id, Cliente model)
        {
            try
            {
                var cliente = await _clienteService.AtualizarCliente(id, model);

                if (cliente == null) return ResponseBadRequest();

                return ResponseOk(cliente);
            }
            catch(Exception ex)
            {
                return ResponseInternalServerError(ex.Message);
            }
        }

        [CustomResponse(StatusCodes.Status200OK)]
        [Route("DeleteCliente/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteCliente(long id)
        {
            try
            {
                var deleted = await _clienteService.DeletarCliente(id);

                if(deleted == false) return ResponseBadRequest();

                return ResponseOk(new { message = $"Cliente Deletado com sucesso." });
            }
            catch (Exception ex)
            {
                return ResponseInternalServerError(ex.Message);
            }
        }
    }
}
