using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MP.ApiDotnet6.Application.Dtos;
using MP.ApiDotnet6.Application.Services.Interfaces;
using MP.ApiDotNet6.Domain.FiltersDb;

namespace MP.ApiDotNet6.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        [Route("PostAsync")]
        public async Task<IActionResult> PostAsync([FromBody]PersonDto personDto)
        {
            var result = await _personService.CreateAsync(personDto);

            if(result.IsSucess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPut]
        [Route("UpdateAsync")]
        public async Task<IActionResult> UpdateAsync([FromBody]PersonDto personDto)
        {
            var result = await _personService.UpdateAsync(personDto);
            if (result.IsSucess)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _personService.DeleteAsync(id);

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
            var result = await _personService.GetAsync();

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
            var result = await _personService.GetByIdAsync(id);

            if(result.IsSucess)
            {
                return Ok(result);
            }

            return NotFound(result);
        }

        [HttpGet]
        [Route("paged")]
        public async Task<IActionResult> GetPagedAsync([FromQuery]PersonFilterDb personFilterDb)
        {
            var result = await _personService.GetPagedAsync(personFilterDb);

            if(result.IsSucess) return Ok(result);

            return BadRequest(result);
        }
    }
}
