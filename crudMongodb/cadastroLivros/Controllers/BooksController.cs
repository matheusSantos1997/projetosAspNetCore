using System.Threading.Tasks;
using cadastroLivros.Model;
using cadastroLivros.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace cadastroLivros.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var books = await _booksService.GetAsync();

                return Ok(books);
            }
            catch (MongoException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro {ex.Message}");
            }
            
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetById(string id)
        {
            try
            {
                var book = await _booksService.GetAsyncById(id);

                if(book == null) 
                {
                   return NotFound();
                }

                return Ok(book);
            }
            catch (MongoException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro {ex.Message}");
            }
            
        }

        [HttpGet("getByName/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            try
            {
                var books = await _booksService.GetAsyncByName(name);

                if(books == null)
                {
                    return NotFound();
                }

                return Ok(books);
            }
            catch (MongoException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Book newBook)
        {
            try
            {
                await _booksService.CreateAsync(newBook);

                return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
            }
            catch (MongoException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro {ex.Message}");
            }
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Book updatedBook)
        {
            try
            {
                var book = await _booksService.GetAsyncById(id);

                if (book == null)
                {
                   return NotFound();
                }

                updatedBook.Id = book.Id;

                await _booksService.UpdateAsync(id, updatedBook);

                return Ok(updatedBook);
            }
            catch (MongoException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro {ex.Message}");
            }
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var book = await _booksService.GetAsyncById(id);

                if (book == null)
                {
                    return NotFound();
                }

                await _booksService.RemoveAsync(id);

                return Ok(new 
                {
                    message = $"Deletado com sucesso!"
                });
            }
            catch (MongoException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Erro {ex.Message}");
            }
        }
    }
}