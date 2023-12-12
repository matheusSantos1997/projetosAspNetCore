using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotnet6.Application.Services.Interfaces;

namespace MP.ApiDotNet6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        [Route("PostAsync")]
        public async Task<IActionResult> PostAsync([FromBody] ProductDto productDto)
        {
            var result = await _productService.CreateAsync(productDto);

            if (result.IsSucess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        [Route("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody] ProductDto productDto)
        {
            var result = await _productService.UpdateAsync(productDto);

            if(result.IsSucess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _productService.RemoveAsync(id);

            if (result.IsSucess) 
            {
               return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        [Route("GetAsync")]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _productService.GetAsync();

            if(result.IsSucess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        [Route("GetByIdAsync/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await _productService.GetByIdAsync(id);

            if(result.IsSucess)
            {
                return Ok(result);
            }

            return NotFound(result);
        }

    }
}
