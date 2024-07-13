using crudDapperEfCore.DBConnections;
using crudDapperEfCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace crudDapperEfCore.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly DataContext _context;

        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public void Adicionar<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Atualizar<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Attach<T>(T entity, EntityState state) where T : class
        {
            _context.Attach(entity);
            _context.Entry(entity).State = state;
        }

        public void Excluir<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> CommitAsync()
        {
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
    }
}
