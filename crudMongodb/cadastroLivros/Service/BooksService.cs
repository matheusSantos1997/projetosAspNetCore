using System.Collections.Generic;
using System.Threading.Tasks;
using cadastroLivros.Connection;
using cadastroLivros.Model;
using MongoDB.Driver;

namespace cadastroLivros.Service
{
    public class BooksService : IBooksService
    {
         MongoDBContext _context = new MongoDBContext();

          public async Task<List<Book>> GetAsync() 
          {
              try
              {
                  // ordenando pelo nome
                 /* var filter = Builders<Book>.Filter.Empty;
                    var sort = Builders<Book>.Sort.Ascending("Name");
                   return await _context.Books.FindAsync(filter, new FindOptions<Book, Book>(){
                   Sort = sort
                   }).GetAwaiter().GetResult().ToListAsync(); */
                   return await _context.Books.FindAsync(b => true).GetAwaiter().GetResult().ToListAsync();
              }
              catch (MongoException ex)
              {
                  throw new MongoException(ex.Message);
              }
          }
          
          public async Task<Book> GetAsyncById(string id)
          {
              try
              {
                  return await _context.Books.FindAsync(x => x.Id.Equals(id)).GetAwaiter().GetResult().FirstOrDefaultAsync();
              }
              catch (MongoException ex)
              {
                  throw new MongoException(ex.Message);
              }
          }

          public async Task<Book> GetAsyncByName(string name)
          {
              try
              {
                  var filter = Builders<Book>.Filter.Where(x => x.BookName.ToLower().Contains(name.ToLower()));
                  var query = await _context.Books.FindAsync(filter);

                  foreach (var result in await query.ToListAsync())
                  {
                     return result;
                  }

                  return null;
              }
              catch (MongoException ex)
              {
                  throw new MongoException(ex.Message);
              }
          }

          public async Task CreateAsync(Book newBook) 
          {
              try
              {
                  await _context.Books.InsertOneAsync(newBook);
              }
              catch (MongoException ex)
              {
                  throw new MongoException(ex.Message);
              }
          }

          public async Task UpdateAsync(string id, Book updatedBook)
          {
              try
              {
                  await _context.Books.ReplaceOneAsync(x => x.Id.Equals(id), updatedBook);
              }
              catch (MongoException ex)
              {
                  throw new MongoException(ex.Message);
              }
          }

          public async Task RemoveAsync(string id)
          {
              try
              {
                  await _context.Books.DeleteOneAsync(x => x.Id.Equals(id));
              }
              catch (MongoException ex)
              {
                  throw new MongoException(ex.Message);
              }
          }
    }
}