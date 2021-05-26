using System.Threading.Tasks;

namespace Gamer_info_webapi.model
{
    public interface IGamerInfo
    {
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
        Task<bool> saveChangesAsync();
        
        // Usuarios
        Task<Usuario[]> GetAllUsuarioAsyncByNome(string nome, bool usuario);
        Task<Usuario[]> GetAllUsuarioAsync(bool usuario);
        Task<Usuario> GetUsuarioAsyncById(int IdUsuario, bool usuario);

    }
}