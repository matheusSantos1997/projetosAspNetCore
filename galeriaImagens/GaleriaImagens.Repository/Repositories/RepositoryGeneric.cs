using System.Threading.Tasks;
using GaleriaImagens.Repository.Context;
using GaleriaImagens.Repository.Interfaces;

namespace GaleriaImagens.Repository.Repositories
{
    public class RepositoryGeneric : IRepositoryGeneric
    {
        private readonly DataContext _context;

        public RepositoryGeneric(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool results = await _context.SaveChangesAsync() > 0;
            return results;
        }

        
    }
}