using System.Linq;
using System.Threading.Tasks;
using crud_webapi.Domain;
using Microsoft.EntityFrameworkCore;

namespace crud_webapi.Repository
{
    public class CrudWebAPI : ICrudWebAPI
    {
        private readonly CrudContext context;

        public CrudWebAPI(CrudContext _context)
        {
            // this.context = _context;
            context = _context;
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add(entity); // adiciona o registro
        }
        public void Update<T>(T entity) where T : class
        {
            context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            //se existe registro no banco de dados retorna e salva as mudanças
            bool results = await context.SaveChangesAsync() > 0;
            return (results); // salva mudanças
        }

        public async Task<Usuario> GetUsuarioAsyncById(int UsuarioId, bool usuario)
        {
            IQueryable<Usuario> query = context.Usuarios;

            if (usuario)
            {
                query = query
                      .Include(u => u.Nome)
                      .Include(u => u.Email)
                      .Include(u => u.Telefone);
            }

            query = query.AsNoTracking()
                    .OrderBy(u => u.Nome)
                    .Where(u => u.IdUsuario == UsuarioId);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Usuario[]> GetAllUsuariosAsync(bool b = false)
        {
            IQueryable<Usuario> query = context.Usuarios;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Nome);

            return await query.ToArrayAsync(); // vai retornar a query com todos os eventos
        }
    }
}