using System.Linq;
using System.Threading.Tasks;
using GaleriaImagens.Business.Models;
using GaleriaImagens.Business.ViewModels;
using GaleriaImagens.Repository.Context;
using GaleriaImagens.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GaleriaImagens.Repository.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _context;

        public UsuarioRepository(DataContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<Usuario> GetUsuarioById(long id)
        {
            var usuario = await _context.Usuarios.AsNoTracking()
                                                  .Include(u => u.Imagens)
                                                  .OrderBy(u => u.Id)
                                                  .Where(u => u.Id == id)
                                                  .FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<Usuario> Autenticacao(UsuarioLogin user)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(x => x.Email == user.Email);

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.Senha, usuario.Senha);

            if(isValidPassword)
            {
                return usuario;
            }

            return null;
        }
        
    }
}