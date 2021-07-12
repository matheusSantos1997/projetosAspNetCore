using authenticationUsers.Application.Interfaces;
using AuthenticationUsers.Business.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationUsers.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            try
            {
                var posts = await _postService.GetAllPosts();
                
                if(posts == null)
                {
                    return NotFound("Not Found Posts.");
                }

                return Ok(posts);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving posts. Error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(long id)
        {
            try
            {
                var post = await _postService.GetPostById(id);

                if (post == null) return NotFound("Not Found Posts.");

                return Ok(post);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving posts. Error: {ex.Message}");
            }
        }

        [HttpGet("title/{title}")]
        [Authorize]
        public async Task<IActionResult> GetByTitle(string title)
        {
            try
            {
                var post = await _postService.GetAllPostsByTitle(title);

                if (post == null) return NotFound("Not Found Posts by title.");

                return Ok(post);

            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving posts. Error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Post model)
        {
            try
            {
                var post = await _postService.AddPost(model);

                if (post == null) return BadRequest("Error at add posts.");

                return Ok(post);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving posts. Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(long id, Post model)
        {
            try
            {
                var post = await _postService.UpdatePost(id, model);
                if (post == null) return BadRequest("Error at update posts.");

                return Ok(post);
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"error when retrieving posts. Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            try
            {
                var post = await _postService.DeletePost(id);

                if (post)
                {
                    return Ok("Post Deleted!");
                }
                else
                {
                    return BadRequest("Post is not deleted.");
                }
            }
            catch(Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                    $"error when retrieving posts. Error: { ex.Message }");
            }
        }
    }
}
