using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProceduresStorage.API.Models;
using ProceduresStorage.API.Services;

namespace ProceduresStorage.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutosController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllProdutos() 
        {
             var produtos = await _produtoService.GetAllProdutos();

             if(produtos == null) return NotFound();

             return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProdutoById(int id) 
        {
             var produtos = await _produtoService.GetProdutoById(id);

             if(produtos == null) return NotFound();

             return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> InsertNewProduct(Produto model)
        {
             var produto = await _produtoService.AddProduto(model);

             if(produto == null) return BadRequest();

             return Created($"/api/eventos/{model.Id}", produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Produto model)
        {
            var produto = await _produtoService.UpdateProduto(id, model);

            if(produto == null) return BadRequest();

            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var produto = await _produtoService.DeleteProduto(id);

            return Ok(new { message = "produto deletado com sucesso!"});
        }
    }
}