using System.Threading.Tasks;
using cadastroLivros.Model;
using cadastroLivros.Service;
using Microsoft.AspNetCore.Mvc;

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
            var books = await _booksService.GetAsync();

            return Ok(books);
        }

        [HttpGet("{id:length(24)}")]
        public async Task<IActionResult> GetById(string id)
        {
            var book = await _booksService.GetAsyncById(id);

            if(book == null) 
            {
               return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Book newBook)
        {
            await _booksService.CreateAsync(newBook);

            return CreatedAtAction(nameof(Get), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Book updatedBook)
        {
            var book = await _booksService.GetAsyncById(id);

            if (book == null)
            {
                return NotFound();
            }

            updatedBook.Id = book.Id;

           _booksService.UpdateAsync(id, updatedBook);

            return Ok(updatedBook);
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var book = await _booksService.GetAsyncById(id);

            if (book == null)
            {
                return NotFound();
            }

            _booksService.RemoveAsync(id);

            return Ok(new 
            {
                message = $"Deletado com sucesso!"
            });
        }
    }
}