using System.Collections.Generic;
using System.Threading.Tasks;
using cadastroLivros.Connection;
using cadastroLivros.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace cadastroLivros.Service
{
    public class BooksService
    {
          MongoDBContext _context = new MongoDBContext();

          public async Task<List<Book>> GetAsync() 
          {
              // ordenando pelo nome
             /* var filter = Builders<Book>.Filter.Empty;
              var sort = Builders<Book>.Sort.Ascending("Name");
              return await _context.Books.FindAsync(filter, new FindOptions<Book, Book>(){
                  Sort = sort
              }).GetAwaiter().GetResult().ToListAsync(); */
              return await _context.Books.FindAsync(b => true).GetAwaiter().GetResult().ToListAsync();
          }
          
          public async Task<Book> GetAsyncById(string id)
          {
              return await _context.Books.FindAsync(x => x.Id.Equals(id)).GetAwaiter().GetResult().FirstOrDefaultAsync();
          }

          public async Task CreateAsync(Book newBook) 
          {
              await _context.Books.InsertOneAsync(newBook);
          }

          public async void UpdateAsync(string id, Book updatedBook)
          {
              await _context.Books.ReplaceOneAsync(x => x.Id.Equals(id), updatedBook);
          }

          public async void RemoveAsync(string id)
          {
              await _context.Books.DeleteOneAsync(x => x.Id.Equals(id));
          }
          
    }
}