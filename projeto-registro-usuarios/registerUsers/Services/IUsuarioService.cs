using System.Collections.Generic;
using System.Threading.Tasks;
using registerUsers.Models;

namespace registerUsers.Services
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> GetAllUsers();

        Task<Usuario> GetUserById(int id);

        Task<List<Usuario>> GetUserByName(string name);

        Task<Usuario> InsertUser(Usuario model);

        Task<Usuario> UpdateUser(int id, Usuario model);

        Task<bool> DeleteUser(int id);
    }
}