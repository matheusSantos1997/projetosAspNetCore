using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotnet6.Application.Services;
using MP.ApiDotnet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.Validations;

namespace MP.ApiDotNet6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseService _purchaseService;

        public PurchaseController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody]PurchaseDto purchaseDto)
        {
            try
            {
                var result = await _purchaseService.CreateAsync(purchaseDto);

                if (result.IsSucess)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch (DomainValidationException ex)
            {
                var result = ResultService.Fail(ex.Message);
                return BadRequest(result);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _purchaseService.GetAsync();

            if(result.IsSucess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var reuslt = await _purchaseService.GetByIdAsync(id);

            if(reuslt.IsSucess) return Ok(reuslt);

            return BadRequest(reuslt);
        }

        [HttpPut]
        public async Task<IActionResult> EditAsync([FromBody] PurchaseDto purchaseDto)
        {
            try
            {
                var result = await _purchaseService.UpdateAsync(purchaseDto);
                if (result.IsSucess)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }
            catch(DomainValidationException ex)
            {
                var result = ResultService.Fail(ex.Message);
                return BadRequest(result);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var result = await _purchaseService.RemoveAsync(id);

            if (result.IsSucess) return Ok(result);

            return BadRequest(result);
        }
    }
}
