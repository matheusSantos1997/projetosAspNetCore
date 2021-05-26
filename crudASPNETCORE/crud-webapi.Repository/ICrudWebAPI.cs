using System.Threading.Tasks;
using crud_webapi.Domain;

namespace crud_webapi.Repository
{
    public interface ICrudWebAPI
    {
        void Add<T>(T entity) where T : class; // interface de adicionar

        void Update<T>(T entity) where T : class; // interface de atualizar

        void Delete<T>(T entity) where T : class; // interface de deletar

        Task<bool> SaveChangesAsync();

        Task<Usuario[]> GetAllUsuariosAsync(bool usuario);

        Task<Usuario> GetUsuarioAsyncById(int UsuarioId, bool usuario);



    }
}