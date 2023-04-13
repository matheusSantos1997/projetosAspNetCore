using System.Linq;
using System.Threading.Tasks;
using GaleriaImagens.Business.DTOS;
using GaleriaImagens.Business.Models;
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

        public async Task<Usuario> Autenticacao(UsuarioLoginDTO user)
        {
            var usuario = await _context.Usuarios.Where(x => x.Email == user.Email).FirstOrDefaultAsync();

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(user.Senha, usuario.Senha);

            if(isValidPassword)
            {
                return usuario;
            }

            return null;
        }

        public async Task<Usuario> GetUsuarioByEmail(string email)
        {
            var emailUsuarioExiste = await _context.Usuarios.AsNoTracking()
                                                            .Include(u => u.Imagens)
                                                            .Where(u => u.Email == email).FirstOrDefaultAsync();


            return emailUsuarioExiste;
        }
    }
}