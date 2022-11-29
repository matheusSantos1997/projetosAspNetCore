using crudNhibernate.Model;
using crudNhibernate.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudNhibernate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductsController(NHibernate.ISession session)
        {
            _productRepository = new ProductRepository(session);
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var allProducts = await _productRepository.FindAll();

            if (allProducts == null) return NoContent();

            return Ok(allProducts);
        }

        [HttpGet]
        [Route("getAllByName/{name}")]
        public async Task<IActionResult> GetAllByName(string name)
        {
            var products = await _productRepository.FindByName(name);

            if (products == null) return NotFound();

            return Ok(products);
        }

        [HttpGet]
        [Route("getById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productRepository.FindById(id);

            if (product == null) return NotFound();

            return Ok(product);
        }

        [HttpPost]
        [Route("newProduct")]
        public async Task<IActionResult> NewProduct(Product product)
        {
            if(ModelState.IsValid)
            {
                await _productRepository.Add(product);

                return Created($"/api/products/newProduct/{product.Id}", product);
            }

            return BadRequest();
        }

        [HttpPut]
        [Route("updateProduct/{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product model)
        {
            if (id != model.Id) return NotFound();

            if(ModelState.IsValid)
            {
                await _productRepository.Update(model);
                return Ok(model);
            }

            return BadRequest();
        }

        [HttpDelete]
        [Route("deleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productRepository.FindById(id);

            if (product == null) return NotFound(new { message = "Product Id Was Not Found!" });

            await _productRepository.Remove(id);

            return Ok(new { message = "Product was deleted success!" });
        }
    }
}
