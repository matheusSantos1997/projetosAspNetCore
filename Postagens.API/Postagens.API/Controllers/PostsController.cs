using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Postagens.Application.Interfaces;
using Postagens.Domain.Dtos;
using Postagens.Domain.Models;

namespace Postagens.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;   
        }

        [HttpGet]
        [Route("PegarTodosPosts")]
        public async Task<IActionResult> PegarTodosPosts()
        {
            var posts = await _postService.ListarTodosPosts();

            if (!posts.Any()) return NoContent();

            return Ok(posts);
        }

        [HttpPost]
        [Route("CadastrarNovoPost")]
        public async Task<IActionResult> CadastrarNovoPost([FromBody]PostCreateDTO model)
        {
            var post = await _postService.CadastrarNovoPost(model);

            if(post == null) return BadRequest();

            return Created($"/api/posts/CadastrarNovoPost/{model.Id}", post);
        }
    }
}
