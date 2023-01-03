using crudDapperEfCore.DBConnections;
using crudDapperEfCore.Interfaces;
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

        public void Excluir<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
    }
}
