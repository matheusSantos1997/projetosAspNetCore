using System.Threading.Tasks;
using ProEventos.Repository.Context;
using ProEventos.Repository.Interfaces;

namespace ProEventos.Repository.Repositories
{
    public class ProEventosGeneric : IProEventosGeneric
    {
        private readonly DataContext _context;
        
        public ProEventosGeneric(DataContext context)
        {
            _context = context;
        }
        
        public void Add<T>(T entity) where T : class
        {
            _context.AddAsync(entity);
        }

        public void Uptate<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
    }
}