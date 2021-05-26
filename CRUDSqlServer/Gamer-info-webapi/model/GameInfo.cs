using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Gamer_info_webapi.model
{
    public class GameInfo : IGamerInfo
    {
        private GameDbContext context;
        
        // construtor
        public GameInfo(GameDbContext context)
        {
            this.context = context;
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Remove(entity);
        }
        public async Task<bool> saveChangesAsync()
        {
            bool results = await context.SaveChangesAsync() > 0;
            return (results);
        }

        public async Task<Usuario[]> GetAllUsuarioAsync(bool usuario = false)
        {
            IQueryable<Usuario> query = context.Usuario
                   .Include(g => g.IdGameNavigation);
            
            query = query.AsNoTracking()
                    .OrderBy(c => c.IdUsuario);

            return await query.ToArrayAsync(); // vai retornar a query com todos os eventos
        }

        public async Task<Usuario[]> GetAllUsuarioAsyncByNome(string nome, bool usuario)
        {
            IQueryable<Usuario> query = context.Usuario
                   .Include(g => g.IdGameNavigation);
            
            query = query.AsNoTracking()
                         .OrderBy(c => c.Nome)
                         .Where(c => c.Nome.ToLower().Contains(nome.ToLower()));
             
            return await query.ToArrayAsync();
            
        }
        public async Task<Usuario> GetUsuarioAsyncById(int IdUsuario, bool usuario)
        {
            IQueryable<Usuario> query = context.Usuario
                   .Include(g => g.IdGameNavigation);
            if(usuario) {
                query = query
                        .Include(u => u.Nome)
                        .Include(u => u.Email)
                        .Include(u => u.DataNasc)
                        .Include(u => u.Telefone)
                        .Include(u => u.Endereco)
                        .Include(u => u.Cep);
            }
            
            query = query.AsNoTracking()
                         .OrderBy(c => c.Nome)
                         .Where(c => c.IdUsuario == IdUsuario);

            return await query.FirstOrDefaultAsync();
             
        }

    }
}