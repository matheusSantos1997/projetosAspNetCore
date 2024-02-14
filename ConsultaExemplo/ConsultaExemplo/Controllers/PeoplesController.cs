using ConsultaExemplo.Models;
using ConsultaExemplo.PaginationItems;
using ConsultaExemplo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Text.Json;

namespace ConsultaExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        private readonly IPeopleRepository _peopleRepository;

        private readonly IInsertNewPeopleRepository _insertNewPeopleRepository;

        public PeoplesController(IPeopleRepository peopleRepository, IInsertNewPeopleRepository insertNewPeopleRepository)
        {
            _peopleRepository = peopleRepository;
            _insertNewPeopleRepository = insertNewPeopleRepository;
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult GetAllPeoples([FromQuery]Pagination pagination)
        {
            var peoples = _peopleRepository.AllPeoples(pagination);
            if (peoples == null) return NoContent();

            HttpContext.Response.Headers.Add("Pagination", JsonSerializer.Serialize(new
            {
                totalItems = peoples.TotalCount,
                currentPage = pagination.PageNumber,
                totalPages = (int)Math.Ceiling((double)peoples.TotalCount! / pagination.PageSize),
                pageSize = pagination.PageSize
            }));

            return Ok(peoples);
        }
        [HttpPost]
        [Route("Post")]
        public IActionResult PostPeople([FromBody]People people)
        {
            _insertNewPeopleRepository.AddPeople(people);

            return Ok(people);
        }

    }
}
