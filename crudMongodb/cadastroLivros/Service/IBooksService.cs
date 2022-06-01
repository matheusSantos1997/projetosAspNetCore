using System.Collections.Generic;
using System.Threading.Tasks;
using cadastroLivros.Model;

namespace cadastroLivros.Service
{
    public interface IBooksService
    {
        Task<List<Book>> GetAsync();

        Task<Book> GetAsyncById(string id);

        Task<Book> GetAsyncByName(string name);

        Task CreateAsync(Book newBook);

        Task UpdateAsync(string id, Book updatedBook);

        Task RemoveAsync(string id);
    }
}